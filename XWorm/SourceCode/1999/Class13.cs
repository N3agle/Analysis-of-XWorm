using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

// Token: 0x0200002B RID: 43
internal class Class13
{
	// Token: 0x06000152 RID: 338 RVA: 0x00002AED File Offset: 0x00000CED
	internal static object[] smethod_0()
	{
		return new object[1];
	}

	// Token: 0x06000153 RID: 339 RVA: 0x0000A650 File Offset: 0x00008850
	internal static object[] smethod_1<T>(int int_1, object[] object_1, object object_2, ref T gparam_0)
	{
		Class13.Class19 @class = null;
		object obj = Class13.object_0;
		lock (obj)
		{
			if (!Class13.bool_0)
			{
				Class13.bool_0 = true;
				Class13.smethod_4();
			}
			if (Class13.class19_0[int_1] != null)
			{
				@class = Class13.class19_0[int_1];
			}
			else
			{
				Class13.binaryReader_0.BaseStream.Position = (long)Class13.int_0[int_1];
				@class = new Class13.Class19();
				Module module = typeof(Class13).Module;
				int num = Class13.smethod_6(Class13.binaryReader_0);
				int num2 = Class13.smethod_6(Class13.binaryReader_0);
				int num3 = Class13.smethod_6(Class13.binaryReader_0);
				int num4 = Class13.smethod_6(Class13.binaryReader_0);
				@class.methodBase_0 = module.ResolveMethod(num);
				ParameterInfo[] parameters = @class.methodBase_0.GetParameters();
				@class.class15_0 = new Class13.Class15[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					Type type = parameters[i].ParameterType;
					Class13.Class15 class2 = new Class13.Class15();
					class2.bool_0 = type.IsByRef;
					class2.int_0 = i;
					@class.class15_0[i] = class2;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					Class13.Enum2 @enum;
					if (type == typeof(string))
					{
						@enum = (Class13.Enum2)14;
					}
					else if (type == typeof(byte))
					{
						@enum = (Class13.Enum2)2;
					}
					else if (type == typeof(sbyte))
					{
						@enum = (Class13.Enum2)1;
					}
					else if (type == typeof(short))
					{
						@enum = (Class13.Enum2)3;
					}
					else if (type == typeof(ushort))
					{
						@enum = (Class13.Enum2)4;
					}
					else if (type == typeof(int))
					{
						@enum = (Class13.Enum2)5;
					}
					else if (type == typeof(uint))
					{
						@enum = (Class13.Enum2)6;
					}
					else if (type == typeof(long))
					{
						@enum = (Class13.Enum2)7;
					}
					else if (type == typeof(ulong))
					{
						@enum = (Class13.Enum2)8;
					}
					else if (type == typeof(float))
					{
						@enum = (Class13.Enum2)9;
					}
					else if (type == typeof(double))
					{
						@enum = (Class13.Enum2)10;
					}
					else if (type == typeof(bool))
					{
						@enum = (Class13.Enum2)11;
					}
					else if (type == typeof(IntPtr))
					{
						@enum = (Class13.Enum2)12;
					}
					else if (type == typeof(UIntPtr))
					{
						@enum = (Class13.Enum2)13;
					}
					else if (type == typeof(char))
					{
						@enum = (Class13.Enum2)15;
					}
					else
					{
						@enum = (Class13.Enum2)0;
					}
					class2.enum2_0 = @enum;
				}
				@class.list_1 = new List<Class13.Class16>(num2);
				for (int j = 0; j < num2; j++)
				{
					int num5 = Class13.smethod_6(Class13.binaryReader_0);
					Class13.Class16 class3 = new Class13.Class16();
					class3.type_0 = null;
					if (num5 >= 0 && num5 < 50)
					{
						class3.enum2_0 = (Class13.Enum2)(num5 & 31);
						class3.bool_0 = (num5 & 32) > 0;
					}
					class3.int_0 = j;
					@class.list_1.Add(class3);
				}
				@class.list_2 = new List<Class13.Class17>(num3);
				for (int k = 0; k < num3; k++)
				{
					int num6 = Class13.smethod_6(Class13.binaryReader_0);
					int num7 = Class13.smethod_6(Class13.binaryReader_0);
					Class13.Class17 class4 = new Class13.Class17();
					class4.int_0 = num6;
					class4.int_1 = num7;
					Class13.Class18 class5 = new Class13.Class18();
					class4.class18_0 = class5;
					num6 = Class13.smethod_6(Class13.binaryReader_0);
					num7 = Class13.smethod_6(Class13.binaryReader_0);
					int num8 = Class13.smethod_6(Class13.binaryReader_0);
					class5.int_0 = num6;
					class5.int_1 = num7;
					class5.int_3 = num8;
					if (num8 == 0)
					{
						class5.type_0 = module.ResolveType(Class13.smethod_6(Class13.binaryReader_0));
					}
					else if (num8 == 1)
					{
						class5.int_2 = Class13.smethod_6(Class13.binaryReader_0);
					}
					else
					{
						Class13.smethod_6(Class13.binaryReader_0);
					}
					@class.list_2.Add(class4);
				}
				@class.list_2.Sort(new Comparison<Class13.Class17>(Class13.Class42<T>.<>9.method_0));
				@class.list_0 = new List<Class13.Class14>(num4);
				for (int l = 0; l < num4; l++)
				{
					Class13.Class14 class6 = new Class13.Class14();
					byte b = Class13.binaryReader_0.ReadByte();
					class6.enum4_0 = (Class13.Enum4)b;
					if (b >= 176)
					{
						throw new Exception();
					}
					int num9 = (int)Class13.byte_0[(int)b];
					if (num9 == 0)
					{
						class6.object_0 = null;
					}
					else
					{
						object obj2;
						switch (num9)
						{
						case 1:
							obj2 = Class13.smethod_6(Class13.binaryReader_0);
							break;
						case 2:
							obj2 = Class13.binaryReader_0.ReadInt64();
							break;
						case 3:
							obj2 = Class13.binaryReader_0.ReadSingle();
							break;
						case 4:
							obj2 = Class13.binaryReader_0.ReadDouble();
							break;
						case 5:
						{
							int num10 = Class13.smethod_6(Class13.binaryReader_0);
							int[] array = new int[num10];
							for (int m = 0; m < num10; m++)
							{
								array[m] = Class13.smethod_6(Class13.binaryReader_0);
							}
							obj2 = array;
							break;
						}
						default:
							throw new Exception();
						}
						class6.object_0 = obj2;
					}
					@class.list_0.Add(class6);
				}
				Class13.class19_0[int_1] = @class;
			}
		}
		Class13.Class22 class7 = new Class13.Class22();
		class7.class19_0 = @class;
		ParameterInfo[] parameters2 = @class.methodBase_0.GetParameters();
		bool flag2 = false;
		int num11 = 0;
		if (@class.methodBase_0 is MethodInfo && ((MethodInfo)@class.methodBase_0).ReturnType != typeof(void))
		{
			flag2 = true;
		}
		if (@class.methodBase_0.IsStatic)
		{
			class7.class24_0 = new Class13.Class24[parameters2.Length];
			for (int n = 0; n < parameters2.Length; n++)
			{
				Type parameterType = parameters2[n].ParameterType;
				class7.class24_0[n] = Class13.Class24.smethod_1(parameterType, object_1[n]);
				if (parameterType.IsByRef)
				{
					num11++;
				}
			}
		}
		else
		{
			class7.class24_0 = new Class13.Class24[parameters2.Length + 1];
			if (@class.methodBase_0.DeclaringType.IsValueType)
			{
				class7.class24_0[0] = new Class13.Class35(new Class13.Class36(object_2), @class.methodBase_0.DeclaringType);
			}
			else
			{
				class7.class24_0[0] = new Class13.Class36(object_2);
			}
			for (int num12 = 0; num12 < parameters2.Length; num12++)
			{
				Type parameterType2 = parameters2[num12].ParameterType;
				if (parameterType2.IsByRef)
				{
					class7.class24_0[num12 + 1] = Class13.Class24.smethod_1(parameterType2, object_1[num12]);
					num11++;
				}
				else
				{
					class7.class24_0[num12 + 1] = Class13.Class24.smethod_1(parameterType2, object_1[num12]);
				}
			}
		}
		class7.class24_1 = new Class13.Class24[@class.list_1.Count];
		for (int num13 = 0; num13 < @class.list_1.Count; num13++)
		{
			Class13.Class16 class8 = @class.list_1[num13];
			switch (class8.enum2_0)
			{
			case (Class13.Enum2)0:
				class7.class24_1[num13] = null;
				break;
			case (Class13.Enum2)1:
			case (Class13.Enum2)2:
			case (Class13.Enum2)3:
			case (Class13.Enum2)4:
			case (Class13.Enum2)5:
			case (Class13.Enum2)6:
			case (Class13.Enum2)11:
			case (Class13.Enum2)15:
				class7.class24_1[num13] = new Class13.Class26(0, class8.enum2_0);
				break;
			case (Class13.Enum2)7:
			case (Class13.Enum2)8:
				class7.class24_1[num13] = new Class13.Class27(0L, class8.enum2_0);
				break;
			case (Class13.Enum2)9:
			case (Class13.Enum2)10:
				class7.class24_1[num13] = new Class13.Class29(0.0, class8.enum2_0);
				break;
			case (Class13.Enum2)12:
				class7.class24_1[num13] = new Class13.Class28(IntPtr.Zero);
				break;
			case (Class13.Enum2)13:
				class7.class24_1[num13] = new Class13.Class28(UIntPtr.Zero);
				break;
			case (Class13.Enum2)14:
				class7.class24_1[num13] = null;
				break;
			case (Class13.Enum2)16:
				class7.class24_1[num13] = new Class13.Class36(null);
				break;
			}
		}
		try
		{
			class7.method_0();
		}
		finally
		{
			class7.method_1();
		}
		int num14 = 0;
		if (flag2)
		{
			num14 = 1;
		}
		num14 += num11;
		object[] array2 = new object[num14];
		if (flag2)
		{
			array2[0] = null;
		}
		if (@class.methodBase_0 is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)@class.methodBase_0;
			if (methodInfo.ReturnType != typeof(void) && class7.class24_2 != null)
			{
				array2[0] = class7.class24_2.vmethod_4(methodInfo.ReturnType);
			}
		}
		if (num11 > 0)
		{
			int num15 = 0;
			if (flag2)
			{
				num15++;
			}
			for (int num16 = 0; num16 < parameters2.Length; num16++)
			{
				Type type2 = parameters2[num16].ParameterType;
				if (type2.IsByRef)
				{
					type2 = type2.GetElementType();
					if (class7.class24_0[num16] != null)
					{
						if (@class.methodBase_0.IsStatic)
						{
							array2[num15] = class7.class24_0[num16].vmethod_4(type2);
						}
						else
						{
							array2[num15] = class7.class24_0[num16 + 1].vmethod_4(type2);
						}
					}
					else
					{
						array2[num15] = null;
					}
					num15++;
				}
			}
		}
		if (!@class.methodBase_0.IsStatic && @class.methodBase_0.DeclaringType.IsValueType)
		{
			gparam_0 = (T)((object)class7.class24_0[0].vmethod_4(@class.methodBase_0.DeclaringType));
		}
		return array2;
	}

	// Token: 0x06000154 RID: 340 RVA: 0x0000B030 File Offset: 0x00009230
	internal static object[] smethod_2(int int_1, object[] object_1, object object_2)
	{
		int num = 0;
		return Class13.smethod_1<int>(int_1, object_1, object_2, ref num);
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00002AF5 File Offset: 0x00000CF5
	internal static object[] smethod_3<T>(int int_1, object[] object_1, ref T gparam_0)
	{
		return Class13.smethod_1<T>(int_1, object_1, gparam_0, ref gparam_0);
	}

	// Token: 0x06000156 RID: 342 RVA: 0x0000B04C File Offset: 0x0000924C
	internal static void smethod_4()
	{
		if (Class13.int_0 == null)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class13).Assembly.GetManifestResourceStream("sb6HtpxcbSgdpMvxne.VNAbTJVGIjK9T7Tm2R"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			binaryReader.Close();
			Class13.smethod_5(array);
		}
	}

	// Token: 0x06000157 RID: 343 RVA: 0x0000B0B0 File Offset: 0x000092B0
	internal static void smethod_5(byte[] byte_1)
	{
		Class13.binaryReader_0 = new BinaryReader(new MemoryStream(byte_1));
		Class13.byte_0 = new byte[255];
		int num = Class13.smethod_6(Class13.binaryReader_0);
		for (int i = 0; i < num; i++)
		{
			int num2 = (int)Class13.binaryReader_0.ReadByte();
			Class13.byte_0[num2] = Class13.binaryReader_0.ReadByte();
		}
		num = Class13.smethod_6(Class13.binaryReader_0);
		Class13.list_0 = new List<string>(num);
		for (int j = 0; j < num; j++)
		{
			Class13.list_0.Add(Encoding.Unicode.GetString(Class13.binaryReader_0.ReadBytes(Class13.smethod_6(Class13.binaryReader_0))));
		}
		num = Class13.smethod_6(Class13.binaryReader_0);
		Class13.class19_0 = new Class13.Class19[num];
		Class13.int_0 = new int[num];
		for (int k = 0; k < num; k++)
		{
			Class13.class19_0[k] = null;
			Class13.int_0[k] = Class13.smethod_6(Class13.binaryReader_0);
		}
		int num3 = (int)Class13.binaryReader_0.BaseStream.Position;
		for (int l = 0; l < num; l++)
		{
			int num4 = Class13.int_0[l];
			Class13.int_0[l] = num3;
			num3 += num4;
		}
	}

	// Token: 0x06000158 RID: 344 RVA: 0x0000B1E4 File Offset: 0x000093E4
	internal static int smethod_6(BinaryReader binaryReader_1)
	{
		bool flag = false;
		uint num = (uint)binaryReader_1.ReadByte();
		uint num2 = 0U | (num & 63U);
		if ((num & 64U) != 0U)
		{
			flag = true;
		}
		if (num < 128U)
		{
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
		else
		{
			int num3 = 0;
			for (;;)
			{
				uint num4 = (uint)binaryReader_1.ReadByte();
				num2 |= (num4 & 127U) << 7 * num3 + 6;
				if (num4 < 128U)
				{
					break;
				}
				num3++;
			}
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
	}

	// Token: 0x04000068 RID: 104
	internal static Class13.Class19[] class19_0 = null;

	// Token: 0x04000069 RID: 105
	internal static int[] int_0 = null;

	// Token: 0x0400006A RID: 106
	internal static List<string> list_0;

	// Token: 0x0400006B RID: 107
	private static BinaryReader binaryReader_0;

	// Token: 0x0400006C RID: 108
	private static byte[] byte_0;

	// Token: 0x0400006D RID: 109
	private static bool bool_0 = false;

	// Token: 0x0400006E RID: 110
	private static object object_0 = new object();

	// Token: 0x0200002C RID: 44
	[StructLayout(LayoutKind.Explicit)]
	public struct Struct5
	{
		// Token: 0x0400006F RID: 111
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x04000070 RID: 112
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x04000071 RID: 113
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x04000072 RID: 114
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x04000073 RID: 115
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x04000074 RID: 116
		[FieldOffset(0)]
		public int int_0;
	}

	// Token: 0x0200002D RID: 45
	private class Class26 : Class13.Class25
	{
		// Token: 0x0600015B RID: 347 RVA: 0x00002B28 File Offset: 0x00000D28
		internal override void zhnXqoJuKJ(Class13.Class24 class24_0)
		{
			this.struct5_0 = ((Class13.Class26)class24_0).struct5_0;
			this.enum2_0 = ((Class13.Class26)class24_0).enum2_0;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002B4C File Offset: 0x00000D4C
		internal override void vmethod_2(Class13.Class24 class24_0)
		{
			this.zhnXqoJuKJ(class24_0);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002B55 File Offset: 0x00000D55
		public Class26(bool bool_0)
		{
			this.enum5_0 = (Class13.Enum5)1;
			if (!bool_0)
			{
				this.struct5_0.int_0 = 0;
			}
			else
			{
				this.struct5_0.int_0 = 1;
			}
			this.enum2_0 = (Class13.Enum2)11;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002B89 File Offset: 0x00000D89
		public Class26(Class13.Class26 class26_0)
		{
			this.enum5_0 = class26_0.enum5_0;
			this.struct5_0.int_0 = class26_0.struct5_0.int_0;
			this.enum2_0 = class26_0.enum2_0;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002BBF File Offset: 0x00000DBF
		public override Class13.Class25 vmethod_71()
		{
			return new Class13.Class26(this);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002BC7 File Offset: 0x00000DC7
		public Class26(int int_0)
		{
			this.enum5_0 = (Class13.Enum5)1;
			this.struct5_0.int_0 = int_0;
			this.enum2_0 = (Class13.Enum2)5;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002BE9 File Offset: 0x00000DE9
		public Class26(uint uint_0)
		{
			this.enum5_0 = (Class13.Enum5)1;
			this.struct5_0.uint_0 = uint_0;
			this.enum2_0 = (Class13.Enum2)6;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002C0B File Offset: 0x00000E0B
		public Class26(int int_0, Class13.Enum2 enum2_1)
		{
			this.enum5_0 = (Class13.Enum5)1;
			this.struct5_0.int_0 = int_0;
			this.enum2_0 = enum2_1;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002C2D File Offset: 0x00000E2D
		public Class26(uint uint_0, Class13.Enum2 enum2_1)
		{
			this.enum5_0 = (Class13.Enum5)1;
			this.struct5_0.uint_0 = uint_0;
			this.enum2_0 = enum2_1;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000B24C File Offset: 0x0000944C
		public override bool vmethod_10()
		{
			Class13.Enum2 @enum = this.enum2_0;
			switch (@enum)
			{
			case (Class13.Enum2)1:
			case (Class13.Enum2)3:
			case (Class13.Enum2)5:
			case (Class13.Enum2)7:
				goto IL_0046;
			case (Class13.Enum2)2:
			case (Class13.Enum2)4:
			case (Class13.Enum2)6:
				break;
			default:
				if (@enum == (Class13.Enum2)11)
				{
					goto IL_0046;
				}
				if (@enum == (Class13.Enum2)15)
				{
					goto IL_0046;
				}
				break;
			}
			return this.struct5_0.uint_0 == 0U;
			IL_0046:
			return this.struct5_0.int_0 == 0;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002C4F File Offset: 0x00000E4F
		public override bool vmethod_11()
		{
			return !this.vmethod_10();
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000B2B0 File Offset: 0x000094B0
		public override Class13.Class24 vmethod_12(Class13.Enum2 enum2_1)
		{
			switch (enum2_1)
			{
			case (Class13.Enum2)1:
				return this.vmethod_14();
			case (Class13.Enum2)2:
				return this.vmethod_15();
			case (Class13.Enum2)3:
				return this.vmethod_16();
			case (Class13.Enum2)4:
				return this.vmethod_17();
			case (Class13.Enum2)5:
				return this.vmethod_18();
			case (Class13.Enum2)6:
				return this.vmethod_19();
			case (Class13.Enum2)11:
				return this.vmethod_13();
			case (Class13.Enum2)15:
				return this.method_5();
			case (Class13.Enum2)16:
				return this.vmethod_71();
			}
			throw new Exception(((Class13.Enum6)4).ToString());
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000B35C File Offset: 0x0000955C
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 != null && Nullable.GetUnderlyingType(type_0) != null)
			{
				type_0 = Nullable.GetUnderlyingType(type_0);
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum2_0)
				{
				case (Class13.Enum2)1:
					return this.struct5_0.sbyte_0;
				case (Class13.Enum2)2:
					return this.struct5_0.byte_0;
				case (Class13.Enum2)3:
					return this.struct5_0.short_0;
				case (Class13.Enum2)4:
					return this.struct5_0.ushort_0;
				case (Class13.Enum2)5:
					return this.struct5_0.int_0;
				case (Class13.Enum2)6:
					return this.struct5_0.uint_0;
				case (Class13.Enum2)7:
					return (long)this.struct5_0.int_0;
				case (Class13.Enum2)8:
					return (ulong)this.struct5_0.uint_0;
				case (Class13.Enum2)11:
					return this.vmethod_11();
				case (Class13.Enum2)15:
					return (char)this.struct5_0.int_0;
				}
				return this.struct5_0.int_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct5_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct5_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct5_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct5_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct5_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct5_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_10();
			}
			if (type_0 == typeof(long))
			{
				return (long)this.struct5_0.int_0;
			}
			if (type_0 == typeof(ulong))
			{
				return (ulong)this.struct5_0.uint_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct5_0.int_0;
			}
			if (type_0 == typeof(IntPtr))
			{
				return new IntPtr(this.struct5_0.int_0);
			}
			if (type_0 == typeof(UIntPtr))
			{
				return new UIntPtr(this.struct5_0.uint_0);
			}
			if (type_0.IsEnum)
			{
				return this.method_4(type_0);
			}
			throw new Class13.Exception1();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000B6A0 File Offset: 0x000098A0
		internal object method_4(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct5_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct5_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct5_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct5_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct5_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct5_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, (long)this.struct5_0.int_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, (ulong)this.struct5_0.uint_0);
			}
			if (underlyingType == typeof(char))
			{
				return Enum.ToObject(type_0, (ushort)this.struct5_0.int_0);
			}
			return Enum.ToObject(type_0, this.struct5_0.int_0);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002C5A File Offset: 0x00000E5A
		public override Class13.Class26 vmethod_13()
		{
			return new Class13.Class26((!this.vmethod_10()) ? 1 : 0);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002C6A File Offset: 0x00000E6A
		internal override bool vmethod_7()
		{
			return this.vmethod_11();
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002C72 File Offset: 0x00000E72
		public override Class13.Class26 vmethod_14()
		{
			return new Class13.Class26((int)this.struct5_0.sbyte_0, (Class13.Enum2)1);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002C85 File Offset: 0x00000E85
		public Class13.Class26 method_5()
		{
			return new Class13.Class26(this.struct5_0.int_0, (Class13.Enum2)15);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002C99 File Offset: 0x00000E99
		public override Class13.Class26 vmethod_15()
		{
			return new Class13.Class26((uint)this.struct5_0.byte_0, (Class13.Enum2)2);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002CAC File Offset: 0x00000EAC
		public override Class13.Class26 vmethod_16()
		{
			return new Class13.Class26((int)this.struct5_0.short_0, (Class13.Enum2)3);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002CBF File Offset: 0x00000EBF
		public override Class13.Class26 vmethod_17()
		{
			return new Class13.Class26((uint)this.struct5_0.ushort_0, (Class13.Enum2)4);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002CD2 File Offset: 0x00000ED2
		public override Class13.Class26 vmethod_18()
		{
			return new Class13.Class26(this.struct5_0.int_0, (Class13.Enum2)5);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002CE5 File Offset: 0x00000EE5
		public override Class13.Class26 vmethod_19()
		{
			return new Class13.Class26(this.struct5_0.uint_0, (Class13.Enum2)6);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public override Class13.Class27 vmethod_20()
		{
			return new Class13.Class27((long)this.struct5_0.int_0, (Class13.Enum2)7);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002D0C File Offset: 0x00000F0C
		public override Class13.Class27 vmethod_21()
		{
			return new Class13.Class27((ulong)this.struct5_0.uint_0, (Class13.Enum2)8);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002D20 File Offset: 0x00000F20
		public override Class13.Class26 vmethod_22()
		{
			return this.vmethod_14();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002D28 File Offset: 0x00000F28
		public override Class13.Class26 vmethod_23()
		{
			return this.vmethod_16();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002D30 File Offset: 0x00000F30
		public override Class13.Class26 vmethod_24()
		{
			return this.vmethod_18();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002D38 File Offset: 0x00000F38
		public override Class13.Class27 WdeXooypfm()
		{
			return this.vmethod_20();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002D40 File Offset: 0x00000F40
		public override Class13.Class26 vmethod_25()
		{
			return this.vmethod_15();
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002D48 File Offset: 0x00000F48
		public override Class13.Class26 vmethod_26()
		{
			return this.vmethod_17();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002D50 File Offset: 0x00000F50
		public override Class13.Class26 vmethod_27()
		{
			return this.vmethod_19();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002D58 File Offset: 0x00000F58
		public override Class13.Class27 vmethod_28()
		{
			return this.vmethod_21();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002D60 File Offset: 0x00000F60
		public override Class13.Class26 vmethod_29()
		{
			return new Class13.Class26((int)(checked((sbyte)this.struct5_0.int_0)), (Class13.Enum2)1);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002D74 File Offset: 0x00000F74
		public override Class13.Class26 vmethod_30()
		{
			return new Class13.Class26((int)(checked((sbyte)this.struct5_0.uint_0)), (Class13.Enum2)1);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002D88 File Offset: 0x00000F88
		public override Class13.Class26 vmethod_31()
		{
			return new Class13.Class26((int)(checked((short)this.struct5_0.int_0)), (Class13.Enum2)3);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002D9C File Offset: 0x00000F9C
		public override Class13.Class26 vmethod_32()
		{
			return new Class13.Class26((int)(checked((short)this.struct5_0.uint_0)), (Class13.Enum2)3);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002CD2 File Offset: 0x00000ED2
		public override Class13.Class26 vmethod_33()
		{
			return new Class13.Class26(this.struct5_0.int_0, (Class13.Enum2)5);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002DB0 File Offset: 0x00000FB0
		public override Class13.Class26 vmethod_34()
		{
			return new Class13.Class26(checked((int)this.struct5_0.uint_0), (Class13.Enum2)5);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public override Class13.Class27 vmethod_35()
		{
			return new Class13.Class27((long)this.struct5_0.int_0, (Class13.Enum2)7);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002DC4 File Offset: 0x00000FC4
		public override Class13.Class27 vmethod_36()
		{
			return new Class13.Class27((long)((ulong)this.struct5_0.uint_0), (Class13.Enum2)7);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002DD8 File Offset: 0x00000FD8
		public override Class13.Class26 vmethod_37()
		{
			return new Class13.Class26((int)(checked((byte)this.struct5_0.int_0)), (Class13.Enum2)2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002DEC File Offset: 0x00000FEC
		public override Class13.Class26 vmethod_38()
		{
			return new Class13.Class26((int)(checked((byte)this.struct5_0.uint_0)), (Class13.Enum2)2);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002E00 File Offset: 0x00001000
		public override Class13.Class26 vmethod_39()
		{
			return new Class13.Class26((int)(checked((ushort)this.struct5_0.int_0)), (Class13.Enum2)4);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002E14 File Offset: 0x00001014
		public override Class13.Class26 vmethod_40()
		{
			return new Class13.Class26((int)(checked((ushort)this.struct5_0.uint_0)), (Class13.Enum2)4);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002E28 File Offset: 0x00001028
		public override Class13.Class26 vmethod_41()
		{
			return new Class13.Class26(checked((uint)this.struct5_0.int_0), (Class13.Enum2)6);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002CE5 File Offset: 0x00000EE5
		public override Class13.Class26 vmethod_42()
		{
			return new Class13.Class26(this.struct5_0.uint_0, (Class13.Enum2)6);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002E3C File Offset: 0x0000103C
		public override Class13.Class27 vmethod_43()
		{
			return new Class13.Class27(checked((ulong)this.struct5_0.int_0), (Class13.Enum2)8);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002D0C File Offset: 0x00000F0C
		public override Class13.Class27 vmethod_44()
		{
			return new Class13.Class27((ulong)this.struct5_0.uint_0, (Class13.Enum2)8);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002E50 File Offset: 0x00001050
		public override Class13.Class29 vmethod_45()
		{
			return new Class13.Class29((float)this.struct5_0.int_0);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002E63 File Offset: 0x00001063
		public override Class13.Class29 vmethod_46()
		{
			return new Class13.Class29((double)this.struct5_0.int_0);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002E76 File Offset: 0x00001076
		public override Class13.Class29 NkkgOoOrdR()
		{
			return new Class13.Class29(this.struct5_0.uint_0);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002E8A File Offset: 0x0000108A
		public override Class13.Class28 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.WdeXooypfm().struct6_0.long_0);
			}
			return new Class13.Class28((long)this.vmethod_24().struct5_0.int_0);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002EC0 File Offset: 0x000010C0
		public override Class13.Class28 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_28().struct6_0.ulong_0);
			}
			return new Class13.Class28((ulong)this.vmethod_27().struct5_0.uint_0);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002EF6 File Offset: 0x000010F6
		public override Class13.Class28 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_35().struct6_0.long_0);
			}
			return new Class13.Class28((long)this.vmethod_33().struct5_0.int_0);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002F2C File Offset: 0x0000112C
		public override Class13.Class28 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_43().struct6_0.ulong_0);
			}
			return new Class13.Class28((ulong)this.vmethod_41().struct5_0.uint_0);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002F62 File Offset: 0x00001162
		public override Class13.Class28 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_36().struct6_0.long_0);
			}
			return new Class13.Class28((long)this.vmethod_34().struct5_0.int_0);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002F98 File Offset: 0x00001198
		public override Class13.Class28 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_44().struct6_0.ulong_0);
			}
			return new Class13.Class28((ulong)this.vmethod_42().struct5_0.uint_0);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000B814 File Offset: 0x00009A14
		public override Class13.Class24 vmethod_53()
		{
			Class13.Enum2 @enum = this.enum2_0;
			switch (@enum)
			{
			case (Class13.Enum2)1:
			case (Class13.Enum2)3:
			case (Class13.Enum2)5:
				goto IL_0043;
			case (Class13.Enum2)2:
			case (Class13.Enum2)4:
				break;
			default:
				if (@enum == (Class13.Enum2)11)
				{
					goto IL_0043;
				}
				if (@enum == (Class13.Enum2)15)
				{
					goto IL_0043;
				}
				break;
			}
			return new Class13.Class26((int)(-(int)((ulong)this.struct5_0.uint_0)));
			IL_0043:
			return new Class13.Class26(-this.struct5_0.int_0);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000B878 File Offset: 0x00009A78
		public override Class13.Class24 vmethod_54(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.int_0 + ((Class13.Class26)class24_0).struct5_0.int_0);
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_54(this);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000B8DC File Offset: 0x00009ADC
		public override Class13.Class24 vmethod_55(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(checked(this.struct5_0.int_0 + ((Class13.Class26)class24_0).struct5_0.int_0));
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_55(this);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000B940 File Offset: 0x00009B40
		public override Class13.Class24 vmethod_56(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(checked(this.struct5_0.uint_0 + ((Class13.Class26)class24_0).struct5_0.uint_0));
			}
			if (class24_0.epLymgDpIC())
			{
				return ((Class13.Class28)class24_0).vmethod_56(this);
			}
			throw new Class13.Exception1();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		public override Class13.Class24 vmethod_57(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.int_0 - ((Class13.Class26)class24_0).struct5_0.int_0);
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).egfAmGpeTE(this);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000BA08 File Offset: 0x00009C08
		public override Class13.Class24 vmethod_58(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(checked(this.struct5_0.int_0 - ((Class13.Class26)class24_0).struct5_0.int_0));
			}
			if (class24_0.epLymgDpIC())
			{
				return ((Class13.Class28)class24_0).method_5(this);
			}
			throw new Class13.Exception1();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000BA6C File Offset: 0x00009C6C
		public override Class13.Class24 vmethod_59(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(checked(this.struct5_0.uint_0 - ((Class13.Class26)class24_0).struct5_0.uint_0));
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).method_6(this);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000BAD0 File Offset: 0x00009CD0
		public override Class13.Class24 vmethod_60(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.int_0 * ((Class13.Class26)class24_0).struct5_0.int_0);
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_60(this);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000BB34 File Offset: 0x00009D34
		public override Class13.Class24 vmethod_61(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(checked(this.struct5_0.int_0 * ((Class13.Class26)class24_0).struct5_0.int_0));
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_61(this);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000BB98 File Offset: 0x00009D98
		public override Class13.Class24 vmethod_62(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(checked(this.struct5_0.uint_0 * ((Class13.Class26)class24_0).struct5_0.uint_0));
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_62(this);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000BBFC File Offset: 0x00009DFC
		public override Class13.Class24 vmethod_63(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.int_0 / ((Class13.Class26)class24_0).struct5_0.int_0);
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).method_7(this);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000BC60 File Offset: 0x00009E60
		public override Class13.Class24 vmethod_64(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.uint_0 / ((Class13.Class26)class24_0).struct5_0.uint_0);
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).method_8(this);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		public override Class13.Class24 vmethod_65(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.int_0 % ((Class13.Class26)class24_0).struct5_0.int_0);
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).method_9(this);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000BD28 File Offset: 0x00009F28
		public override Class13.Class24 vmethod_66(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.uint_0 % ((Class13.Class26)class24_0).struct5_0.uint_0);
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).method_10(this);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000BD8C File Offset: 0x00009F8C
		public override Class13.Class24 vmethod_67(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.int_0 & ((Class13.Class26)class24_0).struct5_0.int_0);
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_67(this);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		public override Class13.Class24 vmethod_68(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.int_0 | ((Class13.Class26)class24_0).struct5_0.int_0);
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_68(this);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002FCE File Offset: 0x000011CE
		public override Class13.Class24 vmethod_69()
		{
			return new Class13.Class26(~this.struct5_0.int_0);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000BE54 File Offset: 0x0000A054
		public override Class13.Class24 vmethod_70(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.int_0 ^ ((Class13.Class26)class24_0).struct5_0.int_0);
			}
			if (class24_0.epLymgDpIC())
			{
				return ((Class13.Class28)class24_0).vmethod_70(this);
			}
			throw new Class13.Exception1();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		public override Class13.Class24 vmethod_72(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.int_0 << ((Class13.Class26)class24_0).struct5_0.int_0);
			}
			if (class24_0.epLymgDpIC())
			{
				return ((Class13.Class28)class24_0).method_13(this);
			}
			throw new Class13.Exception1();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000BF1C File Offset: 0x0000A11C
		public override Class13.Class24 vmethod_73(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.int_0 >> ((Class13.Class26)class24_0).struct5_0.int_0);
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).method_12(this);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000BF80 File Offset: 0x0000A180
		public override Class13.Class24 vmethod_74(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return new Class13.Class26(this.struct5_0.uint_0 >> ((Class13.Class26)class24_0).struct5_0.int_0);
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).method_11(this);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
		public override string ToString()
		{
			Class13.Enum2 @enum = this.enum2_0;
			switch (@enum)
			{
			case (Class13.Enum2)1:
			case (Class13.Enum2)3:
			case (Class13.Enum2)5:
				goto IL_003B;
			case (Class13.Enum2)2:
			case (Class13.Enum2)4:
				break;
			default:
				if (@enum == (Class13.Enum2)11)
				{
					goto IL_003B;
				}
				break;
			}
			return this.struct5_0.uint_0.ToString();
			IL_003B:
			return this.struct5_0.int_0.ToString();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002FE1 File Offset: 0x000011E1
		internal override Class13.Class24 vmethod_8()
		{
			return this;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000243B File Offset: 0x0000063B
		internal override bool vmethod_9()
		{
			return true;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000C03C File Offset: 0x0000A23C
		internal override bool vmethod_5(Class13.Class24 class24_0)
		{
			if (class24_0.method_0())
			{
				return ((Class13.Class36)class24_0).vmethod_5(this);
			}
			if (class24_0.vmethod_0())
			{
				return ((Class13.Class30)class24_0).vmethod_5(this);
			}
			Class13.Class24 @class = class24_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (@class.method_2())
			{
				return false;
			}
			if (@class.method_1())
			{
				return this.struct5_0.int_0 == ((Class13.Class26)@class).struct5_0.int_0;
			}
			return ((Class13.Class28)@class).vmethod_5(this);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		private static Class13.Class25 smethod_4(Class13.Class24 class24_0)
		{
			Class13.Class25 @class = class24_0 as Class13.Class25;
			if (@class == null && class24_0.vmethod_0())
			{
				@class = class24_0.vmethod_8() as Class13.Class25;
			}
			return @class;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		internal override bool vmethod_6(Class13.Class24 class24_0)
		{
			if (class24_0.method_0())
			{
				return false;
			}
			if (class24_0.vmethod_0())
			{
				return ((Class13.Class30)class24_0).vmethod_6(this);
			}
			Class13.Class24 @class = class24_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (@class.method_2())
			{
				return false;
			}
			if (@class.method_1())
			{
				return this.struct5_0.uint_0 != ((Class13.Class26)@class).struct5_0.uint_0;
			}
			return ((Class13.Class28)@class).vmethod_6(this);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000C168 File Offset: 0x0000A368
		public override bool vmethod_75(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return this.struct5_0.int_0 >= ((Class13.Class26)class24_0).struct5_0.int_0;
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_79(this);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		public override bool vmethod_76(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return this.struct5_0.uint_0 >= ((Class13.Class26)class24_0).struct5_0.uint_0;
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_80(this);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000C228 File Offset: 0x0000A428
		public override bool vmethod_77(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return this.struct5_0.int_0 > ((Class13.Class26)class24_0).struct5_0.int_0;
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_81(this);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000C288 File Offset: 0x0000A488
		public override bool vmethod_78(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return this.struct5_0.uint_0 > ((Class13.Class26)class24_0).struct5_0.uint_0;
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_82(this);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		public override bool vmethod_79(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return this.struct5_0.int_0 <= ((Class13.Class26)class24_0).struct5_0.int_0;
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_75(this);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000C348 File Offset: 0x0000A548
		public override bool vmethod_80(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return this.struct5_0.uint_0 <= ((Class13.Class26)class24_0).struct5_0.uint_0;
			}
			if (class24_0.epLymgDpIC())
			{
				return ((Class13.Class28)class24_0).vmethod_76(this);
			}
			throw new Class13.Exception1();
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		public override bool vmethod_81(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return this.struct5_0.int_0 < ((Class13.Class26)class24_0).struct5_0.int_0;
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_77(this);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000C408 File Offset: 0x0000A608
		public override bool vmethod_82(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				return this.struct5_0.uint_0 < ((Class13.Class26)class24_0).struct5_0.uint_0;
			}
			if (!class24_0.epLymgDpIC())
			{
				throw new Class13.Exception1();
			}
			return ((Class13.Class28)class24_0).vmethod_78(this);
		}

		// Token: 0x04000075 RID: 117
		public Class13.Struct5 struct5_0;

		// Token: 0x04000076 RID: 118
		public Class13.Enum2 enum2_0;
	}

	// Token: 0x0200002E RID: 46
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct6
	{
		// Token: 0x04000077 RID: 119
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x04000078 RID: 120
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x04000079 RID: 121
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x0400007A RID: 122
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x0400007B RID: 123
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x0400007C RID: 124
		[FieldOffset(0)]
		public int int_0;

		// Token: 0x0400007D RID: 125
		[FieldOffset(0)]
		public ulong ulong_0;

		// Token: 0x0400007E RID: 126
		[FieldOffset(0)]
		public long long_0;
	}

	// Token: 0x0200002F RID: 47
	private class Class27 : Class13.Class25
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x00002FE4 File Offset: 0x000011E4
		internal override void zhnXqoJuKJ(Class13.Class24 class24_0)
		{
			this.struct6_0 = ((Class13.Class27)class24_0).struct6_0;
			this.enum2_0 = ((Class13.Class27)class24_0).enum2_0;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002B4C File Offset: 0x00000D4C
		internal override void vmethod_2(Class13.Class24 class24_0)
		{
			this.zhnXqoJuKJ(class24_0);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00003008 File Offset: 0x00001208
		public Class27(long long_0)
		{
			this.enum5_0 = (Class13.Enum5)2;
			this.struct6_0.long_0 = long_0;
			this.enum2_0 = (Class13.Enum2)7;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000302A File Offset: 0x0000122A
		public Class27(Class13.Class27 class27_0)
		{
			this.enum5_0 = class27_0.enum5_0;
			this.struct6_0.long_0 = class27_0.struct6_0.long_0;
			this.enum2_0 = class27_0.enum2_0;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00003060 File Offset: 0x00001260
		public override Class13.Class25 vmethod_71()
		{
			return new Class13.Class27(this);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00003068 File Offset: 0x00001268
		public Class27(long long_0, Class13.Enum2 enum2_1)
		{
			this.enum5_0 = (Class13.Enum5)2;
			this.struct6_0.long_0 = long_0;
			this.enum2_0 = enum2_1;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000308A File Offset: 0x0000128A
		public Class27(ulong ulong_0)
		{
			this.enum5_0 = (Class13.Enum5)2;
			this.struct6_0.ulong_0 = ulong_0;
			this.enum2_0 = (Class13.Enum2)8;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000030AC File Offset: 0x000012AC
		public Class27(ulong ulong_0, Class13.Enum2 enum2_1)
		{
			this.enum5_0 = (Class13.Enum5)2;
			this.struct6_0.ulong_0 = ulong_0;
			this.enum2_0 = enum2_1;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000030CE File Offset: 0x000012CE
		public override bool vmethod_10()
		{
			if (this.enum2_0 == (Class13.Enum2)7)
			{
				return this.struct6_0.long_0 == 0L;
			}
			return this.struct6_0.ulong_0 == 0UL;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002C4F File Offset: 0x00000E4F
		public override bool vmethod_11()
		{
			return !this.vmethod_10();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000C468 File Offset: 0x0000A668
		public override Class13.Class24 vmethod_12(Class13.Enum2 enum2_1)
		{
			switch (enum2_1)
			{
			case (Class13.Enum2)1:
				return this.vmethod_14();
			case (Class13.Enum2)2:
				return this.vmethod_15();
			case (Class13.Enum2)3:
				return this.vmethod_16();
			case (Class13.Enum2)4:
				return this.vmethod_17();
			case (Class13.Enum2)5:
				return this.vmethod_18();
			case (Class13.Enum2)6:
				return this.vmethod_19();
			case (Class13.Enum2)7:
				return this.vmethod_20();
			case (Class13.Enum2)8:
				return this.vmethod_21();
			case (Class13.Enum2)11:
				return this.vmethod_13();
			case (Class13.Enum2)15:
				return this.method_5();
			case (Class13.Enum2)16:
				return this.vmethod_71();
			}
			throw new Exception(((Class13.Enum6)4).ToString());
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000C520 File Offset: 0x0000A720
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum2_0)
				{
				case (Class13.Enum2)1:
					return this.struct6_0.sbyte_0;
				case (Class13.Enum2)2:
					return this.struct6_0.byte_0;
				case (Class13.Enum2)3:
					return this.struct6_0.short_0;
				case (Class13.Enum2)4:
					return this.struct6_0.ushort_0;
				case (Class13.Enum2)5:
					return this.struct6_0.int_0;
				case (Class13.Enum2)6:
					return this.struct6_0.uint_0;
				case (Class13.Enum2)7:
					return this.struct6_0.long_0;
				case (Class13.Enum2)8:
					return this.struct6_0.ulong_0;
				case (Class13.Enum2)11:
					return this.vmethod_11();
				case (Class13.Enum2)15:
					return (char)this.struct6_0.int_0;
				}
				return this.struct6_0.long_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct6_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct6_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct6_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct6_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct6_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct6_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_10();
			}
			if (type_0 == typeof(long))
			{
				return this.struct6_0.long_0;
			}
			if (type_0 == typeof(ulong))
			{
				return this.struct6_0.ulong_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct6_0.long_0;
			}
			if (type_0.IsEnum)
			{
				return this.method_4(type_0);
			}
			throw new Class13.Exception1();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		internal object method_4(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct6_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct6_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct6_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct6_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct6_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct6_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, this.struct6_0.long_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, this.struct6_0.ulong_0);
			}
			if (underlyingType == typeof(char))
			{
				return Enum.ToObject(type_0, (ushort)this.struct6_0.int_0);
			}
			return Enum.ToObject(type_0, this.struct6_0.long_0);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002C5A File Offset: 0x00000E5A
		public override Class13.Class26 vmethod_13()
		{
			return new Class13.Class26((!this.vmethod_10()) ? 1 : 0);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002C6A File Offset: 0x00000E6A
		internal override bool vmethod_7()
		{
			return this.vmethod_11();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00003106 File Offset: 0x00001306
		public Class13.Class26 method_5()
		{
			return new Class13.Class26((int)this.struct6_0.sbyte_0, (Class13.Enum2)15);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000311A File Offset: 0x0000131A
		public override Class13.Class26 vmethod_14()
		{
			return new Class13.Class26((int)this.struct6_0.sbyte_0, (Class13.Enum2)1);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000312D File Offset: 0x0000132D
		public override Class13.Class26 vmethod_15()
		{
			return new Class13.Class26((uint)this.struct6_0.byte_0, (Class13.Enum2)2);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00003140 File Offset: 0x00001340
		public override Class13.Class26 vmethod_16()
		{
			return new Class13.Class26((int)this.struct6_0.short_0, (Class13.Enum2)3);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00003153 File Offset: 0x00001353
		public override Class13.Class26 vmethod_17()
		{
			return new Class13.Class26((uint)this.struct6_0.ushort_0, (Class13.Enum2)4);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00003166 File Offset: 0x00001366
		public override Class13.Class26 vmethod_18()
		{
			return new Class13.Class26(this.struct6_0.int_0, (Class13.Enum2)5);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00003179 File Offset: 0x00001379
		public override Class13.Class26 vmethod_19()
		{
			return new Class13.Class26(this.struct6_0.uint_0, (Class13.Enum2)6);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000318C File Offset: 0x0000138C
		public override Class13.Class27 vmethod_20()
		{
			return new Class13.Class27(this.struct6_0.long_0, (Class13.Enum2)7);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000319F File Offset: 0x0000139F
		public override Class13.Class27 vmethod_21()
		{
			return new Class13.Class27(this.struct6_0.ulong_0, (Class13.Enum2)8);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002D20 File Offset: 0x00000F20
		public override Class13.Class26 vmethod_22()
		{
			return this.vmethod_14();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002D28 File Offset: 0x00000F28
		public override Class13.Class26 vmethod_23()
		{
			return this.vmethod_16();
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002D30 File Offset: 0x00000F30
		public override Class13.Class26 vmethod_24()
		{
			return this.vmethod_18();
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002D38 File Offset: 0x00000F38
		public override Class13.Class27 WdeXooypfm()
		{
			return this.vmethod_20();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002D40 File Offset: 0x00000F40
		public override Class13.Class26 vmethod_25()
		{
			return this.vmethod_15();
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002D48 File Offset: 0x00000F48
		public override Class13.Class26 vmethod_26()
		{
			return this.vmethod_17();
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002D50 File Offset: 0x00000F50
		public override Class13.Class26 vmethod_27()
		{
			return this.vmethod_19();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002D58 File Offset: 0x00000F58
		public override Class13.Class27 vmethod_28()
		{
			return this.vmethod_21();
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000031B2 File Offset: 0x000013B2
		public override Class13.Class26 vmethod_29()
		{
			return new Class13.Class26((int)(checked((sbyte)this.struct6_0.long_0)), (Class13.Enum2)1);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000031C6 File Offset: 0x000013C6
		public override Class13.Class26 vmethod_30()
		{
			return new Class13.Class26((int)(checked((sbyte)this.struct6_0.ulong_0)), (Class13.Enum2)1);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000031DA File Offset: 0x000013DA
		public override Class13.Class26 vmethod_31()
		{
			return new Class13.Class26((int)(checked((short)this.struct6_0.long_0)), (Class13.Enum2)3);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000031EE File Offset: 0x000013EE
		public override Class13.Class26 vmethod_32()
		{
			return new Class13.Class26((int)(checked((short)this.struct6_0.ulong_0)), (Class13.Enum2)3);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00003202 File Offset: 0x00001402
		public override Class13.Class26 vmethod_33()
		{
			return new Class13.Class26(checked((int)this.struct6_0.long_0), (Class13.Enum2)5);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00003216 File Offset: 0x00001416
		public override Class13.Class26 vmethod_34()
		{
			return new Class13.Class26(checked((int)this.struct6_0.ulong_0), (Class13.Enum2)5);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000318C File Offset: 0x0000138C
		public override Class13.Class27 vmethod_35()
		{
			return new Class13.Class27(this.struct6_0.long_0, (Class13.Enum2)7);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000322A File Offset: 0x0000142A
		public override Class13.Class27 vmethod_36()
		{
			return new Class13.Class27(checked((long)this.struct6_0.ulong_0), (Class13.Enum2)7);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000323E File Offset: 0x0000143E
		public override Class13.Class26 vmethod_37()
		{
			return new Class13.Class26((int)(checked((byte)this.struct6_0.long_0)), (Class13.Enum2)2);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00003252 File Offset: 0x00001452
		public override Class13.Class26 vmethod_38()
		{
			return new Class13.Class26((int)(checked((byte)this.struct6_0.ulong_0)), (Class13.Enum2)2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00003266 File Offset: 0x00001466
		public override Class13.Class26 vmethod_39()
		{
			return new Class13.Class26((int)(checked((ushort)this.struct6_0.long_0)), (Class13.Enum2)4);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000327A File Offset: 0x0000147A
		public override Class13.Class26 vmethod_40()
		{
			return new Class13.Class26((int)(checked((ushort)this.struct6_0.ulong_0)), (Class13.Enum2)4);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000328E File Offset: 0x0000148E
		public override Class13.Class26 vmethod_41()
		{
			return new Class13.Class26(checked((uint)this.struct6_0.long_0), (Class13.Enum2)6);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000032A2 File Offset: 0x000014A2
		public override Class13.Class26 vmethod_42()
		{
			return new Class13.Class26(checked((uint)this.struct6_0.ulong_0), (Class13.Enum2)6);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000032B6 File Offset: 0x000014B6
		public override Class13.Class27 vmethod_43()
		{
			return new Class13.Class27(checked((ulong)this.struct6_0.long_0), (Class13.Enum2)8);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000319F File Offset: 0x0000139F
		public override Class13.Class27 vmethod_44()
		{
			return new Class13.Class27(this.struct6_0.ulong_0, (Class13.Enum2)8);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000032CA File Offset: 0x000014CA
		public override Class13.Class29 vmethod_45()
		{
			return new Class13.Class29((float)this.struct6_0.long_0);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000032DD File Offset: 0x000014DD
		public override Class13.Class29 vmethod_46()
		{
			return new Class13.Class29((double)this.struct6_0.long_0);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000032F0 File Offset: 0x000014F0
		public override Class13.Class29 NkkgOoOrdR()
		{
			return new Class13.Class29(this.struct6_0.ulong_0);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002E8A File Offset: 0x0000108A
		public override Class13.Class28 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.WdeXooypfm().struct6_0.long_0);
			}
			return new Class13.Class28((long)this.vmethod_24().struct5_0.int_0);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002EC0 File Offset: 0x000010C0
		public override Class13.Class28 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_28().struct6_0.ulong_0);
			}
			return new Class13.Class28((ulong)this.vmethod_27().struct5_0.uint_0);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002EF6 File Offset: 0x000010F6
		public override Class13.Class28 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_35().struct6_0.long_0);
			}
			return new Class13.Class28((long)this.vmethod_33().struct5_0.int_0);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002F2C File Offset: 0x0000112C
		public override Class13.Class28 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_43().struct6_0.ulong_0);
			}
			return new Class13.Class28((ulong)this.vmethod_41().struct5_0.uint_0);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002F62 File Offset: 0x00001162
		public override Class13.Class28 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_36().struct6_0.long_0);
			}
			return new Class13.Class28((long)this.vmethod_34().struct5_0.int_0);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00003304 File Offset: 0x00001504
		public override Class13.Class28 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.struct6_0.ulong_0);
			}
			return new Class13.Class28((ulong)(checked((uint)this.struct6_0.ulong_0)));
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00003331 File Offset: 0x00001531
		public override Class13.Class24 vmethod_53()
		{
			return new Class13.Class27(-this.struct6_0.long_0);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000C95C File Offset: 0x0000AB5C
		public override Class13.Class24 vmethod_54(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(this.struct6_0.long_0 + ((Class13.Class27)class24_0).struct6_0.long_0);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		public override Class13.Class24 vmethod_55(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(checked(this.struct6_0.long_0 + ((Class13.Class27)class24_0).struct6_0.long_0));
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000C9F4 File Offset: 0x0000ABF4
		public override Class13.Class24 vmethod_56(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(checked(this.struct6_0.ulong_0 + ((Class13.Class27)class24_0).struct6_0.ulong_0));
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000CA40 File Offset: 0x0000AC40
		public override Class13.Class24 vmethod_57(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(this.struct6_0.long_0 - ((Class13.Class27)class24_0).struct6_0.long_0);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000CA8C File Offset: 0x0000AC8C
		public override Class13.Class24 vmethod_58(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(checked(this.struct6_0.long_0 - ((Class13.Class27)class24_0).struct6_0.long_0));
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
		public override Class13.Class24 vmethod_59(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(checked(this.struct6_0.ulong_0 - ((Class13.Class27)class24_0).struct6_0.ulong_0));
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000CB24 File Offset: 0x0000AD24
		public override Class13.Class24 vmethod_60(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(this.struct6_0.long_0 * ((Class13.Class27)class24_0).struct6_0.long_0);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000CB70 File Offset: 0x0000AD70
		public override Class13.Class24 vmethod_61(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(checked(this.struct6_0.long_0 * ((Class13.Class27)class24_0).struct6_0.long_0));
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000CBBC File Offset: 0x0000ADBC
		public override Class13.Class24 vmethod_62(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(checked(this.struct6_0.ulong_0 * ((Class13.Class27)class24_0).struct6_0.ulong_0));
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000CC08 File Offset: 0x0000AE08
		public override Class13.Class24 vmethod_63(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(this.struct6_0.long_0 / ((Class13.Class27)class24_0).struct6_0.long_0);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000CC54 File Offset: 0x0000AE54
		public override Class13.Class24 vmethod_64(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(this.struct6_0.ulong_0 / ((Class13.Class27)class24_0).struct6_0.ulong_0);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		public override Class13.Class24 vmethod_65(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(this.struct6_0.long_0 % ((Class13.Class27)class24_0).struct6_0.long_0);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000CCEC File Offset: 0x0000AEEC
		public override Class13.Class24 vmethod_66(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(this.struct6_0.ulong_0 % ((Class13.Class27)class24_0).struct6_0.ulong_0);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000CD38 File Offset: 0x0000AF38
		public override Class13.Class24 vmethod_67(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(this.struct6_0.long_0 & ((Class13.Class27)class24_0).struct6_0.long_0);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000CD84 File Offset: 0x0000AF84
		public override Class13.Class24 vmethod_68(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(this.struct6_0.long_0 | ((Class13.Class27)class24_0).struct6_0.long_0);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00003344 File Offset: 0x00001544
		public override Class13.Class24 vmethod_69()
		{
			return new Class13.Class27(~this.struct6_0.long_0);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000CDD0 File Offset: 0x0000AFD0
		public override Class13.Class24 vmethod_70(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(this.struct6_0.long_0 ^ ((Class13.Class27)class24_0).struct6_0.long_0);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000CE1C File Offset: 0x0000B01C
		public override Class13.Class24 vmethod_72(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_2())
			{
				return new Class13.Class27(this.struct6_0.long_0 << ((Class13.Class27)class24_0).struct6_0.int_0);
			}
			if (class24_0.vmethod_3())
			{
				return new Class13.Class27(this.struct6_0.long_0 << ((Class13.Class25)class24_0).vmethod_18().struct5_0.int_0);
			}
			throw new Class13.Exception1();
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		public override Class13.Class24 vmethod_73(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_2())
			{
				return new Class13.Class27(this.struct6_0.long_0 >> ((Class13.Class27)class24_0).struct6_0.int_0);
			}
			if (!class24_0.vmethod_3())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(this.struct6_0.long_0 >> ((Class13.Class25)class24_0).vmethod_18().struct5_0.int_0);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000CF24 File Offset: 0x0000B124
		public override Class13.Class24 vmethod_74(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_2())
			{
				return new Class13.Class27(this.struct6_0.ulong_0 >> ((Class13.Class27)class24_0).struct6_0.int_0);
			}
			if (!class24_0.vmethod_3())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class27(this.struct6_0.ulong_0 >> ((Class13.Class25)class24_0).vmethod_18().struct5_0.int_0);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00003357 File Offset: 0x00001557
		public override string ToString()
		{
			if (this.enum2_0 == (Class13.Enum2)7)
			{
				return this.struct6_0.long_0.ToString();
			}
			return this.struct6_0.ulong_0.ToString();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002FE1 File Offset: 0x000011E1
		internal override Class13.Class24 vmethod_8()
		{
			return this;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000243B File Offset: 0x0000063B
		internal override bool vmethod_9()
		{
			return true;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		internal override bool vmethod_5(Class13.Class24 class24_0)
		{
			if (class24_0.method_0())
			{
				return ((Class13.Class36)class24_0).vmethod_5(this);
			}
			if (class24_0.vmethod_0())
			{
				return ((Class13.Class30)class24_0).vmethod_5(this);
			}
			Class13.Class24 @class = class24_0.vmethod_8();
			return @class.method_2() && this.struct6_0.long_0 == ((Class13.Class27)@class).struct6_0.long_0;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		private static Class13.Class25 smethod_4(Class13.Class24 class24_0)
		{
			Class13.Class25 @class = class24_0 as Class13.Class25;
			if (@class == null && class24_0.vmethod_0())
			{
				@class = class24_0.vmethod_8() as Class13.Class25;
			}
			return @class;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000D010 File Offset: 0x0000B210
		internal override bool vmethod_6(Class13.Class24 class24_0)
		{
			if (class24_0.method_0())
			{
				return false;
			}
			if (!class24_0.vmethod_0())
			{
				Class13.Class24 @class = class24_0.vmethod_8();
				return @class.method_2() && this.struct6_0.ulong_0 != ((Class13.Class27)@class).struct6_0.ulong_0;
			}
			return ((Class13.Class30)class24_0).vmethod_6(this);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00003383 File Offset: 0x00001583
		public override bool vmethod_75(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return this.struct6_0.long_0 >= ((Class13.Class27)class24_0).struct6_0.long_0;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000033C3 File Offset: 0x000015C3
		public override bool vmethod_76(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return this.struct6_0.ulong_0 >= ((Class13.Class27)class24_0).struct6_0.ulong_0;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00003403 File Offset: 0x00001603
		public override bool vmethod_77(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return this.struct6_0.long_0 > ((Class13.Class27)class24_0).struct6_0.long_0;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00003440 File Offset: 0x00001640
		public override bool vmethod_78(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return this.struct6_0.ulong_0 > ((Class13.Class27)class24_0).struct6_0.ulong_0;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000347D File Offset: 0x0000167D
		public override bool vmethod_79(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return this.struct6_0.long_0 <= ((Class13.Class27)class24_0).struct6_0.long_0;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000034BD File Offset: 0x000016BD
		public override bool vmethod_80(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return this.struct6_0.ulong_0 <= ((Class13.Class27)class24_0).struct6_0.ulong_0;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000034FD File Offset: 0x000016FD
		public override bool vmethod_81(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return this.struct6_0.long_0 < ((Class13.Class27)class24_0).struct6_0.long_0;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000353A File Offset: 0x0000173A
		public override bool vmethod_82(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_2())
			{
				throw new Class13.Exception1();
			}
			return this.struct6_0.ulong_0 < ((Class13.Class27)class24_0).struct6_0.ulong_0;
		}

		// Token: 0x0400007F RID: 127
		public Class13.Struct6 struct6_0;

		// Token: 0x04000080 RID: 128
		public Class13.Enum2 enum2_0;
	}

	// Token: 0x02000030 RID: 48
	private class Class28 : Class13.Class25
	{
		// Token: 0x06000214 RID: 532 RVA: 0x00003577 File Offset: 0x00001777
		internal void method_4(Class13.Class24 class24_0)
		{
			if (!class24_0.epLymgDpIC())
			{
				this.zhnXqoJuKJ(class24_0);
				return;
			}
			this.class25_0 = ((Class13.Class28)class24_0).class25_0;
			this.enum2_0 = ((Class13.Class28)class24_0).enum2_0;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000D070 File Offset: 0x0000B270
		internal unsafe override void zhnXqoJuKJ(Class13.Class24 class24_0)
		{
			if (class24_0.epLymgDpIC())
			{
				if (IntPtr.Size == 8)
				{
					IntPtr intPtr = new IntPtr(((Class13.Class27)this.class25_0).struct6_0.long_0);
					IntPtr intPtr2 = new IntPtr(((Class13.Class27)((Class13.Class28)class24_0).class25_0).struct6_0.long_0);
					*(long*)(void*)intPtr = intPtr2.ToInt64();
					return;
				}
				IntPtr intPtr3 = new IntPtr(((Class13.Class26)this.class25_0).struct5_0.int_0);
				IntPtr intPtr4 = new IntPtr(((Class13.Class26)((Class13.Class28)class24_0).class25_0).struct5_0.int_0);
				*(int*)(void*)intPtr3 = intPtr4.ToInt32();
				return;
			}
			else
			{
				object obj = class24_0.vmethod_4(null);
				if (obj == null)
				{
					return;
				}
				IntPtr intPtr5;
				if (IntPtr.Size == 8)
				{
					intPtr5 = new IntPtr(((Class13.Class27)this.class25_0).struct6_0.long_0);
				}
				else
				{
					intPtr5 = new IntPtr(((Class13.Class26)this.class25_0).struct5_0.int_0);
				}
				Type type = obj.GetType();
				if (type == typeof(string))
				{
					return;
				}
				if (type == typeof(byte))
				{
					*(byte*)(void*)intPtr5 = (byte)obj;
					return;
				}
				if (type == typeof(sbyte))
				{
					*(byte*)(void*)intPtr5 = (byte)((sbyte)obj);
					return;
				}
				if (type == typeof(short))
				{
					*(short*)(void*)intPtr5 = (short)obj;
					return;
				}
				if (type == typeof(ushort))
				{
					*(short*)(void*)intPtr5 = (short)((ushort)obj);
					return;
				}
				if (type == typeof(int))
				{
					*(int*)(void*)intPtr5 = (int)obj;
					return;
				}
				if (type == typeof(uint))
				{
					*(int*)(void*)intPtr5 = (int)((uint)obj);
					return;
				}
				if (type == typeof(long))
				{
					*(long*)(void*)intPtr5 = (long)obj;
					return;
				}
				if (type == typeof(ulong))
				{
					*(long*)(void*)intPtr5 = (long)((ulong)obj);
					return;
				}
				if (type == typeof(float))
				{
					*(float*)(void*)intPtr5 = (float)obj;
					return;
				}
				if (type == typeof(double))
				{
					*(double*)(void*)intPtr5 = (double)obj;
					return;
				}
				if (type == typeof(bool))
				{
					*(byte*)(void*)intPtr5 = (((bool)obj) ? 1 : 0);
					return;
				}
				if (type == typeof(IntPtr))
				{
					*(IntPtr*)(void*)intPtr5 = (IntPtr)obj;
					return;
				}
				if (type == typeof(UIntPtr))
				{
					*(IntPtr*)(void*)intPtr5 = (IntPtr)((UIntPtr)obj);
					return;
				}
				if (type == typeof(char))
				{
					*(short*)(void*)intPtr5 = (short)((char)obj);
					return;
				}
				throw new Class13.Exception1();
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002B4C File Offset: 0x00000D4C
		internal override void vmethod_2(Class13.Class24 class24_0)
		{
			this.zhnXqoJuKJ(class24_0);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000D370 File Offset: 0x0000B570
		public Class28(IntPtr intptr_0)
		{
			this.enum5_0 = (Class13.Enum5)3;
			if (IntPtr.Size == 8)
			{
				this.class25_0 = new Class13.Class27(intptr_0.ToInt64());
				this.enum2_0 = (Class13.Enum2)12;
				return;
			}
			this.class25_0 = new Class13.Class26(intptr_0.ToInt32());
			this.enum2_0 = (Class13.Enum2)12;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		public Class28(UIntPtr uintptr_0)
		{
			this.enum5_0 = (Class13.Enum5)3;
			if (IntPtr.Size == 8)
			{
				this.class25_0 = new Class13.Class27(uintptr_0.ToUInt64());
				this.enum2_0 = (Class13.Enum2)12;
				return;
			}
			this.class25_0 = new Class13.Class26(uintptr_0.ToUInt32());
			this.enum2_0 = (Class13.Enum2)12;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000D420 File Offset: 0x0000B620
		public Class28()
		{
			this.enum5_0 = (Class13.Enum5)3;
			if (IntPtr.Size == 8)
			{
				this.class25_0 = new Class13.Class27(0L);
				this.enum2_0 = (Class13.Enum2)12;
				return;
			}
			this.class25_0 = new Class13.Class26(0);
			this.enum2_0 = (Class13.Enum2)12;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000035AB File Offset: 0x000017AB
		public override Class13.Class25 vmethod_71()
		{
			return new Class13.Class28
			{
				class25_0 = this.class25_0.vmethod_71(),
				enum2_0 = this.enum2_0
			};
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000D474 File Offset: 0x0000B674
		public Class28(long long_0)
		{
			this.enum5_0 = (Class13.Enum5)3;
			if (IntPtr.Size == 8)
			{
				this.class25_0 = new Class13.Class27(long_0);
				this.enum2_0 = (Class13.Enum2)12;
				return;
			}
			this.class25_0 = new Class13.Class26((int)long_0);
			this.enum2_0 = (Class13.Enum2)12;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000035CF File Offset: 0x000017CF
		public Class28(long long_0, Class13.Enum2 enum2_1)
		{
			this.enum5_0 = (Class13.Enum5)3;
			if (IntPtr.Size == 8)
			{
				this.class25_0 = new Class13.Class27(long_0);
				this.enum2_0 = enum2_1;
				return;
			}
			this.class25_0 = new Class13.Class26((int)long_0);
			this.enum2_0 = enum2_1;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000D4C0 File Offset: 0x0000B6C0
		public Class28(ulong ulong_0)
		{
			this.enum5_0 = (Class13.Enum5)4;
			if (IntPtr.Size == 8)
			{
				this.class25_0 = new Class13.Class27(ulong_0);
				this.enum2_0 = (Class13.Enum2)13;
				return;
			}
			this.class25_0 = new Class13.Class26((uint)ulong_0);
			this.enum2_0 = (Class13.Enum2)13;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000360E File Offset: 0x0000180E
		public Class28(ulong ulong_0, Class13.Enum2 enum2_1)
		{
			this.enum5_0 = (Class13.Enum5)4;
			if (IntPtr.Size == 8)
			{
				this.class25_0 = new Class13.Class27(ulong_0);
				this.enum2_0 = enum2_1;
				return;
			}
			this.class25_0 = new Class13.Class26((uint)ulong_0);
			this.enum2_0 = enum2_1;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000364D File Offset: 0x0000184D
		public override bool vmethod_10()
		{
			return this.class25_0.vmethod_10();
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002C4F File Offset: 0x00000E4F
		public override bool vmethod_11()
		{
			return !this.vmethod_10();
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002C6A File Offset: 0x00000E6A
		internal override bool vmethod_7()
		{
			return this.vmethod_11();
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000243B File Offset: 0x0000063B
		internal override bool vmethod_1()
		{
			return true;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000D50C File Offset: 0x0000B70C
		public override Class13.Class24 vmethod_12(Class13.Enum2 enum2_1)
		{
			switch (enum2_1)
			{
			case (Class13.Enum2)1:
				return this.vmethod_14();
			case (Class13.Enum2)2:
				return this.vmethod_15();
			case (Class13.Enum2)3:
				return this.vmethod_16();
			case (Class13.Enum2)4:
				return this.vmethod_17();
			case (Class13.Enum2)5:
				return this.vmethod_18();
			case (Class13.Enum2)6:
				return this.vmethod_19();
			case (Class13.Enum2)7:
				return this.vmethod_20();
			case (Class13.Enum2)8:
				return this.vmethod_21();
			case (Class13.Enum2)11:
				return this.vmethod_13();
			case (Class13.Enum2)12:
				return this;
			case (Class13.Enum2)13:
				return this;
			case (Class13.Enum2)16:
				return this.vmethod_71();
			}
			throw new Exception(((Class13.Enum6)4).ToString());
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000365A File Offset: 0x0000185A
		internal IntPtr uilAcHjmLR()
		{
			if (IntPtr.Size == 8)
			{
				return new IntPtr(((Class13.Class27)this.class25_0).struct6_0.long_0);
			}
			return new IntPtr(((Class13.Class26)this.class25_0).struct5_0.int_0);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000D5C4 File Offset: 0x0000B7C4
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (!(type_0 == typeof(IntPtr)))
			{
				if (type_0 == typeof(UIntPtr))
				{
					if (IntPtr.Size == 8)
					{
						return new UIntPtr(((Class13.Class27)this.class25_0).struct6_0.ulong_0);
					}
					return new UIntPtr(((Class13.Class26)this.class25_0).struct5_0.uint_0);
				}
				else
				{
					if (!(type_0 == null) && !(type_0 == typeof(object)))
					{
						throw new Class13.Exception1();
					}
					if (IntPtr.Size == 8)
					{
						if (this.enum2_0 == (Class13.Enum2)12)
						{
							return new IntPtr(((Class13.Class27)this.class25_0).struct6_0.long_0);
						}
						return new UIntPtr(((Class13.Class27)this.class25_0).struct6_0.ulong_0);
					}
					else
					{
						if (this.enum2_0 == (Class13.Enum2)12)
						{
							return new IntPtr(((Class13.Class27)this.class25_0).struct6_0.int_0);
						}
						return new UIntPtr(((Class13.Class26)this.class25_0).struct5_0.uint_0);
					}
				}
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new IntPtr(((Class13.Class27)this.class25_0).struct6_0.long_0);
				}
				return new IntPtr(((Class13.Class26)this.class25_0).struct5_0.int_0);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00003699 File Offset: 0x00001899
		public override Class13.Class26 vmethod_13()
		{
			return this.class25_0.vmethod_13();
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000036A6 File Offset: 0x000018A6
		public override Class13.Class26 vmethod_14()
		{
			return this.class25_0.vmethod_14();
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000036B3 File Offset: 0x000018B3
		public override Class13.Class26 vmethod_15()
		{
			return this.class25_0.vmethod_15();
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000036C0 File Offset: 0x000018C0
		public override Class13.Class26 vmethod_16()
		{
			return this.class25_0.vmethod_16();
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000036CD File Offset: 0x000018CD
		public override Class13.Class26 vmethod_17()
		{
			return this.class25_0.vmethod_17();
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000036DA File Offset: 0x000018DA
		public override Class13.Class26 vmethod_18()
		{
			return this.class25_0.vmethod_18();
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000036E7 File Offset: 0x000018E7
		public override Class13.Class26 vmethod_19()
		{
			return this.class25_0.vmethod_19();
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000036F4 File Offset: 0x000018F4
		public override Class13.Class27 vmethod_20()
		{
			return this.class25_0.vmethod_20();
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00003701 File Offset: 0x00001901
		public override Class13.Class27 vmethod_21()
		{
			return this.class25_0.vmethod_21();
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002D20 File Offset: 0x00000F20
		public override Class13.Class26 vmethod_22()
		{
			return this.vmethod_14();
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002D28 File Offset: 0x00000F28
		public override Class13.Class26 vmethod_23()
		{
			return this.vmethod_16();
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002D30 File Offset: 0x00000F30
		public override Class13.Class26 vmethod_24()
		{
			return this.vmethod_18();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002D38 File Offset: 0x00000F38
		public override Class13.Class27 WdeXooypfm()
		{
			return this.vmethod_20();
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002D40 File Offset: 0x00000F40
		public override Class13.Class26 vmethod_25()
		{
			return this.vmethod_15();
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002D48 File Offset: 0x00000F48
		public override Class13.Class26 vmethod_26()
		{
			return this.vmethod_17();
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002D50 File Offset: 0x00000F50
		public override Class13.Class26 vmethod_27()
		{
			return this.vmethod_19();
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002D58 File Offset: 0x00000F58
		public override Class13.Class27 vmethod_28()
		{
			return this.vmethod_21();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000370E File Offset: 0x0000190E
		public override Class13.Class26 vmethod_29()
		{
			return this.class25_0.vmethod_29();
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000371B File Offset: 0x0000191B
		public override Class13.Class26 vmethod_30()
		{
			return this.class25_0.vmethod_30();
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00003728 File Offset: 0x00001928
		public override Class13.Class26 vmethod_31()
		{
			return this.class25_0.vmethod_31();
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00003735 File Offset: 0x00001935
		public override Class13.Class26 vmethod_32()
		{
			return this.class25_0.vmethod_32();
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00003742 File Offset: 0x00001942
		public override Class13.Class26 vmethod_33()
		{
			return this.class25_0.vmethod_33();
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000374F File Offset: 0x0000194F
		public override Class13.Class26 vmethod_34()
		{
			return this.class25_0.vmethod_34();
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000375C File Offset: 0x0000195C
		public override Class13.Class27 vmethod_35()
		{
			return this.class25_0.vmethod_35();
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00003769 File Offset: 0x00001969
		public override Class13.Class27 vmethod_36()
		{
			return this.class25_0.vmethod_36();
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00003776 File Offset: 0x00001976
		public override Class13.Class26 vmethod_37()
		{
			return this.class25_0.vmethod_37();
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00003783 File Offset: 0x00001983
		public override Class13.Class26 vmethod_38()
		{
			return this.class25_0.vmethod_38();
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00003790 File Offset: 0x00001990
		public override Class13.Class26 vmethod_39()
		{
			return this.class25_0.vmethod_39();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000379D File Offset: 0x0000199D
		public override Class13.Class26 vmethod_40()
		{
			return this.class25_0.vmethod_40();
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000037AA File Offset: 0x000019AA
		public override Class13.Class26 vmethod_41()
		{
			return this.class25_0.vmethod_41();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000037B7 File Offset: 0x000019B7
		public override Class13.Class26 vmethod_42()
		{
			return this.class25_0.vmethod_42();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000037C4 File Offset: 0x000019C4
		public override Class13.Class27 vmethod_43()
		{
			return this.class25_0.vmethod_43();
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000037D1 File Offset: 0x000019D1
		public override Class13.Class27 vmethod_44()
		{
			return this.class25_0.vmethod_44();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000037DE File Offset: 0x000019DE
		public override Class13.Class29 vmethod_45()
		{
			return this.class25_0.vmethod_45();
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000037EB File Offset: 0x000019EB
		public override Class13.Class29 vmethod_46()
		{
			return this.class25_0.vmethod_46();
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000037F8 File Offset: 0x000019F8
		public override Class13.Class29 NkkgOoOrdR()
		{
			return this.class25_0.NkkgOoOrdR();
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002E8A File Offset: 0x0000108A
		public override Class13.Class28 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.WdeXooypfm().struct6_0.long_0);
			}
			return new Class13.Class28((long)this.vmethod_24().struct5_0.int_0);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002EC0 File Offset: 0x000010C0
		public override Class13.Class28 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_28().struct6_0.ulong_0);
			}
			return new Class13.Class28((ulong)this.vmethod_27().struct5_0.uint_0);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002EF6 File Offset: 0x000010F6
		public override Class13.Class28 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_35().struct6_0.long_0);
			}
			return new Class13.Class28((long)this.vmethod_33().struct5_0.int_0);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002F2C File Offset: 0x0000112C
		public override Class13.Class28 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_43().struct6_0.ulong_0);
			}
			return new Class13.Class28((ulong)this.vmethod_41().struct5_0.uint_0);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002F62 File Offset: 0x00001162
		public override Class13.Class28 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_36().struct6_0.long_0);
			}
			return new Class13.Class28((long)this.vmethod_34().struct5_0.int_0);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002F98 File Offset: 0x00001198
		public override Class13.Class28 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_44().struct6_0.ulong_0);
			}
			return new Class13.Class28((ulong)this.vmethod_42().struct5_0.uint_0);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000D760 File Offset: 0x0000B960
		public override Class13.Class24 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(-((Class13.Class27)this.class25_0).struct6_0.long_0);
			}
			return new Class13.Class28((long)(-(long)((Class13.Class26)this.class25_0).struct5_0.int_0));
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
		public override Class13.Class24 vmethod_54(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 + ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 + ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 + ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 + ((Class13.Class26)class24_0).struct5_0.int_0));
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		public override Class13.Class24 vmethod_55(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(checked(this.vmethod_20().struct6_0.long_0 + ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0));
				}
				return new Class13.Class28((long)(checked(this.vmethod_18().struct5_0.int_0 + ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(checked(this.vmethod_20().struct6_0.long_0 + ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0));
				}
				return new Class13.Class28((long)(checked(this.vmethod_18().struct5_0.int_0 + ((Class13.Class26)class24_0).struct5_0.int_0)));
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000D990 File Offset: 0x0000BB90
		public override Class13.Class24 vmethod_56(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(checked(this.vmethod_20().struct6_0.ulong_0 + ((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0));
				}
				return new Class13.Class28((ulong)(checked(this.vmethod_18().struct5_0.uint_0 + ((Class13.Class28)class24_0).vmethod_18().struct5_0.uint_0)));
			}
			else
			{
				checked
				{
					if (IntPtr.Size == 8)
					{
						return new Class13.Class28(this.vmethod_20().struct6_0.ulong_0 + unchecked((ulong)((Class13.Class26)class24_0).struct5_0.uint_0));
					}
				}
				return new Class13.Class28((long)((ulong)(checked(this.vmethod_18().struct5_0.uint_0 + ((Class13.Class26)class24_0).struct5_0.uint_0))));
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000DA7C File Offset: 0x0000BC7C
		public override Class13.Class24 vmethod_57(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 - ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 - ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 - ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 - ((Class13.Class26)class24_0).struct5_0.int_0));
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000DB6C File Offset: 0x0000BD6C
		public Class13.Class24 egfAmGpeTE(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0 - this.vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(((Class13.Class26)class24_0).struct5_0.int_0 - this.vmethod_18().struct5_0.int_0));
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0 - this.vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0 - this.vmethod_18().struct5_0.int_0));
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000DC5C File Offset: 0x0000BE5C
		public override Class13.Class24 vmethod_58(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(checked(this.vmethod_20().struct6_0.long_0 - ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0));
				}
				return new Class13.Class28((long)(checked(this.vmethod_18().struct5_0.int_0 - ((Class13.Class26)class24_0).struct5_0.int_0)));
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(checked(this.vmethod_20().struct6_0.long_0 - ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0));
				}
				return new Class13.Class28((long)(checked(this.vmethod_18().struct5_0.int_0 - ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0)));
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000DD4C File Offset: 0x0000BF4C
		public Class13.Class24 method_5(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(checked(((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0 - this.vmethod_20().struct6_0.long_0));
				}
				return new Class13.Class28((long)(checked(((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0 - this.vmethod_18().struct5_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(checked(((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0 - this.vmethod_20().struct6_0.long_0));
				}
				return new Class13.Class28((long)(checked(((Class13.Class26)class24_0).struct5_0.int_0 - this.vmethod_18().struct5_0.int_0)));
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000DE3C File Offset: 0x0000C03C
		public override Class13.Class24 vmethod_59(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(checked(this.vmethod_20().struct6_0.ulong_0 - ((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0));
				}
				return new Class13.Class28((ulong)(checked(this.vmethod_18().struct5_0.uint_0 - ((Class13.Class28)class24_0).vmethod_18().struct5_0.uint_0)));
			}
			else
			{
				checked
				{
					if (IntPtr.Size == 8)
					{
						return new Class13.Class28(this.vmethod_20().struct6_0.ulong_0 - unchecked((ulong)((Class13.Class26)class24_0).struct5_0.uint_0));
					}
				}
				return new Class13.Class28((long)((ulong)(checked(this.vmethod_18().struct5_0.uint_0 - ((Class13.Class26)class24_0).struct5_0.uint_0))));
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000DF28 File Offset: 0x0000C128
		public Class13.Class24 method_6(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(checked(((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0 - this.vmethod_20().struct6_0.ulong_0));
				}
				return new Class13.Class28((ulong)(checked(((Class13.Class28)class24_0).vmethod_18().struct5_0.uint_0 - this.vmethod_18().struct5_0.uint_0)));
			}
			else
			{
				checked
				{
					if (IntPtr.Size == 8)
					{
						return new Class13.Class28(unchecked((ulong)((Class13.Class26)class24_0).struct5_0.uint_0) - this.vmethod_20().struct6_0.ulong_0);
					}
				}
				return new Class13.Class28((long)((ulong)(checked(((Class13.Class26)class24_0).struct5_0.uint_0 - this.vmethod_18().struct5_0.uint_0))));
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000E014 File Offset: 0x0000C214
		public override Class13.Class24 vmethod_60(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 * ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 * ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 * ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 * ((Class13.Class26)class24_0).struct5_0.int_0));
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000E104 File Offset: 0x0000C304
		public override Class13.Class24 vmethod_61(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(checked(this.vmethod_20().struct6_0.long_0 * ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0));
				}
				return new Class13.Class28((long)(checked(this.vmethod_18().struct5_0.int_0 * ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(checked(this.vmethod_20().struct6_0.long_0 * ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0));
				}
				return new Class13.Class28((long)(checked(this.vmethod_18().struct5_0.int_0 * ((Class13.Class26)class24_0).struct5_0.int_0)));
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000E1F4 File Offset: 0x0000C3F4
		public override Class13.Class24 vmethod_62(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				checked
				{
					if (IntPtr.Size == 8)
					{
						return new Class13.Class28(this.vmethod_20().struct6_0.ulong_0 * unchecked((ulong)((Class13.Class26)class24_0).struct5_0.uint_0));
					}
				}
				return new Class13.Class28((long)((ulong)(checked(this.vmethod_18().struct5_0.uint_0 * ((Class13.Class26)class24_0).struct5_0.uint_0))));
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(checked(this.vmethod_20().struct6_0.ulong_0 * ((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0));
				}
				return new Class13.Class28((ulong)(checked(this.vmethod_18().struct5_0.uint_0 * ((Class13.Class28)class24_0).vmethod_18().struct5_0.uint_0)));
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
		public override Class13.Class24 vmethod_63(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 / ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 / ((Class13.Class26)class24_0).struct5_0.int_0));
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 / ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 / ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0));
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		public Class13.Class24 method_7(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0 / this.vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(((Class13.Class26)class24_0).struct5_0.int_0 / this.vmethod_18().struct5_0.int_0));
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0 / this.vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0 / this.vmethod_18().struct5_0.int_0));
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		public override Class13.Class24 vmethod_64(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.ulong_0 / ((Class13.Class26)class24_0).vmethod_20().struct6_0.ulong_0);
				}
				return new Class13.Class28((long)((ulong)(this.vmethod_18().struct5_0.uint_0 / ((Class13.Class26)class24_0).struct5_0.uint_0)));
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.ulong_0 / ((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0);
				}
				return new Class13.Class28((ulong)(this.vmethod_18().struct5_0.uint_0 / ((Class13.Class28)class24_0).vmethod_18().struct5_0.uint_0));
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		public Class13.Class24 method_8(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0 / this.vmethod_20().struct6_0.ulong_0);
				}
				return new Class13.Class28((ulong)(((Class13.Class28)class24_0).vmethod_18().struct5_0.uint_0 / this.vmethod_18().struct5_0.uint_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(((Class13.Class26)class24_0).vmethod_20().struct6_0.ulong_0 / this.vmethod_20().struct6_0.ulong_0);
				}
				return new Class13.Class28((long)((ulong)(((Class13.Class26)class24_0).struct5_0.uint_0 / this.vmethod_18().struct5_0.uint_0)));
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		public override Class13.Class24 vmethod_65(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 % ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 % ((Class13.Class26)class24_0).struct5_0.int_0));
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 % ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 % ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0));
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000E790 File Offset: 0x0000C990
		public Class13.Class24 method_9(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0 % this.vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0 % this.vmethod_18().struct5_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0 % this.vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(((Class13.Class26)class24_0).struct5_0.int_0 % this.vmethod_18().struct5_0.int_0));
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000E880 File Offset: 0x0000CA80
		public override Class13.Class24 vmethod_66(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.ulong_0 % ((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0);
				}
				return new Class13.Class28((ulong)(this.vmethod_18().struct5_0.uint_0 % ((Class13.Class28)class24_0).vmethod_18().struct5_0.uint_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.ulong_0 % ((Class13.Class26)class24_0).vmethod_20().struct6_0.ulong_0);
				}
				return new Class13.Class28((long)((ulong)(this.vmethod_18().struct5_0.uint_0 % ((Class13.Class26)class24_0).struct5_0.uint_0)));
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000E970 File Offset: 0x0000CB70
		public Class13.Class24 method_10(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(((Class13.Class26)class24_0).vmethod_20().struct6_0.ulong_0 % this.vmethod_20().struct6_0.ulong_0);
				}
				return new Class13.Class28((long)((ulong)(((Class13.Class26)class24_0).struct5_0.uint_0 % this.vmethod_18().struct5_0.uint_0)));
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0 % this.vmethod_20().struct6_0.ulong_0);
				}
				return new Class13.Class28((ulong)(((Class13.Class28)class24_0).vmethod_18().struct5_0.uint_0 % this.vmethod_18().struct5_0.uint_0));
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000EA60 File Offset: 0x0000CC60
		public override Class13.Class24 vmethod_67(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 & ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 & ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 & ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 & ((Class13.Class26)class24_0).struct5_0.int_0));
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000EB50 File Offset: 0x0000CD50
		public override Class13.Class24 vmethod_68(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 | ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 | ((Class13.Class26)class24_0).struct5_0.int_0));
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 | ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 | ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0));
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00003805 File Offset: 0x00001A05
		public override Class13.Class24 vmethod_69()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(~this.vmethod_20().struct6_0.long_0);
			}
			return new Class13.Class28((long)(~(long)this.vmethod_18().struct5_0.int_0));
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000EC40 File Offset: 0x0000CE40
		public override Class13.Class24 vmethod_70(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 ^ ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 ^ ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 ^ ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 ^ ((Class13.Class26)class24_0).struct5_0.int_0));
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000ED30 File Offset: 0x0000CF30
		public override Class13.Class24 vmethod_72(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 << ((Class13.Class28)class24_0).vmethod_20().struct6_0.int_0);
				}
				return new Class13.Class28((long)((long)this.vmethod_18().struct5_0.int_0 << ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 << ((Class13.Class26)class24_0).struct5_0.int_0);
				}
				return new Class13.Class28((long)((long)this.vmethod_18().struct5_0.int_0 << ((Class13.Class26)class24_0).struct5_0.int_0));
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000EE28 File Offset: 0x0000D028
		public override Class13.Class24 vmethod_73(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 >> ((Class13.Class26)class24_0).struct5_0.int_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 >> ((Class13.Class26)class24_0).struct5_0.int_0));
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.long_0 >> ((Class13.Class28)class24_0).vmethod_20().struct6_0.int_0);
				}
				return new Class13.Class28((long)(this.vmethod_18().struct5_0.int_0 >> ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0));
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000EF20 File Offset: 0x0000D120
		public override Class13.Class24 vmethod_74(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.ulong_0 >> ((Class13.Class26)class24_0).struct5_0.int_0);
				}
				return new Class13.Class28((long)((ulong)(this.vmethod_18().struct5_0.uint_0 >> ((Class13.Class26)class24_0).struct5_0.int_0)));
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class13.Class28(this.vmethod_20().struct6_0.ulong_0 >> ((Class13.Class28)class24_0).vmethod_20().struct6_0.int_0);
				}
				return new Class13.Class28((long)((ulong)(this.vmethod_18().struct5_0.uint_0 >> ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0)));
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000383D File Offset: 0x00001A3D
		public Class13.Class24 method_11(Class13.Class26 class26_0)
		{
			return new Class13.Class28((long)((ulong)(class26_0.struct5_0.uint_0 >> this.vmethod_18().struct5_0.int_0)));
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00003864 File Offset: 0x00001A64
		public Class13.Class24 method_12(Class13.Class26 class26_0)
		{
			return new Class13.Class28((long)(class26_0.struct5_0.int_0 >> this.vmethod_20().struct6_0.int_0));
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000388B File Offset: 0x00001A8B
		public Class13.Class24 method_13(Class13.Class26 class26_0)
		{
			return new Class13.Class28((long)((long)class26_0.struct5_0.int_0 << this.vmethod_20().struct6_0.int_0));
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000038B2 File Offset: 0x00001AB2
		public override string ToString()
		{
			return this.class25_0.ToString();
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002FE1 File Offset: 0x000011E1
		internal override Class13.Class24 vmethod_8()
		{
			return this;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000243B File Offset: 0x0000063B
		internal override bool vmethod_9()
		{
			return true;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000F018 File Offset: 0x0000D218
		internal override bool vmethod_5(Class13.Class24 class24_0)
		{
			if (class24_0.method_0())
			{
				return false;
			}
			if (class24_0.vmethod_0())
			{
				return ((Class13.Class30)class24_0).vmethod_5(this);
			}
			Class13.Class24 @class = class24_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (@class.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.long_0 == ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0;
				}
				return this.vmethod_18().struct5_0.int_0 == ((Class13.Class26)class24_0).struct5_0.int_0;
			}
			else
			{
				if (@class.epLymgDpIC())
				{
					int size = IntPtr.Size;
					return this.vmethod_20().struct6_0.long_0 == ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0;
				}
				return false;
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
		internal override bool vmethod_6(Class13.Class24 class24_0)
		{
			if (class24_0.method_0())
			{
				return false;
			}
			if (class24_0.vmethod_0())
			{
				return ((Class13.Class30)class24_0).vmethod_6(this);
			}
			Class13.Class24 @class = class24_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (@class.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.ulong_0 != ((Class13.Class26)class24_0).vmethod_20().struct6_0.ulong_0;
				}
				return this.vmethod_18().struct5_0.uint_0 != ((Class13.Class26)class24_0).struct5_0.uint_0;
			}
			else
			{
				if (!@class.epLymgDpIC())
				{
					return false;
				}
				int size = IntPtr.Size;
				return this.vmethod_20().struct6_0.ulong_0 != ((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000F1CC File Offset: 0x0000D3CC
		public override bool vmethod_75(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.long_0 >= ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0;
				}
				return this.vmethod_18().struct5_0.int_0 >= ((Class13.Class26)class24_0).struct5_0.int_0;
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.long_0 >= ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0;
				}
				return this.vmethod_18().struct5_0.int_0 >= ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0;
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		public override bool vmethod_76(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.ulong_0 >= ((Class13.Class26)class24_0).vmethod_20().struct6_0.ulong_0;
				}
				return this.vmethod_18().struct5_0.uint_0 >= ((Class13.Class26)class24_0).struct5_0.uint_0;
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.ulong_0 >= ((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0;
				}
				return this.vmethod_18().struct5_0.uint_0 >= ((Class13.Class28)class24_0).vmethod_18().struct5_0.uint_0;
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000F3A4 File Offset: 0x0000D5A4
		public override bool vmethod_77(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.long_0 > ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0;
				}
				return this.vmethod_18().struct5_0.int_0 > ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.long_0 > ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0;
				}
				return this.vmethod_18().struct5_0.int_0 > ((Class13.Class26)class24_0).struct5_0.int_0;
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000F484 File Offset: 0x0000D684
		public override bool vmethod_78(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.ulong_0 > ((Class13.Class26)class24_0).vmethod_20().struct6_0.ulong_0;
				}
				return this.vmethod_18().struct5_0.uint_0 > ((Class13.Class26)class24_0).struct5_0.uint_0;
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.ulong_0 > ((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0;
				}
				return this.vmethod_18().struct5_0.uint_0 > ((Class13.Class28)class24_0).vmethod_18().struct5_0.uint_0;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000F564 File Offset: 0x0000D764
		public override bool vmethod_79(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.long_0 <= ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0;
				}
				return this.vmethod_18().struct5_0.int_0 <= ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.long_0 <= ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0;
				}
				return this.vmethod_18().struct5_0.int_0 <= ((Class13.Class26)class24_0).struct5_0.int_0;
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000F650 File Offset: 0x0000D850
		public override bool vmethod_80(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.ulong_0 <= ((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0;
				}
				return this.vmethod_18().struct5_0.uint_0 <= ((Class13.Class28)class24_0).vmethod_18().struct5_0.uint_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.ulong_0 <= ((Class13.Class26)class24_0).vmethod_20().struct6_0.ulong_0;
				}
				return this.vmethod_18().struct5_0.uint_0 <= ((Class13.Class26)class24_0).struct5_0.uint_0;
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000F73C File Offset: 0x0000D93C
		public override bool vmethod_81(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (class24_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.long_0 < ((Class13.Class26)class24_0).vmethod_20().struct6_0.long_0;
				}
				return this.vmethod_18().struct5_0.int_0 < ((Class13.Class26)class24_0).struct5_0.int_0;
			}
			else
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.long_0 < ((Class13.Class28)class24_0).vmethod_20().struct6_0.long_0;
				}
				return this.vmethod_18().struct5_0.int_0 < ((Class13.Class28)class24_0).vmethod_18().struct5_0.int_0;
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000F81C File Offset: 0x0000DA1C
		public override bool vmethod_82(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.method_1())
			{
				if (!class24_0.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.ulong_0 < ((Class13.Class28)class24_0).vmethod_20().struct6_0.ulong_0;
				}
				return this.vmethod_18().struct5_0.uint_0 < ((Class13.Class28)class24_0).vmethod_18().struct5_0.uint_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct6_0.ulong_0 < ((Class13.Class26)class24_0).vmethod_20().struct6_0.ulong_0;
				}
				return this.vmethod_18().struct5_0.uint_0 < ((Class13.Class26)class24_0).struct5_0.uint_0;
			}
		}

		// Token: 0x04000081 RID: 129
		public Class13.Class25 class25_0;

		// Token: 0x04000082 RID: 130
		public Class13.Enum2 enum2_0;
	}

	// Token: 0x02000031 RID: 49
	private abstract class Class25 : Class13.Class24
	{
		// Token: 0x0600027C RID: 636
		public abstract bool vmethod_10();

		// Token: 0x0600027D RID: 637
		public abstract bool vmethod_11();

		// Token: 0x0600027E RID: 638
		public abstract Class13.Class24 vmethod_12(Class13.Enum2 enum2_0);

		// Token: 0x0600027F RID: 639
		public abstract Class13.Class26 vmethod_13();

		// Token: 0x06000280 RID: 640
		public abstract Class13.Class26 vmethod_14();

		// Token: 0x06000281 RID: 641
		public abstract Class13.Class26 vmethod_15();

		// Token: 0x06000282 RID: 642
		public abstract Class13.Class26 vmethod_16();

		// Token: 0x06000283 RID: 643
		public abstract Class13.Class26 vmethod_17();

		// Token: 0x06000284 RID: 644
		public abstract Class13.Class26 vmethod_18();

		// Token: 0x06000285 RID: 645
		public abstract Class13.Class26 vmethod_19();

		// Token: 0x06000286 RID: 646
		public abstract Class13.Class27 vmethod_20();

		// Token: 0x06000287 RID: 647
		public abstract Class13.Class27 vmethod_21();

		// Token: 0x06000288 RID: 648
		public abstract Class13.Class26 vmethod_22();

		// Token: 0x06000289 RID: 649
		public abstract Class13.Class26 vmethod_23();

		// Token: 0x0600028A RID: 650
		public abstract Class13.Class26 vmethod_24();

		// Token: 0x0600028B RID: 651
		public abstract Class13.Class27 WdeXooypfm();

		// Token: 0x0600028C RID: 652
		public abstract Class13.Class26 vmethod_25();

		// Token: 0x0600028D RID: 653
		public abstract Class13.Class26 vmethod_26();

		// Token: 0x0600028E RID: 654
		public abstract Class13.Class26 vmethod_27();

		// Token: 0x0600028F RID: 655
		public abstract Class13.Class27 vmethod_28();

		// Token: 0x06000290 RID: 656
		public abstract Class13.Class26 vmethod_29();

		// Token: 0x06000291 RID: 657
		public abstract Class13.Class26 vmethod_30();

		// Token: 0x06000292 RID: 658
		public abstract Class13.Class26 vmethod_31();

		// Token: 0x06000293 RID: 659
		public abstract Class13.Class26 vmethod_32();

		// Token: 0x06000294 RID: 660
		public abstract Class13.Class26 vmethod_33();

		// Token: 0x06000295 RID: 661
		public abstract Class13.Class26 vmethod_34();

		// Token: 0x06000296 RID: 662
		public abstract Class13.Class27 vmethod_35();

		// Token: 0x06000297 RID: 663
		public abstract Class13.Class27 vmethod_36();

		// Token: 0x06000298 RID: 664
		public abstract Class13.Class26 vmethod_37();

		// Token: 0x06000299 RID: 665
		public abstract Class13.Class26 vmethod_38();

		// Token: 0x0600029A RID: 666
		public abstract Class13.Class26 vmethod_39();

		// Token: 0x0600029B RID: 667
		public abstract Class13.Class26 vmethod_40();

		// Token: 0x0600029C RID: 668
		public abstract Class13.Class26 vmethod_41();

		// Token: 0x0600029D RID: 669
		public abstract Class13.Class26 vmethod_42();

		// Token: 0x0600029E RID: 670
		public abstract Class13.Class27 vmethod_43();

		// Token: 0x0600029F RID: 671
		public abstract Class13.Class27 vmethod_44();

		// Token: 0x060002A0 RID: 672
		public abstract Class13.Class29 vmethod_45();

		// Token: 0x060002A1 RID: 673
		public abstract Class13.Class29 vmethod_46();

		// Token: 0x060002A2 RID: 674
		public abstract Class13.Class29 NkkgOoOrdR();

		// Token: 0x060002A3 RID: 675
		public abstract Class13.Class28 vmethod_47();

		// Token: 0x060002A4 RID: 676
		public abstract Class13.Class28 vmethod_48();

		// Token: 0x060002A5 RID: 677
		public abstract Class13.Class28 vmethod_49();

		// Token: 0x060002A6 RID: 678
		public abstract Class13.Class28 vmethod_50();

		// Token: 0x060002A7 RID: 679
		public abstract Class13.Class28 vmethod_51();

		// Token: 0x060002A8 RID: 680
		public abstract Class13.Class28 vmethod_52();

		// Token: 0x060002A9 RID: 681
		public abstract Class13.Class24 vmethod_53();

		// Token: 0x060002AA RID: 682
		public abstract Class13.Class24 vmethod_54(Class13.Class24 class24_0);

		// Token: 0x060002AB RID: 683
		public abstract Class13.Class24 vmethod_55(Class13.Class24 class24_0);

		// Token: 0x060002AC RID: 684
		public abstract Class13.Class24 vmethod_56(Class13.Class24 class24_0);

		// Token: 0x060002AD RID: 685
		public abstract Class13.Class24 vmethod_57(Class13.Class24 class24_0);

		// Token: 0x060002AE RID: 686
		public abstract Class13.Class24 vmethod_58(Class13.Class24 class24_0);

		// Token: 0x060002AF RID: 687
		public abstract Class13.Class24 vmethod_59(Class13.Class24 class24_0);

		// Token: 0x060002B0 RID: 688
		public abstract Class13.Class24 vmethod_60(Class13.Class24 class24_0);

		// Token: 0x060002B1 RID: 689
		public abstract Class13.Class24 vmethod_61(Class13.Class24 class24_0);

		// Token: 0x060002B2 RID: 690
		public abstract Class13.Class24 vmethod_62(Class13.Class24 class24_0);

		// Token: 0x060002B3 RID: 691
		public abstract Class13.Class24 vmethod_63(Class13.Class24 class24_0);

		// Token: 0x060002B4 RID: 692
		public abstract Class13.Class24 vmethod_64(Class13.Class24 class24_0);

		// Token: 0x060002B5 RID: 693
		public abstract Class13.Class24 vmethod_65(Class13.Class24 class24_0);

		// Token: 0x060002B6 RID: 694
		public abstract Class13.Class24 vmethod_66(Class13.Class24 class24_0);

		// Token: 0x060002B7 RID: 695
		public abstract Class13.Class24 vmethod_67(Class13.Class24 class24_0);

		// Token: 0x060002B8 RID: 696
		public abstract Class13.Class24 vmethod_68(Class13.Class24 class24_0);

		// Token: 0x060002B9 RID: 697
		public abstract Class13.Class24 vmethod_69();

		// Token: 0x060002BA RID: 698
		public abstract Class13.Class24 vmethod_70(Class13.Class24 class24_0);

		// Token: 0x060002BB RID: 699
		public abstract Class13.Class25 vmethod_71();

		// Token: 0x060002BC RID: 700
		public abstract Class13.Class24 vmethod_72(Class13.Class24 class24_0);

		// Token: 0x060002BD RID: 701
		public abstract Class13.Class24 vmethod_73(Class13.Class24 class24_0);

		// Token: 0x060002BE RID: 702
		public abstract Class13.Class24 vmethod_74(Class13.Class24 class24_0);

		// Token: 0x060002BF RID: 703
		public abstract bool vmethod_75(Class13.Class24 class24_0);

		// Token: 0x060002C0 RID: 704
		public abstract bool vmethod_76(Class13.Class24 class24_0);

		// Token: 0x060002C1 RID: 705
		public abstract bool vmethod_77(Class13.Class24 class24_0);

		// Token: 0x060002C2 RID: 706
		public abstract bool vmethod_78(Class13.Class24 class24_0);

		// Token: 0x060002C3 RID: 707
		public abstract bool vmethod_79(Class13.Class24 class24_0);

		// Token: 0x060002C4 RID: 708
		public abstract bool vmethod_80(Class13.Class24 class24_0);

		// Token: 0x060002C5 RID: 709
		public abstract bool vmethod_81(Class13.Class24 class24_0);

		// Token: 0x060002C6 RID: 710
		public abstract bool vmethod_82(Class13.Class24 class24_0);

		// Token: 0x060002C7 RID: 711 RVA: 0x0000243B File Offset: 0x0000063B
		internal override bool vmethod_3()
		{
			return true;
		}
	}

	// Token: 0x02000032 RID: 50
	private class Class29 : Class13.Class25
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x000038C7 File Offset: 0x00001AC7
		internal override void zhnXqoJuKJ(Class13.Class24 class24_0)
		{
			this.double_0 = ((Class13.Class29)class24_0).double_0;
			this.enum2_0 = ((Class13.Class29)class24_0).enum2_0;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002B4C File Offset: 0x00000D4C
		internal override void vmethod_2(Class13.Class24 class24_0)
		{
			this.zhnXqoJuKJ(class24_0);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000038EB File Offset: 0x00001AEB
		public Class29(double double_1)
		{
			this.enum5_0 = (Class13.Enum5)5;
			this.enum2_0 = (Class13.Enum2)10;
			this.double_0 = double_1;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003909 File Offset: 0x00001B09
		public Class29(Class13.Class29 class29_0)
		{
			this.enum5_0 = class29_0.enum5_0;
			this.enum2_0 = class29_0.enum2_0;
			this.double_0 = class29_0.double_0;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00003935 File Offset: 0x00001B35
		public override Class13.Class25 vmethod_71()
		{
			return new Class13.Class29(this);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000393D File Offset: 0x00001B3D
		public Class29(double double_1, Class13.Enum2 enum2_1)
		{
			this.enum5_0 = (Class13.Enum5)5;
			this.double_0 = double_1;
			this.enum2_0 = enum2_1;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000395A File Offset: 0x00001B5A
		public Class29(float float_0)
		{
			this.enum5_0 = (Class13.Enum5)5;
			this.double_0 = (double)float_0;
			this.enum2_0 = (Class13.Enum2)9;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00003979 File Offset: 0x00001B79
		public Class29(float float_0, Class13.Enum2 enum2_1)
		{
			this.enum5_0 = (Class13.Enum5)5;
			this.double_0 = (double)float_0;
			this.enum2_0 = enum2_1;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00003997 File Offset: 0x00001B97
		public override bool vmethod_10()
		{
			return this.double_0 == 0.0;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002C4F File Offset: 0x00000E4F
		public override bool vmethod_11()
		{
			return !this.vmethod_10();
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000039AA File Offset: 0x00001BAA
		public override string ToString()
		{
			return this.double_0.ToString();
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		public override Class13.Class24 vmethod_12(Class13.Enum2 enum2_1)
		{
			switch (enum2_1)
			{
			case (Class13.Enum2)1:
				return this.vmethod_14();
			case (Class13.Enum2)2:
				return this.vmethod_15();
			case (Class13.Enum2)3:
				return this.vmethod_16();
			case (Class13.Enum2)4:
				return this.vmethod_17();
			case (Class13.Enum2)5:
				return this.vmethod_18();
			case (Class13.Enum2)6:
				return this.vmethod_19();
			case (Class13.Enum2)7:
				return this.vmethod_20();
			case (Class13.Enum2)8:
				return this.vmethod_21();
			case (Class13.Enum2)9:
				return this.vmethod_45();
			case (Class13.Enum2)10:
				return this.vmethod_46();
			case (Class13.Enum2)11:
				return this.vmethod_13();
			default:
				throw new Exception(((Class13.Enum6)4).ToString());
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000F9A0 File Offset: 0x0000DBA0
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(float))
			{
				return (float)this.double_0;
			}
			if (type_0 == typeof(double))
			{
				return this.double_0;
			}
			if ((type_0 == null || type_0 == typeof(object)) && this.enum2_0 == (Class13.Enum2)9)
			{
				return (float)this.double_0;
			}
			return this.double_0;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000039B7 File Offset: 0x00001BB7
		public override Class13.Class26 vmethod_13()
		{
			return new Class13.Class26((this.vmethod_10() > false) ? 1 : 0);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002C6A File Offset: 0x00000E6A
		internal override bool vmethod_7()
		{
			return this.vmethod_11();
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000039C7 File Offset: 0x00001BC7
		public override Class13.Class26 vmethod_14()
		{
			return new Class13.Class26((int)((sbyte)this.double_0), (Class13.Enum2)1);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000039D6 File Offset: 0x00001BD6
		public override Class13.Class26 vmethod_15()
		{
			return new Class13.Class26((uint)((byte)this.double_0), (Class13.Enum2)2);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000039E5 File Offset: 0x00001BE5
		public override Class13.Class26 vmethod_16()
		{
			return new Class13.Class26((int)((short)this.double_0), (Class13.Enum2)3);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000039F4 File Offset: 0x00001BF4
		public override Class13.Class26 vmethod_17()
		{
			return new Class13.Class26((uint)((ushort)this.double_0), (Class13.Enum2)4);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00003A03 File Offset: 0x00001C03
		public override Class13.Class26 vmethod_18()
		{
			return new Class13.Class26((int)this.double_0, (Class13.Enum2)5);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00003A12 File Offset: 0x00001C12
		public override Class13.Class26 vmethod_19()
		{
			return new Class13.Class26((uint)this.double_0, (Class13.Enum2)6);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00003A21 File Offset: 0x00001C21
		public override Class13.Class27 vmethod_20()
		{
			return new Class13.Class27((long)this.double_0, (Class13.Enum2)7);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00003A30 File Offset: 0x00001C30
		public override Class13.Class27 vmethod_21()
		{
			return new Class13.Class27((ulong)this.double_0, (Class13.Enum2)8);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002D20 File Offset: 0x00000F20
		public override Class13.Class26 vmethod_22()
		{
			return this.vmethod_14();
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002D28 File Offset: 0x00000F28
		public override Class13.Class26 vmethod_23()
		{
			return this.vmethod_16();
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002D30 File Offset: 0x00000F30
		public override Class13.Class26 vmethod_24()
		{
			return this.vmethod_18();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002D38 File Offset: 0x00000F38
		public override Class13.Class27 WdeXooypfm()
		{
			return this.vmethod_20();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002D40 File Offset: 0x00000F40
		public override Class13.Class26 vmethod_25()
		{
			return this.vmethod_15();
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002D48 File Offset: 0x00000F48
		public override Class13.Class26 vmethod_26()
		{
			return this.vmethod_17();
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002D50 File Offset: 0x00000F50
		public override Class13.Class26 vmethod_27()
		{
			return this.vmethod_19();
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002D58 File Offset: 0x00000F58
		public override Class13.Class27 vmethod_28()
		{
			return this.vmethod_21();
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00003A3F File Offset: 0x00001C3F
		public override Class13.Class26 vmethod_29()
		{
			return new Class13.Class26((int)(checked((sbyte)this.double_0)), (Class13.Enum2)1);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00003A3F File Offset: 0x00001C3F
		public override Class13.Class26 vmethod_30()
		{
			return new Class13.Class26((int)(checked((sbyte)this.double_0)), (Class13.Enum2)1);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00003A4E File Offset: 0x00001C4E
		public override Class13.Class26 vmethod_31()
		{
			return new Class13.Class26((int)(checked((short)this.double_0)), (Class13.Enum2)3);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00003A4E File Offset: 0x00001C4E
		public override Class13.Class26 vmethod_32()
		{
			return new Class13.Class26((int)(checked((short)this.double_0)), (Class13.Enum2)3);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00003A5D File Offset: 0x00001C5D
		public override Class13.Class26 vmethod_33()
		{
			return new Class13.Class26(checked((int)this.double_0), (Class13.Enum2)5);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00003A5D File Offset: 0x00001C5D
		public override Class13.Class26 vmethod_34()
		{
			return new Class13.Class26(checked((int)this.double_0), (Class13.Enum2)5);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00003A6C File Offset: 0x00001C6C
		public override Class13.Class27 vmethod_35()
		{
			return new Class13.Class27(checked((long)this.double_0), (Class13.Enum2)7);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00003A6C File Offset: 0x00001C6C
		public override Class13.Class27 vmethod_36()
		{
			return new Class13.Class27(checked((long)this.double_0), (Class13.Enum2)7);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00003A7B File Offset: 0x00001C7B
		public override Class13.Class26 vmethod_37()
		{
			return new Class13.Class26((int)(checked((byte)this.double_0)), (Class13.Enum2)2);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00003A7B File Offset: 0x00001C7B
		public override Class13.Class26 vmethod_38()
		{
			return new Class13.Class26((int)(checked((byte)this.double_0)), (Class13.Enum2)2);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00003A8A File Offset: 0x00001C8A
		public override Class13.Class26 vmethod_39()
		{
			return new Class13.Class26((int)(checked((ushort)this.double_0)), (Class13.Enum2)4);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00003A8A File Offset: 0x00001C8A
		public override Class13.Class26 vmethod_40()
		{
			return new Class13.Class26((int)(checked((ushort)this.double_0)), (Class13.Enum2)4);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00003A99 File Offset: 0x00001C99
		public override Class13.Class26 vmethod_41()
		{
			return new Class13.Class26(checked((uint)this.double_0), (Class13.Enum2)6);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00003A99 File Offset: 0x00001C99
		public override Class13.Class26 vmethod_42()
		{
			return new Class13.Class26(checked((uint)this.double_0), (Class13.Enum2)6);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00003AA8 File Offset: 0x00001CA8
		public override Class13.Class27 vmethod_43()
		{
			return new Class13.Class27(checked((ulong)this.double_0), (Class13.Enum2)8);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003AA8 File Offset: 0x00001CA8
		public override Class13.Class27 vmethod_44()
		{
			return new Class13.Class27(checked((ulong)this.double_0), (Class13.Enum2)8);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00003AB7 File Offset: 0x00001CB7
		public override Class13.Class29 vmethod_45()
		{
			return new Class13.Class29((float)this.double_0, (Class13.Enum2)9);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00003AC7 File Offset: 0x00001CC7
		public override Class13.Class29 vmethod_46()
		{
			return new Class13.Class29(this.double_0, (Class13.Enum2)10);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00003AD7 File Offset: 0x00001CD7
		public override Class13.Class29 NkkgOoOrdR()
		{
			return new Class13.Class29(this.double_0);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002E8A File Offset: 0x0000108A
		public override Class13.Class28 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.WdeXooypfm().struct6_0.long_0);
			}
			return new Class13.Class28((long)this.vmethod_24().struct5_0.int_0);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002EC0 File Offset: 0x000010C0
		public override Class13.Class28 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_28().struct6_0.ulong_0);
			}
			return new Class13.Class28((ulong)this.vmethod_27().struct5_0.uint_0);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002EF6 File Offset: 0x000010F6
		public override Class13.Class28 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_35().struct6_0.long_0);
			}
			return new Class13.Class28((long)this.vmethod_33().struct5_0.int_0);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002F2C File Offset: 0x0000112C
		public override Class13.Class28 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_43().struct6_0.ulong_0);
			}
			return new Class13.Class28((ulong)this.vmethod_41().struct5_0.uint_0);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002F62 File Offset: 0x00001162
		public override Class13.Class28 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_36().struct6_0.long_0);
			}
			return new Class13.Class28((long)this.vmethod_34().struct5_0.int_0);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002F98 File Offset: 0x00001198
		public override Class13.Class28 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class13.Class28(this.vmethod_44().struct6_0.ulong_0);
			}
			return new Class13.Class28((ulong)this.vmethod_42().struct5_0.uint_0);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00003AE5 File Offset: 0x00001CE5
		public override Class13.Class24 vmethod_53()
		{
			if (this.enum2_0 == (Class13.Enum2)9)
			{
				return new Class13.Class29((float)(-(float)this.double_0));
			}
			return new Class13.Class29(-this.double_0);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00003B0C File Offset: 0x00001D0C
		public override Class13.Class24 vmethod_54(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 + ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00003B0C File Offset: 0x00001D0C
		public override Class13.Class24 vmethod_55(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 + ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00003B0C File Offset: 0x00001D0C
		public override Class13.Class24 vmethod_56(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 + ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00003B43 File Offset: 0x00001D43
		public override Class13.Class24 vmethod_57(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 - ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00003B43 File Offset: 0x00001D43
		public override Class13.Class24 vmethod_58(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 - ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00003B43 File Offset: 0x00001D43
		public override Class13.Class24 vmethod_59(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 - ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00003B7A File Offset: 0x00001D7A
		public override Class13.Class24 vmethod_60(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn() || !class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 * ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00003BB9 File Offset: 0x00001DB9
		public override Class13.Class24 vmethod_61(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 * ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003BB9 File Offset: 0x00001DB9
		public override Class13.Class24 vmethod_62(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 * ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00003BF0 File Offset: 0x00001DF0
		public override Class13.Class24 vmethod_63(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 / ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00003BF0 File Offset: 0x00001DF0
		public override Class13.Class24 vmethod_64(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 / ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00003C27 File Offset: 0x00001E27
		public override Class13.Class24 vmethod_65(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 % ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00003C27 File Offset: 0x00001E27
		public override Class13.Class24 vmethod_66(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return new Class13.Class29(this.double_0 % ((Class13.Class29)class24_0).double_0);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00003C5E File Offset: 0x00001E5E
		public override Class13.Class24 vmethod_67(Class13.Class24 class24_0)
		{
			throw new Class13.Exception1();
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00003C5E File Offset: 0x00001E5E
		public override Class13.Class24 vmethod_68(Class13.Class24 class24_0)
		{
			throw new Class13.Exception1();
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00003C5E File Offset: 0x00001E5E
		public override Class13.Class24 vmethod_69()
		{
			throw new Class13.Exception1();
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00003C5E File Offset: 0x00001E5E
		public override Class13.Class24 vmethod_70(Class13.Class24 class24_0)
		{
			throw new Class13.Exception1();
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00003C5E File Offset: 0x00001E5E
		public override Class13.Class24 vmethod_72(Class13.Class24 class24_0)
		{
			throw new Class13.Exception1();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00003C5E File Offset: 0x00001E5E
		public override Class13.Class24 vmethod_73(Class13.Class24 class24_0)
		{
			throw new Class13.Exception1();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00003C5E File Offset: 0x00001E5E
		public override Class13.Class24 vmethod_74(Class13.Class24 class24_0)
		{
			throw new Class13.Exception1();
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002FE1 File Offset: 0x000011E1
		internal override Class13.Class24 vmethod_8()
		{
			return this;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000FA40 File Offset: 0x0000DC40
		internal override bool vmethod_5(Class13.Class24 class24_0)
		{
			if (class24_0.method_0())
			{
				return false;
			}
			if (class24_0.vmethod_0())
			{
				return ((Class13.Class30)class24_0).vmethod_5(this);
			}
			Class13.Class24 @class = class24_0.vmethod_8();
			return @class.uMpydVvbAn() && this.double_0 == ((Class13.Class29)@class).double_0;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000FA90 File Offset: 0x0000DC90
		internal override bool vmethod_6(Class13.Class24 class24_0)
		{
			if (class24_0.method_0())
			{
				return false;
			}
			if (class24_0.vmethod_0())
			{
				return ((Class13.Class30)class24_0).vmethod_6(this);
			}
			Class13.Class24 @class = class24_0.vmethod_8();
			return @class.uMpydVvbAn() && this.double_0 != ((Class13.Class29)@class).double_0;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00003C65 File Offset: 0x00001E65
		public override bool vmethod_75(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return this.double_0 >= ((Class13.Class29)class24_0).double_0;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00003C65 File Offset: 0x00001E65
		public override bool vmethod_76(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return this.double_0 >= ((Class13.Class29)class24_0).double_0;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00003C9B File Offset: 0x00001E9B
		public override bool vmethod_77(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return this.double_0 > ((Class13.Class29)class24_0).double_0;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00003C9B File Offset: 0x00001E9B
		public override bool vmethod_78(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return this.double_0 > ((Class13.Class29)class24_0).double_0;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00003CCE File Offset: 0x00001ECE
		public override bool vmethod_79(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return this.double_0 <= ((Class13.Class29)class24_0).double_0;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00003CCE File Offset: 0x00001ECE
		public override bool vmethod_80(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return this.double_0 <= ((Class13.Class29)class24_0).double_0;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00003D04 File Offset: 0x00001F04
		public override bool vmethod_81(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return this.double_0 < ((Class13.Class29)class24_0).double_0;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003D04 File Offset: 0x00001F04
		public override bool vmethod_82(Class13.Class24 class24_0)
		{
			if (class24_0.vmethod_0())
			{
				class24_0 = class24_0.vmethod_8();
			}
			if (!class24_0.uMpydVvbAn())
			{
				throw new Class13.Exception1();
			}
			return this.double_0 < ((Class13.Class29)class24_0).double_0;
		}

		// Token: 0x04000083 RID: 131
		public double double_0;

		// Token: 0x04000084 RID: 132
		public Class13.Enum2 enum2_0;
	}

	// Token: 0x02000033 RID: 51
	internal enum Enum2 : byte
	{

	}

	// Token: 0x02000034 RID: 52
	internal enum Enum3 : byte
	{

	}

	// Token: 0x02000035 RID: 53
	private class Exception0 : Exception
	{
		// Token: 0x06000321 RID: 801 RVA: 0x00003D37 File Offset: 0x00001F37
		public Exception0(string string_0)
			: base(string_0)
		{
		}
	}

	// Token: 0x02000036 RID: 54
	private class Exception1 : Exception
	{
		// Token: 0x06000322 RID: 802 RVA: 0x00003D40 File Offset: 0x00001F40
		public Exception1()
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00003D37 File Offset: 0x00001F37
		public Exception1(string string_0)
			: base(string_0)
		{
		}
	}

	// Token: 0x02000037 RID: 55
	internal class Class14
	{
		// Token: 0x06000324 RID: 804 RVA: 0x0000FAE4 File Offset: 0x0000DCE4
		public override string ToString()
		{
			object obj = this.enum4_0;
			if (this.object_0 != null)
			{
				return obj.ToString() + "H" + this.object_0.ToString();
			}
			return obj.ToString();
		}

		// Token: 0x04000087 RID: 135
		internal Class13.Enum4 enum4_0 = (Class13.Enum4)126;

		// Token: 0x04000088 RID: 136
		internal object object_0;
	}

	// Token: 0x02000038 RID: 56
	internal abstract class Class30 : Class13.Class24
	{
		// Token: 0x06000326 RID: 806 RVA: 0x000038BF File Offset: 0x00001ABF
		public Class30()
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000243B File Offset: 0x0000063B
		internal override bool vmethod_0()
		{
			return true;
		}

		// Token: 0x06000328 RID: 808
		internal abstract IntPtr vmethod_10();

		// Token: 0x06000329 RID: 809
		internal abstract void vmethod_11(Class13.Class24 class24_0);

		// Token: 0x0600032A RID: 810 RVA: 0x0000243B File Offset: 0x0000063B
		internal override bool vmethod_1()
		{
			return true;
		}
	}

	// Token: 0x02000039 RID: 57
	internal class Class31 : Class13.Class30
	{
		// Token: 0x0600032B RID: 811 RVA: 0x00003D58 File Offset: 0x00001F58
		public Class31(int int_1, Class13.Class22 class22_1)
		{
			this.class22_0 = class22_1;
			this.int_0 = int_1;
			this.enum5_0 = (Class13.Enum5)7;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000FB28 File Offset: 0x0000DD28
		internal override void zhnXqoJuKJ(Class13.Class24 class24_0)
		{
			if (class24_0 is Class13.Class31)
			{
				this.class22_0 = ((Class13.Class31)class24_0).class22_0;
				this.int_0 = ((Class13.Class31)class24_0).int_0;
				return;
			}
			Class13.Class16 @class = this.class22_0.class19_0.list_1[this.int_0];
			if (class24_0 is Class13.Class30 && (@class.enum2_0 & (Class13.Enum2)226) > (Class13.Enum2)0)
			{
				Class13.Class24 class2 = (class24_0 as Class13.Class30).vmethod_8();
				this.vmethod_11(class2);
				return;
			}
			this.vmethod_11(class24_0);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00003D75 File Offset: 0x00001F75
		internal override void vmethod_2(Class13.Class24 class24_0)
		{
			this.vmethod_11(class24_0);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00003D7E File Offset: 0x00001F7E
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00003D85 File Offset: 0x00001F85
		internal override void vmethod_11(Class13.Class24 class24_0)
		{
			this.class22_0.class24_1[this.int_0] = class24_0;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00003D9A File Offset: 0x00001F9A
		internal override object vmethod_4(Type type_0)
		{
			if (this.class22_0.class24_1[this.int_0] != null)
			{
				return this.vmethod_8().vmethod_4(type_0);
			}
			return null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003DBE File Offset: 0x00001FBE
		internal override Class13.Class24 vmethod_8()
		{
			if (this.class22_0.class24_1[this.int_0] != null)
			{
				return this.class22_0.class24_1[this.int_0].vmethod_8();
			}
			return new Class13.Class36(null);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00003DF2 File Offset: 0x00001FF2
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00003DFF File Offset: 0x00001FFF
		internal override bool vmethod_5(Class13.Class24 class24_0)
		{
			return class24_0.vmethod_0() && class24_0 is Class13.Class31 && ((Class13.Class31)class24_0).int_0 == this.int_0;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00003E2B File Offset: 0x0000202B
		internal override bool vmethod_6(Class13.Class24 class24_0)
		{
			return !class24_0.vmethod_0() || !(class24_0 is Class13.Class31) || ((Class13.Class31)class24_0).int_0 != this.int_0;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00003E57 File Offset: 0x00002057
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x04000089 RID: 137
		private Class13.Class22 class22_0;

		// Token: 0x0400008A RID: 138
		internal int int_0;
	}

	// Token: 0x0200003A RID: 58
	internal class Class32 : Class13.Class30
	{
		// Token: 0x06000336 RID: 822 RVA: 0x00003E64 File Offset: 0x00002064
		public Class32(int int_1, Array array_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
			this.enum5_0 = (Class13.Enum5)7;
			if (array_1 != null)
			{
				this.array_0.GetType().GetElementType();
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00003D7E File Offset: 0x00001F7E
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00003E95 File Offset: 0x00002095
		internal override void zhnXqoJuKJ(Class13.Class24 class24_0)
		{
			if (class24_0 is Class13.Class32)
			{
				this.array_0 = ((Class13.Class32)class24_0).array_0;
				this.int_0 = ((Class13.Class32)class24_0).int_0;
				return;
			}
			this.vmethod_11(class24_0);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00003D75 File Offset: 0x00001F75
		internal override void vmethod_2(Class13.Class24 class24_0)
		{
			this.vmethod_11(class24_0);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000FBB0 File Offset: 0x0000DDB0
		internal override void vmethod_11(Class13.Class24 class24_0)
		{
			object obj = class24_0.vmethod_4(null);
			this.array_0.SetValue(obj, this.int_0);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00003EC9 File Offset: 0x000020C9
		internal override object vmethod_4(Type type_0)
		{
			return this.vmethod_8().vmethod_4(type_0);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00003ED7 File Offset: 0x000020D7
		internal override Class13.Class24 vmethod_8()
		{
			return Class13.Class24.smethod_1(this.array_0.GetType().GetElementType(), this.array_0.GetValue(this.int_0));
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00003DF2 File Offset: 0x00001FF2
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000FBD8 File Offset: 0x0000DDD8
		internal override bool vmethod_5(Class13.Class24 class24_0)
		{
			if (!class24_0.vmethod_0())
			{
				return false;
			}
			if (class24_0 is Class13.Class32)
			{
				Class13.Class32 @class = (Class13.Class32)class24_0;
				return @class.int_0 == this.int_0 && @class.array_0 == this.array_0;
			}
			return false;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000FC24 File Offset: 0x0000DE24
		internal override bool vmethod_6(Class13.Class24 class24_0)
		{
			if (!class24_0.vmethod_0())
			{
				return true;
			}
			if (class24_0 is Class13.Class32)
			{
				Class13.Class32 @class = (Class13.Class32)class24_0;
				return @class.int_0 != this.int_0 || @class.array_0 != this.array_0;
			}
			return true;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00003E57 File Offset: 0x00002057
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x0400008B RID: 139
		private Array array_0;

		// Token: 0x0400008C RID: 140
		internal int int_0;
	}

	// Token: 0x0200003B RID: 59
	internal class Class33 : Class13.Class30
	{
		// Token: 0x06000341 RID: 833 RVA: 0x00003EFF File Offset: 0x000020FF
		public Class33(FieldInfo fieldInfo_1, object object_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.object_0 = object_1;
			this.enum5_0 = (Class13.Enum5)7;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00003D7E File Offset: 0x00001F7E
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000FC70 File Offset: 0x0000DE70
		internal override void vmethod_11(Class13.Class24 class24_0)
		{
			if (this.object_0 != null && this.object_0 is Class13.Class24)
			{
				this.fieldInfo_0.SetValue(((Class13.Class24)this.object_0).vmethod_4(null), class24_0.vmethod_4(null));
				return;
			}
			this.fieldInfo_0.SetValue(this.object_0, class24_0.vmethod_4(null));
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00003F1C File Offset: 0x0000211C
		internal override void zhnXqoJuKJ(Class13.Class24 class24_0)
		{
			if (class24_0 is Class13.Class33)
			{
				this.fieldInfo_0 = ((Class13.Class33)class24_0).fieldInfo_0;
				this.object_0 = ((Class13.Class33)class24_0).object_0;
				return;
			}
			this.vmethod_11(class24_0);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00003D75 File Offset: 0x00001F75
		internal override void vmethod_2(Class13.Class24 class24_0)
		{
			this.vmethod_11(class24_0);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00003EC9 File Offset: 0x000020C9
		internal override object vmethod_4(Type type_0)
		{
			return this.vmethod_8().vmethod_4(type_0);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000FCD0 File Offset: 0x0000DED0
		internal override Class13.Class24 vmethod_8()
		{
			if (this.object_0 != null && this.object_0 is Class13.Class24)
			{
				return Class13.Class24.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(((Class13.Class24)this.object_0).vmethod_4(null)));
			}
			return Class13.Class24.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(this.object_0));
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00003DF2 File Offset: 0x00001FF2
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000FD40 File Offset: 0x0000DF40
		internal override bool vmethod_5(Class13.Class24 class24_0)
		{
			if (!class24_0.vmethod_0())
			{
				return false;
			}
			if (class24_0 is Class13.Class33)
			{
				Class13.Class33 @class = (Class13.Class33)class24_0;
				return !(@class.fieldInfo_0 != this.fieldInfo_0) && @class.object_0 == this.object_0;
			}
			return false;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000FD90 File Offset: 0x0000DF90
		internal override bool vmethod_6(Class13.Class24 class24_0)
		{
			if (!class24_0.vmethod_0())
			{
				return true;
			}
			if (!(class24_0 is Class13.Class33))
			{
				return true;
			}
			Class13.Class33 @class = (Class13.Class33)class24_0;
			return @class.fieldInfo_0 != this.fieldInfo_0 || @class.object_0 != this.object_0;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00003E57 File Offset: 0x00002057
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x0400008D RID: 141
		internal FieldInfo fieldInfo_0;

		// Token: 0x0400008E RID: 142
		internal object object_0;
	}

	// Token: 0x0200003C RID: 60
	internal class Class34 : Class13.Class30
	{
		// Token: 0x0600034C RID: 844 RVA: 0x00003F50 File Offset: 0x00002150
		public Class34(int int_1, Class13.Class22 class22_1)
		{
			this.class22_0 = class22_1;
			this.int_0 = int_1;
			this.enum5_0 = (Class13.Enum5)7;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00003D7E File Offset: 0x00001F7E
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00003F6D File Offset: 0x0000216D
		internal override void zhnXqoJuKJ(Class13.Class24 class24_0)
		{
			if (class24_0 is Class13.Class34)
			{
				this.class22_0 = ((Class13.Class34)class24_0).class22_0;
				this.int_0 = ((Class13.Class34)class24_0).int_0;
				return;
			}
			this.vmethod_11(class24_0);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00003D75 File Offset: 0x00001F75
		internal override void vmethod_2(Class13.Class24 class24_0)
		{
			this.vmethod_11(class24_0);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003FA1 File Offset: 0x000021A1
		internal override void vmethod_11(Class13.Class24 class24_0)
		{
			this.class22_0.class24_0[this.int_0] = class24_0;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00003FB6 File Offset: 0x000021B6
		internal override object vmethod_4(Type type_0)
		{
			if (this.class22_0.class24_0[this.int_0] == null)
			{
				return null;
			}
			return this.vmethod_8().vmethod_4(type_0);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00003FDA File Offset: 0x000021DA
		internal override Class13.Class24 vmethod_8()
		{
			if (this.class22_0.class24_0[this.int_0] != null)
			{
				return this.class22_0.class24_0[this.int_0].vmethod_8();
			}
			return new Class13.Class36(null);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00003DF2 File Offset: 0x00001FF2
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000400E File Offset: 0x0000220E
		internal override bool vmethod_5(Class13.Class24 class24_0)
		{
			return class24_0.vmethod_0() && class24_0 is Class13.Class34 && ((Class13.Class34)class24_0).int_0 == this.int_0;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00004037 File Offset: 0x00002237
		internal override bool vmethod_6(Class13.Class24 class24_0)
		{
			return !class24_0.vmethod_0() || !(class24_0 is Class13.Class34) || ((Class13.Class34)class24_0).int_0 != this.int_0;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003E57 File Offset: 0x00002057
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x0400008F RID: 143
		private Class13.Class22 class22_0;

		// Token: 0x04000090 RID: 144
		internal int int_0;
	}

	// Token: 0x0200003D RID: 61
	internal class Class35 : Class13.Class30
	{
		// Token: 0x06000357 RID: 855 RVA: 0x00004063 File Offset: 0x00002263
		public Class35(Class13.Class24 class24_1, Type type_1)
		{
			this.class24_0 = class24_1;
			this.type_0 = type_1;
			this.enum5_0 = (Class13.Enum5)7;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00003D7E File Offset: 0x00001F7E
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00004080 File Offset: 0x00002280
		internal override void zhnXqoJuKJ(Class13.Class24 class24_1)
		{
			if (!(class24_1 is Class13.Class35))
			{
				this.class24_0.zhnXqoJuKJ(class24_1);
				return;
			}
			this.type_0 = ((Class13.Class35)class24_1).type_0;
			this.class24_0 = ((Class13.Class35)class24_1).class24_0;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003D75 File Offset: 0x00001F75
		internal override void vmethod_2(Class13.Class24 class24_1)
		{
			this.vmethod_11(class24_1);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000040B9 File Offset: 0x000022B9
		internal override void vmethod_11(Class13.Class24 class24_1)
		{
			this.class24_0 = class24_1;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		internal override object vmethod_4(Type type_1)
		{
			if (this.class24_0 == null)
			{
				return new Class13.Class36(null);
			}
			if (!(type_1 == null) && !(type_1 == typeof(object)))
			{
				return this.class24_0.vmethod_4(type_1);
			}
			return this.class24_0.vmethod_4(this.type_0);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000040C2 File Offset: 0x000022C2
		internal override Class13.Class24 vmethod_8()
		{
			if (this.class24_0 == null)
			{
				return new Class13.Class36(null);
			}
			return this.class24_0.vmethod_8();
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00003DF2 File Offset: 0x00001FF2
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000FE38 File Offset: 0x0000E038
		internal override bool vmethod_5(Class13.Class24 class24_1)
		{
			if (!class24_1.vmethod_0())
			{
				return false;
			}
			if (!(class24_1 is Class13.Class35))
			{
				return false;
			}
			Class13.Class35 @class = (Class13.Class35)class24_1;
			if (@class.type_0 != this.type_0)
			{
				return false;
			}
			if (this.class24_0 != null)
			{
				return this.class24_0.vmethod_5(@class.class24_0);
			}
			return @class.class24_0 == null;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000FE9C File Offset: 0x0000E09C
		internal override bool vmethod_6(Class13.Class24 class24_1)
		{
			if (!class24_1.vmethod_0())
			{
				return true;
			}
			if (!(class24_1 is Class13.Class35))
			{
				return true;
			}
			Class13.Class35 @class = (Class13.Class35)class24_1;
			if (@class.type_0 != this.type_0)
			{
				return true;
			}
			if (this.class24_0 == null)
			{
				return @class.class24_0 != null;
			}
			return this.class24_0.vmethod_6(@class.class24_0);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003E57 File Offset: 0x00002057
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x04000091 RID: 145
		private Class13.Class24 class24_0;

		// Token: 0x04000092 RID: 146
		private Type type_0;
	}

	// Token: 0x0200003E RID: 62
	internal class Class15
	{
		// Token: 0x04000093 RID: 147
		public int int_0;

		// Token: 0x04000094 RID: 148
		public bool bool_0;

		// Token: 0x04000095 RID: 149
		public Class13.Enum2 enum2_0;
	}

	// Token: 0x0200003F RID: 63
	internal class Class16
	{
		// Token: 0x04000096 RID: 150
		public int int_0;

		// Token: 0x04000097 RID: 151
		public Class13.Enum2 enum2_0;

		// Token: 0x04000098 RID: 152
		public bool bool_0;

		// Token: 0x04000099 RID: 153
		public Type type_0 = typeof(object);
	}

	// Token: 0x02000040 RID: 64
	internal class Class17
	{
		// Token: 0x0400009A RID: 154
		public int int_0;

		// Token: 0x0400009B RID: 155
		public int int_1;

		// Token: 0x0400009C RID: 156
		public Class13.Class18 class18_0;
	}

	// Token: 0x02000041 RID: 65
	internal class Class18
	{
		// Token: 0x0400009D RID: 157
		public int int_0;

		// Token: 0x0400009E RID: 158
		public int int_1;

		// Token: 0x0400009F RID: 159
		public byte byte_0;

		// Token: 0x040000A0 RID: 160
		public Type type_0;

		// Token: 0x040000A1 RID: 161
		public int int_2;

		// Token: 0x040000A2 RID: 162
		public int int_3;
	}

	// Token: 0x02000042 RID: 66
	internal class Class19
	{
		// Token: 0x040000A3 RID: 163
		internal MethodBase methodBase_0;

		// Token: 0x040000A4 RID: 164
		internal List<Class13.Class14> list_0;

		// Token: 0x040000A5 RID: 165
		internal Class13.Class15[] class15_0;

		// Token: 0x040000A6 RID: 166
		internal List<Class13.Class16> list_1;

		// Token: 0x040000A7 RID: 167
		internal List<Class13.Class17> list_2;
	}

	// Token: 0x02000043 RID: 67
	private class Class20
	{
		// Token: 0x06000367 RID: 871 RVA: 0x000040F6 File Offset: 0x000022F6
		public Class20(FieldInfo fieldInfo_1, int int_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.int_0 = int_1;
		}

		// Token: 0x040000A8 RID: 168
		internal FieldInfo fieldInfo_0;

		// Token: 0x040000A9 RID: 169
		internal int int_0;
	}

	// Token: 0x02000044 RID: 68
	private class Class21
	{
		// Token: 0x06000368 RID: 872 RVA: 0x0000410C File Offset: 0x0000230C
		public Class21(MethodBase methodBase_1, List<Class13.Class20> list_1)
		{
			this.list_0 = list_1;
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000412D File Offset: 0x0000232D
		public Class21(MethodBase methodBase_1, Class13.Class20[] class20_0)
		{
			this.list_0.AddRange(class20_0);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000FF00 File Offset: 0x0000E100
		public override bool Equals(object obj)
		{
			Class13.Class21 @class = obj as Class13.Class21;
			if (obj == null)
			{
				return false;
			}
			if (this.methodBase_0 != @class.methodBase_0)
			{
				return false;
			}
			if (this.list_0.Count != @class.list_0.Count)
			{
				return false;
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i].fieldInfo_0 != @class.list_0[i].fieldInfo_0)
				{
					return false;
				}
				if (this.list_0[i].int_0 != @class.list_0[i].int_0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
		public override int GetHashCode()
		{
			int num = this.methodBase_0.GetHashCode();
			foreach (Class13.Class20 @class in this.list_0)
			{
				int num2 = @class.fieldInfo_0.GetHashCode() + @class.int_0;
				num = (num ^ num2) + num2;
			}
			return num;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00010028 File Offset: 0x0000E228
		public Class13.Class20 method_0(int int_0)
		{
			foreach (Class13.Class20 @class in this.list_0)
			{
				if (@class.int_0 == int_0)
				{
					return @class;
				}
			}
			return null;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00010088 File Offset: 0x0000E288
		public bool method_1(int int_0)
		{
			using (List<Class13.Class20>.Enumerator enumerator = this.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.int_0 == int_0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x040000AA RID: 170
		private List<Class13.Class20> list_0 = new List<Class13.Class20>();

		// Token: 0x040000AB RID: 171
		private MethodBase methodBase_0;
	}

	// Token: 0x02000045 RID: 69
	// (Invoke) Token: 0x0600036F RID: 879
	private delegate object Delegate12(object target, object[] paramters);

	// Token: 0x02000046 RID: 70
	// (Invoke) Token: 0x06000373 RID: 883
	private delegate object Delegate13(ref object target, object[] paramters);

	// Token: 0x02000047 RID: 71
	// (Invoke) Token: 0x06000377 RID: 887
	private delegate object Delegate14(object target);

	// Token: 0x02000048 RID: 72
	// (Invoke) Token: 0x0600037B RID: 891
	private delegate void Delegate15(IntPtr a, byte b, int c);

	// Token: 0x02000049 RID: 73
	// (Invoke) Token: 0x0600037F RID: 895
	private delegate void Delegate16(IntPtr s, IntPtr t, uint c);

	// Token: 0x0200004A RID: 74
	internal class Class22
	{
		// Token: 0x06000382 RID: 898 RVA: 0x000100E8 File Offset: 0x0000E2E8
		internal void method_0()
		{
			bool flag = false;
			this.method_2(ref flag);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00010100 File Offset: 0x0000E300
		internal void method_1()
		{
			this.class41_0.method_1();
			this.class24_1 = null;
			if (this.list_0 != null)
			{
				foreach (IntPtr intPtr in this.list_0)
				{
					try
					{
						Marshal.FreeHGlobal(intPtr);
					}
					catch
					{
					}
				}
				this.list_0.Clear();
				this.list_0 = null;
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00010190 File Offset: 0x0000E390
		internal void method_2(ref bool bool_4)
		{
			while (this.int_0 > -2)
			{
				if (this.bool_0)
				{
					this.bool_0 = false;
					int num = this.int_1;
					int num2 = this.int_0;
					this.method_4(this.int_1, this.int_0);
					this.int_0 = num2;
					this.int_1 = num;
				}
				if (this.bool_2)
				{
					this.bool_2 = false;
					return;
				}
				if (!this.bool_1)
				{
					this.int_1 = this.int_0;
					Class13.Class14 @class = this.class19_0.list_0[this.int_0];
					this.object_0 = @class.object_0;
					try
					{
						this.method_7(@class);
					}
					catch (Exception innerException)
					{
						if (innerException is TargetInvocationException)
						{
							TargetInvocationException ex = (TargetInvocationException)innerException;
							if (ex.InnerException != null)
							{
								innerException = ex.InnerException;
							}
						}
						this.exception_0 = innerException;
						bool_4 = true;
						this.class41_0.method_1();
						int num3 = this.int_1;
						Class13.Class17 class2 = this.method_5(num3, innerException);
						List<Class13.Class17> list = this.method_6(num3, false);
						List<Class13.Class17> list2 = new List<Class13.Class17>();
						if (class2 != null)
						{
							list2.Add(class2);
						}
						if (list != null && list.Count > 0)
						{
							list2.AddRange(list);
						}
						list2.Sort(new Comparison<Class13.Class17>(Class13.Class22.Class23.<>9.method_0));
						Class13.Class17 class3 = null;
						foreach (Class13.Class17 class4 in list2)
						{
							if (class4.class18_0.int_3 != 0)
							{
								this.class41_0.method_2(new Class13.Class36(innerException));
								this.int_1 = class4.class18_0.int_2;
								this.int_0 = this.int_1;
								this.method_0();
								if (!this.bool_3)
								{
									continue;
								}
								this.bool_3 = false;
								class3 = class4;
							}
							else
							{
								class3 = class4;
							}
							break;
						}
						if (class3 != null)
						{
							this.int_2 = class3.class18_0.int_0;
							this.method_3(num3, class3.class18_0.int_0);
							if (this.int_2 >= 0)
							{
								this.class41_0.method_2(new Class13.Class36(innerException));
								this.int_1 = this.int_2;
								this.int_0 = this.int_1;
								this.int_2 = -1;
								this.method_0();
							}
							return;
						}
						throw innerException;
					}
					this.int_0++;
					continue;
				}
				this.bool_1 = false;
				return;
			}
			this.class41_0.method_1();
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00010440 File Offset: 0x0000E640
		internal void method_3(int int_3, int int_4)
		{
			if (this.class19_0.list_2 != null)
			{
				foreach (Class13.Class17 @class in this.class19_0.list_2)
				{
					if ((@class.class18_0.int_3 == 4 || @class.class18_0.int_3 == 2) && @class.class18_0.int_0 >= int_3 && @class.class18_0.int_1 <= int_4)
					{
						this.int_1 = @class.class18_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00010508 File Offset: 0x0000E708
		internal void method_4(int int_3, int int_4)
		{
			if (this.class19_0.list_2 != null)
			{
				foreach (Class13.Class17 @class in this.class19_0.list_2)
				{
					if (@class.class18_0.int_3 == 2 && @class.class18_0.int_0 >= int_3 && @class.class18_0.int_1 <= int_4)
					{
						this.int_1 = @class.class18_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000105C0 File Offset: 0x0000E7C0
		internal Class13.Class17 method_5(int int_3, Exception exception_1)
		{
			Class13.Class17 @class = null;
			if (this.class19_0.list_2 != null)
			{
				foreach (Class13.Class17 class2 in this.class19_0.list_2)
				{
					if (class2.class18_0 != null && class2.class18_0.int_3 == 0 && (class2.class18_0.type_0 == exception_1.GetType() || (class2.class18_0.type_0 != null && (class2.class18_0.type_0.FullName == exception_1.GetType().FullName || class2.class18_0.type_0.FullName == typeof(object).FullName || class2.class18_0.type_0.FullName == typeof(Exception).FullName))) && int_3 >= class2.int_0 && int_3 <= class2.int_1)
					{
						if (@class == null)
						{
							@class = class2;
						}
						else if (class2.class18_0.int_0 < @class.class18_0.int_0)
						{
							@class = class2;
						}
					}
				}
			}
			return @class;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00010724 File Offset: 0x0000E924
		internal List<Class13.Class17> method_6(int int_3, bool bool_4)
		{
			if (this.class19_0.list_2 == null)
			{
				return null;
			}
			List<Class13.Class17> list = new List<Class13.Class17>();
			foreach (Class13.Class17 @class in this.class19_0.list_2)
			{
				if ((@class.class18_0.int_3 & 1) == 1 && int_3 >= @class.int_0 && int_3 <= @class.int_1)
				{
					list.Add(@class);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return list;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000107C0 File Offset: 0x0000E9C0
		private unsafe void method_7(Class13.Class14 class14_0)
		{
			switch (class14_0.enum4_0)
			{
			case (Class13.Enum4)0:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				object obj = ((Array)this.class41_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct5_0.int_0);
				this.class41_0.method_2(Class13.Class24.smethod_1(typeof(sbyte), obj));
				return;
			}
			case (Class13.Enum4)1:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_52());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)2:
			{
				Class13.Class25 @class = this.class41_0.method_4() as Class13.Class25;
				IntPtr intPtr = Class13.Class22.smethod_9(this.class41_0.method_4());
				IntPtr intPtr2 = Class13.Class22.smethod_9(this.class41_0.method_4());
				if (intPtr != IntPtr.Zero && intPtr2 != IntPtr.Zero)
				{
					uint num = @class.vmethod_19().struct5_0.uint_0;
					Class13.Class22.smethod_12(intPtr2, intPtr, num);
				}
				return;
			}
			case (Class13.Enum4)3:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_47());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)4:
			{
				int num2 = (int)this.object_0;
				Type type = typeof(Class13).Module.ResolveType(num2);
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				((Array)this.class41_0.method_4().vmethod_4(null)).SetValue(class2.vmethod_4(type), @class.vmethod_18().struct5_0.int_0);
				return;
			}
			case (Class13.Enum4)5:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_56(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)6:
				this.class41_0.method_2(new Class13.Class26((int)this.object_0));
				return;
			case (Class13.Enum4)7:
			case (Class13.Enum4)47:
			case (Class13.Enum4)63:
			case (Class13.Enum4)76:
			case (Class13.Enum4)131:
			case (Class13.Enum4)134:
				return;
			case (Class13.Enum4)8:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				this.class41_0.method_4().vmethod_2(class2);
				return;
			}
			case (Class13.Enum4)9:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_73(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)10:
			{
				int num2 = (int)this.object_0;
				Type type = typeof(Class13).Module.ResolveType(num2);
				Class13.Class30 class4 = this.class41_0.method_4() as Class13.Class30;
				if (class4 == null)
				{
					throw new Class13.Exception1();
				}
				object obj = class4.vmethod_4(type);
				Class13.Class24 class2;
				if (obj != null)
				{
					if (type.IsValueType)
					{
						obj = Class13.Class22.smethod_10(obj);
					}
					class2 = Class13.Class24.smethod_1(type, obj);
				}
				else if (type.IsValueType)
				{
					obj = Activator.CreateInstance(type);
					class2 = Class13.Class24.smethod_1(type, obj);
				}
				else
				{
					class2 = new Class13.Class36(null);
				}
				this.class41_0.method_2(class2);
				return;
			}
			case (Class13.Enum4)11:
				this.int_0 = (int)this.object_0 - 1;
				return;
			case (Class13.Enum4)12:
				this.int_0 = (int)this.object_0 - 1;
				this.bool_0 = true;
				return;
			case (Class13.Enum4)13:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_27());
				return;
			}
			case (Class13.Enum4)14:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_64(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)15:
				this.class41_0.method_2(new Class13.Class27((long)this.object_0));
				return;
			case (Class13.Enum4)16:
			{
				int num2 = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class13).Module.ResolveField(num2);
				Class13.Class24 class5 = this.class41_0.method_4();
				class5.vmethod_8();
				object obj = class5.vmethod_4(null);
				this.class41_0.method_2(new Class13.Class33(fieldInfo, obj));
				return;
			}
			case (Class13.Enum4)17:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_31());
				return;
			}
			case (Class13.Enum4)18:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_69());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)19:
			{
				int num2 = (int)this.object_0;
				MethodBase methodBase = typeof(Class13).Module.ResolveMethod(num2);
				Type type = this.class41_0.method_4().vmethod_4(null).GetType();
				List<Type> list = new List<Type>();
				do
				{
					list.Add(type);
					type = type.BaseType;
				}
				while (type != null && type != methodBase.DeclaringType);
				list.Reverse();
				MethodBase methodBase2 = methodBase;
				foreach (Type type2 in list)
				{
					foreach (MethodInfo methodInfo in type2.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
					{
						if (methodInfo.GetBaseDefinition() == methodBase2)
						{
							methodBase2 = methodInfo;
							break;
						}
					}
				}
				this.class41_0.method_2(new Class13.Class28(methodBase2.MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class13.Enum4)20:
			case (Class13.Enum4)144:
			{
				int num2 = (int)this.object_0;
				Type type = typeof(Class13).Module.ResolveType(num2);
				Class13.Class24 class2 = this.class41_0.method_4();
				object obj = class2.vmethod_4(type);
				if (obj != null)
				{
					if (type.IsValueType)
					{
						obj = Class13.Class22.smethod_10(obj);
					}
					class2 = Class13.Class24.smethod_1(type, obj);
				}
				else if (!type.IsValueType)
				{
					class2 = new Class13.Class36(null);
				}
				else
				{
					obj = Activator.CreateInstance(type);
					class2 = Class13.Class24.smethod_1(type, obj);
				}
				Class13.Class30 class6 = this.class41_0.method_4() as Class13.Class30;
				if (class6 == null)
				{
					throw new Class13.Exception1();
				}
				class6.zhnXqoJuKJ(class2);
				return;
			}
			case (Class13.Enum4)21:
			{
				object obj = Class13.Class22.object_2;
				lock (obj)
				{
					Class13.Class24 class2 = this.class41_0.method_4();
					object obj2 = this.class41_0.method_4().vmethod_4(null);
					Class13.Class22.dictionary_1[obj2] = class2;
				}
				return;
			}
			case (Class13.Enum4)22:
				if (Class13.list_0.Count == 0)
				{
					Module module = typeof(Class13).Module;
					this.class41_0.method_2(new Class13.Class37(module.ResolveString((int)this.object_0 | 1879048192)));
					return;
				}
				this.class41_0.method_2(new Class13.Class37(Class13.list_0[(int)this.object_0]));
				return;
			case (Class13.Enum4)23:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (Class13.Class22.smethod_1(this.class41_0.method_4()).vmethod_77(class2))
				{
					this.class41_0.method_2(new Class13.Class26(1));
					return;
				}
				this.class41_0.method_2(new Class13.Class26(0));
				return;
			}
			case (Class13.Enum4)24:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_74(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)25:
			{
				int num2 = (int)this.object_0;
				Type type = typeof(Class13).Module.ResolveType(num2);
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				object obj = ((Array)this.class41_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct5_0.int_0);
				this.class41_0.method_2(Class13.Class24.smethod_1(type, obj));
				return;
			}
			case (Class13.Enum4)26:
			{
				object obj = Class13.Class22.object_2;
				lock (obj)
				{
					object obj2 = this.class41_0.method_4().vmethod_4(null);
					Class13.Class24 class2 = null;
					if (!Class13.Class22.dictionary_1.TryGetValue(obj2, out class2))
					{
						this.class41_0.method_2(new Class13.Class36(null));
					}
					else
					{
						this.class41_0.method_2(class2);
					}
				}
				return;
			}
			case (Class13.Enum4)27:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				object obj = ((Array)this.class41_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct5_0.int_0);
				this.class41_0.method_2(Class13.Class24.smethod_1(typeof(float), obj));
				return;
			}
			case (Class13.Enum4)28:
			{
				int num2 = (int)this.object_0;
				Type type = typeof(Class13).Module.ResolveType(num2);
				Class13.Class30 class7 = this.class41_0.method_4() as Class13.Class30;
				if (class7 == null)
				{
					throw new Class13.Exception1();
				}
				if (!type.IsValueType)
				{
					class7.vmethod_11(new Class13.Class36(null));
					return;
				}
				if (!(Nullable.GetUnderlyingType(type) != null))
				{
					object obj = Activator.CreateInstance(type);
					Class13.Class24 class2 = Class13.Class24.smethod_1(type, obj);
					class7.vmethod_11(class2);
					return;
				}
				class7.vmethod_11(new Class13.Class38(null, Nullable.GetUnderlyingType(type)));
				return;
			}
			case (Class13.Enum4)29:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (Class13.Class22.smethod_1(this.class41_0.method_4()).vmethod_82(class2))
				{
					this.class41_0.method_2(new Class13.Class26(1));
					return;
				}
				this.class41_0.method_2(new Class13.Class26(0));
				return;
			}
			case (Class13.Enum4)30:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_42());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)31:
				this.bool_2 = true;
				return;
			case (Class13.Enum4)32:
			case (Class13.Enum4)50:
			case (Class13.Enum4)66:
			case (Class13.Enum4)86:
			case (Class13.Enum4)113:
			case (Class13.Enum4)122:
			case (Class13.Enum4)157:
			case (Class13.Enum4)161:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Array array = (Array)this.class41_0.method_4().vmethod_4(null);
				Type type = array.GetType().GetElementType();
				array.SetValue(class2.vmethod_4(type), @class.vmethod_18().struct5_0.int_0);
				return;
			}
			case (Class13.Enum4)33:
				throw this.exception_0;
			case (Class13.Enum4)34:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(class2);
				if (class2 != null && class2.vmethod_0() && @class != null)
				{
					this.class41_0.method_2(@class.vmethod_45());
					return;
				}
				if (@class != null && @class.epLymgDpIC())
				{
					IntPtr intPtr = ((Class13.Class28)@class).uilAcHjmLR();
					this.class41_0.method_2(new Class13.Class29(*(float*)(void*)intPtr, (Class13.Enum2)9));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)35:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(class2);
				if (class2 != null && class2.vmethod_0() && @class != null)
				{
					this.class41_0.method_2(@class.vmethod_25());
					return;
				}
				if (@class != null && @class.epLymgDpIC())
				{
					IntPtr intPtr = ((Class13.Class28)@class).uilAcHjmLR();
					this.class41_0.method_2(new Class13.Class26((int)(*(byte*)(void*)intPtr), (Class13.Enum2)2));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)36:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.NkkgOoOrdR());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)37:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_40());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)38:
			case (Class13.Enum4)60:
			case (Class13.Enum4)62:
			case (Class13.Enum4)78:
			case (Class13.Enum4)153:
			case (Class13.Enum4)170:
				throw new Class13.Exception1();
			case (Class13.Enum4)39:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (class2.vmethod_3())
				{
					class2 = ((Class13.Class25)class2).vmethod_47();
				}
				this.class41_0.method_4().vmethod_2(class2);
				return;
			}
			case (Class13.Enum4)40:
				this.class41_0.method_2(new Class13.Class31((int)this.object_0, this));
				return;
			case (Class13.Enum4)41:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (class2 != null && class2.vmethod_7())
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class13.Enum4)42:
			{
				Class13.Class24 class8 = Class13.Class22.smethod_7(this.class41_0.method_4());
				Class13.Class24 class2 = Class13.Class22.smethod_7(this.class41_0.method_4());
				if (class8.vmethod_5(class2))
				{
					this.class41_0.method_2(new Class13.Class26(1));
					return;
				}
				this.class41_0.method_2(new Class13.Class26(0));
				return;
			}
			case (Class13.Enum4)43:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(class2);
				if (class2 != null && class2.vmethod_0() && @class != null)
				{
					this.class41_0.method_2(@class.vmethod_27());
					return;
				}
				if (@class != null && @class.epLymgDpIC())
				{
					IntPtr intPtr = ((Class13.Class28)@class).uilAcHjmLR();
					this.class41_0.method_2(new Class13.Class26(*(uint*)(void*)intPtr, (Class13.Enum2)6));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)44:
				return;
			case (Class13.Enum4)45:
			{
				int num2 = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class13).Module.ResolveField(num2);
				this.class41_0.method_2(Class13.Class24.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(null)));
				return;
			}
			case (Class13.Enum4)46:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (Class13.Class22.smethod_1(this.class41_0.method_4()).vmethod_75(class2))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class13.Enum4)48:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_49());
				return;
			}
			case (Class13.Enum4)49:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_46());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)51:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_41());
				return;
			}
			case (Class13.Enum4)52:
			{
				int num2 = (int)this.object_0;
				this.class41_0.method_2(new Class13.Class34(num2, this));
				return;
			}
			case (Class13.Enum4)53:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_43());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)54:
			{
				int num2 = (int)this.object_0;
				ConstructorInfo constructorInfo = (ConstructorInfo)typeof(Class13).Module.ResolveMethod(num2);
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				object[] array2 = new object[parameters.Length];
				Class13.Class24[] array3 = new Class13.Class24[parameters.Length];
				List<Class13.Class20> list2 = null;
				Class13.Class21 class9 = null;
				for (int i = 0; i < parameters.Length; i++)
				{
					Class13.Class24 class2 = this.class41_0.method_4();
					Type type = parameters[parameters.Length - 1 - i].ParameterType;
					object obj2 = null;
					bool flag = false;
					if (type.IsByRef)
					{
						Class13.Class33 class10 = class2 as Class13.Class33;
						if (class10 != null)
						{
							if (list2 == null)
							{
								list2 = new List<Class13.Class20>();
							}
							list2.Add(new Class13.Class20(class10.fieldInfo_0, parameters.Length - 1 - i));
							obj2 = class10.object_0;
							if (obj2 is Class13.Class24)
							{
								class2 = obj2 as Class13.Class24;
							}
							else
							{
								flag = true;
							}
						}
					}
					if (!flag)
					{
						if (class2 != null)
						{
							obj2 = class2.vmethod_4(type);
						}
						if (obj2 == null)
						{
							if (type.IsByRef)
							{
								type = type.GetElementType();
							}
							if (type.IsValueType)
							{
								obj2 = Activator.CreateInstance(type);
								if (class2 is Class13.Class31)
								{
									((Class13.Class30)class2).vmethod_11(Class13.Class24.smethod_1(type, obj2));
								}
							}
						}
					}
					array3[array2.Length - 1 - i] = class2;
					array2[array2.Length - 1 - i] = obj2;
				}
				Class13.Delegate12 @delegate = null;
				if (list2 != null)
				{
					class9 = new Class13.Class21(constructorInfo, list2);
					@delegate = Class13.Class22.smethod_4(constructorInfo, true, class9);
				}
				object obj = null;
				if (@delegate == null)
				{
					obj = constructorInfo.Invoke(array2);
				}
				else
				{
					obj = @delegate(null, array2);
				}
				for (int j = 0; j < parameters.Length; j++)
				{
					if (parameters[j].ParameterType.IsByRef && (class9 == null || !class9.method_1(j)))
					{
						if (array3[j].epLymgDpIC())
						{
							((Class13.Class28)array3[j]).method_4(Class13.Class24.smethod_1(parameters[j].ParameterType, array2[j]));
						}
						else if (array3[j] is Class13.Class31)
						{
							array3[j].zhnXqoJuKJ(Class13.Class24.smethod_1(parameters[j].ParameterType.GetElementType(), array2[j]));
						}
						else
						{
							array3[j].zhnXqoJuKJ(Class13.Class24.smethod_1(parameters[j].ParameterType, array2[j]));
						}
					}
				}
				this.class41_0.method_2(Class13.Class24.smethod_1(constructorInfo.DeclaringType, obj));
				return;
			}
			case (Class13.Enum4)55:
				this.class41_0.method_2(new Class13.Class36(null));
				return;
			case (Class13.Enum4)56:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				bool flag2 = Class13.Class22.smethod_1(this.class41_0.method_4()).vmethod_82(class2);
				if (flag2)
				{
					this.class41_0.method_2(new Class13.Class26(1));
				}
				else
				{
					this.class41_0.method_2(new Class13.Class26(0));
				}
				if (flag2)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class13.Enum4)57:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (class2.vmethod_3())
				{
					class2 = ((Class13.Class25)class2).vmethod_46();
				}
				this.class41_0.method_4().vmethod_2(class2);
				return;
			}
			case (Class13.Enum4)58:
				if (this.class41_0.method_4().vmethod_6(this.class41_0.method_4()))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			case (Class13.Enum4)59:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(class2);
				if (class2 != null && class2.vmethod_0() && @class != null)
				{
					this.class41_0.method_2(@class.vmethod_47());
					return;
				}
				if (@class == null || !@class.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				IntPtr intPtr = ((Class13.Class28)@class).uilAcHjmLR();
				if (IntPtr.Size == 8)
				{
					long num3 = *(long*)(void*)intPtr;
					this.class41_0.method_2(new Class13.Class28(num3, (Class13.Enum2)12));
					return;
				}
				int num2 = *(int*)(void*)intPtr;
				this.class41_0.method_2(new Class13.Class28((long)num2, (Class13.Enum2)12));
				return;
			}
			case (Class13.Enum4)61:
			{
				int num2 = (int)this.object_0;
				this.class24_1[num2] = this.method_8(this.class41_0.method_4(), this.class19_0.list_1[num2].enum2_0, this.class19_0.list_1[num2].bool_0);
				return;
			}
			case (Class13.Enum4)64:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				object obj = ((Array)this.class41_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct5_0.int_0);
				this.class41_0.method_2(Class13.Class24.smethod_1(typeof(ushort), obj));
				return;
			}
			case (Class13.Enum4)65:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				this.class41_0.method_4().vmethod_2(class2);
				return;
			}
			case (Class13.Enum4)67:
			{
				int num2 = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class13).Module.ResolveField(num2);
				this.class41_0.method_2(new Class13.Class33(fieldInfo, null));
				return;
			}
			case (Class13.Enum4)68:
			{
				int num2 = (int)this.object_0;
				uint num = (uint)Class13.Class22.smethod_0(typeof(Class13).Module.ResolveType(num2));
				this.class41_0.method_2(new Class13.Class26(num, (Class13.Enum2)6));
				return;
			}
			case (Class13.Enum4)69:
				this.int_0 = -3;
				if (this.class41_0.method_0() > 0)
				{
					this.class24_2 = this.class41_0.method_4();
				}
				return;
			case (Class13.Enum4)70:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				this.class41_0.method_4().vmethod_2(class2);
				return;
			}
			case (Class13.Enum4)71:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(class2);
				if (class2 != null && class2.vmethod_0() && @class != null)
				{
					this.class41_0.method_2(@class.vmethod_46());
					return;
				}
				if (@class != null && @class.epLymgDpIC())
				{
					IntPtr intPtr = ((Class13.Class28)@class).uilAcHjmLR();
					this.class41_0.method_2(new Class13.Class29(*(double*)(void*)intPtr, (Class13.Enum2)10));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)72:
			{
				bool flag = false;
				Class13.Class24 class2 = this.class41_0.method_4();
				flag = class2 == null || !class2.vmethod_7();
				if (flag)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class13.Enum4)73:
			{
				int[] array4 = (int[])this.object_0;
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				long num3 = @class.vmethod_20().struct6_0.long_0;
				if ((num3 < 0L || @class.uMpydVvbAn()) && IntPtr.Size == 4)
				{
					num3 = (long)((int)num3);
				}
				if (@class.method_1())
				{
					Class13.Class26 class11 = (Class13.Class26)@class;
					if (class11.enum2_0 == (Class13.Enum2)6)
					{
						num3 = (long)((ulong)class11.struct5_0.uint_0);
					}
				}
				if (num3 < (long)array4.Length && num3 >= 0L)
				{
					this.int_0 = array4[(int)(checked((IntPtr)num3))] - 1;
				}
				return;
			}
			case (Class13.Enum4)74:
				this.class41_0.method_2(new Class13.Class29((double)this.object_0));
				return;
			case (Class13.Enum4)75:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(class2);
				if (class2 != null && class2.vmethod_0() && @class != null)
				{
					this.class41_0.method_2(@class.vmethod_23());
					return;
				}
				if (@class != null && @class.epLymgDpIC())
				{
					IntPtr intPtr = ((Class13.Class28)@class).uilAcHjmLR();
					this.class41_0.method_2(new Class13.Class26((int)(*(short*)(void*)intPtr), (Class13.Enum2)3));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)77:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_60(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)79:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				this.class41_0.method_4().vmethod_2(class2);
				return;
			}
			case (Class13.Enum4)80:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				object obj = ((Array)this.class41_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct5_0.int_0);
				this.class41_0.method_2(Class13.Class24.smethod_1(typeof(short), obj));
				return;
			}
			case (Class13.Enum4)81:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (Class13.Class22.smethod_1(this.class41_0.method_4()).vmethod_81(class2))
				{
					this.class41_0.method_2(new Class13.Class26(1));
					return;
				}
				this.class41_0.method_2(new Class13.Class26(0));
				return;
			}
			case (Class13.Enum4)82:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_50());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)83:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null && class3 != null)
				{
					this.class41_0.method_2(@class.vmethod_68(class3));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)84:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_26());
				return;
			}
			case (Class13.Enum4)85:
				this.method_12(false);
				return;
			case (Class13.Enum4)87:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_24());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)88:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_22());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)89:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Array array5 = (Array)this.class41_0.method_4().vmethod_4(null);
				object obj = array5.GetValue(@class.vmethod_18().struct5_0.int_0);
				Type type = array5.GetType().GetElementType();
				this.class41_0.method_2(Class13.Class24.smethod_1(type, obj));
				return;
			}
			case (Class13.Enum4)90:
			{
				Class13.Class25 class12 = Class13.Class22.smethod_1(this.class41_0.method_3());
				if (class12 != null)
				{
					Class13.Class29 class13 = class12 as Class13.Class29;
					if (class13 != null)
					{
						if (double.IsNaN(class13.double_0))
						{
							throw new OverflowException(((Class13.Enum6)2).ToString());
						}
						if (double.IsInfinity(class13.double_0))
						{
							throw new OverflowException(((Class13.Enum6)1).ToString());
						}
					}
					return;
				}
				throw new ArithmeticException(((Class13.Enum6)0).ToString());
			}
			case (Class13.Enum4)91:
			{
				int num2 = (int)this.object_0;
				Module module = typeof(Class13).Module;
				this.class41_0.method_2(new Class13.Class28(module.ResolveMethod(num2).MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class13.Enum4)92:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_62(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)93:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				object obj = ((Array)this.class41_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct5_0.int_0);
				this.class41_0.method_2(Class13.Class24.smethod_1(typeof(int), obj));
				return;
			}
			case (Class13.Enum4)94:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(class2);
				if (class2 != null && class2.vmethod_0() && @class != null)
				{
					this.class41_0.method_2(@class.WdeXooypfm());
					return;
				}
				if (@class != null && @class.epLymgDpIC())
				{
					IntPtr intPtr = ((Class13.Class28)@class).uilAcHjmLR();
					this.class41_0.method_2(new Class13.Class27(*(long*)(void*)intPtr, (Class13.Enum2)7));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)95:
			{
				int num2 = (int)this.object_0;
				Class13.Class24 class2 = this.class24_1[num2];
				this.class41_0.method_2(class2);
				return;
			}
			case (Class13.Enum4)96:
			{
				int num2 = (int)this.object_0;
				Module module = typeof(Class13).Module;
				object obj = null;
				try
				{
					obj = module.ResolveType(num2);
				}
				catch
				{
					try
					{
						obj = module.ResolveMethod(num2);
					}
					catch
					{
						try
						{
							obj = module.ResolveField(num2);
						}
						catch
						{
							obj = module.ResolveMember(num2);
						}
					}
				}
				this.class41_0.method_2(new Class13.Class36(obj));
				return;
			}
			case (Class13.Enum4)97:
			{
				Array array6 = (Array)this.class41_0.method_4().vmethod_4(null);
				this.class41_0.method_2(new Class13.Class26(array6.Length, (Class13.Enum2)5));
				return;
			}
			case (Class13.Enum4)98:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				object obj = ((Array)this.class41_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct5_0.int_0);
				this.class41_0.method_2(Class13.Class24.smethod_1(typeof(byte), obj));
				return;
			}
			case (Class13.Enum4)99:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_30());
				return;
			}
			case (Class13.Enum4)100:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_51());
				return;
			}
			case (Class13.Enum4)101:
			{
				int num2 = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class13).Module.ResolveField(num2);
				object obj = this.class41_0.method_4().vmethod_4(fieldInfo.FieldType);
				Class13.Class24 class2 = this.class41_0.method_4();
				object obj2 = class2.vmethod_4(null);
				if (obj2 == null)
				{
					Type type = fieldInfo.DeclaringType;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					if (!type.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type);
					if (class2 is Class13.Class31)
					{
						((Class13.Class30)class2).vmethod_11(Class13.Class24.smethod_1(type, obj2));
					}
				}
				fieldInfo.SetValue(obj2, obj);
				return;
			}
			case (Class13.Enum4)102:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_44());
				return;
			}
			case (Class13.Enum4)103:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_39());
				return;
			}
			case (Class13.Enum4)104:
				this.class41_0.method_4();
				return;
			case (Class13.Enum4)105:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_23());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)106:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_34());
				return;
			}
			case (Class13.Enum4)107:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_35());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)108:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (Class13.Class22.smethod_1(this.class41_0.method_4()).vmethod_76(class2))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class13.Enum4)109:
			{
				int num2 = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class13).Module.ResolveField(num2);
				object obj = this.class41_0.method_4().vmethod_4(null);
				this.class41_0.method_2(Class13.Class24.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(obj)));
				return;
			}
			case (Class13.Enum4)110:
				this.class41_0.method_2(this.class41_0.method_4().vmethod_8());
				return;
			case (Class13.Enum4)111:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (Class13.Class22.smethod_1(this.class41_0.method_4()).vmethod_79(class2))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class13.Enum4)112:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_25());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)114:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(class2);
				if (class2 != null && class2.vmethod_0() && @class != null)
				{
					this.class41_0.method_2(@class.vmethod_26());
					return;
				}
				if (@class != null && @class.epLymgDpIC())
				{
					IntPtr intPtr = ((Class13.Class28)@class).uilAcHjmLR();
					this.class41_0.method_2(new Class13.Class26((int)(*(ushort*)(void*)intPtr), (Class13.Enum2)4));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)115:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_32());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)116:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (class2.vmethod_0())
				{
					object obj = class2.vmethod_4(null);
					if (obj != null)
					{
						class2 = Class13.Class24.smethod_1(obj.GetType(), obj);
					}
					else
					{
						class2 = new Class13.Class36(null);
					}
					this.class41_0.method_2(class2);
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)117:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (Class13.Class22.smethod_1(this.class41_0.method_4()).vmethod_77(class2))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class13.Enum4)118:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null && class3 != null)
				{
					this.class41_0.method_2(@class.vmethod_67(class3));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)119:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_29());
				return;
			}
			case (Class13.Enum4)120:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				object obj = ((Array)this.class41_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct5_0.int_0);
				this.class41_0.method_2(Class13.Class24.smethod_1(typeof(double), obj));
				return;
			}
			case (Class13.Enum4)121:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_36());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)123:
			{
				Class13.Class25 @class = this.class41_0.method_4() as Class13.Class25;
				Class13.Class25 class3 = this.class41_0.method_4() as Class13.Class25;
				IntPtr intPtr = Class13.Class22.smethod_9(this.class41_0.method_4());
				if (intPtr != IntPtr.Zero)
				{
					byte byte_ = class3.vmethod_15().struct5_0.byte_0;
					uint num = @class.vmethod_19().struct5_0.uint_0;
					Class13.Class22.smethod_11(intPtr, byte_, (int)num);
				}
				return;
			}
			case (Class13.Enum4)124:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_28());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)125:
			{
				int num2 = (int)this.object_0;
				Type type = typeof(Class13).Module.ResolveType(num2);
				Class13.Class24 class2 = this.class41_0.method_4();
				object obj = class2.vmethod_4(null);
				if (obj == null)
				{
					this.class41_0.method_2(new Class13.Class36(null));
					return;
				}
				if (type.IsAssignableFrom(obj.GetType()))
				{
					this.class41_0.method_2(class2);
					return;
				}
				this.class41_0.method_2(new Class13.Class36(null));
				return;
			}
			case (Class13.Enum4)126:
				this.class41_0.method_2(((Class13.Class25)this.class41_0.method_4()).vmethod_53());
				return;
			case (Class13.Enum4)127:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_61(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)128:
			{
				IntPtr intPtr = Marshal.AllocHGlobal((this.class41_0.method_4() as Class13.Class25).vmethod_18().struct5_0.int_0);
				if (this.list_0 == null)
				{
					this.list_0 = new List<IntPtr>();
				}
				this.list_0.Add(intPtr);
				this.class41_0.method_2(new Class13.Class28(intPtr));
				return;
			}
			case (Class13.Enum4)129:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				object obj = ((Array)this.class41_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct5_0.int_0);
				this.class41_0.method_2(Class13.Class24.smethod_1(typeof(long), obj));
				return;
			}
			case (Class13.Enum4)130:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(class2);
				Class13.Class24 class14 = this.class41_0.method_4();
				Class13.Class25 class3 = Class13.Class22.smethod_1(class14);
				if (class3 != null && @class != null)
				{
					if (class3.vmethod_78(class2))
					{
						this.int_0 = (int)this.object_0 - 1;
					}
					return;
				}
				if (class2.vmethod_6(class14))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class13.Enum4)132:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_33());
				return;
			}
			case (Class13.Enum4)133:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				this.class41_0.method_4().vmethod_2(class2);
				return;
			}
			case (Class13.Enum4)135:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_66(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)136:
			{
				int num2 = (int)this.object_0;
				if (!this.class19_0.methodBase_0.IsStatic)
				{
					this.class24_0[num2] = this.method_8(this.class41_0.method_4(), this.class19_0.class15_0[num2 - 1].enum2_0, false);
					return;
				}
				this.class24_0[num2] = this.method_8(this.class41_0.method_4(), this.class19_0.class15_0[num2].enum2_0, false);
				return;
			}
			case (Class13.Enum4)137:
				throw (Exception)this.class41_0.method_4().vmethod_4(null);
			case (Class13.Enum4)138:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_38());
				return;
			}
			case (Class13.Enum4)139:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_72(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)140:
			{
				int num2 = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class13).Module.ResolveField(num2);
				object obj = this.class41_0.method_4().vmethod_4(fieldInfo.FieldType);
				fieldInfo.SetValue(null, obj);
				return;
			}
			case (Class13.Enum4)141:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_65(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)142:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (Class13.Class22.smethod_1(this.class41_0.method_4()).vmethod_81(class2))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class13.Enum4)143:
				this.class41_0.method_2(this.class41_0.method_3());
				return;
			case (Class13.Enum4)145:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				object obj = ((Array)this.class41_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct5_0.int_0);
				this.class41_0.method_2(Class13.Class24.smethod_1(typeof(uint), obj));
				return;
			}
			case (Class13.Enum4)146:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(class2);
				Class13.Class24 class14 = this.class41_0.method_4();
				Class13.Class25 class3 = Class13.Class22.smethod_1(class14);
				if (class3 != null && @class != null)
				{
					if (class3.vmethod_78(class2))
					{
						this.class41_0.method_2(new Class13.Class26(1));
						return;
					}
					this.class41_0.method_2(new Class13.Class26(0));
					return;
				}
				else
				{
					if (!class2.vmethod_6(class14))
					{
						this.class41_0.method_2(new Class13.Class26(0));
						return;
					}
					this.class41_0.method_2(new Class13.Class26(1));
					return;
				}
				break;
			}
			case (Class13.Enum4)147:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.WdeXooypfm());
				return;
			}
			case (Class13.Enum4)148:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_57(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)149:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_48());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)150:
				this.class41_0.method_2(new Class13.Class29((float)this.object_0));
				return;
			case (Class13.Enum4)151:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				object obj = ((Array)this.class41_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct5_0.int_0);
				this.class41_0.method_2(Class13.Class24.smethod_1(typeof(IntPtr), obj));
				return;
			}
			case (Class13.Enum4)152:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_55(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)154:
			{
				int num2 = (int)this.object_0;
				Type type3 = typeof(Class13).Module.ResolveType(num2);
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Array array6 = Array.CreateInstance(type3, @class.vmethod_18().struct5_0.int_0);
				this.class41_0.method_2(new Class13.Class36(array6));
				return;
			}
			case (Class13.Enum4)155:
			{
				Class13.Class24 class15 = this.class41_0.method_4();
				Class13.Class24 class2 = this.class41_0.method_4();
				if (class15.vmethod_5(class2))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class13.Enum4)156:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_54(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)158:
			{
				int num2 = (int)this.object_0;
				typeof(Class13).Module.ResolveType(num2);
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Array array6 = (Array)this.class41_0.method_4().vmethod_4(null);
				this.class41_0.method_2(new Class13.Class32(@class.vmethod_18().struct5_0.int_0, array6));
				return;
			}
			case (Class13.Enum4)159:
			{
				int num2 = (int)this.object_0;
				Type type = typeof(Class13).Module.ResolveType(num2);
				object obj = this.class41_0.method_4().vmethod_8().vmethod_4(type);
				Class13.Class24 class2 = Class13.Class24.smethod_1(type, obj);
				this.class41_0.method_2(class2);
				return;
			}
			case (Class13.Enum4)160:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class == null)
				{
					throw new Class13.Exception1();
				}
				this.class41_0.method_2(@class.vmethod_37());
				return;
			}
			case (Class13.Enum4)162:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (Class13.Class22.smethod_1(this.class41_0.method_4()).vmethod_80(class2))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class13.Enum4)163:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				if (class2.vmethod_3())
				{
					class2 = ((Class13.Class25)class2).vmethod_45();
				}
				this.class41_0.method_4().vmethod_2(class2);
				return;
			}
			case (Class13.Enum4)164:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(class2);
				if (class2 != null && class2.vmethod_0() && @class != null)
				{
					this.class41_0.method_2(@class.vmethod_22());
					return;
				}
				if (@class != null && @class.epLymgDpIC())
				{
					IntPtr intPtr = ((Class13.Class28)@class).uilAcHjmLR();
					this.class41_0.method_2(new Class13.Class26((int)(*(sbyte*)(void*)intPtr), (Class13.Enum2)1));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)165:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = (Class13.Class25)this.class41_0.method_4();
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_58(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)166:
			{
				Type type = typeof(Class13).Module.ResolveType((int)this.object_0);
				object obj = this.class41_0.method_4().vmethod_4(type);
				if (obj == null)
				{
					obj = Activator.CreateInstance(type);
				}
				Class13.Class36 class16 = new Class13.Class36(Class13.Class24.smethod_1(type, Class13.Class22.smethod_10(obj)));
				this.class41_0.method_2(class16);
				return;
			}
			case (Class13.Enum4)167:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null && class3 != null)
				{
					this.class41_0.method_2(@class.vmethod_70(class3));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)168:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_63(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)169:
				this.method_12(true);
				return;
			case (Class13.Enum4)171:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				Class13.Class25 class3 = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (class3 != null && @class != null)
				{
					this.class41_0.method_2(class3.vmethod_59(@class));
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)172:
			{
				int num2 = (int)this.object_0;
				this.class41_0.method_2(this.class24_0[num2]);
				return;
			}
			case (Class13.Enum4)173:
				this.bool_3 = (bool)this.class41_0.method_4().vmethod_4(typeof(bool));
				this.bool_1 = true;
				return;
			case (Class13.Enum4)174:
			{
				Class13.Class25 @class = Class13.Class22.smethod_1(this.class41_0.method_4());
				if (@class != null)
				{
					this.class41_0.method_2(@class.vmethod_45());
					return;
				}
				throw new Class13.Exception1();
			}
			case (Class13.Enum4)175:
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Class13.Class25 @class = Class13.Class22.smethod_1(class2);
				if (class2 != null && class2.vmethod_0() && @class != null)
				{
					this.class41_0.method_2(@class.vmethod_24());
					return;
				}
				if (@class == null || !@class.epLymgDpIC())
				{
					throw new Class13.Exception1();
				}
				IntPtr intPtr = ((Class13.Class28)@class).uilAcHjmLR();
				this.class41_0.method_2(new Class13.Class26(*(int*)(void*)intPtr, (Class13.Enum2)5));
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000136AC File Offset: 0x000118AC
		private Class13.Class24 method_8(Class13.Class24 class24_3, Class13.Enum2 enum2_0, bool bool_4 = false)
		{
			if (!bool_4 && class24_3.vmethod_0())
			{
				class24_3 = class24_3.vmethod_8();
			}
			if (class24_3.method_1())
			{
				return ((Class13.Class26)class24_3).vmethod_12(enum2_0);
			}
			if (class24_3.method_2())
			{
				return ((Class13.Class27)class24_3).vmethod_12(enum2_0);
			}
			if (class24_3.uMpydVvbAn())
			{
				return ((Class13.Class29)class24_3).vmethod_12(enum2_0);
			}
			if (!class24_3.epLymgDpIC())
			{
				return class24_3;
			}
			return ((Class13.Class28)class24_3).vmethod_12(enum2_0);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000414C File Offset: 0x0000234C
		private Class13.Class24 method_9(int int_3)
		{
			return this.class24_1[int_3];
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00004156 File Offset: 0x00002356
		private void method_10(int int_3)
		{
			this.method_11(int_3, this.class41_0.method_4());
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00013724 File Offset: 0x00011924
		private static int smethod_0(Type type_0)
		{
			object obj = Class13.Class22.object_1;
			int num2;
			lock (obj)
			{
				if (Class13.Class22.dictionary_0 == null)
				{
					Class13.Class22.dictionary_0 = new Dictionary<Type, int>();
				}
				try
				{
					int num = 0;
					if (!Class13.Class22.dictionary_0.TryGetValue(type_0, out num))
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(int), Type.EmptyTypes, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Sizeof, type_0);
						ilgenerator.Emit(OpCodes.Ret);
						num = (int)dynamicMethod.Invoke(null, null);
						Class13.Class22.dictionary_0[type_0] = num;
						num2 = num;
					}
					else
					{
						num2 = num;
					}
				}
				catch
				{
					num2 = 0;
				}
			}
			return num2;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000416A File Offset: 0x0000236A
		private void method_11(int int_3, Class13.Class24 class24_3)
		{
			this.class24_1[int_3] = this.method_8(class24_3, this.class19_0.list_1[int_3].enum2_0, this.class19_0.list_1[int_3].bool_0);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		private static Class13.Class25 smethod_1(Class13.Class24 class24_3)
		{
			Class13.Class25 @class = class24_3 as Class13.Class25;
			if (@class == null && class24_3.vmethod_0())
			{
				@class = class24_3.vmethod_8() as Class13.Class25;
			}
			return @class;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000137E8 File Offset: 0x000119E8
		private void method_12(bool bool_4)
		{
			int num = (int)this.object_0;
			MethodBase methodBase = typeof(Class13).Module.ResolveMethod(num);
			MethodInfo methodInfo = methodBase as MethodInfo;
			ParameterInfo[] parameters = methodBase.GetParameters();
			object[] array = new object[parameters.Length];
			Class13.Class24[] array2 = new Class13.Class24[parameters.Length];
			List<Class13.Class20> list = null;
			Class13.Class21 @class = null;
			for (int i = 0; i < parameters.Length; i++)
			{
				Class13.Class24 class2 = this.class41_0.method_4();
				Type type = parameters[parameters.Length - 1 - i].ParameterType;
				object obj = null;
				bool flag = false;
				if (type.IsByRef)
				{
					Class13.Class33 class3 = class2 as Class13.Class33;
					if (class3 != null)
					{
						if (list == null)
						{
							list = new List<Class13.Class20>();
						}
						list.Add(new Class13.Class20(class3.fieldInfo_0, parameters.Length - 1 - i));
						obj = class3.object_0;
						if (obj is Class13.Class24)
						{
							class2 = obj as Class13.Class24;
						}
						else
						{
							flag = true;
							if (obj == null)
							{
								if (type.IsByRef)
								{
									type = type.GetElementType();
								}
								if (type.IsValueType)
								{
									if (class3.fieldInfo_0.IsStatic)
									{
										obj = class3.fieldInfo_0.GetValue(null);
									}
									else
									{
										obj = Activator.CreateInstance(type);
									}
									if (class2 is Class13.Class31)
									{
										((Class13.Class30)class2).vmethod_11(Class13.Class24.smethod_1(type, obj));
									}
								}
							}
						}
					}
				}
				if (!flag)
				{
					if (class2 != null)
					{
						obj = class2.vmethod_4(type);
					}
					if (obj == null)
					{
						if (type.IsByRef)
						{
							type = type.GetElementType();
						}
						if (type.IsValueType)
						{
							obj = Activator.CreateInstance(type);
							if (class2 is Class13.Class31)
							{
								((Class13.Class30)class2).vmethod_11(Class13.Class24.smethod_1(type, obj));
							}
						}
					}
				}
				array2[array.Length - 1 - i] = class2;
				array[array.Length - 1 - i] = obj;
			}
			Class13.Delegate12 @delegate = null;
			Class13.Class22.Delegate17 delegate2 = null;
			if (list == null)
			{
				if (methodInfo != null && methodInfo.ReturnType.IsByRef)
				{
					@delegate = Class13.Class22.smethod_2(methodBase, bool_4);
				}
				else if (bool_4 && methodInfo != null && methodBase.IsVirtual)
				{
					delegate2 = Class13.Class22.smethod_6(methodBase, bool_4);
				}
			}
			else
			{
				@class = new Class13.Class21(methodBase, list);
				@delegate = Class13.Class22.smethod_3(methodBase, bool_4, @class);
			}
			object obj2 = null;
			Class13.Class24 class4 = null;
			bool flag2 = Nullable.GetUnderlyingType(methodBase.DeclaringType) != null;
			if (!methodBase.IsStatic)
			{
				class4 = this.class41_0.method_4();
				if (class4 != null)
				{
					obj2 = class4.vmethod_4(methodBase.DeclaringType);
				}
				if (obj2 == null && !flag2)
				{
					Type type2 = methodBase.DeclaringType;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
					}
					if (!type2.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type2);
					if (obj2 == null && Nullable.GetUnderlyingType(type2) != null)
					{
						obj2 = FormatterServices.GetUninitializedObject(type2);
					}
					if (class4 is Class13.Class31)
					{
						((Class13.Class30)class4).vmethod_11(Class13.Class24.smethod_1(type2, obj2));
					}
				}
			}
			object obj3 = null;
			if (obj2 == null && flag2)
			{
				if (methodBase is ConstructorInfo && Nullable.GetUnderlyingType(methodBase.DeclaringType) != null)
				{
					obj3 = array[0];
					if (class4 != null && class4 is Class13.Class31)
					{
						((Class13.Class30)class4).vmethod_11(Class13.Class24.smethod_1(Nullable.GetUnderlyingType(methodBase.DeclaringType), obj3));
					}
				}
				else if (!(methodBase.Name == Class13.Class22.string_0))
				{
					if (!(methodBase.Name == Class13.Class22.string_1))
					{
						if (!(methodBase.Name == Class13.Class22.string_4))
						{
							if (methodBase.Name == Class13.Class22.string_3)
							{
								obj3 = 0;
							}
							else if (!(methodBase.Name == Class13.Class22.string_2))
							{
								if (methodBase.Name == Class13.Class22.string_5)
								{
									obj3 = "";
								}
							}
							else
							{
								Class13.Class39 class5 = Class13.Class39.smethod_0(Nullable.GetUnderlyingType(methodBase.DeclaringType));
								if (array != null && array.Length != 0)
								{
									obj3 = class5.vmethod_3(array[0]);
								}
								else
								{
									obj3 = class5.vmethod_2();
								}
							}
						}
						else if (array[0] == null)
						{
							obj3 = true;
						}
						else
						{
							obj3 = false;
						}
					}
					else
					{
						obj3 = null;
					}
				}
				else
				{
					obj3 = false;
				}
			}
			else if (methodBase is ConstructorInfo && Nullable.GetUnderlyingType(methodBase.DeclaringType) != null)
			{
				obj3 = array[0];
				if (class4 != null && class4 is Class13.Class31)
				{
					((Class13.Class30)class4).vmethod_11(Class13.Class24.smethod_1(Nullable.GetUnderlyingType(methodBase.DeclaringType), obj3));
				}
			}
			else if (@delegate != null)
			{
				obj3 = @delegate(obj2, array);
			}
			else if (delegate2 != null)
			{
				obj3 = delegate2(ref obj2, array);
				if (!methodBase.DeclaringType.IsClass && !methodBase.DeclaringType.IsInterface && class4 != null && class4 is Class13.Class30)
				{
					Type type3 = Nullable.GetUnderlyingType(methodBase.DeclaringType);
					if (type3 == null)
					{
						type3 = methodBase.DeclaringType;
					}
					((Class13.Class30)class4).vmethod_11(Class13.Class24.smethod_1(type3, obj2));
				}
			}
			else
			{
				obj3 = methodBase.Invoke(obj2, array);
			}
			for (int j = 0; j < parameters.Length; j++)
			{
				if (parameters[j].ParameterType.IsByRef && (@class == null || !@class.method_1(j)))
				{
					if (array2[j].epLymgDpIC())
					{
						((Class13.Class28)array2[j]).method_4(Class13.Class24.smethod_1(parameters[j].ParameterType, array[j]));
					}
					else if (array2[j] is Class13.Class31)
					{
						array2[j].zhnXqoJuKJ(Class13.Class24.smethod_1(parameters[j].ParameterType.GetElementType(), array[j]));
					}
					else
					{
						array2[j].zhnXqoJuKJ(Class13.Class24.smethod_1(parameters[j].ParameterType, array[j]));
					}
				}
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				this.class41_0.method_2(Class13.Class24.smethod_1(methodInfo.ReturnType, obj3));
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00013E0C File Offset: 0x0001200C
		private static Class13.Delegate12 smethod_2(MethodBase methodBase_0, bool bool_4)
		{
			object obj = Class13.Class22.object_3;
			Class13.Delegate12 delegate3;
			lock (obj)
			{
				Class13.Delegate12 @delegate = null;
				if (!bool_4)
				{
					if (Class13.Class22.dictionary_3.TryGetValue(methodBase_0, out @delegate))
					{
						return @delegate;
					}
				}
				else if (Class13.Class22.dictionary_2.TryGetValue(methodBase_0, out @delegate))
				{
					return @delegate;
				}
				MethodInfo methodInfo = methodBase_0 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (methodBase_0.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				if (methodBase_0.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType);
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class13.Class22.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!array[k].IsValueType)
					{
						if (array[k] != typeof(object))
						{
							ilgenerator.Emit(OpCodes.Castclass, array[k]);
						}
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!methodBase_0.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (!methodBase_0.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Castclass, methodBase_0.DeclaringType);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, methodBase_0.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[array2.Length - 1]);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
				}
				if (bool_4)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Call, methodBase_0 as ConstructorInfo);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Callvirt, methodBase_0 as ConstructorInfo);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (!methodInfo.ReturnType.IsByRef)
					{
						if (methodInfo.ReturnType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
						}
					}
					else
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class13.Class22.smethod_5(ilgenerator, m);
						ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class13.Delegate12 delegate2 = (Class13.Delegate12)dynamicMethod.CreateDelegate(typeof(Class13.Delegate12));
				if (!bool_4)
				{
					Class13.Class22.dictionary_3.Add(methodBase_0, delegate2);
				}
				else
				{
					Class13.Class22.dictionary_2.Add(methodBase_0, delegate2);
				}
				delegate3 = delegate2;
			}
			return delegate3;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000142AC File Offset: 0x000124AC
		private static Class13.Delegate12 smethod_3(MethodBase methodBase_0, bool bool_4, Class13.Class21 class21_0)
		{
			object obj = Class13.Class22.object_4;
			Class13.Delegate12 delegate3;
			lock (obj)
			{
				Class13.Delegate12 @delegate = null;
				if (bool_4)
				{
					if (Class13.Class22.dictionary_4.TryGetValue(class21_0, out @delegate))
					{
						return @delegate;
					}
				}
				else if (Class13.Class22.dictionary_5.TryGetValue(class21_0, out @delegate))
				{
					return @delegate;
				}
				MethodInfo methodInfo = methodBase_0 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, typeof(Class13), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (methodBase_0.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (!class21_0.method_1(j))
					{
						array2[j] = ilgenerator.DeclareLocal(array[j]);
					}
					else
					{
						array2[j] = ilgenerator.DeclareLocal(typeof(object));
					}
				}
				if (methodBase_0.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class13.Class22.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!class21_0.method_1(k))
					{
						if (array[k].IsValueType)
						{
							ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
						}
						else if (array[k] != typeof(object))
						{
							ilgenerator.Emit(OpCodes.Castclass, array[k]);
						}
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!methodBase_0.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (methodBase_0.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox, methodBase_0.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Castclass, methodBase_0.DeclaringType);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!class21_0.method_1(l))
					{
						if (parameters[l].ParameterType.IsByRef)
						{
							ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
						}
					}
					else
					{
						Class13.Class20 @class = class21_0.method_0(l);
						if (@class.fieldInfo_0.IsStatic)
						{
							ilgenerator.Emit(OpCodes.Ldsflda, @class.fieldInfo_0);
						}
						else if (!@class.fieldInfo_0.DeclaringType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(OpCodes.Castclass, @class.fieldInfo_0.DeclaringType);
							ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(OpCodes.Unbox, @class.fieldInfo_0.DeclaringType);
							ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
						}
					}
				}
				if (bool_4)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Call, methodBase_0 as ConstructorInfo);
					}
				}
				else if (!(methodInfo != null))
				{
					ilgenerator.Emit(OpCodes.Callvirt, methodBase_0 as ConstructorInfo);
				}
				else
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (!methodInfo.ReturnType.IsByRef)
					{
						if (methodInfo.ReturnType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
						}
					}
					else
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (!elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						if (!class21_0.method_1(m))
						{
							ilgenerator.Emit(OpCodes.Ldarg_1);
							Class13.Class22.smethod_5(ilgenerator, m);
							ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
							}
							ilgenerator.Emit(OpCodes.Stelem_Ref);
						}
						else
						{
							Class13.Class20 class2 = class21_0.method_0(m);
							if (!class2.fieldInfo_0.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class13.Class22.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.fieldInfo_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class13.Class22.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldsfld, class2.fieldInfo_0);
								if (class2.fieldInfo_0.FieldType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.fieldInfo_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
						}
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class13.Delegate12 delegate2 = (Class13.Delegate12)dynamicMethod.CreateDelegate(typeof(Class13.Delegate12));
				if (bool_4)
				{
					Class13.Class22.dictionary_4.Add(class21_0, delegate2);
				}
				else
				{
					Class13.Class22.dictionary_5.Add(class21_0, delegate2);
				}
				delegate3 = delegate2;
			}
			return delegate3;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00014948 File Offset: 0x00012B48
		private static Class13.Delegate12 smethod_4(MethodBase methodBase_0, bool bool_4, Class13.Class21 class21_0)
		{
			object obj = Class13.Class22.object_5;
			Class13.Delegate12 delegate2;
			lock (obj)
			{
				Class13.Delegate12 @delegate = null;
				if (Class13.Class22.dictionary_6.TryGetValue(class21_0, out @delegate))
				{
					delegate2 = @delegate;
				}
				else
				{
					ConstructorInfo constructorInfo = methodBase_0 as ConstructorInfo;
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
					{
						typeof(object),
						typeof(object[])
					}, typeof(Class13), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ParameterInfo[] parameters = methodBase_0.GetParameters();
					Type[] array = new Type[parameters.Length];
					for (int i = 0; i < array.Length; i++)
					{
						if (parameters[i].ParameterType.IsByRef)
						{
							array[i] = parameters[i].ParameterType.GetElementType();
						}
						else
						{
							array[i] = parameters[i].ParameterType;
						}
					}
					int num = array.Length;
					if (methodBase_0.DeclaringType.IsValueType)
					{
						num++;
					}
					LocalBuilder[] array2 = new LocalBuilder[num];
					for (int j = 0; j < array.Length; j++)
					{
						if (class21_0.method_1(j))
						{
							array2[j] = ilgenerator.DeclareLocal(typeof(object));
						}
						else
						{
							array2[j] = ilgenerator.DeclareLocal(array[j]);
						}
					}
					if (methodBase_0.DeclaringType.IsValueType)
					{
						array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType.MakeByRefType());
					}
					for (int k = 0; k < array.Length; k++)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class13.Class22.smethod_5(ilgenerator, k);
						ilgenerator.Emit(OpCodes.Ldelem_Ref);
						if (!class21_0.method_1(k))
						{
							if (!array[k].IsValueType)
							{
								if (array[k] != typeof(object))
								{
									ilgenerator.Emit(OpCodes.Castclass, array[k]);
								}
							}
							else
							{
								ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
							}
						}
						ilgenerator.Emit(OpCodes.Stloc, array2[k]);
					}
					for (int l = 0; l < array.Length; l++)
					{
						if (class21_0.method_1(l))
						{
							Class13.Class20 @class = class21_0.method_0(l);
							if (!@class.fieldInfo_0.IsStatic)
							{
								if (@class.fieldInfo_0.DeclaringType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
									ilgenerator.Emit(OpCodes.Unbox, @class.fieldInfo_0.DeclaringType);
									ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
									ilgenerator.Emit(OpCodes.Castclass, @class.fieldInfo_0.DeclaringType);
									ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
								}
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldsflda, @class.fieldInfo_0);
							}
						}
						else if (parameters[l].ParameterType.IsByRef)
						{
							ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
						}
					}
					ilgenerator.Emit(OpCodes.Newobj, methodBase_0 as ConstructorInfo);
					if (constructorInfo.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, constructorInfo.DeclaringType);
					}
					for (int m = 0; m < array.Length; m++)
					{
						if (parameters[m].ParameterType.IsByRef)
						{
							if (!class21_0.method_1(m))
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class13.Class22.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								Class13.Class20 class2 = class21_0.method_0(m);
								if (!class2.fieldInfo_0.IsStatic)
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class13.Class22.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
									if (array2[m].LocalType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class13.Class22.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldsfld, class2.fieldInfo_0);
									if (class2.fieldInfo_0.FieldType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
							}
						}
					}
					ilgenerator.Emit(OpCodes.Ret);
					Class13.Delegate12 delegate3 = (Class13.Delegate12)dynamicMethod.CreateDelegate(typeof(Class13.Delegate12));
					Class13.Class22.dictionary_6.Add(class21_0, delegate3);
					delegate2 = delegate3;
				}
			}
			return delegate2;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00014E68 File Offset: 0x00013068
		private static void smethod_5(ILGenerator ilgenerator_0, int int_3)
		{
			switch (int_3)
			{
			case -1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
				return;
			case 0:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
				return;
			case 1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
				return;
			case 2:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
				return;
			case 3:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
				return;
			case 4:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
				return;
			case 5:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
				return;
			case 6:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
				return;
			case 7:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
				return;
			case 8:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
				return;
			default:
				if (int_3 > -129 && int_3 < 128)
				{
					ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_3);
					return;
				}
				ilgenerator_0.Emit(OpCodes.Ldc_I4, int_3);
				return;
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00014F48 File Offset: 0x00013148
		private static Class13.Class22.Delegate17 smethod_6(MethodBase methodBase_0, bool bool_4)
		{
			object obj = Class13.Class22.object_6;
			Class13.Class22.Delegate17 delegate3;
			lock (obj)
			{
				Class13.Class22.Delegate17 @delegate = null;
				if (bool_4)
				{
					if (Class13.Class22.dictionary_7.TryGetValue(methodBase_0, out @delegate))
					{
						return @delegate;
					}
				}
				else if (Class13.Class22.dictionary_8.TryGetValue(methodBase_0, out @delegate))
				{
					return @delegate;
				}
				MethodInfo methodInfo = methodBase_0 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object).MakeByRefType(),
					typeof(object[])
				}, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (!parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType;
					}
					else
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
				}
				LocalBuilder[] array2 = new LocalBuilder[array.Length + 1];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType);
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class13.Class22.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!array[k].IsValueType)
					{
						if (array[k] != typeof(object))
						{
							ilgenerator.Emit(OpCodes.Castclass, array[k]);
						}
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!methodBase_0.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldind_Ref);
					if (!methodBase_0.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Castclass, methodBase_0.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, methodBase_0.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[array2.Length - 1]);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
				}
				if (bool_4)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Call, methodBase_0 as ConstructorInfo);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Callvirt, methodBase_0 as ConstructorInfo);
				}
				if (!methodBase_0.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldloc, array2[array2.Length - 1]);
					if (methodBase_0.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodBase_0.DeclaringType);
					}
					ilgenerator.Emit(OpCodes.Stind_Ref);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (!methodInfo.ReturnType.IsByRef)
					{
						if (methodInfo.ReturnType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
						}
					}
					else
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class13.Class22.smethod_5(ilgenerator, m);
						ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class13.Class22.Delegate17 delegate2 = (Class13.Class22.Delegate17)dynamicMethod.CreateDelegate(typeof(Class13.Class22.Delegate17));
				if (bool_4)
				{
					Class13.Class22.dictionary_7.Add(methodBase_0, delegate2);
				}
				else
				{
					Class13.Class22.dictionary_8.Add(methodBase_0, delegate2);
				}
				delegate3 = delegate2;
			}
			return delegate3;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00015458 File Offset: 0x00013658
		private static Class13.Class24 smethod_7(Class13.Class24 class24_3)
		{
			if (class24_3.vmethod_8().method_0())
			{
				object obj = class24_3.vmethod_4(null);
				if (obj != null && obj.GetType().IsEnum)
				{
					Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
					object obj2 = Convert.ChangeType(obj, underlyingType);
					Class13.Class24 @class = Class13.Class22.smethod_8(Class13.Class24.smethod_1(underlyingType, obj2));
					if (@class != null)
					{
						return @class as Class13.Class25;
					}
				}
			}
			return class24_3;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		private static Class13.Class25 smethod_8(Class13.Class24 class24_3)
		{
			Class13.Class25 @class = class24_3 as Class13.Class25;
			if (@class == null && class24_3.vmethod_0())
			{
				@class = class24_3.vmethod_8() as Class13.Class25;
			}
			return @class;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000154B8 File Offset: 0x000136B8
		private static IntPtr smethod_9(Class13.Class24 class24_3)
		{
			if (class24_3 == null)
			{
				return IntPtr.Zero;
			}
			if (class24_3.epLymgDpIC())
			{
				return ((Class13.Class28)class24_3).uilAcHjmLR();
			}
			if (class24_3.vmethod_0())
			{
				Class13.Class30 @class = (Class13.Class30)class24_3;
				IntPtr intPtr;
				try
				{
					intPtr = @class.vmethod_10();
				}
				catch
				{
					goto IL_003A;
				}
				return intPtr;
			}
			IL_003A:
			object obj = class24_3.vmethod_4(typeof(IntPtr));
			if (obj == null || !(obj.GetType() == typeof(IntPtr)))
			{
				throw new Class13.Exception1();
			}
			return (IntPtr)obj;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00015548 File Offset: 0x00013748
		private static object smethod_10(object object_8)
		{
			object obj = Class13.Class22.object_7;
			object obj2;
			lock (obj)
			{
				if (Class13.Class22.dictionary_9 == null)
				{
					Class13.Class22.dictionary_9 = new Dictionary<Type, Class13.Delegate14>();
				}
				if (object_8 != null)
				{
					try
					{
						Type type = object_8.GetType();
						Class13.Delegate14 @delegate;
						if (!Class13.Class22.dictionary_9.TryGetValue(type, out @delegate))
						{
							DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[] { typeof(object) }, true);
							ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
							ilgenerator.Emit(OpCodes.Ldarg_0);
							ilgenerator.Emit(OpCodes.Unbox_Any, type);
							ilgenerator.Emit(OpCodes.Box, type);
							ilgenerator.Emit(OpCodes.Ret);
							Class13.Delegate14 delegate2 = (Class13.Delegate14)dynamicMethod.CreateDelegate(typeof(Class13.Delegate14));
							Class13.Class22.dictionary_9.Add(type, delegate2);
							return delegate2(object_8);
						}
						return @delegate(object_8);
					}
					catch
					{
						return null;
					}
				}
				obj2 = null;
			}
			return obj2;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00015660 File Offset: 0x00013860
		private static void smethod_11(IntPtr intptr_0, byte byte_0, int int_3)
		{
			object obj = Class13.Class22.object_7;
			lock (obj)
			{
				if (Class13.Class22.delegate15_0 == null)
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
					{
						typeof(IntPtr),
						typeof(byte),
						typeof(int)
					}, typeof(Class13), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldarg_1);
					ilgenerator.Emit(OpCodes.Ldarg_2);
					ilgenerator.Emit(OpCodes.Initblk);
					ilgenerator.Emit(OpCodes.Ret);
					Class13.Class22.delegate15_0 = (Class13.Delegate15)dynamicMethod.CreateDelegate(typeof(Class13.Delegate15));
				}
				Class13.Class22.delegate15_0(intptr_0, byte_0, int_3);
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00015754 File Offset: 0x00013954
		private static void smethod_12(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
		{
			if (Class13.Class22.delegate16_0 == null)
			{
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
				{
					typeof(IntPtr),
					typeof(IntPtr),
					typeof(uint)
				}, typeof(Class13), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ilgenerator.Emit(OpCodes.Ldarg_0);
				ilgenerator.Emit(OpCodes.Ldarg_1);
				ilgenerator.Emit(OpCodes.Ldarg_2);
				ilgenerator.Emit(OpCodes.Cpblk);
				ilgenerator.Emit(OpCodes.Ret);
				Class13.Class22.delegate16_0 = (Class13.Delegate16)dynamicMethod.CreateDelegate(typeof(Class13.Delegate16));
			}
			Class13.Class22.delegate16_0(intptr_0, intptr_1, uint_0);
		}

		// Token: 0x040000AC RID: 172
		internal Class13.Class19 class19_0;

		// Token: 0x040000AD RID: 173
		internal Class13.Class24[] class24_0 = new Class13.Class24[0];

		// Token: 0x040000AE RID: 174
		internal Class13.Class24[] class24_1 = new Class13.Class24[0];

		// Token: 0x040000AF RID: 175
		internal Class13.Class41 class41_0 = new Class13.Class41();

		// Token: 0x040000B0 RID: 176
		internal Class13.Class24 class24_2;

		// Token: 0x040000B1 RID: 177
		internal Exception exception_0;

		// Token: 0x040000B2 RID: 178
		internal List<IntPtr> list_0;

		// Token: 0x040000B3 RID: 179
		private int int_0;

		// Token: 0x040000B4 RID: 180
		private int int_1;

		// Token: 0x040000B5 RID: 181
		private int int_2 = -1;

		// Token: 0x040000B6 RID: 182
		private object object_0;

		// Token: 0x040000B7 RID: 183
		private bool bool_0;

		// Token: 0x040000B8 RID: 184
		private bool bool_1;

		// Token: 0x040000B9 RID: 185
		private bool bool_2;

		// Token: 0x040000BA RID: 186
		private bool bool_3;

		// Token: 0x040000BB RID: 187
		private static Dictionary<Type, int> dictionary_0;

		// Token: 0x040000BC RID: 188
		private static object object_1 = new object();

		// Token: 0x040000BD RID: 189
		private static Dictionary<object, Class13.Class24> dictionary_1 = new Dictionary<object, Class13.Class24>();

		// Token: 0x040000BE RID: 190
		private static object object_2 = new object();

		// Token: 0x040000BF RID: 191
		private static string string_0 = Encoding.Unicode.GetString(new byte[]
		{
			103, 0, 101, 0, 116, 0, 95, 0, 72, 0,
			97, 0, 115, 0, 86, 0, 97, 0, 108, 0,
			117, 0, 101, 0
		});

		// Token: 0x040000C0 RID: 192
		private static string string_1 = Encoding.Unicode.GetString(new byte[]
		{
			103, 0, 101, 0, 116, 0, 95, 0, 86, 0,
			97, 0, 108, 0, 117, 0, 101, 0
		});

		// Token: 0x040000C1 RID: 193
		private static string string_2 = Encoding.Unicode.GetString(new byte[]
		{
			71, 0, 101, 0, 116, 0, 86, 0, 97, 0,
			108, 0, 117, 0, 101, 0, 79, 0, 114, 0,
			68, 0, 101, 0, 102, 0, 97, 0, 117, 0,
			108, 0, 116, 0
		});

		// Token: 0x040000C2 RID: 194
		private static string string_3 = Encoding.Unicode.GetString(new byte[]
		{
			71, 0, 101, 0, 116, 0, 72, 0, 97, 0,
			115, 0, 104, 0, 67, 0, 111, 0, 100, 0,
			101, 0
		});

		// Token: 0x040000C3 RID: 195
		private static string string_4 = Encoding.Unicode.GetString(new byte[]
		{
			69, 0, 113, 0, 117, 0, 97, 0, 108, 0,
			115, 0
		});

		// Token: 0x040000C4 RID: 196
		private static string string_5 = Encoding.Unicode.GetString(new byte[]
		{
			84, 0, 111, 0, 83, 0, 116, 0, 114, 0,
			105, 0, 110, 0, 103, 0
		});

		// Token: 0x040000C5 RID: 197
		private static Dictionary<MethodBase, Class13.Delegate12> dictionary_2 = new Dictionary<MethodBase, Class13.Delegate12>();

		// Token: 0x040000C6 RID: 198
		private static Dictionary<MethodBase, Class13.Delegate12> dictionary_3 = new Dictionary<MethodBase, Class13.Delegate12>();

		// Token: 0x040000C7 RID: 199
		private static object object_3 = new object();

		// Token: 0x040000C8 RID: 200
		private static Dictionary<Class13.Class21, Class13.Delegate12> dictionary_4 = new Dictionary<Class13.Class21, Class13.Delegate12>();

		// Token: 0x040000C9 RID: 201
		private static Dictionary<Class13.Class21, Class13.Delegate12> dictionary_5 = new Dictionary<Class13.Class21, Class13.Delegate12>();

		// Token: 0x040000CA RID: 202
		private static object object_4 = new object();

		// Token: 0x040000CB RID: 203
		private static Dictionary<Class13.Class21, Class13.Delegate12> dictionary_6 = new Dictionary<Class13.Class21, Class13.Delegate12>();

		// Token: 0x040000CC RID: 204
		private static object object_5 = new object();

		// Token: 0x040000CD RID: 205
		private static object object_6 = new object();

		// Token: 0x040000CE RID: 206
		private static Dictionary<MethodBase, Class13.Class22.Delegate17> dictionary_7 = new Dictionary<MethodBase, Class13.Class22.Delegate17>();

		// Token: 0x040000CF RID: 207
		private static Dictionary<MethodBase, Class13.Class22.Delegate17> dictionary_8 = new Dictionary<MethodBase, Class13.Class22.Delegate17>();

		// Token: 0x040000D0 RID: 208
		private static Dictionary<Type, Class13.Delegate14> dictionary_9;

		// Token: 0x040000D1 RID: 209
		private static object object_7 = new object();

		// Token: 0x040000D2 RID: 210
		private static Class13.Delegate15 delegate15_0;

		// Token: 0x040000D3 RID: 211
		private static Class13.Delegate16 delegate16_0;

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600039F RID: 927
		private delegate object Delegate17(ref object target, object[] paramters);

		// Token: 0x0200004C RID: 76
		[CompilerGenerated]
		[Serializable]
		private sealed class Class23
		{
			// Token: 0x060003A4 RID: 932 RVA: 0x000041E5 File Offset: 0x000023E5
			internal int method_0(Class13.Class17 x, Class13.Class17 y)
			{
				return x.class18_0.int_0.CompareTo(y.class18_0.int_0);
			}

			// Token: 0x040000D4 RID: 212
			public static readonly Class13.Class22.Class23 <>9 = new Class13.Class22.Class23();

			// Token: 0x040000D5 RID: 213
			public static Comparison<Class13.Class17> <>9__12_0;
		}
	}

	// Token: 0x0200004D RID: 77
	internal enum Enum4 : byte
	{

	}

	// Token: 0x0200004E RID: 78
	internal enum Enum5 : byte
	{

	}

	// Token: 0x0200004F RID: 79
	internal abstract class Class24
	{
		// Token: 0x060003A5 RID: 933 RVA: 0x00002329 File Offset: 0x00000529
		public Class24()
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00004202 File Offset: 0x00002402
		internal bool method_0()
		{
			return this.enum5_0 == (Class13.Enum5)0;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000420D File Offset: 0x0000240D
		internal bool method_1()
		{
			return this.enum5_0 == (Class13.Enum5)1;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00004218 File Offset: 0x00002418
		internal bool GxdycPcase()
		{
			return this.enum5_0 == (Class13.Enum5)8;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00004223 File Offset: 0x00002423
		internal bool epLymgDpIC()
		{
			return this.enum5_0 == (Class13.Enum5)3 || this.enum5_0 == (Class13.Enum5)4;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00004239 File Offset: 0x00002439
		internal bool method_2()
		{
			return this.enum5_0 == (Class13.Enum5)2;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00004244 File Offset: 0x00002444
		internal bool uMpydVvbAn()
		{
			return this.enum5_0 == (Class13.Enum5)5;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000424F File Offset: 0x0000244F
		internal bool method_3()
		{
			return this.enum5_0 == (Class13.Enum5)6;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000425A File Offset: 0x0000245A
		internal virtual bool vmethod_0()
		{
			return false;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000425A File Offset: 0x0000245A
		internal virtual bool vmethod_1()
		{
			return false;
		}

		// Token: 0x060003AF RID: 943
		internal abstract void vmethod_2(Class13.Class24 class24_0);

		// Token: 0x060003B0 RID: 944 RVA: 0x0000425A File Offset: 0x0000245A
		internal virtual bool vmethod_3()
		{
			return false;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000425D File Offset: 0x0000245D
		internal Class24(Class13.Enum5 enum5_1)
		{
			this.enum5_0 = enum5_1;
		}

		// Token: 0x060003B2 RID: 946
		internal abstract object vmethod_4(Type type_0);

		// Token: 0x060003B3 RID: 947
		internal abstract bool vmethod_5(Class13.Class24 class24_0);

		// Token: 0x060003B4 RID: 948
		internal abstract bool vmethod_6(Class13.Class24 class24_0);

		// Token: 0x060003B5 RID: 949
		internal abstract bool vmethod_7();

		// Token: 0x060003B6 RID: 950
		internal abstract Class13.Class24 vmethod_8();

		// Token: 0x060003B7 RID: 951 RVA: 0x0000425A File Offset: 0x0000245A
		internal virtual bool vmethod_9()
		{
			return false;
		}

		// Token: 0x060003B8 RID: 952
		internal abstract void zhnXqoJuKJ(Class13.Class24 class24_0);

		// Token: 0x060003B9 RID: 953 RVA: 0x00015988 File Offset: 0x00013B88
		internal static Class13.Enum3 smethod_0(Type type_0)
		{
			Type type = type_0;
			if (!(type != null))
			{
				return (Class13.Enum3)18;
			}
			if (type.IsByRef)
			{
				type = type.GetElementType();
			}
			if (type != null && Nullable.GetUnderlyingType(type) != null)
			{
				type = Nullable.GetUnderlyingType(type);
			}
			if (type == typeof(string))
			{
				return (Class13.Enum3)14;
			}
			if (type == typeof(byte))
			{
				return (Class13.Enum3)2;
			}
			if (type == typeof(sbyte))
			{
				return (Class13.Enum3)1;
			}
			if (type == typeof(short))
			{
				return (Class13.Enum3)3;
			}
			if (type == typeof(ushort))
			{
				return (Class13.Enum3)4;
			}
			if (type == typeof(int))
			{
				return (Class13.Enum3)5;
			}
			if (type == typeof(uint))
			{
				return (Class13.Enum3)6;
			}
			if (type == typeof(long))
			{
				return (Class13.Enum3)7;
			}
			if (type == typeof(ulong))
			{
				return (Class13.Enum3)8;
			}
			if (type == typeof(float))
			{
				return (Class13.Enum3)9;
			}
			if (type == typeof(double))
			{
				return (Class13.Enum3)10;
			}
			if (type == typeof(bool))
			{
				return (Class13.Enum3)11;
			}
			if (type == typeof(IntPtr))
			{
				return (Class13.Enum3)12;
			}
			if (type == typeof(UIntPtr))
			{
				return (Class13.Enum3)13;
			}
			if (type == typeof(char))
			{
				return (Class13.Enum3)15;
			}
			if (type == typeof(object))
			{
				return (Class13.Enum3)0;
			}
			if (type.IsEnum)
			{
				return (Class13.Enum3)16;
			}
			return (Class13.Enum3)17;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00015B3C File Offset: 0x00013D3C
		internal static Class13.Class24 smethod_1(Type type_0, object object_0)
		{
			Type underlyingType = Nullable.GetUnderlyingType(type_0);
			if (!(underlyingType != null))
			{
				Class13.Enum3 @enum = Class13.Class24.smethod_0(type_0);
				Class13.Enum3 enum2 = (Class13.Enum3)18;
				if (object_0 != null)
				{
					enum2 = Class13.Class24.smethod_0(object_0.GetType());
				}
				Class13.Class24 @class = null;
				switch (@enum)
				{
				case (Class13.Enum3)0:
					if (enum2 == (Class13.Enum3)15)
					{
						@class = new Class13.Class36(object_0);
					}
					else
					{
						@class = Class13.Class24.smethod_2(object_0);
					}
					break;
				case (Class13.Enum3)1:
					if (enum2 <= (Class13.Enum3)2)
					{
						if (enum2 == (Class13.Enum3)1)
						{
							@class = new Class13.Class26((int)((sbyte)object_0), (Class13.Enum2)1);
							break;
						}
						if (enum2 == (Class13.Enum3)2)
						{
							@class = new Class13.Class26((int)((sbyte)((byte)object_0)), (Class13.Enum2)1);
							break;
						}
					}
					else if (enum2 != (Class13.Enum3)11)
					{
						if (enum2 == (Class13.Enum3)15)
						{
							@class = new Class13.Class26((int)((sbyte)((char)object_0)), (Class13.Enum2)1);
							break;
						}
					}
					else
					{
						if (!(bool)object_0)
						{
							@class = new Class13.Class26(0, (Class13.Enum2)1);
							break;
						}
						@class = new Class13.Class26(1, (Class13.Enum2)1);
						break;
					}
					throw new InvalidCastException();
				case (Class13.Enum3)2:
					if (enum2 <= (Class13.Enum3)2)
					{
						if (enum2 == (Class13.Enum3)1)
						{
							@class = new Class13.Class26((int)((byte)((sbyte)object_0)), (Class13.Enum2)2);
							break;
						}
						if (enum2 == (Class13.Enum3)2)
						{
							@class = new Class13.Class26((int)((byte)object_0), (Class13.Enum2)2);
							break;
						}
					}
					else if (enum2 != (Class13.Enum3)11)
					{
						if (enum2 == (Class13.Enum3)15)
						{
							@class = new Class13.Class26((int)((byte)((char)object_0)), (Class13.Enum2)2);
							break;
						}
					}
					else
					{
						if ((bool)object_0)
						{
							@class = new Class13.Class26(1, (Class13.Enum2)2);
							break;
						}
						@class = new Class13.Class26(0, (Class13.Enum2)2);
						break;
					}
					throw new InvalidCastException();
				case (Class13.Enum3)3:
					if (enum2 != (Class13.Enum3)3)
					{
						if (enum2 != (Class13.Enum3)11)
						{
							if (enum2 != (Class13.Enum3)15)
							{
								throw new InvalidCastException();
							}
							@class = new Class13.Class26((int)((short)((char)object_0)), (Class13.Enum2)3);
						}
						else if (!(bool)object_0)
						{
							@class = new Class13.Class26(0, (Class13.Enum2)3);
						}
						else
						{
							@class = new Class13.Class26(1, (Class13.Enum2)3);
						}
					}
					else
					{
						@class = new Class13.Class26((int)((short)object_0), (Class13.Enum2)3);
					}
					break;
				case (Class13.Enum3)4:
					if (enum2 != (Class13.Enum3)4)
					{
						if (enum2 != (Class13.Enum3)11)
						{
							if (enum2 != (Class13.Enum3)15)
							{
								throw new InvalidCastException();
							}
							@class = new Class13.Class26((int)((char)object_0), (Class13.Enum2)4);
						}
						else if (!(bool)object_0)
						{
							@class = new Class13.Class26(0, (Class13.Enum2)4);
						}
						else
						{
							@class = new Class13.Class26(1, (Class13.Enum2)4);
						}
					}
					else
					{
						@class = new Class13.Class26((int)((ushort)object_0), (Class13.Enum2)4);
					}
					break;
				case (Class13.Enum3)5:
					if (enum2 != (Class13.Enum3)5)
					{
						if (enum2 != (Class13.Enum3)11)
						{
							if (enum2 != (Class13.Enum3)15)
							{
								throw new InvalidCastException();
							}
							@class = new Class13.Class26((int)((char)object_0), (Class13.Enum2)5);
						}
						else if ((bool)object_0)
						{
							@class = new Class13.Class26(1, (Class13.Enum2)5);
						}
						else
						{
							@class = new Class13.Class26(0, (Class13.Enum2)5);
						}
					}
					else
					{
						@class = new Class13.Class26((int)object_0, (Class13.Enum2)5);
					}
					break;
				case (Class13.Enum3)6:
					if (enum2 != (Class13.Enum3)6)
					{
						if (enum2 != (Class13.Enum3)11)
						{
							if (enum2 != (Class13.Enum3)15)
							{
								throw new InvalidCastException();
							}
							@class = new Class13.Class26((uint)((char)object_0), (Class13.Enum2)6);
						}
						else if ((bool)object_0)
						{
							@class = new Class13.Class26(1U, (Class13.Enum2)6);
						}
						else
						{
							@class = new Class13.Class26(0U, (Class13.Enum2)6);
						}
					}
					else
					{
						@class = new Class13.Class26((uint)object_0, (Class13.Enum2)6);
					}
					break;
				case (Class13.Enum3)7:
					if (enum2 != (Class13.Enum3)7)
					{
						if (enum2 != (Class13.Enum3)11)
						{
							if (enum2 != (Class13.Enum3)15)
							{
								throw new InvalidCastException();
							}
							@class = new Class13.Class27((long)((ulong)((char)object_0)), (Class13.Enum2)7);
						}
						else if ((bool)object_0)
						{
							@class = new Class13.Class27(1L, (Class13.Enum2)7);
						}
						else
						{
							@class = new Class13.Class27(0L, (Class13.Enum2)7);
						}
					}
					else
					{
						@class = new Class13.Class27((long)object_0, (Class13.Enum2)7);
					}
					break;
				case (Class13.Enum3)8:
					if (enum2 != (Class13.Enum3)8)
					{
						if (enum2 != (Class13.Enum3)11)
						{
							if (enum2 != (Class13.Enum3)15)
							{
								throw new InvalidCastException();
							}
							@class = new Class13.Class27((ulong)((char)object_0), (Class13.Enum2)8);
						}
						else if ((bool)object_0)
						{
							@class = new Class13.Class27(1UL, (Class13.Enum2)8);
						}
						else
						{
							@class = new Class13.Class27(0UL, (Class13.Enum2)8);
						}
					}
					else
					{
						@class = new Class13.Class27((ulong)object_0, (Class13.Enum2)8);
					}
					break;
				case (Class13.Enum3)9:
					if (enum2 != (Class13.Enum3)9)
					{
						throw new InvalidCastException();
					}
					@class = new Class13.Class29((float)object_0);
					break;
				case (Class13.Enum3)10:
					if (enum2 != (Class13.Enum3)10)
					{
						throw new InvalidCastException();
					}
					@class = new Class13.Class29((double)object_0);
					break;
				case (Class13.Enum3)11:
					switch (enum2)
					{
					case (Class13.Enum3)1:
						@class = new Class13.Class26((sbyte)object_0 != 0);
						goto IL_062B;
					case (Class13.Enum3)2:
						@class = new Class13.Class26((byte)object_0 > 0);
						goto IL_062B;
					case (Class13.Enum3)3:
						@class = new Class13.Class26((short)object_0 != 0);
						goto IL_062B;
					case (Class13.Enum3)4:
						@class = new Class13.Class26((ushort)object_0 > 0);
						goto IL_062B;
					case (Class13.Enum3)5:
						@class = new Class13.Class26((int)object_0 != 0);
						goto IL_062B;
					case (Class13.Enum3)6:
						@class = new Class13.Class26((uint)object_0 > 0U);
						goto IL_062B;
					case (Class13.Enum3)7:
						@class = new Class13.Class26((long)object_0 != 0L);
						goto IL_062B;
					case (Class13.Enum3)8:
						@class = new Class13.Class26((ulong)object_0 > 0UL);
						goto IL_062B;
					case (Class13.Enum3)9:
					case (Class13.Enum3)10:
					case (Class13.Enum3)12:
					case (Class13.Enum3)13:
					case (Class13.Enum3)14:
					case (Class13.Enum3)15:
					case (Class13.Enum3)16:
						throw new InvalidCastException();
					case (Class13.Enum3)11:
						@class = new Class13.Class26((bool)object_0);
						goto IL_062B;
					case (Class13.Enum3)18:
						@class = new Class13.Class26(false);
						goto IL_062B;
					}
					@class = new Class13.Class26(object_0 != null);
					break;
				case (Class13.Enum3)12:
					if (enum2 != (Class13.Enum3)12)
					{
						throw new InvalidCastException();
					}
					@class = new Class13.Class28((IntPtr)object_0);
					break;
				case (Class13.Enum3)13:
					if (enum2 != (Class13.Enum3)13)
					{
						throw new InvalidCastException();
					}
					@class = new Class13.Class28((UIntPtr)object_0);
					break;
				case (Class13.Enum3)14:
					@class = new Class13.Class37(object_0 as string);
					break;
				case (Class13.Enum3)15:
					switch (enum2)
					{
					case (Class13.Enum3)1:
						@class = new Class13.Class26((int)((sbyte)object_0), (Class13.Enum2)15);
						break;
					case (Class13.Enum3)2:
						@class = new Class13.Class26((int)((byte)object_0), (Class13.Enum2)15);
						break;
					case (Class13.Enum3)3:
						@class = new Class13.Class26((int)((short)object_0), (Class13.Enum2)15);
						break;
					case (Class13.Enum3)4:
						@class = new Class13.Class26((int)((ushort)object_0), (Class13.Enum2)15);
						break;
					case (Class13.Enum3)5:
						@class = new Class13.Class26((int)object_0, (Class13.Enum2)15);
						break;
					case (Class13.Enum3)6:
						@class = new Class13.Class26((int)((uint)object_0), (Class13.Enum2)15);
						break;
					default:
						if (enum2 != (Class13.Enum3)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class13.Class26((int)((char)object_0), (Class13.Enum2)15);
						break;
					}
					break;
				case (Class13.Enum3)16:
				case (Class13.Enum3)17:
					@class = Class13.Class24.smethod_2(object_0);
					break;
				case (Class13.Enum3)18:
					throw new InvalidCastException();
				}
				IL_062B:
				if (type_0.IsByRef)
				{
					@class = new Class13.Class35(@class, type_0.GetElementType());
				}
				return @class;
			}
			return new Class13.Class38(object_0, underlyingType);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00016198 File Offset: 0x00014398
		private static Class13.Class24 smethod_2(object object_0)
		{
			if (object_0 != null && object_0.GetType().IsEnum)
			{
				Type underlyingType = Enum.GetUnderlyingType(object_0.GetType());
				object obj = Convert.ChangeType(object_0, underlyingType);
				Class13.Class24 @class = Class13.Class24.smethod_3(Class13.Class24.smethod_1(underlyingType, obj));
				if (@class != null)
				{
					return @class as Class13.Class25;
				}
			}
			return new Class13.Class36(object_0);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		private static Class13.Class25 smethod_3(Class13.Class24 class24_0)
		{
			Class13.Class25 @class = class24_0 as Class13.Class25;
			if (@class == null && class24_0.vmethod_0())
			{
				@class = class24_0.vmethod_8() as Class13.Class25;
			}
			return @class;
		}

		// Token: 0x040000D8 RID: 216
		internal Class13.Enum5 enum5_0;
	}

	// Token: 0x02000050 RID: 80
	private class Class36 : Class13.Class24
	{
		// Token: 0x060003BD RID: 957 RVA: 0x0000426C File Offset: 0x0000246C
		public Class36()
			: this(null)
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00004275 File Offset: 0x00002475
		internal override void zhnXqoJuKJ(Class13.Class24 class24_1)
		{
			if (!(class24_1 is Class13.Class36))
			{
				this.class24_0 = class24_1.vmethod_8();
				return;
			}
			this.class24_0 = ((Class13.Class36)class24_1).class24_0;
			this.SrZyhCtsk8 = ((Class13.Class36)class24_1).SrZyhCtsk8;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002B4C File Offset: 0x00000D4C
		internal override void vmethod_2(Class13.Class24 class24_1)
		{
			this.zhnXqoJuKJ(class24_1);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000042AE File Offset: 0x000024AE
		public Class36(object object_0)
			: base((Class13.Enum5)0)
		{
			this.class24_0 = object_0;
			this.SrZyhCtsk8 = null;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000042C5 File Offset: 0x000024C5
		public Class36(object object_0, Type type_0)
			: base((Class13.Enum5)0)
		{
			this.class24_0 = object_0;
			this.SrZyhCtsk8 = type_0;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000161E8 File Offset: 0x000143E8
		public override string ToString()
		{
			if (this.class24_0 == null)
			{
				return ((Class13.Enum6)5).ToString();
			}
			return this.class24_0.ToString();
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00016218 File Offset: 0x00014418
		internal override object vmethod_4(Type type_0)
		{
			if (this.class24_0 == null)
			{
				return null;
			}
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (!(this.class24_0 is Class13.Class24))
			{
				object obj = this.class24_0;
				if (obj != null && type_0 != null && obj.GetType() != type_0)
				{
					if (type_0 == typeof(RuntimeFieldHandle) && obj is FieldInfo)
					{
						obj = ((FieldInfo)obj).FieldHandle;
					}
					else if (type_0 == typeof(RuntimeTypeHandle) && obj is Type)
					{
						obj = ((Type)obj).TypeHandle;
					}
					else if (type_0 == typeof(RuntimeMethodHandle) && obj is MethodBase)
					{
						obj = ((MethodBase)obj).MethodHandle;
					}
				}
				return obj;
			}
			if (!(this.SrZyhCtsk8 != null))
			{
				object obj2 = ((Class13.Class24)this.class24_0).vmethod_4(type_0);
				if (obj2 != null && type_0 != null && obj2.GetType() != type_0)
				{
					if (type_0 == typeof(RuntimeFieldHandle) && obj2 is FieldInfo)
					{
						obj2 = ((FieldInfo)obj2).FieldHandle;
					}
					else if (type_0 == typeof(RuntimeTypeHandle) && obj2 is Type)
					{
						obj2 = ((Type)obj2).TypeHandle;
					}
					else if (type_0 == typeof(RuntimeMethodHandle) && obj2 is MethodBase)
					{
						obj2 = ((MethodBase)obj2).MethodHandle;
					}
				}
				return obj2;
			}
			return ((Class13.Class24)this.class24_0).vmethod_4(this.SrZyhCtsk8);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000163EC File Offset: 0x000145EC
		internal override bool vmethod_5(Class13.Class24 class24_1)
		{
			if (class24_1.vmethod_0())
			{
				return ((Class13.Class30)class24_1).vmethod_5(this);
			}
			object obj = this.vmethod_4(null);
			object obj2 = class24_1.vmethod_4(null);
			return obj == obj2;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00016424 File Offset: 0x00014624
		internal override bool vmethod_6(Class13.Class24 class24_1)
		{
			if (!class24_1.vmethod_0())
			{
				object obj = this.vmethod_4(null);
				object obj2 = class24_1.vmethod_4(null);
				return obj != obj2;
			}
			return ((Class13.Class30)class24_1).vmethod_6(this);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0001645C File Offset: 0x0001465C
		internal override Class13.Class24 vmethod_8()
		{
			Class13.Class24 @class = this.class24_0 as Class13.Class24;
			if (@class == null)
			{
				return this;
			}
			return @class.vmethod_8();
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00016480 File Offset: 0x00014680
		internal override bool vmethod_7()
		{
			if (this.class24_0 == null)
			{
				return false;
			}
			if (this.class24_0 is bool)
			{
				return (bool)this.class24_0;
			}
			Class13.Class24 @class = this.class24_0 as Class13.Class24;
			if (@class != null)
			{
				object obj = @class.vmethod_4(null);
				return obj != null && (!(obj is bool) || (bool)obj);
			}
			return true;
		}

		// Token: 0x040000D9 RID: 217
		public Class13.Class24 class24_0;

		// Token: 0x040000DA RID: 218
		public Type SrZyhCtsk8;
	}

	// Token: 0x02000051 RID: 81
	private class Class37 : Class13.Class24
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x000042DC File Offset: 0x000024DC
		public Class37(string string_0)
			: base((Class13.Enum5)6)
		{
			this.IhjyrsHpTu = string_0;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000042EC File Offset: 0x000024EC
		internal override void zhnXqoJuKJ(Class13.Class24 class24_0)
		{
			this.IhjyrsHpTu = ((Class13.Class37)class24_0).IhjyrsHpTu;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002B4C File Offset: 0x00000D4C
		internal override void vmethod_2(Class13.Class24 class24_0)
		{
			this.zhnXqoJuKJ(class24_0);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000164E0 File Offset: 0x000146E0
		public override string ToString()
		{
			if (this.IhjyrsHpTu == null)
			{
				return ((Class13.Enum6)5).ToString();
			}
			string text = "*";
			string ihjyrsHpTu = this.IhjyrsHpTu;
			return text + ((ihjyrsHpTu != null) ? ihjyrsHpTu.ToString() : null) + "*";
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000042FF File Offset: 0x000024FF
		internal override bool vmethod_7()
		{
			return this.IhjyrsHpTu != null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000430A File Offset: 0x0000250A
		internal override object vmethod_4(Type type_0)
		{
			return this.IhjyrsHpTu;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00016528 File Offset: 0x00014728
		internal override bool vmethod_5(Class13.Class24 class24_0)
		{
			if (!class24_0.vmethod_0())
			{
				object ihjyrsHpTu = this.IhjyrsHpTu;
				object obj = class24_0.vmethod_4(null);
				return ihjyrsHpTu == obj;
			}
			return ((Class13.Class30)class24_0).vmethod_5(this);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00016560 File Offset: 0x00014760
		internal override bool vmethod_6(Class13.Class24 class24_0)
		{
			if (!class24_0.vmethod_0())
			{
				object ihjyrsHpTu = this.IhjyrsHpTu;
				object obj = class24_0.vmethod_4(null);
				return ihjyrsHpTu != obj;
			}
			return ((Class13.Class30)class24_0).vmethod_6(this);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002FE1 File Offset: 0x000011E1
		internal override Class13.Class24 vmethod_8()
		{
			return this;
		}

		// Token: 0x040000DB RID: 219
		public string IhjyrsHpTu;
	}

	// Token: 0x02000052 RID: 82
	private class Class38 : Class13.Class24
	{
		// Token: 0x060003D1 RID: 977 RVA: 0x00004312 File Offset: 0x00002512
		public Class38(object object_0, Type type_1)
			: base((Class13.Enum5)8)
		{
			this.class24_0 = object_0;
			this.type_0 = type_1;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00004329 File Offset: 0x00002529
		internal override void zhnXqoJuKJ(Class13.Class24 class24_1)
		{
			if (class24_1 is Class13.Class38)
			{
				this.class24_0 = ((Class13.Class38)class24_1).class24_0;
				this.type_0 = ((Class13.Class38)class24_1).type_0;
				return;
			}
			this.class24_0 = class24_1.vmethod_8();
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002B4C File Offset: 0x00000D4C
		internal override void vmethod_2(Class13.Class24 class24_1)
		{
			this.zhnXqoJuKJ(class24_1);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00016598 File Offset: 0x00014798
		public override string ToString()
		{
			if (this.class24_0 == null)
			{
				return ((Class13.Enum6)5).ToString();
			}
			string text = "*";
			Class13.Class24 @class = this.class24_0;
			return text + ((@class != null) ? @class.ToString() : null) + "*";
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000165E0 File Offset: 0x000147E0
		internal override bool vmethod_7()
		{
			if (this.class24_0 == null)
			{
				return false;
			}
			if (this.class24_0 is bool)
			{
				return (bool)this.class24_0;
			}
			Class13.Class24 @class = this.class24_0 as Class13.Class24;
			if (@class != null)
			{
				object obj = @class.vmethod_4(null);
				return obj != null && (!(obj is bool) || (bool)obj);
			}
			return true;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00016640 File Offset: 0x00014840
		internal override object vmethod_4(Type type_1)
		{
			if (this.class24_0 == null)
			{
				return null;
			}
			if (type_1 != null && type_1.IsByRef)
			{
				type_1 = type_1.GetElementType();
			}
			if (!(this.class24_0 is Class13.Class24))
			{
				object obj = this.class24_0;
				if (obj != null && type_1 != null && obj.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj is FieldInfo)
					{
						obj = ((FieldInfo)obj).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj is Type)
					{
						obj = ((Type)obj).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj is MethodBase)
					{
						obj = ((MethodBase)obj).MethodHandle;
					}
				}
				return obj;
			}
			if (!(this.type_0 != null))
			{
				object obj2 = ((Class13.Class24)this.class24_0).vmethod_4(type_1);
				if (obj2 != null && type_1 != null && obj2.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj2 is FieldInfo)
					{
						obj2 = ((FieldInfo)obj2).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj2 is Type)
					{
						obj2 = ((Type)obj2).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj2 is MethodBase)
					{
						obj2 = ((MethodBase)obj2).MethodHandle;
					}
				}
				return obj2;
			}
			return ((Class13.Class24)this.class24_0).vmethod_4(this.type_0);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00016814 File Offset: 0x00014A14
		internal override bool vmethod_5(Class13.Class24 class24_1)
		{
			if (!class24_1.vmethod_0())
			{
				object obj = this.vmethod_4(null);
				object obj2 = class24_1.vmethod_4(null);
				return obj == obj2;
			}
			return ((Class13.Class30)class24_1).vmethod_5(this);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0001684C File Offset: 0x00014A4C
		internal override bool vmethod_6(Class13.Class24 class24_1)
		{
			if (class24_1.vmethod_0())
			{
				return ((Class13.Class30)class24_1).vmethod_6(this);
			}
			object obj = this.vmethod_4(null);
			object obj2 = class24_1.vmethod_4(null);
			return obj != obj2;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00016888 File Offset: 0x00014A88
		internal override Class13.Class24 vmethod_8()
		{
			Class13.Class24 @class = this.class24_0 as Class13.Class24;
			if (@class == null)
			{
				return this;
			}
			return @class.vmethod_8();
		}

		// Token: 0x040000DC RID: 220
		public Class13.Class24 class24_0;

		// Token: 0x040000DD RID: 221
		public Type type_0;
	}

	// Token: 0x02000053 RID: 83
	private abstract class Class39
	{
		// Token: 0x060003DA RID: 986
		public abstract bool vmethod_0();

		// Token: 0x060003DB RID: 987
		public abstract object vmethod_1();

		// Token: 0x060003DC RID: 988
		public abstract object vmethod_2();

		// Token: 0x060003DD RID: 989
		public abstract object vmethod_3(object object_0);

		// Token: 0x060003DE RID: 990
		public abstract int vmethod_4();

		// Token: 0x060003DF RID: 991
		public abstract void vmethod_5();

		// Token: 0x060003E0 RID: 992
		public abstract void vmethod_6(object object_0);

		// Token: 0x060003E1 RID: 993 RVA: 0x00004362 File Offset: 0x00002562
		internal static Class13.Class39 smethod_0(Type type_0)
		{
			Class13.Class39 @class = (Class13.Class39)Activator.CreateInstance(typeof(Class13.Class40<>).MakeGenericType(new Type[] { type_0 }));
			@class.vmethod_5();
			return @class;
		}
	}

	// Token: 0x02000054 RID: 84
	private class Class40<T> : Class13.Class39 where T : struct
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x0000438D File Offset: 0x0000258D
		public override bool vmethod_0()
		{
			return this.nullable_0 != null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000439A File Offset: 0x0000259A
		public override object vmethod_1()
		{
			return this.nullable_0.Value;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000043AC File Offset: 0x000025AC
		public override object vmethod_2()
		{
			return this.nullable_0.GetValueOrDefault();
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000043BE File Offset: 0x000025BE
		public override object vmethod_3(object object_1)
		{
			return this.nullable_0.GetValueOrDefault((T)((object)object_1));
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000043D6 File Offset: 0x000025D6
		public override int vmethod_4()
		{
			return this.nullable_0.GetHashCode();
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000043E9 File Offset: 0x000025E9
		public override void vmethod_5()
		{
			this.nullable_0 = null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000168AC File Offset: 0x00014AAC
		public override void vmethod_6(object object_1)
		{
			while (object_1 != null)
			{
				int num = 0;
				if (Class13.Class40<T>.smethod_2() != null)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_003E;
					case 3:
						return;
					}
				}
				this.nullable_0 = new T?((T)((object)object_1));
				return;
			}
			IL_003E:
			this.vmethod_5();
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000043FF File Offset: 0x000025FF
		internal static bool smethod_1()
		{
			return Class13.Class40<T>.object_0 == null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00004409 File Offset: 0x00002609
		internal static object smethod_2()
		{
			return Class13.Class40<T>.object_0;
		}

		// Token: 0x040000DE RID: 222
		public T? nullable_0;

		// Token: 0x040000DF RID: 223
		internal static object object_0;
	}

	// Token: 0x02000055 RID: 85
	internal class Class41
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x00004410 File Offset: 0x00002610
		public int method_0()
		{
			return this.list_0.Count;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000441D File Offset: 0x0000261D
		public void method_1()
		{
			this.list_0.Clear();
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000442A File Offset: 0x0000262A
		public void method_2(Class13.Class24 class24_0)
		{
			this.list_0.Add(class24_0);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00004438 File Offset: 0x00002638
		public Class13.Class24 method_3()
		{
			return this.list_0[this.list_0.Count - 1];
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00004452 File Offset: 0x00002652
		public Class13.Class24 method_4()
		{
			Class13.Class24 @class = this.method_3();
			if (this.list_0.Count != 0)
			{
				this.list_0.RemoveAt(this.list_0.Count - 1);
			}
			return @class;
		}

		// Token: 0x040000E0 RID: 224
		private List<Class13.Class24> list_0 = new List<Class13.Class24>();
	}

	// Token: 0x02000056 RID: 86
	private struct Struct7
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x00004492 File Offset: 0x00002692
		public Struct7(int int_0, int int_1)
		{
			this.stringBuilder_0 = new StringBuilder();
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00004492 File Offset: 0x00002692
		public Struct7(int int_0, int int_1, IFormatProvider iformatProvider_0)
		{
			this.stringBuilder_0 = new StringBuilder();
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000449F File Offset: 0x0000269F
		public void method_0(string string_0)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.Append(string_0);
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000044B1 File Offset: 0x000026B1
		public void method_1<T>(T gparam_0)
		{
			if (gparam_0 != null)
			{
				this.stringBuilder_0.Append(gparam_0);
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000044CD File Offset: 0x000026CD
		public void method_2<T>(T gparam_0, string string_0)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.AppendFormat(string_0, gparam_0);
				return;
			}
			this.stringBuilder_0.Append(gparam_0);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000044B1 File Offset: 0x000026B1
		public void method_3<T>(T gparam_0, int int_0)
		{
			if (gparam_0 != null)
			{
				this.stringBuilder_0.Append(gparam_0);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000044F8 File Offset: 0x000026F8
		public void method_4<T>(T gparam_0, int int_0, string string_0)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.AppendFormat(string_0, gparam_0);
				return;
			}
			this.stringBuilder_0.Append(gparam_0);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000449F File Offset: 0x0000269F
		public void method_5(string string_0)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.Append(string_0);
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00004523 File Offset: 0x00002723
		public void method_6(string string_0, int int_0 = 0, string string_1 = null)
		{
			if (string_1 == null)
			{
				this.stringBuilder_0.Append(string_0);
				return;
			}
			this.stringBuilder_0.AppendFormat(string_1, string_0);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00004544 File Offset: 0x00002744
		public void method_7(object object_0, int int_0 = 0, string string_0 = null)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.AppendFormat(string_0, object_0);
				return;
			}
			this.stringBuilder_0.Append(object_0);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00004565 File Offset: 0x00002765
		public string method_8()
		{
			string text = this.stringBuilder_0.ToString();
			this.stringBuilder_0.Clear();
			return text;
		}

		// Token: 0x040000E1 RID: 225
		private StringBuilder stringBuilder_0;
	}

	// Token: 0x02000057 RID: 87
	internal enum Enum6
	{

	}

	// Token: 0x02000058 RID: 88
	[CompilerGenerated]
	[Serializable]
	private sealed class Class42<T>
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x000041E5 File Offset: 0x000023E5
		internal int method_0(Class13.Class17 x, Class13.Class17 y)
		{
			return x.class18_0.int_0.CompareTo(y.class18_0.int_0);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000458A File Offset: 0x0000278A
		internal static bool smethod_0()
		{
			return Class13.Class42<T>.object_0 == null;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00004594 File Offset: 0x00002794
		internal static object smethod_1()
		{
			return Class13.Class42<T>.object_0;
		}

		// Token: 0x040000E3 RID: 227
		public static readonly Class13.Class42<T> <>9 = new Class13.Class42<T>();

		// Token: 0x040000E4 RID: 228
		public static Comparison<Class13.Class17> <>9__50_0;

		// Token: 0x040000E5 RID: 229
		private static object object_0;
	}
}
