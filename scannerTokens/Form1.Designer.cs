namespace scannerTokens
{
    partial class tokens
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
            this.FileDataBox = new System.Windows.Forms.TextBox();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TokensButton = new System.Windows.Forms.Button();
            this.ScannerGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScannerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FileDataBox
            // 
            this.FileDataBox.Location = new System.Drawing.Point(26, 99);
            this.FileDataBox.Multiline = true;
            this.FileDataBox.Name = "FileDataBox";
            this.FileDataBox.Size = new System.Drawing.Size(277, 255);
            this.FileDataBox.TabIndex = 4;
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(111, 47);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(101, 46);
            this.loadFileButton.TabIndex = 5;
            this.loadFileButton.Text = "Load Code File";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please write here your code or you can upload the file.";
            // 
            // TokensButton
            // 
            this.TokensButton.Location = new System.Drawing.Point(58, 360);
            this.TokensButton.Name = "TokensButton";
            this.TokensButton.Size = new System.Drawing.Size(75, 23);
            this.TokensButton.TabIndex = 7;
            this.TokensButton.Text = "See Tokens";
            this.TokensButton.UseVisualStyleBackColor = true;
            this.TokensButton.Click += new System.EventHandler(this.TokensButton_Click);
            // 
            // ScannerGridView
            // 
            this.ScannerGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScannerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.ScannerGridView.Location = new System.Drawing.Point(309, 31);
            this.ScannerGridView.Name = "ScannerGridView";
            this.ScannerGridView.RowHeadersWidth = 30;
            this.ScannerGridView.Size = new System.Drawing.Size(542, 325);
            this.ScannerGridView.TabIndex = 8;
            this.ScannerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScannerGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Lexeme";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Token Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(172, 360);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 9;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // tokens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(863, 394);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.ScannerGridView);
            this.Controls.Add(this.TokensButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.FileDataBox);
            this.Name = "tokens";
            this.Text = "v";
            this.Load += new System.EventHandler(this.tokens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScannerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileDataBox;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TokensButton;
        private System.Windows.Forms.DataGridView ScannerGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button restart;
    }
}

