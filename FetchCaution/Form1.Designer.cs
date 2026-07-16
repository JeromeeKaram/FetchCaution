namespace FetchCaution
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
            txtUrl = new TextBox();
            btnFetchCaution = new Button();
            txtOutPutPath = new TextBox();
            btnBrowseOutputPath = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(12, 152);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(776, 23);
            txtUrl.TabIndex = 0;
            // 
            // btnFetchCaution
            // 
            btnFetchCaution.Location = new Point(293, 319);
            btnFetchCaution.Name = "btnFetchCaution";
            btnFetchCaution.Size = new Size(181, 23);
            btnFetchCaution.TabIndex = 1;
            btnFetchCaution.Text = "Fetch Caution";
            btnFetchCaution.UseVisualStyleBackColor = true;
            btnFetchCaution.Click += btnFetchCaution_Click;
            // 
            // txtOutPutPath
            // 
            txtOutPutPath.Location = new Point(12, 196);
            txtOutPutPath.Name = "txtOutPutPath";
            txtOutPutPath.Size = new Size(287, 23);
            txtOutPutPath.TabIndex = 2;
            // 
            // btnBrowseOutputPath
            // 
            btnBrowseOutputPath.Location = new Point(305, 198);
            btnBrowseOutputPath.Name = "btnBrowseOutputPath";
            btnBrowseOutputPath.Size = new Size(181, 23);
            btnBrowseOutputPath.TabIndex = 3;
            btnBrowseOutputPath.Text = "Browse";
            btnBrowseOutputPath.UseVisualStyleBackColor = true;
            btnBrowseOutputPath.Click += btnBrowseOutputPath_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 270);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 23);
            progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(btnBrowseOutputPath);
            Controls.Add(txtOutPutPath);
            Controls.Add(btnFetchCaution);
            Controls.Add(txtUrl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrl;
        private Button btnFetchCaution;
        private TextBox txtOutPutPath;
        private Button btnBrowseOutputPath;
        private ProgressBar progressBar1;
    }
}
