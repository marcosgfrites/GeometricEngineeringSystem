﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace ICSharpCode.NRefactory6.CSharp
{
	#if NR6
	public
	#endif
	static class SymbolKeyResolutionExtensions
	{
		public static ISymbol GetAnySymbol(this SymbolKeyResolution resolution)
		{
			if (resolution.Symbol != null)
			{
				return resolution.Symbol;
			}

			if (resolution.CandidateSymbols.Length > 0)
			{
				return resolution.CandidateSymbols[0];
			}

			return null;
		}

		public static IEnumerable<ISymbol> GetAllSymbols(this SymbolKeyResolution resolution)
		{
			return GetAllSymbolsWorker(resolution).Distinct();
		}

		private static IEnumerable<ISymbol> GetAllSymbolsWorker(SymbolKeyResolution resolution)
		{
			if (resolution.Symbol != null)
			{
				yield return resolution.Symbol;
			}

			foreach (var symbol in resolution.CandidateSymbols)
			{
				yield return symbol;
			}
		}
	}
}
