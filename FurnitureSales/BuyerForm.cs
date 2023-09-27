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
using System.Windows.Media.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FurnitureSales
{
    public partial class Bform : Form
    {

        ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
        object[][] mas;
        private int id;
        public Bform(int id1)
        {
            id = id1;
            InitializeComponent();
            CenterToScreen();
            TextBoxWatermarkExtensionMethod.SetWatermark(textBoxCharacterization, "Название");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBoxCost, "Стоимость");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBoxItog, "Итоговая цена");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBoxKol, "Количество");
            mas = forSQL.SelectionRequest("furniture_models");
            for (int i = 0; i < mas.Length; i++)
                comboBoxName.Items.Add(Convert.ToString(mas[i][1]));
        }

        

        private void comboBoxName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxCharacterization.Text = Convert.ToString(mas[comboBoxName.SelectedIndex][2]);
            textBoxCost.Text = Convert.ToString(mas[comboBoxName.SelectedIndex][3]);

            //pictureBox1.Image = Image.FromFile(@"E:\4kurs\yp\Lab5\FurnitureSales\FurnitureSales\Resources\ber.jpg");
            try
            {
                textBoxItog.Text = Convert.ToString(Convert.ToDouble(textBoxCost.Text) * Convert.ToDouble(textBoxKol.Text));
            }
            catch
            {

            }
        }
        private void textBoxKol_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxItog.Text = Convert.ToString(Convert.ToDouble(textBoxCost.Text) * Convert.ToDouble(textBoxKol.Text));
            }
            catch
            {

            }
        }
        double sum = 0;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                bool newLine = true;
                if (dataGridView1.RowCount != 1)
                {
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        if (dataGridView1[0, i].Value.ToString() == comboBoxName.Text)
                        {
                            dataGridView1[2, i].Value = Convert.ToInt32(dataGridView1[2, i].Value) + Convert.ToInt32(textBoxKol.Text);
                            dataGridView1[3, i].Value = Convert.ToInt32(dataGridView1[2, i].Value) * Convert.ToDouble(dataGridView1[1, i].Value);
                            newLine = false;
                        }
                }
                if (newLine)
                {
                    dataGridView1.Rows.Add(comboBoxName.Text, textBoxCost.Text, textBoxKol.Text, textBoxItog.Text);
                }
                sum += Convert.ToDouble(textBoxItog.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка добавления покупки!", "Ошибка");
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                object[][] masFM = forSQL.SelectionRequest("sale_contracts");
                int idContract = masFM.Length + 1;
                forSQL.SQLcommand($"insert into sale_contracts (id,id_buyer,registration_date,execution_date,id_employee,status,Cost)" + $"values ('{idContract}','{id}','{DateTime.Now}','{DateTime.Now}','1','0','{sum}')");
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    masFM = forSQL.SelectionRequest("sale");
                    for (int j = 0; j < mas.Length; j++)
                    {

                        if (mas[j][1].ToString() == dataGridView1[0, i].Value.ToString())
                        {
                            forSQL.SQLcommand($"insert into sale (id,id_model,quantity)" + $"values ('{masFM.Length + 1}','{mas[j][0]}','{dataGridView1[2, i].Value}')");
                            forSQL.SQLcommand($"insert into sale_sale_contracts (id_C,id_S)" + $"values ('{idContract}','{masFM.Length + 1}')");
                            break;
                            
                        }
                    }

                    MessageBox.Show("Успешная покупка!", "Ошибка");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления заказа!", "Ошибка");
            }

        }
    }
}
