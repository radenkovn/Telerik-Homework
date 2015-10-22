namespace _06.Excel_Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntryPoint
    {
        public static void Main()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../../NameScore.xlsx;Extended Properties='Excel 12.0 xml;HDR=Yes';";
            OleDbConnection dbConn = new OleDbConnection(connectionString);
            dbConn.Open();

            var excelSchema = dbConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            var sheetName = excelSchema.Rows[0]["TABLE_NAME"].ToString();

            //Task 6
            ReadRows(dbConn, sheetName);

            //Task 7
            InsertData(dbConn, sheetName, "Ronald Weasley", "5");
        }

        //Task 6

        public static void ReadRows(OleDbConnection dbConn, string sheetName)
        {
            OleDbCommand cmdReadTable = new OleDbCommand("SELECT * FROM [" + sheetName + "]", dbConn);
            OleDbDataReader reader = cmdReadTable.ExecuteReader();

            while (reader.Read())
            {
                var name = (string)reader["Name"];
                var score = reader["Score"].ToString();
                Console.WriteLine("Name - {0,20}, Score - {1,3}", name, score);
            }
        }


        //Task 7
        public static void InsertData(OleDbConnection dbConn, string sheetName, string name, string score)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO [" + sheetName + "] ([Name], [Score]) VALUES (@name, @score)", dbConn);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@score", score);

            cmd.ExecuteNonQuery();
        }

    }
}
