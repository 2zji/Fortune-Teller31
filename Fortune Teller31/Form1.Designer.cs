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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상담내역불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.포춘텔러정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(70, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "생년월일을 입력하세요(ex:20010101)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "태어난 시각을 입력하세요(ex: 13시 04분 -> 1304)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbBrithday
            // 
            this.tbBrithday.Location = new System.Drawing.Point(43, 86);
            this.tbBrithday.Name = "tbBrithday";
            this.tbBrithday.Size = new System.Drawing.Size(273, 21);
            this.tbBrithday.TabIndex = 2;
            // 
            // tbBrithtime
            // 
            this.tbBrithtime.Location = new System.Drawing.Point(45, 216);
            this.tbBrithtime.Name = "tbBrithtime";
            this.tbBrithtime.Size = new System.Drawing.Size(271, 21);
            this.tbBrithtime.TabIndex = 3;
            // 
            // tbShowResult
            // 
            this.tbShowResult.Location = new System.Drawing.Point(72, 273);
            this.tbShowResult.Name = "tbShowResult";
            this.tbShowResult.Size = new System.Drawing.Size(203, 58);
            this.tbShowResult.TabIndex = 4;
            this.tbShowResult.Text = "사용자 결과 보기";
            this.tbShowResult.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(0, 20);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(420, 406);
            this.tbResult.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상담내역불러오기ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.포춘텔러정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 상담내역불러오기ToolStripMenuItem
            // 
            this.상담내역불러오기ToolStripMenuItem.Name = "상담내역불러오기ToolStripMenuItem";
            this.상담내역불러오기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.상담내역불러오기ToolStripMenuItem.Text = "내역 불러오기";
            this.상담내역불러오기ToolStripMenuItem.Click += new System.EventHandler(this.상담내역불러오기ToolStripMenuItem_Click);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 포춘텔러정보ToolStripMenuItem
            // 
            this.포춘텔러정보ToolStripMenuItem.Name = "포춘텔러정보ToolStripMenuItem";
            this.포춘텔러정보ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.포춘텔러정보ToolStripMenuItem.Text = "포춘텔러 정보";
            this.포춘텔러정보ToolStripMenuItem.Click += new System.EventHandler(this.포춘텔러정보ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "포춘텔러(3109윤예지)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상담내역불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 포춘텔러정보ToolStripMenuItem;
    }
}

