using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList AL = new ArrayList();
            AL.Add("TIRAMISU LAYER CAKE");
            AL.Add("DEVIL'S FOOD CAKE");
            AL.Add("LEMON SOUFFLES");
            AL.Add("WHITE CHOCOLATE RASPBERRY CHEESECAKE");
            AL.Add("BAKLAVA");
            FileStream fs = new FileStream("E:/Training/Day 5/files/desert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach (string s in AL)
            {
                sw.Write(s + "\n");
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            FileStream fs1 = new FileStream("E:/Training/Day 5/files/desert.txt", FileMode.Open, FileAccess.Read);
            StreamReader sa = new StreamReader(fs1);
            string line = sa.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sa.ReadLine();
            }
            string fileName = @"E:/Training/Day 5/files/desert.txt";
            FileInfo fi = new FileInfo(fileName);
            bool exists = fi.Exists;
            if (fi.Exists)
            {
                DateTime creationTime = fi.CreationTime;
                long size = fi.Length;
                Console.WriteLine("File Size in Bytes: {0}", size);
                Console.WriteLine("Creation time: {0}", creationTime);
            }
            Console.ReadLine();
        }

    }
}
