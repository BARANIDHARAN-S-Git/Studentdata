﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sl_project2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string studentdetails = @"C:\Users\brother\Desktop\project-2\StudentData.txt";




            if (File.Exists(studentdetails))
            {

                string details = File.ReadAllText(studentdetails);
                Console.WriteLine(details);
            }

            else
            {
                Console.WriteLine("Error accours chech the path of document or check the condition,Thank You");
            }
            Console.ReadLine();

        }

    }
}
