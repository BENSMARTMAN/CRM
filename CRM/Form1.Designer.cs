namespace CRM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            SearchBox = new TextBox();
            label3 = new Label();
            buttonNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1466, 680);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 67);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(353, 44);
            button1.Name = "button1";
            button1.Size = new Size(111, 31);
            button1.TabIndex = 2;
            button1.Text = "條件查詢";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 86);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 3;
            label2.Text = "快速查詢:";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(96, 78);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(238, 27);
            SearchBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 56);
            label3.Name = "label3";
            label3.Size = new Size(214, 19);
            label3.TabIndex = 5;
            label3.Text = "(請輸入公司代碼或關鍵字名稱)";
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(353, 74);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(111, 31);
            buttonNew.TabIndex = 6;
            buttonNew.Text = "新增客戶名單";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 817);
            Controls.Add(buttonNew);
            Controls.Add(label3);
            Controls.Add(SearchBox);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "CRM_客戶資料管理系統";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox SearchBox;
        private Label label3;
        private Button buttonNew;
    }
}
