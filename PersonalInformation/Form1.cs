using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        InputForm inputForm;
        private void button1_Click(object sender, EventArgs e)
        {
            inputForm = new InputForm();
            inputForm.ShowDialog();
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            foreach(PersonalInfo p in inputForm.infoList)
            {
                txtOutput.Text += p.ToString();
                txtOutput.Text += Environment.NewLine;
            }
        }
    }
}
