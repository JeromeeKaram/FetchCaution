namespace ExtractCautions
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
            btnFetchCaution = new Button();
            txtOutPutPath = new TextBox();
            btnBrowseOutputPath = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            cmbModule = new ComboBox();
            label3 = new Label();
            txtUrl = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            lblHeader = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnFetchCaution
            // 
            btnFetchCaution.BackColor = SystemColors.Highlight;
            btnFetchCaution.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFetchCaution.ForeColor = Color.White;
            btnFetchCaution.Location = new Point(329, 185);
            btnFetchCaution.Name = "btnFetchCaution";
            btnFetchCaution.Size = new Size(216, 34);
            btnFetchCaution.TabIndex = 1;
            btnFetchCaution.Text = "Fetch Cautions";
            btnFetchCaution.UseVisualStyleBackColor = false;
            btnFetchCaution.Click += btnFetchCaution_Click;
            // 
            // txtOutPutPath
            // 
            txtOutPutPath.Location = new Point(252, 155);
            txtOutPutPath.Name = "txtOutPutPath";
            txtOutPutPath.Size = new Size(469, 23);
            txtOutPutPath.TabIndex = 2;
            // 
            // btnBrowseOutputPath
            // 
            btnBrowseOutputPath.Location = new Point(727, 154);
            btnBrowseOutputPath.Name = "btnBrowseOutputPath";
            btnBrowseOutputPath.Size = new Size(75, 23);
            btnBrowseOutputPath.TabIndex = 3;
            btnBrowseOutputPath.Text = "Browse";
            btnBrowseOutputPath.UseVisualStyleBackColor = true;
            btnBrowseOutputPath.Click += btnBrowseOutputPath_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(80, 225);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(739, 23);
            progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label1.Location = new Point(73, 88);
            label1.Name = "label1";
            label1.Size = new Size(99, 14);
            label1.TabIndex = 5;
            label1.Text = "Select Module";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.Location = new Point(74, 159);
            label2.Name = "label2";
            label2.Size = new Size(164, 14);
            label2.TabIndex = 6;
            label2.Text = "Choose Output Location";
            // 
            // cmbModule
            // 
            cmbModule.FormattingEnabled = true;
            cmbModule.Location = new Point(252, 84);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(553, 23);
            cmbModule.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label3.Location = new Point(74, 122);
            label3.Name = "label3";
            label3.Size = new Size(173, 14);
            label3.TabIndex = 8;
            label3.Text = "Enter Engine Manual Link";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(252, 118);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(553, 23);
            txtUrl.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(844, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, helpToolStripMenuItem1 });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(107, 22);
            helpToolStripMenuItem1.Text = "Help";
            helpToolStripMenuItem1.Click += helpToolStripMenuItem1_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(164, 37);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(542, 26);
            lblHeader.TabIndex = 11;
            lblHeader.Text = "Extract Cautions From Engine Manual Tool";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ExtractCautions.Properties.Resources.IHI_Logo;
            pictureBox1.Location = new Point(2, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(844, 265);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeader);
            Controls.Add(txtUrl);
            Controls.Add(label3);
            Controls.Add(cmbModule);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(btnBrowseOutputPath);
            Controls.Add(txtOutPutPath);
            Controls.Add(btnFetchCaution);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Extract Cautions From Engine Manual Tool";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFetchCaution;
        private TextBox txtOutPutPath;
        private Button btnBrowseOutputPath;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private ComboBox cmbModule;
        private Label label3;
        private TextBox txtUrl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label lblHeader;
        private PictureBox pictureBox1;
        private ToolStripMenuItem helpToolStripMenuItem1;
    }
}
