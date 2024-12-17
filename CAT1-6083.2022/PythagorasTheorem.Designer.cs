namespace CAT1_6083._2022
{
    partial class FormPythagorasTheorem
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
            this.box_base = new System.Windows.Forms.TextBox();
            this.box_height = new System.Windows.Forms.TextBox();
            this.box_hypotunese = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.btn_clear_db = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_eight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_hypotunese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Base and Height to get the Hypotunese:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hypotunese:";
            // 
            // box_base
            // 
            this.box_base.Location = new System.Drawing.Point(191, 117);
            this.box_base.Name = "box_base";
            this.box_base.Size = new System.Drawing.Size(100, 26);
            this.box_base.TabIndex = 5;
            // 
            // box_height
            // 
            this.box_height.Location = new System.Drawing.Point(191, 164);
            this.box_height.Name = "box_height";
            this.box_height.Size = new System.Drawing.Size(100, 26);
            this.box_height.TabIndex = 6;
            // 
            // box_hypotunese
            // 
            this.box_hypotunese.Location = new System.Drawing.Point(191, 207);
            this.box_hypotunese.Name = "box_hypotunese";
            this.box_hypotunese.ReadOnly = true;
            this.box_hypotunese.Size = new System.Drawing.Size(100, 26);
            this.box_hypotunese.TabIndex = 7;
            // 
            // btn_calculate
            // 
            this.btn_calculate.AutoSize = true;
            this.btn_calculate.Location = new System.Drawing.Point(61, 269);
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
            this.btn_cancel.Location = new System.Drawing.Point(172, 269);
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
            this.btn_post.Location = new System.Drawing.Point(273, 269);
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
            this.btn_clear_db.Location = new System.Drawing.Point(366, 269);
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
            this.db_base,
            this.db_eight,
            this.db_hypotunese});
            this.dataGridView1.Location = new System.Drawing.Point(466, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(516, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // db_base
            // 
            this.db_base.HeaderText = "Base";
            this.db_base.MinimumWidth = 8;
            this.db_base.Name = "db_base";
            this.db_base.ReadOnly = true;
            // 
            // db_eight
            // 
            this.db_eight.HeaderText = "Height";
            this.db_eight.MinimumWidth = 8;
            this.db_eight.Name = "db_eight";
            this.db_eight.ReadOnly = true;
            // 
            // db_hypotunese
            // 
            this.db_hypotunese.HeaderText = "Hypotunese";
            this.db_hypotunese.MinimumWidth = 8;
            this.db_hypotunese.Name = "db_hypotunese";
            this.db_hypotunese.ReadOnly = true;
            // 
            // FormPythagorasTheorem
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
            this.Controls.Add(this.box_hypotunese);
            this.Controls.Add(this.box_height);
            this.Controls.Add(this.box_base);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPythagorasTheorem";
            this.Text = "Pythagoras Theorem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box_base;
        private System.Windows.Forms.TextBox box_height;
        private System.Windows.Forms.TextBox box_hypotunese;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.Button btn_clear_db;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_base;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_eight;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_hypotunese;
    }
}