namespace CAT1_6083._2022
{
    partial class FormOhmsLaw
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.box_voltage = new System.Windows.Forms.TextBox();
            this.box_resistance = new System.Windows.Forms.TextBox();
            this.box_current = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.btn_clear_db = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_voltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_resistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Voltage and Resistance to get Current:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voltage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resistance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // box_voltage
            // 
            this.box_voltage.Location = new System.Drawing.Point(224, 91);
            this.box_voltage.Name = "box_voltage";
            this.box_voltage.Size = new System.Drawing.Size(100, 26);
            this.box_voltage.TabIndex = 5;
            // 
            // box_resistance
            // 
            this.box_resistance.Location = new System.Drawing.Point(224, 131);
            this.box_resistance.Name = "box_resistance";
            this.box_resistance.Size = new System.Drawing.Size(100, 26);
            this.box_resistance.TabIndex = 6;
            // 
            // box_current
            // 
            this.box_current.Location = new System.Drawing.Point(224, 176);
            this.box_current.Name = "box_current";
            this.box_current.ReadOnly = true;
            this.box_current.Size = new System.Drawing.Size(100, 26);
            this.box_current.TabIndex = 7;
            // 
            // btn_calculate
            // 
            this.btn_calculate.AutoSize = true;
            this.btn_calculate.Location = new System.Drawing.Point(89, 231);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(85, 30);
            this.btn_calculate.TabIndex = 8;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Location = new System.Drawing.Point(207, 231);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_post
            // 
            this.btn_post.AutoSize = true;
            this.btn_post.Location = new System.Drawing.Point(316, 231);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 30);
            this.btn_post.TabIndex = 10;
            this.btn_post.Text = "Post";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // btn_clear_db
            // 
            this.btn_clear_db.AutoSize = true;
            this.btn_clear_db.Location = new System.Drawing.Point(422, 231);
            this.btn_clear_db.Name = "btn_clear_db";
            this.btn_clear_db.Size = new System.Drawing.Size(83, 30);
            this.btn_clear_db.TabIndex = 21;
            this.btn_clear_db.Text = "Clear DB";
            this.btn_clear_db.UseVisualStyleBackColor = true;
            this.btn_clear_db.Click += new System.EventHandler(this.btn_clear_db_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.db_voltage,
            this.db_resistance,
            this.db_current});
            this.dataGridView1.Location = new System.Drawing.Point(534, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(514, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // db_voltage
            // 
            this.db_voltage.HeaderText = "Voltage (V)";
            this.db_voltage.MinimumWidth = 8;
            this.db_voltage.Name = "db_voltage";
            this.db_voltage.ReadOnly = true;
            // 
            // db_resistance
            // 
            this.db_resistance.HeaderText = "Resistance (Ω)";
            this.db_resistance.MinimumWidth = 8;
            this.db_resistance.Name = "db_resistance";
            this.db_resistance.ReadOnly = true;
            // 
            // db_current
            // 
            this.db_current.HeaderText = "Ccurrent (I)";
            this.db_current.MinimumWidth = 8;
            this.db_current.Name = "db_current";
            this.db_current.ReadOnly = true;
            // 
            // FormOhmsLaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_clear_db);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.box_current);
            this.Controls.Add(this.box_resistance);
            this.Controls.Add(this.box_voltage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOhmsLaw";
            this.Text = "Ohms Law";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox box_voltage;
        private System.Windows.Forms.TextBox box_resistance;
        private System.Windows.Forms.TextBox box_current;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.Button btn_clear_db;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_voltage;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_resistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_current;
    }
}