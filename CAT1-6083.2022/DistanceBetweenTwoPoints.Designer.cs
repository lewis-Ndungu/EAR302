namespace CAT1_6083._2022
{
    partial class FormDistanceBetweenTwoPoints
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
            this.box_x1 = new System.Windows.Forms.TextBox();
            this.box_x2 = new System.Windows.Forms.TextBox();
            this.box_y1 = new System.Windows.Forms.TextBox();
            this.box_y2 = new System.Windows.Forms.TextBox();
            this.box_distance = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.btn_clear_db = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_x2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_y2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input the Respective Values:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "x1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "x2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "y1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "y2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Distance:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // box_x1
            // 
            this.box_x1.Location = new System.Drawing.Point(197, 82);
            this.box_x1.Name = "box_x1";
            this.box_x1.Size = new System.Drawing.Size(100, 26);
            this.box_x1.TabIndex = 7;
            // 
            // box_x2
            // 
            this.box_x2.Location = new System.Drawing.Point(197, 114);
            this.box_x2.Name = "box_x2";
            this.box_x2.Size = new System.Drawing.Size(100, 26);
            this.box_x2.TabIndex = 8;
            // 
            // box_y1
            // 
            this.box_y1.Location = new System.Drawing.Point(197, 156);
            this.box_y1.Name = "box_y1";
            this.box_y1.Size = new System.Drawing.Size(100, 26);
            this.box_y1.TabIndex = 9;
            // 
            // box_y2
            // 
            this.box_y2.Location = new System.Drawing.Point(197, 194);
            this.box_y2.Name = "box_y2";
            this.box_y2.Size = new System.Drawing.Size(100, 26);
            this.box_y2.TabIndex = 10;
            // 
            // box_distance
            // 
            this.box_distance.Location = new System.Drawing.Point(197, 235);
            this.box_distance.Name = "box_distance";
            this.box_distance.ReadOnly = true;
            this.box_distance.Size = new System.Drawing.Size(100, 26);
            this.box_distance.TabIndex = 11;
            // 
            // btn_calculate
            // 
            this.btn_calculate.AutoSize = true;
            this.btn_calculate.Location = new System.Drawing.Point(100, 283);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(87, 30);
            this.btn_calculate.TabIndex = 12;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Location = new System.Drawing.Point(200, 283);
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
            this.btn_post.Location = new System.Drawing.Point(300, 283);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 30);
            this.btn_post.TabIndex = 14;
            this.btn_post.Text = "Post";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // btn_clear_db
            // 
            this.btn_clear_db.AutoSize = true;
            this.btn_clear_db.Location = new System.Drawing.Point(400, 283);
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
            this.db_x1,
            this.db_x2,
            this.db_y1,
            this.db_y2,
            this.db_distance});
            this.dataGridView1.Location = new System.Drawing.Point(512, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(814, 150);
            this.dataGridView1.TabIndex = 23;
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
            // db_y1
            // 
            this.db_y1.HeaderText = "y1";
            this.db_y1.MinimumWidth = 8;
            this.db_y1.Name = "db_y1";
            this.db_y1.ReadOnly = true;
            // 
            // db_y2
            // 
            this.db_y2.HeaderText = "y2";
            this.db_y2.MinimumWidth = 8;
            this.db_y2.Name = "db_y2";
            this.db_y2.ReadOnly = true;
            // 
            // db_distance
            // 
            this.db_distance.HeaderText = "distance";
            this.db_distance.MinimumWidth = 8;
            this.db_distance.Name = "db_distance";
            this.db_distance.ReadOnly = true;
            // 
            // FormDistanceBetweenTwoPoints
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
            this.Controls.Add(this.box_distance);
            this.Controls.Add(this.box_y2);
            this.Controls.Add(this.box_y1);
            this.Controls.Add(this.box_x2);
            this.Controls.Add(this.box_x1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDistanceBetweenTwoPoints";
            this.Text = "Distance Between Two Points";
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
        private System.Windows.Forms.TextBox box_x1;
        private System.Windows.Forms.TextBox box_x2;
        private System.Windows.Forms.TextBox box_y1;
        private System.Windows.Forms.TextBox box_y2;
        private System.Windows.Forms.TextBox box_distance;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.Button btn_clear_db;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_x2;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_y1;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_y2;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_distance;
    }
}