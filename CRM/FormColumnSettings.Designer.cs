namespace CRM
{
    partial class FormColumnSettings
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
            checkedListBox = new CheckedListBox();
            label1 = new Label();
            btnSelectAll = new Button();
            btnDeselectAll = new Button();
            listBoxConfigNames = new ListBox();
            buttonOk = new Button();
            button4 = new Button();
            buttonSave = new Button();
            txtConfigName = new TextBox();
            label2 = new Label();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // checkedListBox
            // 
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Items.AddRange(new object[] { "客戶編號", "客戶名稱", "產業別", "地址", "網址", "客戶狀態", "權責員工", "SM維護工程師", "SF維護工程師", "統一編號", "員工人數", "資本額 (單位：億)", "備註", "系統", "系統備註", "主要聯絡人", "部門", "職稱", "電話", "傳真", "行動電話", "Email", "聯絡人備註" });
            checkedListBox.Location = new Point(61, 84);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(191, 334);
            checkedListBox.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 27);
            label1.Name = "label1";
            label1.Size = new Size(151, 19);
            label1.TabIndex = 24;
            label1.Text = "請選擇要顯示的欄位 :";
            // 
            // btnSelectAll
            // 
            btnSelectAll.Location = new Point(61, 49);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(94, 29);
            btnSelectAll.TabIndex = 25;
            btnSelectAll.Text = "全顯";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // btnDeselectAll
            // 
            btnDeselectAll.Location = new Point(158, 49);
            btnDeselectAll.Name = "btnDeselectAll";
            btnDeselectAll.Size = new Size(94, 29);
            btnDeselectAll.TabIndex = 26;
            btnDeselectAll.Text = "全隱";
            btnDeselectAll.UseVisualStyleBackColor = true;
            btnDeselectAll.Click += btnDeselectAll_Click;
            // 
            // listBoxConfigNames
            // 
            listBoxConfigNames.FormattingEnabled = true;
            listBoxConfigNames.ItemHeight = 19;
            listBoxConfigNames.Location = new Point(282, 84);
            listBoxConfigNames.Name = "listBoxConfigNames";
            listBoxConfigNames.Size = new Size(317, 327);
            listBoxConfigNames.TabIndex = 27;
            listBoxConfigNames.DoubleClick += listBoxConfigNames_DoubleClick;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(282, 441);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 28;
            buttonOk.Text = "確定";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // button4
            // 
            button4.Location = new Point(393, 441);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 29;
            button4.Text = "返回";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(282, 17);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 30;
            buttonSave.Text = "儲存欄位";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // txtConfigName
            // 
            txtConfigName.Location = new Point(432, 52);
            txtConfigName.Name = "txtConfigName";
            txtConfigName.Size = new Size(167, 27);
            txtConfigName.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 55);
            label2.Name = "label2";
            label2.Size = new Size(151, 19);
            label2.TabIndex = 32;
            label2.Text = "請輸入儲存欄位名稱 :";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(382, 17);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 33;
            buttonDelete.Text = "刪除欄位";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormColumnSettings
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 494);
            Controls.Add(buttonDelete);
            Controls.Add(label2);
            Controls.Add(txtConfigName);
            Controls.Add(buttonSave);
            Controls.Add(button4);
            Controls.Add(buttonOk);
            Controls.Add(listBoxConfigNames);
            Controls.Add(btnDeselectAll);
            Controls.Add(btnSelectAll);
            Controls.Add(label1);
            Controls.Add(checkedListBox);
            Name = "FormColumnSettings";
            Text = "選擇欄位";
            Load += FormColumnSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkedListBox;
        private Label label1;
        private Button btnSelectAll;
        private Button btnDeselectAll;
        private ListBox listBoxConfigNames;
        private Button buttonOk;
        private Button button4;
        private Button buttonSave;
        private TextBox txtConfigName;
        private Label label2;
        private Button buttonDelete;
    }
}