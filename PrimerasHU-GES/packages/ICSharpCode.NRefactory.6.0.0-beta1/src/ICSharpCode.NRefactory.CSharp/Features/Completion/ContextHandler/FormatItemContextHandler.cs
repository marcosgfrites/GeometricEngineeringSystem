﻿//
// FormatItemContextHandler.cs
//
// Author:
//       Mike Krüger <mkrueger@xamarin.com>
//
// Copyright (c) 2015 Xamarin Inc. (http://xamarin.com)
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
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis;

namespace ICSharpCode.NRefactory6.CSharp.Completion
{
	class FormatItemContextHandler : CompletionContextHandler
	{
		public override bool IsTriggerCharacter (Microsoft.CodeAnalysis.Text.SourceText text, int position)
		{
			var ch = text [position];
			return ch == ':' || ch == '"';
		}

		protected async override Task<IEnumerable<ICompletionData>> GetItemsWorkerAsync (CompletionResult completionResult, CompletionEngine engine, CompletionContext completionContext, CompletionTriggerInfo info, CancellationToken cancellationToken)
		{
			var ctx = await completionContext.GetSyntaxContextAsync (engine.Workspace, cancellationToken).ConfigureAwait(false);
			var document = completionContext.Document;
			var position = completionContext.Position;
			var semanticModel = await completionContext.GetSemanticModelAsync (cancellationToken).ConfigureAwait (false);

			if (ctx.TargetToken.Parent != null && ctx.TargetToken.Parent.Parent != null && 
			    ctx.TargetToken.Parent.Parent.IsKind(SyntaxKind.Argument)) {

				if (ctx.TargetToken.Parent == null || !ctx.TargetToken.Parent.IsKind(SyntaxKind.StringLiteralExpression) ||
				    ctx.TargetToken.Parent.Parent == null || !ctx.TargetToken.Parent.Parent.IsKind(SyntaxKind.Argument) ||
				    ctx.TargetToken.Parent.Parent.Parent == null || !ctx.TargetToken.Parent.Parent.Parent.IsKind(SyntaxKind.ArgumentList) ||
				    ctx.TargetToken.Parent.Parent.Parent.Parent == null || !ctx.TargetToken.Parent.Parent.Parent.Parent.IsKind(SyntaxKind.InvocationExpression)) {
					return Enumerable.Empty<ICompletionData> ();
				}
				var formatArgument = GetFormatItemNumber(document, position);
				var invocationExpression = ctx.TargetToken.Parent.Parent.Parent.Parent as InvocationExpressionSyntax;
				var symbolInfo = semanticModel.GetSymbolInfo(invocationExpression);
				return GetFormatCompletionData(engine, semanticModel, invocationExpression, formatArgument, symbolInfo.Symbol);
			}

			return Enumerable.Empty<ICompletionData> ();
		}


		static readonly DateTime curDate = DateTime.Now;

