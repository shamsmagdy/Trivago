using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace ODP1_Connected_Start
{
    public partial class Form1 : Form
    {
        CrystalReport1 cr1;
        CrystalReport2 cr2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr1.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cr1 = new CrystalReport1();
            cr2 = new CrystalReport2();
            foreach(ParameterDiscreteValue v in cr1.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr2;

        }
    }
}
