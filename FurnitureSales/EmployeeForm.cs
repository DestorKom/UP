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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FurnitureSales
{
    public partial class EmployeeForm : Form
    {
        ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
        object[][] masSC;
        object[][] masB;
        public EmployeeForm()
        {
            InitializeComponent();
            CenterToScreen();
            updateform();
           
        }
        private void updateform()
        {
            comboBox1.Items.Clear();
            masSC = forSQL.SelectionRequest("sale_contracts");
            masB = forSQL.SelectionRequest("buyers");
            for (int i = 0; i < masSC.Length; i++)
                if (masSC[i][4].ToString() == "False")
                    comboBox1.Items.Add(Convert.ToString("Contract " + masSC[i][0]));
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            for (int i = 0; i < masSC.Length; i++)
            {
                if ("Contract " + masSC[i][0].ToString() == comboBox1.GetItemText(comboBox1.SelectedItem))
                {
                    for (int j = 0; j < masB.Length; j++)
                        if (masB[j][0].ToString() == masSC[i][1].ToString())
                            TextBoxBuyers.Text = Convert.ToString(masB[j][4]);
                    textBoxRDate.Text = Convert.ToString(masSC[i][2]);
                    textBoxCost.Text = Convert.ToString(masSC[i][6]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < masSC.Length; i++)
                {
                    if ("Contract " + masSC[i][0].ToString() == comboBox1.GetItemText(comboBox1.SelectedItem))
                    {
                        forSQL.SQLcommand($"update sale_contracts set status = 1 where (id = {masSC[i][0].ToString()})");
                        forSQL.SQLcommand($"update sale_contracts set execution_date = '{Convert.ToDateTime(textBoxEDate.Text)}' where (id = {masSC[i][0].ToString()})");
                        MessageBox.Show("Успешная обработка заказа!", "Ошибка");
                        updateform();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка Обрабоки заказа!", "Ошибка");
            }

        }
    }
}
