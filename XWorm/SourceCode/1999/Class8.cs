using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200001A RID: 26
internal class Class8
{
	// Token: 0x06000080 RID: 128 RVA: 0x0000780C File Offset: 0x00005A0C
	static Class8()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000081 RID: 129 RVA: 0x000022DF File Offset: 0x000004DF
	private void method_0()
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00007988 File Offset: 0x00005B88
	internal static byte[] smethod_0(byte[] byte_2)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - byte_2.Length * 8 % 512 + 512) % 512);
		if (num == 0U)
		{
			num = 512U;
		}
		uint num2 = (uint)((long)byte_2.Length + (long)((ulong)(num / 8U)) + 8L);
		ulong num3 = (ulong)((long)byte_2.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < byte_2.Length; i++)
		{
			array2[i] = byte_2[i];
		}
		byte[] array3 = array2;
		int num4 = byte_2.Length;
		array3[num4] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)((num3 >> (8 - j) * 8) & 255UL);
		}
		uint num5 = (uint)(array2.Length * 8 / 32);
		uint num6 = 1732584193U;
		uint num7 = 4023233417U;
		uint num8 = 2562383102U;
		uint num9 = 271733878U;
		for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0U; num12 < 61U; num12 += 4U)
			{
				array[(int)(num12 >> 2)] = (uint)(((int)array2[(int)(num11 + (num12 + 3U))] << 24) | ((int)array2[(int)(num11 + (num12 + 2U))] << 16) | ((int)array2[(int)(num11 + (num12 + 1U))] << 8) | (int)array2[(int)(num11 + num12)]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			Class8.smethod_1(ref num6, num7, num8, num9, 0U, 7, 1U, array);
			Class8.smethod_1(ref num9, num6, num7, num8, 1U, 12, 2U, array);
			Class8.smethod_1(ref num8, num9, num6, num7, 2U, 17, 3U, array);
			Class8.smethod_1(ref num7, num8, num9, num6, 3U, 22, 4U, array);
			Class8.smethod_1(ref num6, num7, num8, num9, 4U, 7, 5U, array);
			Class8.smethod_1(ref num9, num6, num7, num8, 5U, 12, 6U, array);
			Class8.smethod_1(ref num8, num9, num6, num7, 6U, 17, 7U, array);
			Class8.smethod_1(ref num7, num8, num9, num6, 7U, 22, 8U, array);
			Class8.smethod_1(ref num6, num7, num8, num9, 8U, 7, 9U, array);
			Class8.smethod_1(ref num9, num6, num7, num8, 9U, 12, 10U, array);
			Class8.smethod_1(ref num8, num9, num6, num7, 10U, 17, 11U, array);
			Class8.smethod_1(ref num7, num8, num9, num6, 11U, 22, 12U, array);
			Class8.smethod_1(ref num6, num7, num8, num9, 12U, 7, 13U, array);
			Class8.smethod_1(ref num9, num6, num7, num8, 13U, 12, 14U, array);
			Class8.smethod_1(ref num8, num9, num6, num7, 14U, 17, 15U, array);
			Class8.smethod_1(ref num7, num8, num9, num6, 15U, 22, 16U, array);
			Class8.smethod_2(ref num6, num7, num8, num9, 1U, 5, 17U, array);
			Class8.smethod_2(ref num9, num6, num7, num8, 6U, 9, 18U, array);
			Class8.smethod_2(ref num8, num9, num6, num7, 11U, 14, 19U, array);
			Class8.smethod_2(ref num7, num8, num9, num6, 0U, 20, 20U, array);
			Class8.smethod_2(ref num6, num7, num8, num9, 5U, 5, 21U, array);
			Class8.smethod_2(ref num9, num6, num7, num8, 10U, 9, 22U, array);
			Class8.smethod_2(ref num8, num9, num6, num7, 15U, 14, 23U, array);
			Class8.smethod_2(ref num7, num8, num9, num6, 4U, 20, 24U, array);
			Class8.smethod_2(ref num6, num7, num8, num9, 9U, 5, 25U, array);
			Class8.smethod_2(ref num9, num6, num7, num8, 14U, 9, 26U, array);
			Class8.smethod_2(ref num8, num9, num6, num7, 3U, 14, 27U, array);
			Class8.smethod_2(ref num7, num8, num9, num6, 8U, 20, 28U, array);
			Class8.smethod_2(ref num6, num7, num8, num9, 13U, 5, 29U, array);
			Class8.smethod_2(ref num9, num6, num7, num8, 2U, 9, 30U, array);
			Class8.smethod_2(ref num8, num9, num6, num7, 7U, 14, 31U, array);
			Class8.smethod_2(ref num7, num8, num9, num6, 12U, 20, 32U, array);
			Class8.smethod_3(ref num6, num7, num8, num9, 5U, 4, 33U, array);
			Class8.smethod_3(ref num9, num6, num7, num8, 8U, 11, 34U, array);
			Class8.smethod_3(ref num8, num9, num6, num7, 11U, 16, 35U, array);
			Class8.smethod_3(ref num7, num8, num9, num6, 14U, 23, 36U, array);
			Class8.smethod_3(ref num6, num7, num8, num9, 1U, 4, 37U, array);
			Class8.smethod_3(ref num9, num6, num7, num8, 4U, 11, 38U, array);
			Class8.smethod_3(ref num8, num9, num6, num7, 7U, 16, 39U, array);
			Class8.smethod_3(ref num7, num8, num9, num6, 10U, 23, 40U, array);
			Class8.smethod_3(ref num6, num7, num8, num9, 13U, 4, 41U, array);
			Class8.smethod_3(ref num9, num6, num7, num8, 0U, 11, 42U, array);
			Class8.smethod_3(ref num8, num9, num6, num7, 3U, 16, 43U, array);
			Class8.smethod_3(ref num7, num8, num9, num6, 6U, 23, 44U, array);
			Class8.smethod_3(ref num6, num7, num8, num9, 9U, 4, 45U, array);
			Class8.smethod_3(ref num9, num6, num7, num8, 12U, 11, 46U, array);
			Class8.smethod_3(ref num8, num9, num6, num7, 15U, 16, 47U, array);
			Class8.smethod_3(ref num7, num8, num9, num6, 2U, 23, 48U, array);
			Class8.smethod_4(ref num6, num7, num8, num9, 0U, 6, 49U, array);
			Class8.smethod_4(ref num9, num6, num7, num8, 7U, 10, 50U, array);
			Class8.smethod_4(ref num8, num9, num6, num7, 14U, 15, 51U, array);
			Class8.smethod_4(ref num7, num8, num9, num6, 5U, 21, 52U, array);
			Class8.smethod_4(ref num6, num7, num8, num9, 12U, 6, 53U, array);
			Class8.smethod_4(ref num9, num6, num7, num8, 3U, 10, 54U, array);
			Class8.smethod_4(ref num8, num9, num6, num7, 10U, 15, 55U, array);
			Class8.smethod_4(ref num7, num8, num9, num6, 1U, 21, 56U, array);
			Class8.smethod_4(ref num6, num7, num8, num9, 8U, 6, 57U, array);
			Class8.smethod_4(ref num9, num6, num7, num8, 15U, 10, 58U, array);
			Class8.smethod_4(ref num8, num9, num6, num7, 6U, 15, 59U, array);
			Class8.smethod_4(ref num7, num8, num9, num6, 13U, 21, 60U, array);
			Class8.smethod_4(ref num6, num7, num8, num9, 4U, 6, 61U, array);
			Class8.smethod_4(ref num9, num6, num7, num8, 11U, 10, 62U, array);
			Class8.smethod_4(ref num8, num9, num6, num7, 2U, 15, 63U, array);
			Class8.smethod_4(ref num7, num8, num9, num6, 9U, 21, 64U, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002472 File Offset: 0x00000672
	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class8.smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + uint_7[(int)uint_5] + Class8.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000084 RID: 132 RVA: 0x0000249B File Offset: 0x0000069B
	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class8.smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + uint_7[(int)uint_5] + Class8.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000085 RID: 133 RVA: 0x000024C4 File Offset: 0x000006C4
	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class8.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + uint_7[(int)uint_5] + Class8.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000086 RID: 134 RVA: 0x000024EA File Offset: 0x000006EA
	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class8.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + uint_7[(int)uint_5] + Class8.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002511 File Offset: 0x00000711
	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return (uint_1 >> (int)(32 - ushort_0)) | (uint_1 << (int)ushort_0);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002523 File Offset: 0x00000723
	internal static bool smethod_6()
	{
		if (!Class8.bool_4)
		{
			Class8.smethod_8();
			Class8.bool_4 = true;
		}
		return Class8.bool_5;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002329 File Offset: 0x00000529
	internal Class8()
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00007FE8 File Offset: 0x000061E8
	private void method_1(byte[] byte_2, byte[] byte_3, byte[] byte_4)
	{
		int num = byte_4.Length % 4;
		int num2 = byte_4.Length / 4;
		byte[] array = new byte[byte_4.Length];
		int num3 = byte_2.Length / 4;
		uint num4 = 0U;
		if (num > 0)
		{
			num2++;
		}
		for (int i = 0; i < num2; i++)
		{
			int num5 = i % num3;
			int num6 = i * 4;
			uint num7 = (uint)(num5 * 4);
			uint num8 = (uint)(((int)byte_2[(int)(num7 + 3U)] << 24) | ((int)byte_2[(int)(num7 + 2U)] << 16) | ((int)byte_2[(int)(num7 + 1U)] << 8) | (int)byte_2[(int)num7]);
			uint num9 = 255U;
			int num10 = 0;
			uint num11;
			if (i == num2 - 1 && num > 0)
			{
				num11 = 0U;
				num4 += num8;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num11 <<= 8;
					}
					num11 |= (uint)byte_4[byte_4.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num8;
				num7 = (uint)num6;
				num11 = (uint)(((int)byte_4[(int)(num7 + 3U)] << 24) | ((int)byte_4[(int)(num7 + 2U)] << 16) | ((int)byte_4[(int)(num7 + 1U)] << 8) | (int)byte_4[(int)num7]);
			}
			uint num13;
			uint num12 = (num13 = num4);
			uint num14 = (num13 + num13) ^ 552843558U;
			num13 = 13733868U * (num13 & 255U) + (num13 >> 8);
			num14 = 12729U * num14 + 636998866U;
			uint num15 = (num14 ^ 2002401426U) - 458878875U;
			num13 = 1624505U * (num13 & 1023U) - (num13 >> 10);
			num14 = 9296U * num14 - num15;
			num13 ^= num13 << 3;
			num13 += num13;
			num13 ^= num13 >> 23;
			num13 += num15;
			num13 ^= num13 << 25;
			num13 += 1480803205U;
			num13 = ((3146776576U + num14) ^ num13) + num13;
			num4 = num12 + (uint)num13;
			if (i == num2 - 1 && num > 0)
			{
				uint num16 = num4 ^ num11;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num9 <<= 8;
						num10 += 8;
					}
					array[num6 + k] = (byte)((num16 & num9) >> num10);
				}
			}
			else
			{
				uint num17 = num4 ^ num11;
				array[num6] = (byte)(num17 & 255U);
				array[num6 + 1] = (byte)((num17 & 65280U) >> 8);
				array[num6 + 2] = (byte)((num17 & 16711680U) >> 16);
				array[num6 + 3] = (byte)((num17 & 4278190080U) >> 24);
			}
		}
		Class8.byte_0 = array;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00008258 File Offset: 0x00006458
	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (Class8.smethod_6())
		{
			symmetricAlgorithm = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				symmetricAlgorithm = new RijndaelManaged();
			}
			catch
			{
				try
				{
					symmetricAlgorithm = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
				catch
				{
					symmetricAlgorithm = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
		}
		return symmetricAlgorithm;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000082D8 File Offset: 0x000064D8
	internal static void smethod_8()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			Class8.bool_5 = true;
			return;
		}
		try
		{
			Class8.bool_5 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0000253C File Offset: 0x0000073C
	internal static byte[] smethod_9(byte[] byte_2)
	{
		if (!Class8.smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_2);
		}
		return Class8.smethod_0(byte_2);
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00008324 File Offset: 0x00006524
	internal static void smethod_10(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_2)
	{
		while (uint_1 > 0U)
		{
			int num = ((uint_1 > (uint)byte_2.Length) ? byte_2.Length : ((int)uint_1));
			stream_0.Read(byte_2, 0, num);
			Class8.smethod_11(hashAlgorithm_0, byte_2, 0, num);
			uint_1 -= (uint)num;
		}
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002557 File Offset: 0x00000757
	internal static void smethod_11(HashAlgorithm hashAlgorithm_0, byte[] byte_2, int int_6, int int_7)
	{
		hashAlgorithm_0.TransformBlock(byte_2, int_6, int_7, byte_2, int_6);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00008360 File Offset: 0x00006560
	internal static uint smethod_12(uint uint_1, int int_6, long long_2, BinaryReader binaryReader_0)
	{
		for (int i = 0; i < int_6; i++)
		{
			binaryReader_0.BaseStream.Position = long_2 + (long)(i * 40 + 8);
			uint num = binaryReader_0.ReadUInt32();
			uint num2 = binaryReader_0.ReadUInt32();
			binaryReader_0.ReadUInt32();
			uint num3 = binaryReader_0.ReadUInt32();
			if (num2 <= uint_1 && uint_1 < num2 + num)
			{
				return num3 + uint_1 - num2;
			}
		}
		return 0U;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x000083BC File Offset: 0x000065BC
	private static void smethod_13(Stream stream_0, int int_6)
	{
		Class13.smethod_2(0, new object[] { stream_0, int_6 }, null);
	}

	// Token: 0x06000092 RID: 146 RVA: 0x000083FC File Offset: 0x000065FC
	internal static string smethod_14(string string_1)
	{
		"ombumFiALBeWwVuZ9x".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x06000093 RID: 147 RVA: 0x0000842C File Offset: 0x0000662C
	internal static uint smethod_15(IntPtr intptr_4, IntPtr intptr_5, IntPtr intptr_6, [MarshalAs(UnmanagedType.U4)] uint uint_1, IntPtr intptr_7, ref uint uint_2)
	{
		IntPtr intPtr = intptr_6;
		if (Class8.bool_1)
		{
			intPtr = intptr_5;
		}
		long num;
		if (IntPtr.Size == 4)
		{
			num = (long)Marshal.ReadInt32(intPtr, IntPtr.Size * 2);
		}
		else
		{
			num = Marshal.ReadInt64(intPtr, IntPtr.Size * 2);
		}
		object obj = Class8.hashtable_0[num];
		if (obj == null)
		{
			return Class8.delegate4_1(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
		}
		Class8.Struct4 @struct = (Class8.Struct4)obj;
		IntPtr intPtr2 = Marshal.AllocCoTaskMem(@struct.byte_0.Length);
		Marshal.Copy(@struct.byte_0, 0, intPtr2, @struct.byte_0.Length);
		if (@struct.bool_0)
		{
			intptr_7 = intPtr2;
			uint_2 = (uint)@struct.byte_0.Length;
			Class8.smethod_24(intptr_7, @struct.byte_0.Length, 64, ref Class8.int_4);
			return 0U;
		}
		Marshal.WriteIntPtr(intPtr, IntPtr.Size * 2, intPtr2);
		Marshal.WriteInt32(intPtr, IntPtr.Size * 3, @struct.byte_0.Length);
		uint num2 = 0U;
		if (uint_1 == 216669565U && !Class8.bool_6)
		{
			Class8.bool_6 = true;
		}
		else
		{
			num2 = Class8.delegate4_1(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
			Marshal.WriteIntPtr(intPtr, IntPtr.Size * 2, IntPtr.Zero);
		}
		return num2;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002565 File Offset: 0x00000765
	private static int smethod_16()
	{
		return 5;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00008564 File Offset: 0x00006764
	private static void smethod_17()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000858C File Offset: 0x0000678C
	private static Delegate smethod_18(IntPtr intptr_4, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[] { intptr_4, type_0 });
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000085EC File Offset: 0x000067EC
	internal unsafe static void smethod_19()
	{
		if (!Class8.bool_2)
		{
			Class8.bool_2 = true;
			long num = 0L;
			Marshal.ReadIntPtr(new IntPtr((void*)(&num)), 0);
			Marshal.ReadInt32(new IntPtr((void*)(&num)), 0);
			Marshal.ReadInt64(new IntPtr((void*)(&num)), 0);
			Marshal.WriteIntPtr(new IntPtr((void*)(&num)), 0, IntPtr.Zero);
			Marshal.WriteInt32(new IntPtr((void*)(&num)), 0, 0);
			Marshal.WriteInt64(new IntPtr((void*)(&num)), 0, 0L);
			Marshal.Copy(new byte[1], 0, Marshal.AllocCoTaskMem(8), 1);
			Class8.smethod_17();
			if (IntPtr.Size == 4 && Type.GetType("System.Reflection.ReflectionContext", false) != null)
			{
				foreach (object obj in Process.GetCurrentProcess().Modules)
				{
					ProcessModule processModule = (ProcessModule)obj;
					if (processModule.ModuleName.ToLower() == "clrjit.dll")
					{
						Version version = new Version(processModule.FileVersionInfo.ProductMajorPart, processModule.FileVersionInfo.ProductMinorPart, processModule.FileVersionInfo.ProductBuildPart, processModule.FileVersionInfo.ProductPrivatePart);
						Version version2 = new Version(4, 0, 30319, 17020);
						Version version3 = new Version(4, 0, 30319, 17921);
						if (version >= version2 && version < version3)
						{
							Class8.bool_1 = true;
							break;
						}
					}
				}
			}
			Class8.Class11 @class = new Class8.Class11(Class8.assembly_0.GetManifestResourceStream("CJBlqO7GuJsNbaONa2.a0EBvAsE6ZfyFBggRI"));
			@class.method_0().Position = 0L;
			byte[] array = @class.method_1((int)@class.method_0().Length);
			byte[] array2 = new byte[32];
			array2[0] = 134;
			array2[0] = 110;
			array2[0] = 248;
			array2[1] = 105;
			array2[1] = 116;
			array2[1] = 173;
			array2[1] = 162;
			array2[1] = 55;
			array2[1] = 156;
			array2[2] = 163;
			array2[2] = 122;
			array2[2] = 206;
			array2[3] = 122;
			array2[3] = 192;
			array2[3] = 96;
			array2[3] = 213;
			array2[4] = 98;
			array2[4] = 98;
			array2[4] = 140;
			array2[4] = 32;
			array2[5] = 117;
			array2[5] = 128;
			array2[5] = 206;
			array2[6] = 102;
			array2[6] = 142;
			array2[6] = 8;
			array2[7] = 157;
			array2[7] = 60;
			array2[7] = 158;
			array2[7] = 144;
			array2[8] = 141;
			array2[8] = 220;
			array2[8] = 22;
			array2[9] = 84;
			array2[9] = 118;
			array2[9] = 137;
			array2[9] = 143;
			array2[9] = 43;
			array2[10] = 161;
			array2[10] = 83;
			array2[10] = 120;
			array2[10] = 89;
			array2[10] = 89;
			array2[10] = 152;
			array2[11] = 78;
			array2[11] = 122;
			array2[11] = 98;
			array2[11] = 242;
			array2[12] = 150;
			array2[12] = 148;
			array2[12] = 128;
			array2[12] = 154;
			array2[12] = 72;
			array2[13] = 160;
			array2[13] = 151;
			array2[13] = 146;
			array2[13] = 85;
			array2[14] = 122;
			array2[14] = 130;
			array2[14] = 130;
			array2[14] = 156;
			array2[15] = 133;
			array2[15] = 104;
			array2[15] = 114;
			array2[15] = 169;
			array2[15] = 49;
			array2[16] = 119;
			array2[16] = 156;
			array2[16] = 83;
			array2[16] = 125;
			array2[16] = 90;
			array2[16] = 187;
			array2[17] = 65;
			array2[17] = 189;
			array2[17] = 197;
			array2[17] = 97;
			array2[18] = 147;
			array2[18] = 138;
			array2[18] = 31;
			array2[18] = 95;
			array2[18] = 164;
			array2[19] = 89;
			array2[19] = 161;
			array2[19] = 166;
			array2[19] = 162;
			array2[19] = 203;
			array2[20] = 149;
			array2[20] = 138;
			array2[20] = 220;
			array2[21] = 55;
			array2[21] = 123;
			array2[21] = 161;
			array2[21] = 182;
			array2[21] = 157;
			array2[22] = 101;
			array2[22] = 158;
			array2[22] = 17;
			array2[23] = 88;
			array2[23] = 40;
			array2[23] = 55;
			array2[23] = 119;
			array2[24] = 93;
			array2[24] = 121;
			array2[24] = 193;
			array2[25] = 105;
			array2[25] = 51;
			array2[25] = 110;
			array2[26] = 127;
			array2[26] = 157;
			array2[26] = 162;
			array2[27] = 103;
			array2[27] = 156;
			array2[27] = 50;
			array2[27] = 132;
			array2[28] = 62;
			array2[28] = 131;
			array2[28] = 160;
			array2[28] = 89;
			array2[28] = 81;
			array2[29] = 130;
			array2[29] = 128;
			array2[29] = 148;
			array2[29] = 49;
			array2[30] = 174;
			array2[30] = 146;
			array2[30] = 128;
			array2[30] = 207;
			array2[31] = 110;
			array2[31] = 78;
			array2[31] = 233;
			array2[31] = 186;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 50;
			array4[0] = 118;
			array4[0] = 88;
			array4[0] = 91;
			array4[0] = 166;
			array4[0] = 140;
			array4[1] = 127;
			array4[1] = 146;
			array4[1] = 162;
			array4[1] = 136;
			array4[1] = 209;
			array4[1] = 210;
			array4[2] = 77;
			array4[2] = 161;
			array4[2] = 172;
			array4[2] = 90;
			array4[2] = 159;
			array4[2] = 184;
			array4[3] = 155;
			array4[3] = 100;
			array4[3] = 109;
			array4[3] = 175;
			array4[3] = 191;
			array4[4] = 168;
			array4[4] = 163;
			array4[4] = 72;
			array4[5] = 163;
			array4[5] = 202;
			array4[5] = 109;
			array4[5] = 100;
			array4[5] = 106;
			array4[6] = 173;
			array4[6] = 123;
			array4[6] = 17;
			array4[6] = 124;
			array4[6] = 117;
			array4[6] = 63;
			array4[7] = 136;
			array4[7] = 121;
			array4[7] = 109;
			array4[8] = 192;
			array4[8] = 145;
			array4[8] = 96;
			array4[8] = 87;
			array4[9] = 160;
			array4[9] = 140;
			array4[9] = 207;
			array4[9] = 99;
			array4[9] = 145;
			array4[10] = 50;
			array4[10] = 124;
			array4[10] = 92;
			array4[10] = 178;
			array4[10] = 142;
			array4[10] = 23;
			array4[11] = 144;
			array4[11] = 160;
			array4[11] = 171;
			array4[11] = 209;
			array4[11] = 9;
			array4[12] = 136;
			array4[12] = 197;
			array4[12] = 164;
			array4[12] = 113;
			array4[12] = 86;
			array4[12] = 227;
			array4[13] = 105;
			array4[13] = 106;
			array4[13] = 238;
			array4[14] = 135;
			array4[14] = 168;
			array4[14] = 90;
			array4[15] = 134;
			array4[15] = 154;
			array4[15] = 74;
			array4[15] = 97;
			array4[15] = 101;
			array4[15] = 201;
			byte[] array5 = array4;
			Array.Reverse(array5);
			byte[] publicKeyToken = Class8.assembly_0.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length != 0)
			{
				array5[1] = publicKeyToken[0];
				array5[3] = publicKeyToken[1];
				array5[5] = publicKeyToken[2];
				array5[7] = publicKeyToken[3];
				array5[9] = publicKeyToken[4];
				array5[11] = publicKeyToken[5];
				array5[13] = publicKeyToken[6];
				array5[15] = publicKeyToken[7];
				Array.Clear(publicKeyToken, 0, publicKeyToken.Length);
			}
			for (int i = 0; i < array5.Length; i++)
			{
				array3[i] ^= array5[i];
			}
			byte[] array6 = array;
			int num2 = array6.Length % 4;
			int num3 = array6.Length / 4;
			byte[] array7 = new byte[array6.Length];
			int num4 = array3.Length / 4;
			uint num5 = 0U;
			if (num2 > 0)
			{
				num3++;
			}
			for (int j = 0; j < num3; j++)
			{
				int num6 = j % num4;
				int num7 = j * 4;
				uint num8 = (uint)(num6 * 4);
				uint num9 = (uint)(((int)array3[(int)(num8 + 3U)] << 24) | ((int)array3[(int)(num8 + 2U)] << 16) | ((int)array3[(int)(num8 + 1U)] << 8) | (int)array3[(int)num8]);
				uint num10 = 255U;
				int num11 = 0;
				uint num12;
				if (j == num3 - 1 && num2 > 0)
				{
					num5 += num9;
					num12 = 0U;
					for (int k = 0; k < num2; k++)
					{
						if (k > 0)
						{
							num12 <<= 8;
						}
						num12 |= (uint)array6[array6.Length - (1 + k)];
					}
				}
				else
				{
					num8 = (uint)num7;
					num5 += num9;
					num12 = (uint)(((int)array6[(int)(num8 + 3U)] << 24) | ((int)array6[(int)(num8 + 2U)] << 16) | ((int)array6[(int)(num8 + 1U)] << 8) | (int)array6[(int)num8]);
				}
				num5 = num5;
				uint num13 = num5;
				uint num14 = num5;
				uint num15 = (num14 + num14) ^ 552843558U;
				num14 = 13733868U * (num14 & 255U) + (num14 >> 8);
				num15 = 12729U * num15 + 636998866U;
				uint num16 = (num15 ^ 2002401426U) - 458878875U;
				num14 = 1624505U * (num14 & 1023U) - (num14 >> 10);
				num15 = 9296U * num15 - num16;
				num14 ^= num14 << 3;
				num14 += num14;
				num14 ^= num14 >> 23;
				num14 += num16;
				num14 ^= num14 << 25;
				num14 += 1480803205U;
				num14 = ((3146776576U + num15) ^ num14) + num14;
				num5 = num13 + (uint)num14;
				if (j == num3 - 1 && num2 > 0)
				{
					uint num17 = num5 ^ num12;
					for (int l = 0; l < num2; l++)
					{
						if (l > 0)
						{
							num10 <<= 8;
							num11 += 8;
						}
						array7[num7 + l] = (byte)((num17 & num10) >> num11);
					}
				}
				else
				{
					uint num18 = num5 ^ num12;
					array7[num7] = (byte)(num18 & 255U);
					array7[num7 + 1] = (byte)((num18 & 65280U) >> 8);
					array7[num7 + 2] = (byte)((num18 & 16711680U) >> 16);
					array7[num7 + 3] = (byte)((num18 & 4278190080U) >> 24);
				}
			}
			byte[] array8 = array7;
			int num19 = array8.Length / 8;
			byte[] array9;
			byte* ptr;
			if ((array9 = array8) != null && array9.Length != 0)
			{
				ptr = &array9[0];
			}
			else
			{
				ptr = null;
			}
			for (int m = 0; m < num19; m++)
			{
				*(long*)(ptr + m * 8) ^= 1351379670L;
			}
			array9 = null;
			@class = new Class8.Class11(new MemoryStream(array8));
			@class.method_0().Position = 0L;
			long num20 = Marshal.GetHINSTANCE(Class8.assembly_0.GetModules()[0]).ToInt64();
			int num21 = 0;
			int num22 = 0;
			if (Class8.assembly_0.Location == null || Class8.assembly_0.Location.Length == 0)
			{
				num22 = 7680;
			}
			@class.method_3();
			@class.method_3();
			@class.method_3();
			@class.method_3();
			int num23 = @class.method_3();
			int num24 = @class.method_3();
			if (num24 == 4)
			{
				SymmetricAlgorithm symmetricAlgorithm = Class8.smethod_7();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform cryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5);
				Array.Clear(array3, 0, array3.Length);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				array8 = memoryStream.ToArray();
				Array.Clear(array5, 0, array5.Length);
				memoryStream.Close();
				cryptoStream.Close();
				@class.method_4();
				num23 = @class.method_3();
				num24 = @class.method_3();
			}
			if (num24 == 1)
			{
				IntPtr intPtr = IntPtr.Zero;
				intPtr = Class8.smethod_25(56U, 1, (uint)Process.GetCurrentProcess().Id);
				if (IntPtr.Size == 4)
				{
					Class8.int_1 = Marshal.GetHINSTANCE(Class8.assembly_0.GetModules()[0]).ToInt32();
				}
				Class8.long_0 = Marshal.GetHINSTANCE(Class8.assembly_0.GetModules()[0]).ToInt64();
				IntPtr zero = IntPtr.Zero;
				for (int n = 0; n < num23; n++)
				{
					IntPtr intPtr2 = new IntPtr(Class8.long_0 + (long)@class.method_3() - (long)num22);
					if (Class8.smethod_24(intPtr2, 4, 4, ref num21) == 0)
					{
						Class8.smethod_24(intPtr2, 4, 8, ref num21);
					}
					if (IntPtr.Size == 4)
					{
						Class8.smethod_23(intPtr, intPtr2, BitConverter.GetBytes(@class.method_3()), 4U, out zero);
					}
					else
					{
						Class8.smethod_23(intPtr, intPtr2, BitConverter.GetBytes(@class.method_3()), 4U, out zero);
					}
					Class8.smethod_24(intPtr2, 4, num21, ref num21);
				}
				while (@class.method_0().Position < @class.method_0().Length - 1L)
				{
					int num25 = @class.method_3();
					IntPtr intPtr3 = new IntPtr(Class8.long_0 + (long)num25 - (long)num22);
					int num26 = @class.method_3();
					if (Class8.smethod_24(intPtr3, num26 * 4, 4, ref num21) == 0)
					{
						Class8.smethod_24(intPtr3, num26 * 4, 8, ref num21);
					}
					for (int num27 = 0; num27 < num26; num27++)
					{
						Marshal.WriteInt32(new IntPtr(intPtr3.ToInt64() + (long)(num27 * 4)), @class.method_3());
					}
					Class8.smethod_24(intPtr3, num26 * 4, num21, ref num21);
				}
				Class8.smethod_26(intPtr);
				return;
			}
			for (int num28 = 0; num28 < num23; num28++)
			{
				IntPtr intPtr4 = new IntPtr(num20 + (long)@class.method_3() - (long)num22);
				if (Class8.smethod_24(intPtr4, 4, 4, ref num21) == 0)
				{
					Class8.smethod_24(intPtr4, 4, 8, ref num21);
				}
				Marshal.WriteInt32(intPtr4, @class.method_3());
				Class8.smethod_24(intPtr4, 4, num21, ref num21);
			}
			Class8.hashtable_0 = new Hashtable(@class.method_3() + 1);
			Class8.Struct4 @struct = default(Class8.Struct4);
			@struct.byte_0 = new byte[] { 42 };
			@struct.bool_0 = false;
			Class8.hashtable_0.Add(0L, @struct);
			while (@class.method_0().Position < @class.method_0().Length - 1L)
			{
				int num29 = @class.method_3() - num22;
				int num30 = @class.method_3();
				bool flag = false;
				if (num30 >= 1879048192)
				{
					flag = true;
				}
				int num31 = @class.method_3();
				byte[] array10 = @class.method_1(num31);
				Class8.Struct4 struct2 = default(Class8.Struct4);
				struct2.byte_0 = array10;
				struct2.bool_0 = flag;
				Class8.hashtable_0.Add(num20 + (long)num29, struct2);
			}
			Class8.long_1 = Marshal.GetHINSTANCE(typeof(Class8).Assembly.GetModules()[0]).ToInt64();
			if (IntPtr.Size == 4)
			{
				Class8.int_5 = Convert.ToInt32(Class8.long_1);
			}
			byte[] array11 = new byte[]
			{
				109, 115, 99, 111, 114, 106, 105, 116, 46, 100,
				108, 108
			};
			string text = Encoding.UTF8.GetString(array11);
			IntPtr intPtr5 = IntPtr.Zero;
			if (intPtr5 == IntPtr.Zero)
			{
				array11 = new byte[] { 99, 108, 114, 106, 105, 116, 46, 100, 108, 108 };
				text = Encoding.UTF8.GetString(array11);
				intPtr5 = Class8.LoadLibrary(text);
			}
			byte[] array12 = new byte[] { 103, 101, 116, 74, 105, 116 };
			string @string = Encoding.UTF8.GetString(array12);
			IntPtr intPtr6 = ((Class8.Delegate5)Class8.smethod_18(Class8.GetProcAddress(intPtr5, @string), typeof(Class8.Delegate5)))();
			long num32 = 0L;
			if (IntPtr.Size == 4)
			{
				num32 = (long)Marshal.ReadInt32(intPtr6);
			}
			else
			{
				num32 = Marshal.ReadInt64(intPtr6);
			}
			Marshal.ReadIntPtr(intPtr6, 0);
			Class8.delegate4_0 = new Class8.Delegate4(Class8.smethod_15);
			IntPtr intPtr7 = IntPtr.Zero;
			intPtr7 = Marshal.GetFunctionPointerForDelegate(Class8.delegate4_0);
			long num33 = 0L;
			if (IntPtr.Size == 4)
			{
				num33 = (long)Marshal.ReadInt32(new IntPtr(num32));
			}
			else
			{
				num33 = Marshal.ReadInt64(new IntPtr(num32));
			}
			Process currentProcess = Process.GetCurrentProcess();
			try
			{
				foreach (object obj2 in currentProcess.Modules)
				{
					ProcessModule processModule2 = (ProcessModule)obj2;
					if (processModule2.ModuleName == text && (num33 < processModule2.BaseAddress.ToInt64() || num33 > processModule2.BaseAddress.ToInt64() + (long)processModule2.ModuleMemorySize) && typeof(Class8).Assembly.EntryPoint != null)
					{
						return;
					}
				}
			}
			catch
			{
			}
			try
			{
				using (IEnumerator enumerator = currentProcess.Modules.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((ProcessModule)enumerator.Current).BaseAddress.ToInt64() == Class8.long_1)
						{
							break;
						}
					}
				}
			}
			catch
			{
			}
			Class8.delegate4_1 = null;
			try
			{
				Class8.delegate4_1 = (Class8.Delegate4)Class8.smethod_18(new IntPtr(num33), typeof(Class8.Delegate4));
			}
			catch
			{
				try
				{
					Delegate @delegate = Class8.smethod_18(new IntPtr(num33), typeof(Class8.Delegate4));
					Class8.delegate4_1 = (Class8.Delegate4)Delegate.CreateDelegate(typeof(Class8.Delegate4), @delegate.Method);
				}
				catch
				{
				}
			}
			int num34 = 0;
			if (typeof(Class8).Assembly.EntryPoint != null && typeof(Class8).Assembly.EntryPoint.GetParameters().Length == 2 && typeof(Class8).Assembly.Location != null && typeof(Class8).Assembly.Location.Length > 0)
			{
				return;
			}
			try
			{
				object value = typeof(Class8).Assembly.ManifestModule.ModuleHandle.GetType().GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(typeof(Class8).Assembly.ManifestModule.ModuleHandle);
				if (value is IntPtr)
				{
					Class8.intptr_1 = (IntPtr)value;
				}
				if (value.GetType().ToString() == "System.Reflection.RuntimeModule")
				{
					Class8.intptr_1 = (IntPtr)value.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(value);
				}
				MemoryStream memoryStream2 = new MemoryStream();
				memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				if (IntPtr.Size == 4)
				{
					memoryStream2.Write(BitConverter.GetBytes(Class8.intptr_1.ToInt32()), 0, 4);
				}
				else
				{
					memoryStream2.Write(BitConverter.GetBytes(Class8.intptr_1.ToInt64()), 0, 8);
				}
				memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				memoryStream2.Position = 0L;
				byte[] array13 = memoryStream2.ToArray();
				memoryStream2.Close();
				uint num35 = 0U;
				try
				{
					byte* ptr2;
					if ((array9 = array13) != null && array9.Length != 0)
					{
						ptr2 = &array9[0];
					}
					else
					{
						ptr2 = null;
					}
					Class8.delegate4_0(new IntPtr((void*)ptr2), new IntPtr((void*)ptr2), new IntPtr((void*)ptr2), 216669565U, new IntPtr((void*)ptr2), ref num35);
				}
				finally
				{
					array9 = null;
				}
			}
			catch
			{
			}
			RuntimeHelpers.PrepareDelegate(Class8.delegate4_1);
			RuntimeHelpers.PrepareMethod(Class8.delegate4_1.Method.MethodHandle);
			RuntimeHelpers.PrepareDelegate(Class8.delegate4_0);
			RuntimeHelpers.PrepareMethod(Class8.delegate4_0.Method.MethodHandle);
			byte[] array14;
			if (IntPtr.Size != 4)
			{
				array14 = new byte[]
				{
					72, 184, 0, 0, 0, 0, 0, 0, 0, 0,
					73, 57, 64, 8, 116, 12, 72, 184, 0, 0,
					0, 0, 0, 0, 0, 0, byte.MaxValue, 224, 72, 184,
					0, 0, 0, 0, 0, 0, 0, 0, byte.MaxValue, 224
				};
			}
			else
			{
				array14 = new byte[]
				{
					85, 139, 236, 139, 69, 16, 129, 120, 4, 125,
					29, 234, 12, 116, 7, 184, 182, 177, 74, 6,
					235, 5, 184, 182, 146, 64, 12, 93, byte.MaxValue, 224
				};
			}
			IntPtr intPtr8 = Class8.smethod_22(IntPtr.Zero, (uint)array14.Length, 4096U, 64U);
			byte[] array15 = array14;
			byte[] array16;
			byte[] array17;
			byte[] array18;
			if (IntPtr.Size == 4)
			{
				array16 = BitConverter.GetBytes(Class8.intptr_1.ToInt32());
				array17 = BitConverter.GetBytes(intPtr7.ToInt32());
				array18 = BitConverter.GetBytes(Convert.ToInt32(num33));
			}
			else
			{
				array16 = BitConverter.GetBytes(Class8.intptr_1.ToInt64());
				array17 = BitConverter.GetBytes(intPtr7.ToInt64());
				array18 = BitConverter.GetBytes(num33);
			}
			if (IntPtr.Size == 4)
			{
				array15[9] = array16[0];
				array15[10] = array16[1];
				array15[11] = array16[2];
				array15[12] = array16[3];
				array15[16] = array18[0];
				array15[17] = array18[1];
				array15[18] = array18[2];
				array15[19] = array18[3];
				array15[23] = array17[0];
				array15[24] = array17[1];
				array15[25] = array17[2];
				array15[26] = array17[3];
			}
			else
			{
				array15[2] = array16[0];
				array15[3] = array16[1];
				array15[4] = array16[2];
				array15[5] = array16[3];
				array15[6] = array16[4];
				array15[7] = array16[5];
				array15[8] = array16[6];
				array15[9] = array16[7];
				array15[18] = array18[0];
				array15[19] = array18[1];
				array15[20] = array18[2];
				array15[21] = array18[3];
				array15[22] = array18[4];
				array15[23] = array18[5];
				array15[24] = array18[6];
				array15[25] = array18[7];
				array15[30] = array17[0];
				array15[31] = array17[1];
				array15[32] = array17[2];
				array15[33] = array17[3];
				array15[34] = array17[4];
				array15[35] = array17[5];
				array15[36] = array17[6];
				array15[37] = array17[7];
			}
			Marshal.Copy(array15, 0, intPtr8, array15.Length);
			Class8.bool_0 = false;
			Class8.smethod_24(new IntPtr(num32), IntPtr.Size, 64, ref num34);
			Marshal.WriteIntPtr(new IntPtr(num32), intPtr8);
			Class8.smethod_24(new IntPtr(num32), IntPtr.Size, num34, ref num34);
		}
	}

	// Token: 0x06000098 RID: 152 RVA: 0x0000A1CC File Offset: 0x000083CC
	internal static object smethod_20(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(((Assembly)assembly_1).Location))
			{
				return ((Assembly)assembly_1).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0])
				.ToString()))
			{
				return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x06000099 RID: 153
	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_1);

	// Token: 0x0600009A RID: 154
	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_4, string string_1);

	// Token: 0x0600009B RID: 155 RVA: 0x0000A2DC File Offset: 0x000084DC
	private static IntPtr smethod_21(IntPtr intptr_4, string string_1, uint uint_1)
	{
		if (Class8.delegate6_0 == null)
		{
			Class8.delegate6_0 = (Class8.Delegate6)Marshal.GetDelegateForFunctionPointer(Class8.GetProcAddress(Class8.smethod_27(), "Find ".Trim() + "ResourceA"), typeof(Class8.Delegate6));
		}
		return Class8.delegate6_0(intptr_4, string_1, uint_1);
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000A334 File Offset: 0x00008534
	private static IntPtr smethod_22(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		if (Class8.delegate7_0 == null)
		{
			Class8.delegate7_0 = (Class8.Delegate7)Marshal.GetDelegateForFunctionPointer(Class8.GetProcAddress(Class8.smethod_27(), "Virtual ".Trim() + "Alloc"), typeof(Class8.Delegate7));
		}
		return Class8.delegate7_0(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x0600009D RID: 157 RVA: 0x0000A390 File Offset: 0x00008590
	private static int smethod_23(IntPtr intptr_4, IntPtr intptr_5, [In] [Out] byte[] byte_2, uint uint_1, out IntPtr intptr_6)
	{
		if (Class8.delegate8_0 == null)
		{
			Class8.delegate8_0 = (Class8.Delegate8)Marshal.GetDelegateForFunctionPointer(Class8.GetProcAddress(Class8.smethod_27(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Class8.Delegate8));
		}
		return Class8.delegate8_0(intptr_4, intptr_5, byte_2, uint_1, out intptr_6);
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0000A3F8 File Offset: 0x000085F8
	private static int smethod_24(IntPtr intptr_4, int int_6, int int_7, ref int int_8)
	{
		if (Class8.delegate9_0 == null)
		{
			Class8.delegate9_0 = (Class8.Delegate9)Marshal.GetDelegateForFunctionPointer(Class8.GetProcAddress(Class8.smethod_27(), "Virtual ".Trim() + "Protect"), typeof(Class8.Delegate9));
		}
		return Class8.delegate9_0(intptr_4, int_6, int_7, ref int_8);
	}

	// Token: 0x0600009F RID: 159 RVA: 0x0000A454 File Offset: 0x00008654
	private static IntPtr smethod_25(uint uint_1, int int_6, uint uint_2)
	{
		if (Class8.delegate10_0 == null)
		{
			Class8.delegate10_0 = (Class8.Delegate10)Marshal.GetDelegateForFunctionPointer(Class8.GetProcAddress(Class8.smethod_27(), "Open ".Trim() + "Process"), typeof(Class8.Delegate10));
		}
		return Class8.delegate10_0(uint_1, int_6, uint_2);
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x0000A4AC File Offset: 0x000086AC
	private static int smethod_26(IntPtr intptr_4)
	{
		if (Class8.delegate11_0 == null)
		{
			Class8.delegate11_0 = (Class8.Delegate11)Marshal.GetDelegateForFunctionPointer(Class8.GetProcAddress(Class8.smethod_27(), "Close ".Trim() + "Handle"), typeof(Class8.Delegate11));
		}
		return Class8.delegate11_0(intptr_4);
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00002568 File Offset: 0x00000768
	private static IntPtr smethod_27()
	{
		if (Class8.intptr_0 == IntPtr.Zero)
		{
			Class8.intptr_0 = Class8.LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return Class8.intptr_0;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x0000A504 File Offset: 0x00008704
	private static byte[] smethod_28(string string_1)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			int i = (int)fileStream.Length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0000259E File Offset: 0x0000079E
	internal static byte[] smethod_29(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x0000A564 File Offset: 0x00008764
	private static byte[] smethod_30(byte[] byte_2)
	{
		Stream stream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = Class8.smethod_7();
		symmetricAlgorithm.Key = new byte[]
		{
			22, 89, 76, 81, 252, 212, 59, 148, 23, 77,
			150, 128, 35, 87, 185, 241, 207, 140, 57, 104,
			205, 116, 120, 21, 145, 22, 57, 182, 212, 147,
			209, 245
		};
		symmetricAlgorithm.IV = new byte[]
		{
			213, 90, 148, 26, 90, 250, 152, 104, 239, 8,
			36, 162, 177, 7, 21, 120
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_2, 0, byte_2.Length);
		cryptoStream.Close();
		return Class8.smethod_29(stream);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x000025AB File Offset: 0x000007AB
	private byte[] method_2()
	{
		return null;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x000025AB File Offset: 0x000007AB
	private byte[] method_3()
	{
		return null;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x000025AB File Offset: 0x000007AB
	private byte[] method_4()
	{
		return null;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x000025AB File Offset: 0x000007AB
	private byte[] method_5()
	{
		return null;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x000025AB File Offset: 0x000007AB
	private byte[] method_6()
	{
		return null;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x000025AB File Offset: 0x000007AB
	private byte[] method_7()
	{
		return null;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x000025AE File Offset: 0x000007AE
	internal byte[] method_8()
	{
		int length = "M5Uxb9ENT4ql3YBV".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x060000AC RID: 172 RVA: 0x000025C9 File Offset: 0x000007C9
	internal byte[] method_9()
	{
		int length = "9I5uMIK7ahX1ZpsINwjk9".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x060000AD RID: 173 RVA: 0x000025AB File Offset: 0x000007AB
	internal byte[] method_10()
	{
		return null;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x000025AB File Offset: 0x000007AB
	internal byte[] ayExxfFjMA()
	{
		return null;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x000025E4 File Offset: 0x000007E4
	internal static object smethod_31(Class8.Class11 class11_0)
	{
		return class11_0.method_0();
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x000025EF File Offset: 0x000007EF
	internal static void smethod_32(Stream stream_0, long long_2)
	{
		stream_0.Position = long_2;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x000025FE File Offset: 0x000007FE
	internal static long smethod_33(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002609 File Offset: 0x00000809
	internal static object smethod_34(Class8.Class11 class11_0, int int_6)
	{
		return class11_0.method_1(int_6);
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002618 File Offset: 0x00000818
	internal static void smethod_35(Class8.Class11 class11_0)
	{
		class11_0.method_4();
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002623 File Offset: 0x00000823
	internal static void smethod_36(Array array_0)
	{
		Array.Reverse(array_0);
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x0000262E File Offset: 0x0000082E
	internal static object smethod_37(Assembly assembly_1)
	{
		return assembly_1.GetName();
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002639 File Offset: 0x00000839
	internal static object smethod_38(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKeyToken();
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00002644 File Offset: 0x00000844
	internal static object smethod_39()
	{
		return Class8.smethod_7();
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x0000264B File Offset: 0x0000084B
	internal static void smethod_40(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0000265A File Offset: 0x0000085A
	internal static object smethod_41(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_2, byte[] byte_3)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
	}

	// Token: 0x060000BA RID: 186 RVA: 0x0000266D File Offset: 0x0000086D
	internal static object smethod_42()
	{
		return new MemoryStream();
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00002674 File Offset: 0x00000874
	internal static void smethod_43(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		stream_0.Write(byte_2, int_6, int_7);
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0000268B File Offset: 0x0000088B
	internal static void smethod_44(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00002696 File Offset: 0x00000896
	internal static object smethod_45(Stream stream_0)
	{
		return Class8.smethod_29(stream_0);
	}

	// Token: 0x060000BE RID: 190 RVA: 0x000026A1 File Offset: 0x000008A1
	internal static void smethod_46(Stream stream_0)
	{
		stream_0.Close();
	}

	// Token: 0x060000BF RID: 191 RVA: 0x000026AC File Offset: 0x000008AC
	internal static object smethod_47(Assembly assembly_1)
	{
		return assembly_1.EntryPoint;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x000026B7 File Offset: 0x000008B7
	internal static bool smethod_48(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
	{
		return methodInfo_0 == methodInfo_1;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x000026C6 File Offset: 0x000008C6
	internal static bool smethod_49()
	{
		return null == null;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x000025AB File Offset: 0x000007AB
	internal static object smethod_50()
	{
		return null;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x000026C6 File Offset: 0x000008C6
	internal static bool smethod_51()
	{
		return null == null;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x000025AB File Offset: 0x000007AB
	internal static object smethod_52()
	{
		return null;
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x0000243B File Offset: 0x0000063B
	static int smethod_53()
	{
		return 1;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x000026CC File Offset: 0x000008CC
	internal static IntPtr smethod_54(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadIntPtr(intptr_4, int_6);
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000026DB File Offset: 0x000008DB
	internal static int smethod_55(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadInt32(intptr_4, int_6);
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x000026EA File Offset: 0x000008EA
	internal static long smethod_56(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadInt64(intptr_4, int_6);
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x000026F9 File Offset: 0x000008F9
	internal static void smethod_57(IntPtr intptr_4, int int_6, IntPtr intptr_5)
	{
		Marshal.WriteIntPtr(intptr_4, int_6, intptr_5);
	}

	// Token: 0x060000CA RID: 202 RVA: 0x0000270C File Offset: 0x0000090C
	internal static void smethod_58(IntPtr intptr_4, int int_6, int int_7)
	{
		Marshal.WriteInt32(intptr_4, int_6, int_7);
	}

	// Token: 0x060000CB RID: 203 RVA: 0x0000271F File Offset: 0x0000091F
	internal static void smethod_59(IntPtr intptr_4, int int_6, long long_2)
	{
		Marshal.WriteInt64(intptr_4, int_6, long_2);
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002732 File Offset: 0x00000932
	internal static IntPtr smethod_60(int int_6)
	{
		return Marshal.AllocCoTaskMem(int_6);
	}

	// Token: 0x060000CD RID: 205 RVA: 0x0000273D File Offset: 0x0000093D
	internal static void smethod_61(byte[] byte_2, int int_6, IntPtr intptr_4, int int_7)
	{
		Marshal.Copy(byte_2, int_6, intptr_4, int_7);
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002754 File Offset: 0x00000954
	internal static void smethod_62()
	{
		Class8.smethod_17();
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0000275B File Offset: 0x0000095B
	internal static object smethod_63()
	{
		return Process.GetCurrentProcess();
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002762 File Offset: 0x00000962
	internal static object smethod_64(Process process_0)
	{
		return process_0.MainModule;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x0000276D File Offset: 0x0000096D
	internal static IntPtr smethod_65(ProcessModule processModule_0)
	{
		return processModule_0.BaseAddress;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00002778 File Offset: 0x00000978
	internal static IntPtr smethod_66(IntPtr intptr_4, string string_1, uint uint_1)
	{
		return Class8.smethod_21(intptr_4, string_1, uint_1);
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x0000278B File Offset: 0x0000098B
	internal static bool smethod_67(IntPtr intptr_4, IntPtr intptr_5)
	{
		return intptr_4 != intptr_5;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x000022DF File Offset: 0x000004DF
	internal static void smethod_68()
	{
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x0000279A File Offset: 0x0000099A
	internal static int smethod_69()
	{
		return IntPtr.Size;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x000027A1 File Offset: 0x000009A1
	internal static Type smethod_70(string string_1, bool bool_7)
	{
		return Type.GetType(string_1, bool_7);
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x000027B0 File Offset: 0x000009B0
	internal static bool smethod_71(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x000027BF File Offset: 0x000009BF
	internal static object smethod_72(Process process_0)
	{
		return process_0.Modules;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x000027CA File Offset: 0x000009CA
	internal static object smethod_73(ReadOnlyCollectionBase readOnlyCollectionBase_0)
	{
		return readOnlyCollectionBase_0.GetEnumerator();
	}

	// Token: 0x060000DA RID: 218 RVA: 0x000027D5 File Offset: 0x000009D5
	internal static object smethod_74(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x000027E0 File Offset: 0x000009E0
	internal static object smethod_75(ProcessModule processModule_0)
	{
		return processModule_0.ModuleName;
	}

	// Token: 0x060000DC RID: 220 RVA: 0x000027EB File Offset: 0x000009EB
	internal static object smethod_76(string string_1)
	{
		return string_1.ToLower();
	}

	// Token: 0x060000DD RID: 221 RVA: 0x000027F6 File Offset: 0x000009F6
	internal static bool smethod_77(string string_1, string string_2)
	{
		return string_1 == string_2;
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002805 File Offset: 0x00000A05
	internal static object smethod_78(ProcessModule processModule_0)
	{
		return processModule_0.FileVersionInfo;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00002810 File Offset: 0x00000A10
	internal static int smethod_79(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductMajorPart;
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x0000281B File Offset: 0x00000A1B
	internal static int smethod_80(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductMinorPart;
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00002826 File Offset: 0x00000A26
	internal static int smethod_81(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductBuildPart;
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00002831 File Offset: 0x00000A31
	internal static int smethod_82(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductPrivatePart;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x0000283C File Offset: 0x00000A3C
	internal static bool smethod_83(Version version_0, Version version_1)
	{
		return version_0 >= version_1;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x0000284B File Offset: 0x00000A4B
	internal static bool smethod_84(Version version_0, Version version_1)
	{
		return version_0 < version_1;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x0000285A File Offset: 0x00000A5A
	internal static bool smethod_85(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00002865 File Offset: 0x00000A65
	internal static void smethod_86(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00002870 File Offset: 0x00000A70
	internal static object smethod_87(Assembly assembly_1, string string_1)
	{
		return assembly_1.GetManifestResourceStream(string_1);
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x000025E4 File Offset: 0x000007E4
	internal static object smethod_88(Class8.Class11 class11_0)
	{
		return class11_0.method_0();
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x000025EF File Offset: 0x000007EF
	internal static void smethod_89(Stream stream_0, long long_2)
	{
		stream_0.Position = long_2;
	}

	// Token: 0x060000EA RID: 234 RVA: 0x000025FE File Offset: 0x000007FE
	internal static long smethod_90(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00002609 File Offset: 0x00000809
	internal static object smethod_91(Class8.Class11 class11_0, int int_6)
	{
		return class11_0.method_1(int_6);
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00002623 File Offset: 0x00000823
	internal static void smethod_92(Array array_0)
	{
		Array.Reverse(array_0);
	}

	// Token: 0x060000ED RID: 237 RVA: 0x0000262E File Offset: 0x0000082E
	internal static object smethod_93(Assembly assembly_1)
	{
		return assembly_1.GetName();
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002639 File Offset: 0x00000839
	internal static object smethod_94(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKeyToken();
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0000287F File Offset: 0x00000A7F
	internal static void smethod_95(Array array_0, int int_6, int int_7)
	{
		Array.Clear(array_0, int_6, int_7);
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00002892 File Offset: 0x00000A92
	internal static object smethod_96(Assembly assembly_1)
	{
		return assembly_1.GetModules();
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x0000289D File Offset: 0x00000A9D
	internal static IntPtr smethod_97(Module module_0)
	{
		return Marshal.GetHINSTANCE(module_0);
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x000028A8 File Offset: 0x00000AA8
	internal static object smethod_98(Assembly assembly_1)
	{
		return assembly_1.Location;
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x000028B3 File Offset: 0x00000AB3
	internal static int smethod_99(string string_1)
	{
		return string_1.Length;
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x000028BE File Offset: 0x00000ABE
	internal static int smethod_100(Class8.Class11 class11_0)
	{
		return class11_0.method_3();
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00002644 File Offset: 0x00000844
	internal static object smethod_101()
	{
		return Class8.smethod_7();
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x0000264B File Offset: 0x0000084B
	internal static void smethod_102(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x0000265A File Offset: 0x0000085A
	internal static object smethod_103(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_2, byte[] byte_3)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00002674 File Offset: 0x00000874
	internal static void smethod_104(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		stream_0.Write(byte_2, int_6, int_7);
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x0000268B File Offset: 0x0000088B
	internal static void smethod_105(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	// Token: 0x060000FA RID: 250 RVA: 0x000028C9 File Offset: 0x00000AC9
	internal static object smethod_106(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	// Token: 0x060000FB RID: 251 RVA: 0x000026A1 File Offset: 0x000008A1
	internal static void smethod_107(Stream stream_0)
	{
		stream_0.Close();
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00002618 File Offset: 0x00000818
	internal static void smethod_108(Class8.Class11 class11_0)
	{
		class11_0.method_4();
	}

	// Token: 0x060000FD RID: 253 RVA: 0x000028D4 File Offset: 0x00000AD4
	internal static int smethod_109(Process process_0)
	{
		return process_0.Id;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x000028DF File Offset: 0x00000ADF
	internal static IntPtr smethod_110(uint uint_1, int int_6, uint uint_2)
	{
		return Class8.smethod_25(uint_1, int_6, uint_2);
	}

	// Token: 0x060000FF RID: 255 RVA: 0x000028F2 File Offset: 0x00000AF2
	internal static object smethod_111(int int_6)
	{
		return BitConverter.GetBytes(int_6);
	}

	// Token: 0x06000100 RID: 256 RVA: 0x000028FD File Offset: 0x00000AFD
	internal static long smethod_112(Stream stream_0)
	{
		return stream_0.Position;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00002908 File Offset: 0x00000B08
	internal static void smethod_113(IntPtr intptr_4, int int_6)
	{
		Marshal.WriteInt32(intptr_4, int_6);
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00002917 File Offset: 0x00000B17
	internal static int smethod_114(IntPtr intptr_4)
	{
		return Class8.smethod_26(intptr_4);
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00002922 File Offset: 0x00000B22
	internal static void smethod_115(Hashtable hashtable_1, object object_2, object object_3)
	{
		hashtable_1.Add(object_2, object_3);
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002935 File Offset: 0x00000B35
	internal static Type smethod_116(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00002940 File Offset: 0x00000B40
	internal static int smethod_117(long long_2)
	{
		return Convert.ToInt32(long_2);
	}

	// Token: 0x06000106 RID: 262 RVA: 0x0000294B File Offset: 0x00000B4B
	internal static object smethod_118()
	{
		return Encoding.UTF8;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00002952 File Offset: 0x00000B52
	internal static object smethod_119(Encoding encoding_0, byte[] byte_2)
	{
		return encoding_0.GetString(byte_2);
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00002961 File Offset: 0x00000B61
	internal static bool smethod_120(IntPtr intptr_4, IntPtr intptr_5)
	{
		return intptr_4 == intptr_5;
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00002970 File Offset: 0x00000B70
	internal static object smethod_121(IntPtr intptr_4, Type type_0)
	{
		return Class8.smethod_18(intptr_4, type_0);
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0000297F File Offset: 0x00000B7F
	internal static IntPtr smethod_122(Class8.Delegate5 delegate5_0)
	{
		return delegate5_0();
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0000298A File Offset: 0x00000B8A
	internal static int smethod_123(IntPtr intptr_4)
	{
		return Marshal.ReadInt32(intptr_4);
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00002995 File Offset: 0x00000B95
	internal static long smethod_124(IntPtr intptr_4)
	{
		return Marshal.ReadInt64(intptr_4);
	}

	// Token: 0x0600010D RID: 269 RVA: 0x000029A0 File Offset: 0x00000BA0
	internal static IntPtr smethod_125(Delegate delegate_0)
	{
		return Marshal.GetFunctionPointerForDelegate(delegate_0);
	}

	// Token: 0x0600010E RID: 270 RVA: 0x000029AB File Offset: 0x00000BAB
	internal static int smethod_126(ProcessModule processModule_0)
	{
		return processModule_0.ModuleMemorySize;
	}

	// Token: 0x0600010F RID: 271 RVA: 0x000026AC File Offset: 0x000008AC
	internal static object smethod_127(Assembly assembly_1)
	{
		return assembly_1.EntryPoint;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x000029B6 File Offset: 0x00000BB6
	internal static bool smethod_128(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
	{
		return methodInfo_0 != methodInfo_1;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x000029C5 File Offset: 0x00000BC5
	internal static object smethod_129(Delegate delegate_0)
	{
		return delegate_0.Method;
	}

	// Token: 0x06000112 RID: 274 RVA: 0x000029D0 File Offset: 0x00000BD0
	internal static object smethod_130(Type type_0, MethodInfo methodInfo_0)
	{
		return Delegate.CreateDelegate(type_0, methodInfo_0);
	}

	// Token: 0x06000113 RID: 275 RVA: 0x000029DF File Offset: 0x00000BDF
	internal static object smethod_131(MethodBase methodBase_0)
	{
		return methodBase_0.GetParameters();
	}

	// Token: 0x06000114 RID: 276 RVA: 0x000029EA File Offset: 0x00000BEA
	internal static object smethod_132(Assembly assembly_1)
	{
		return assembly_1.ManifestModule;
	}

	// Token: 0x06000115 RID: 277 RVA: 0x000029F5 File Offset: 0x00000BF5
	internal static ModuleHandle smethod_133(Module module_0)
	{
		return module_0.ModuleHandle;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00002A00 File Offset: 0x00000C00
	internal static Type smethod_134(object object_2)
	{
		return object_2.GetType();
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00002A0B File Offset: 0x00000C0B
	internal static object smethod_135(FieldInfo fieldInfo_0, object object_2)
	{
		return fieldInfo_0.GetValue(object_2);
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00002A1A File Offset: 0x00000C1A
	internal static object smethod_136(long long_2)
	{
		return BitConverter.GetBytes(long_2);
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00002A25 File Offset: 0x00000C25
	internal static void smethod_137(Delegate delegate_0)
	{
		RuntimeHelpers.PrepareDelegate(delegate_0);
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00002A30 File Offset: 0x00000C30
	internal static RuntimeMethodHandle smethod_138(MethodBase methodBase_0)
	{
		return methodBase_0.MethodHandle;
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00002A3B File Offset: 0x00000C3B
	internal static void smethod_139(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00002A46 File Offset: 0x00000C46
	internal static void smethod_140(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00002A55 File Offset: 0x00000C55
	internal static IntPtr smethod_141(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		return Class8.smethod_22(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00002A6C File Offset: 0x00000C6C
	internal static void smethod_142(IntPtr intptr_4, IntPtr intptr_5)
	{
		Marshal.WriteIntPtr(intptr_4, intptr_5);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x000026C6 File Offset: 0x000008C6
	internal static bool smethod_143()
	{
		return null == null;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x000025AB File Offset: 0x000007AB
	internal static object smethod_144()
	{
		return null;
	}

	// Token: 0x0400003A RID: 58
	private static string[] string_0 = new string[0];

	// Token: 0x0400003B RID: 59
	private static bool bool_0 = false;

	// Token: 0x0400003C RID: 60
	private static Dictionary<int, int> dictionary_0 = null;

	// Token: 0x0400003D RID: 61
	private static long long_0 = 0L;

	// Token: 0x0400003E RID: 62
	private static List<string> list_0 = null;

	// Token: 0x0400003F RID: 63
	private static Class8.Delegate9 delegate9_0 = null;

	// Token: 0x04000040 RID: 64
	private static Class8.Delegate7 delegate7_0 = null;

	// Token: 0x04000041 RID: 65
	private static bool bool_1 = false;

	// Token: 0x04000042 RID: 66
	private static bool bool_2 = false;

	// Token: 0x04000043 RID: 67
	private static byte[] byte_0 = new byte[0];

	// Token: 0x04000044 RID: 68
	internal static Hashtable hashtable_0 = new Hashtable();

	// Token: 0x04000045 RID: 69
	private static object object_0 = new object();

	// Token: 0x04000046 RID: 70
	private static uint[] uint_0 = new uint[]
	{
		3614090360U, 3905402710U, 606105819U, 3250441966U, 4118548399U, 1200080426U, 2821735955U, 4249261313U, 1770035416U, 2336552879U,
		4294925233U, 2304563134U, 1804603682U, 4254626195U, 2792965006U, 1236535329U, 4129170786U, 3225465664U, 643717713U, 3921069994U,
		3593408605U, 38016083U, 3634488961U, 3889429448U, 568446438U, 3275163606U, 4107603335U, 1163531501U, 2850285829U, 4243563512U,
		1735328473U, 2368359562U, 4294588738U, 2272392833U, 1839030562U, 4259657740U, 2763975236U, 1272893353U, 4139469664U, 3200236656U,
		681279174U, 3936430074U, 3572445317U, 76029189U, 3654602809U, 3873151461U, 530742520U, 3299628645U, 4096336452U, 1126891415U,
		2878612391U, 4237533241U, 1700485571U, 2399980690U, 4293915773U, 2240044497U, 1873313359U, 4264355552U, 2734768916U, 1309151649U,
		4149444226U, 3174756917U, 718787259U, 3951481745U
	};

	// Token: 0x04000047 RID: 71
	private static List<int> list_1 = null;

	// Token: 0x04000048 RID: 72
	private static SortedList sortedList_0 = new SortedList();

	// Token: 0x04000049 RID: 73
	private static bool bool_3 = false;

	// Token: 0x0400004A RID: 74
	private static IntPtr intptr_0 = IntPtr.Zero;

	// Token: 0x0400004B RID: 75
	private static long long_1 = 0L;

	// Token: 0x0400004C RID: 76
	private static int int_0 = 0;

	// Token: 0x0400004D RID: 77
	internal static Class8.Delegate4 delegate4_0 = null;

	// Token: 0x0400004E RID: 78
	private static Class8.Delegate10 delegate10_0 = null;

	// Token: 0x0400004F RID: 79
	internal static Class8.Delegate4 delegate4_1 = null;

	// Token: 0x04000050 RID: 80
	private static int int_1 = 0;

	// Token: 0x04000051 RID: 81
	private static int int_2 = 1;

	// Token: 0x04000052 RID: 82
	private static Class8.Delegate11 delegate11_0 = null;

	// Token: 0x04000053 RID: 83
	private static int[] int_3 = new int[0];

	// Token: 0x04000054 RID: 84
	private static IntPtr intptr_1 = IntPtr.Zero;

	// Token: 0x04000055 RID: 85
	private static int int_4 = 0;

	// Token: 0x04000056 RID: 86
	private static int int_5 = 0;

	// Token: 0x04000057 RID: 87
	private static IntPtr intptr_2 = IntPtr.Zero;

	// Token: 0x04000058 RID: 88
	private static bool bool_4 = false;

	// Token: 0x04000059 RID: 89
	internal static Assembly assembly_0 = typeof(Class8).Assembly;

	// Token: 0x0400005A RID: 90
	private static Class8.Delegate8 delegate8_0 = null;

	// Token: 0x0400005B RID: 91
	private static bool bool_5 = false;

	// Token: 0x0400005C RID: 92
	private static IntPtr intptr_3 = IntPtr.Zero;

	// Token: 0x0400005D RID: 93
	private static byte[] byte_1 = new byte[0];

	// Token: 0x0400005E RID: 94
	private static object object_1 = new object();

	// Token: 0x0400005F RID: 95
	internal static RSACryptoServiceProvider rsacryptoServiceProvider_0 = null;

	// Token: 0x04000060 RID: 96
	[Class8.Attribute0(typeof(Class8.Attribute0.Class9<object>[]))]
	private static bool bool_6 = false;

	// Token: 0x04000061 RID: 97
	private static Class8.Delegate6 delegate6_0 = null;

	// Token: 0x0200001B RID: 27
	// (Invoke) Token: 0x06000122 RID: 290
	private delegate void Delegate3(object o);

	// Token: 0x0200001C RID: 28
	internal class Attribute0 : Attribute
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00002A7B File Offset: 0x00000C7B
		public Attribute0(object object_0)
		{
		}

		// Token: 0x0200001D RID: 29
		internal class Class9<T>
		{
			// Token: 0x06000127 RID: 295 RVA: 0x00002A83 File Offset: 0x00000C83
			internal static bool smethod_0()
			{
				return Class8.Attribute0.Class9<T>.object_0 == null;
			}

			// Token: 0x06000128 RID: 296 RVA: 0x00002A8D File Offset: 0x00000C8D
			internal static object smethod_1()
			{
				return Class8.Attribute0.Class9<T>.object_0;
			}

			// Token: 0x04000062 RID: 98
			internal static object object_0;
		}
	}

	// Token: 0x0200001E RID: 30
	internal class Class10
	{
		// Token: 0x06000129 RID: 297 RVA: 0x0000A5D0 File Offset: 0x000087D0
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = new byte[]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] array2 = Class8.smethod_9(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class8.smethod_7();
			symmetricAlgorithm.Key = array;
			symmetricAlgorithm.IV = array2;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	// Token: 0x0200001F RID: 31
	// (Invoke) Token: 0x0600012C RID: 300
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate4(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	// Token: 0x02000020 RID: 32
	// (Invoke) Token: 0x06000130 RID: 304
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate5();

	// Token: 0x02000021 RID: 33
	internal struct Struct4
	{
		// Token: 0x04000063 RID: 99
		internal bool bool_0;

		// Token: 0x04000064 RID: 100
		internal byte[] byte_0;
	}

	// Token: 0x02000022 RID: 34
	internal class Class11
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00002A94 File Offset: 0x00000C94
		public Class11(Stream stream_0)
		{
			this.binaryReader_0 = new BinaryReader(stream_0);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002AA8 File Offset: 0x00000CA8
		internal Stream method_0()
		{
			return this.binaryReader_0.BaseStream;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002AB5 File Offset: 0x00000CB5
		internal byte[] method_1(int int_0)
		{
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002AC3 File Offset: 0x00000CC3
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.binaryReader_0.Read(byte_0, int_0, int_1);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002AD3 File Offset: 0x00000CD3
		internal int method_3()
		{
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002AE0 File Offset: 0x00000CE0
		internal void method_4()
		{
			this.binaryReader_0.Close();
		}

		// Token: 0x04000065 RID: 101
		private BinaryReader binaryReader_0;
	}

	// Token: 0x02000023 RID: 35
	// (Invoke) Token: 0x0600013A RID: 314
	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr Delegate6(IntPtr hModule, string lpName, uint lpType);

	// Token: 0x02000024 RID: 36
	// (Invoke) Token: 0x0600013E RID: 318
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate7(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	// Token: 0x02000025 RID: 37
	// (Invoke) Token: 0x06000142 RID: 322
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate8(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	// Token: 0x02000026 RID: 38
	// (Invoke) Token: 0x06000146 RID: 326
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate9(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	// Token: 0x02000027 RID: 39
	// (Invoke) Token: 0x0600014A RID: 330
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate10(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	// Token: 0x02000028 RID: 40
	// (Invoke) Token: 0x0600014E RID: 334
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate11(IntPtr ptr);

	// Token: 0x02000029 RID: 41
	[Flags]
	private enum Enum1
	{

	}
}
