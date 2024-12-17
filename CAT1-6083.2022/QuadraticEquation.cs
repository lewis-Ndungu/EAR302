using System;
using System.Windows.Forms;

namespace CAT1_6083._2022
{
    public partial class FormQuadraticEquation : Form
    {
        bool isCalculated, isWrong = false;
        public FormQuadraticEquation()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double a, b, c, d, x, y , x1, x2;
            isCalculated = true;

            try
            {
                a = Convert.ToDouble(box_a.Text);
                b = Convert.ToDouble(box_b.Text);
                c = Convert.ToDouble(box_c.Text);

                d = Math.Pow(b, 2) - (4 * a * c);

                if (d > 0)
                {
                    x1 = Math.Round((-b + Math.Sqrt(d)) / (2 * a), 2);
                    x2 = Math.Round((-b - Math.Sqrt(d)) / (2 * a), 2);

                    box_x1.Text = x1.ToString();
                    box_x2.Text = x2.ToString();

                    txt_output.Text = "The Roots are Real and Distinct with x1 = " + x1 + " and x2 = " + x2;
                }
                else if (d == 0)
                {
                    x1 = x2 = Math.Round((-b / (2 * a)), 2);

                    box_x1.Text = x1.ToString();
                    box_x2.Text = x2.ToString();

                    txt_output.Text = "The roots are Real and Repeated with x1 = x2 = " + x1;
                }
                else
                {
                    x = Math.Round((-b / (2 * a)), 2);
                    y = Math.Round((Math.Sqrt(-d) / (2 * a)), 4);

                    box_x1.Text = x + " + " + y + " i"; 
                    box_x2.Text = x + " - " + y + " i"; 

                    txt_output.Text = "The Roots are complex with x1 = " + x + " + " + y + " i" + " and x2 = " + x + " - " + y + " i";
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Program", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                isWrong = true;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            box_a.Clear();
            box_b.Clear();
            box_c.Clear();
            box_x1.Clear();
            box_x2.Clear();
            txt_output.Text = "";
        }

        private void box_output_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (isCalculated && !isWrong)
            {
                dataGridView1.Rows.Add(box_a.Text, box_b.Text, box_c.Text, box_x1.Text, box_x2.Text);
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

        private void FormQuadraticEquation_Load(object sender, EventArgs e)
        {

        }

        private void txt_output_Click(object sender, EventArgs e)
        {
            
        }
    }
}
