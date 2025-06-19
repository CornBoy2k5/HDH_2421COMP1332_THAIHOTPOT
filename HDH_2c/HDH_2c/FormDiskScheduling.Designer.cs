namespace HDH_2c
{
    partial class FormDiskScheduling
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
            this.btnFCFS = new System.Windows.Forms.Button();
            this.btnSSTF = new System.Windows.Forms.Button();
            this.btnCSCAN = new System.Windows.Forms.Button();
            this.btnSCAN = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHeadPosition = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequestSequence = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disk Scheduling Algorithms";
            // 
            // btnFCFS
            // 
            this.btnFCFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFCFS.Location = new System.Drawing.Point(23, 113);
            this.btnFCFS.Name = "btnFCFS";
            this.btnFCFS.Size = new System.Drawing.Size(241, 190);
            this.btnFCFS.TabIndex = 1;
            this.btnFCFS.Text = "FCFS";
            this.btnFCFS.UseVisualStyleBackColor = true;
            this.btnFCFS.Click += new System.EventHandler(this.btnFCFS_Click);
            this.btnFCFS.MouseEnter += new System.EventHandler(this.btnFCFS_MouseEnter);
            this.btnFCFS.MouseLeave += new System.EventHandler(this.btnFCFS_MouseLeave);
            // 
            // btnSSTF
            // 
            this.btnSSTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSTF.Location = new System.Drawing.Point(341, 113);
            this.btnSSTF.Name = "btnSSTF";
            this.btnSSTF.Size = new System.Drawing.Size(241, 190);
            this.btnSSTF.TabIndex = 2;
            this.btnSSTF.Text = "SSTF";
            this.btnSSTF.UseVisualStyleBackColor = true;
            this.btnSSTF.Click += new System.EventHandler(this.btnSSTF_Click);
            this.btnSSTF.MouseEnter += new System.EventHandler(this.btnSSTF_MouseEnter);
            this.btnSSTF.MouseLeave += new System.EventHandler(this.btnSSTF_MouseLeave);
            // 
            // btnCSCAN
            // 
            this.btnCSCAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSCAN.Location = new System.Drawing.Point(985, 113);
            this.btnCSCAN.Name = "btnCSCAN";
            this.btnCSCAN.Size = new System.Drawing.Size(241, 190);
            this.btnCSCAN.TabIndex = 4;
            this.btnCSCAN.Text = "C-SCAN";
            this.btnCSCAN.UseVisualStyleBackColor = true;
            this.btnCSCAN.Click += new System.EventHandler(this.btnCSCAN_Click);
            this.btnCSCAN.MouseEnter += new System.EventHandler(this.btnCSCAN_MouseEnter);
            this.btnCSCAN.MouseLeave += new System.EventHandler(this.btnCSCAN_MouseLeave);
            // 
            // btnSCAN
            // 
            this.btnSCAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCAN.Location = new System.Drawing.Point(657, 113);
            this.btnSCAN.Name = "btnSCAN";
            this.btnSCAN.Size = new System.Drawing.Size(241, 190);
            this.btnSCAN.TabIndex = 5;
            this.btnSCAN.Text = "SCAN";
            this.btnSCAN.UseVisualStyleBackColor = true;
            this.btnSCAN.Click += new System.EventHandler(this.btnSCAN_Click);
            this.btnSCAN.MouseEnter += new System.EventHandler(this.btnSCAN_MouseEnter);
            this.btnSCAN.MouseLeave += new System.EventHandler(this.btnSCAN_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(74, 812);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(190, 76);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFCFS);
            this.groupBox1.Controls.Add(this.btnSCAN);
            this.groupBox1.Controls.Add(this.btnCSCAN);
            this.groupBox1.Controls.Add(this.btnSSTF);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(75, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1304, 366);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn thuật toán";
            // 
            // txtHeadPosition
            // 
            this.txtHeadPosition.Location = new System.Drawing.Point(496, 182);
            this.txtHeadPosition.Name = "txtHeadPosition";
            this.txtHeadPosition.Size = new System.Drawing.Size(146, 31);
            this.txtHeadPosition.TabIndex = 8;
            this.txtHeadPosition.Text = "53";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(74, 182);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(303, 37);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Nhập Head Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Request Sequence";
            // 
            // txtRequestSequence
            // 
            this.txtRequestSequence.Location = new System.Drawing.Point(496, 235);
            this.txtRequestSequence.Name = "txtRequestSequence";
            this.txtRequestSequence.Size = new System.Drawing.Size(605, 31);
            this.txtRequestSequence.TabIndex = 11;
            this.txtRequestSequence.Text = "98 183 37 122 14 124 65 67";
            // 
            // FormDiskScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 937);
            this.Controls.Add(this.txtRequestSequence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtHeadPosition);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "FormDiskScheduling";
            this.Text = "FormDiskScheduling";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFCFS;
        private System.Windows.Forms.Button btnSSTF;
        private System.Windows.Forms.Button btnCSCAN;
        private System.Windows.Forms.Button btnSCAN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHeadPosition;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequestSequence;
    }
}