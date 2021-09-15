using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day__task
{
    class Program
    {
        static void Main(string[] args)
        {

            FileHandling file = new FileHandling();
            // 1. Creating a new file mytest.txt

            // file.DeleteFile();


            //2. Deleteing file mytest.txt

            // file.DeleteFile();

            // 3. Is file already exist?
            //file.IsExist();

            //4. Creating a new file mytest.txt and writing into it

            //file.WriteFile();

            // 5. Reading contents from the file

            //file.ReadFile();

            //6. Display the perticular line data from the file

            int n = Convert.ToInt32(Console.ReadLine());
            file.ReadPerticularLine(n);


            //7. Counting the total number of lines
            //file.TotalLines();

            Console.Read(); 
        }
    }
}
