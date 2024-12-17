using System;
using System.Windows.Forms;

namespace CAT1_6083._2022
{
    public partial class FormOhmsLaw : Form
    {
        bool isCalculated = false;
        public FormOhmsLaw()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double current, voltage, resistance;
            isCalculated = true;

            try
            {
                voltage = Convert.ToDouble(box_voltage.Text);
                resistance= Convert.ToDouble(box_resistance.Text);

                current = Math.Round(voltage / resistance, 4);
                box_current.Text = current.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Program", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        
    }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            box_voltage.Clear();
            box_resistance.Clear();
            box_current.Clear();
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (isCalculated)
            {
                dataGridView1.Rows.Add(box_voltage.Text, box_resistance.Text, box_current.Text);
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
