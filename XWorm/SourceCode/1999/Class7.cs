using System;
using System.Reflection;

// Token: 0x02000018 RID: 24
internal class Class7
{
	// Token: 0x06000079 RID: 121 RVA: 0x000077A0 File Offset: 0x000059A0
	internal static void smethod_0(int typemdt)
	{
		Type type = Class7.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo methodInfo = (MethodInfo)Class7.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, methodInfo));
		}
	}

	// Token: 0x04000039 RID: 57
	internal static Module module_0 = typeof(Class7).Assembly.ManifestModule;

	// Token: 0x02000019 RID: 25
	// (Invoke) Token: 0x0600007D RID: 125
	internal delegate void Delegate2(object o);
}
