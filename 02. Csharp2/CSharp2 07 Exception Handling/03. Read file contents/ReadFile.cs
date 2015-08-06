//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.


using System;
using System.IO;
using System.Security;
class ReadFile
{
    static void Main()
    {

        try
        {
            StreamReader reader = new StreamReader("C:\\WINDOWS\\win.ini");
            string print = reader.ReadToEnd();
            Console.WriteLine(print);
            reader.Close();
            Console.WriteLine("\n\nFile successfully printed.\n");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The file specified in path was not found.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Error: The path is null.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Error: The arguement contains a null/empty string");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Error: The specified path, file name, or both exceed the system-defined maximum length.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Error: The specified path is invalid.");
        }
        catch (IOException)
        {
            Console.WriteLine("Error: An I/O error occurred while opening the file. ");
        }
        catch (SecurityException)
        {
            Console.WriteLine("Error: The caller does not have the required permission. ");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: The file that is read-only, the path is a directory.");
        }

        catch (NotSupportedException)
        {
            Console.WriteLine("Error: The path is in an invalid format.");
        }

    }
}

