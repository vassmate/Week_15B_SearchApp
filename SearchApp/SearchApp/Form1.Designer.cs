namespace SearchApp
{
    partial class Form1
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
            this.lstText = new System.Windows.Forms.ListBox();
            this.lstMatched = new System.Windows.Forms.ListBox();
            this.lblPattern = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblMatched = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstText
            // 
            this.lstText.FormattingEnabled = true;
            this.lstText.Location = new System.Drawing.Point(12, 34);
            this.lstText.Name = "lstText";
            this.lstText.Size = new System.Drawing.Size(290, 342);
            this.lstText.TabIndex = 0;
            // 
            // lstMatched
            // 
            this.lstMatched.FormattingEnabled = true;
            this.lstMatched.Location = new System.Drawing.Point(322, 34);
            this.lstMatched.Name = "lstMatched";
            this.lstMatched.Size = new System.Drawing.Size(290, 342);
            this.lstMatched.TabIndex = 1;
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(235, 411);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(41, 13);
            this.lblPattern.TabIndex = 2;
            this.lblPattern.Text = "Pattern";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(282, 408);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(249, 20);
            this.txtBox.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(537, 406);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 18);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "Text";
            // 
            // lblMatched
            // 
            this.lblMatched.AutoSize = true;
            this.lblMatched.Location = new System.Drawing.Point(319, 18);
            this.lblMatched.Name = "lblMatched";
            this.lblMatched.Size = new System.Drawing.Size(49, 13);
            this.lblMatched.TabIndex = 6;
            this.lblMatched.Text = "Matched";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblMatched);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.lstMatched);
            this.Controls.Add(this.lstText);
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstText;
        private System.Windows.Forms.ListBox lstMatched;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblMatched;
    }
}

