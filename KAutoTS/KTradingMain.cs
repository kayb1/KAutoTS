/************************************************************
  샘플버전 : 1.0.0.0 ( 2015.01.23 )
  샘플제작 : (주)에스비씨엔 / sbcn.co.kr/ ZooATS.com
  샘플환경 : Visual Studio 2013 / C# 5.0
  샘플문의 : support@zooats.com / john@sbcn.co.kr
  전    화 : 02-719-5500 / 070-7777-6555
************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KiwoomCode;
using System.Net.Json;

namespace KAutoTS
{

    public partial class KTradingMain : Form
    {
        private string TITLE_NAME = "KAutoTS";
        private string TITLE_VERSION_CODE = "v0.0.1";

        private int scrNum = 5000;

        /// <summary>매수할 종목 그리드 헤더 json</summary>
        public JsonObjectCollection mhBuyList;

        /// <summary>주식잔고 그리드 헤더 json</summary>
        public JsonObjectCollection mhAccount;

        /// <summary>매도시 활용 {"종목코드":"고가|최고수익율"}</summary>
        public JsonObjectCollection mAccountJson;

        /// <summary>당일 같은 종목 재매수 세팅시 활용 {"종목코드"}</summary>
        public JsonObjectCollection mRebuyJson;

        /// <summary>실시간 조건검색식 활용 {"종목코드"}</summary>
        public JsonObjectCollection mRealJson;

        private FormSetting mfSetting;

        public KTradingMain()
        {
            InitializeComponent();

            // 그리드 초기화
            initGridTitle();

            로그인ToolStripMenuItem.Enabled = true;
            로그아웃ToolStripMenuItem.Enabled = false;

            if (axKHOpenAPI.CommConnect() == 0)
            {
                Logger(Log.일반, "로그인창 열기 성공");
            }
            else
            {
                Logger(Log.에러, "로그인창 열기 실패");
            }

            Text = TITLE_NAME + " " + TITLE_VERSION_CODE + " - 미연결";

            #region 필요한 JSON 로딩

            string date_saved = Properties.Settings.Default.LAST_DATE;
            string date_now = util_datetime.GetFormatNow("yyyyMMdd");

            // 오늘 프로그램이 실행된적이 있다면...
            if (date_now == date_saved)
            {
                // 설정파일에 저장된 값을 로딩				
                try
                {
                    mAccountJson = (JsonObjectCollection)new JsonTextParser().Parse(Properties.Settings.Default.ACCOUNT_JSON);
                    mRebuyJson = (JsonObjectCollection)new JsonTextParser().Parse(Properties.Settings.Default.REBUY_JSON);
                }
                // 설정 파일에 잘못된 json 값이 들어가 있을 경우 예외 처리
                catch (Exception ex)
                {
                    // json 초기화
                    mAccountJson = new JsonObjectCollection();
                    mRebuyJson = new JsonObjectCollection();

                    Logger(Log.에러, "KTradingMain json 초기화 :: " + ex.Message);
                }
            }
            // 오늘 처음 실행되는 것이라면..
            else
            {
                // json 초기화
                mAccountJson = new JsonObjectCollection();
                mRebuyJson = new JsonObjectCollection();

                // 설정파일에 금일 날짜값 저장
                Properties.Settings.Default.LAST_DATE = date_now;
                Properties.Settings.Default.Save();
            }

            mfSetting = new FormSetting();

            ButtonAutoRealSearchStart.Enabled = false;
            ButtonAutoRealSearchStop.Enabled = false;

            #endregion
        }

        /// <summary>
        /// 그리드 초기화 - 타이틀 세팅 
        /// </summary>
        private void initGridTitle()
        {
            // 실시간 잔고 그리드
            string[] aAccountTitle = { "종목번호", "종목명", "평가손익", "수익률", "매입가", "보유수량", "현재가", "매입금액", "평가금액" };

            mhAccount = new JsonObjectCollection();
            GridAccount.ColumnCount = aAccountTitle.Length;

            for (int i = 0; i < aAccountTitle.Length; i++)
            {
                mhAccount.Add(new JsonNumericValue(aAccountTitle[i], i));

                GridAccount.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                GridAccount.Columns[i].Name = aAccountTitle[i];
                //GridAccount.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                GridAccount.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                GridAccount.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                GridAccount.Columns[i].Width = GridAccount.Width / aAccountTitle.Length;

                if (aAccountTitle[i] == "종목번호" || aAccountTitle[i] == "종목명")
                {
                    GridAccount.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    GridAccount.Columns[i].Frozen = true;
                }
                else
                {
                    GridAccount.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    if (aAccountTitle[i] == "수익률")
                    {
                        //GridAccount.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font(GridAccount.Font, System.Drawing.FontStyle.Bold);
                    }
                }
            }

            GridAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;		// 행단위 선택

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 실시간 조건검색 그리드
            string[] aAccountRealCondition = { "종목번호", "종목명", "현재가", "현.등락률", "검색가", "검.등락률"};

            GridRealCondition.ColumnCount = aAccountRealCondition.Length;

            for (int i = 0; i < aAccountRealCondition.Length; i++)
            {
                GridRealCondition.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                GridRealCondition.Columns[i].Name = aAccountRealCondition[i];
                GridRealCondition.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                GridRealCondition.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                GridRealCondition.Columns[i].Width = GridRealCondition.Width / aAccountRealCondition.Length;

                if (aAccountTitle[i] == "종목번호" || aAccountTitle[i] == "종목명")
                {
                    GridRealCondition.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    GridRealCondition.Columns[i].Frozen = true;
                }
                else
                {
                    GridRealCondition.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    if (aAccountTitle[i] == "수익률")
                    {
                        //GridRealCondition.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font(GridRealCondition.Font, System.Drawing.FontStyle.Bold);
                    }
                }
            }

            GridRealCondition.SelectionMode = DataGridViewSelectionMode.FullRowSelect;		// 행단위 선택

            mRealJson = new JsonObjectCollection();
        }

        // 로그를 출력합니다.
        public void Logger(Log type, string format, params Object[] args)
        {
            string message = String.Format(format, args);

            switch (type)
            {
                case Log.조회:
                    lst일반.Items.Add("[조회] " + message);
                    lst일반.SelectedIndex = lst일반.Items.Count - 1;
                    break;
                case Log.에러:
                    lst일반.Items.Add("[에러] " + message);
                    lst일반.SelectedIndex = lst일반.Items.Count - 1;
                    break;
                case Log.일반:
                    lst일반.Items.Add("[일반] " + message);
                    lst일반.SelectedIndex = lst일반.Items.Count - 1;
                    break;
                case Log.실시간:
                    lst일반.Items.Add("[실시간] " + message);
                    lst일반.SelectedIndex = lst일반.Items.Count - 1;
                    break;
                default:
                    break;
            }
        }

        // 로그인 창을 엽니다.
        private void 로그인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axKHOpenAPI.CommConnect() == 0)
            {
                Logger(Log.일반, "로그인창 열기 성공");
            }
            else
            {
                Logger(Log.에러, "로그인창 열기 실패");
            }
        }

        // 샘플 프로그램을 종료 합니다.
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 로그아웃
        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            로그인ToolStripMenuItem.Enabled = true;
            로그아웃ToolStripMenuItem.Enabled = false;

            DisconnectAllRealData();
            axKHOpenAPI.CommTerminate();
            Logger(Log.일반, "로그아웃");
        }

        private void axKHOpenAPI_OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
       
            if (e.sRQName == "주식주문")
            {
                string s원주문번호 = axKHOpenAPI.GetCommData(e.sTrCode, "", 0, "").Trim();

                long n원주문번호 = 0;
                bool canConvert = long.TryParse(s원주문번호, out n원주문번호);

                if (canConvert == true)
                    txt원주문번호.Text = s원주문번호;
                else
                    Logger(Log.에러, "잘못된 원주문번호 입니다");

            }
            // OPT1001 : 주식기본정보
            else if (e.sRQName == "주식기본정보")
            {
                int nCnt = axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);

                for (int i = 0; i < nCnt; i++)
                {
                    Logger(Log.조회, "{0} | 현재가:{1:N0} | 등락율:{2} | 거래량:{3:N0} ",
                        axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "종목명").Trim(),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "현재가").Trim()),
                        axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "등락율").Trim(),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "거래량").Trim()));
                }
            }
            // OPT10081 : 주식일봉차트조회
            else if (e.sRQName == "주식일봉차트조회")
            {
                int nCnt = axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);

                for (int i = 0; i < nCnt; i++)
                {
                    Logger(Log.조회, "{0} | 현재가:{1:N0} | 거래량:{2:N0} | 시가:{3:N0} | 고가:{4:N0} | 저가:{5:N0} ",
                        axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "일자").Trim(),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "현재가").Trim()),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "거래량").Trim()),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "시가").Trim()),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "고가").Trim()),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "저가").Trim()));
                }
            }
            // OPW00004 : 주식실시간잔고
            else if (e.sRQName == "실시간잔고")
            {
                String sunamt = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "예수금").Trim();
                String sunamtD2 = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "D+2추정예수금").Trim();

                Text100.Text = Util.GetNumberFormat(sunamt);
                TextSunamt1.Text = Util.GetNumberFormat(sunamtD2);
            }
            // OPW00018 : 계좌평가잔고
            else if (e.sRQName == "계좌잔고평가")
            {
                String mamt = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "총매입금액").Trim();
                String abp = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "총평가금액").Trim();
                String todayDtsunik = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "총평가손익금액").Trim();
                String todayRate = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "총수익률(%)").Trim();

                TextMamt.Text = Util.GetNumberFormat(mamt);
                TextSunamt.Text = Util.GetNumberFormat(abp);
                TextTdtsunik.Text = Util.GetNumberFormat(todayDtsunik);
                TextTdtsunikP.Text = Util.GetNumberFormat2(todayRate);

                // 그리드 초기화
                GridAccount.Rows.Clear();

                int nCnt = axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);

                if (nCnt > 0)
                {
                    // 잔고 그리드 초기화
                    for (int iRow = 0; iRow < GridAccount.Rows.Count; iRow++)
                    {
                        // 비교용으로 사용할 row header 값 초기화
                        GridAccount.Rows[iRow].HeaderCell.Value = "";

                        // 배경색 초기화
                        GridAccount.Rows[iRow].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    }
                }

                for (int i = 0; i < nCnt; i++)
                {
                    string[] row = new string[GridAccount.ColumnCount];

                    for (int j = 0; j < row.Length; j++)
                    {
                        row[j] = "0";
                    }

                    string shcode = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "종목번호").Trim();
                    string dtsunik = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "평가손익").Trim();
                    string squantity = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "보유수량").Trim();

                    #region 0424 당일 재매수 종목 json 데이터 처리
                    // json에 저장된 잔고 종목 정보 가져 옴
                    JsonObject jsonRebuy0424 = mRebuyJson[shcode];

                    // json에 잔고 종목 정보가 없으면 추가
                    if (jsonRebuy0424 == null)
                    {
                        mRebuyJson.Add(new JsonStringValue(shcode));
                    }
                    #endregion

                    // 잔고정보 그리드에 종목정보가 이미 있다면 현재값 기준으로 수정
					/*bool flagModify = false;
					
					int iRowGrid = GridAccount.Rows.Count;

                    for (int iRow = 0; iRow < iRowGrid; iRow++)
                    {
                        // 그리드에서 해당 종목을 찾아서..
                        if (shcode == GridAccount.Rows[iRow].Cells[0].Value.ToString())
                        {
                            #region 매도주문

                            double quantity = Convert.ToDouble(squantity);
                            // 매도가능 수량이 있다면 설정값에 따른 매도 진행
                            if (quantity > 0)
                            {
                                // 일괄매도 체크되어 있으면 보유종목 전량 매도
                                if (CheckSellAll.Checked)
                                {
                                    setting.mxTrCSPAT00600.call_request(shcode, quantity.ToString(), price.ToString(), "1", "[매도] 일괄 :: " + rate.ToString(), hname);
                                }

                                // 보유종목 당일 청산
                                if (setting.sell_today_yn)
                                {
                                    // 장중
                                    if (setting.mxRealJif.mjstatus == "21" && setting.mxTr0167.mTimeCur >= 144900)
                                    {
                                        setting.mxTrCSPAT00600.call_request(shcode, quantity.ToString(), price.ToString(), "1", "[매도] 당일청산 :: " + rate.ToString(), hname);
                                    }
                                    // 장 마감 동시호가
                                    else if (setting.mxRealJif.mjstatus == "42")
                                    {
                                        double dnlmt_grid = Convert.ToDouble(mfTrading.GridAccount.Rows[iRow].Cells[Convert.ToInt32(mfTrading.mhAccount["하한가"].GetValue())].Value);
                                        setting.mxTrCSPAT00600.call_request(shcode, quantity.ToString(), dnlmt_grid.ToString(), "1", "[매도] 당일청산 :: " + rate.ToString(), hname);
                                    }
                                }

                                // 손실제한 사용
                                if (setting.sell_min_yn)
                                {
                                    // 수익율이 손실제한 설정값보다 작다면 매도
                                    if (rate < -setting.sell_min_rate)
                                    {
                                        setting.mxTrCSPAT00600.call_request(shcode, quantity.ToString(), price.ToString(), "1", "[매도] 손절 :: " + rate.ToString(), hname);
                                    }
                                }

                                // 목표 수익율 달성시 매도 사용
                                if (setting.sell_max_yn)
                                {
                                    // 최고 수익율이 목표 수익율을 넘겼다면..
                                    if (json_rate_high > setting.sell_max_rate)
                                    {
                                        // 목표 수익율 도달 후 버퍼값 만큼 하락시 매도
                                        if ((rate + 100) < (json_rate_high + 100 - setting.sell_max_buffer))
                                        {
                                            setting.mxTrCSPAT00600.call_request(shcode, quantity.ToString(), price.ToString(), "1", "[매도] 목표 :: " + rate.ToString(), hname);
                                        }
                                    }
                                }

                                // 고정진폭 매도
                                if (setting.sell_fix_yn)
                                {
                                    // 현재 수익율 < 최고 수익율 - 버퍼
                                    if ((rate + 100) < (json_rate_high + 100 - setting.sell_fix_buffer))
                                    {
                                        setting.mxTrCSPAT00600.call_request(shcode, quantity.ToString(), price.ToString(), "1", "[매도] 고정 :: " + rate.ToString(), hname);
                                    }
                                }

                                // 절반 매도 사용
                                if (setting.sell_half_yn)
                                {
                                    // 최고 수익율이 목표 수익율을 넘겼다면..
                                    if (json_rate_high > setting.sell_half)
                                    {
                                        // 최고 수익율 대비 절반만큼 하락시 매도
                                        if (rate <= (json_rate_high - (json_rate_high / 2)))
                                        {
                                            setting.mxTrCSPAT00600.call_request(shcode, quantity.ToString(), price.ToString(), "1", "[매도] 절반 :: " + rate.ToString(), hname);
                                        }
                                    }
                                }

                                // 상한가 이탈 종목 잡기
                                if (setting.sell_uplmt_yn)
                                {
                                    // 고가 == 상한가 찍었을 경우
                                    if (json_price_high == uplmt_grid)
                                    {
                                        // 지정한 버퍼만큼 하락하면 매도
                                        if ((rate + 100) < (json_rate_high + 100 - setting.sell_uplmt_buffer))
                                        {
                                            setting.mxTrCSPAT00600.call_request(shcode, quantity.ToString(), price.ToString(), "1", "[매도] 상한가 이탈 :: " + rate.ToString(), hname);
                                        }
                                    }
                                }

                                // 시가 기준 매도
                                if (setting.sell_open_yn)
                                {
                                    double open_grid = Convert.ToDouble(mfTrading.GridAccount.Rows[iRow].Cells[Convert.ToInt32(mfTrading.mhAccount["시가"].GetValue())].Value);
                                    double dnlmt_grid = Convert.ToDouble(mfTrading.GridAccount.Rows[iRow].Cells[Convert.ToInt32(mfTrading.mhAccount["하한가"].GetValue())].Value);

                                    // 시가 == 하한가 경우는 무조건 매도
                                    if (open_grid == dnlmt_grid)
                                    {
                                        setting.mxTrCSPAT00600.call_request(shcode, quantity.ToString(), price.ToString(), "1", "[매도] 시가 == 하한가 :: " + rate.ToString(), hname);
                                    }
                                    // 시가 기준 버퍼값 하락시 매도
                                    else
                                    {
                                        if (price < Util.GetPricePercent(open_grid, -setting.sell_open_buffer))
                                        {
                                            setting.mxTrCSPAT00600.call_request(shcode, quantity.ToString(), price.ToString(), "1", "[매도] 현재가 < 당일시가 :: " + rate.ToString(), hname);
                                        }
                                    }
                                }
                            }

                            #endregion

                            #region 그리드에 잔고 변경 정보 반영

                            // 수정될 종목이 있다고 flag 값 변경
                            flagModify = true;

                            // 루프 종료 후 삭제시 참고하기 위해 현재 정보를 row header 값에 세팅
                            GridAccount.Rows[iRow].HeaderCell.Value = "U";

                            // 그리드의 값 변경
                            mfTrading.GridAccount.Rows[iRow].Cells[Convert.ToInt32(mfTrading.mhAccount["수량"].GetValue())].Value = Util.GetNumberFormat(quantity);
                            mfTrading.GridAccount.Rows[iRow].Cells[Convert.ToInt32(mfTrading.mhAccount["현재가"].GetValue())].Value = Util.GetNumberFormat(price);
                            mfTrading.GridAccount.Rows[iRow].Cells[Convert.ToInt32(mfTrading.mhAccount["평가금액"].GetValue())].Value = Util.GetNumberFormat(appamt);
                            mfTrading.GridAccount.Rows[iRow].Cells[Convert.ToInt32(mfTrading.mhAccount["평가손익"].GetValue())].Value = Util.GetNumberFormat(dtsunik);
                            mfTrading.GridAccount.Rows[iRow].Cells[Convert.ToInt32(mfTrading.mhAccount["수익율"].GetValue())].Value = Util.GetNumberFormat2(rate);
                            mfTrading.GridAccount.Rows[iRow].Cells[Convert.ToInt32(mfTrading.mhAccount["평균단가"].GetValue())].Value = Util.GetNumberFormat(pamt);

                            // 고가 == 상한가
                            if (json_price_high == uplmt_grid)
                            {
                                GridAccount.Rows[iRow].DefaultCellStyle.Font = new System.Drawing.Font("굴림", 9, System.Drawing.FontStyle.Italic);

                                // 현재가 == 상한가
                                if (price == uplmt_grid)
                                {
                                    GridAccount.Rows[iRow].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                                    GridAccount.Rows[iRow].DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
                                }
                                // 상한가 이탈
                                else
                                {
                                    // 평가손익 대비 row 색상 지정
                                    if (Convert.ToDouble(dtsunik) > 0)
                                    {
                                        GridAccount.Rows[iRow].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                                    }
                                    else
                                    {
                                        GridAccount.Rows[iRow].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
                                    }
                                }
                            }

                            // 그리드 루프 빠져 나감
                            break;

                            #endregion
                        }
                    }
                    */
                    row[Convert.ToInt32(mhAccount["종목번호"].GetValue())] = shcode;
                    row[Convert.ToInt32(mhAccount["종목명"].GetValue())] = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "종목명").Trim();
                    row[Convert.ToInt32(mhAccount["평가손익"].GetValue())] = Util.GetNumberFormat(dtsunik);
                    row[Convert.ToInt32(mhAccount["수익률"].GetValue())] = Util.GetNumberFormat2(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "수익률(%)").Trim());
                    row[Convert.ToInt32(mhAccount["매입가"].GetValue())] = Util.GetNumberFormat(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "매입가").Trim());
                    row[Convert.ToInt32(mhAccount["보유수량"].GetValue())] = Util.GetNumberFormat(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "보유수량").Trim());
                    row[Convert.ToInt32(mhAccount["현재가"].GetValue())] = Util.GetNumberFormat(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "현재가").Trim());
                    row[Convert.ToInt32(mhAccount["매입금액"].GetValue())] = Util.GetNumberFormat(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "매입금액").Trim());
                    row[Convert.ToInt32(mhAccount["평가금액"].GetValue())] = Util.GetNumberFormat(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "평가금액").Trim());

                    GridAccount.Rows.Add(row);

                    int iRowLast = GridAccount.Rows.Count - 1;

                    // 평가손익 대비 row 색상 지정
                    if (Convert.ToDouble(dtsunik) > 0)
                    {
                        GridAccount.Rows[iRowLast].Cells[Convert.ToInt32(mhAccount["평가손익"].GetValue())].Style.ForeColor = System.Drawing.Color.Red;
                        GridAccount.Rows[iRowLast].Cells[Convert.ToInt32(mhAccount["수익률"].GetValue())].Style.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        GridAccount.Rows[iRowLast].Cells[Convert.ToInt32(mhAccount["평가손익"].GetValue())].Style.ForeColor = System.Drawing.Color.Blue;
                        GridAccount.Rows[iRowLast].Cells[Convert.ToInt32(mhAccount["수익률"].GetValue())].Style.ForeColor = System.Drawing.Color.Blue;
                    }

                    /*
                    Logger(Log.조회, "{0} | 현재가:{1:N0} | 등락율:{2} | 거래량:{3:N0} ",
                        axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "종목명").Trim(),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "현재가").Trim()),
                        axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "손익금액").Trim(),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "손익율").Trim()));
                     */
                }
            }
            // OPT10074 : 일자별실현손익
            else if (e.sRQName == "일자별실현손익")
            {
                String todaySonik = axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, 0, "당일매도손익").Trim();
                TextDtsunik.Text = Util.GetNumberFormat(todaySonik);
            }
            // OPT10026 : 고저PER종목검색
            else if (e.sRQName == "고저PER종목")
            {
                int nCnt = axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);

                Logger(Log.일반, "고저PER종목 시작..!!");
                for (int i = 0; i < nCnt; i++)
                {
                    Logger(Log.조회, "{0} | 현재가:{1:N0} | 등락율:{2} | 거래량:{3:N0} ",
                        axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "종목명").Trim(),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "현재가").Trim()),
                        axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "등락율").Trim(),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "현재거래량").Trim()));
                }
                Logger(Log.일반, "고저PER종목 끝..!!");
            }
            // OPT10016 : 신고저가요청검색
            else if (e.sRQName == "신고저가요청")
            {
                int nCnt = axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);

                Logger(Log.일반, "신고저가요청 시작..!! " + nCnt);
                /*for (int i = 0; i < nCnt; i++)
                {
                    Logger(Log.조회, "{0} | 현재가:{1:N0} | 등락률:{2} | 거래량:{3:N0} ",
                        axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "종목명").Trim(),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "현재가").Trim()),
                        axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "등락률").Trim(),
                        Int32.Parse(axKHOpenAPI.CommGetData(e.sTrCode, "", e.sRQName, i, "현재거래량").Trim()));
                }*/
                Logger(Log.일반, "신고저가요청 끝..!!");
            }
            else
            {
                Logger(Log.일반, "모니..!! " + e.sRQName);
            }
        }

        private void axKHOpenAPI_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (Error.IsError(e.nErrCode))
            {
                Logger(Log.일반, "[로그인 처리결과] " + Error.GetErrorMessage());
            }
            else
            {
                Logger(Log.에러, "[로그인 처리결과] " + Error.GetErrorMessage());
            }

            if (axKHOpenAPI.GetConnectState() == 0)
            {
                로그인ToolStripMenuItem.Enabled = true;
                로그아웃ToolStripMenuItem.Enabled = false;

                Text = TITLE_NAME + " " + TITLE_VERSION_CODE + " - 미연결";
            }
            else
            {
                로그인ToolStripMenuItem.Enabled = false;
                로그아웃ToolStripMenuItem.Enabled = true;

                Text = TITLE_NAME + " " + TITLE_VERSION_CODE + " - 연결됨";

                lbl아이디.Text = axKHOpenAPI.GetLoginInfo("USER_ID");
                lbl이름.Text = axKHOpenAPI.GetLoginInfo("USER_NAME");

                string[] arr계좌 = axKHOpenAPI.GetLoginInfo("ACCNO").Split(';');

                cbo계좌.Items.AddRange(arr계좌);
                cbo계좌.SelectedIndex = 0;

                Logger(Log.일반, "자동종목검색 초기화 시작..!!");
                timerRealCondiInit.Start();
            }
        }

        private void axKHOpenAPI_OnReceiveChejanData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveChejanDataEvent e)
        {
            if (e.sGubun == "0")
            {
                Logger(Log.실시간, "구분 : 주문체결통보");
                Logger(Log.실시간, "주문/체결시간 : " + axKHOpenAPI.GetChejanData(908));
                Logger(Log.실시간, "종목명 : " + axKHOpenAPI.GetChejanData(302));
                Logger(Log.실시간, "주문수량 : " + axKHOpenAPI.GetChejanData(900));
                Logger(Log.실시간, "주문가격 : " + axKHOpenAPI.GetChejanData(901));
                Logger(Log.실시간, "체결수량 : " + axKHOpenAPI.GetChejanData(911));
                Logger(Log.실시간, "체결가격 : " + axKHOpenAPI.GetChejanData(910));
                Logger(Log.실시간, "=======================================");
            }
            else if (e.sGubun == "1")
            {
                Logger(Log.실시간, "구분 : 잔고통보");
            }
            else if (e.sGubun == "3")
            {
                Logger(Log.실시간, "구분 : 특이신호");
            }

        }

        private void axKHOpenAPI_OnReceiveMsg(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveMsgEvent e)
        {
            if (e.sRQName == "실시간잔고")
            {

            }
            else if (e.sRQName == "계좌잔고평가")
            {

            }
            else if (e.sRQName == "일자별실현손익")
            {

            }
            else if (e.sRQName == "")
            {

            }
            else
            {
                Logger(Log.조회, "===================================================");
                Logger(Log.조회, "화면번호:{0} | RQName:{1} | TRCode:{2} | 메세지:{3}", e.sScrNo, e.sRQName, e.sTrCode, e.sMsg);
            }
        }

        private void axKHOpenAPI_OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            if( e.sRealType == "주식시세" )
            {
                Logger(Log.실시간, "종목코드 : {0} | 현재가 : {1:C} | 등락율 : {2} | 누적거래량 : {3:N0} ",
                        e.sRealKey,
                        Int32.Parse(axKHOpenAPI.GetCommRealData(e.sRealType, 10).Trim()),
                        axKHOpenAPI.GetCommRealData(e.sRealType, 12).Trim(),
                        Int32.Parse(axKHOpenAPI.GetCommRealData(e.sRealType, 13).Trim()));
            } else
            {
                //Logger(Log.실시간, "종목코드 : {0} | RealType : {1} | RealData : {2}",
                //e.sRealKey, e.sRealType, e.sRealData);

                Logger(Log.실시간, "종목코드 : {0} | 현재가 : {1} | 등락율 : {2} | 종목명 : {3} ",
                        e.sRealKey,
                        Int32.Parse(axKHOpenAPI.GetCommRealData(e.sRealType, 10).Trim()),
                        axKHOpenAPI.GetCommRealData(e.sRealType, 12).Trim(),
                        axKHOpenAPI.GetMasterCodeName(e.sRealKey).Trim());

                for (int iRow = GridRealCondition.Rows.Count - 1; iRow >= 0; iRow--)
                {
                    if (GridRealCondition.Rows[iRow].Cells[0].Value.ToString() == e.sRealKey)
                    {
                        String price = Util.GetNumberFormat(axKHOpenAPI.GetCommRealData(e.sRealType, 10));
                        String updown = axKHOpenAPI.GetCommRealData(e.sRealType, 12);
                        GridRealCondition.Rows[iRow].Cells[1].Value = axKHOpenAPI.GetMasterCodeName(e.sRealKey).Trim();
                        GridRealCondition.Rows[iRow].Cells[2].Value = price;
                        GridRealCondition.Rows[iRow].Cells[3].Value = updown + "%";
                        if (GridRealCondition.Rows[iRow].Cells[4].Value.ToString() == "0")
                        {
                            GridRealCondition.Rows[iRow].Cells[4].Value = price;
                        }
                        if (GridRealCondition.Rows[iRow].Cells[5].Value.ToString() == "0")
                        {
                            GridRealCondition.Rows[iRow].Cells[5].Value = updown;
                        }
                        
                        break;
                    }
                }
            }
            
        }
        
        private void axKHOpenAPI_OnReceiveTrCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {
            if (e.strCodeList != null && e.strCodeList.Length > 0)
            {
                Logger(Log.실시간, "실시간종목 반환 : " + e.strConditionName + " " + e.strCodeList);

                String[] nameList = e.strCodeList.Split(';');
                if (nameList != null && nameList.Length > 1)
                {
                    for (int i = 0; i < nameList.Length; i++)
                    {
                        if (nameList[i].Length > 0 && mRealJson[nameList[i]] == null) 
                        {
                            mRealJson.Add(new JsonStringValue(nameList[i]));

                            string[] row = new string[GridRealCondition.ColumnCount];
                            for (int j = 0; j < row.Length; j++)
                            {
                                row[j] = "0";
                            }
                            row[0] = nameList[i];
                            row[1] = axKHOpenAPI.GetMasterCodeName(nameList[i]).Trim();
                            GridRealCondition.Rows.Add(row);
                        }
                    }
                    axKHOpenAPI.SetRealReg("5201", e.strCodeList, "9001;302;10;12", "0");
                }
            }
        }

        private void axKHOpenAPI_OnReceiveRealCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealConditionEvent e)
        {
            if (mRealJson[e.sTrCode] == null && e.strType == "I")
            {
                Logger(Log.실시간, "실시간종목 편입 : " + e.strConditionName + " " + e.sTrCode);
                mRealJson.Add(new JsonStringValue(e.sTrCode));

                bool isEixst = false;
                for (int iRow = GridRealCondition.Rows.Count - 1; iRow >= 0; iRow--)
                {
                    if (GridRealCondition.Rows[iRow].Cells[0].Value.ToString() == e.sTrCode)
                    {
                        isEixst = true;
                        break;
                    }

                }

                if (!isEixst)
                {
                    string[] row = new string[GridRealCondition.ColumnCount];
                    for (int j = 0; j < row.Length; j++)
                    {
                        row[j] = "0";
                    }
                    row[0] = e.sTrCode;
                    row[1] = axKHOpenAPI.GetMasterCodeName(e.sTrCode).Trim();
                    GridRealCondition.Rows.Add(row);

                    axKHOpenAPI.SetRealReg("5201", e.sTrCode, "9001;302;10;12", "1");
                }
            } else if (mRealJson[e.sTrCode] != null && e.strType == "D")
            {
                Logger(Log.실시간, "실시간종목 이탈 : " + e.strConditionName + " " + e.sTrCode);
                mRealJson.Remove(mRealJson[e.sTrCode]);

                for (int iRow = GridRealCondition.Rows.Count - 1; iRow >= 0; iRow--)
                {
                    if (GridRealCondition.Rows[iRow].Cells[0].Value.ToString() == e.sTrCode)
                    {
                        GridRealCondition.Rows.Remove(GridRealCondition.Rows[iRow]);
                        break;
                    }

                }

                axKHOpenAPI.SetRealRemove("5201", e.sTrCode);
            }
        }

        private void 현재가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axKHOpenAPI.SetInputValue("종목코드", txt종목코드.Text.Trim());

            int nRet = axKHOpenAPI.CommRqData("주식기본정보", "OPT10001", 0, GetScrNum());
            scrNum++;

            if (Error.IsError(nRet))
            {
                Logger(Log.일반, "[OPT10001] : " + Error.GetErrorMessage());
            }
            else
            {
                Logger(Log.에러, "[OPT10001] : " + Error.GetErrorMessage());
            }
        }

        private void 일봉데이터ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axKHOpenAPI.SetInputValue("종목코드", txt종목코드.Text.Trim());
            axKHOpenAPI.SetInputValue("기준일자", txt조회날짜.Text.Trim());
            axKHOpenAPI.SetInputValue("수정주가구분", "1");


            int nRet = axKHOpenAPI.CommRqData("주식일봉차트조회", "OPT10081", 0, GetScrNum());
            scrNum++;

            if (Error.IsError(nRet))
            {
                Logger(Log.일반, "[OPT10081] : " + Error.GetErrorMessage());
            }
            else
            {
                Logger(Log.에러, "[OPT10081] : " + Error.GetErrorMessage());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // =================================================
            // 거래구분목록 지정
            for (int i = 0; i < 12; i++)
                cbo거래구분.Items.Add(KOACode.hogaGb[i].name);
            
            cbo거래구분.SelectedIndex = 0;


            // =================================================
            // 주문유형
            for(int i = 0; i < 5; i++)
                cbo매매구분.Items.Add(KOACode.orderType[i].name);

            cbo매매구분.SelectedIndex = 0;
        }

        private void txt주문종목코드_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txt주문수량_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txt주문가격_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txt원주문번호_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txt종목코드_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txt조회날짜_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn주문_Click(object sender, EventArgs e)
        {
            // =================================================
            // 계좌번호 입력 여부 확인
            if( cbo계좌.Text.Length != 10 )
            {
                Logger(Log.에러, "계좌번호 10자리를 입력해 주세요");

                return;
            }

            // =================================================
            // 종목코드 입력 여부 확인
            if( txt주문종목코드.TextLength != 6 )
            {
                Logger(Log.에러, "종목코드 6자리를 입력해 주세요");

                return;
            }

            // =================================================
            // 주문수량 입력 여부 확인
            int n주문수량;

            if(txt주문수량.TextLength > 0)
            {
                n주문수량 = Int32.Parse(txt주문수량.Text.Trim());
            }
            else
            {
                Logger(Log.에러, "주문수량을 입력하지 않았습니다");
                
                return;
            }

            if( n주문수량 < 1 )
            {
                Logger(Log.에러, "주문수량이 1보다 작습니다");
                
                return;
            }

            // =================================================
            // 거래구분 취득
            // 0:지정가, 3:시장가, 5:조건부지정가, 6:최유리지정가, 7:최우선지정가,
            // 10:지정가IOC, 13:시장가IOC, 16:최유리IOC, 20:지정가FOK, 23:시장가FOK,
            // 26:최유리FOK, 61:장개시전시간외, 62:시간외단일가매매, 81:시간외종가
        
            string s거래구분;
            s거래구분 = KOACode.hogaGb[cbo거래구분.SelectedIndex].code;

            // =================================================
            // 주문가격 입력 여부

            int n주문가격 = 0;

            if( txt주문가격.TextLength > 0 )
            {
                n주문가격 = Int32.Parse(txt주문가격.Text.Trim());
            }

            if (s거래구분 == "3" || s거래구분 == "13" || s거래구분 == "23" && n주문가격 < 1)
            {
                Logger(Log.에러, "주문가격이 1보다 작습니다");
            }

            // =================================================
            // 매매구분 취득
            // (1:신규매수, 2:신규매도 3:매수취소, 
            // 4:매도취소, 5:매수정정, 6:매도정정)

            int n매매구분;
            n매매구분 = KOACode.orderType[cbo매매구분.SelectedIndex].code;

            // =================================================
            // 원주문번호 입력 여부

            if( n매매구분 > 2 && txt원주문번호.TextLength < 1 )
            {
                Logger(Log.에러, "원주문번호를 입력해주세요");
            }


            // =================================================
            // 주식주문
            int lRet;

            lRet = axKHOpenAPI.SendOrder("주식주문", GetScrNum(), cbo계좌.Text.Trim(), 
                                        n매매구분, txt주문종목코드.Text.Trim(), n주문수량, 
                                        n주문가격, s거래구분, txt원주문번호.Text.Trim());

            if( lRet == 0 )
            {
                Logger(Log.일반, "주문이 전송 되었습니다");
            }
            else
            {
                Logger(Log.에러, "주문이 전송 실패 하였습니다. [에러] : " + lRet);
            }
        }

        private void 주문ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn주문_Click(sender, e);
        }

        /// <summary>
        /// 자동거래 중지 버튼 클릭 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAutoRealAccountStop_Click_1(object sender, EventArgs e)
        {
            autoUpdateRealAccount(false);
        }

        /// <summary>
        /// 자동거래 시작 버튼 클릭 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAutoRealAccountStart_Click_1(object sender, EventArgs e)
        {
            autoUpdateRealAccount(true);
        }

        /// <summary>
        /// 실시간 잔고 시작/중지 지정
        /// </summary>
        /// <param name="flag"></param>
        public void autoUpdateRealAccount(bool flag)
        {
            if (flag)
            {
                Logger(Log.일반, "실시간 잔고 시작..!!");

                timerRealAccount.Start();

                ButtonAutoRealAccountStart.Enabled = false;
                ButtonAutoRealAccountStop.Enabled = true;
            }
            else
            {
                Logger(Log.일반, "실시간 잔고 중지..!!");

                timerRealAccount.Stop();

                ButtonAutoRealAccountStart.Enabled = true;
                ButtonAutoRealAccountStop.Enabled = false;
            }
        }

        /// <summary>
        /// 실시간 잔고 타이머 구동 이벤트 처리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRealAccount_tick(object sender, EventArgs e)
        {
            int ret = 0;

            axKHOpenAPI.SetInputValue("계좌번호", cbo계좌.Items[0].ToString());
            axKHOpenAPI.SetInputValue("비밀번호", "");
            axKHOpenAPI.SetInputValue("상장폐지조회구분", "0");
            axKHOpenAPI.SetInputValue("비밀번호입력매체구분", "00");
            ret = axKHOpenAPI.CommRqData("실시간잔고", "OPW00004", 0, "5100");
            if (ret == -201)
            {
                Logger(Log.에러, "실시간잔고 요청실패..!! " + ret);
                timerRealAccount.Stop();
                ButtonAutoRealAccountStart.Enabled = true;
                ButtonAutoRealAccountStop.Enabled = false;
                return;
            }
            
            axKHOpenAPI.SetInputValue("계좌번호", cbo계좌.Items[0].ToString());
            axKHOpenAPI.SetInputValue("비밀번호", "");
            axKHOpenAPI.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI.SetInputValue("조회구분", "1");
            axKHOpenAPI.CommRqData("계좌잔고평가", "opw00018", 0, "5101");

            axKHOpenAPI.SetInputValue("계좌번호", cbo계좌.Items[0].ToString());
            axKHOpenAPI.SetInputValue("시작일자", util_datetime.GetFormatNow("yyyyMMdd"));
            axKHOpenAPI.SetInputValue("종료일자", util_datetime.GetFormatNow("yyyyMMdd"));
            axKHOpenAPI.CommRqData("일자별실현손익", "OPT10074", 0, "5102");
        }	// end function

        private int mRealCondiInitTick = 0;
        /// <summary>
        /// 실시간 종목 검색 초기화 타이머 구동 이벤트 처리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRealCondiInit_Tick(object sender, EventArgs e)
        {
            mRealCondiInitTick++;

            // 1. 서버의 조건검색식을 임시 파일로 저장
            int ret = axKHOpenAPI.GetConditionLoad();
            if (mRealCondiInitTick > 1) 
            {
                // 2. 리스트를 가져옴
                String list = axKHOpenAPI.GetConditionNameList();
                Logger(Log.실시간, "조건검색식을 " + ret + " " + list);
                if (list.Length > 0)
                {
                    string[] arr실시간조건 = list.Split(';');
                    cboRealConditionL.Items.AddRange(arr실시간조건);
                    cboRealConditionL.SelectedIndex = 0;
                }

                timerRealCondiInit.Stop();

                ButtonAutoRealSearchStart.Enabled = true;
                ButtonAutoRealSearchStop.Enabled = false;
            }
        }

        /// <summary>
        /// 실시간 종목 검색 타이머 구동 이벤트 처리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRealSearch_Tick(object sender, EventArgs e)
        {
            String name = cboRealConditionL.Items[cboRealConditionL.SelectedIndex].ToString();
            String[] nameList = name.Split('^');
            if (nameList != null && nameList.Length > 1) 
            {
                int ret = axKHOpenAPI.SendCondition("5200", nameList[1], Convert.ToInt32(nameList[0]), 1);
                Logger(Log.실시간, "실시간 조건 검색식 리스트 결과:" + ret + " " + nameList[1]);
            }
            timerRealSearch.Stop();
            cboRealConditionL.Enabled = false;
        }

        private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mfSetting.Show();
        }

        // 화면번호 생산
        private string GetScrNum()
        {
            if (scrNum < 9999)
                scrNum++;
            else
                scrNum = 5000;

            return scrNum.ToString();
        }

        // 실시간 연결 종료
        private void DisconnectAllRealData()
        {
            for (int i = scrNum; i > 5000; i--)
            {
                axKHOpenAPI.DisconnectRealData(i.ToString());
            }

            scrNum = 5000;
        }

        /// <summary>
        /// 자동종목검색 시작 버튼 클릭 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAutoRealSearchStart_Click(object sender, EventArgs e)
        {
            autoUpdateRealSearch(true);
        }

        /// <summary>
        /// 자동종목검색 중지 버튼 클릭 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAutoRealSearchStop_Click(object sender, EventArgs e)
        {
            autoUpdateRealSearch(false);
        }

        /// <summary>
        /// 실시간 종목 시작/중지 지정
        /// </summary>
        /// <param name="flag"></param>
        public void autoUpdateRealSearch(bool flag)
        {
            if (flag)
            {
                Logger(Log.일반, "자동종목검색 시작..!!");

                timerRealSearch.Start();

                ButtonAutoRealSearchStart.Enabled = false;
                ButtonAutoRealSearchStop.Enabled = true;
            }
            else
            {
                Logger(Log.일반, "자동종목검색 중지..!!");

                ButtonAutoRealSearchStart.Enabled = true;
                ButtonAutoRealSearchStop.Enabled = false;

                String name = cboRealConditionL.Items[cboRealConditionL.SelectedIndex].ToString();
                String[] nameList = name.Split('^');
                if (nameList != null && nameList.Length > 1)
                {
                    axKHOpenAPI.SendConditionStop("5200", nameList[1], Convert.ToInt32(nameList[0]));
                    Logger(Log.실시간, "실시간 조건 검색식 리스트 중지 " + nameList[1]);
                }
                axKHOpenAPI.SetRealRemove("5201", "ALL");
                cboRealConditionL.Enabled = true;
            }
        }
    }
}
