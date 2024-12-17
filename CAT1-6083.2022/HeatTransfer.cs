using System;
using System.Windows.Forms;

namespace CAT1_6083._2022
{
    public partial class FormHeatTransfer : Form
    {
        bool isCalculated = false;
        public FormHeatTransfer()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double mass, tempChange, specificHeat, heatTransfer;
            isCalculated = true;

            try
            {
                mass = Convert.ToDouble(box_mass.Text);
                tempChange = Convert.ToDouble(box_temperatureChange.Text);
                specificHeat = Convert.ToDouble(box_specificHeat.Text);

                heatTransfer = Math.Round(mass * tempChange * specificHeat, 4);
                box_heatTransfer.Text = heatTransfer.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Program", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            box_mass.Clear();
            box_temperatureChange.Clear();
            box_specificHeat.Clear();
            box_heatTransfer.Clear();
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (isCalculated)
            {
                dataGridView1.Rows.Add(box_mass.Text, box_specificHeat.Text, box_temperatureChange.Text ,box_heatTransfer.Text);
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

