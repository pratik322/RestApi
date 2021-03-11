using System;
using Aspose;
using System.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace RestAPIProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var getData = new GetRestData();
            Console.WriteLine("Enter Path");
            var dirPath = @"" + Console.ReadLine();
            Console.WriteLine("Enter the FileName with .csv extension");
            var FileName = Console.ReadLine();

            string[] tokens = FileName.Split('.');
            
            if (tokens[1] == "csv")
            {
                if (Directory.Exists(dirPath))
                {
                    var path = new DirectoryInfo(dirPath);
                    getData.getApiData(path.ToString(), FileName);
                }

                else
                {
                    Console.WriteLine("The Path Provided is Incorrect!!!");
                }
            }

            else
            {
                Console.WriteLine("Please Provide the FileName with Correct Input.");
            }
        }

    }
}
