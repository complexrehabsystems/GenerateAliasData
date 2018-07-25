using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateData
{
    /*
     * This class separates the alias data based on the group and assigns an id.
     */
    class Data
    {
        /*
         * This function reads all the lines from the input file.
         */
        public static string[] ReadAllTheAliasGroups(string inputFile)
        {
            return System.IO.File.ReadAllLines(inputFile);
        }

        /*
         * This function writes all the input data to the output file.
         */
        public static void WriteData(string[] inputData, string outputFileName)
        {
            int groupId = 1;
            foreach (string line in inputData)
            {
                string[] words = line.Split(',');
                foreach (string word in words)
                {
                    string text = word + "," + groupId;
                    using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter(outputFileName, true))
                    {
                        file.WriteLine(text);
                    }
                }

                groupId++;
            }
        }

        static void Main(string[] args)
        {
            string inputFile = @"C:\Users\hadusumilli\Desktop\workspace\GenerateData\GenerateData\Names.txt";
            string[] inputData = ReadAllTheAliasGroups(inputFile);

            string outputFile = @"C:\Users\hadusumilli\Desktop\workspace\GenerateData\GenerateData\alias-names.csv";
            WriteData(inputData, outputFile);
        }
    }
}
