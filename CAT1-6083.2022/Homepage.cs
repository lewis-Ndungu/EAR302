using System;
using System.Windows.Forms;

namespace CAT1_6083._2022
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            showToolStripMenuItem.Checked = true;
        }

        private void curvedSurfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCurvedSurfaceCylinder dfrm = new FormCurvedSurfaceCylinder();
            dfrm.MdiParent = this;
            dfrm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormHeatTransfer dfrm = new FormHeatTransfer();
            dfrm.MdiParent = this;
            dfrm.Show();
        }

        private void temperatureConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemperatureConverter dfrm = new FormTemperatureConverter();
            dfrm.MdiParent = this;
            dfrm.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FormPythagorasTheorem dfrm = new FormPythagorasTheorem();
            dfrm.MdiParent = this;
            dfrm.Show();
        }

        private void ohmsLawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOhmsLaw dfrm = new FormOhmsLaw();
            dfrm.MdiParent = this;
            dfrm.Show();
        }

        private void bMICalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormElectricalConductivityCalculator dfrm = new FormElectricalConductivityCalculator();
            dfrm.MdiParent = this;
            dfrm.Show();
        }

        private void distanceBetween2PointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDistanceBetweenTwoPoints dfrm = new FormDistanceBetweenTwoPoints();
            dfrm.MdiParent = this;
            dfrm.Show();
        }

        private void compoundInterestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompoundInterest dfrm = new FormCompoundInterest();
            dfrm.MdiParent = this;
            dfrm.Show();
        }

        private void workDoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWorkDone dfrm = new FormWorkDone();
            dfrm.MdiParent = this;
            dfrm.Show();
        }

        private void quadraticEquationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuadraticEquation dfrm = new FormQuadraticEquation();
            dfrm.MdiParent = this;
            dfrm.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void fileHandlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormFileHandling dfrm = new FormFileHandling();
            FormStudentDetails dfrm = new FormStudentDetails();
            dfrm.MdiParent = this;
            dfrm.Show();
        }

        private void txt_name_Click(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_name.Visible = false;
            txt_adminissionNumber.Visible = false;
            txt_unitCode.Visible = false;
            txt_unitTitle.Visible = false;
            showToolStripMenuItem.Checked = false;
            hideToolStripMenuItem.Checked = true;
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_name.Visible = true;
            txt_adminissionNumber.Visible = true;
            txt_unitCode.Visible = true;
            txt_unitTitle.Visible = true;
            showToolStripMenuItem.Checked = true;
            hideToolStripMenuItem.Checked = false;
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_name.Visible = false;
            txt_adminissionNumber.Visible = false;
            txt_unitCode.Visible = false;
            txt_unitTitle.Visible = false;
            showToolStripMenuItem.Checked = false;
            hideToolStripMenuItem.Checked = true;
        }
    }
}
