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
    public partial class FormToExcel : Form
    {
        public string SelectedPath { get; private set; } // 用於儲存選擇的路徑
        public FormToExcel()
        {
            InitializeComponent();
        }

        private void textBoxPath_MouseClick(object sender, MouseEventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 預設為文件夾
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.FileName = $"customerlist_{DateTime.Now:yyyyMMdd}.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedPath = saveFileDialog.FileName;
                    textBoxPath.Text = SelectedPath;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedPath))
            {
                MessageBox.Show("請選擇儲存路徑", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 呼叫 Form1 的匯出方法，並將選擇的路徑傳入
            Form1 mainForm = (Form1)Application.OpenForms["Form1"];
            mainForm.ExportDataGridViewToExcel(SelectedPath);
            MessageBox.Show("資料已成功匯出至 Excel！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
