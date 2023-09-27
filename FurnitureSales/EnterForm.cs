using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FurnitureSales
{
   
    public partial class EnterForm : Form
    {


        //ForSQL forSQL = new ForSQL();
        ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
        private string text = String.Empty;

        public EnterForm()
        {
            InitializeComponent();
            CenterToScreen();
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox1, "Логин");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox2, "Пароль");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox3, "Введите капчу");
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            
            bool enter = false;
            int type = 1;
            int id = 1;
            object[][] mas = forSQL.SelectionRequest("account");
            for (int i = 0; i < mas.Length; i++)
            {
                if ((Convert.ToString(mas[i][1]) == textBox1.Text) && (Convert.ToString(mas[i][2]) == textBox2.Text))
                {
                    enter = true;
                    type = Convert.ToInt32(mas[i][3]);
                    id = Convert.ToInt32(mas[i][0]);
                }
            }

            if ((enter && textBox3.Text==text && textBox3.Visible == true)||(enter && textBox3.Visible==false))
            {
                this.Hide();
                WelcomeForm welcomeForm = new WelcomeForm(id);
                welcomeForm.ShowDialog();
                switch (type)
                {
                    case 1:
                        Bform buyerForm = new Bform(id);
                        buyerForm.ShowDialog();
                        this.Close();
                        break;
                    case 2:
                         EmployeeForm employeeForm = new EmployeeForm();
                         employeeForm.ShowDialog();
                        this.Close();
                        break;
                    case 3:
                        AdminForm admin = new AdminForm();
                        admin.ShowDialog();
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ошибка входа", "Ошибка");
                textBox3.Visible = true;
                buttonNewC.Visible = true;
                pictureBox1.Visible = true;
                EnterButton.Enabled = false;
                timer1.Start();
                pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
            }
           
        }


       


        
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((System.Drawing.Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
            this.Close();
        }
        bool See = false; 
        private void buttonSee_Click(object sender, EventArgs e)
        {
            See = !See;
            textBox2.UseSystemPasswordChar = See;
        }

        private void buttonNewC_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }
        double time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time ++;
            if (time > 10)
            {
                EnterButton.Enabled = true;
                time = 0;
            }
        }
    }
}
