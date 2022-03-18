using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class BiographiesAListParser
    {
        private string testFile = @"E:\Big movie files\Csharp-Parser\Csharp Parser\ConsoleApp1\Biographiesactortestfile.txt";
        private string fileLocation;
        private string fileMap = @"..\..\..\testfiles\";
        private string fileName = @"..\..\..\testfiles\editedactorbiographies.csv";
        public BiographiesAListParser(string fileLocation = @"E:\Big movie files\biographies.list")
        {
            this.fileLocation = fileLocation;
        }
        public string GetFileLocation { get { return fileLocation; } }
        public string GetFileName { get { return fileName; } }
        public void SetFileLocation(string fileLocation) { this.fileLocation = fileLocation; }
        public void SetFileName(string fileName) { this.fileName = fileMap + fileName + "csv"; }
        public void RunParser()
        {
            string line;
            StreamReader sr = new StreamReader(fileLocation, System.Text.Encoding.GetEncoding(28591));
            StreamWriter sw = new StreamWriter(fileName);
            string[] nameAndBirth = new string[2];
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("-"))
                {
                    if (nameAndBirth[1] != null)
                    {
                        sw.WriteLine(nameAndBirth[0] + "¤" + nameAndBirth[1]);    
                    }
                    nameAndBirth = new string[2];
                }
                if (line.StartsWith("NM"))
                    nameAndBirth[0] = line.Substring(4, line.Length - 4);
                if (line.StartsWith("DB"))
                    nameAndBirth[1] = line.Substring(4, line.Length - 4);
            }
            sw.WriteLine(nameAndBirth[0] + "¤" + nameAndBirth[1]);
            sr.Close();
            sw.Close();
        }
    }
}
