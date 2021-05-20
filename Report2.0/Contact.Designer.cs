namespace Report2._0
{
    partial class Contact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "당사 무료전화번호 : 080-8282-106",
            "IVR트리 ",
            "1 - 0 (가입상담 연결)",
            "2 - 0 (기술상담 연결)",
            "4 - 0 (해약상담 연결)",
            "5 - 0 (일반상담 연결)",
            "",
            "기업기술 문의 080-8282-123 (1600-0108)",
            "",
            "SK텔레콤 080-011-6000 (1599-0011)",
            "",
            "재판매(SKT유선) 080-816-2000",
            "",
            "SK텔레시스 1566-8102 (  IF전화기 교체 & 수리 )",
            "",
            "모임스톤 1566-6476",
            "",
            "ip공유서비스 담당부서 1600-1637",
            "",
            "PC장애부서 1566-6015",
            "",
            "금영 노래방 02-6390-2435",
            "",
            "질러 노래방(테진) 080-665-3333",
            "",
            "SK텔링크 국제전화 1599-00700 (080-890-0700)",
            "",
            "SK텔링크 알뜰폰 1599-0999 (080-899-0999)",
            "",
            "뮤직링 080-7777-106",
            "",
            "다산네트웍스(AP) 1588-7080",
            "",
            "한양디지텍(AP) 02-3497-4500",
            "",
            "머큐리(AP) 080-002-0030",
            "",
            "디링크(AP) 1899-3540",
            "",
            "삼성전자 1588-3366",
            "",
            "VIP PC케어 1566-6036",
            "",
            "PC방서비스 1600-7200",
            "",
            "노턴플러스 1566-6200",
            "",
            "가디언 080-8282-101",
            "",
            "개인정보지킴이 031-8092-3778",
            "",
            "TG삼보 1588-3582",
            "",
            "주연테크 1588-1118",
            "",
            "DELL 080-850-5050",
            "",
            "HP 1588-3003",
            "",
            "LG전자 1544-7777",
            "",
            "다보링크(모뎀) 031-387-3240",
            "",
            "ATM 유니(WPS-6000) 1600-9742 (AS불가)",
            "",
            "ATM 다산(H535검정) 1566-6745",
            "",
            "iptime(아이피타임) 1544-8695",
            "",
            "리모컨서비스 1560",
            "",
            "농협070 1544-2110",
            "",
            "PC원스톱 1566-0660",
            "",
            "B세이버 1566-1428",
            "",
            "B클린 1566-0846",
            "",
            "우리아이 1566-6030",
            "",
            "스쿨케어 1600-2277",
            "",
            "마이캠(SME소기업 네트워크) 1600-9150",
            "",
            "T브로드 1877-7000",
            "",
            "KT 100",
            "",
            "LG U+ 101",
            "",
            "LG U+(무선) 1544-0010",
            "",
            "SKT(무선) 1599-0011",
            "",
            "사이버테러대응센터 182",
            "",
            "기업회선 1600-0108 (080-8282-123)",
            "",
            "매스 다회선(상품M) 1600-7200"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(394, 244);
            this.listBox1.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(12, 262);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(233, 21);
            this.txt_search.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(251, 262);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(150, 44);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Aqua;
            this.label_status.Location = new System.Drawing.Point(12, 294);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(45, 12);
            this.label_status.TabIndex = 3;
            this.label_status.Text = "상    태";
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 343);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.listBox1);
            this.Name = "Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.Contact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label_status;
    }
}