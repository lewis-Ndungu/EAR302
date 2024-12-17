using System;
using System.Windows.Forms;

namespace CAT1_6083._2022
{
    public partial class FormPythagorasTheorem : Form
    {
        bool isCalculated = false;
        public FormPythagorasTheorem()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double base_tri, height, hypotunese;
            isCalculated = true;

            try
            {
                base_tri = Convert.ToDouble(box_base.Text);
                height = Convert.ToDouble(box_height.Text);

                hypotunese = Math.Round(Math.Sqrt((Math.Pow(base_tri, 2) + Math.Pow(height, 2))), 4);
                box_hypotunese.Text = hypotunese.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Program", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        
    }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            box_base.Clear();
            box_height.Clear();
            box_hypotunese.Clear();
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (isCalculated)
            {
                dataGridView1.Rows.Add(box_base.Text, box_height.Text, box_hypotunese.Text);
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
