namespace Key1._0
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.암호1 = new System.Windows.Forms.TextBox();
            this.출력1 = new System.Windows.Forms.TextBox();
            this.암호화 = new System.Windows.Forms.Button();
            this.복호화 = new System.Windows.Forms.Button();
            this.출력2 = new System.Windows.Forms.TextBox();
            this.복호1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.진법1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.해독문1 = new System.Windows.Forms.TextBox();
            this.난독문1 = new System.Windows.Forms.TextBox();
            this.해독버튼1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // 암호1
            // 
            this.암호1.Location = new System.Drawing.Point(24, 32);
            this.암호1.Multiline = true;
            this.암호1.Name = "암호1";
            this.암호1.Size = new System.Drawing.Size(161, 97);
            this.암호1.TabIndex = 0;
            this.암호1.TextChanged += new System.EventHandler(this.암호1_TextChanged);
            // 
            // 출력1
            // 
            this.출력1.Location = new System.Drawing.Point(208, 32);
            this.출력1.Multiline = true;
            this.출력1.Name = "출력1";
            this.출력1.Size = new System.Drawing.Size(168, 97);
            this.출력1.TabIndex = 1;
            this.출력1.TextChanged += new System.EventHandler(this.출력1_TextChanged);
            // 
            // 암호화
            // 
            this.암호화.Location = new System.Drawing.Point(24, 135);
            this.암호화.Name = "암호화";
            this.암호화.Size = new System.Drawing.Size(161, 52);
            this.암호화.TabIndex = 2;
            this.암호화.Text = "암호화";
            this.암호화.UseVisualStyleBackColor = true;
            this.암호화.Click += new System.EventHandler(this.암호화_Click);
            // 
            // 복호화
            // 
            this.복호화.Location = new System.Drawing.Point(24, 357);
            this.복호화.Name = "복호화";
            this.복호화.Size = new System.Drawing.Size(161, 52);
            this.복호화.TabIndex = 3;
            this.복호화.Text = "복호화";
            this.복호화.UseVisualStyleBackColor = true;
            this.복호화.Click += new System.EventHandler(this.복호화_Click);
            // 
            // 출력2
            // 
            this.출력2.Location = new System.Drawing.Point(208, 254);
            this.출력2.Multiline = true;
            this.출력2.Name = "출력2";
            this.출력2.Size = new System.Drawing.Size(168, 97);
            this.출력2.TabIndex = 5;
            this.출력2.TextChanged += new System.EventHandler(this.출력2_TextChanged);
            // 
            // 복호1
            // 
            this.복호1.Location = new System.Drawing.Point(24, 254);
            this.복호1.Multiline = true;
            this.복호1.Name = "복호1";
            this.복호1.Size = new System.Drawing.Size(161, 97);
            this.복호1.TabIndex = 4;
            this.복호1.TextChanged += new System.EventHandler(this.복호1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "암호화할 문자열";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "출력값";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "복호화할 ASCII코드";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "출력값";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 97);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // 진법1
            // 
            this.진법1.Location = new System.Drawing.Point(423, 135);
            this.진법1.Name = "진법1";
            this.진법1.Size = new System.Drawing.Size(161, 52);
            this.진법1.TabIndex = 13;
            this.진법1.Text = "난독화";
            this.진법1.UseVisualStyleBackColor = true;
            this.진법1.Click += new System.EventHandler(this.진법1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(626, 32);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 97);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "변환할 ASCII코드";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(624, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "난독화";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // 해독문1
            // 
            this.해독문1.Location = new System.Drawing.Point(626, 254);
            this.해독문1.Multiline = true;
            this.해독문1.Name = "해독문1";
            this.해독문1.Size = new System.Drawing.Size(168, 97);
            this.해독문1.TabIndex = 18;
            this.해독문1.TextChanged += new System.EventHandler(this.해독문1_TextChanged);
            // 
            // 난독문1
            // 
            this.난독문1.Location = new System.Drawing.Point(423, 254);
            this.난독문1.Multiline = true;
            this.난독문1.Name = "난독문1";
            this.난독문1.Size = new System.Drawing.Size(168, 97);
            this.난독문1.TabIndex = 17;
            this.난독문1.TextChanged += new System.EventHandler(this.난독문1_TextChanged);
            // 
            // 해독버튼1
            // 
            this.해독버튼1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.해독버튼1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.해독버튼1.Location = new System.Drawing.Point(423, 357);
            this.해독버튼1.Name = "해독버튼1";
            this.해독버튼1.Size = new System.Drawing.Size(161, 52);
            this.해독버튼1.TabIndex = 19;
            this.해독버튼1.Text = "해독";
            this.해독버튼1.UseVisualStyleBackColor = false;
            this.해독버튼1.Click += new System.EventHandler(this.해독버튼1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "난독화된문장";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(624, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "해독";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 421);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.해독버튼1);
            this.Controls.Add(this.해독문1);
            this.Controls.Add(this.난독문1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.진법1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.출력2);
            this.Controls.Add(this.복호1);
            this.Controls.Add(this.복호화);
            this.Controls.Add(this.암호화);
            this.Controls.Add(this.출력1);
            this.Controls.Add(this.암호1);
            this.Name = "Form1";
            this.Text = "난독기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 암호1;
        private System.Windows.Forms.TextBox 출력1;
        private System.Windows.Forms.Button 암호화;
        private System.Windows.Forms.Button 복호화;
        private System.Windows.Forms.TextBox 출력2;
        private System.Windows.Forms.TextBox 복호1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button 진법1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button 해독버튼1;
        private System.Windows.Forms.TextBox 해독문1;
        private System.Windows.Forms.TextBox 난독문1;
    }
}

