using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace Szolgaltatok
{
    class Program
    {
        static void Main(string[] args)
        {

            // Itt hozzá kell adni a mySQL.Data-t a referenciákhoz.

            string connStr = "server=localhost;user=root;password=;database=iskola1";

            MySqlConnection conn = new MySqlConnection(connStr); //itt létrehozunk egy kapcsolatot.

            Console.WriteLine("Nyitasi kísérlet");
            try
            {
                conn.Open(); // itt megnyitjuk a kapcsoltatot
                Console.WriteLine("Siekrült a kapcsolódás!");

                MySqlCommand myCmd = new MySqlCommand("SELECT * FROM diakok", conn);

                MySqlDataReader reader = myCmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["nev"],-20}{reader["hely"],20}");
                }


                conn.Close(); // itt pedig lezárjuk
                //Console.WriteLine("Lezárt a kapcsolódás!");
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.ToString());

            }
            finally
            {
                Console.WriteLine("Mittomén!");
            }

            /*App configuration beolvasasa, kell a referencebe a System.Configuration*/
            string szolgStr = ConfigurationManager.AppSettings["Szolgaltato"];
            Console.WriteLine($"{szolgStr}");




            //DataTable dataTable = DbProviderFactories.GetFactoryClasses();

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (DataColumn column in dataTable.Columns)
            //    {
            //        Console.WriteLine(row[column]);
            //    }
            //}




            Console.ReadLine();

            /*
             * Ha akarunk csatlakozni egy DB-hez, akkor kell egy connector.
             *           
             *
             */

        }
    }
}
