using System;
using System.Windows.Forms;

namespace CAT1_6083._2022
{
    public partial class FormDistanceBetweenTwoPoints : Form
    {
        bool isCalculated = false;
        public FormDistanceBetweenTwoPoints()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2, distance;
            isCalculated = true;

            try
            {
                x1 = Convert.ToDouble(box_x1.Text);
                x2 = Convert.ToDouble(box_x2.Text);
                y1 = Convert.ToDouble(box_y1.Text);
                y2 = Convert.ToDouble(box_y2.Text);

                distance = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 4);
                box_distance.Text = distance.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Program", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        
    }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            box_distance.Clear();
            box_x1.Clear();
            box_y1.Clear();
            box_y2.Clear();
            box_x2.Clear();

        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (isCalculated)
            {
                dataGridView1.Rows.Add(box_x1.Text, box_x2.Text, box_y1.Text, box_y2.Text, box_distance.Text);
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
