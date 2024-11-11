namespace CRM
{
    partial class FormToExcel
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
            label1 = new Label();
            textBoxPath = new TextBox();
            label2 = new Label();
            buttonSave = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(168, 29);
            label1.TabIndex = 0;
            label1.Text = "檔案產生路徑 : ";
            // 
            // textBoxPath
            // 
            textBoxPath.Font = new Font("微軟正黑體", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBoxPath.Location = new Point(173, 41);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(469, 37);
            textBoxPath.TabIndex = 1;
            textBoxPath.Text = "按左鍵選擇儲存位置";
            textBoxPath.MouseClick += textBoxPath_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("微軟正黑體", 13.2000008F);
            buttonSave.Location = new Point(373, 109);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(121, 49);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "儲存";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // button2
            // 
            button2.Font = new Font("微軟正黑體", 13.2000008F);
            button2.Location = new Point(521, 109);
            button2.Name = "button2";
            button2.Size = new Size(121, 49);
            button2.TabIndex = 4;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormToExcel
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 188);
            Controls.Add(button2);
            Controls.Add(buttonSave);
            Controls.Add(label2);
            Controls.Add(textBoxPath);
            Controls.Add(label1);
            Name = "FormToExcel";
            Text = "資料轉出";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPath;
        private Label label2;
        private Button buttonSave;
        private Button button2;
    }
}