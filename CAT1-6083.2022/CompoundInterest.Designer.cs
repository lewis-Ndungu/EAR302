﻿namespace CAT1_6083._2022
{
    partial class FormCompoundInterest
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.box_principle = new System.Windows.Forms.TextBox();
            this.box_frequency = new System.Windows.Forms.TextBox();
            this.box_rate = new System.Windows.Forms.TextBox();
            this.box_time = new System.Windows.Forms.TextBox();
            this.box_compoundInterest = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Principle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_compoundInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_clear_db = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input the respecive values to calculate compound interest:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Principle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Frequency:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Compound Intrest:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // box_principle
            // 
            this.box_principle.Location = new System.Drawing.Point(242, 71);
            this.box_principle.Name = "box_principle";
            this.box_principle.Size = new System.Drawing.Size(100, 26);
            this.box_principle.TabIndex = 7;
            // 
            // box_frequency
            // 
            this.box_frequency.Location = new System.Drawing.Point(242, 110);
            this.box_frequency.Name = "box_frequency";
            this.box_frequency.Size = new System.Drawing.Size(100, 26);
            this.box_frequency.TabIndex = 8;
            // 
            // box_rate
            // 
            this.box_rate.Location = new System.Drawing.Point(242, 151);
            this.box_rate.Name = "box_rate";
            this.box_rate.Size = new System.Drawing.Size(100, 26);
            this.box_rate.TabIndex = 9;
            // 
            // box_time
            // 
            this.box_time.Location = new System.Drawing.Point(242, 195);
            this.box_time.Name = "box_time";
            this.box_time.Size = new System.Drawing.Size(100, 26);
            this.box_time.TabIndex = 10;
            // 
            // box_compoundInterest
            // 
            this.box_compoundInterest.Location = new System.Drawing.Point(242, 249);
            this.box_compoundInterest.Name = "box_compoundInterest";
            this.box_compoundInterest.ReadOnly = true;
            this.box_compoundInterest.Size = new System.Drawing.Size(100, 26);
            this.box_compoundInterest.TabIndex = 11;
            // 
            // btn_calculate
            // 
            this.btn_calculate.AutoSize = true;
            this.btn_calculate.Location = new System.Drawing.Point(20, 299);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(85, 30);
            this.btn_calculate.TabIndex = 12;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Location = new System.Drawing.Point(120, 299);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_post
            // 
            this.btn_post.AutoSize = true;
            this.btn_post.Location = new System.Drawing.Point(210, 299);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 30);
            this.btn_post.TabIndex = 14;
            this.btn_post.Text = "Post";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Principle,
            this.Frequency,
            this.bd_rate,
            this.db_time,
            this.db_compoundInterest});
            this.dataGridView1.Location = new System.Drawing.Point(460, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(818, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Principle
            // 
            this.Principle.HeaderText = "Principle";
            this.Principle.MinimumWidth = 8;
            this.Principle.Name = "Principle";
            this.Principle.ReadOnly = true;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.MinimumWidth = 8;
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // bd_rate
            // 
            this.bd_rate.HeaderText = "Rate";
            this.bd_rate.MinimumWidth = 8;
            this.bd_rate.Name = "bd_rate";
            this.bd_rate.ReadOnly = true;
            // 
            // db_time
            // 
            this.db_time.HeaderText = "Time";
            this.db_time.MinimumWidth = 8;
            this.db_time.Name = "db_time";
            this.db_time.ReadOnly = true;
            // 
            // db_compoundInterest
            // 
            this.db_compoundInterest.HeaderText = "Compound Interest";
            this.db_compoundInterest.MinimumWidth = 8;
            this.db_compoundInterest.Name = "db_compoundInterest";
            this.db_compoundInterest.ReadOnly = true;
            // 
            // btn_clear_db
            // 
            this.btn_clear_db.AutoSize = true;
            this.btn_clear_db.Location = new System.Drawing.Point(294, 299);
            this.btn_clear_db.Name = "btn_clear_db";
            this.btn_clear_db.Size = new System.Drawing.Size(83, 30);
            this.btn_clear_db.TabIndex = 16;
            this.btn_clear_db.Text = "Clear DB";
            this.btn_clear_db.UseVisualStyleBackColor = true;
            this.btn_clear_db.Click += new System.EventHandler(this.btn_clear_db_Click);
            // 
            // FormCompoundInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.btn_clear_db);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.box_compoundInterest);
            this.Controls.Add(this.box_time);
            this.Controls.Add(this.box_rate);
            this.Controls.Add(this.box_frequency);
            this.Controls.Add(this.box_principle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCompoundInterest";
            this.Text = "Compound Interest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox box_principle;
        private System.Windows.Forms.TextBox box_frequency;
        private System.Windows.Forms.TextBox box_rate;
        private System.Windows.Forms.TextBox box_time;
        private System.Windows.Forms.TextBox box_compoundInterest;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_clear_db;
        private System.Windows.Forms.DataGridViewTextBoxColumn Principle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn bd_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_compoundInterest;
    }
}