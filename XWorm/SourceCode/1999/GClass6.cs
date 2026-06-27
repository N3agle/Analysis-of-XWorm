using System;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000010 RID: 16
	public class GClass6
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00006ED4 File Offset: 0x000050D4
		public static object smethod_0(string string_0)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = new byte[32];
			byte[] array2 = md5CryptoServiceProvider.ComputeHash(Class6.smethod_6(GClass0.string_7));
			Array.Copy(array2, 0, array, 0, 16);
			Array.Copy(array2, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array3 = Convert.FromBase64String(string_0);
			return Class6.smethod_7(cryptoTransform.TransformFinalBlock(array3, 0, array3.Length));
		}
	}
}
