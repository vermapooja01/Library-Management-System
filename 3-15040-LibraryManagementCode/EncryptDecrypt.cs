using System;

namespace Library_Management
{
	/// <summary>
	/// Summary description for Base64.
	/// </summary>
	public class EncryptDecrypt
	{
		const char          fillchar = '=';
		static string cvt = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

		static public string Encode(string data)
		{
			int i;
			int c;
			int len = data.Length;
			string ret="";

			for (i = 0; i < len; ++i)
			{
				c = (data[i] >> 2) & 0x3f;
				ret +=cvt[c];
				c = (data[i] << 4) & 0x3f;
				if (++i < len)
					c |= (data[i] >> 4) & 0x0f;

				ret += cvt[c];
				if (i < len)
				{
					c = (data[i] << 2) & 0x3f;
					if (++i < len)
						c |= (data[i] >> 6) & 0x03;

					ret += cvt[c];
				}
				else
				{
					++i;
					ret += fillchar;
				}

				if (i < len)
				{
					c = data[i] & 0x3f;
					ret += cvt[c];
				}
				else
				{
					ret += fillchar;
				}
			}

			return(ret);
		}

		static public string Decode(string data)
		{
			string ret="";
			int i;
			char c;
			char c1;
			int len = data.Length;

			for (i = 0; i < len; ++i)
			{
				c = (char) cvt.IndexOf(data[i]);
				++i;
				c1 = (char) cvt.IndexOf(data[i]);
				c = ((char)((c << 2) | ((c1 >> 4) & 0x3)));
				ret += c;
				if (++i < len)
				{
					c = data[i];
					if (fillchar == c)
						break;

					c = (char) cvt.IndexOf(c);
					c1 = (char)(((c1 << 4) & 0xf0) | ((c >> 2) & 0xf));
					ret += c1;
				}

				if (++i < len)
				{
					c1 = data[i];
					if (fillchar == c1)
						break;

					c1 = (char) cvt.IndexOf(c1);
					c = (char)(((c << 6) & 0xc0) | c1);
					ret += c;
				}
			}
			return(ret);
		}
	}
}

