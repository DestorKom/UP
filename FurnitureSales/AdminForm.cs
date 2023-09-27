using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FurnitureSales
{
    public partial class AdminForm : Form
    {
        ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
        object[][] mas;
        public AdminForm()
        {
            InitializeComponent();
            CenterToScreen();
            comboBox1.Items.Add("account");
            comboBox1.Items.Add("buyers");
            comboBox1.Items.Add("furniture_models");
            comboBox1.Items.Add("sale");
            comboBox1.Items.Add("sale_contracts");
            comboBox1.Items.Add("employee");
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            object[][] mas = null;
            dataGridView1.Columns.Clear();
            switch (comboBox1.GetItemText(comboBox1.SelectedItem))
            {
                case "account":
                    dataGridView1.Columns.Add("id", "id");
                    dataGridView1.Columns.Add("login", "login");
                    dataGridView1.Columns.Add("password", "password");
                    dataGridView1.Columns.Add("type", "type");
                    mas = forSQL.SelectionRequest("account");
                    break;
                case "buyers":
                    dataGridView1.Columns.Add("id", "id");
                    dataGridView1.Columns.Add("id_acc", "id_acc");
                    dataGridView1.Columns.Add("addres", "addres");
                    dataGridView1.Columns.Add("phone", "phone");
                    dataGridView1.Columns.Add("full_name", "full_name");
                    mas = forSQL.SelectionRequest("buyers");
                    break;
                case "employee":
                    dataGridView1.Columns.Add("id", "id");
                    dataGridView1.Columns.Add("id_acc", "id_acc");
                    dataGridView1.Columns.Add("full_name", "full_name");
                    dataGridView1.Columns.Add("experience", "experience");
                    mas = forSQL.SelectionRequest("employee");
                    break;
                case "furniture_models":
                    dataGridView1.Columns.Add("id", "id");
                    dataGridView1.Columns.Add("name", "name");
                    dataGridView1.Columns.Add("characterization", "characterization");
                    dataGridView1.Columns.Add("cost", "cost");
                    mas = forSQL.SelectionRequest("furniture_models");
                    break;
                case "sale":
                    dataGridView1.Columns.Add("id", "id");
                    dataGridView1.Columns.Add("id_model", "id_model");
                    dataGridView1.Columns.Add("quantity", "quantity");
                    mas = forSQL.SelectionRequest("sale");
                    break;
                case "sale_contracts":
                    dataGridView1.Columns.Add("id", "id");
                    dataGridView1.Columns.Add("id_buyer", "id_buyer");
                    dataGridView1.Columns.Add("registration_date", "registration_date");
                    dataGridView1.Columns.Add("execution_date", "execution_date");
                    dataGridView1.Columns.Add("status", "status");
                    dataGridView1.Columns.Add("id_employee", "id_employee");
                    dataGridView1.Columns.Add("Cost", "Cost");
                    mas = forSQL.SelectionRequest("sale_contracts");
                    break;
            }
            for (int i = 0; i < mas.Length; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < mas[i].Length; j++)
                    dataGridView1[j, i].Value = mas[i][j].ToString();
            }
        }





        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                forSQL.SQLcommand($"delete from {comboBox1.GetItemText(comboBox1.SelectedItem)} where id = {dataGridView1.CurrentRow.Cells[0].Value}");
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!", "Ошибка");
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != 0)
                {
                    forSQL.SQLcommand($"update {comboBox1.GetItemText(comboBox1.SelectedItem)} set {dataGridView1.Columns[e.ColumnIndex].Name} = '{dataGridView1[e.ColumnIndex, e.RowIndex].Value}' where (id = '{dataGridView1[0, e.RowIndex].Value}')");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка обновления данных!", "Ошибка");
            }
        }


        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (Convert.ToInt32(dataGridView1[0, i].Value) != i + 1)
                    {
                        dataGridView1.Rows.Add((i + 1).ToString());
                        forSQL.SQLcommand($"insert into {comboBox1.GetItemText(comboBox1.SelectedItem)} (id)" + $"values ('{i + 1}')");
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления данных!", "Ошибка");
            }
        }
    }
}
