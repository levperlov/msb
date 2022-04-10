using Microsoft.Office.Interop.Excel;
using System;
using System.Data.SqlClient;
using System.IO;

namespace МСБ
{
    internal class exel
    {
        private string line;
        private int i = 4;
        private int n = 0;
        private int c;
        private int d;
        private int f;
        private double res = 0;
        private double s = 0;
        public exel()
        {
            start();
        }

        private async void start()
        {
            using (SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = master; Trusted_Connection = True;"))
            {
                try
                {
                    await sqlConnection.OpenAsync();

                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "CREATE TABLE stavki (ID INT PRIMARY KEY IDENTITY, Procent INT NOT NULL, Name NVARCHAR(100) NOT NULL)",
                        Connection = sqlConnection
                    };
                    command.ExecuteNonQuery();
                    sqlConnection.Open();

                    command = new SqlCommand
                    {
                        CommandText = "CREATE TABLE dannye (name ncar(10) PRIMARY KEY IDENTITY, value NVARCHAR(100) NOT NULL)",
                        Connection = sqlConnection
                    };
                    command.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Таблица уже создана");
                }







            }
        }

#pragma warning disable CS1998 // В данном асинхронном методе отсутствуют операторы await, поэтому метод будет выполняться синхронно. Воспользуйтесь оператором await для ожидания неблокирующих вызовов API или оператором await Task.Run(...) для выполнения связанных с ЦП заданий в фоновом потоке.
        public async void metod(Worksheet a)
#pragma warning restore CS1998 // В данном асинхронном методе отсутствуют операторы await, поэтому метод будет выполняться синхронно. Воспользуйтесь оператором await для ожидания неблокирующих вызовов API или оператором await Task.Run(...) для выполнения связанных с ЦП заданий в фоновом потоке.
        {





            d = 12130;

            s = 0;
            while (i != n + 4)
            {
                c = (int)a.Range["C" + i].Value;
                f = c - d;
                if (f < 0)
                {
                    f = 0;
                }

                Work(@"ndfl");
                float v = (float)res / 100;
                double y = (c * v);
                int t = (int)Math.Round(y);
                a.Range["D" + i].Value = t;

                //travmatizm!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


                Work(@"opcmrot");

                v = (float)res / 100;
                y = (d * v);
                t = (int)Math.Round(y);
                a.Range["H" + i].Value = t;


                Work(@"omcmrot");

                v = (float)res / 100;
                y = (d * v);
                t = (int)Math.Round(y);
                a.Range["G" + i].Value = t;

                Work(@"fssmrot");

                v = (float)res / 100;
                y = (d * v);
                t = (int)Math.Round(y);
                a.Range["F" + i].Value = t;
                //mrot^
                //ost->

                Work(@"omc");

                v = (float)res / 100;
                y = (f * v);
                t = (int)Math.Round(y);
                a.Range["J" + i].Value = t;


                Work(@"opc");

                v = (float)res / 100;
                y = (f * v);
                t = (int)Math.Round(y);
                a.Range["K" + i].Value = t;


                Work(@"fss");

                v = (float)res / 100;
                y = (f * v);
                t = (int)Math.Round(y);
                a.Range["I" + i].Value = t;
                a.Range["A" + i].Value = i - 3;
                a.Range["E" + i].Value = c - (int)a.Range["D" + i].Value;



                Work(@"tramvatizm");

                v = (float)res / 100;
                s += (c * v);



                i++;
            }


            a.Range["B" + (n + 4)].Value = s;
        }
        public void writeme(Worksheet a)
        {

            i = 4;

            using (SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = master; Trusted_Connection = True;"))
            {

                try
                {
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "select * from rabotniki1",
                        Connection = sqlConnection
                    };

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        a.Range["B" + i].Value = reader.GetValue(1).ToString();
                        a.Range["C" + i].Value = reader.GetValue(2).ToString();
                        i++;
                        n++;
                    }

                }
                catch
                {
                    Console.WriteLine("не найдено");


                }

            }
            i = 4;

        }

        internal void update(string a, string b)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = master; Trusted_Connection = True;"))
            {


                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    CommandText = "UPDATE dannye SET value = '" + b + "' where name = '" + a + "';",
                    Connection = sqlConnection
                };
                command.ExecuteNonQuery();





            }


        }


        private void Work(string b)
        {

            using (SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = master; Trusted_Connection = True;"))
            {
                try
                {
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "select Procent from stavki WHERE Name = '" + b + "'",
                        Connection = sqlConnection
                    };

                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    res = Convert.ToDouble(reader.GetValue(0));

                }
                catch
                {
                    Console.WriteLine("не найдено");
                    res = 0;
                }

            }

        }
        public string Work()
        {
            string res = "";
            using (SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = master; Trusted_Connection = True;"))
            {

                try
                {
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "select * from rabotniki1",
                        Connection = sqlConnection
                    };

                    SqlDataReader reader = command.ExecuteReader();
                    res = res + reader.GetName(0).ToString() + "    ";
                    res = res + reader.GetName(1).ToString() + "    ";
                    res = res + reader.GetName(2).ToString() + "    ";
                    res = res + reader.GetName(3).ToString() + "    " + "\n";
                    while (reader.Read())
                    {
                        res = res + reader.GetValue(0).ToString() + " ";
                        res = res + reader.GetValue(1).ToString() + " ";
                        res = res + reader.GetValue(2).ToString() + " ";
                        res = res + reader.GetValue(3).ToString() + " " + "\n";

                    }

                }
                catch
                {
                    Console.WriteLine("не найдено");


                }
                return res;
            }

        }
        public string Work(object e, int a)
        {
            string res = "";
            using (SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = master; Trusted_Connection = True;"))
            {

                try
                {
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "select * from dannye",
                        Connection = sqlConnection
                    };

                    SqlDataReader reader = command.ExecuteReader();
                    res = res + reader.GetName(0).ToString() + "    ";
                    res = res + reader.GetName(1).ToString() + "    " + "\n";
                    while (reader.Read())
                    {
                        res = res + reader.GetValue(0).ToString() + " ";
                        res = res + reader.GetValue(1).ToString() + " " + "\n";

                    }

                }
                catch
                {
                    Console.WriteLine("не найдено");


                }
                return res;
            }

        }
        private object Work1(string a)
        {
            string[] raslozeniy = new string[n];
            StreamReader sr = new StreamReader(a);
            int u = 0;
            while ((line = sr.ReadLine()) != null && u <= n)
            {



                raslozeniy[u] = line;
                u++;
            }
            return raslozeniy;

        }
        public bool Dellite(string a)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = master; Trusted_Connection = True;"))
            {
                try
                {
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand
                    {
                        CommandText = "select name from stavki WHERE name = '" + a + "'",
                        Connection = sqlConnection
                    };

                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    reader.GetValue(1);
                    command.CommandText = "DELETE FROM Rabotniki1 WHERE ID ='" + a + "'";
                    command.Connection = sqlConnection;
                    command.ExecuteNonQuery();

                    return false;

                }
                catch
                {



                    return true;


                }





            }
        }
        public void ins(string a, string b, string c, string d)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = master; Trusted_Connection = True;"))
            {


                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    CommandText = "INSERT INTO Rabotniki1 VALUES('" + a + "', '" + b + "', " + c + ", '" + d + "');",
                    Connection = sqlConnection
                };
                command.ExecuteNonQuery();



            }
        }
    }
}

