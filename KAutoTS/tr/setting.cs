using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace KAutoTS
{
	/// <summary>환경설정 변수 값을 저장하는 클래스</summary>
	class setting
	{


		#region 로그인/세션 관련 설정

		/// <summary>서버 접속 주소</summary>
		public static string login_server;

		/// <summary>로그인 아뒤</summary>
		public static string login_id;

		/// <summary>로그인 비밀번호</summary>
		public static string login_pw;

		/// <summary>공인인증서 비밀번호</summary>
		public static string login_public_pw;

		/// <summary>계좌</summary>
		public static string login_account;

		/// <summary>계좌 비밀번호</summary>
		public static string login_account_pw;

		/// <summary>자동 로그인 유무</summary>
		public static bool login_auto_yn;

		/// <summary>자동 매매 시작 유무</summary>
		public static bool login_trading_yn;

		#endregion

		#region 매수관련 설정

		/// <summary>추정자산을 기준으로 1/n 여부</summary>
		public static bool buy_count_yn;

		/// <summary>추정자산을 기준으로 최대 매수 가능 금액을 1/n 값으로 계산할 값</summary>
		public static int buy_count;

		/// <summary>매수 금액 지정 여부</summary>
		public static bool buy_cost_yn;

		/// <summary>매수 금액 지정 값</summary>
		public static double buy_cost;

		/// <summary>당일 같은 종목 재매수 가능 여부</summary>
		public static bool buy_rebuy_yn;

		/// <summary>자동 정정 주문 발행 여부</summary>
		public static bool buy_re_order_yn;

		/// <summary>장마감 동시호가 진입시 미체결(매수) 종목 취소 주문 발행</summary>
		public static bool buy_order_cancel_31_yn;

		/// <summary>미수 주문 가능 여부</summary>
		public static bool buy_misu_yn;

		/// <summary>중목 매수 가능 여부</summary>
		public static bool buy_duplicate_yn;

		/// <summary>당일 목표 수익 달성시 매수 주문 안함</summary>
		public static bool buy_max_yn;

		/// <summary>당일 목표 수익 달성시 매수 주문 안함 :: 목표 수익율 값</summary>
		public static double buy_max;

		/// <summary>장 시작 후 지정시간 동안 매수 진행 여부</summary>
		public static bool buy_time_yn;

		/// <summary>장 시작 후 지정시간 동안 매수 진행할 시간 값</summary>
		public static double buy_time;

		
		#endregion 

		#region 매도관련 설정

		/// <summary>손절 매도 사용 유무</summary>
		public static bool sell_min_yn;

		/// <summary>손절할 수익율</summary>
		public static double sell_min_rate;

		/// <summary>고정 매도 사용 유무</summary>
		public static bool sell_fix_yn;

		/// <summary>고정 매도할 수익율 버퍼</summary>
		public static double sell_fix_buffer;

		/// <summary>목표달성 매도 사용 유무</summary>
		public static bool sell_max_yn;

		/// <summary>목표달성 수익율</summary>
		public static double sell_max_rate;

		/// <summary>목표달성 후 매도를 위한 버퍼</summary>
		public static double sell_max_buffer;

		/// <summary>시가 기준 매도 사용 여부</summary>
		public static bool sell_open_yn;

		/// <summary>시가 기준 매도할 버퍼 값</summary>
		public static double sell_open_buffer;

		/// <summary>상한가 기준 매도 사용 여부</summary>
		public static bool sell_uplmt_yn;

		/// <summary>상한가 기준 매도할 버퍼 값</summary>
		public static double sell_uplmt_buffer;

		/// <summary>장마감 동시호가 진입시 미체결(매도) 종목 취소 주문 발행</summary>
		public static bool sell_order_cancel_31_yn;

		/// <summary>자동 정정 주문 발행 여부</summary>
		public static bool sell_re_order_yn;

		/// <summary>당일 청산 여부</summary>
		public static bool sell_today_yn;

		/// <summary>종목검색 매도 사용 유무</summary>
		public static bool sell_1833_yn;

		/// <summary>종목검색 매도시 버퍼 값</summary>
		public static double sell_1833_buffer;

		/// <summary>절반 매도 사용 유무</summary>
		public static bool sell_half_yn;

		/// <summary>절반 매도시 목표 값</summary>
		public static double sell_half;

		#endregion

		#region 나머지 시스템 관련 설정

		/// <summary>프로그램 실행 디렉토리</summary>
		public static string program_execute_dir = "";

		/// <summary>현재 실행중인 프로그램 경로/이름 </summary>
		public static string program_full_name;

		/// <summary>API -> HTS 연동 유무</summary>
		public static bool program_api_2_hts_yn;

		/// <summary>HTS -> API 연동 유무</summary>
		public static bool program_hts_2_api_yn;

		/// <summary>PC 시간을 서버와 동기화 유무</summary>
		public static bool program_sync_time_yn;

		
		#endregion
	}	// end class
}	// end namespace
