using System;
using System.Windows.Forms;

namespace CAT1_6083._2022
{
    public partial class FormTemperatureConverter : Form
    {
        bool isCalculatedFahrenheit, isCalculatedCelcius = false;
        public FormTemperatureConverter()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double celcius, fahrenheit;
            isCalculatedFahrenheit = true;

            try
            {
                celcius = Convert.ToDouble(box_celcius.Text);

                fahrenheit = Math.Round((9 * celcius / 5) + 32, 2);
                box_fahrenheit.Text = fahrenheit.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Program", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void FormTemperatureConverter_Load(object sender, EventArgs e)
        {

        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            box_celcius.Clear();
            box_fahrenheit.Clear();
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (isCalculatedFahrenheit)
            {
                dataGridView1.Rows.Add(box_celcius.Text, box_fahrenheit.Text);
                isCalculatedFahrenheit = false;
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

        private void btn_calculate01_Click(object sender, EventArgs e)
        {
            double celcius, fahrenheit;
            isCalculatedCelcius = true;

            try
            {
                fahrenheit = Convert.ToDouble(box_fahrenheit01.Text);

                celcius = Math.Round((5D / 9D) * (fahrenheit - 32), 2);
                box_celcius01.Text = celcius.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Program", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel01_Click(object sender, EventArgs e)
        {
            box_fahrenheit01.Clear();
            box_celcius01.Clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_post01_Click(object sender, EventArgs e)
        {
            if (isCalculatedCelcius)
            {
                dataGridView2.Rows.Add(box_fahrenheit01.Text, box_celcius01.Text);
                isCalculatedCelcius = false;
            }
            else
            {
                MessageBox.Show("Please Calculate First before Posting.", "Posting Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btn_clear_db01_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }
    }
    }

