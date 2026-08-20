using System.Drawing;
using System.Windows.Forms;

namespace ExtractCautionsForEM.About
{
    partial class UIAbout
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grbContactDet = new System.Windows.Forms.GroupBox();
            this.tbOffshoreMail = new System.Windows.Forms.TextBox();
            this.tbOnsiteMail = new System.Windows.Forms.TextBox();
            this.tbIHIMail = new System.Windows.Forms.TextBox();
            this.lbOffshoreContact = new System.Windows.Forms.Label();
            this.lbOnsiteContact = new System.Windows.Forms.Label();
            this.lblHIContact = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grbContactDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic);
            this.panel1.Location = new System.Drawing.Point(4, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 70);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(5, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(583, 59);
            this.label3.TabIndex = 9;
            this.label3.Text = "The primary purpose of this tool is to extract Cautions from Engine Manual, Engin" +
    "e Manual (CIR), SP 72-35 (EM && CIR), SP 72-51(EM && CIR). ";
            // 
            // grbContactDet
            // 
            this.grbContactDet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbContactDet.Controls.Add(this.tbOffshoreMail);
            this.grbContactDet.Controls.Add(this.tbOnsiteMail);
            this.grbContactDet.Controls.Add(this.tbIHIMail);
            this.grbContactDet.Controls.Add(this.lbOffshoreContact);
            this.grbContactDet.Controls.Add(this.lbOnsiteContact);
            this.grbContactDet.Controls.Add(this.lblHIContact);
            this.grbContactDet.Controls.Add(this.label2);
            this.grbContactDet.Controls.Add(this.label1);
            this.grbContactDet.Controls.Add(this.lbContact);
            this.grbContactDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.grbContactDet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
            this.grbContactDet.Location = new System.Drawing.Point(4, 107);
            this.grbContactDet.Name = "grbContactDet";
            this.grbContactDet.Size = new System.Drawing.Size(592, 121);
            this.grbContactDet.TabIndex = 1;
            this.grbContactDet.TabStop = false;
            this.grbContactDet.Text = "Contact details";
            // 
            // tbOffshoreMail
            // 
            this.tbOffshoreMail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbOffshoreMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOffshoreMail.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Underline);
            this.tbOffshoreMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
            this.tbOffshoreMail.Location = new System.Drawing.Point(332, 93);
            this.tbOffshoreMail.Name = "tbOffshoreMail";
            this.tbOffshoreMail.Size = new System.Drawing.Size(185, 13);
            this.tbOffshoreMail.TabIndex = 11;
            this.tbOffshoreMail.Text = "Veerendra.Kotari@cyient.com";
            // 
            // tbOnsiteMail
            // 
            this.tbOnsiteMail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbOnsiteMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOnsiteMail.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Underline);
            this.tbOnsiteMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
            this.tbOnsiteMail.Location = new System.Drawing.Point(332, 61);
            this.tbOnsiteMail.Name = "tbOnsiteMail";
            this.tbOnsiteMail.Size = new System.Drawing.Size(185, 13);
            this.tbOnsiteMail.TabIndex = 10;
            this.tbOnsiteMail.Text = "prakash7808@ihi-g.com";
            // 
            // tbIHIMail
            // 
            this.tbIHIMail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbIHIMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIHIMail.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Underline);
            this.tbIHIMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
            this.tbIHIMail.Location = new System.Drawing.Point(332, 28);
            this.tbIHIMail.Name = "tbIHIMail";
            this.tbIHIMail.Size = new System.Drawing.Size(185, 13);
            this.tbIHIMail.TabIndex = 9;
            this.tbIHIMail.Text = "ito0114@ihi-g.com";
            // 
            // lbOffshoreContact
            // 
            this.lbOffshoreContact.AutoSize = true;
            this.lbOffshoreContact.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOffshoreContact.Location = new System.Drawing.Point(153, 92);
            this.lbOffshoreContact.Name = "lbOffshoreContact";
            this.lbOffshoreContact.Size = new System.Drawing.Size(119, 14);
            this.lbOffshoreContact.TabIndex = 5;
            this.lbOffshoreContact.Text = "Veerendra Kotari";
            // 
            // lbOnsiteContact
            // 
            this.lbOnsiteContact.AutoSize = true;
            this.lbOnsiteContact.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOnsiteContact.Location = new System.Drawing.Point(153, 60);
            this.lbOnsiteContact.Name = "lbOnsiteContact";
            this.lbOnsiteContact.Size = new System.Drawing.Size(98, 14);
            this.lbOnsiteContact.TabIndex = 4;
            this.lbOnsiteContact.Text = "Suraj Prakash";
            // 
            // lblHIContact
            // 
            this.lblHIContact.AutoSize = true;
            this.lblHIContact.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHIContact.Location = new System.Drawing.Point(153, 28);
            this.lblHIContact.Name = "lblHIContact";
            this.lblHIContact.Size = new System.Drawing.Size(112, 14);
            this.lblHIContact.TabIndex = 3;
            this.lblHIContact.Text = "Tatsuya Ito San";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "CYIENT Offshore";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "CYIENT Onsite";
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.Location = new System.Drawing.Point(16, 28);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(28, 14);
            this.lbContact.TabIndex = 0;
            this.lbContact.Text = "IHI";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(504, 237);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(92, 32);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbVersion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
            this.lbVersion.Location = new System.Drawing.Point(8, 9);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(52, 14);
            this.lbVersion.TabIndex = 57;
            this.lbVersion.Text = "Version";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
            this.lbDate.Location = new System.Drawing.Point(122, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(35, 14);
            this.lbDate.TabIndex = 58;
            this.lbDate.Text = "Date";
            // 
            // UIAbout
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 278);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.grbContactDet);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIAbout";
            this.ShowInTaskbar = false;
            this.Text = "Fetch Cautions V1.0";
            this.Load += new System.EventHandler(this.UIAbout_Load);
            this.panel1.ResumeLayout(false);
            this.grbContactDet.ResumeLayout(false);
            this.grbContactDet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbContactDet;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbOffshoreContact;
        private System.Windows.Forms.Label lbOnsiteContact;
        private System.Windows.Forms.Label lblHIContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIHIMail;
        private System.Windows.Forms.TextBox tbOffshoreMail;
        private System.Windows.Forms.TextBox tbOnsiteMail;
    }
}