﻿using CppAst;
using System.Collections.Generic;
using System.Text;

class CSModule
{
	public string            module;
	public List<CppFunction> functions = new List<CppFunction>();

	public CSModule(string module) => this.module = module;
	
	public void AddFunction(CppFunction fn)
	{
		functions.Add(fn);
	}

	///////////////////////////////////////////

	static void BuildRawFunction(StringBuilder fnText, Dictionary<string, string> delegateText, CppFunction fn)
	{
		SKType     returnType = CSTypes.TypeName(fn.ReturnType, "", null);
		SKTextType textType   = returnType.text;

		string line  = $"{returnType.RawName,-20}{fn.Name,-20}(";
		bool   first = true;
		int    i     = 0;
		foreach (var p in fn.Parameters)
		{
			if (first) { first = false; }
			else { line += ", "; }
			SKType paramType;

			// Something kinda weird happening here with function pointer
			// params, but this code seems to work just fine.
			if (p.Type.TypeKind == CppTypeKind.Pointer && ((CppPointerType)p.Type).ElementType.TypeKind == CppTypeKind.Function)
			{
				CppFunctionType fnParam  = (CppFunctionType)((CppPointerType)p.Type).ElementType;
				CppParameter    subParam = fnParam.Parameters[i];
				paramType = CSTypes.TypeName(subParam.Type, subParam.Name, delegateText);
				if (paramType.fixedArray != 0) line += $"[MarshalAs(UnmanagedType.LPArray, SizeConst = {paramType.fixedArray})] ";
				line += $"{paramType.RawName} {subParam.Name}";
			}
			else
			{
				paramType = CSTypes.TypeName(p.Type, p.Name, delegateText);
				if (paramType.fixedArray != 0) line += $"[MarshalAs(UnmanagedType.LPArray, SizeConst = {paramType.fixedArray})] ";
				line += $"{paramType.RawName} {p.Name}";
			}
			if (paramType.text != SKTextType.None) textType = paramType.text;
			i+=1;
		}
		line += ");";

		string charSet = textType switch
		{
			SKTextType.None  => "",
			SKTextType.Ascii => ", CharSet = ascii",
			SKTextType.Utf8  => "",
			SKTextType.Utf16 => ", CharSet = utf16",
		};
		line = $"[DllImport(dll, CallingConvention = call{charSet,-17})] public static extern " + line;
		fnText.AppendLine(line);
	}

	///////////////////////////////////////////

	public void BuildRawModule(StringBuilder builder, Dictionary<string, string> delegates, string indent)
	{
		builder.Append($"\r\n{indent}///////////////////////////////////////////\r\n\r\n");
		for (int i = 0; i < functions.Count; i++)
		{
			builder.Append(indent);
			BuildRawFunction(builder, delegates, functions[i]);
		}
	}
}