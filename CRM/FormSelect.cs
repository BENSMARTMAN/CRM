using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class FormSelect : Form
    {
        public string SelectedCSR { get; set; }
        public string SelectedSME { get; set; }
        public string SelectedSFE { get; set; }
        public string SelectedCustStatus { get; set; }
        public FormSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedCSR = comboBoxCSR.SelectedItem?.ToString();
            SelectedSME = comboBoxSME.SelectedItem?.ToString();
            SelectedSFE = comboBoxSFE.SelectedItem?.ToString();
            SelectedCustStatus = comboBoxCustStatus.SelectedItem?.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
