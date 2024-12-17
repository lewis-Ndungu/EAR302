using System;
using System.Windows.Forms;

namespace CAT1_6083._2022
{
    public partial class FormWorkDone : Form
    {
        bool isCalculated = false;
        public FormWorkDone()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double force, distance, angle, work;
            isCalculated = true;

            try
            {
                force = Convert.ToDouble(box_force.Text);
                distance = Convert.ToDouble(box_distance.Text);
                angle = Convert.ToDouble(box_angle.Text);

                work = Math.Round(force * distance * Math.Cos(angle), 4);
                box_work.Text = work.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Program", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        
    }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            box_force.Clear();
            box_distance.Clear();
            box_angle.Clear();
            box_work.Clear();
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (isCalculated)
            {
                dataGridView1.Rows.Add(box_force.Text, box_distance.Text, box_angle.Text, box_work.Text);
                isCalculated = false;
            }
            else
            {
                MessageBox.Show("Please Calculate First before Posting.", "Posting Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btn_clear_db_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
