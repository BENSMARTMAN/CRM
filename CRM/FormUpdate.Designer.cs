namespace CRM
{
    partial class FormUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            labelCustomer = new Label();
            labelCustName = new Label();
            labelIndustryRemark = new Label();
            labelAddress = new Label();
            labelWebSite = new Label();
            labelCustStatus = new Label();
            labelCSR = new Label();
            labelSME = new Label();
            labelSFE = new Label();
            labelGSTNo = new Label();
            labelNOE = new Label();
            labelAOC = new Label();
            labelRemark = new Label();
            labelSystem = new Label();
            labelSystemRemark = new Label();
            textBoxCustomer = new TextBox();
            label1 = new Label();
            textBoxCustName = new TextBox();
            textBoxIndustryRemark = new TextBox();
            textBoxAddress = new TextBox();
            textBoxWebSite = new TextBox();
            textBoxGSTNo = new TextBox();
            textBoxNOE = new TextBox();
            textBoxAOC = new TextBox();
            textBoxSystem = new TextBox();
            textBoxSystemRemark = new TextBox();
            buttonUpdate = new Button();
            buttonBack = new Button();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            richTextBoxRemark = new RichTextBox();
            buttonNew = new Button();
            buttonDelete = new Button();
            comboBoxCSR = new ComboBox();
            comboBoxSME = new ComboBox();
            comboBoxSFE = new ComboBox();
            comboBoxCustStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 389);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1924, 251);
            dataGridView1.TabIndex = 0;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCustomer.Location = new Point(12, 23);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(105, 29);
            labelCustomer.TabIndex = 1;
            labelCustomer.Text = "客戶編號";
            // 
            // labelCustName
            // 
            labelCustName.AutoSize = true;
            labelCustName.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCustName.Location = new Point(12, 68);
            labelCustName.Name = "labelCustName";
            labelCustName.Size = new Size(105, 29);
            labelCustName.TabIndex = 2;
            labelCustName.Text = "公司名稱";
            // 
            // labelIndustryRemark
            // 
            labelIndustryRemark.AutoSize = true;
            labelIndustryRemark.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelIndustryRemark.Location = new Point(227, 17);
            labelIndustryRemark.Name = "labelIndustryRemark";
            labelIndustryRemark.Size = new Size(82, 29);
            labelIndustryRemark.TabIndex = 3;
            labelIndustryRemark.Text = "產業別";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelAddress.Location = new Point(40, 200);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(59, 29);
            labelAddress.TabIndex = 4;
            labelAddress.Text = "地址";
            // 
            // labelWebSite
            // 
            labelWebSite.AutoSize = true;
            labelWebSite.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelWebSite.Location = new Point(40, 244);
            labelWebSite.Name = "labelWebSite";
            labelWebSite.Size = new Size(59, 29);
            labelWebSite.TabIndex = 5;
            labelWebSite.Text = "網址";
            // 
            // labelCustStatus
            // 
            labelCustStatus.AutoSize = true;
            labelCustStatus.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCustStatus.Location = new Point(890, 14);
            labelCustStatus.Name = "labelCustStatus";
            labelCustStatus.Size = new Size(105, 29);
            labelCustStatus.TabIndex = 6;
            labelCustStatus.Text = "客戶狀態";
            // 
            // labelCSR
            // 
            labelCSR.AutoSize = true;
            labelCSR.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCSR.Location = new Point(577, 17);
            labelCSR.Name = "labelCSR";
            labelCSR.Size = new Size(105, 29);
            labelCSR.TabIndex = 7;
            labelCSR.Text = "權責員工";
            // 
            // labelSME
            // 
            labelSME.AutoSize = true;
            labelSME.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelSME.Location = new Point(577, 59);
            labelSME.Name = "labelSME";
            labelSME.Size = new Size(163, 29);
            labelSME.TabIndex = 8;
            labelSME.Text = "SM維護工程師";
            // 
            // labelSFE
            // 
            labelSFE.AutoSize = true;
            labelSFE.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelSFE.Location = new Point(577, 100);
            labelSFE.Name = "labelSFE";
            labelSFE.Size = new Size(153, 29);
            labelSFE.TabIndex = 9;
            labelSFE.Text = "SF維護工程師";
            // 
            // labelGSTNo
            // 
            labelGSTNo.AutoSize = true;
            labelGSTNo.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelGSTNo.Location = new Point(12, 112);
            labelGSTNo.Name = "labelGSTNo";
            labelGSTNo.Size = new Size(105, 29);
            labelGSTNo.TabIndex = 10;
            labelGSTNo.Text = "統一編號";
            // 
            // labelNOE
            // 
            labelNOE.AutoSize = true;
            labelNOE.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelNOE.Location = new Point(12, 153);
            labelNOE.Name = "labelNOE";
            labelNOE.Size = new Size(105, 29);
            labelNOE.TabIndex = 11;
            labelNOE.Text = "員工人數";
            // 
            // labelAOC
            // 
            labelAOC.AutoSize = true;
            labelAOC.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelAOC.Location = new Point(198, 150);
            labelAOC.Name = "labelAOC";
            labelAOC.Size = new Size(194, 29);
            labelAOC.TabIndex = 12;
            labelAOC.Text = "資本額 (單位：億)";
            // 
            // labelRemark
            // 
            labelRemark.AutoSize = true;
            labelRemark.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelRemark.Location = new Point(912, 144);
            labelRemark.Name = "labelRemark";
            labelRemark.Size = new Size(59, 29);
            labelRemark.TabIndex = 13;
            labelRemark.Text = "備註";
            // 
            // labelSystem
            // 
            labelSystem.AutoSize = true;
            labelSystem.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelSystem.Location = new Point(912, 55);
            labelSystem.Name = "labelSystem";
            labelSystem.Size = new Size(59, 29);
            labelSystem.TabIndex = 14;
            labelSystem.Text = "系統";
            // 
            // labelSystemRemark
            // 
            labelSystemRemark.AutoSize = true;
            labelSystemRemark.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelSystemRemark.Location = new Point(890, 101);
            labelSystemRemark.Name = "labelSystemRemark";
            labelSystemRemark.Size = new Size(105, 29);
            labelSystemRemark.TabIndex = 15;
            labelSystemRemark.Text = "系統備註";
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxCustomer.Location = new Point(121, 14);
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.Size = new Size(100, 38);
            textBoxCustomer.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(0, 348);
            label1.Name = "label1";
            label1.Size = new Size(133, 29);
            label1.TabIndex = 17;
            label1.Text = "聯絡人名單:";
            // 
            // textBoxCustName
            // 
            textBoxCustName.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxCustName.Location = new Point(121, 59);
            textBoxCustName.Name = "textBoxCustName";
            textBoxCustName.Size = new Size(441, 38);
            textBoxCustName.TabIndex = 18;
            // 
            // textBoxIndustryRemark
            // 
            textBoxIndustryRemark.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxIndustryRemark.Location = new Point(315, 12);
            textBoxIndustryRemark.Name = "textBoxIndustryRemark";
            textBoxIndustryRemark.Size = new Size(247, 38);
            textBoxIndustryRemark.TabIndex = 19;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxAddress.Location = new Point(121, 191);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(754, 38);
            textBoxAddress.TabIndex = 20;
            // 
            // textBoxWebSite
            // 
            textBoxWebSite.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxWebSite.Location = new Point(121, 235);
            textBoxWebSite.Name = "textBoxWebSite";
            textBoxWebSite.Size = new Size(754, 38);
            textBoxWebSite.TabIndex = 21;
            // 
            // textBoxGSTNo
            // 
            textBoxGSTNo.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxGSTNo.Location = new Point(121, 103);
            textBoxGSTNo.Name = "textBoxGSTNo";
            textBoxGSTNo.Size = new Size(155, 38);
            textBoxGSTNo.TabIndex = 26;
            // 
            // textBoxNOE
            // 
            textBoxNOE.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxNOE.Location = new Point(121, 144);
            textBoxNOE.Name = "textBoxNOE";
            textBoxNOE.Size = new Size(81, 38);
            textBoxNOE.TabIndex = 27;
            // 
            // textBoxAOC
            // 
            textBoxAOC.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxAOC.Location = new Point(398, 141);
            textBoxAOC.Name = "textBoxAOC";
            textBoxAOC.Size = new Size(78, 38);
            textBoxAOC.TabIndex = 28;
            // 
            // textBoxSystem
            // 
            textBoxSystem.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxSystem.Location = new Point(1001, 50);
            textBoxSystem.Name = "textBoxSystem";
            textBoxSystem.Size = new Size(199, 38);
            textBoxSystem.TabIndex = 30;
            // 
            // textBoxSystemRemark
            // 
            textBoxSystemRemark.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxSystemRemark.Location = new Point(1001, 92);
            textBoxSystemRemark.Name = "textBoxSystemRemark";
            textBoxSystemRemark.Size = new Size(898, 38);
            textBoxSystemRemark.TabIndex = 31;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonUpdate.Location = new Point(629, 279);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(120, 44);
            buttonUpdate.TabIndex = 32;
            buttonUpdate.Text = "存檔";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonBack.Location = new Point(755, 279);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(120, 44);
            buttonBack.TabIndex = 33;
            buttonBack.Text = "返回";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(1438, 207);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(8, 8);
            cartesianChart1.TabIndex = 34;
            // 
            // richTextBoxRemark
            // 
            richTextBoxRemark.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            richTextBoxRemark.Location = new Point(1002, 141);
            richTextBoxRemark.Name = "richTextBoxRemark";
            richTextBoxRemark.Size = new Size(897, 205);
            richTextBoxRemark.TabIndex = 35;
            richTextBoxRemark.Text = "";
            // 
            // buttonNew
            // 
            buttonNew.Font = new Font("微軟正黑體", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonNew.Location = new Point(136, 342);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(150, 41);
            buttonNew.TabIndex = 36;
            buttonNew.Text = "新增聯絡人";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("微軟正黑體", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonDelete.Location = new Point(302, 342);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(155, 41);
            buttonDelete.TabIndex = 37;
            buttonDelete.Text = "刪除聯絡人";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // comboBoxCSR
            // 
            comboBoxCSR.Font = new Font("微軟正黑體", 13.2000008F);
            comboBoxCSR.FormattingEnabled = true;
            comboBoxCSR.Items.AddRange(new object[] { "何靜惠", "李俊毅", "林錦凰" });
            comboBoxCSR.Location = new Point(736, 10);
            comboBoxCSR.Name = "comboBoxCSR";
            comboBoxCSR.Size = new Size(151, 36);
            comboBoxCSR.TabIndex = 38;
            // 
            // comboBoxSME
            // 
            comboBoxSME.Font = new Font("微軟正黑體", 13.2000008F);
            comboBoxSME.FormattingEnabled = true;
            comboBoxSME.Items.AddRange(new object[] { "黃志遠", "陳信宏", "林忠億", "蔡信毅", "黃羽軒", "李俊毅", "林錦凰" });
            comboBoxSME.Location = new Point(736, 51);
            comboBoxSME.Name = "comboBoxSME";
            comboBoxSME.Size = new Size(151, 36);
            comboBoxSME.TabIndex = 39;
            // 
            // comboBoxSFE
            // 
            comboBoxSFE.Font = new Font("微軟正黑體", 13.2000008F);
            comboBoxSFE.FormattingEnabled = true;
            comboBoxSFE.Items.AddRange(new object[] { "蔡志偉", "盧慶宇", "楊川旺" });
            comboBoxSFE.Location = new Point(736, 92);
            comboBoxSFE.Name = "comboBoxSFE";
            comboBoxSFE.Size = new Size(151, 36);
            comboBoxSFE.TabIndex = 40;
            // 
            // comboBoxCustStatus
            // 
            comboBoxCustStatus.Font = new Font("微軟正黑體", 13.2000008F);
            comboBoxCustStatus.FormattingEnabled = true;
            comboBoxCustStatus.Items.AddRange(new object[] { "A.系統評估中", "B.可開發", "C.持續跟進", "D.不考慮,無預算", "E.無續約", "其他" });
            comboBoxCustStatus.Location = new Point(1001, 10);
            comboBoxCustStatus.Name = "comboBoxCustStatus";
            comboBoxCustStatus.Size = new Size(199, 36);
            comboBoxCustStatus.TabIndex = 41;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 640);
            Controls.Add(comboBoxCustStatus);
            Controls.Add(comboBoxSFE);
            Controls.Add(comboBoxSME);
            Controls.Add(comboBoxCSR);
            Controls.Add(buttonDelete);
            Controls.Add(buttonNew);
            Controls.Add(richTextBoxRemark);
            Controls.Add(cartesianChart1);
            Controls.Add(buttonBack);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxSystemRemark);
            Controls.Add(textBoxSystem);
            Controls.Add(textBoxAOC);
            Controls.Add(textBoxNOE);
            Controls.Add(textBoxGSTNo);
            Controls.Add(textBoxWebSite);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxIndustryRemark);
            Controls.Add(textBoxCustName);
            Controls.Add(label1);
            Controls.Add(textBoxCustomer);
            Controls.Add(labelSystemRemark);
            Controls.Add(labelSystem);
            Controls.Add(labelRemark);
            Controls.Add(labelAOC);
            Controls.Add(labelNOE);
            Controls.Add(labelGSTNo);
            Controls.Add(labelSFE);
            Controls.Add(labelSME);
            Controls.Add(labelCSR);
            Controls.Add(labelCustStatus);
            Controls.Add(labelWebSite);
            Controls.Add(labelAddress);
            Controls.Add(labelIndustryRemark);
            Controls.Add(labelCustName);
            Controls.Add(labelCustomer);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormUpdate";
            Text = "公司資訊";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelCustomer;
        private Label labelCustName;
        private Label labelIndustryRemark;
        private Label labelAddress;
        private Label labelWebSite;
        private Label labelCustStatus;
        private Label labelCSR;
        private Label labelSME;
        private Label labelSFE;
        private Label labelGSTNo;
        private Label labelNOE;
        private Label labelAOC;
        private Label labelRemark;
        private Label labelSystem;
        private Label labelSystemRemark;
        private TextBox textBoxCustomer;
        private Label label1;
        private TextBox textBoxCustName;
        private TextBox textBoxIndustryRemark;
        private TextBox textBoxAddress;
        private TextBox textBoxWebSite;
        private TextBox textBoxGSTNo;
        private TextBox textBoxNOE;
        private TextBox textBoxAOC;
        private TextBox textBoxSystem;
        private TextBox textBoxSystemRemark;
        private Button buttonUpdate;
        private Button buttonBack;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private RichTextBox richTextBoxRemark;
        private Button buttonNew;
        private Button buttonDelete;
        private ComboBox comboBoxCSR;
        private ComboBox comboBoxSME;
        private ComboBox comboBoxSFE;
        private ComboBox comboBoxCustStatus;
    }
}