using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KAutoTS
{
	public partial class FormSetting : Form
	{

		public FormSetting()
		{
			InitializeComponent();


			#region 매수 설정 가져오기

			// 추정자산 기준 1/n 사용 여부
			setting.buy_count_yn = Properties.Settings.Default.BUY_COUNT_YN;
			CheckBuyCountYN.Checked = setting.buy_count_yn;

			// 추정자산 기준 1/n 사용 여부 값
			setting.buy_count = Properties.Settings.Default.BUY_COUNT;
			TextBuyCount.Text = setting.buy_count.ToString();

			// 매수 금액 지정 사용 여부
			setting.buy_cost_yn = Properties.Settings.Default.BUY_COST_YN;
			CheckBuyCostYN.Checked = setting.buy_cost_yn;

			// 매수 금액 지정 값
			setting.buy_cost = Properties.Settings.Default.BUY_COST;
			TextBuyCost.Text = Util.GetNumberFormat(setting.buy_cost);

			// 거래량 기준 매수수량 사용 여부
			setting.buy_rebuy_yn = Properties.Settings.Default.BUY_REBUY_YN;
            CheckReBuyYN.Checked = setting.buy_rebuy_yn;

			// 자동 정정 주문 사용 여부
			setting.buy_re_order_yn = Properties.Settings.Default.BUY_RE_ORDER_YN;
			CheckBuyReOrder.Checked = setting.buy_re_order_yn;

			// 장마감 동시호가 진입시 취소 주문
			setting.buy_order_cancel_31_yn = Properties.Settings.Default.BUY_ORDER_CANCEL_31_YN;
			CheckBuyOrderCancel31.Checked = setting.buy_order_cancel_31_yn;

			// 미수주문 가능 여부
			setting.buy_misu_yn = Properties.Settings.Default.BUY_MINU_YN;
			CheckBuyMisuYN.Checked = setting.buy_misu_yn;

			// 중복 매수 가능 여부
			setting.buy_duplicate_yn = Properties.Settings.Default.BUY_DUPLICATE_YN;
			CheckBuyDuplicateYN.Checked = setting.buy_duplicate_yn;

			// 당일 목표 달성시 매수 주문 여부
			setting.buy_max_yn = Properties.Settings.Default.BUY_MAX_YN;
			CheckBuyMaxYN.Checked = setting.buy_max_yn;

			// 당일 목표 달성시 매수 주문 여부 - 손익율 값
			setting.buy_max = Properties.Settings.Default.BUY_MAX;
			TextBuyMax.Text = setting.buy_max.ToString();

			// 장 시작 후 매수진행 시간 사용 여부
			setting.buy_time_yn = Properties.Settings.Default.BUY_TIME_YN;
			CheckBuyTimeYN.Checked = setting.buy_time_yn;

			// 장 시작 후 매수진행 시간 값
			setting.buy_time = Properties.Settings.Default.BUY_TIME;
			TextBuyTime.Text = setting.buy_time.ToString();



			#endregion

			#region 매도 설정 가져오기

			// 손절
			setting.sell_min_yn = Properties.Settings.Default.SELL_MIN_YN;
			CheckSellMinYN.Checked = setting.sell_min_yn;

			setting.sell_min_rate = Properties.Settings.Default.SELL_MIN_RATE;
			TextSellMinRate.Text = setting.sell_min_rate.ToString();

			// 고정
			setting.sell_fix_yn = Properties.Settings.Default.SELL_FIX_YN;
			CheckSellFixYN.Checked = setting.sell_fix_yn;

			setting.sell_fix_buffer = Properties.Settings.Default.SELL_FIX_BUFFER;
			TextSellFixBuffer.Text = setting.sell_fix_buffer.ToString();

			// 목표
			setting.sell_max_yn = Properties.Settings.Default.SELL_MAX_YN;
			CheckSellMaxYN.Checked = setting.sell_max_yn;

			setting.sell_max_rate = Properties.Settings.Default.SELL_MAX_RATE;
			TextSellMaxRate.Text = setting.sell_max_rate.ToString();

			setting.sell_max_buffer = Properties.Settings.Default.SELL_MAX_BUFFER;
			TextSellMaxBuffer.Text = setting.sell_max_buffer.ToString();

			// 시가
			setting.sell_open_yn = Properties.Settings.Default.SELL_OPEN_YN;
			CheckSellOpenYN.Checked = setting.sell_open_yn;

			setting.sell_open_buffer = Properties.Settings.Default.SELL_OPEN_BUFFER;
			TextSellOpenBuffer.Text = setting.sell_open_buffer.ToString();

			// 상한가
			setting.sell_uplmt_yn = Properties.Settings.Default.SELL_UPLMT_YN;
			CheckSellUplmtYN.Checked = setting.sell_uplmt_yn;

			setting.sell_uplmt_buffer = Properties.Settings.Default.SELL_UPLMT_BUFFER;
			TextSellUplmtBuffer.Text = setting.sell_uplmt_buffer.ToString();

			// 자동 정정 주문 사용 여부
			setting.sell_re_order_yn = Properties.Settings.Default.SELL_RE_ORDER_YN;
			CheckSellReOrder.Checked = setting.sell_re_order_yn;

			// 장마감 동시호가 진입시 취소 주문
			setting.sell_order_cancel_31_yn = Properties.Settings.Default.SELL_ORDER_CANCEL_31_YN;
			CheckSellOrderCancel31.Checked = setting.sell_order_cancel_31_yn;

			// 보유종목 당일 청산
			setting.sell_today_yn = Properties.Settings.Default.SELL_TODAY_YN;
			CheckSellTodayYN.Checked = setting.sell_today_yn;

			// 종목검색 매도 사용 유무
			setting.sell_1833_yn = Properties.Settings.Default.SELL_1833_YN;
			CheckSell1833YN.Checked = setting.sell_1833_yn;

			// 종목검색 매도 버퍼 값
			setting.sell_1833_buffer = Properties.Settings.Default.SELL_1833_BUFFER;
			TextSell1833Buffer.Text = setting.sell_1833_buffer.ToString();

			// 절반 매도 사용 유무
			setting.sell_half_yn = Properties.Settings.Default.SELL_HALF_YN;
			CheckSellHalfYN.Checked = setting.sell_half_yn;

			// 절반 매도 목표 값
			setting.sell_half = Properties.Settings.Default.SELL_HALF;
			TextSellHalf.Text = setting.sell_half.ToString();

			#endregion

			#region 시스템 설정 가져오기

			// API -> HTS
			setting.program_api_2_hts_yn = Properties.Settings.Default.PROGRAM_API_2_HTS_YN;
			CheckProgramApi2HtsYN.Checked = setting.program_api_2_hts_yn;

			// HTS -> API
			setting.program_hts_2_api_yn = Properties.Settings.Default.PROGRAM_HTS_2_API_YN;
			CheckProgramHts2ApiYN.Checked = setting.program_hts_2_api_yn;

			// 서버 시간 동기화 유무
			setting.program_sync_time_yn = Properties.Settings.Default.PROGRAM_SYNC_TIME_YN;
			CheckProgramSyncTimeYN.Checked = setting.program_sync_time_yn;

			#endregion

			#region 폼 위치/사이즈 복원

			if (Properties.Settings.Default.FORM_SETTING_LEFT >= 0)
			{
				this.Left = Properties.Settings.Default.FORM_SETTING_LEFT;
			}
			else
			{
				this.Left = 0;
			}

			if (Properties.Settings.Default.FORM_SETTING_TOP >= 0)
			{
				this.Top = Properties.Settings.Default.FORM_SETTING_TOP;
			}
			else
			{
				this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height - 29;
			}

			#endregion
		}

		/// <summary>
		/// 종목검색 설정저장 버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonSaveSetting1833_Click(object sender, EventArgs e)
		{
			try
			{
				

				Properties.Settings.Default.Save();

				MessageBox.Show("종목검색 설정을 저장하였습니다..!!");
			}
			catch (Exception ex)
			{
				
			}
		}

		
		/// <summary>
		/// 매수 설정저장 버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonSaveSettingBuy_Click(object sender, EventArgs e)
		{
			try
			{
				// 추정자산 기준 1/n 사용 여부
				setting.buy_count_yn = CheckBuyCountYN.Checked;
				Properties.Settings.Default.BUY_COUNT_YN = setting.buy_count_yn;

				// 추정자산 기준 1/n 사용 값
				setting.buy_count = Convert.ToInt32(TextBuyCount.Text.Trim().Replace(",", ""));
				Properties.Settings.Default.BUY_COUNT = setting.buy_count;

				// 매수 금액 지정 여부
				setting.buy_cost_yn = CheckBuyCostYN.Checked;
				Properties.Settings.Default.BUY_COST_YN = setting.buy_cost_yn;

				// 매수 금액 지정 값
				setting.buy_cost = Convert.ToDouble(TextBuyCost.Text.Trim().Replace(",", ""));
				Properties.Settings.Default.BUY_COST = setting.buy_cost;
				TextBuyCost.Text = Util.GetNumberFormat(setting.buy_cost);

				// 당일 같은 종목 재매수 가능 여부
				setting.buy_rebuy_yn = CheckReBuyYN.Checked;
                Properties.Settings.Default.BUY_REBUY_YN = setting.buy_rebuy_yn;

				// 자동 정정 주문 발행
				setting.buy_re_order_yn = CheckBuyReOrder.Checked;
				Properties.Settings.Default.BUY_RE_ORDER_YN = setting.buy_re_order_yn;

				// 장마감 동시호가 진입시 취소 주문
				setting.buy_order_cancel_31_yn = CheckBuyOrderCancel31.Checked;
				Properties.Settings.Default.BUY_ORDER_CANCEL_31_YN = setting.buy_order_cancel_31_yn;

				// 미수 주문 가능 여부
				setting.buy_misu_yn = CheckBuyMisuYN.Checked;
				Properties.Settings.Default.BUY_MINU_YN = setting.buy_misu_yn;

				// 중복 매수 가능 여부
				setting.buy_duplicate_yn = CheckBuyDuplicateYN.Checked;
				Properties.Settings.Default.BUY_DUPLICATE_YN = setting.buy_duplicate_yn;

				// 당일 목표 달성시 매수 주문 사용 여부
				setting.buy_max_yn = CheckBuyMaxYN.Checked;
				Properties.Settings.Default.BUY_MAX_YN = setting.buy_max_yn;

				// 당일 목표 달성 수익율
				setting.buy_max = Convert.ToDouble(TextBuyMax.Text);
				Properties.Settings.Default.BUY_MAX = setting.buy_max;

				// 장 시작 후 매수 진행 시간값 사용 여부
				setting.buy_time_yn = CheckBuyTimeYN.Checked;
				Properties.Settings.Default.BUY_TIME_YN = setting.buy_time_yn;

				// 장 시작 후 매수 진행 시간값 
				setting.buy_time = Convert.ToDouble(TextBuyTime.Text);
				Properties.Settings.Default.BUY_TIME = setting.buy_time;


				Properties.Settings.Default.Save();

				MessageBox.Show("매수 설정을 저장하였습니다..!!");
			}
			catch (Exception ex)
			{
				
			}
		}

		/// <summary>
		/// 매도 설정저장 버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonSaveSettingSell_Click(object sender, EventArgs e)
		{
			try
			{
				// 손절
				setting.sell_min_yn = CheckSellMinYN.Checked;
				Properties.Settings.Default.SELL_MIN_YN = setting.sell_min_yn;

				setting.sell_min_rate = Math.Abs(Convert.ToDouble(TextSellMinRate.Text));
				Properties.Settings.Default.SELL_MIN_RATE = setting.sell_min_rate;

				// 고정
				setting.sell_fix_yn = CheckSellFixYN.Checked;
				Properties.Settings.Default.SELL_FIX_YN = setting.sell_fix_yn;

				setting.sell_fix_buffer = Math.Abs(Convert.ToDouble(TextSellFixBuffer.Text));
				Properties.Settings.Default.SELL_FIX_BUFFER = setting.sell_fix_buffer;

				// 목표
				setting.sell_max_yn = CheckSellMaxYN.Checked;
				Properties.Settings.Default.SELL_MAX_YN = setting.sell_max_yn;

				setting.sell_max_rate = Math.Abs(Convert.ToDouble(TextSellMaxRate.Text));
				Properties.Settings.Default.SELL_MAX_RATE = setting.sell_max_rate;

				setting.sell_max_buffer = Math.Abs(Convert.ToDouble(TextSellMaxBuffer.Text));
				Properties.Settings.Default.SELL_MAX_BUFFER = setting.sell_max_buffer;

				// 시가
				setting.sell_open_yn = CheckSellOpenYN.Checked;
				Properties.Settings.Default.SELL_OPEN_YN = setting.sell_open_yn;

				setting.sell_open_buffer = Math.Abs(Convert.ToDouble(TextSellOpenBuffer.Text));
				Properties.Settings.Default.SELL_OPEN_BUFFER = setting.sell_open_buffer;

				// 상한가
				setting.sell_uplmt_yn = CheckSellUplmtYN.Checked;
				Properties.Settings.Default.SELL_UPLMT_YN = setting.sell_uplmt_yn;

				setting.sell_uplmt_buffer = Math.Abs(Convert.ToDouble(TextSellUplmtBuffer.Text));
				Properties.Settings.Default.SELL_UPLMT_BUFFER = setting.sell_uplmt_buffer;

				// UI 필드에 보정된 값 세팅
				TextSellMinRate.Text = setting.sell_min_rate.ToString();
				TextSellFixBuffer.Text = setting.sell_fix_buffer.ToString();
				TextSellMaxRate.Text = setting.sell_max_rate.ToString();
				TextSellMaxBuffer.Text = setting.sell_max_buffer.ToString();
				TextSellOpenBuffer.Text = setting.sell_open_buffer.ToString();
				TextSellUplmtBuffer.Text = setting.sell_uplmt_buffer.ToString();

				// 장마감 동시호가 진입시 취소 주문
				setting.sell_order_cancel_31_yn = CheckSellOrderCancel31.Checked;
				Properties.Settings.Default.SELL_ORDER_CANCEL_31_YN = setting.sell_order_cancel_31_yn;

				// 자동 정정 주문 발행
				setting.sell_re_order_yn = CheckSellReOrder.Checked;
				Properties.Settings.Default.SELL_RE_ORDER_YN = setting.sell_re_order_yn;

				// 보유종목 당일 청산
				setting.sell_today_yn = CheckSellTodayYN.Checked;
				Properties.Settings.Default.SELL_TODAY_YN = setting.sell_today_yn;

				// 종목검색 매도 사용 유무
				setting.sell_1833_yn = CheckSell1833YN.Checked;
				Properties.Settings.Default.SELL_1833_YN = setting.sell_1833_yn;

				// 종목검색 매도 버퍼 값
				setting.sell_1833_buffer = Convert.ToDouble(TextSell1833Buffer.Text);
				Properties.Settings.Default.SELL_1833_BUFFER = setting.sell_1833_buffer;

				// 절반 매도 사용 유무
				setting.sell_half_yn = CheckSellHalfYN.Checked;
				Properties.Settings.Default.SELL_HALF_YN = setting.sell_half_yn;

				// 절반 매도 목표 값
				setting.sell_half = Convert.ToDouble(TextSellHalf.Text);
				Properties.Settings.Default.SELL_HALF = setting.sell_half;

				Properties.Settings.Default.Save();

				MessageBox.Show("매도 설정을 저장하였습니다..!!");

			}
			catch (Exception ex)
			{
				
			}
		}

		/// <summary>
		/// 시스템 설정저장 버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonSaveSettingProgram_Click(object sender, EventArgs e)
		{
			try
			{
				// API -> HTS
				setting.program_api_2_hts_yn = CheckProgramApi2HtsYN.Checked;
				Properties.Settings.Default.PROGRAM_API_2_HTS_YN = setting.program_api_2_hts_yn;

				// HTS -> API
				setting.program_hts_2_api_yn = CheckProgramHts2ApiYN.Checked;
				Properties.Settings.Default.PROGRAM_HTS_2_API_YN = setting.program_hts_2_api_yn;

				// PC 시간을 서버와 동기화
				setting.program_sync_time_yn = CheckProgramSyncTimeYN.Checked;
				Properties.Settings.Default.PROGRAM_SYNC_TIME_YN = setting.program_sync_time_yn;

				Properties.Settings.Default.Save();

				MessageBox.Show("시스템 설정을 저장하였습니다..!!");
			}
			catch (Exception ex)
			{
			}
		}


		/// <summary>
		/// 새로고침 버튼 클릭시 이벤트 처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Button_LoadAdf_Click(object sender, EventArgs e)
		{
			try
			{
				fnLoad1833FileList();
			}
			catch (Exception ex)
			{
			}
		}

		

		/// <summary>
		/// t1833 종목검색을 위한 파일 리스트를 체크 리스트 박스에 생성
		/// </summary>
		public void fnLoad1833FileList()
		{
			List1833FileName.Items.Clear();
            /*
			DirectoryInfo dir = new DirectoryInfo(setting.t1833_dir);

			foreach (FileInfo file in dir.GetFiles())
			{
				if (file.Extension.ToUpper() == ".ADF")
				{
					string filename = file.Name;

					if (setting.t1833_files.IndexOf(filename) >= 0)
					{
						List1833FileName.Items.Add(file.Name, true);
					}
					else
					{
						List1833FileName.Items.Add(file.Name, false);
					}
				}
			}
             * */
		}

		
		
		/// <summary>
		/// 1833 종목검색 폴더 열기
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Button1833DirOpen_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("explorer", Text1833Dir.Text);
		}

		

		/// <summary>미수주문 체크값 변경시</summary>
		private void CheckBuyMisuYN_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckBuyMisuYN.Checked)
			{
				CheckBuyCountYN.Checked = false;
				CheckBuyCountYN.Enabled = false;
				TextBuyCount.Enabled = false;

				CheckBuyCostYN.Checked = false;
				CheckBuyCostYN.Enabled = false;
				TextBuyCost.Enabled = false;

				CheckBuyDuplicateYN.Checked = false;
				CheckBuyDuplicateYN.Enabled = false;
			}
			else
			{
				CheckBuyCountYN.Checked = true;
				CheckBuyCountYN.Enabled = true;
				TextBuyCount.Enabled = true;

				CheckBuyCostYN.Checked = true;
				CheckBuyCostYN.Enabled = true;
				TextBuyCost.Enabled = true;

				CheckBuyDuplicateYN.Checked = true;
				CheckBuyDuplicateYN.Enabled = true;
			}
		}

		/// <summary>종목검색 체크리스트 체크 항목 변경시 - 매수/매도 중 한가지만 사용가능하도록..</summary>
		private void List1833FileName_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Checked)
			{
				// 파일명에서 매수/매도 구분값 가져옴
				string divide = List1833FileName.Items[e.Index].ToString().Substring(3, 2);

				for (int i = 0; i < List1833FileName.Items.Count; i++)
				{
					if (divide != List1833FileName.Items[i].ToString().Substring(3, 2))
					{
						List1833FileName.SetItemCheckState(i, CheckState.Unchecked);
					}
				}
			}
		}






	}
}
