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
            try
            {
                string line;
                StreamReader sr = new StreamReader(fileLocation, System.Text.Encoding.GetEncoding(28591));
                StreamWriter sw = new StreamWriter(fileName);
                string[] nameAndBirth = new string[3];
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("-"))
                    {
                        if (nameAndBirth[1] != null)
                        {
                            sw.WriteLine(nameAndBirth[0] + "¤" + nameAndBirth[1] + "¤" + nameAndBirth[2]);    
                        }
                        nameAndBirth = new string[3];
                    }
                    if (line.StartsWith("NM"))
                        nameAndBirth[0] = line.Substring(4, line.Length - 4);
                    if (line.StartsWith("DB"))
                    {
                        string result = line.Substring(4, line.Length - 4);
                        string[] splitted = result.Split(',');
                        for (int i = 0; i < splitted.Length; i++)
                        {
                            if (i == 0)
                                nameAndBirth[1] = splitted[i];
                            else if (i == 1)
                                nameAndBirth[2] = nameAndBirth[2] + splitted[i];
                            else
                                nameAndBirth[2] = nameAndBirth[2] + "," + splitted[i];
                        }
                        //nameAndBirth[1] = line.Substring(4, line.Length - 4);
                    }
                }
                sw.WriteLine(nameAndBirth[0] + "¤" + nameAndBirth[1] + "¤" + nameAndBirth[2]);
                sr.Close();
                sw.Close();
            }catch (Exception e){
                Console.WriteLine(e.ToString());
            }
        }
    }
}
