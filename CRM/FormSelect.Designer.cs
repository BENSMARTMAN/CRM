namespace CRM
{
    partial class FormSelect
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
            comboBoxSFE = new ComboBox();
            comboBoxSME = new ComboBox();
            comboBoxCSR = new ComboBox();
            labelSFE = new Label();
            labelSME = new Label();
            labelCSR = new Label();
            comboBoxCustStatus = new ComboBox();
            labelCustStatus = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBoxSFE
            // 
            comboBoxSFE.Font = new Font("微軟正黑體", 13.2000008F);
            comboBoxSFE.FormattingEnabled = true;
            comboBoxSFE.Items.AddRange(new object[] { "蔡志偉", "盧慶宇", "楊川旺" });
            comboBoxSFE.Location = new Point(200, 123);
            comboBoxSFE.Name = "comboBoxSFE";
            comboBoxSFE.Size = new Size(199, 36);
            comboBoxSFE.TabIndex = 61;
            // 
            // comboBoxSME
            // 
            comboBoxSME.Font = new Font("微軟正黑體", 13.2000008F);
            comboBoxSME.FormattingEnabled = true;
            comboBoxSME.Items.AddRange(new object[] { "黃志遠", "陳信宏", "林忠億", "蔡信毅", "黃羽軒", "李俊毅", "林錦凰" });
            comboBoxSME.Location = new Point(200, 81);
            comboBoxSME.Name = "comboBoxSME";
            comboBoxSME.Size = new Size(199, 36);
            comboBoxSME.TabIndex = 60;
            // 
            // comboBoxCSR
            // 
            comboBoxCSR.Font = new Font("微軟正黑體", 13.2000008F);
            comboBoxCSR.FormattingEnabled = true;
            comboBoxCSR.Items.AddRange(new object[] { "何靜惠", "李俊毅", "林錦凰" });
            comboBoxCSR.Location = new Point(200, 37);
            comboBoxCSR.Name = "comboBoxCSR";
            comboBoxCSR.Size = new Size(199, 36);
            comboBoxCSR.TabIndex = 59;
            // 
            // labelSFE
            // 
            labelSFE.AutoSize = true;
            labelSFE.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelSFE.Location = new Point(31, 130);
            labelSFE.Name = "labelSFE";
            labelSFE.Size = new Size(153, 29);
            labelSFE.TabIndex = 58;
            labelSFE.Text = "SF維護工程師";
            // 
            // labelSME
            // 
            labelSME.AutoSize = true;
            labelSME.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelSME.Location = new Point(21, 88);
            labelSME.Name = "labelSME";
            labelSME.Size = new Size(163, 29);
            labelSME.TabIndex = 57;
            labelSME.Text = "SM維護工程師";
            // 
            // labelCSR
            // 
            labelCSR.AutoSize = true;
            labelCSR.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCSR.Location = new Point(79, 44);
            labelCSR.Name = "labelCSR";
            labelCSR.Size = new Size(105, 29);
            labelCSR.TabIndex = 56;
            labelCSR.Text = "權責員工";
            // 
            // comboBoxCustStatus
            // 
            comboBoxCustStatus.Font = new Font("微軟正黑體", 13.2000008F);
            comboBoxCustStatus.FormattingEnabled = true;
            comboBoxCustStatus.Items.AddRange(new object[] { "A.系統評估中", "B.可開發", "C.持續跟進", "D.不考慮,無預算", "E.無續約", "其他" });
            comboBoxCustStatus.Location = new Point(200, 165);
            comboBoxCustStatus.Name = "comboBoxCustStatus";
            comboBoxCustStatus.Size = new Size(199, 36);
            comboBoxCustStatus.TabIndex = 63;
            // 
            // labelCustStatus
            // 
            labelCustStatus.AutoSize = true;
            labelCustStatus.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCustStatus.Location = new Point(79, 172);
            labelCustStatus.Name = "labelCustStatus";
            labelCustStatus.Size = new Size(105, 29);
            labelCustStatus.TabIndex = 62;
            labelCustStatus.Text = "客戶狀態";
            // 
            // button1
            // 
            button1.Font = new Font("微軟正黑體", 13.2000008F);
            button1.Location = new Point(153, 225);
            button1.Name = "button1";
            button1.Size = new Size(114, 41);
            button1.TabIndex = 64;
            button1.Text = "查詢";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("微軟正黑體", 13.2000008F);
            button2.Location = new Point(292, 224);
            button2.Name = "button2";
            button2.Size = new Size(107, 42);
            button2.TabIndex = 65;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormSelect
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 294);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxCustStatus);
            Controls.Add(labelCustStatus);
            Controls.Add(comboBoxSFE);
            Controls.Add(comboBoxSME);
            Controls.Add(comboBoxCSR);
            Controls.Add(labelSFE);
            Controls.Add(labelSME);
            Controls.Add(labelCSR);
            Name = "FormSelect";
            Text = "FormSelect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSFE;
        private ComboBox comboBoxSME;
        private ComboBox comboBoxCSR;
        private Label labelSFE;
        private Label labelSME;
        private Label labelCSR;
        private ComboBox comboBoxCustStatus;
        private Label labelCustStatus;
        private Button button1;
        private Button button2;
    }
}