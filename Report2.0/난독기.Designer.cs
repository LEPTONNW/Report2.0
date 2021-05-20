namespace Report2._0
{
    partial class 난독기
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
            this.label10 = new System.Windows.Forms.Label();
            this.해독버튼1 = new System.Windows.Forms.Button();
            this.해독문1 = new System.Windows.Forms.TextBox();
            this.난독문1 = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.진법1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.출력2 = new System.Windows.Forms.TextBox();
            this.복호1 = new System.Windows.Forms.TextBox();
            this.복호화 = new System.Windows.Forms.Button();
            this.암호화 = new System.Windows.Forms.Button();
            this.출력1 = new System.Windows.Forms.TextBox();
            this.암호1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(612, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 43;
            this.label10.Text = "해독";
            // 
            // 해독버튼1
            // 
            this.해독버튼1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.해독버튼1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.해독버튼1.Location = new System.Drawing.Point(411, 350);
            this.해독버튼1.Name = "해독버튼1";
            this.해독버튼1.Size = new System.Drawing.Size(161, 52);
            this.해독버튼1.TabIndex = 41;
            this.해독버튼1.Text = "해독";
            this.해독버튼1.UseVisualStyleBackColor = false;
            this.해독버튼1.Click += new System.EventHandler(this.해독버튼1_Click);
            // 
            // 해독문1
            // 
            this.해독문1.Location = new System.Drawing.Point(614, 247);
            this.해독문1.Multiline = true;
            this.해독문1.Name = "해독문1";
            this.해독문1.Size = new System.Drawing.Size(168, 97);
            this.해독문1.TabIndex = 40;
            // 
            // 난독문1
            // 
            this.난독문1.Location = new System.Drawing.Point(411, 247);
            this.난독문1.Multiline = true;
            this.난독문1.Name = "난독문1";
            this.난독문1.Size = new System.Drawing.Size(168, 97);
            this.난독문1.TabIndex = 39;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 42;
            this.label9.Text = "난독화된문장";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "난독화";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = "변환할 ASCII코드";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(614, 25);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 97);
            this.textBox2.TabIndex = 36;
            // 
            // 진법1
            // 
            this.진법1.Location = new System.Drawing.Point(411, 128);
            this.진법1.Name = "진법1";
            this.진법1.Size = new System.Drawing.Size(161, 52);
            this.진법1.TabIndex = 35;
            this.진법1.Text = "난독";
            this.진법1.UseVisualStyleBackColor = true;
            this.진법1.Click += new System.EventHandler(this.진법1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 97);
            this.textBox1.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "출력값";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "복호화할 ASCII코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "출력값";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "암호화할 문자열";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "=";
            // 
            // 출력2
            // 
            this.출력2.Location = new System.Drawing.Point(196, 247);
            this.출력2.Multiline = true;
            this.출력2.Name = "출력2";
            this.출력2.Size = new System.Drawing.Size(168, 97);
            this.출력2.TabIndex = 27;
            // 
            // 복호1
            // 
            this.복호1.Location = new System.Drawing.Point(12, 247);
            this.복호1.Multiline = true;
            this.복호1.Name = "복호1";
            this.복호1.Size = new System.Drawing.Size(161, 97);
            this.복호1.TabIndex = 26;
            // 
            // 복호화
            // 
            this.복호화.Location = new System.Drawing.Point(12, 350);
            this.복호화.Name = "복호화";
            this.복호화.Size = new System.Drawing.Size(161, 52);
            this.복호화.TabIndex = 25;
            this.복호화.Text = "ASCII -> Char";
            this.복호화.UseVisualStyleBackColor = true;
            this.복호화.Click += new System.EventHandler(this.복호화_Click);
            // 
            // 암호화
            // 
            this.암호화.Location = new System.Drawing.Point(12, 128);
            this.암호화.Name = "암호화";
            this.암호화.Size = new System.Drawing.Size(161, 52);
            this.암호화.TabIndex = 24;
            this.암호화.Text = "Char -> ASCII";
            this.암호화.UseVisualStyleBackColor = true;
            this.암호화.Click += new System.EventHandler(this.암호화_Click);
            // 
            // 출력1
            // 
            this.출력1.Location = new System.Drawing.Point(196, 25);
            this.출력1.Multiline = true;
            this.출력1.Name = "출력1";
            this.출력1.Size = new System.Drawing.Size(168, 97);
            this.출력1.TabIndex = 23;
            // 
            // 암호1
            // 
            this.암호1.Location = new System.Drawing.Point(12, 25);
            this.암호1.Multiline = true;
            this.암호1.Name = "암호1";
            this.암호1.Size = new System.Drawing.Size(161, 97);
            this.암호1.TabIndex = 22;
            // 
            // 난독기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 418);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.해독버튼1);
            this.Controls.Add(this.해독문1);
            this.Controls.Add(this.난독문1);
            this.Controls.Add(this.label9);
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
            this.Name = "난독기";
            this.Text = "난독기";
            this.Load += new System.EventHandler(this.난독기_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button 해독버튼1;
        private System.Windows.Forms.TextBox 해독문1;
        private System.Windows.Forms.TextBox 난독문1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button 진법1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 출력2;
        private System.Windows.Forms.TextBox 복호1;
        private System.Windows.Forms.Button 복호화;
        private System.Windows.Forms.Button 암호화;
        private System.Windows.Forms.TextBox 출력1;
        private System.Windows.Forms.TextBox 암호1;
    }
}