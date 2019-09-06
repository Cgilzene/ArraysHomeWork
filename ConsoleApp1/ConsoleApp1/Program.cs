using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create create = new Create();
            //create.insert();
            // Read read = new Read();
            // read.readTable();
            Update update = new Update();
            update.updateTable();
        }
    }
     class Game
     {
        string name = "";
        string game = "";
        string type = "";
        string review = "";

        public string Name { get => name; set => name = value; }
        public string Game1 { get => game; set => game = value; }
        public string Type { get => type; set => type = value; }
        public string Review { get => review; set => review = value; }
     }


     class Create
     {
        public void insert()
        {
                Game game1 = new Game();
                game1.Name = "Tetris";
                game1.Game1 = "Arcade";
                game1.Type = "Puzzle";
                game1.Review = "Great";
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSharpGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                string insertString = String.Format("INSERT INTO Game(name, game, type, review) VALUES ('{0}', '{1}', '{2}', '{3}')", game1.Name, game1.Game1, game1.Type, game1.Review);
                // string inserting2 = "INSERT INTO GAME (name,game,type,review) VALUES('a','b','c','d')";

                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();

                    SqlCommand insertCommand = new SqlCommand(insertString, conn);

                    Console.WriteLine(conn.State);

                    insertCommand.ExecuteReader();
                }
                catch (SqlException ex)
                {

                    Console.WriteLine("Something happened to server " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
        }

     }
    

     class Read
    {

        public void readTable()
        {
            Game game1 = new Game();
            

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSharpGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            string readTable = "SELECT * FROM Game";

            try
            {
                conn.Open();


                SqlCommand SelectCommand = new SqlCommand(readTable, conn);

                Console.WriteLine(conn.State);

                SqlDataReader reader = SelectCommand.ExecuteReader();

                while (reader.Read())
                {
                    game1.Name = reader["Name"].ToString();
                    game1.Game1 = reader["Game"].ToString();
                    game1.Type = reader["Type"].ToString();
                    game1.Review = reader["Review"].ToString();


                }


            }
            catch (SqlException ex)
            {

                Console.WriteLine("Something happened to server " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }

    class Update
    {

        public void updateTable()
        {
            Game game1 = new Game();


            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSharpGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            


            try
            {
                conn.Open();

                string UpdateTable = "UPDATE Game " + "SET name = @name ";

                SqlCommand UpdateCommand = new SqlCommand(UpdateTable, conn);


                UpdateCommand.Parameters.AddWithValue("@name", "PacMan");

                Console.WriteLine(conn.State);

                SqlDataReader update = UpdateCommand.ExecuteReader();

                

            }
            catch (SqlException ex)
            {

                Console.WriteLine("Something happened to server " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }

    class Delete
    {

        public void deleteRow()
        {
            Game game1 = new Game();


            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSharpGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);



            try
            {
                conn.Open();

                string UpdateTable = "UPDATE Game " + "SET name = @name ";

                SqlCommand UpdateCommand = new SqlCommand(UpdateTable, conn);


                UpdateCommand.Parameters.AddWithValue("@name", "PacMan");

                Console.WriteLine(conn.State);

                SqlDataReader update = UpdateCommand.ExecuteReader();



            }
            catch (SqlException ex)
            {

                Console.WriteLine("Something happened to server " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}

    

