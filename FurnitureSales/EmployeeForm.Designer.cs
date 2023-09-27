namespace FurnitureSales
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBoxBuyers = new System.Windows.Forms.TextBox();
            this.textBoxRDate = new System.Windows.Forms.TextBox();
            this.textBoxEDate = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // TextBoxBuyers
            // 
            this.TextBoxBuyers.Location = new System.Drawing.Point(65, 80);
            this.TextBoxBuyers.Name = "TextBoxBuyers";
            this.TextBoxBuyers.Size = new System.Drawing.Size(121, 20);
            this.TextBoxBuyers.TabIndex = 1;
            // 
            // textBoxRDate
            // 
            this.textBoxRDate.Location = new System.Drawing.Point(65, 123);
            this.textBoxRDate.Name = "textBoxRDate";
            this.textBoxRDate.Size = new System.Drawing.Size(121, 20);
            this.textBoxRDate.TabIndex = 2;
            // 
            // textBoxEDate
            // 
            this.textBoxEDate.Location = new System.Drawing.Point(65, 170);
            this.textBoxEDate.Name = "textBoxEDate";
            this.textBoxEDate.Size = new System.Drawing.Size(121, 20);
            this.textBoxEDate.TabIndex = 3;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(65, 210);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(121, 20);
            this.textBoxCost.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Обработать заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxEDate);
            this.Controls.Add(this.textBoxRDate);
            this.Controls.Add(this.TextBoxBuyers);
            this.Controls.Add(this.comboBox1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TextBoxBuyers;
        private System.Windows.Forms.TextBox textBoxRDate;
        private System.Windows.Forms.TextBox textBoxEDate;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button button1;
    }
}