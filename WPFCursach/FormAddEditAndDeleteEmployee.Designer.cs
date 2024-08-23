namespace WPFCursach
{
    partial class FormAddEditAndDeleteEmployee
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.cbNameEmployee = new System.Windows.Forms.ComboBox();
            this.labelSelectEmployee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbExp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.labelEnterNameEmployee = new System.Windows.Forms.Label();
            this.tbNameEmployee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.AutoSize = true;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(10, 191);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(347, 36);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cbNameEmployee
            // 
            this.cbNameEmployee.FormattingEnabled = true;
            this.cbNameEmployee.Location = new System.Drawing.Point(6, 35);
            this.cbNameEmployee.Name = "cbNameEmployee";
            this.cbNameEmployee.Size = new System.Drawing.Size(162, 21);
            this.cbNameEmployee.TabIndex = 1;
            this.cbNameEmployee.SelectedIndexChanged += new System.EventHandler(this.cbNameEmployee_SelectedIndexChanged);
            // 
            // labelSelectEmployee
            // 
            this.labelSelectEmployee.AutoSize = true;
            this.labelSelectEmployee.Location = new System.Drawing.Point(3, 19);
            this.labelSelectEmployee.Name = "labelSelectEmployee";
            this.labelSelectEmployee.Size = new System.Drawing.Size(144, 13);
            this.labelSelectEmployee.TabIndex = 2;
            this.labelSelectEmployee.Text = "Выберите имя сотрудника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите телефон сотроудника:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(6, 97);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(162, 20);
            this.tbPhone.TabIndex = 4;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(6, 148);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(162, 20);
            this.tbAdress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите адрес сотрудника:";
            // 
            // tbExp
            // 
            this.tbExp.Location = new System.Drawing.Point(189, 97);
            this.tbExp.Name = "tbExp";
            this.tbExp.Size = new System.Drawing.Size(168, 20);
            this.tbExp.TabIndex = 8;
            this.tbExp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите стаж сотрудника:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Выберите магазин:";
            // 
            // cbStore
            // 
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(189, 35);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(168, 21);
            this.cbStore.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Выберите категорию:\r\n";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(189, 148);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(168, 21);
            this.cbCategories.TabIndex = 11;
            // 
            // labelEnterNameEmployee
            // 
            this.labelEnterNameEmployee.AutoSize = true;
            this.labelEnterNameEmployee.Location = new System.Drawing.Point(7, 19);
            this.labelEnterNameEmployee.Name = "labelEnterNameEmployee";
            this.labelEnterNameEmployee.Size = new System.Drawing.Size(133, 13);
            this.labelEnterNameEmployee.TabIndex = 13;
            this.labelEnterNameEmployee.Text = "Введите имя сотрудника";
            this.labelEnterNameEmployee.Visible = false;
            // 
            // tbNameEmployee
            // 
            this.tbNameEmployee.Location = new System.Drawing.Point(6, 36);
            this.tbNameEmployee.Name = "tbNameEmployee";
            this.tbNameEmployee.Size = new System.Drawing.Size(162, 20);
            this.tbNameEmployee.TabIndex = 14;
            // 
            // FormAddEditAndDeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 245);
            this.Controls.Add(this.tbNameEmployee);
            this.Controls.Add(this.labelEnterNameEmployee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbStore);
            this.Controls.Add(this.tbExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSelectEmployee);
            this.Controls.Add(this.cbNameEmployee);
            this.Controls.Add(this.acceptButton);
            this.Name = "FormAddEditAndDeleteEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма изменения данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddEditAndDeleteEmployee_FormClosing);
            this.Load += new System.EventHandler(this.FormAddEditAndDeleteEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.ComboBox cbNameEmployee;
        private System.Windows.Forms.Label labelSelectEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label labelEnterNameEmployee;
        private System.Windows.Forms.TextBox tbNameEmployee;
    }
}