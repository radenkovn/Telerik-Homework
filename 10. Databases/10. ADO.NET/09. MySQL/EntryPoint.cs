namespace _09.MySQL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MySql.Data.MySqlClient;

    public class EntryPoint
    {

        private static MySqlConnection connection;
        public static void Main()
        {
            Initialize();
            //Adding 1 default book comment this to prevent more books with the same name
            AddBook();
            //Adding a specific book
            AddBook("The Lord of the Rings", "Tolkien");

            //Listing all books
            ListAllBooks();

            //Finding books
            FindBook("Harry Potter");
            FindBook("The Lord of the Rings");
        }


        private static void ListAllBooks()
        {
            MySqlCommand command = new MySqlCommand("select * from books", connection);
            MySqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("Books: ");
            while (reader.Read())
            {
                Console.WriteLine(reader["title"]);
                Console.WriteLine(reader["author"]);
                Console.WriteLine(reader["publishDate"]);
                Console.WriteLine();
            }
            reader.Close();
        }

        private static void FindBook(string name)
        {
            MySqlCommand cmdFind = new MySqlCommand(string.Format("select * from books where title='{0}'", name), connection);
            MySqlDataReader reader = cmdFind.ExecuteReader();
            Console.WriteLine("Books with the title: {0}", name);
            Console.WriteLine("---------------------------------------");
            while (reader.Read())
            {
                Console.WriteLine(reader["title"]);
                Console.WriteLine(reader["author"]);
                Console.WriteLine(reader["publishDate"]);
                Console.WriteLine();
            }
            reader.Close();
            Console.WriteLine("---------------------------------------");
        }

        private static void AddBook(string name = "Harry Potter", string author = "Rowling")
        {
            string queryInsert = string.Format("INSERT INTO Books (title, author, publishDate) VALUES('{0}', '{1}', NOW())", name, author);
            MySqlCommand cmdInsert = new MySqlCommand(queryInsert, connection);
            cmdInsert.ExecuteNonQuery();
        }

        private static void Initialize()
        {
            var server = "localhost";
            var database = "bookshw";
            var uid = "root";
            var password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "create table Books (id INT NOT NULL AUTO_INCREMENT, title VARCHAR(30), author VARCHAR(30), publishDate DATETIME, PRIMARY KEY(id));";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Please Create the Database with a name {0}", database);
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please change the uid or password variables");
                        break;
                }
            }
        }
    }
}
