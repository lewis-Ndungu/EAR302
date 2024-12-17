namespace CAT1_6083._2022
{
    partial class FormHeatTransfer
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.box_heatTransfer = new System.Windows.Forms.TextBox();
            this.box_temperatureChange = new System.Windows.Forms.TextBox();
            this.box_specificHeat = new System.Windows.Forms.TextBox();
            this.box_mass = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.btn_clear_db = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_specificHeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_temperatureChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_heatTransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input the mass, specific heat and temperature change:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mass:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Specific Heat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperature Change:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Heat Transfer:";
            // 
            // box_heatTransfer
            // 
            this.box_heatTransfer.Location = new System.Drawing.Point(261, 211);
            this.box_heatTransfer.Name = "box_heatTransfer";
            this.box_heatTransfer.ReadOnly = true;
            this.box_heatTransfer.Size = new System.Drawing.Size(100, 26);
            this.box_heatTransfer.TabIndex = 5;
            // 
            // box_temperatureChange
            // 
            this.box_temperatureChange.Location = new System.Drawing.Point(261, 170);
            this.box_temperatureChange.Name = "box_temperatureChange";
            this.box_temperatureChange.Size = new System.Drawing.Size(100, 26);
            this.box_temperatureChange.TabIndex = 6;
            // 
            // box_specificHeat
            // 
            this.box_specificHeat.Location = new System.Drawing.Point(261, 134);
            this.box_specificHeat.Name = "box_specificHeat";
            this.box_specificHeat.Size = new System.Drawing.Size(100, 26);
            this.box_specificHeat.TabIndex = 7;
            // 
            // box_mass
            // 
            this.box_mass.Location = new System.Drawing.Point(261, 102);
            this.box_mass.Name = "box_mass";
            this.box_mass.Size = new System.Drawing.Size(100, 26);
            this.box_mass.TabIndex = 8;
            // 
            // btn_calculate
            // 
            this.btn_calculate.AutoSize = true;
            this.btn_calculate.Location = new System.Drawing.Point(67, 271);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(91, 30);
            this.btn_calculate.TabIndex = 9;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Location = new System.Drawing.Point(173, 271);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_post
            // 
            this.btn_post.AutoSize = true;
            this.btn_post.Location = new System.Drawing.Point(271, 271);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 30);
            this.btn_post.TabIndex = 11;
            this.btn_post.Text = "Post";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // btn_clear_db
            // 
            this.btn_clear_db.AutoSize = true;
            this.btn_clear_db.Location = new System.Drawing.Point(359, 271);
            this.btn_clear_db.Name = "btn_clear_db";
            this.btn_clear_db.Size = new System.Drawing.Size(83, 30);
            this.btn_clear_db.TabIndex = 22;
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
            this.db_mass,
            this.db_specificHeat,
            this.db_temperatureChange,
            this.db_heatTransfer});
            this.dataGridView1.Location = new System.Drawing.Point(493, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(666, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // db_mass
            // 
            this.db_mass.HeaderText = "Mass (kg)";
            this.db_mass.MinimumWidth = 8;
            this.db_mass.Name = "db_mass";
            this.db_mass.ReadOnly = true;
            // 
            // db_specificHeat
            // 
            this.db_specificHeat.HeaderText = "Specific Heat (J/kg·K)";
            this.db_specificHeat.MinimumWidth = 8;
            this.db_specificHeat.Name = "db_specificHeat";
            this.db_specificHeat.ReadOnly = true;
            // 
            // db_temperatureChange
            // 
            this.db_temperatureChange.HeaderText = "Temperature Change (K)";
            this.db_temperatureChange.MinimumWidth = 8;
            this.db_temperatureChange.Name = "db_temperatureChange";
            this.db_temperatureChange.ReadOnly = true;
            // 
            // db_heatTransfer
            // 
            this.db_heatTransfer.HeaderText = "Heat Transfer (J)";
            this.db_heatTransfer.MinimumWidth = 8;
            this.db_heatTransfer.Name = "db_heatTransfer";
            this.db_heatTransfer.ReadOnly = true;
            // 
            // FormHeatTransfer
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
            this.Controls.Add(this.box_mass);
            this.Controls.Add(this.box_specificHeat);
            this.Controls.Add(this.box_temperatureChange);
            this.Controls.Add(this.box_heatTransfer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHeatTransfer";
            this.Text = "Heat Transfer";
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
        private System.Windows.Forms.TextBox box_heatTransfer;
        private System.Windows.Forms.TextBox box_temperatureChange;
        private System.Windows.Forms.TextBox box_specificHeat;
        private System.Windows.Forms.TextBox box_mass;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.Button btn_clear_db;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_mass;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_specificHeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_temperatureChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_heatTransfer;
    }
}