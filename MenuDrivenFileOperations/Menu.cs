using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDrivenFileOperations
{
    public class Menu
    {
        public void Main()
        {
            FileManager fileManager = new FileManager();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Choice 1: Create a new File");
                Console.WriteLine("Choice 2: Copy File");
                Console.WriteLine("Choice 3: Rename File");
                Console.WriteLine("Choice 4: Delete File");
                Console.WriteLine("Choice 5: Create a Directory");
                Console.WriteLine("Choice 6: Delete a Directory");
                Console.WriteLine("Choice 7: Write to a File");
                Console.WriteLine("Choice 8: Reade from a File");
                Console.WriteLine("Choice 9: To Exit");
                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: CreateFile(fileManager); break;
                    case 2: CopyFile(fileManager); break;
                    case 3: RenameFile(fileManager); break;
                    case 4: DeleteFile(fileManager); break;
                    case 5: CreateDirectory(fileManager); break;
                    case 6: DeleteDirectory(fileManager); break;
                    case 7: WriteToFile(fileManager); break;
                    case 8: ReadFromFile(fileManager); break;
                    case 9: flag = false; break;
                    default:
                        Console.WriteLine("Invalid Choice. Please Re-enter the choice.");
                        break;
                }


            }
        }

        private void ReadFromFile(FileManager fileManager)
        {
            var path = GetFilePath();
            fileManager.ReadFromFile(path);
        }

        private void WriteToFile(FileManager fileManager)
        {
            var path = GetFilePath();
            fileManager.WriteToFile(path);
        }

        private void CreateDirectory(FileManager fileManager)
        {
            var path = GetFilePath();
            fileManager.CreateDirectory(path);
        }

        private void DeleteDirectory(FileManager fileManager)
        {
            var path = GetFilePath();
            fileManager.DeleteDirectory(path);
        }

        private void CreateFile(FileManager fileManager)
        {
            var path = GetFilePath();
            fileManager.CreateFile(path);
        }

        private void RenameFile(FileManager fileManager)
        {
            try
            {
                var path = GetFilePath();
                fileManager.RenameFile(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void CopyFile(FileManager fileManager)
        {
            var path = GetFilePath();
            fileManager.CopyFile(path);
        }

        private void DeleteFile(FileManager fileManager)
        {
            var path = GetFilePath();
            fileManager.DeleteFile(path);
        }

        public static string GetFilePath()
        {
            Console.WriteLine("Enter the path");
            return Console.ReadLine();
        }
    }
}
