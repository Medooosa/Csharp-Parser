using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class BiographiesActorList
    {
        string temp = string.Empty;
        string BiographiesActorFileName = @"E:\Big movie files\biographies.list";
        string editedActorBiographies = @"..\..\..\testfiles\editedactorbiographies.csv";
        public BiographiesActorList(string fileLocation = @"E:\Big movie files\Csharp-Parser\Csharp Parser\ConsoleApp1\Biographiesactortestfile.txt")
        {
            BiographiesActorFileName = fileLocation;
        }
        public void RunParser(string path = @"..\..\..\testfiles\editedactorbiographies.csv")
        {
            string line;
            StreamReader sr = new StreamReader(BiographiesActorFileName, System.Text.Encoding.GetEncoding(28591));
            StreamWriter sw = new StreamWriter(editedActorBiographies);
            string[] nameAndBirth = new string[2];
            while ((line = sr.ReadLine()) != null)
            {
                int temp = line.Length;
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
