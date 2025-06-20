﻿
namespace HDH_2c
{
    partial class FormBanker
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_nprocess = new System.Windows.Forms.TextBox();
            this.text_nresource = new System.Windows.Forms.TextBox();
            this.button_check = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text_allocation = new System.Windows.Forms.TextBox();
            this.rich_allocation = new System.Windows.Forms.RichTextBox();
            this.button_allocation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.text_max = new System.Windows.Forms.TextBox();
            this.rich_max = new System.Windows.Forms.RichTextBox();
            this.button_max = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.text_available = new System.Windows.Forms.TextBox();
            this.rich_output = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_safe = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.rich_need = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.text_Prequest = new System.Windows.Forms.TextBox();
            this.text_Rrequest = new System.Windows.Forms.TextBox();
            this.radioButton_safe = new System.Windows.Forms.RadioButton();
            this.radioButton_request = new System.Windows.Forms.RadioButton();
            this.btn_back = new System.Windows.Forms.Button();
            this.btnDetectDeadlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banker\'s Algorithm\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total processes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total resource types";
            // 
            // text_nprocess
            // 
            this.text_nprocess.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nprocess.Location = new System.Drawing.Point(173, 48);
            this.text_nprocess.Margin = new System.Windows.Forms.Padding(2);
            this.text_nprocess.Name = "text_nprocess";
            this.text_nprocess.Size = new System.Drawing.Size(76, 42);
            this.text_nprocess.TabIndex = 3;
            this.text_nprocess.TextChanged += new System.EventHandler(this.text_nprocess_TextChanged);
            // 
            // text_nresource
            // 
            this.text_nresource.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nresource.Location = new System.Drawing.Point(173, 77);
            this.text_nresource.Margin = new System.Windows.Forms.Padding(2);
            this.text_nresource.Name = "text_nresource";
            this.text_nresource.Size = new System.Drawing.Size(76, 42);
            this.text_nresource.TabIndex = 4;
            this.text_nresource.TextChanged += new System.EventHandler(this.text_nresource_TextChanged);
            // 
            // button_check
            // 
            this.button_check.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.Location = new System.Drawing.Point(276, 46);
            this.button_check.Margin = new System.Windows.Forms.Padding(2);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(100, 24);
            this.button_check.TabIndex = 5;
            this.button_check.Text = "Continue";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Allocation matrix";
            // 
            // text_allocation
            // 
            this.text_allocation.Enabled = false;
            this.text_allocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_allocation.Location = new System.Drawing.Point(46, 170);
            this.text_allocation.Margin = new System.Windows.Forms.Padding(2);
            this.text_allocation.Name = "text_allocation";
            this.text_allocation.Size = new System.Drawing.Size(88, 42);
            this.text_allocation.TabIndex = 7;
            // 
            // rich_allocation
            // 
            this.rich_allocation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rich_allocation.Cursor = System.Windows.Forms.Cursors.No;
            this.rich_allocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_allocation.Location = new System.Drawing.Point(169, 133);
            this.rich_allocation.Margin = new System.Windows.Forms.Padding(2);
            this.rich_allocation.Name = "rich_allocation";
            this.rich_allocation.ReadOnly = true;
            this.rich_allocation.Size = new System.Drawing.Size(176, 122);
            this.rich_allocation.TabIndex = 8;
            this.rich_allocation.Text = "";
            // 
            // button_allocation
            // 
            this.button_allocation.Enabled = false;
            this.button_allocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_allocation.Location = new System.Drawing.Point(47, 210);
            this.button_allocation.Margin = new System.Windows.Forms.Padding(2);
            this.button_allocation.Name = "button_allocation";
            this.button_allocation.Size = new System.Drawing.Size(89, 22);
            this.button_allocation.TabIndex = 9;
            this.button_allocation.Text = "Add row";
            this.button_allocation.UseVisualStyleBackColor = true;
            this.button_allocation.Click += new System.EventHandler(this.button_allocation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max matrix";
            // 
            // text_max
            // 
            this.text_max.Enabled = false;
            this.text_max.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_max.Location = new System.Drawing.Point(374, 172);
            this.text_max.Margin = new System.Windows.Forms.Padding(2);
            this.text_max.Name = "text_max";
            this.text_max.Size = new System.Drawing.Size(80, 42);
            this.text_max.TabIndex = 11;
            // 
            // rich_max
            // 
            this.rich_max.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rich_max.Cursor = System.Windows.Forms.Cursors.No;
            this.rich_max.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_max.Location = new System.Drawing.Point(485, 137);
            this.rich_max.Margin = new System.Windows.Forms.Padding(2);
            this.rich_max.Name = "rich_max";
            this.rich_max.ReadOnly = true;
            this.rich_max.Size = new System.Drawing.Size(184, 122);
            this.rich_max.TabIndex = 12;
            this.rich_max.Text = "";
            // 
            // button_max
            // 
            this.button_max.Enabled = false;
            this.button_max.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_max.Location = new System.Drawing.Point(374, 208);
            this.button_max.Margin = new System.Windows.Forms.Padding(2);
            this.button_max.Name = "button_max";
            this.button_max.Size = new System.Drawing.Size(79, 23);
            this.button_max.TabIndex = 13;
            this.button_max.Text = "Add row";
            this.button_max.UseVisualStyleBackColor = true;
            this.button_max.Click += new System.EventHandler(this.button_max_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(724, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 36);
            this.label6.TabIndex = 14;
            this.label6.Text = "Available matrix";
            // 
            // text_available
            // 
            this.text_available.Enabled = false;
            this.text_available.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_available.Location = new System.Drawing.Point(727, 170);
            this.text_available.Margin = new System.Windows.Forms.Padding(2);
            this.text_available.Name = "text_available";
            this.text_available.Size = new System.Drawing.Size(119, 42);
            this.text_available.TabIndex = 15;
            // 
            // rich_output
            // 
            this.rich_output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rich_output.Cursor = System.Windows.Forms.Cursors.No;
            this.rich_output.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_output.Location = new System.Drawing.Point(404, 309);
            this.rich_output.Margin = new System.Windows.Forms.Padding(2);
            this.rich_output.Name = "rich_output";
            this.rich_output.ReadOnly = true;
            this.rich_output.Size = new System.Drawing.Size(195, 132);
            this.rich_output.TabIndex = 16;
            this.rich_output.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "Output";
            // 
            // button_safe
            // 
            this.button_safe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_safe.Location = new System.Drawing.Point(676, 451);
            this.button_safe.Margin = new System.Windows.Forms.Padding(2);
            this.button_safe.Name = "button_safe";
            this.button_safe.Size = new System.Drawing.Size(107, 29);
            this.button_safe.TabIndex = 18;
            this.button_safe.Text = "Check ";
            this.button_safe.UseVisualStyleBackColor = true;
            this.button_safe.Click += new System.EventHandler(this.button_safe_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(817, 451);
            this.button_clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(108, 30);
            this.button_clear.TabIndex = 19;
            this.button_clear.Text = "Reset";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 282);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 36);
            this.label10.TabIndex = 27;
            this.label10.Text = "Need Matrix";
            // 
            // rich_need
            // 
            this.rich_need.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rich_need.Cursor = System.Windows.Forms.Cursors.No;
            this.rich_need.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_need.Location = new System.Drawing.Point(46, 310);
            this.rich_need.Margin = new System.Windows.Forms.Padding(2);
            this.rich_need.Name = "rich_need";
            this.rich_need.ReadOnly = true;
            this.rich_need.Size = new System.Drawing.Size(288, 131);
            this.rich_need.TabIndex = 28;
            this.rich_need.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(667, 333);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 36);
            this.label8.TabIndex = 21;
            this.label8.Text = "Request process";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(667, 382);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 36);
            this.label9.TabIndex = 22;
            this.label9.Text = "Request resources";
            this.label9.Visible = false;
            // 
            // text_Prequest
            // 
            this.text_Prequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Prequest.Location = new System.Drawing.Point(791, 331);
            this.text_Prequest.Margin = new System.Windows.Forms.Padding(2);
            this.text_Prequest.Name = "text_Prequest";
            this.text_Prequest.Size = new System.Drawing.Size(92, 42);
            this.text_Prequest.TabIndex = 23;
            this.text_Prequest.Visible = false;
            // 
            // text_Rrequest
            // 
            this.text_Rrequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Rrequest.Location = new System.Drawing.Point(792, 377);
            this.text_Rrequest.Margin = new System.Windows.Forms.Padding(2);
            this.text_Rrequest.Name = "text_Rrequest";
            this.text_Rrequest.Size = new System.Drawing.Size(122, 42);
            this.text_Rrequest.TabIndex = 24;
            this.text_Rrequest.Visible = false;
            // 
            // radioButton_safe
            // 
            this.radioButton_safe.AutoSize = true;
            this.radioButton_safe.Checked = true;
            this.radioButton_safe.Enabled = false;
            this.radioButton_safe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_safe.Location = new System.Drawing.Point(670, 287);
            this.radioButton_safe.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_safe.Name = "radioButton_safe";
            this.radioButton_safe.Size = new System.Drawing.Size(209, 40);
            this.radioButton_safe.TabIndex = 25;
            this.radioButton_safe.TabStop = true;
            this.radioButton_safe.Text = "safe sequence";
            this.radioButton_safe.UseVisualStyleBackColor = true;
            this.radioButton_safe.CheckedChanged += new System.EventHandler(this.radioButton_safe_CheckedChanged);
            // 
            // radioButton_request
            // 
            this.radioButton_request.AutoSize = true;
            this.radioButton_request.Enabled = false;
            this.radioButton_request.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_request.Location = new System.Drawing.Point(791, 287);
            this.radioButton_request.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_request.Name = "radioButton_request";
            this.radioButton_request.Size = new System.Drawing.Size(139, 40);
            this.radioButton_request.TabIndex = 26;
            this.radioButton_request.Text = "Request";
            this.radioButton_request.UseVisualStyleBackColor = true;
            this.radioButton_request.CheckedChanged += new System.EventHandler(this.radioButton_request_CheckedChanged);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(46, 458);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(110, 56);
            this.btn_back.TabIndex = 33;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btnDetectDeadlock
            // 
            this.btnDetectDeadlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectDeadlock.Location = new System.Drawing.Point(834, 49);
            this.btnDetectDeadlock.Name = "btnDetectDeadlock";
            this.btnDetectDeadlock.Size = new System.Drawing.Size(145, 67);
            this.btnDetectDeadlock.TabIndex = 34;
            this.btnDetectDeadlock.Text = "Detect Deadlock";
            this.btnDetectDeadlock.UseVisualStyleBackColor = true;
            this.btnDetectDeadlock.Click += new System.EventHandler(this.btnDetectDeadlock_Click);
            // 
            // FormBanker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1003, 580);
            this.Controls.Add(this.btnDetectDeadlock);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.rich_need);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radioButton_request);
            this.Controls.Add(this.radioButton_safe);
            this.Controls.Add(this.text_Rrequest);
            this.Controls.Add(this.text_Prequest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_safe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rich_output);
            this.Controls.Add(this.text_available);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_max);
            this.Controls.Add(this.rich_max);
            this.Controls.Add(this.text_max);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_allocation);
            this.Controls.Add(this.rich_allocation);
            this.Controls.Add(this.text_allocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.text_nresource);
            this.Controls.Add(this.text_nprocess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormBanker";
            this.Text = "Banker\'s Algorithm";
            this.Load += new System.EventHandler(this.FormBanker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_nprocess;
        private System.Windows.Forms.TextBox text_nresource;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_allocation;
        private System.Windows.Forms.RichTextBox rich_allocation;
        private System.Windows.Forms.Button button_allocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_max;
        private System.Windows.Forms.RichTextBox rich_max;
        private System.Windows.Forms.Button button_max;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_available;
        private System.Windows.Forms.RichTextBox rich_output;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_safe;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rich_need;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_Prequest;
        private System.Windows.Forms.TextBox text_Rrequest;
        private System.Windows.Forms.RadioButton radioButton_safe;
        private System.Windows.Forms.RadioButton radioButton_request;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btnDetectDeadlock;
    }
}

