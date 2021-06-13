
namespace _84_QueueExample
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
            this.txtCounter1 = new System.Windows.Forms.TextBox();
            this.txtCounter2 = new System.Windows.Forms.TextBox();
            this.txtCounter3 = new System.Windows.Forms.TextBox();
            this.btnCounter1 = new System.Windows.Forms.Button();
            this.btnCounter2 = new System.Windows.Forms.Button();
            this.btnCounter3 = new System.Windows.Forms.Button();
            this.txtDispaly = new System.Windows.Forms.TextBox();
            this.listTokens = new System.Windows.Forms.ListBox();
            this.btnPrintToken = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCounter1
            // 
            this.txtCounter1.BackColor = System.Drawing.Color.Blue;
            this.txtCounter1.Location = new System.Drawing.Point(18, 43);
            this.txtCounter1.Name = "txtCounter1";
            this.txtCounter1.Size = new System.Drawing.Size(169, 23);
            this.txtCounter1.TabIndex = 0;
            // 
            // txtCounter2
            // 
            this.txtCounter2.BackColor = System.Drawing.Color.Blue;
            this.txtCounter2.Location = new System.Drawing.Point(204, 43);
            this.txtCounter2.Name = "txtCounter2";
            this.txtCounter2.Size = new System.Drawing.Size(169, 23);
            this.txtCounter2.TabIndex = 1;
            // 
            // txtCounter3
            // 
            this.txtCounter3.BackColor = System.Drawing.Color.Blue;
            this.txtCounter3.Location = new System.Drawing.Point(379, 43);
            this.txtCounter3.Name = "txtCounter3";
            this.txtCounter3.Size = new System.Drawing.Size(169, 23);
            this.txtCounter3.TabIndex = 2;
            // 
            // btnCounter1
            // 
            this.btnCounter1.Location = new System.Drawing.Point(47, 72);
            this.btnCounter1.Name = "btnCounter1";
            this.btnCounter1.Size = new System.Drawing.Size(111, 25);
            this.btnCounter1.TabIndex = 3;
            this.btnCounter1.Text = "Next";
            this.btnCounter1.UseVisualStyleBackColor = true;
            // 
            // btnCounter2
            // 
            this.btnCounter2.Location = new System.Drawing.Point(232, 72);
            this.btnCounter2.Name = "btnCounter2";
            this.btnCounter2.Size = new System.Drawing.Size(111, 25);
            this.btnCounter2.TabIndex = 4;
            this.btnCounter2.Text = "Next";
            this.btnCounter2.UseVisualStyleBackColor = true;
            // 
            // btnCounter3
            // 
            this.btnCounter3.Location = new System.Drawing.Point(406, 72);
            this.btnCounter3.Name = "btnCounter3";
            this.btnCounter3.Size = new System.Drawing.Size(111, 25);
            this.btnCounter3.TabIndex = 5;
            this.btnCounter3.Text = "Next";
            this.btnCounter3.UseVisualStyleBackColor = true;
            // 
            // txtDispaly
            // 
            this.txtDispaly.BackColor = System.Drawing.Color.Lime;
            this.txtDispaly.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDispaly.Location = new System.Drawing.Point(18, 108);
            this.txtDispaly.Name = "txtDispaly";
            this.txtDispaly.Size = new System.Drawing.Size(529, 23);
            this.txtDispaly.TabIndex = 6;
            // 
            // listTokens
            // 
            this.listTokens.FormattingEnabled = true;
            this.listTokens.ItemHeight = 15;
            this.listTokens.Location = new System.Drawing.Point(223, 137);
            this.listTokens.Name = "listTokens";
            this.listTokens.Size = new System.Drawing.Size(129, 124);
            this.listTokens.TabIndex = 7;
            // 
            // btnPrintToken
            // 
            this.btnPrintToken.Location = new System.Drawing.Point(229, 273);
            this.btnPrintToken.Name = "btnPrintToken";
            this.btnPrintToken.Size = new System.Drawing.Size(113, 30);
            this.btnPrintToken.TabIndex = 8;
            this.btnPrintToken.Text = "Print Token";
            this.btnPrintToken.UseVisualStyleBackColor = true;
            this.btnPrintToken.Click += new System.EventHandler(this.btnPrintToken_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Counter 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Counter 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Counter 3";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(263, 323);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 15);
            this.lblStatus.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintToken);
            this.Controls.Add(this.listTokens);
            this.Controls.Add(this.txtDispaly);
            this.Controls.Add(this.btnCounter3);
            this.Controls.Add(this.btnCounter2);
            this.Controls.Add(this.btnCounter1);
            this.Controls.Add(this.txtCounter3);
            this.Controls.Add(this.txtCounter2);
            this.Controls.Add(this.txtCounter1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCounter1;
        private System.Windows.Forms.TextBox txtCounter2;
        private System.Windows.Forms.TextBox txtCounter3;
        private System.Windows.Forms.Button btnCounter1;
        private System.Windows.Forms.Button btnCounter2;
        private System.Windows.Forms.Button btnCounter3;
        private System.Windows.Forms.TextBox txtDispaly;
        private System.Windows.Forms.ListBox listTokens;
        private System.Windows.Forms.Button btnPrintToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
    }
}

