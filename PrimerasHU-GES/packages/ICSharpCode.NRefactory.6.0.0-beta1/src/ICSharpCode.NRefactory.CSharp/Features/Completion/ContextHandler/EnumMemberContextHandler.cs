//
// EnumMemberContextHandler.cs
//
// Author:
//       Mike Krüger <mkrueger@xamarin.com>
//
// Copyright (c) 2014 Xamarin Inc. (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.Recommendations;
using Microsoft.CodeAnalysis;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp;

using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CodeAnalysis.Options;

namespace ICSharpCode.NRefactory6.CSharp.Completion
{

//	public class CompletionEngineCache
//	{
//		public List<INamespace>  namespaces;
//		public ICompletionData[] importCompletion;
//	}
	
	class EnumMemberContextHandler : CompletionContextHandler
	{
		public override bool IsCommitCharacter (ICompletionData completionItem, char ch, string textTypedSoFar)
		{
			// Only commit on dot.
			return ch == '.';
		}

		public override bool IsTriggerCharacter(SourceText text, int position)
		{
			// Bring up on space or at the start of a word, or after a ( or [.
			//
			// Note: we don't want to bring this up after traditional enum operators like & or |.
			// That's because we don't like the experience where the enum appears directly after the
			// operator.  Instead, the user normally types <space> and we will bring up the list
			// then.
			var ch = text[position];
			return
				ch == ' ' ||
				ch == '[' ||
				ch == '(' ||
				(/*options.GetOption(CompletionOptions.TriggerOnTypingLetters, LanguageNames.CSharp) && CompletionUtilities.*/IsStartingNewWord(text, position));
		}

		protected async override Task<IEnumerable<ICompletionData>> GetItemsWorkerAsync (CompletionResult completionResult, CompletionEngine engine, CompletionContext completionContext, CompletionTriggerInfo info, CancellationToken cancellationToken)
		{
			var ctx = await completionContext.GetSyntaxContextAsync (engine.Workspace, cancellationToken).ConfigureAwait(false);
			var model = await completionContext.GetSemanticModelAsync (cancellationToken).ConfigureAwait (false);
			var tree = await completionContext.Document.GetSyntaxTreeAsync(cancellationToken).ConfigureAwait(false);
			if (tree.IsInNonUserCode(completionContext.Position, cancellationToken))
				return Enumerable.Empty<ICompletionData> ();

			var token = tree.FindTokenOnLeftOfPosition(completionContext.Position, cancellationToken);
			if (token.IsMandatoryNamedParameterPosition())
				return Enumerable.Empty<ICompletionData> ();
			var result = new List<ICompletionData> ();

			foreach (var _type in ctx.InferredTypes) {
				var type = _type;
				if (type.OriginalDefinition.SpecialType == SpecialType.System_Nullable_T) {
					type = type.GetTypeArguments().FirstOrDefault();
					if (type == null)
						continue;
				}

				if (type.TypeKind != TypeKind.Enum)
					continue;
				if (!type.IsEditorBrowsable ())
					continue;

				// Does type have any aliases?
				ISymbol alias = await type.FindApplicableAlias(completionContext.Position, model, cancellationToken).ConfigureAwait(false);

				if (string.IsNullOrEmpty(completionResult.DefaultCompletionString))
					completionResult.DefaultCompletionString = type.Name;

				result.Add (engine.Factory.CreateSymbolCompletionData(this, type, type.ToMinimalDisplayString(model, completionContext.Position, SymbolDisplayFormat.CSharpErrorMessageFormat)));
				foreach (IFieldSymbol field in type.GetMembers().OfType<IFieldSymbol>()) {
					if (field.DeclaredAccessibility == Accessibility.Public && (field.IsConst || field.IsStatic)) {
						result.Add (engine.Factory.CreateEnumMemberCompletionData(this, alias, field));
					}
				}
			}
			return result;
		}
	}

}