		IEnumerable<ICompletionData> GenerateNumberFormatitems(CompletionEngine engine, bool isFloatingPoint)
		{
			yield return engine.Factory.CreateFormatItemCompletionData(this, "D", "decimal", 123);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "D5", "decimal", 123);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "C", "currency", 123);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "C0", "currency", 123);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "E", "exponential", 1.23E4);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "E2", "exponential", 1.234);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "e2", "exponential", 1.234);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "F", "fixed-point", 123.45);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "F1", "fixed-point", 123.45);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "G", "general", 1.23E+56);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "g2", "general", 1.23E+56);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "N", "number", 12345.68);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "N1", "number", 12345.68);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "P", "percent", 12.34);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "P1", "percent", 12.34);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "R", "round-trip", 0.1230000001);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "X", "hexadecimal", 1234);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "x8", "hexadecimal", 1234);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "0000", "custom", 123);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "####", "custom", 123);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "##.###", "custom", 1.23);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "##.000", "custom", 1.23);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "## 'items'", "custom", 12);
		}

		IEnumerable<ICompletionData> GenerateDateTimeFormatitems(CompletionEngine engine)
		{
			yield return engine.Factory.CreateFormatItemCompletionData(this, "D", "long date", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "d", "short date", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "F", "full date long", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "f", "full date short", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "G", "general long", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "g", "general short", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "M", "month", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "O", "ISO 8601", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "R", "RFC 1123", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "s", "sortable", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "T", "long time", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "t", "short time", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "U", "universal full", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "u", "universal sortable", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "Y", "year month", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "yy-MM-dd", "custom", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "yyyy MMMMM dd", "custom", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "yy-MMM-dd ddd", "custom", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "yyyy-M-d dddd", "custom", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "hh:mm:ss t z", "custom", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "hh:mm:ss tt zz", "custom", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "HH:mm:ss tt zz", "custom", curDate);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "HH:m:s tt zz", "custom", curDate);

		}

		[Flags]
		enum TestEnum
		{
			EnumCaseName = 0,
			Flag1 = 1,
			Flag2 = 2,
			Flags
		}

		IEnumerable<ICompletionData> GenerateEnumFormatitems(CompletionEngine engine)
		{
			yield return engine.Factory.CreateFormatItemCompletionData(this, "G", "string value", TestEnum.EnumCaseName);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "F", "flags value", TestEnum.Flags);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "D", "integer value", TestEnum.Flags);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "X", "hexadecimal", TestEnum.Flags);
		}

		IEnumerable<ICompletionData> GenerateTimeSpanFormatitems(CompletionEngine engine)
		{
			yield return engine.Factory.CreateFormatItemCompletionData(this, "c", "invariant", new TimeSpan(0, 1, 23, 456));
			yield return engine.Factory.CreateFormatItemCompletionData(this, "G", "general long", new TimeSpan(0, 1, 23, 456));
			yield return engine.Factory.CreateFormatItemCompletionData(this, "g", "general short", new TimeSpan(0, 1, 23, 456));
		}

		static Guid defaultGuid = Guid.NewGuid();

		IEnumerable<ICompletionData> GenerateGuidFormatitems(CompletionEngine engine)
		{
			yield return engine.Factory.CreateFormatItemCompletionData(this, "N", "digits", defaultGuid);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "D", "hypens", defaultGuid);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "B", "braces", defaultGuid);
			yield return engine.Factory.CreateFormatItemCompletionData(this, "P", "parentheses", defaultGuid);
		}


		static int GetFormatItemNumber(Document document, int offset)
		{
			int number = 0;
			var o = offset - 2;
			var text = document.GetTextAsync().Result;
			while (o > 0) {
				char ch = text[o];
				if (ch == '{')
					return number;
				if (!char.IsDigit(ch))
					break;
				number = number * 10 + ch - '0';
				o--;
			}
			return -1;
		}

		IEnumerable<ICompletionData> GetFormatCompletionForType(CompletionEngine engine, ITypeSymbol type)
		{
			if (type == null) {
				return GenerateNumberFormatitems (engine, false)
					.Concat (GenerateDateTimeFormatitems (engine))
					.Concat (GenerateTimeSpanFormatitems (engine))
					.Concat (GenerateEnumFormatitems (engine))
					.Concat (GenerateGuidFormatitems (engine));
			}

			switch (type.ToString()) {
				case "long":
				case "System.Int64":
				case "ulong":
				case "System.UInt64":
				case "int":
				case "System.Int32":
				case "uint":
				case "System.UInt32":
				case "short":
				case "System.Int16":
				case "ushort":
				case "System.UInt16":
				case "byte":
				case "System.Byte":
				case "sbyte":
				case "System.SByte":
				return GenerateNumberFormatitems(engine, false);
				case "float":
				case "System.Single":
				case "double":
				case "System.Double":
				case "decimal":
				case "System.Decimal":
				return GenerateNumberFormatitems(engine, true);
				case "System.Enum":
				return GenerateEnumFormatitems(engine);
				case "System.DateTime":
				return GenerateDateTimeFormatitems(engine);
				case "System.TimeSpan":
				return GenerateTimeSpanFormatitems(engine);
				case "System.Guid":
				return GenerateGuidFormatitems(engine);
			}
			return CompletionResult.Empty;
		}

		IEnumerable<ICompletionData> GetFormatCompletionData(CompletionEngine engine, SemanticModel semanticModel, InvocationExpressionSyntax invocationExpression, int formatArgument, ISymbol symbol)
		{
			var ma = invocationExpression.Expression as MemberAccessExpressionSyntax;

			if (ma != null && ma.Name.ToString () == "ToString") {
				return GetFormatCompletionForType(engine, symbol != null ? symbol.ContainingType : null);
			} else {
				var method = symbol as IMethodSymbol;
				if (method == null)
					return Enumerable.Empty<ICompletionData> ();

				ExpressionSyntax fmtArgumets;
				IList<ExpressionSyntax> args;
				if (FormatStringHelper.TryGetFormattingParameters(semanticModel, invocationExpression, out fmtArgumets, out args, null)) {
					ITypeSymbol type = null;
					if (formatArgument  + 1< args.Count) {
						var invokeArgument = semanticModel.GetSymbolInfo(args[formatArgument + 1]);
						if (invokeArgument.Symbol != null)
							type = invokeArgument.Symbol.GetReturnType();
					}

					return GetFormatCompletionForType(engine, type);
				}
			}
			return Enumerable.Empty<ICompletionData> ();
		}
	}
}