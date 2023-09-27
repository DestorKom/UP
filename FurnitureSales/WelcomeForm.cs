using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureSales
{
    public partial class WelcomeForm : Form
    {
        ForSQLClass.ForSqlClass ForSQL = new ForSQLClass.ForSqlClass();
        public WelcomeForm(int id)
        {
            InitializeComponent();
            CenterToScreen();
            object[][] masBuyers = ForSQL.SelectionRequest("buyers");
            string id_acc = "1";
            for (int i = 0; i < masBuyers.Length; i++)
            {
                if (masBuyers[i][0].ToString() == id.ToString())
                {
                    labelWelcome.Text = masBuyers[i][4].ToString();
                    id_acc = masBuyers[i][1].ToString();
                    break;
                }
            }
            object[][] masAccount = ForSQL.SelectionRequest("account");
            for (int i = 0; i < masAccount.Length; i++)
            {
                if (masAccount[i][0].ToString() == id_acc)
                {
                    switch (masAccount[i][3].ToString())
                    {
                        case "1":
                            labelWelcome.Text = $"Добро пожаловать покупатель "+labelWelcome.Text;
                            break;
                        case "2":
                            labelWelcome.Text = $"Добро пожаловать сотрудник " + labelWelcome.Text;
                            break;
                        case "3":
                            labelWelcome.Text = $"Добро пожаловать администратор " + labelWelcome.Text;
                            break;
                    }


                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
