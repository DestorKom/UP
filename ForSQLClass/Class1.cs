using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSQLClass
{
    public class ForSqlClass
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-VPF7FUA; Initial catalog = FurnitureSalesSQL; Integrated Security = True");
        /// <summary>
        /// Открытие связи с бд
        /// </summary>
        private void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }
        /// <summary>
        /// Закрытие связи с бд
        /// </summary>
        private void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }
        /// <summary>
        /// Возвращает строку подключения
        /// </summary>
        /// <returns></returns>
        private SqlConnection getConnection()
        {
            return sqlConnection;
        }
        /// <summary>
        /// Введние запроса
        /// </summary>
        /// <returns></returns>
        public void SQLcommand(string queryString)
        {
            openConnection();
            SqlCommand command = new SqlCommand(queryString, getConnection());
            command.ExecuteNonQuery();
            closeConnection();
        }

        private delegate object[] TableString(IDataRecord dataRecord, int n);

        /// <summary>
        /// 1.account
        /// 2.buyers
        /// 3.furniture_models
        /// 4.sale
        /// 5.sale_contracts
        /// 6.sale_sale_contracts
        /// 7.employee
        /// </summary>
        /// <returns></returns>
        public object[][] SelectionRequest(string queryString)
        {
            int colomnCount = 0;
            TableString tablestring = ReadRowAccount;
            switch (queryString)
            {
                case "account":
                    {
                        tablestring = ReadRowAccount;
                        colomnCount = 4;
                    }
                    break;
                case "buyers":
                    {
                        tablestring = ReadRowBuyers;
                        colomnCount = 5;
                    }
                    break;
                case "furniture_models":
                    {
                        tablestring = ReadRowfurnitureModels;
                        colomnCount = 4;
                    }
                    break;
                case "sale":
                    {
                        tablestring = ReadRowSale;
                        colomnCount = 3;
                    }
                    break;
                case "sale_contracts":
                    {
                        tablestring = ReadRowSaleContracts;
                        colomnCount = 7;
                    }
                    break;
                case "sale_sale_contracts":
                    {
                        tablestring = ReadRowSaleSaleContracts;
                        colomnCount = 2;
                    }
                    break;
                case "employee":
                    {
                        tablestring = ReadRowEmployee;
                        colomnCount = 4;
                    }
                    break;
            }

            SqlCommand sqlCommandmas = new SqlCommand($"Select Count(*) from " + queryString, getConnection());
            openConnection();
            SqlDataReader readermas = sqlCommandmas.ExecuteReader();
            readermas.Read();
            IDataRecord dataRecordmas = readermas;
            int stringCount = dataRecordmas.GetInt32(0);
            readermas.Close();

            object[][] mas = new object[stringCount][];


            SqlCommand sqlCommand = new SqlCommand($"Select * from " + queryString, getConnection());
            openConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                mas[i] = tablestring(reader, colomnCount);
                i++;
            }

            reader.Close();
            return mas;
        }

        private object[] ReadRowAccount(IDataRecord dataRecord, int n)
        {
            object[] mas = new object[n];
            mas[0] = dataRecord.GetInt32(0);
            mas[1] = dataRecord.GetString(1);
            mas[2] = dataRecord.GetString(2);
            mas[3] = dataRecord.GetInt32(3);
            return mas;

        }
        private object[] ReadRowBuyers(IDataRecord dataRecord, int n)
        {
            object[] mas = new object[n];
            mas[0] = dataRecord.GetInt32(0);
            mas[1] = dataRecord.GetInt32(1);
            mas[2] = dataRecord.GetString(2);
            mas[3] = dataRecord.GetString(3);
            mas[4] = dataRecord.GetString(4);
            return mas;

        }
        private object[] ReadRowfurnitureModels(IDataRecord dataRecord, int n)
        {
            object[] mas = new object[n];
            mas[0] = dataRecord.GetInt32(0);
            mas[1] = dataRecord.GetString(1);
            mas[2] = dataRecord.GetString(2);
            mas[3] = Math.Round(dataRecord.GetDecimal(3));
            return mas;

        }
        private object[] ReadRowSale(IDataRecord dataRecord, int n)
        {
            object[] mas = new object[n];
            mas[0] = dataRecord.GetInt32(0);
            mas[1] = dataRecord.GetInt32(1);
            mas[2] = dataRecord.GetInt32(2);
            return mas;

        }
        private object[] ReadRowSaleContracts(IDataRecord dataRecord, int n)
        {
            object[] mas = new object[n];
            mas[0] = dataRecord.GetInt32(0);
            mas[1] = dataRecord.GetInt32(1);
            mas[2] = dataRecord.GetDateTime(2);
            mas[3] = dataRecord.GetDateTime(3);
            mas[4] = dataRecord.GetBoolean(4);
            mas[5] = dataRecord.GetInt32(5);
            mas[6] = Math.Round(dataRecord.GetDecimal(6));
            return mas;

        }
        private object[] ReadRowSaleSaleContracts(IDataRecord dataRecord, int n)
        {
            object[] mas = new object[n];
            mas[0] = dataRecord.GetInt32(0);
            mas[1] = dataRecord.GetInt32(1);
            return mas;

        }
        private object[] ReadRowEmployee(IDataRecord dataRecord, int n)
        {
            object[] mas = new object[n];
            mas[0] = dataRecord.GetInt32(0);
            mas[1] = dataRecord.GetInt32(1);
            mas[2] = dataRecord.GetString(2);
            mas[3] = dataRecord.GetString(3);
            return mas;

        }
    }

}

