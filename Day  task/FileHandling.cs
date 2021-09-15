using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day__task
{
    class FileHandling
    {
        public void CreateFile()
        {
            FileStream fs = new FileStream(@"C:\Training\Task\Day  task\Day  task\mytest.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            Console.WriteLine("File created successfully");
        }

        public void DeleteFile()
        {
            File.Delete(@"C:\Training\Task\Day  task\Day  task\mytest.txt");
            Console.WriteLine("File deleted Successfully");
        }

        public void IsExist()
        {
            if (File.Exists(@"C:\Training\Task\Day  task\Day  task\mytest.txt"))
                Console.WriteLine("File already exists..!");
            else
            {
                Console.WriteLine("Redirecting to Create file...");
                CreateFile();
            }
            
        }

        public void WriteFile()
        {
            FileStream fs = new FileStream(@"C:\Training\Task\Day  task\Day  task\mytest.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            int i = 1;
            sw.WriteLine(i++ + "Hello and welcome");
            sw.WriteLine(i++ + "This is the Second line");
            sw.WriteLine(i++ + "This is Third line of mytest.txt");

            sw.Close();
            fs.Close();
            Console.WriteLine("Data entered successfully");

        }

        public void ReadFile()
        {
            FileStream fs = new FileStream(@"C:\Training\Task\Day  task\Day  task\mytest.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
           
            while (sr.Peek() > 0) {
                Console.WriteLine(line);
                line = sr.ReadLine();   
            }

        }
        public void ReadPerticularLine(int n)
        {
            FileStream fs = new FileStream(@"C:\Training\Task\Day  task\Day  task\LineText.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
           
            int i = 1;
            while (i<n)
            {
                string line = sr.ReadLine();
                i++;
            }
            Console.WriteLine(sr.ReadLine());

        }

        public void TotalLines()
        {
            FileStream fs = new FileStream(@"C:\Training\Task\Day  task\Day  task\Lines.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();

            int i = 1;

            while (sr.Peek() > 0)
            {
                line = sr.ReadLine();
                i++;
            }

            Console.WriteLine("Total number of lines = " + i);
        }
    }
}
