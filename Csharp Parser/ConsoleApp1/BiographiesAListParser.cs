using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1{

    public class BiographiesAListParser : ParserBase{

        public BiographiesAListParser(string fileLocation = @"E:\Big movie files\biographies.list", string newFileName = @"..\..\..\testfiles\editedactorbiographies.csv") : base(fileLocation, newFileName) {
            this.fileMap = @"..\..\..\testfiles\";
        }

        public override void RunParser(){
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
