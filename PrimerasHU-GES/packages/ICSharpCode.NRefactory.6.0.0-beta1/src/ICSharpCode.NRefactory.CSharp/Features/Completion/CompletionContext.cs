﻿//
// CompletionContext.cs
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

using Microsoft.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using ICSharpCode.NRefactory6.CSharp.Completion;
using System.Linq;

namespace ICSharpCode.NRefactory6.CSharp
{
    public class CompletionContext
	{
		readonly Document document;

		public Document Document {
			get {
				return document;
			}
		}

		SemanticModel semanticModel;

		internal async Task<SemanticModel> GetSemanticModelAsync (CancellationToken cancellationToken = default (CancellationToken)) 
		{
			if (semanticModel == null)
				semanticModel = await document.GetSemanticModelAsync (cancellationToken);
			return semanticModel;
		}

		readonly int position;
		public int Position {
			get {
				return position;
			}
		}

		SyntaxContext syntaxContext;
		internal Task<SyntaxContext> GetSyntaxContextAsync  (Workspace workspace, CancellationToken cancellationToken = default (CancellationToken)) 
		{
			if (syntaxContext == null)
				syntaxContext = SyntaxContext.Create(workspace, document, semanticModel, position, cancellationToken);
			return Task.FromResult (syntaxContext);
		}

		IEnumerable<CompletionContextHandler> additionalContextHandlers;

		/// <summary>
		/// Adds completion context handlers to the given context.
		/// </summary>
		public IEnumerable<CompletionContextHandler> AdditionalContextHandlers {
			get {
				return additionalContextHandlers ?? Enumerable.Empty<CompletionContextHandler> ();
			}
			set {
				additionalContextHandlers = value;
			}
		}

		/// <summary>
		/// If false no default handlers will be used and only the AdditionalContextHandlers will run.
		/// </summary>
		public bool UseDefaultContextHandlers { get; set; } = true;

		public CompletionContext (Document document, int position, SemanticModel semanticModel  = null)
		{
			this.document = document;
			this.semanticModel = semanticModel;
			this.position = position;
		}
	}
}