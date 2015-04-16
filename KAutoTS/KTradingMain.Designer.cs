namespace KAutoTS
{
    partial class KTradingMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KTradingMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.기본기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조회기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.현재가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.일봉데이터ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lst일반 = new System.Windows.Forms.ListBox();
            this.lbl일반 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl이름 = new System.Windows.Forms.Label();
            this.lbl아이디 = new System.Windows.Forms.Label();
            this.cbo계좌 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt종목코드 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt조회날짜 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn주문 = new System.Windows.Forms.Button();
            this.cbo매매구분 = new System.Windows.Forms.ComboBox();
            this.cbo거래구분 = new System.Windows.Forms.ComboBox();
            this.txt원주문번호 = new System.Windows.Forms.TextBox();
            this.txt주문가격 = new System.Windows.Forms.TextBox();
            this.txt주문수량 = new System.Windows.Forms.TextBox();
            this.txt주문종목코드 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.axKHOpenAPI = new AxKHOpenAPILib.AxKHOpenAPI();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.Text100 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TextSunamt1 = new System.Windows.Forms.TextBox();
            this.TextSunamt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TextMamt = new System.Windows.Forms.TextBox();
            this.TextTappamt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TextTdtsunik = new System.Windows.Forms.TextBox();
            this.TextDtsunik = new System.Windows.Forms.TextBox();
            this.ButtonAutoRealAccountStop = new System.Windows.Forms.Button();
            this.CheckSellAll = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TextRate = new System.Windows.Forms.TextBox();
            this.ButtonAutoRealAccountStart = new System.Windows.Forms.Button();
            this.GridAccount = new System.Windows.Forms.DataGridView();
            this.timerRealAccount = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기본기능ToolStripMenuItem,
            this.조회기능ToolStripMenuItem,
            this.주문기능ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(964, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // 기본기능ToolStripMenuItem
            // 
            this.기본기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.기본기능ToolStripMenuItem.Name = "기본기능ToolStripMenuItem";
            this.기본기능ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.기본기능ToolStripMenuItem.Text = "기본기능";
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.로그인ToolStripMenuItem.Text = "로그인";
            this.로그인ToolStripMenuItem.Click += new System.EventHandler(this.로그인ToolStripMenuItem_Click);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 조회기능ToolStripMenuItem
            // 
            this.조회기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.현재가ToolStripMenuItem,
            this.일봉데이터ToolStripMenuItem});
            this.조회기능ToolStripMenuItem.Name = "조회기능ToolStripMenuItem";
            this.조회기능ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.조회기능ToolStripMenuItem.Text = "조회기능";
            // 
            // 현재가ToolStripMenuItem
            // 
            this.현재가ToolStripMenuItem.Name = "현재가ToolStripMenuItem";
            this.현재가ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.현재가ToolStripMenuItem.Text = "현재가";
            this.현재가ToolStripMenuItem.Click += new System.EventHandler(this.현재가ToolStripMenuItem_Click);
            // 
            // 일봉데이터ToolStripMenuItem
            // 
            this.일봉데이터ToolStripMenuItem.Name = "일봉데이터ToolStripMenuItem";
            this.일봉데이터ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.일봉데이터ToolStripMenuItem.Text = "일봉데이터";
            this.일봉데이터ToolStripMenuItem.Click += new System.EventHandler(this.일봉데이터ToolStripMenuItem_Click);
            // 
            // 주문기능ToolStripMenuItem
            // 
            this.주문기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주문ToolStripMenuItem});
            this.주문기능ToolStripMenuItem.Name = "주문기능ToolStripMenuItem";
            this.주문기능ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.주문기능ToolStripMenuItem.Text = "주문기능";
            // 
            // 주문ToolStripMenuItem
            // 
            this.주문ToolStripMenuItem.Name = "주문ToolStripMenuItem";
            this.주문ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.주문ToolStripMenuItem.Text = "주문";
            this.주문ToolStripMenuItem.Click += new System.EventHandler(this.주문ToolStripMenuItem_Click);
            // 
            // lst일반
            // 
            this.lst일반.FormattingEnabled = true;
            this.lst일반.HorizontalScrollbar = true;
            this.lst일반.ItemHeight = 12;
            this.lst일반.Location = new System.Drawing.Point(281, 410);
            this.lst일반.Name = "lst일반";
            this.lst일반.Size = new System.Drawing.Size(267, 124);
            this.lst일반.TabIndex = 3;
            // 
            // lbl일반
            // 
            this.lbl일반.AutoSize = true;
            this.lbl일반.Location = new System.Drawing.Point(279, 395);
            this.lbl일반.Name = "lbl일반";
            this.lbl일반.Size = new System.Drawing.Size(29, 12);
            this.lbl일반.TabIndex = 6;
            this.lbl일반.Text = "로그";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 61);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 12);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "이름 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "아이디 : ";
            // 
            // lbl이름
            // 
            this.lbl이름.AutoSize = true;
            this.lbl이름.Location = new System.Drawing.Point(59, 61);
            this.lbl이름.Name = "lbl이름";
            this.lbl이름.Size = new System.Drawing.Size(0, 12);
            this.lbl이름.TabIndex = 14;
            // 
            // lbl아이디
            // 
            this.lbl아이디.AutoSize = true;
            this.lbl아이디.Location = new System.Drawing.Point(71, 87);
            this.lbl아이디.Name = "lbl아이디";
            this.lbl아이디.Size = new System.Drawing.Size(0, 12);
            this.lbl아이디.TabIndex = 15;
            // 
            // cbo계좌
            // 
            this.cbo계좌.FormattingEnabled = true;
            this.cbo계좌.Location = new System.Drawing.Point(82, 110);
            this.cbo계좌.Name = "cbo계좌";
            this.cbo계좌.Size = new System.Drawing.Size(121, 20);
            this.cbo계좌.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "계좌번호 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "종목코드 :";
            // 
            // txt종목코드
            // 
            this.txt종목코드.Location = new System.Drawing.Point(82, 136);
            this.txt종목코드.Name = "txt종목코드";
            this.txt종목코드.Size = new System.Drawing.Size(75, 21);
            this.txt종목코드.TabIndex = 19;
            this.txt종목코드.Text = "039490";
            this.txt종목코드.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt종목코드_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "조회날짜 (20141226)";
            // 
            // txt조회날짜
            // 
            this.txt조회날짜.Location = new System.Drawing.Point(131, 168);
            this.txt조회날짜.Name = "txt조회날짜";
            this.txt조회날짜.Size = new System.Drawing.Size(72, 21);
            this.txt조회날짜.TabIndex = 21;
            this.txt조회날짜.Text = "20150126";
            this.txt조회날짜.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt조회날짜_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn주문);
            this.groupBox1.Controls.Add(this.cbo매매구분);
            this.groupBox1.Controls.Add(this.cbo거래구분);
            this.groupBox1.Controls.Add(this.txt원주문번호);
            this.groupBox1.Controls.Add(this.txt주문가격);
            this.groupBox1.Controls.Add(this.txt주문수량);
            this.groupBox1.Controls.Add(this.txt주문종목코드);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(14, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 246);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주문입력";
            // 
            // btn주문
            // 
            this.btn주문.Location = new System.Drawing.Point(27, 197);
            this.btn주문.Name = "btn주문";
            this.btn주문.Size = new System.Drawing.Size(198, 30);
            this.btn주문.TabIndex = 12;
            this.btn주문.Text = "주     문";
            this.btn주문.UseVisualStyleBackColor = true;
            this.btn주문.Click += new System.EventHandler(this.btn주문_Click);
            // 
            // cbo매매구분
            // 
            this.cbo매매구분.FormattingEnabled = true;
            this.cbo매매구분.Location = new System.Drawing.Point(84, 78);
            this.cbo매매구분.Name = "cbo매매구분";
            this.cbo매매구분.Size = new System.Drawing.Size(141, 20);
            this.cbo매매구분.TabIndex = 11;
            // 
            // cbo거래구분
            // 
            this.cbo거래구분.FormattingEnabled = true;
            this.cbo거래구분.Location = new System.Drawing.Point(84, 47);
            this.cbo거래구분.Name = "cbo거래구분";
            this.cbo거래구분.Size = new System.Drawing.Size(141, 20);
            this.cbo거래구분.TabIndex = 10;
            // 
            // txt원주문번호
            // 
            this.txt원주문번호.Location = new System.Drawing.Point(84, 159);
            this.txt원주문번호.Name = "txt원주문번호";
            this.txt원주문번호.Size = new System.Drawing.Size(141, 21);
            this.txt원주문번호.TabIndex = 9;
            this.txt원주문번호.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt원주문번호_KeyPress);
            // 
            // txt주문가격
            // 
            this.txt주문가격.Location = new System.Drawing.Point(84, 134);
            this.txt주문가격.Name = "txt주문가격";
            this.txt주문가격.Size = new System.Drawing.Size(141, 21);
            this.txt주문가격.TabIndex = 8;
            this.txt주문가격.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt주문가격_KeyPress);
            // 
            // txt주문수량
            // 
            this.txt주문수량.Location = new System.Drawing.Point(84, 107);
            this.txt주문수량.Name = "txt주문수량";
            this.txt주문수량.Size = new System.Drawing.Size(141, 21);
            this.txt주문수량.TabIndex = 7;
            this.txt주문수량.Text = "10";
            this.txt주문수량.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt주문수량_KeyPress);
            // 
            // txt주문종목코드
            // 
            this.txt주문종목코드.Location = new System.Drawing.Point(84, 20);
            this.txt주문종목코드.Name = "txt주문종목코드";
            this.txt주문종목코드.Size = new System.Drawing.Size(141, 21);
            this.txt주문종목코드.TabIndex = 6;
            this.txt주문종목코드.Text = "039490";
            this.txt주문종목코드.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt주문종목코드_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "원주문번호";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "주문가격";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "주문수량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "매매구분";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "거래구분";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "종목코드";
            // 
            // axKHOpenAPI
            // 
            this.axKHOpenAPI.Enabled = true;
            this.axKHOpenAPI.Location = new System.Drawing.Point(12, 506);
            this.axKHOpenAPI.Name = "axKHOpenAPI";
            this.axKHOpenAPI.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI.OcxState")));
            this.axKHOpenAPI.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI.TabIndex = 11;
            this.axKHOpenAPI.TabStop = false;
            this.axKHOpenAPI.Visible = false;
            this.axKHOpenAPI.OnReceiveTrData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEventHandler(this.axKHOpenAPI_OnReceiveTrData);
            this.axKHOpenAPI.OnReceiveRealData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEventHandler(this.axKHOpenAPI_OnReceiveRealData);
            this.axKHOpenAPI.OnReceiveMsg += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveMsgEventHandler(this.axKHOpenAPI_OnReceiveMsg);
            this.axKHOpenAPI.OnReceiveChejanData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveChejanDataEventHandler(this.axKHOpenAPI_OnReceiveChejanData);
            this.axKHOpenAPI.OnEventConnect += new AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEventHandler(this.axKHOpenAPI_OnEventConnect);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel9);
            this.groupBox5.Location = new System.Drawing.Point(281, 47);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox5.Size = new System.Drawing.Size(674, 334);
            this.groupBox5.TabIndex = 63;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "실시간 계좌 관리 - 실시간 잔고";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.GridAccount, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 14);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(668, 317);
            this.tableLayoutPanel9.TabIndex = 102;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 10;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36781F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36782F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36782F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36782F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36782F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.08046F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.08046F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel7.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.Text100, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label21, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label16, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.TextSunamt1, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.TextSunamt, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.label18, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.label19, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.TextMamt, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.TextTappamt, 4, 1);
            this.tableLayoutPanel7.Controls.Add(this.label20, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.label17, 6, 0);
            this.tableLayoutPanel7.Controls.Add(this.TextTdtsunik, 5, 1);
            this.tableLayoutPanel7.Controls.Add(this.TextDtsunik, 6, 1);
            this.tableLayoutPanel7.Controls.Add(this.ButtonAutoRealAccountStop, 9, 1);
            this.tableLayoutPanel7.Controls.Add(this.CheckSellAll, 8, 0);
            this.tableLayoutPanel7.Controls.Add(this.label13, 7, 0);
            this.tableLayoutPanel7.Controls.Add(this.TextRate, 7, 1);
            this.tableLayoutPanel7.Controls.Add(this.ButtonAutoRealAccountStart, 9, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(668, 44);
            this.tableLayoutPanel7.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 109;
            this.label12.Text = "주문가능";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Text100
            // 
            this.Text100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text100.Location = new System.Drawing.Point(0, 22);
            this.Text100.Margin = new System.Windows.Forms.Padding(0);
            this.Text100.Name = "Text100";
            this.Text100.ReadOnly = true;
            this.Text100.Size = new System.Drawing.Size(66, 21);
            this.Text100.TabIndex = 112;
            this.Text100.Text = "0";
            this.Text100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(66, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 20);
            this.label21.TabIndex = 43;
            this.label21.Text = "예수금-D2";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(132, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "추정자산";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TextSunamt1
            // 
            this.TextSunamt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextSunamt1.Location = new System.Drawing.Point(66, 22);
            this.TextSunamt1.Margin = new System.Windows.Forms.Padding(0);
            this.TextSunamt1.Name = "TextSunamt1";
            this.TextSunamt1.ReadOnly = true;
            this.TextSunamt1.Size = new System.Drawing.Size(66, 21);
            this.TextSunamt1.TabIndex = 44;
            this.TextSunamt1.Text = "0";
            this.TextSunamt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextSunamt
            // 
            this.TextSunamt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextSunamt.Location = new System.Drawing.Point(132, 22);
            this.TextSunamt.Margin = new System.Windows.Forms.Padding(0);
            this.TextSunamt.Name = "TextSunamt";
            this.TextSunamt.ReadOnly = true;
            this.TextSunamt.Size = new System.Drawing.Size(66, 21);
            this.TextSunamt.TabIndex = 34;
            this.TextSunamt.Text = "0";
            this.TextSunamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(198, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 20);
            this.label18.TabIndex = 37;
            this.label18.Text = "총매입금액";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(264, 0);
            this.label19.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 20);
            this.label19.TabIndex = 39;
            this.label19.Text = "평가금액";
            this.label19.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TextMamt
            // 
            this.TextMamt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextMamt.Location = new System.Drawing.Point(198, 22);
            this.TextMamt.Margin = new System.Windows.Forms.Padding(0);
            this.TextMamt.Name = "TextMamt";
            this.TextMamt.ReadOnly = true;
            this.TextMamt.Size = new System.Drawing.Size(66, 21);
            this.TextMamt.TabIndex = 38;
            this.TextMamt.Text = "0";
            this.TextMamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextTappamt
            // 
            this.TextTappamt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextTappamt.Location = new System.Drawing.Point(264, 22);
            this.TextTappamt.Margin = new System.Windows.Forms.Padding(0);
            this.TextTappamt.Name = "TextTappamt";
            this.TextTappamt.ReadOnly = true;
            this.TextTappamt.Size = new System.Drawing.Size(66, 21);
            this.TextTappamt.TabIndex = 40;
            this.TextTappamt.Text = "0";
            this.TextTappamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(330, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 20);
            this.label20.TabIndex = 41;
            this.label20.Text = "평가손익";
            this.label20.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(395, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 20);
            this.label17.TabIndex = 35;
            this.label17.Text = "실현손익";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TextTdtsunik
            // 
            this.TextTdtsunik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextTdtsunik.Location = new System.Drawing.Point(330, 22);
            this.TextTdtsunik.Margin = new System.Windows.Forms.Padding(0);
            this.TextTdtsunik.Name = "TextTdtsunik";
            this.TextTdtsunik.ReadOnly = true;
            this.TextTdtsunik.Size = new System.Drawing.Size(65, 21);
            this.TextTdtsunik.TabIndex = 42;
            this.TextTdtsunik.Text = "0";
            this.TextTdtsunik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextDtsunik
            // 
            this.TextDtsunik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextDtsunik.Location = new System.Drawing.Point(395, 22);
            this.TextDtsunik.Margin = new System.Windows.Forms.Padding(0);
            this.TextDtsunik.Name = "TextDtsunik";
            this.TextDtsunik.ReadOnly = true;
            this.TextDtsunik.Size = new System.Drawing.Size(65, 21);
            this.TextDtsunik.TabIndex = 36;
            this.TextDtsunik.Text = "0";
            this.TextDtsunik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonAutoRealAccountStop
            // 
            this.ButtonAutoRealAccountStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAutoRealAccountStop.Enabled = false;
            this.ButtonAutoRealAccountStop.Location = new System.Drawing.Point(576, 22);
            this.ButtonAutoRealAccountStop.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAutoRealAccountStop.Name = "ButtonAutoRealAccountStop";
            this.ButtonAutoRealAccountStop.Size = new System.Drawing.Size(92, 20);
            this.ButtonAutoRealAccountStop.TabIndex = 53;
            this.ButtonAutoRealAccountStop.Text = "실.잔고Stop";
            this.ButtonAutoRealAccountStop.UseVisualStyleBackColor = true;
            this.ButtonAutoRealAccountStop.Click += new System.EventHandler(this.ButtonAutoRealAccountStop_Click_1);
            // 
            // CheckSellAll
            // 
            this.CheckSellAll.AutoSize = true;
            this.CheckSellAll.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CheckSellAll.Location = new System.Drawing.Point(512, 0);
            this.CheckSellAll.Margin = new System.Windows.Forms.Padding(0);
            this.CheckSellAll.Name = "CheckSellAll";
            this.tableLayoutPanel7.SetRowSpan(this.CheckSellAll, 2);
            this.CheckSellAll.Size = new System.Drawing.Size(33, 42);
            this.CheckSellAll.TabIndex = 95;
            this.CheckSellAll.Text = "일괄\r\n매도";
            this.CheckSellAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CheckSellAll.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(460, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 113;
            this.label13.Text = "손익율";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TextRate
            // 
            this.TextRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextRate.Location = new System.Drawing.Point(460, 22);
            this.TextRate.Margin = new System.Windows.Forms.Padding(0);
            this.TextRate.Name = "TextRate";
            this.TextRate.ReadOnly = true;
            this.TextRate.Size = new System.Drawing.Size(52, 21);
            this.TextRate.TabIndex = 114;
            this.TextRate.Text = "0";
            this.TextRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonAutoRealAccountStart
            // 
            this.ButtonAutoRealAccountStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAutoRealAccountStart.Location = new System.Drawing.Point(576, 0);
            this.ButtonAutoRealAccountStart.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAutoRealAccountStart.Name = "ButtonAutoRealAccountStart";
            this.ButtonAutoRealAccountStart.Size = new System.Drawing.Size(92, 20);
            this.ButtonAutoRealAccountStart.TabIndex = 54;
            this.ButtonAutoRealAccountStart.Text = "실.잔고Start";
            this.ButtonAutoRealAccountStart.UseVisualStyleBackColor = true;
            this.ButtonAutoRealAccountStart.Click += new System.EventHandler(this.ButtonAutoRealAccountStart_Click_1);
            // 
            // GridAccount
            // 
            this.GridAccount.AllowUserToAddRows = false;
            this.GridAccount.AllowUserToDeleteRows = false;
            this.GridAccount.AllowUserToResizeColumns = false;
            this.GridAccount.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.NullValue = null;
            this.GridAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.GridAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridAccount.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridAccount.Location = new System.Drawing.Point(0, 44);
            this.GridAccount.Margin = new System.Windows.Forms.Padding(0);
            this.GridAccount.MultiSelect = false;
            this.GridAccount.Name = "GridAccount";
            this.GridAccount.ReadOnly = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.GridAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridAccount.RowHeadersVisible = false;
            this.GridAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.NullValue = null;
            this.GridAccount.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GridAccount.RowTemplate.Height = 23;
            this.GridAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAccount.Size = new System.Drawing.Size(668, 273);
            this.GridAccount.TabIndex = 32;
            // 
            // timerRealAccount
            // 
            this.timerRealAccount.Interval = 1100;
            this.timerRealAccount.Tick += new System.EventHandler(this.timerRealAccount_tick);
            // 
            // KTradingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 550);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt조회날짜);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt종목코드);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo계좌);
            this.Controls.Add(this.lbl아이디);
            this.Controls.Add(this.lbl이름);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.axKHOpenAPI);
            this.Controls.Add(this.lbl일반);
            this.Controls.Add(this.lst일반);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "KTradingMain";
            this.Text = "키움 오픈 API C# 예제 ( www.sbcn.co.kr )";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 기본기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조회기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 현재가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 일봉데이터ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문ToolStripMenuItem;
        private System.Windows.Forms.ListBox lst일반;
        private System.Windows.Forms.Label lbl일반;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl이름;
        private System.Windows.Forms.Label lbl아이디;
        private System.Windows.Forms.ComboBox cbo계좌;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt종목코드;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt조회날짜;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo매매구분;
        private System.Windows.Forms.ComboBox cbo거래구분;
        private System.Windows.Forms.TextBox txt원주문번호;
        private System.Windows.Forms.TextBox txt주문가격;
        private System.Windows.Forms.TextBox txt주문수량;
        private System.Windows.Forms.TextBox txt주문종목코드;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn주문;
        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
        public System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox Text100;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox TextSunamt1;
        public System.Windows.Forms.TextBox TextSunamt;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox TextMamt;
        public System.Windows.Forms.TextBox TextTappamt;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox TextTdtsunik;
        public System.Windows.Forms.TextBox TextDtsunik;
        public System.Windows.Forms.Button ButtonAutoRealAccountStop;
        public System.Windows.Forms.CheckBox CheckSellAll;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox TextRate;
        public System.Windows.Forms.Button ButtonAutoRealAccountStart;
        public System.Windows.Forms.DataGridView GridAccount;
        private System.Windows.Forms.Timer timerRealAccount;
    }
}

