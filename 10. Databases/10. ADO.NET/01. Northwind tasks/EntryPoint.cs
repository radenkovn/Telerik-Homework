namespace Northwind_tasks
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;

    public class EntryPoint
    {
        public static void Main()
        {

            SqlConnection dbCon = new SqlConnection("Server=.\\ADMIN; Database=NorthWind; Integrated Security=true");

            dbCon.Open();

            using (dbCon)
            {
                //Task 1
                CategoriesCount(dbCon);

                //Task 2
                GetNameDescription(dbCon);

                //Task 3
                GetProductsAndCategories(dbCon);

                //Task 4
                InsertProduct(dbCon);

                //Task 5
                RetreiveImages(dbCon);

                //Task 8
                SearchForASymbol(dbCon, "meat");
            }
        }

        //Task 1
        //Write a program that retrieves from the Northwind sample database in MS SQL Server the number of rows in the Categories table.
        private static void CategoriesCount(SqlConnection dbCon)
        {
            SqlCommand cmdCount = new SqlCommand("SELECT Count(CategoryId) AS Count FROM Categories", dbCon);
            int employeesCount = (int)cmdCount.ExecuteScalar();

            Console.WriteLine("Categories count: {0} ", employeesCount);
            Console.WriteLine();
        }


        //Task 2
        //Write a program that retrieves the name and description of all categories in the Northwind DB.
        private static void GetNameDescription(SqlConnection dbCon)
        {
            SqlCommand cmdAllEmployees = new SqlCommand("SELECT CategoryName, Description FROM Categories WHERE (CategoryName IS NOT NULL AND Description IS NOT NULL)", dbCon);
            SqlDataReader reader = cmdAllEmployees.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string name = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("Name - {0}", name);
                    Console.WriteLine("Description-  {0}", description);
                }
            }
        }

        //Task 3
        //Write a program that retrieves from the Northwind database all product categories and the names of the products in each category. 
        private static void GetProductsAndCategories(SqlConnection dbCon)
        {
            SqlCommand cmdAllEmployees = new SqlCommand("SELECT p.ProductName, c.CategoryName FROM Products p JOIN Categories c ON p.CategoryID = c.CategoryID", dbCon);
            SqlDataReader reader = cmdAllEmployees.ExecuteReader();
            var products = new Dictionary<string, StringBuilder>();

            using (reader)
            {
                while (reader.Read())
                {
                    string currentCategory = (string)reader["CategoryName"];
                    string currentProduct = (string)reader["ProductName"];

                    if (!products.ContainsKey(currentCategory))
                    {
                        products.Add(currentCategory, new StringBuilder(currentProduct));
                    }
                    else
                    {
                        var productsSoFar = products[currentCategory];
                        productsSoFar.Append(", " + currentProduct);
                    }
                }
            }

            foreach (var category in products)
            {
                Console.WriteLine("Category: {0}", category.Key);
                Console.WriteLine();
                Console.WriteLine("Products: {0}", category.Value.ToString());
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        //Task 4
        // Write a method that adds a new product in the products table in the Northwind database. 

        private static void InsertProduct(SqlConnection dbCon)
        {
            SqlCommand cmdCount = new SqlCommand("INSERT INTO Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)" +
"VALUES (@name , @supplier , @category, @quantity, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)", dbCon);
            cmdCount.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, 40);
            cmdCount.Parameters.Add("@supplier", System.Data.SqlDbType.Int);
            cmdCount.Parameters.Add("@category", System.Data.SqlDbType.Int);
            cmdCount.Parameters.Add("@quantity", System.Data.SqlDbType.NVarChar, 20);
            cmdCount.Parameters.Add("@unitPrice", System.Data.SqlDbType.Money);
            cmdCount.Parameters.Add("@unitsInStock", System.Data.SqlDbType.SmallInt);
            cmdCount.Parameters.Add("@unitsOnOrder", System.Data.SqlDbType.SmallInt);
            cmdCount.Parameters.Add("@reorderLevel", System.Data.SqlDbType.SmallInt);
            cmdCount.Parameters.Add("@discontinued", System.Data.SqlDbType.Bit);


            cmdCount.Parameters["@name"].Value = "Voda";
            cmdCount.Parameters["@supplier"].Value = 1;
            cmdCount.Parameters["@category"].Value = 1;
            cmdCount.Parameters["@quantity"].Value = "5 Bottles";
            cmdCount.Parameters["@unitPrice"].Value = 19.00;
            cmdCount.Parameters["@unitsInStock"].Value = 39;
            cmdCount.Parameters["@unitsOnOrder"].Value = 0;
            cmdCount.Parameters["@reorderLevel"].Value = 5;
            cmdCount.Parameters["@discontinued"].Value = 0;
            cmdCount.ExecuteNonQuery();
        }

        //Task 5
        //Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.

        private static void RetreiveImages(SqlConnection dbCon)
        {
            ExtractImageFromDB(dbCon);
        }

        private static void WriteBinaryFile(string fileName, byte[] fileContents)
        {
            FileStream stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(fileContents, 0, fileContents.Length);
            }
        }

        //This should work, no idea why it gives an error
        //Tried it in an online converter, still doesn't work
        private static void ExtractImageFromDB(SqlConnection dbConn)
        {

            SqlCommand cmd = new SqlCommand("SELECT Picture FROM Categories WHERE Picture IS NOT NULL", dbConn);
            SqlDataReader reader = cmd.ExecuteReader();
            int fileCounter = 0;
            using (reader)
            {
                while (reader.Read())
                {
                    fileCounter++;
                    byte[] image = (byte[])reader["Picture"];
                    WriteBinaryFile(string.Format(@"..\..\..\image{0}.jpg", fileCounter), image);
                }
            }
        }


        //Task 8
        //Write a program that reads a string from the console and finds all products that contain this string. 

        static void SearchForASymbol(SqlConnection dbCon, string letters)
        {
            SqlCommand cmdCategories = new SqlCommand("SELECT CategoryName FROM Categories WHERE PATINDEX ('%' + @letters + '%', CategoryName) > 0", dbCon);

            cmdCategories.Parameters.Add("@letters", System.Data.SqlDbType.NVarChar, 10);
            cmdCategories.Parameters["@letters"].Value = letters;
            SqlDataReader reader = cmdCategories.ExecuteReader();

            Console.WriteLine(@"Categories containting ""{0}""", letters);
            using (reader)
            {
                while (reader.Read())
                {
                    string name = (string)reader["CategoryName"];
                    Console.WriteLine("Name - {0}", name);
                }
            }
        }
    }
}
