﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.CodeAnalysis;

namespace ICSharpCode.NRefactory6.CSharp
{
	#if NR6
	public
	#endif
	static class SignatureComparer
	{
		readonly static Type typeInfo;
		readonly static object instance;
		readonly static MethodInfo haveSameSignatureMethod;
		readonly static MethodInfo haveSameSignature2Method;
		readonly static MethodInfo haveSameSignature3Method;
		readonly static MethodInfo haveSameSignature4Method;
		readonly static MethodInfo haveSameSignature5Method;

		static SignatureComparer()
		{
			typeInfo = Type.GetType("Microsoft.CodeAnalysis.Shared.Utilities.SignatureComparer" + ReflectionNamespaces.WorkspacesAsmName, true);

			instance = typeInfo.GetField("Instance", BindingFlags.Public | BindingFlags.Static).GetValue(null);

			haveSameSignatureMethod = typeInfo.GetMethod("HaveSameSignature", new[] { typeof(IList<IParameterSymbol>), typeof(IList<IParameterSymbol>) });
			haveSameSignature2Method = typeInfo.GetMethod("HaveSameSignature", new[] { typeof(IPropertySymbol), typeof(IPropertySymbol), typeof(bool) });
			haveSameSignature3Method = typeInfo.GetMethod("HaveSameSignature", new[] { typeof(ISymbol), typeof(ISymbol), typeof(bool) });
			haveSameSignature4Method = typeInfo.GetMethod("HaveSameSignature", new[] { typeof(IMethodSymbol), typeof(IMethodSymbol), typeof(bool), typeof(bool), typeof(bool) });
			haveSameSignature5Method = typeInfo.GetMethod("HaveSameSignature", new[] { typeof(IList<IParameterSymbol>), typeof(IList<IParameterSymbol>), typeof(bool), typeof(bool) });
			haveSameSignatureAndConstraintsAndReturnTypeAndAccessorsMethod = typeInfo.GetMethod ("HaveSameSignatureAndConstraintsAndReturnTypeAndAccessors", BindingFlags.Public | BindingFlags.Instance);
		}

		public static bool HaveSameSignature (IList<IParameterSymbol> parameters1, IList<IParameterSymbol> parameters2)
		{
			return (bool)haveSameSignatureMethod.Invoke(instance, new object[] { parameters1, parameters2 });
		}

		public static bool HaveSameSignature (IPropertySymbol property1, IPropertySymbol property2, bool caseSensitive)
		{
			return (bool)haveSameSignature2Method.Invoke(instance, new object[] { property1, property2, caseSensitive });
		}

		public static bool HaveSameSignature (ISymbol symbol1, ISymbol symbol2, bool caseSensitive)
		{
			return (bool)haveSameSignature3Method.Invoke(instance, new object[] { symbol1, symbol2, caseSensitive });
		}

		public static bool HaveSameSignature (IMethodSymbol method1, IMethodSymbol method2, bool caseSensitive, bool compareParameterName = false, bool isParameterCaseSensitive = false)
		{
			return (bool)haveSameSignature4Method.Invoke(instance, new object[] { method1, method2, caseSensitive, compareParameterName, isParameterCaseSensitive });
		}

		public static bool HaveSameSignature (IList<IParameterSymbol> parameters1, IList<IParameterSymbol> parameters2, bool compareParameterName, bool isCaseSensitive)
		{
			return (bool)haveSameSignature5Method.Invoke(instance, new object[] { parameters1, parameters2, compareParameterName, isCaseSensitive });
		}

		readonly static MethodInfo haveSameSignatureAndConstraintsAndReturnTypeAndAccessorsMethod;
		public static bool HaveSameSignatureAndConstraintsAndReturnTypeAndAccessors(ISymbol symbol1, ISymbol symbol2, bool caseSensitive)
		{
			return (bool)haveSameSignatureAndConstraintsAndReturnTypeAndAccessorsMethod.Invoke(instance, new object[] { symbol1, symbol2, caseSensitive });
		}
	}
}