namespace CAT1_6083._2022
{
    partial class FormWorkDone
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
            this.box_force = new System.Windows.Forms.TextBox();
            this.box_distance = new System.Windows.Forms.TextBox();
            this.box_angle = new System.Windows.Forms.TextBox();
            this.box_work = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear_db = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_force = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input the Force(N), Distance(m) and Angle in Degrees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Force:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Angle";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // box_force
            // 
            this.box_force.Location = new System.Drawing.Point(178, 119);
            this.box_force.Name = "box_force";
            this.box_force.Size = new System.Drawing.Size(100, 26);
            this.box_force.TabIndex = 5;
            // 
            // box_distance
            // 
            this.box_distance.Location = new System.Drawing.Point(178, 156);
            this.box_distance.Name = "box_distance";
            this.box_distance.Size = new System.Drawing.Size(100, 26);
            this.box_distance.TabIndex = 6;
            // 
            // box_angle
            // 
            this.box_angle.Location = new System.Drawing.Point(178, 193);
            this.box_angle.Name = "box_angle";
            this.box_angle.Size = new System.Drawing.Size(100, 26);
            this.box_angle.TabIndex = 7;
            // 
            // box_work
            // 
            this.box_work.Location = new System.Drawing.Point(178, 239);
            this.box_work.Name = "box_work";
            this.box_work.ReadOnly = true;
            this.box_work.Size = new System.Drawing.Size(100, 26);
            this.box_work.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Work:";
            // 
            // btn_clear_db
            // 
            this.btn_clear_db.AutoSize = true;
            this.btn_clear_db.Location = new System.Drawing.Point(374, 292);
            this.btn_clear_db.Name = "btn_clear_db";
            this.btn_clear_db.Size = new System.Drawing.Size(83, 30);
            this.btn_clear_db.TabIndex = 20;
            this.btn_clear_db.Text = "Clear DB";
            this.btn_clear_db.UseVisualStyleBackColor = true;
            this.btn_clear_db.Click += new System.EventHandler(this.btn_clear_db_Click);
            // 
            // btn_post
            // 
            this.btn_post.AutoSize = true;
            this.btn_post.Location = new System.Drawing.Point(284, 292);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 30);
            this.btn_post.TabIndex = 19;
            this.btn_post.Text = "Post";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Location = new System.Drawing.Point(203, 292);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.AutoSize = true;
            this.btn_calculate.Location = new System.Drawing.Point(100, 292);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(85, 30);
            this.btn_calculate.TabIndex = 17;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.db_force,
            this.db_distance,
            this.db_angle,
            this.db_work});
            this.dataGridView1.Location = new System.Drawing.Point(494, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(664, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // db_force
            // 
            this.db_force.HeaderText = "Force (N)";
            this.db_force.MinimumWidth = 8;
            this.db_force.Name = "db_force";
            this.db_force.ReadOnly = true;
            // 
            // db_distance
            // 
            this.db_distance.HeaderText = "Distance (m)";
            this.db_distance.MinimumWidth = 8;
            this.db_distance.Name = "db_distance";
            this.db_distance.ReadOnly = true;
            // 
            // db_angle
            // 
            this.db_angle.HeaderText = "Angle (ºC)";
            this.db_angle.MinimumWidth = 8;
            this.db_angle.Name = "db_angle";
            this.db_angle.ReadOnly = true;
            // 
            // db_work
            // 
            this.db_work.HeaderText = "Work (Joules)";
            this.db_work.MinimumWidth = 8;
            this.db_work.Name = "db_work";
            this.db_work.ReadOnly = true;
            // 
            // FormWorkDone
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_work);
            this.Controls.Add(this.box_angle);
            this.Controls.Add(this.box_distance);
            this.Controls.Add(this.box_force);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormWorkDone";
            this.Text = "Work Done";
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
        private System.Windows.Forms.TextBox box_force;
        private System.Windows.Forms.TextBox box_distance;
        private System.Windows.Forms.TextBox box_angle;
        private System.Windows.Forms.TextBox box_work;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear_db;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_force;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_work;
    }
}