namespace CAT1_6083._2022
{
    partial class FormElectricalConductivityCalculator
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
            this.box_length = new System.Windows.Forms.TextBox();
            this.box_crossSectionalArea = new System.Windows.Forms.TextBox();
            this.box_resistance = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.btn_clear_db = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_crossSectionalArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_resistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_sensitivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box_sensitivity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input the length of the conductor, cross-sectional area and resistance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cross-Sectional Area:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resistance:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // box_length
            // 
            this.box_length.Location = new System.Drawing.Point(267, 78);
            this.box_length.Name = "box_length";
            this.box_length.Size = new System.Drawing.Size(100, 26);
            this.box_length.TabIndex = 5;
            // 
            // box_crossSectionalArea
            // 
            this.box_crossSectionalArea.Location = new System.Drawing.Point(267, 124);
            this.box_crossSectionalArea.Name = "box_crossSectionalArea";
            this.box_crossSectionalArea.Size = new System.Drawing.Size(100, 26);
            this.box_crossSectionalArea.TabIndex = 6;
            // 
            // box_resistance
            // 
            this.box_resistance.Location = new System.Drawing.Point(267, 166);
            this.box_resistance.Name = "box_resistance";
            this.box_resistance.Size = new System.Drawing.Size(100, 26);
            this.box_resistance.TabIndex = 7;
            // 
            // btn_calculate
            // 
            this.btn_calculate.AutoSize = true;
            this.btn_calculate.Location = new System.Drawing.Point(93, 267);
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
            this.btn_cancel.Location = new System.Drawing.Point(194, 267);
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
            this.btn_post.Location = new System.Drawing.Point(292, 267);
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
            this.btn_clear_db.Location = new System.Drawing.Point(387, 267);
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
            this.db_length,
            this.db_crossSectionalArea,
            this.db_resistance,
            this.db_sensitivity});
            this.dataGridView1.Location = new System.Drawing.Point(613, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(515, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // db_length
            // 
            this.db_length.HeaderText = "Length (m)";
            this.db_length.MinimumWidth = 8;
            this.db_length.Name = "db_length";
            this.db_length.ReadOnly = true;
            // 
            // db_crossSectionalArea
            // 
            this.db_crossSectionalArea.HeaderText = "Cross-sectional area (m²)";
            this.db_crossSectionalArea.MinimumWidth = 8;
            this.db_crossSectionalArea.Name = "db_crossSectionalArea";
            this.db_crossSectionalArea.ReadOnly = true;
            // 
            // db_resistance
            // 
            this.db_resistance.HeaderText = "Resistance (Ω)";
            this.db_resistance.MinimumWidth = 8;
            this.db_resistance.Name = "db_resistance";
            this.db_resistance.ReadOnly = true;
            // 
            // db_sensitivity
            // 
            this.db_sensitivity.HeaderText = "Sensitivity (S/m)";
            this.db_sensitivity.MinimumWidth = 8;
            this.db_sensitivity.Name = "db_sensitivity";
            this.db_sensitivity.ReadOnly = true;
            // 
            // box_sensitivity
            // 
            this.box_sensitivity.Location = new System.Drawing.Point(267, 211);
            this.box_sensitivity.Name = "box_sensitivity";
            this.box_sensitivity.ReadOnly = true;
            this.box_sensitivity.Size = new System.Drawing.Size(100, 26);
            this.box_sensitivity.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sensitivity:";
            // 
            // FormElectricalConductivityCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_sensitivity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_clear_db);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.box_resistance);
            this.Controls.Add(this.box_crossSectionalArea);
            this.Controls.Add(this.box_length);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormElectricalConductivityCalculator";
            this.Text = "Electrical Conductivity Calculator.";
            this.Load += new System.EventHandler(this.FormBMICalculator_Load);
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
        private System.Windows.Forms.TextBox box_length;
        private System.Windows.Forms.TextBox box_crossSectionalArea;
        private System.Windows.Forms.TextBox box_resistance;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.Button btn_clear_db;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_crossSectionalArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_resistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_sensitivity;
        private System.Windows.Forms.TextBox box_sensitivity;
        private System.Windows.Forms.Label label5;
    }
}