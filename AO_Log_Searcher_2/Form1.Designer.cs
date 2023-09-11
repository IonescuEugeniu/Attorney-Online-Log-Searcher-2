namespace AO_Log_Searcher_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tb_mainPath = new TextBox();
            lb_mainPath = new Label();
            bt_mainPath = new Button();
            cb_clientList = new ComboBox();
            panel1 = new Panel();
            rtb_logOutput = new RichTextBox();
            bt_search = new Button();
            lb_terms = new Label();
            tb_terms = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_mainPath
            // 
            tb_mainPath.Location = new Point(25, 35);
            tb_mainPath.Name = "tb_mainPath";
            tb_mainPath.Size = new Size(300, 23);
            tb_mainPath.TabIndex = 0;
            tb_mainPath.TextChanged += tb_mainPath_TextChanged;
            // 
            // lb_mainPath
            // 
            lb_mainPath.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lb_mainPath.Location = new Point(0, 9);
            lb_mainPath.Name = "lb_mainPath";
            lb_mainPath.Size = new Size(350, 23);
            lb_mainPath.TabIndex = 1;
            lb_mainPath.Text = "Parent folder path:";
            lb_mainPath.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_mainPath
            // 
            bt_mainPath.Location = new Point(299, 36);
            bt_mainPath.Name = "bt_mainPath";
            bt_mainPath.Size = new Size(25, 21);
            bt_mainPath.TabIndex = 2;
            bt_mainPath.Text = "...";
            bt_mainPath.UseVisualStyleBackColor = true;
            bt_mainPath.Click += bt_mainPath_Click;
            // 
            // cb_clientList
            // 
            cb_clientList.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_clientList.FormattingEnabled = true;
            cb_clientList.Location = new Point(60, 64);
            cb_clientList.Name = "cb_clientList";
            cb_clientList.Size = new Size(230, 23);
            cb_clientList.TabIndex = 3;
            cb_clientList.KeyDown += cb_clientList_KeyDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(cb_clientList);
            panel1.Controls.Add(lb_mainPath);
            panel1.Controls.Add(bt_mainPath);
            panel1.Controls.Add(tb_mainPath);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 94);
            panel1.TabIndex = 4;
            // 
            // rtb_logOutput
            // 
            rtb_logOutput.Location = new Point(12, 122);
            rtb_logOutput.Name = "rtb_logOutput";
            rtb_logOutput.ReadOnly = true;
            rtb_logOutput.Size = new Size(326, 278);
            rtb_logOutput.TabIndex = 5;
            rtb_logOutput.Text = "";
            rtb_logOutput.DetectUrls = true;
            rtb_logOutput.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtb_logOutput_LinkClicked);
            // 
            // bt_search
            // 
            bt_search.Location = new Point(137, 406);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(76, 23);
            bt_search.TabIndex = 6;
            bt_search.Text = "Search";
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += bt_search_Click;
            // 
            // lb_terms
            // 
            lb_terms.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_terms.Location = new Point(60, 94);
            lb_terms.Name = "lb_terms";
            lb_terms.Size = new Size(41, 21);
            lb_terms.TabIndex = 7;
            lb_terms.Text = "Terms:";
            lb_terms.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_terms
            // 
            tb_terms.Location = new Point(101, 93);
            tb_terms.Name = "tb_terms";
            tb_terms.PlaceholderText = "; - split, ? - opt., ! - req.";
            tb_terms.Size = new Size(150, 23);
            tb_terms.TabIndex = 8;
            tb_terms.KeyDown += tb_terms_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 436);
            Controls.Add(lb_terms);
            Controls.Add(tb_terms);
            Controls.Add(bt_search);
            Controls.Add(rtb_logOutput);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(366, 475);
            MinimumSize = new Size(366, 475);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attorney Online: Log Searcher 2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_mainPath;
        private Label lb_mainPath;
        private Button bt_mainPath;
        private ComboBox cb_clientList;
        private Panel panel1;
        private RichTextBox rtb_logOutput;
        private Button bt_search;
        private Label lb_terms;
        private TextBox tb_terms;
    }
}