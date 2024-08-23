namespace WPFCursach
{
    partial class FormAddAndDeleteSupplies
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
            this.cbNameProvider = new System.Windows.Forms.ComboBox();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSelectIDSupplies = new System.Windows.Forms.Label();
            this.cbSupplies = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.AutoSize = true;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(12, 151);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(162, 32);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cbNameProvider
            // 
            this.cbNameProvider.FormattingEnabled = true;
            this.cbNameProvider.Location = new System.Drawing.Point(14, 29);
            this.cbNameProvider.Name = "cbNameProvider";
            this.cbNameProvider.Size = new System.Drawing.Size(160, 21);
            this.cbNameProvider.TabIndex = 13;
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(14, 77);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(160, 21);
            this.cbProducts.TabIndex = 14;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(14, 125);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(160, 20);
            this.tbAmount.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Выберите поставщика:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Выберите товар:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Введите количество:";
            // 
            // labelSelectIDSupplies
            // 
            this.labelSelectIDSupplies.AutoSize = true;
            this.labelSelectIDSupplies.Location = new System.Drawing.Point(14, 10);
            this.labelSelectIDSupplies.Name = "labelSelectIDSupplies";
            this.labelSelectIDSupplies.Size = new System.Drawing.Size(131, 13);
            this.labelSelectIDSupplies.TabIndex = 19;
            this.labelSelectIDSupplies.Text = "Выберите код поставки:";
            // 
            // cbSupplies
            // 
            this.cbSupplies.FormattingEnabled = true;
            this.cbSupplies.Location = new System.Drawing.Point(12, 29);
            this.cbSupplies.Name = "cbSupplies";
            this.cbSupplies.Size = new System.Drawing.Size(162, 21);
            this.cbSupplies.TabIndex = 20;
            // 
            // FormAddAndDeleteSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 192);
            this.Controls.Add(this.cbSupplies);
            this.Controls.Add(this.labelSelectIDSupplies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.cbNameProvider);
            this.Controls.Add(this.acceptButton);
            this.Name = "FormAddAndDeleteSupplies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма редактирования поставок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddAndDeleteSupplies_FormClosing);
            this.Load += new System.EventHandler(this.FormAddAndDeleteSupplies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.ComboBox cbNameProvider;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSelectIDSupplies;
        private System.Windows.Forms.ComboBox cbSupplies;
    }
}