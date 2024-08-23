namespace WPFCursach
{
    partial class FormAddEditAndDeleteProviders
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
            this.tbContactDetailsProvider = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhoneProvider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameProvider = new System.Windows.Forms.TextBox();
            this.labelNameProvider = new System.Windows.Forms.Label();
            this.labelCBProvider = new System.Windows.Forms.Label();
            this.cbNameProvider = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.AutoSize = true;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(15, 190);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(162, 32);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // tbContactDetailsProvider
            // 
            this.tbContactDetailsProvider.Location = new System.Drawing.Point(15, 87);
            this.tbContactDetailsProvider.Multiline = true;
            this.tbContactDetailsProvider.Name = "tbContactDetailsProvider";
            this.tbContactDetailsProvider.Size = new System.Drawing.Size(162, 49);
            this.tbContactDetailsProvider.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите контактную \r\nинформацию поставщика:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbPhoneProvider
            // 
            this.tbPhoneProvider.Location = new System.Drawing.Point(15, 164);
            this.tbPhoneProvider.Name = "tbPhoneProvider";
            this.tbPhoneProvider.Size = new System.Drawing.Size(162, 20);
            this.tbPhoneProvider.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите телефон поставщика:";
            // 
            // tbNameProvider
            // 
            this.tbNameProvider.Location = new System.Drawing.Point(15, 25);
            this.tbNameProvider.Name = "tbNameProvider";
            this.tbNameProvider.Size = new System.Drawing.Size(162, 20);
            this.tbNameProvider.TabIndex = 10;
            // 
            // labelNameProvider
            // 
            this.labelNameProvider.AutoSize = true;
            this.labelNameProvider.Location = new System.Drawing.Point(12, 9);
            this.labelNameProvider.Name = "labelNameProvider";
            this.labelNameProvider.Size = new System.Drawing.Size(140, 13);
            this.labelNameProvider.TabIndex = 9;
            this.labelNameProvider.Text = "Введите имя поставщика:";
            // 
            // labelCBProvider
            // 
            this.labelCBProvider.AutoSize = true;
            this.labelCBProvider.Location = new System.Drawing.Point(12, 9);
            this.labelCBProvider.Name = "labelCBProvider";
            this.labelCBProvider.Size = new System.Drawing.Size(148, 13);
            this.labelCBProvider.TabIndex = 11;
            this.labelCBProvider.Text = "Выберите имя поставщика:";
            // 
            // cbNameProvider
            // 
            this.cbNameProvider.FormattingEnabled = true;
            this.cbNameProvider.Location = new System.Drawing.Point(15, 26);
            this.cbNameProvider.Name = "cbNameProvider";
            this.cbNameProvider.Size = new System.Drawing.Size(160, 21);
            this.cbNameProvider.TabIndex = 12;
            this.cbNameProvider.SelectedIndexChanged += new System.EventHandler(this.cbNameProvider_SelectedIndexChanged);
            // 
            // FormAddEditAndDeleteProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 240);
            this.Controls.Add(this.cbNameProvider);
            this.Controls.Add(this.labelCBProvider);
            this.Controls.Add(this.tbNameProvider);
            this.Controls.Add(this.labelNameProvider);
            this.Controls.Add(this.tbPhoneProvider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbContactDetailsProvider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.acceptButton);
            this.Name = "FormAddEditAndDeleteProviders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма редактирования поставщиков";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddEditAndDeleteProviders_FormClosing);
            this.Load += new System.EventHandler(this.FormAddEditAndDeleteProviders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox tbContactDetailsProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhoneProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameProvider;
        private System.Windows.Forms.Label labelNameProvider;
        private System.Windows.Forms.Label labelCBProvider;
        private System.Windows.Forms.ComboBox cbNameProvider;
    }
}