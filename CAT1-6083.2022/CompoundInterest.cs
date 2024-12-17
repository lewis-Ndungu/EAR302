using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAT1_6083._2022
{
    public partial class FormCompoundInterest : Form
    {
        bool isCalculated = false;
        public FormCompoundInterest()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double principle, frequency, CompoundInterest, rate;
            int time;
            isCalculated = true;

            try
            {
                principle = Convert.ToDouble(box_principle.Text);
                frequency = Convert.ToDouble(box_frequency.Text);
                rate = Convert.ToDouble(box_rate.Text);
                time = Convert.ToInt32(box_time.Text);

                CompoundInterest = Math.Round(principle * Math.Pow((1 + (rate / frequency)), (frequency * time)), 4);
                box_compoundInterest.Text = CompoundInterest.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Program", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        
    }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            box_compoundInterest.Clear();
            box_frequency.Clear();
            box_rate.Clear();
            box_principle.Clear();
            box_time.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (isCalculated)
            {
                dataGridView1.Rows.Add(box_principle.Text, box_frequency.Text, box_rate.Text, box_time.Text, box_compoundInterest.Text);
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
