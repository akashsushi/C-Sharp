using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDrivenFileOperations
{
    public class FileManager
    {
        public void CreateFile(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File already exist");
            }
            using (FileStream sf = File.Create(path))
            {
               Console.WriteLine("New File created.");                
            }
        }
        public void RenameFile(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("Enter the new name for file:");
                var newName = Console.ReadLine();
                File.Move(path,newName);
                Console.WriteLine("File has been renamed");
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
        public void CopyFile(string path)
        {
            Console.WriteLine("Enter the new path");
            var newPath = Console.ReadLine();
            if (!File.Exists(path))
            {
                if (File.Exists(newPath))
                {
                    Console.WriteLine($"File exist in the path : {newPath}"); 
                }
               Console.WriteLine("No file to copy.");
            }
            File.Copy(path, newPath);
            Console.WriteLine($"New file copied and its location is " +    
                $"{Path.GetFullPath(newPath)}");

        }
        public void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File in the given path deleted");
            }
        }
        public void CreateDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                Console.WriteLine("Directory already exist");
            }                 
            Directory.CreateDirectory(path);
            Console.WriteLine("Directory has been Created");
        }
        public void DeleteDirectory(string path)
        {
            if (!(Directory.Exists(path)))
            {
                Console.WriteLine("There is no such directory found");
            }
            Directory.Delete(path);
            Console.WriteLine("Directory has been deleted");
        }
        public void WriteToFile(string path)
        {
            if (File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    Console.WriteLine("Enter the data to written into file");
                    var line = Console.ReadLine();
                    
                    while(line != "0")
                    {
                        sw.WriteLine(line);
                        line = Console.ReadLine();
                    }
                }
                Console.WriteLine("Data have been written into file");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
        public void ReadFromFile(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}

