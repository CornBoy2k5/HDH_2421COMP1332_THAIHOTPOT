namespace HDH_2c
{
    partial class FormDetectBanker
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
            this.labelNumProcesses = new System.Windows.Forms.Label();
            this.labelNumResources = new System.Windows.Forms.Label();
            this.txtNumProcesses = new System.Windows.Forms.TextBox();
            this.txtNumResources = new System.Windows.Forms.TextBox();
            this.dataGridViewAllocation = new System.Windows.Forms.DataGridView();
            this.dataGridViewRequest = new System.Windows.Forms.DataGridView();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.btnConfigureGrid = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(818, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detect Deadlock";
            // 
            // labelNumProcesses
            // 
            this.labelNumProcesses.AutoSize = true;
            this.labelNumProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumProcesses.Location = new System.Drawing.Point(50, 150);
            this.labelNumProcesses.Name = "labelNumProcesses";
            this.labelNumProcesses.Size = new System.Drawing.Size(252, 37);
            this.labelNumProcesses.TabIndex = 1;
            this.labelNumProcesses.Text = "Total processes:";
            // 
            // labelNumResources
            // 
            this.labelNumResources.AutoSize = true;
            this.labelNumResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumResources.Location = new System.Drawing.Point(50, 226);
            this.labelNumResources.Name = "labelNumResources";
            this.labelNumResources.Size = new System.Drawing.Size(315, 37);
            this.labelNumResources.TabIndex = 2;
            this.labelNumResources.Text = "Total resource types:";
            // 
            // txtNumProcesses
            // 
            this.txtNumProcesses.Location = new System.Drawing.Point(362, 150);
            this.txtNumProcesses.Name = "txtNumProcesses";
            this.txtNumProcesses.Size = new System.Drawing.Size(246, 31);
            this.txtNumProcesses.TabIndex = 3;
            // 
            // txtNumResources
            // 
            this.txtNumResources.Location = new System.Drawing.Point(362, 226);
            this.txtNumResources.Name = "txtNumResources";
            this.txtNumResources.Size = new System.Drawing.Size(246, 31);
            this.txtNumResources.TabIndex = 4;
            // 
            // dataGridViewAllocation
            // 
            this.dataGridViewAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllocation.Location = new System.Drawing.Point(57, 346);
            this.dataGridViewAllocation.Name = "dataGridViewAllocation";
            this.dataGridViewAllocation.RowHeadersWidth = 82;
            this.dataGridViewAllocation.RowTemplate.Height = 33;
            this.dataGridViewAllocation.Size = new System.Drawing.Size(706, 448);
            this.dataGridViewAllocation.TabIndex = 5;
            // 
            // dataGridViewRequest
            // 
            this.dataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequest.Location = new System.Drawing.Point(889, 346);
            this.dataGridViewRequest.Name = "dataGridViewRequest";
            this.dataGridViewRequest.RowHeadersWidth = 82;
            this.dataGridViewRequest.RowTemplate.Height = 33;
            this.dataGridViewRequest.Size = new System.Drawing.Size(707, 448);
            this.dataGridViewRequest.TabIndex = 6;
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(1639, 346);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(274, 31);
            this.txtAvailable.TabIndex = 7;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(55, 829);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(154, 65);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 25;
            this.listBoxResult.Location = new System.Drawing.Point(309, 832);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(1287, 204);
            this.listBoxResult.TabIndex = 9;
            // 
            // btnConfigureGrid
            // 
            this.btnConfigureGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigureGrid.Location = new System.Drawing.Point(654, 168);
            this.btnConfigureGrid.Name = "btnConfigureGrid";
            this.btnConfigureGrid.Size = new System.Drawing.Size(183, 70);
            this.btnConfigureGrid.TabIndex = 10;
            this.btnConfigureGrid.Text = "Configure";
            this.btnConfigureGrid.UseVisualStyleBackColor = true;
            this.btnConfigureGrid.Click += new System.EventHandler(this.btnConfigureGrid_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Allocation matrix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(882, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Request matrix";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailable.Location = new System.Drawing.Point(1681, 235);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(146, 37);
            this.labelAvailable.TabIndex = 13;
            this.labelAvailable.Text = "Available";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(55, 900);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 65);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(57, 971);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 65);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormDetectBanker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2074, 1084);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelAvailable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConfigureGrid);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.dataGridViewRequest);
            this.Controls.Add(this.dataGridViewAllocation);
            this.Controls.Add(this.txtNumResources);
            this.Controls.Add(this.txtNumProcesses);
            this.Controls.Add(this.labelNumResources);
            this.Controls.Add(this.labelNumProcesses);
            this.Controls.Add(this.label1);
            this.Name = "FormDetectBanker";
            this.Text = "FormDetectBanker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumProcesses;
        private System.Windows.Forms.Label labelNumResources;
        private System.Windows.Forms.TextBox txtNumProcesses;
        private System.Windows.Forms.TextBox txtNumResources;
        private System.Windows.Forms.DataGridView dataGridViewAllocation;
        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button btnConfigureGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}