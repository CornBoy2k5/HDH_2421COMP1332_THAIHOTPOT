namespace HDH_2c
{
    partial class FormPFSR
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrameCapacity = new System.Windows.Forms.TextBox();
            this.txtPageSequence = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOPT = new System.Windows.Forms.Button();
            this.btnLRU = new System.Windows.Forms.Button();
            this.btnFIFO = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "PFSR Simulation";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(80, 849);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(157, 84);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số frame trống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chuỗi tham chiếu trang nhớ";
            // 
            // txtFrameCapacity
            // 
            this.txtFrameCapacity.Location = new System.Drawing.Point(707, 3);
            this.txtFrameCapacity.Name = "txtFrameCapacity";
            this.txtFrameCapacity.Size = new System.Drawing.Size(216, 31);
            this.txtFrameCapacity.TabIndex = 4;
            this.txtFrameCapacity.Text = "3";
            // 
            // txtPageSequence
            // 
            this.txtPageSequence.Location = new System.Drawing.Point(707, 107);
            this.txtPageSequence.Name = "txtPageSequence";
            this.txtPageSequence.Size = new System.Drawing.Size(498, 31);
            this.txtPageSequence.TabIndex = 5;
            this.txtPageSequence.Text = "2 3 2 1 5 2 4 5 3 2 5 2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtPageSequence, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFrameCapacity, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(80, 135);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1409, 209);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnOPT
            // 
            this.btnOPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOPT.Location = new System.Drawing.Point(80, 387);
            this.btnOPT.Name = "btnOPT";
            this.btnOPT.Size = new System.Drawing.Size(182, 150);
            this.btnOPT.TabIndex = 7;
            this.btnOPT.Text = "OPT";
            this.btnOPT.UseVisualStyleBackColor = true;
            this.btnOPT.Click += new System.EventHandler(this.btnOPT_Click);
            this.btnOPT.MouseEnter += new System.EventHandler(this.btnOPT_MouseEnter);
            this.btnOPT.MouseLeave += new System.EventHandler(this.btnOPT_MouseLeave);
            // 
            // btnLRU
            // 
            this.btnLRU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLRU.Location = new System.Drawing.Point(456, 387);
            this.btnLRU.Name = "btnLRU";
            this.btnLRU.Size = new System.Drawing.Size(182, 150);
            this.btnLRU.TabIndex = 8;
            this.btnLRU.Text = "LRU";
            this.btnLRU.UseVisualStyleBackColor = true;
            this.btnLRU.Click += new System.EventHandler(this.btnLRU_Click);
            this.btnLRU.MouseEnter += new System.EventHandler(this.btnLRU_MouseEnter);
            this.btnLRU.MouseLeave += new System.EventHandler(this.btnLRU_MouseLeave);
            // 
            // btnFIFO
            // 
            this.btnFIFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFIFO.Location = new System.Drawing.Point(895, 387);
            this.btnFIFO.Name = "btnFIFO";
            this.btnFIFO.Size = new System.Drawing.Size(182, 150);
            this.btnFIFO.TabIndex = 9;
            this.btnFIFO.Text = "FIFO";
            this.btnFIFO.UseVisualStyleBackColor = true;
            this.btnFIFO.Click += new System.EventHandler(this.btnFIFO_Click);
            this.btnFIFO.MouseEnter += new System.EventHandler(this.btnFIFO_MouseEnter);
            this.btnFIFO.MouseLeave += new System.EventHandler(this.btnFIFO_MouseLeave);
            // 
            // btnClock
            // 
            this.btnClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClock.Location = new System.Drawing.Point(1307, 387);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(182, 150);
            this.btnClock.TabIndex = 10;
            this.btnClock.Text = "Clock";
            this.btnClock.UseVisualStyleBackColor = true;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            this.btnClock.MouseEnter += new System.EventHandler(this.btnClock_MouseEnter);
            this.btnClock.MouseLeave += new System.EventHandler(this.btnClock_MouseLeave);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 25;
            this.listBoxResult.Location = new System.Drawing.Point(80, 583);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(1409, 229);
            this.listBoxResult.TabIndex = 11;
            // 
            // FormPFSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 956);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.btnClock);
            this.Controls.Add(this.btnFIFO);
            this.Controls.Add(this.btnLRU);
            this.Controls.Add(this.btnOPT);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "FormPFSR";
            this.Text = "PFSR";
            this.Load += new System.EventHandler(this.FormPFSR_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrameCapacity;
        private System.Windows.Forms.TextBox txtPageSequence;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOPT;
        private System.Windows.Forms.Button btnLRU;
        private System.Windows.Forms.Button btnFIFO;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}