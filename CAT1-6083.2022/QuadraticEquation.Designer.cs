namespace CAT1_6083._2022
{
    partial class FormQuadraticEquation
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
            this.label6 = new System.Windows.Forms.Label();
            this.box_a = new System.Windows.Forms.TextBox();
            this.box_b = new System.Windows.Forms.TextBox();
            this.box_c = new System.Windows.Forms.TextBox();
            this.box_x1 = new System.Windows.Forms.TextBox();
            this.box_x2 = new System.Windows.Forms.TextBox();
            this.btn_clear_db = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_x2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_output = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Input the Value of \'a\', \'b\' and \'c\' :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "x1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "x2:";
            // 
            // box_a
            // 
            this.box_a.Location = new System.Drawing.Point(180, 125);
            this.box_a.Name = "box_a";
            this.box_a.Size = new System.Drawing.Size(156, 26);
            this.box_a.TabIndex = 30;
            // 
            // box_b
            // 
            this.box_b.Location = new System.Drawing.Point(180, 163);
            this.box_b.Name = "box_b";
            this.box_b.Size = new System.Drawing.Size(156, 26);
            this.box_b.TabIndex = 31;
            // 
            // box_c
            // 
            this.box_c.Location = new System.Drawing.Point(180, 200);
            this.box_c.Name = "box_c";
            this.box_c.Size = new System.Drawing.Size(156, 26);
            this.box_c.TabIndex = 32;
            // 
            // box_x1
            // 
            this.box_x1.Location = new System.Drawing.Point(180, 242);
            this.box_x1.Name = "box_x1";
            this.box_x1.ReadOnly = true;
            this.box_x1.Size = new System.Drawing.Size(156, 26);
            this.box_x1.TabIndex = 33;
            // 
            // box_x2
            // 
            this.box_x2.Location = new System.Drawing.Point(180, 276);
            this.box_x2.Name = "box_x2";
            this.box_x2.ReadOnly = true;
            this.box_x2.Size = new System.Drawing.Size(156, 26);
            this.box_x2.TabIndex = 34;
            // 
            // btn_clear_db
            // 
            this.btn_clear_db.AutoSize = true;
            this.btn_clear_db.Location = new System.Drawing.Point(419, 369);
            this.btn_clear_db.Name = "btn_clear_db";
            this.btn_clear_db.Size = new System.Drawing.Size(83, 30);
            this.btn_clear_db.TabIndex = 38;
            this.btn_clear_db.Text = "Clear DB";
            this.btn_clear_db.UseVisualStyleBackColor = true;
            this.btn_clear_db.Click += new System.EventHandler(this.btn_clear_db_Click);
            // 
            // btn_post
            // 
            this.btn_post.AutoSize = true;
            this.btn_post.Location = new System.Drawing.Point(323, 369);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 30);
            this.btn_post.TabIndex = 37;
            this.btn_post.Text = "Post";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Location = new System.Drawing.Point(225, 369);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.AutoSize = true;
            this.btn_calculate.Location = new System.Drawing.Point(124, 369);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(85, 30);
            this.btn_calculate.TabIndex = 35;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.db_a,
            this.db_b,
            this.db_c,
            this.db_x1,
            this.db_x2});
            this.dataGridView1.Location = new System.Drawing.Point(828, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(815, 150);
            this.dataGridView1.TabIndex = 39;
            // 
            // db_a
            // 
            this.db_a.HeaderText = "a";
            this.db_a.MinimumWidth = 8;
            this.db_a.Name = "db_a";
            this.db_a.ReadOnly = true;
            // 
            // db_b
            // 
            this.db_b.HeaderText = "b";
            this.db_b.MinimumWidth = 8;
            this.db_b.Name = "db_b";
            this.db_b.ReadOnly = true;
            // 
            // db_c
            // 
            this.db_c.HeaderText = "c";
            this.db_c.MinimumWidth = 8;
            this.db_c.Name = "db_c";
            this.db_c.ReadOnly = true;
            // 
            // db_x1
            // 
            this.db_x1.HeaderText = "x1";
            this.db_x1.MinimumWidth = 8;
            this.db_x1.Name = "db_x1";
            this.db_x1.ReadOnly = true;
            // 
            // db_x2
            // 
            this.db_x2.HeaderText = "x2";
            this.db_x2.MinimumWidth = 8;
            this.db_x2.Name = "db_x2";
            this.db_x2.ReadOnly = true;
            // 
            // txt_output
            // 
            this.txt_output.AutoSize = true;
            this.txt_output.Location = new System.Drawing.Point(124, 331);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(0, 20);
            this.txt_output.TabIndex = 40;
            this.txt_output.Click += new System.EventHandler(this.txt_output_Click);
            // 
            // FormQuadraticEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_clear_db);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.box_x2);
            this.Controls.Add(this.box_x1);
            this.Controls.Add(this.box_c);
            this.Controls.Add(this.box_b);
            this.Controls.Add(this.box_a);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQuadraticEquation";
            this.Text = "Quadratic Equation";
            this.Load += new System.EventHandler(this.FormQuadraticEquation_Load);
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
        private System.Windows.Forms.TextBox box_a;
        private System.Windows.Forms.TextBox box_b;
        private System.Windows.Forms.TextBox box_c;
        private System.Windows.Forms.TextBox box_x1;
        private System.Windows.Forms.TextBox box_x2;
        private System.Windows.Forms.Button btn_clear_db;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_x2;
        private System.Windows.Forms.Label txt_output;
    }
}