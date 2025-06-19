namespace HDH_2c
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBanker = new System.Windows.Forms.Button();
            this.btnCPUScheduling = new System.Windows.Forms.Button();
            this.btnPFSR = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDiskScheduling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operating System";
            // 
            // btnBanker
            // 
            this.btnBanker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanker.Location = new System.Drawing.Point(42, 275);
            this.btnBanker.Name = "btnBanker";
            this.btnBanker.Size = new System.Drawing.Size(300, 253);
            this.btnBanker.TabIndex = 1;
            this.btnBanker.Text = "Banker\'s Algorithm";
            this.btnBanker.UseVisualStyleBackColor = true;
            this.btnBanker.Click += new System.EventHandler(this.btnBanker_Click);
            // 
            // btnCPUScheduling
            // 
            this.btnCPUScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPUScheduling.Location = new System.Drawing.Point(433, 275);
            this.btnCPUScheduling.Name = "btnCPUScheduling";
            this.btnCPUScheduling.Size = new System.Drawing.Size(300, 253);
            this.btnCPUScheduling.TabIndex = 2;
            this.btnCPUScheduling.Text = "CPU Scheduling";
            this.btnCPUScheduling.UseVisualStyleBackColor = true;
            this.btnCPUScheduling.Click += new System.EventHandler(this.btnCPUScheduling_Click);
            // 
            // btnPFSR
            // 
            this.btnPFSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPFSR.Location = new System.Drawing.Point(819, 275);
            this.btnPFSR.Name = "btnPFSR";
            this.btnPFSR.Size = new System.Drawing.Size(292, 253);
            this.btnPFSR.TabIndex = 3;
            this.btnPFSR.Text = "PFSR";
            this.btnPFSR.UseVisualStyleBackColor = true;
            this.btnPFSR.Click += new System.EventHandler(this.btnPFSR_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.Location = new System.Drawing.Point(1182, 730);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(268, 111);
            this.btnAboutUs.TabIndex = 5;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(76, 752);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 89);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDiskScheduling
            // 
            this.btnDiskScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiskScheduling.Location = new System.Drawing.Point(1158, 275);
            this.btnDiskScheduling.Name = "btnDiskScheduling";
            this.btnDiskScheduling.Size = new System.Drawing.Size(292, 253);
            this.btnDiskScheduling.TabIndex = 7;
            this.btnDiskScheduling.Text = "Disk Scheduling";
            this.btnDiskScheduling.UseVisualStyleBackColor = true;
            this.btnDiskScheduling.Click += new System.EventHandler(this.btnDiskScheduling_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 889);
            this.Controls.Add(this.btnDiskScheduling);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.btnPFSR);
            this.Controls.Add(this.btnCPUScheduling);
            this.Controls.Add(this.btnBanker);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "THAIHOTPOT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBanker;
        private System.Windows.Forms.Button btnCPUScheduling;
        private System.Windows.Forms.Button btnPFSR;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDiskScheduling;
    }
}

