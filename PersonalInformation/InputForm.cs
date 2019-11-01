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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        public List<PersonalInfo> infoList = new List<PersonalInfo>();
        string name;
        string address;
        string phone;
        int age;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                PersonalInfo info = new PersonalInfo(name, address, age, phone);
                infoList.Add(info);
                MessageBox.Show("Info Submitted");
            }
            else
            {
                MessageBox.Show("Please enter valid input", "Invalid input");
            }
        }

        private bool ValidateInput()
        {
            name = textBox1.Text;
            address = textBox2.Text;
            phone = textBox3.Text;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(address) && !string.IsNullOrWhiteSpace(phone) && int.TryParse(textBox3.Text, out age))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if(infoList.Count > 0)
            {
                this.Close();
            } else
            {
                MessageBox.Show("No information was submitted yet!");
            }
        }
    }
}
