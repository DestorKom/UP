namespace FurnitureSales
{
    partial class Bform
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
            this.textBoxCharacterization = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxItog = new System.Windows.Forms.TextBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.textBoxKol = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColomn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCharacterization
            // 
            this.textBoxCharacterization.Location = new System.Drawing.Point(12, 39);
            this.textBoxCharacterization.Name = "textBoxCharacterization";
            this.textBoxCharacterization.Size = new System.Drawing.Size(121, 20);
            this.textBoxCharacterization.TabIndex = 1;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(12, 65);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(121, 20);
            this.textBoxCost.TabIndex = 2;
            // 
            // textBoxItog
            // 
            this.textBoxItog.Location = new System.Drawing.Point(12, 117);
            this.textBoxItog.Name = "textBoxItog";
            this.textBoxItog.Size = new System.Drawing.Size(121, 20);
            this.textBoxItog.TabIndex = 3;
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(12, 12);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxName.TabIndex = 5;
            this.comboBoxName.SelectionChangeCommitted += new System.EventHandler(this.comboBoxName_SelectionChangeCommitted);
            // 
            // textBoxKol
            // 
            this.textBoxKol.Location = new System.Drawing.Point(12, 91);
            this.textBoxKol.Name = "textBoxKol";
            this.textBoxKol.Size = new System.Drawing.Size(121, 20);
            this.textBoxKol.TabIndex = 6;
            this.textBoxKol.TextChanged += new System.EventHandler(this.textBoxKol_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 167);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 32);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить в заказ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(212, 387);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 10;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColomn,
            this.Cost,
            this.Kol,
            this.Itog});
            this.dataGridView1.Location = new System.Drawing.Point(212, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 345);
            this.dataGridView1.TabIndex = 13;
            // 
            // NameColomn
            // 
            this.NameColomn.HeaderText = "Название";
            this.NameColomn.Name = "NameColomn";
            this.NameColomn.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Цена";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Kol
            // 
            this.Kol.HeaderText = "Количество";
            this.Kol.Name = "Kol";
            this.Kol.ReadOnly = true;
            // 
            // Itog
            // 
            this.Itog.HeaderText = "Итог";
            this.Itog.Name = "Itog";
            this.Itog.ReadOnly = true;
            // 
            // Bform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FurnitureSales.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxKol);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.textBoxItog);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxCharacterization);
            this.Name = "Bform";
            this.Text = "BuyerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCharacterization;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxItog;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.TextBox textBoxKol;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColomn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itog;
    }
}