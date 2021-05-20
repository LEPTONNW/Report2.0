namespace Report2._0
{
    partial class TV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TV));
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("굴림", 7.7F);
            this.button8.Location = new System.Drawing.Point(12, 115);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(162, 19);
            this.button8.TabIndex = 47;
            this.button8.Text = "STB메뉴설정방법문의";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("굴림", 7.7F);
            this.button7.Location = new System.Drawing.Point(13, 140);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(162, 20);
            this.button7.TabIndex = 46;
            this.button7.Text = "VOD장애";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 7.7F);
            this.button6.Location = new System.Drawing.Point(13, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 20);
            this.button6.TabIndex = 45;
            this.button6.Text = "STB부팅불량";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 7.7F);
            this.button5.Location = new System.Drawing.Point(13, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 20);
            this.button5.TabIndex = 44;
            this.button5.Text = "STB녹색/흑백화면";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 7.7F);
            this.button4.Location = new System.Drawing.Point(12, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 20);
            this.button4.TabIndex = 43;
            this.button4.Text = "STB전원불량";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 7.7F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 19);
            this.button1.TabIndex = 42;
            this.button1.Text = "TV입력신호없음장애";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 7.7F);
            this.button2.Location = new System.Drawing.Point(14, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 20);
            this.button2.TabIndex = 48;
            this.button2.Text = "tv소리안들림";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 199);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TV";
            this.Load += new System.EventHandler(this.TV_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}