﻿namespace Client4
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
            this.MsgTxt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SendMsgBTN = new System.Windows.Forms.Button();
            this.IPTxt = new System.Windows.Forms.TextBox();
            this.InfoTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MsgTxt
            // 
            this.MsgTxt.Location = new System.Drawing.Point(188, 480);
            this.MsgTxt.Name = "MsgTxt";
            this.MsgTxt.ReadOnly = true;
            this.MsgTxt.Size = new System.Drawing.Size(670, 28);
            this.MsgTxt.TabIndex = 33;
            this.MsgTxt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Enter exit to DisConnect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "IP";
            // 
            // SendMsgBTN
            // 
            this.SendMsgBTN.Location = new System.Drawing.Point(639, 547);
            this.SendMsgBTN.Name = "SendMsgBTN";
            this.SendMsgBTN.Size = new System.Drawing.Size(173, 29);
            this.SendMsgBTN.TabIndex = 29;
            this.SendMsgBTN.Text = "Connect";
            this.SendMsgBTN.UseVisualStyleBackColor = true;
            this.SendMsgBTN.Click += new System.EventHandler(this.SendMsgBTN_Click);
            // 
            // IPTxt
            // 
            this.IPTxt.Location = new System.Drawing.Point(188, 23);
            this.IPTxt.Name = "IPTxt";
            this.IPTxt.ReadOnly = true;
            this.IPTxt.Size = new System.Drawing.Size(670, 27);
            this.IPTxt.TabIndex = 28;
            // 
            // InfoTxt
            // 
            this.InfoTxt.Location = new System.Drawing.Point(188, 86);
            this.InfoTxt.Name = "InfoTxt";
            this.InfoTxt.ReadOnly = true;
            this.InfoTxt.Size = new System.Drawing.Size(670, 367);
            this.InfoTxt.TabIndex = 27;
            this.InfoTxt.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 624);
            this.Controls.Add(this.MsgTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendMsgBTN);
            this.Controls.Add(this.IPTxt);
            this.Controls.Add(this.InfoTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox MsgTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button SendMsgBTN;
        private TextBox IPTxt;
        private RichTextBox InfoTxt;
    }
}