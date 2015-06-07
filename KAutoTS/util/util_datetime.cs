using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KAutoTS
{
	/// <summary>
	/// DateTime 관련 함수들
	/// </summary>
	public class util_datetime
	{
		/// <summary>
		/// 현재 시간을 포멧 입힌 형태로 리턴
		/// </summary>
		/// <param name="format">
		/// yyyy-MM-dd HH:mm:ss.fff -> 2013-10.30 14:30:21.123
		/// </param>
		/// <returns>포멧 변환된 값</returns>
		public static string GetFormatNow(string format)
		{
			return DateTime.Now.ToString(format);
		}	// end function
	}	// end class
}	// end namespace
