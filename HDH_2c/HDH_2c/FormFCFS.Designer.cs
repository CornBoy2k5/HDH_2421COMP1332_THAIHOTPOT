namespace HDH_2c
{
    partial class FormFCFS
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
            this.lblHeadPosition = new System.Windows.Forms.Label();
            this.lblRequestSequence = new System.Windows.Forms.Label();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.lblTotalSeeks = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "FCFS Disk Scheduling Simulation";
            // 
            // lblHeadPosition
            // 
            this.lblHeadPosition.AutoSize = true;
            this.lblHeadPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadPosition.Location = new System.Drawing.Point(57, 123);
            this.lblHeadPosition.Name = "lblHeadPosition";
            this.lblHeadPosition.Size = new System.Drawing.Size(216, 37);
            this.lblHeadPosition.TabIndex = 1;
            this.lblHeadPosition.Text = "Head Position";
            // 
            // lblRequestSequence
            // 
            this.lblRequestSequence.AutoSize = true;
            this.lblRequestSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestSequence.Location = new System.Drawing.Point(57, 256);
            this.lblRequestSequence.Name = "lblRequestSequence";
            this.lblRequestSequence.Size = new System.Drawing.Size(285, 37);
            this.lblRequestSequence.TabIndex = 2;
            this.lblRequestSequence.Text = "Request Sequence";
            // 
            // btnSimulate
            // 
            this.btnSimulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulate.Location = new System.Drawing.Point(1221, 123);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(225, 170);
            this.btnSimulate.TabIndex = 3;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 31;
            this.listBoxResult.Location = new System.Drawing.Point(64, 380);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(1382, 283);
            this.listBoxResult.TabIndex = 4;
            // 
            // lblTotalSeeks
            // 
            this.lblTotalSeeks.AutoSize = true;
            this.lblTotalSeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSeeks.Location = new System.Drawing.Point(1190, 704);
            this.lblTotalSeeks.Name = "lblTotalSeeks";
            this.lblTotalSeeks.Size = new System.Drawing.Size(221, 37);
            this.lblTotalSeeks.TabIndex = 5;
            this.lblTotalSeeks.Text = "Total Seeks: 0";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(64, 796);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(179, 73);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormFCFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 911);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTotalSeeks);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.lblRequestSequence);
            this.Controls.Add(this.lblHeadPosition);
            this.Controls.Add(this.label1);
            this.Name = "FormFCFS";
            this.Text = "FormFCFS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeadPosition;
        private System.Windows.Forms.Label lblRequestSequence;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label lblTotalSeeks;
        private System.Windows.Forms.Button btnBack;
    }
}