using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenerateCSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            string path = (@"C:\Users\mathi\source\repos\GenerateCSVFile\GenerateCSVFile\myOutPut.csv");
            
            using (StreamWriter sw = new StreamWriter (path))
            {
                for (int i = 0; i <= 1000000; i++)
                {
                    int randNum = r.Next(1, 10000);
                    
                    sw.WriteLine($"{i},{randNum}");
                }
            }
        }
    }
}
