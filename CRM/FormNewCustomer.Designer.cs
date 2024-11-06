namespace CRM
{
    partial class FormNewCustomer
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
            labelCustomer = new Label();
            labelSystemRemark = new Label();
            labelSystem = new Label();
            labelRemark = new Label();
            labelAOC = new Label();
            labelNOE = new Label();
            labelGSTNo = new Label();
            labelSFE = new Label();
            labelSME = new Label();
            labelCSR = new Label();
            labelCustStatus = new Label();
            labelWebSite = new Label();
            labelAddress = new Label();
            labelIndustryRemark = new Label();
            labelCustName = new Label();
            comboBoxCustStatus = new ComboBox();
            comboBoxSFE = new ComboBox();
            comboBoxSME = new ComboBox();
            comboBoxCSR = new ComboBox();
            richTextBoxRemark = new RichTextBox();
            textBoxSystemRemark = new TextBox();
            textBoxSystem = new TextBox();
            textBoxAOC = new TextBox();
            textBoxNOE = new TextBox();
            textBoxGSTNo = new TextBox();
            textBoxWebSite = new TextBox();
            textBoxAddress = new TextBox();
            textBoxIndustryRemark = new TextBox();
            textBoxCustName = new TextBox();
            textBoxCustomer = new TextBox();
            buttonSave = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCustomer.Location = new Point(12, 31);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(105, 29);
            labelCustomer.TabIndex = 2;
            labelCustomer.Text = "客戶編號";
            // 
            // labelSystemRemark
            // 
            labelSystemRemark.AutoSize = true;
            labelSystemRemark.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelSystemRemark.Location = new Point(917, 117);
            labelSystemRemark.Name = "labelSystemRemark";
            labelSystemRemark.Size = new Size(105, 29);
            labelSystemRemark.TabIndex = 29;
            labelSystemRemark.Text = "系統備註";
            // 
            // labelSystem
            // 
            labelSystem.AutoSize = true;
            labelSystem.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelSystem.Location = new Point(939, 70);
            labelSystem.Name = "labelSystem";
            labelSystem.Size = new Size(59, 29);
            labelSystem.TabIndex = 28;
            labelSystem.Text = "系統";
            // 
            // labelRemark
            // 
            labelRemark.AutoSize = true;
            labelRemark.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelRemark.Location = new Point(939, 161);
            labelRemark.Name = "labelRemark";
            labelRemark.Size = new Size(59, 29);
            labelRemark.TabIndex = 27;
            labelRemark.Text = "備註";
            // 
            // labelAOC
            // 
            labelAOC.AutoSize = true;
            labelAOC.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelAOC.Location = new Point(210, 161);
            labelAOC.Name = "labelAOC";
            labelAOC.Size = new Size(194, 29);
            labelAOC.TabIndex = 26;
            labelAOC.Text = "資本額 (單位：億)";
            // 
            // labelNOE
            // 
            labelNOE.AutoSize = true;
            labelNOE.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelNOE.Location = new Point(12, 161);
            labelNOE.Name = "labelNOE";
            labelNOE.Size = new Size(105, 29);
            labelNOE.TabIndex = 25;
            labelNOE.Text = "員工人數";
            // 
            // labelGSTNo
            // 
            labelGSTNo.AutoSize = true;
            labelGSTNo.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelGSTNo.Location = new Point(12, 117);
            labelGSTNo.Name = "labelGSTNo";
            labelGSTNo.Size = new Size(105, 29);
            labelGSTNo.TabIndex = 24;
            labelGSTNo.Text = "統一編號";
            // 
            // labelSFE
            // 
            labelSFE.AutoSize = true;
            labelSFE.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelSFE.Location = new Point(580, 117);
            labelSFE.Name = "labelSFE";
            labelSFE.Size = new Size(153, 29);
            labelSFE.TabIndex = 23;
            labelSFE.Text = "SF維護工程師";
            // 
            // labelSME
            // 
            labelSME.AutoSize = true;
            labelSME.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelSME.Location = new Point(580, 70);
            labelSME.Name = "labelSME";
            labelSME.Size = new Size(163, 29);
            labelSME.TabIndex = 22;
            labelSME.Text = "SM維護工程師";
            // 
            // labelCSR
            // 
            labelCSR.AutoSize = true;
            labelCSR.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCSR.Location = new Point(580, 31);
            labelCSR.Name = "labelCSR";
            labelCSR.Size = new Size(105, 29);
            labelCSR.TabIndex = 21;
            labelCSR.Text = "權責員工";
            // 
            // labelCustStatus
            // 
            labelCustStatus.AutoSize = true;
            labelCustStatus.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCustStatus.Location = new Point(917, 31);
            labelCustStatus.Name = "labelCustStatus";
            labelCustStatus.Size = new Size(105, 29);
            labelCustStatus.TabIndex = 20;
            labelCustStatus.Text = "客戶狀態";
            // 
            // labelWebSite
            // 
            labelWebSite.AutoSize = true;
            labelWebSite.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelWebSite.Location = new Point(41, 252);
            labelWebSite.Name = "labelWebSite";
            labelWebSite.Size = new Size(59, 29);
            labelWebSite.TabIndex = 19;
            labelWebSite.Text = "網址";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelAddress.Location = new Point(41, 202);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(59, 29);
            labelAddress.TabIndex = 18;
            labelAddress.Text = "地址";
            // 
            // labelIndustryRemark
            // 
            labelIndustryRemark.AutoSize = true;
            labelIndustryRemark.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelIndustryRemark.Location = new Point(229, 31);
            labelIndustryRemark.Name = "labelIndustryRemark";
            labelIndustryRemark.Size = new Size(82, 29);
            labelIndustryRemark.TabIndex = 17;
            labelIndustryRemark.Text = "產業別";
            // 
            // labelCustName
            // 
            labelCustName.AutoSize = true;
            labelCustName.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCustName.Location = new Point(12, 70);
            labelCustName.Name = "labelCustName";
            labelCustName.Size = new Size(105, 29);
            labelCustName.TabIndex = 16;
            labelCustName.Text = "公司名稱";
            // 
            // comboBoxCustStatus
            // 
            comboBoxCustStatus.Font = new Font("微軟正黑體", 13.2000008F);
            comboBoxCustStatus.FormattingEnabled = true;
            comboBoxCustStatus.Items.AddRange(new object[] { "A.系統評估中", "B.可開發", "C.持續跟進", "D.不考慮,無預算", "E.無續約", "其他" });
            comboBoxCustStatus.Location = new Point(1031, 24);
            comboBoxCustStatus.Name = "comboBoxCustStatus";
            comboBoxCustStatus.Size = new Size(199, 36);
            comboBoxCustStatus.TabIndex = 56;
            // 
            // comboBoxSFE
            // 
            comboBoxSFE.Font = new Font("微軟正黑體", 13.2000008F);
            comboBoxSFE.FormattingEnabled = true;
            comboBoxSFE.Items.AddRange(new object[] { "蔡志偉", "盧慶宇", "楊川旺" });
            comboBoxSFE.Location = new Point(749, 110);
            comboBoxSFE.Name = "comboBoxSFE";
            comboBoxSFE.Size = new Size(151, 36);
            comboBoxSFE.TabIndex = 55;
            // 
            // comboBoxSME
            // 
            comboBoxSME.Font = new Font("微軟正黑體", 13.2000008F);
            comboBoxSME.FormattingEnabled = true;
            comboBoxSME.Items.AddRange(new object[] { "黃志遠", "陳信宏", "林忠億", "蔡信毅", "黃羽軒", "李俊毅", "林錦凰" });
            comboBoxSME.Location = new Point(749, 68);
            comboBoxSME.Name = "comboBoxSME";
            comboBoxSME.Size = new Size(151, 36);
            comboBoxSME.TabIndex = 54;
            // 
            // comboBoxCSR
            // 
            comboBoxCSR.Font = new Font("微軟正黑體", 13.2000008F);
            comboBoxCSR.FormattingEnabled = true;
            comboBoxCSR.Items.AddRange(new object[] { "何靜惠", "李俊毅", "林錦凰" });
            comboBoxCSR.Location = new Point(749, 24);
            comboBoxCSR.Name = "comboBoxCSR";
            comboBoxCSR.Size = new Size(151, 36);
            comboBoxCSR.TabIndex = 53;
            // 
            // richTextBoxRemark
            // 
            richTextBoxRemark.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            richTextBoxRemark.Location = new Point(1031, 161);
            richTextBoxRemark.Name = "richTextBoxRemark";
            richTextBoxRemark.Size = new Size(763, 205);
            richTextBoxRemark.TabIndex = 52;
            richTextBoxRemark.Text = "";
            // 
            // textBoxSystemRemark
            // 
            textBoxSystemRemark.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxSystemRemark.Location = new Point(1031, 114);
            textBoxSystemRemark.Name = "textBoxSystemRemark";
            textBoxSystemRemark.Size = new Size(763, 38);
            textBoxSystemRemark.TabIndex = 51;
            // 
            // textBoxSystem
            // 
            textBoxSystem.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxSystem.Location = new Point(1031, 66);
            textBoxSystem.Name = "textBoxSystem";
            textBoxSystem.Size = new Size(199, 38);
            textBoxSystem.TabIndex = 50;
            // 
            // textBoxAOC
            // 
            textBoxAOC.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxAOC.Location = new Point(410, 152);
            textBoxAOC.Name = "textBoxAOC";
            textBoxAOC.Size = new Size(78, 38);
            textBoxAOC.TabIndex = 49;
            // 
            // textBoxNOE
            // 
            textBoxNOE.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxNOE.Location = new Point(123, 152);
            textBoxNOE.Name = "textBoxNOE";
            textBoxNOE.Size = new Size(81, 38);
            textBoxNOE.TabIndex = 48;
            // 
            // textBoxGSTNo
            // 
            textBoxGSTNo.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxGSTNo.Location = new Point(123, 108);
            textBoxGSTNo.Name = "textBoxGSTNo";
            textBoxGSTNo.Size = new Size(155, 38);
            textBoxGSTNo.TabIndex = 47;
            // 
            // textBoxWebSite
            // 
            textBoxWebSite.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxWebSite.Location = new Point(123, 243);
            textBoxWebSite.Name = "textBoxWebSite";
            textBoxWebSite.Size = new Size(754, 38);
            textBoxWebSite.TabIndex = 46;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxAddress.Location = new Point(123, 199);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(754, 38);
            textBoxAddress.TabIndex = 45;
            // 
            // textBoxIndustryRemark
            // 
            textBoxIndustryRemark.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxIndustryRemark.Location = new Point(317, 22);
            textBoxIndustryRemark.Name = "textBoxIndustryRemark";
            textBoxIndustryRemark.Size = new Size(247, 38);
            textBoxIndustryRemark.TabIndex = 44;
            // 
            // textBoxCustName
            // 
            textBoxCustName.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxCustName.Location = new Point(123, 67);
            textBoxCustName.Name = "textBoxCustName";
            textBoxCustName.Size = new Size(441, 38);
            textBoxCustName.TabIndex = 43;
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxCustomer.Location = new Point(123, 22);
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.Size = new Size(100, 38);
            textBoxCustomer.TabIndex = 42;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonSave.Location = new Point(613, 299);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(120, 44);
            buttonSave.TabIndex = 57;
            buttonSave.Text = "存檔";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonBack.Location = new Point(757, 299);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(120, 44);
            buttonBack.TabIndex = 58;
            buttonBack.Text = "返回";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // FormNewCustomer
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 391);
            Controls.Add(buttonBack);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxCustStatus);
            Controls.Add(comboBoxSFE);
            Controls.Add(comboBoxSME);
            Controls.Add(comboBoxCSR);
            Controls.Add(richTextBoxRemark);
            Controls.Add(textBoxSystemRemark);
            Controls.Add(textBoxSystem);
            Controls.Add(textBoxAOC);
            Controls.Add(textBoxNOE);
            Controls.Add(textBoxGSTNo);
            Controls.Add(textBoxWebSite);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxIndustryRemark);
            Controls.Add(textBoxCustName);
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
            Name = "FormNewCustomer";
            Text = "FormNewCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCustomer;
        private Label labelSystemRemark;
        private Label labelSystem;
        private Label labelRemark;
        private Label labelAOC;
        private Label labelNOE;
        private Label labelGSTNo;
        private Label labelSFE;
        private Label labelSME;
        private Label labelCSR;
        private Label labelCustStatus;
        private Label labelWebSite;
        private Label labelAddress;
        private Label labelIndustryRemark;
        private Label labelCustName;
        private ComboBox comboBoxCustStatus;
        private ComboBox comboBoxSFE;
        private ComboBox comboBoxSME;
        private ComboBox comboBoxCSR;
        private RichTextBox richTextBoxRemark;
        private TextBox textBoxSystemRemark;
        private TextBox textBoxSystem;
        private TextBox textBoxAOC;
        private TextBox textBoxNOE;
        private TextBox textBoxGSTNo;
        private TextBox textBoxWebSite;
        private TextBox textBoxAddress;
        private TextBox textBoxIndustryRemark;
        private TextBox textBoxCustName;
        private TextBox textBoxCustomer;
        private Button buttonSave;
        private Button buttonBack;
    }
}