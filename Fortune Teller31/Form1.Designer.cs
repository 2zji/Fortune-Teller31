namespace Fortune_Teller31
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBrithday = new System.Windows.Forms.TextBox();
            this.tbBrithtime = new System.Windows.Forms.TextBox();
            this.tbShowResult = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbShowResult);
            this.groupBox1.Controls.Add(this.tbBrithtime);
            this.groupBox1.Controls.Add(this.tbBrithday);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 입력";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbResult);
            this.groupBox2.Location = new System.Drawing.Point(368, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 406);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사주 결과";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "생년월일을 입력하세요(ex:20010101)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "태어난 시각을 입력하세요(ex: 13시 04분 -> 1304)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbBrithday
            // 
            this.tbBrithday.Location = new System.Drawing.Point(43, 128);
            this.tbBrithday.Name = "tbBrithday";
            this.tbBrithday.Size = new System.Drawing.Size(273, 21);
            this.tbBrithday.TabIndex = 2;
            // 
            // tbBrithtime
            // 
            this.tbBrithtime.Location = new System.Drawing.Point(45, 258);
            this.tbBrithtime.Name = "tbBrithtime";
            this.tbBrithtime.Size = new System.Drawing.Size(271, 21);
            this.tbBrithtime.TabIndex = 3;
            // 
            // tbShowResult
            // 
            this.tbShowResult.Location = new System.Drawing.Point(72, 315);
            this.tbShowResult.Name = "tbShowResult";
            this.tbShowResult.Size = new System.Drawing.Size(203, 58);
            this.tbShowResult.TabIndex = 4;
            this.tbShowResult.Text = "사용자 결과 보기";
            this.tbShowResult.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(0, 44);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(420, 382);
            this.tbResult.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "포춘텔";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBrithtime;
        private System.Windows.Forms.TextBox tbBrithday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tbShowResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

