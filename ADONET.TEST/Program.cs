using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace ADONET.TEST
{
    class Program
    {   
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string insertCommand = "INSERT INTO Pumps (Id, Name, PressureSideDN, SuctionSideDN, Weight, Width) VALUES (2, 'CR', 65, 65, 100, 250)";
            string updateCommand = "UPDATE Pumps SET PressureSideDN = 100 WHERE Id = 2";
            string deleteCommand = "DELETE FROM Pumps WHERE Id = 2";
            string selectCommand = "SELECT * FROM Pumps";
            string insertWithParameters = "INSERT INTO Pumps (Id, Name, PressureSideDN, SuctionSideDN, Weight, Width) VALUES (@id, @name, @pressureSideDn, @suctionSideDn, @weight, @width)";

            Console.Write("Enter \"id:\" ");
            int pumpsId = int.Parse(Console.ReadLine());

            Console.Write("\nEnter \"pump's name:\" ");
            string pumpsName = Console.ReadLine();

            Console.Write("\nEnter \"pressure Side Dn:\" ");
            int pressureSideDn = int.Parse(Console.ReadLine());

            Console.Write("\nEnter \"suction Side Dn:\" ");
            int suctionSideDn = int.Parse(Console.ReadLine());

            Console.Write("\nEnter \"weight:\" ");
            int weight = int.Parse(Console.ReadLine());

            Console.Write("\nEnter \"width:\" ");
            int width = int.Parse(Console.ReadLine());

            try
            {
                connection.Open();
                Debug.Print(connection.State.ToString());

                #region EXECUTE NON QUERY
                //SqlCommand command = new SqlCommand(insertCommand, connection);
                //SqlCommand command = new SqlCommand(updateCommand, connection);
                //SqlCommand command = new SqlCommand(deleteCommand, connection);
                //SqlCommand command = new SqlCommand(selectCommand, connection);
                #endregion

               
                SqlCommand command = new SqlCommand(insertWithParameters, connection);

                #region QUERY WITH PARAMS
                SqlParameter id = new SqlParameter("@id", pumpsId);
                command.Parameters.Add(id);
                SqlParameter pName = new SqlParameter("@name", pumpsName);
                command.Parameters.Add(pName);
                SqlParameter pumpsPressureSideDn = new SqlParameter("@pressureSideDn", pressureSideDn);
                command.Parameters.Add(pumpsPressureSideDn);
                SqlParameter pumpsSuctionSideDn = new SqlParameter("@suctionSideDn", suctionSideDn);
                command.Parameters.Add(pumpsSuctionSideDn);
                SqlParameter pumpsWeight = new SqlParameter("@weight", weight);
                command.Parameters.Add(pumpsWeight);
                SqlParameter pumpsWidth = new SqlParameter("@width", width);
                command.Parameters.Add(pumpsWidth);
                #endregion


                #region CONSOLE
                int result = command.ExecuteNonQuery();
                Debug.Print("{0} rows added", result);
                //Debug.Print("{0} rows updated", result);
                //Debug.Print("{0} rows deleted", result);
                #endregion

                #region EXECUTE READER
                //SqlDataReader reader = command.ExecuteReader();

                //if (reader.HasRows) 
                //{
                //    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));
                //    while (reader.Read()) 
                //    {
                //        Console.WriteLine("{0} \t{1} \t{2}", reader.GetValue(0), reader.GetValue(1), reader.GetValue(2));
                //    }
                //    Console.ReadLine();
                //}
                #endregion

            }
            catch (SqlException e)
            {
                Debug.Print(e.Message);
            }
            finally 
            {
                connection.Close();
                Debug.Print(connection.State.ToString());
            }
        }
    }
}
