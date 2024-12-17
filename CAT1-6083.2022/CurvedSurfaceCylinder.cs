using System;
using System.Windows.Forms;

namespace CAT1_6083._2022
{
    public partial class FormCurvedSurfaceCylinder : Form
    {
        bool isCalculated = false;
        public FormCurvedSurfaceCylinder()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double radius, height, area;
            isCalculated = true;


            try
            {
                radius = Convert.ToDouble(box_radius.Text);
                height = Convert.ToDouble(box_height.Text);

                area = Math.Round(2 * Math.PI * radius * height, 4);
                box_curvedSurface.Text = area.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Program", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            box_curvedSurface.Clear();
            box_height.Clear();
            box_radius.Clear();
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (isCalculated)
            {
                dataGridView1.Rows.Add(box_radius.Text, box_height.Text, box_curvedSurface.Text);
                isCalculated = false;
            }
            else
            {
                MessageBox.Show("Please Calculate First before Posting.", "Posting Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_db_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
