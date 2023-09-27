namespace FurnitureSales
{
    partial class EnterForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonSee = new System.Windows.Forms.Button();
            this.buttonNewC = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(138, 366);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 23);
            this.EnterButton.TabIndex = 3;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(280, 12);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(92, 23);
            this.RegistrationButton.TabIndex = 4;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Visible = false;
            // 
            // buttonSee
            // 
            this.buttonSee.Font = new System.Drawing.Font("Webdings", 16.2F);
            this.buttonSee.Location = new System.Drawing.Point(230, 135);
            this.buttonSee.Name = "buttonSee";
            this.buttonSee.Size = new System.Drawing.Size(30, 30);
            this.buttonSee.TabIndex = 7;
            this.buttonSee.Text = "N";
            this.buttonSee.UseVisualStyleBackColor = true;
            this.buttonSee.Click += new System.EventHandler(this.buttonSee_Click);
            // 
            // buttonNewC
            // 
            this.buttonNewC.Location = new System.Drawing.Point(122, 321);
            this.buttonNewC.Name = "buttonNewC";
            this.buttonNewC.Size = new System.Drawing.Size(113, 23);
            this.buttonNewC.TabIndex = 8;
            this.buttonNewC.Text = "Обновить капчу";
            this.buttonNewC.UseVisualStyleBackColor = true;
            this.buttonNewC.Visible = false;
            this.buttonNewC.Click += new System.EventHandler(this.buttonNewC_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(87, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.buttonNewC);
            this.Controls.Add(this.buttonSee);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "EnterForm";
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonSee;
        private System.Windows.Forms.Button buttonNewC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

