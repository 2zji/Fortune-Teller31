namespace Fortune_Teller31
{
    partial class FormHistory
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
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 12;
            this.lbHistory.Items.AddRange(new object[] {
            "2025-08-24 13:00:01 - 20071201 - 올해 귀인이 찾아와서 큰 도움을 줄 것임",
            "2025-08-24 13:00:01 - 20071201 - 올해 귀인이 찾아와서 큰 도움을 줄 것임",
            "2025-08-24 13:00:01 - 20071201 - 올해 귀인이 찾아와서 큰 도움을 줄 것임",
            "2025-08-24 13:00:01 - 20071201 - 올해 귀인이 찾아와서 큰 도움을 줄 것임",
            "2025-08-24 13:00:01 - 20071201 - 올해 귀인이 찾아와서 큰 도움을 줄 것임",
            "2025-08-24 13:00:01 - 20071201 - 올해 귀인이 찾아와서 큰 도움을 줄 것임"});
            this.lbHistory.Location = new System.Drawing.Point(12, 86);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(305, 352);
            this.lbHistory.TabIndex = 0;
            this.lbHistory.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(305, 58);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "버튼 다시 불러오기";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbHistory);
            this.Name = "FormHistory";
            this.Text = "내역 불러오기";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Button btnRefresh;
    }
}