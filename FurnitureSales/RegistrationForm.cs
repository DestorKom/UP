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

namespace FurnitureSales
{
    public partial class RegistrationForm : Form
    {
        ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
        public RegistrationForm()
        {
            InitializeComponent();
            CenterToScreen();
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox1, "Логин");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox2, "Пароль");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox3, "Адресс");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox4, "Телефон");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox5, "ФИО");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool uniqueLogin = true;
                object[][] mas = forSQL.SelectionRequest("account");
                object[][] mas1 = forSQL.SelectionRequest("buyers");
                for (int i = 0; i < mas.Length; i++)
                {
                    if ((Convert.ToString(mas[i][1]) == textBox1.Text))
                    {
                        MessageBox.Show("Аккаунт с таким логином уже существует", "Ошибка");
                        uniqueLogin = false;
                    }


                }

                if (uniqueLogin)
                {
                    string login = textBox1.Text;
                    string password = textBox2.Text;
                    forSQL.SQLcommand( $"insert into account (id,login,password,type)" + $"values ('{mas.Length + 1}','{login}','{password}','1')");



                    string addres = textBox3.Text;
                    string phone = textBox4.Text;
                    string fullName = textBox5.Text;
                    forSQL.SQLcommand($"insert into buyers (id,id_acc,addres,phone,full_name)" + $"values ('{mas1.Length + 1}','{mas.Length + 1}','{addres}','{phone}','{fullName}')");
                    MessageBox.Show("Вы успешно создали аккаунт", "Успех");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка «Проверьте введённые данные»", "Ошибка");
            }
        
        }
    }
}
