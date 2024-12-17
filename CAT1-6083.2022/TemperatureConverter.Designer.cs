namespace CAT1_6083._2022
{
    partial class FormTemperatureConverter
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
            this.box_celcius = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.box_fahrenheit = new System.Windows.Forms.TextBox();
            this.btn_clear_db = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_celcius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_fahrenheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_clear_db01 = new System.Windows.Forms.Button();
            this.box_celcius01 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_post01 = new System.Windows.Forms.Button();
            this.btn_cancel01 = new System.Windows.Forms.Button();
            this.btn_calculate01 = new System.Windows.Forms.Button();
            this.box_fahrenheit01 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Converting Temperature in Degrees Celcius to Degree Fahrenheit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Degree Celcius:";
            // 
            // box_celcius
            // 
            this.box_celcius.Location = new System.Drawing.Point(215, 73);
            this.box_celcius.Name = "box_celcius";
            this.box_celcius.Size = new System.Drawing.Size(100, 26);
            this.box_celcius.TabIndex = 2;
            // 
            // btn_calculate
            // 
            this.btn_calculate.AutoSize = true;
            this.btn_calculate.Location = new System.Drawing.Point(41, 172);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(85, 30);
            this.btn_calculate.TabIndex = 3;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Location = new System.Drawing.Point(142, 172);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_post
            // 
            this.btn_post.AutoSize = true;
            this.btn_post.Location = new System.Drawing.Point(240, 172);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 30);
            this.btn_post.TabIndex = 5;
            this.btn_post.Text = "Post";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Degree Fahrenheit:";
            // 
            // box_fahrenheit
            // 
            this.box_fahrenheit.Location = new System.Drawing.Point(215, 117);
            this.box_fahrenheit.Name = "box_fahrenheit";
            this.box_fahrenheit.ReadOnly = true;
            this.box_fahrenheit.Size = new System.Drawing.Size(100, 26);
            this.box_fahrenheit.TabIndex = 7;
            // 
            // btn_clear_db
            // 
            this.btn_clear_db.AutoSize = true;
            this.btn_clear_db.Location = new System.Drawing.Point(336, 172);
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
            this.db_celcius,
            this.db_fahrenheit});
            this.dataGridView1.Location = new System.Drawing.Point(535, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(580, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // db_celcius
            // 
            this.db_celcius.HeaderText = "Celcius (°C)";
            this.db_celcius.MinimumWidth = 8;
            this.db_celcius.Name = "db_celcius";
            this.db_celcius.ReadOnly = true;
            // 
            // db_fahrenheit
            // 
            this.db_fahrenheit.HeaderText = "Fahrenheit (°F)";
            this.db_fahrenheit.MinimumWidth = 8;
            this.db_fahrenheit.Name = "db_fahrenheit";
            this.db_fahrenheit.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(535, 238);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(365, 150);
            this.dataGridView2.TabIndex = 33;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Fahrenheit (°F)";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Celcius (°C)";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btn_clear_db01
            // 
            this.btn_clear_db01.AutoSize = true;
            this.btn_clear_db01.Location = new System.Drawing.Point(336, 380);
            this.btn_clear_db01.Name = "btn_clear_db01";
            this.btn_clear_db01.Size = new System.Drawing.Size(83, 30);
            this.btn_clear_db01.TabIndex = 32;
            this.btn_clear_db01.Text = "Clear DB";
            this.btn_clear_db01.UseVisualStyleBackColor = true;
            this.btn_clear_db01.Click += new System.EventHandler(this.btn_clear_db01_Click);
            // 
            // box_celcius01
            // 
            this.box_celcius01.Location = new System.Drawing.Point(215, 325);
            this.box_celcius01.Name = "box_celcius01";
            this.box_celcius01.ReadOnly = true;
            this.box_celcius01.Size = new System.Drawing.Size(100, 26);
            this.box_celcius01.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Degree Celcius:";
            // 
            // btn_post01
            // 
            this.btn_post01.AutoSize = true;
            this.btn_post01.Location = new System.Drawing.Point(240, 380);
            this.btn_post01.Name = "btn_post01";
            this.btn_post01.Size = new System.Drawing.Size(75, 30);
            this.btn_post01.TabIndex = 29;
            this.btn_post01.Text = "Post";
            this.btn_post01.UseVisualStyleBackColor = true;
            this.btn_post01.Click += new System.EventHandler(this.btn_post01_Click);
            // 
            // btn_cancel01
            // 
            this.btn_cancel01.AutoSize = true;
            this.btn_cancel01.Location = new System.Drawing.Point(142, 380);
            this.btn_cancel01.Name = "btn_cancel01";
            this.btn_cancel01.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel01.TabIndex = 28;
            this.btn_cancel01.Text = "Cancel";
            this.btn_cancel01.UseVisualStyleBackColor = true;
            this.btn_cancel01.Click += new System.EventHandler(this.btn_cancel01_Click);
            // 
            // btn_calculate01
            // 
            this.btn_calculate01.AutoSize = true;
            this.btn_calculate01.Location = new System.Drawing.Point(41, 380);
            this.btn_calculate01.Name = "btn_calculate01";
            this.btn_calculate01.Size = new System.Drawing.Size(85, 30);
            this.btn_calculate01.TabIndex = 27;
            this.btn_calculate01.Text = "Calculate";
            this.btn_calculate01.UseVisualStyleBackColor = true;
            this.btn_calculate01.Click += new System.EventHandler(this.btn_calculate01_Click);
            // 
            // box_fahrenheit01
            // 
            this.box_fahrenheit01.Location = new System.Drawing.Point(215, 281);
            this.box_fahrenheit01.Name = "box_fahrenheit01";
            this.box_fahrenheit01.Size = new System.Drawing.Size(100, 26);
            this.box_fahrenheit01.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Degree Fahrenheit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(476, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Converting Temperature in Degrees Fahrenheit to Degree Celcius:";
            // 
            // FormTemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_clear_db01);
            this.Controls.Add(this.box_celcius01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_post01);
            this.Controls.Add(this.btn_cancel01);
            this.Controls.Add(this.btn_calculate01);
            this.Controls.Add(this.box_fahrenheit01);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_clear_db);
            this.Controls.Add(this.box_fahrenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.box_celcius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTemperatureConverter";
            this.Text = "Temperature in Degrees Celcius to Degree Fahrenheit:";
            this.Load += new System.EventHandler(this.FormTemperatureConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_celcius;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_fahrenheit;
        private System.Windows.Forms.Button btn_clear_db;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_clear_db01;
        private System.Windows.Forms.TextBox box_celcius01;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_post01;
        private System.Windows.Forms.Button btn_cancel01;
        private System.Windows.Forms.Button btn_calculate01;
        private System.Windows.Forms.TextBox box_fahrenheit01;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_celcius;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_fahrenheit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label6;
    }
}