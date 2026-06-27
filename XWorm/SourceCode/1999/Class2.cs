using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000004 RID: 4
[HideModuleName]
[GeneratedCode("MyTemplate", "14.0.0.0")]
[StandardModule]
internal sealed class Class2
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000006 RID: 6 RVA: 0x0000459C File Offset: 0x0000279C
	[HelpKeyword("My.Computer")]
	internal static Class1 Ⴓ
	{
		get
		{
			return (Class1)Class2.class4_0.method_0();
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000007 RID: 7 RVA: 0x000045BC File Offset: 0x000027BC
	[HelpKeyword("My.Application")]
	internal static Class0 Ⴓ
	{
		get
		{
			return (Class0)Class2.class4_1.method_0();
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000008 RID: 8 RVA: 0x000045DC File Offset: 0x000027DC
	[HelpKeyword("My.User")]
	internal static User Ⴐ
	{
		get
		{
			return (User)Class2.RwFkYkHfQu.method_0();
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000009 RID: 9 RVA: 0x000045FC File Offset: 0x000027FC
	[HelpKeyword("My.WebServices")]
	internal static Class2.Class3 Ⴓ
	{
		get
		{
			return (Class2.Class3)Class2.class4_2.method_0();
		}
	}

	// Token: 0x04000001 RID: 1
	private static readonly Class2.Class4<Class1> class4_0 = new Class2.Class4<Class1>();

	// Token: 0x04000002 RID: 2
	private static readonly Class2.Class4<Class0> class4_1 = new Class2.Class4<Class0>();

	// Token: 0x04000003 RID: 3
	private static readonly Class2.Class4<User> RwFkYkHfQu = new Class2.Class4<User>();

	// Token: 0x04000004 RID: 4
	private static readonly Class2.Class4<Class2.Class3> class4_2 = new Class2.Class4<Class2.Class3>();

	// Token: 0x02000005 RID: 5
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		// Token: 0x0600000A RID: 10 RVA: 0x0000231B File Offset: 0x0000051B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000461C File Offset: 0x0000281C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00004634 File Offset: 0x00002834
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class2.Class3);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00004650 File Offset: 0x00002850
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00004668 File Offset: 0x00002868
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			T t;
			if (gparam_0 == null)
			{
				t = new T();
			}
			else
			{
				t = gparam_0;
			}
			return t;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00004688 File Offset: 0x00002888
		private void method_1<KuTwsefkhuSxrEasxJE>(ref KuTwsefkhuSxrEasxJE gparam_0)
		{
			gparam_0 = default(KuTwsefkhuSxrEasxJE);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002329 File Offset: 0x00000529
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
		}
	}

	// Token: 0x02000006 RID: 6
	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4<T> where T : new()
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000046A4 File Offset: 0x000028A4
		internal T method_0()
		{
			if (Class2.Class4<T>.gparam_0 == null)
			{
				Class2.Class4<T>.gparam_0 = new T();
			}
			return Class2.Class4<T>.gparam_0;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002329 File Offset: 0x00000529
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002331 File Offset: 0x00000531
		internal static bool smethod_0()
		{
			return Class2.Class4<T>.object_0 == null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000233B File Offset: 0x0000053B
		internal static object smethod_1()
		{
			return Class2.Class4<T>.object_0;
		}

		// Token: 0x04000005 RID: 5
		[ThreadStatic]
		private static T gparam_0;

		// Token: 0x04000006 RID: 6
		internal static object object_0;
	}
}
