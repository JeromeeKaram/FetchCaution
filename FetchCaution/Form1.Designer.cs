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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(200, 55);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(573, 23);
            txtUrl.TabIndex = 0;
            // 
            // btnFetchCaution
            // 
            btnFetchCaution.Location = new Point(592, 114);
            btnFetchCaution.Name = "btnFetchCaution";
            btnFetchCaution.Size = new Size(181, 23);
            btnFetchCaution.TabIndex = 1;
            btnFetchCaution.Text = "Fetch Cautions";
            btnFetchCaution.UseVisualStyleBackColor = true;
            btnFetchCaution.Click += btnFetchCaution_Click;
            // 
            // txtOutPutPath
            // 
            txtOutPutPath.Location = new Point(200, 84);
            txtOutPutPath.Name = "txtOutPutPath";
            txtOutPutPath.Size = new Size(386, 23);
            txtOutPutPath.TabIndex = 2;
            // 
            // btnBrowseOutputPath
            // 
            btnBrowseOutputPath.Location = new Point(592, 83);
            btnBrowseOutputPath.Name = "btnBrowseOutputPath";
            btnBrowseOutputPath.Size = new Size(181, 23);
            btnBrowseOutputPath.TabIndex = 3;
            btnBrowseOutputPath.Text = "Browse";
            btnBrowseOutputPath.UseVisualStyleBackColor = true;
            btnBrowseOutputPath.Click += btnBrowseOutputPath_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(34, 154);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(739, 23);
            progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 63);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 5;
            label1.Text = "Enter Cautions URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 92);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 6;
            label2.Text = "Choose Output Location";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 224);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
    }
}
