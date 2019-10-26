﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace ICSharpCode.NRefactory6.CSharp
{
	#if NR6
	public
	#endif
	static class ITypeParameterSymbolExtensions
	{
		public static INamedTypeSymbol GetNamedTypeSymbolConstraint(this ITypeParameterSymbol typeParameter)
		{
			return typeParameter.ConstraintTypes.Select(GetNamedTypeSymbol).WhereNotNull().FirstOrDefault();
		}

		private static INamedTypeSymbol GetNamedTypeSymbol(ITypeSymbol type)
		{
			return type is INamedTypeSymbol
				? (INamedTypeSymbol)type
					: type is ITypeParameterSymbol
				? GetNamedTypeSymbolConstraint((ITypeParameterSymbol)type)
					: null;
		}
	}
}
