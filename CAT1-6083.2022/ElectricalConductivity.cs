using System;
using System.Windows.Forms;

namespace CAT1_6083._2022
{
    public partial class FormElectricalConductivityCalculator : Form
    {
        bool isCalculated = false;
        public FormElectricalConductivityCalculator()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double length, crossSectionalArea, resistance, sensitivity;
            isCalculated = true;

            try
            {
                length = Convert.ToDouble(box_length.Text);
                crossSectionalArea = Convert.ToDouble(box_crossSectionalArea.Text);
                resistance = Convert.ToDouble(box_resistance.Text);

                sensitivity = Math.Round((length / (crossSectionalArea * resistance)), 4);
                box_sensitivity.Text = sensitivity.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Program", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        
    }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            box_length.Clear();
            box_crossSectionalArea.Clear();
            box_resistance.Clear();
            box_sensitivity.Clear();
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (isCalculated)
            {
                dataGridView1.Rows.Add(box_length.Text, box_crossSectionalArea.Text, box_resistance.Text, box_sensitivity.Text);
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

        private void FormBMICalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
