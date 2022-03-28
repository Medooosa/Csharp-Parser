using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1 {

    public class BussinessMListParser : ParserBase {
        
        public BussinessMListParser(string fileLocation = @"E:\Big movie files\business.list", string newFileName = @"..\..\..\testfiles\editedbussiness.csv") : base(fileLocation, newFileName){
            this.fileMap = @"..\..\..\testfiles\";
        }

public override void RunParser(){
    try{
        string line;
        StreamReader sr = new StreamReader(this.fileLocation, System.Text.Encoding.GetEncoding(28591));
        StreamWriter sw = new StreamWriter(this.fileName);
        sw.WriteLine("Name¤Budget");
        string[] nameYearAndBudget = new string[3];
        while ((line = sr.ReadLine()) != null){
            int temp = line.Length;
            if (line.StartsWith("MV:")){
                nameYearAndBudget[0] = line.Replace("MV: ", "");
                string[] split = nameYearAndBudget[0].Split('(');
                nameYearAndBudget[0] = split.Length > 0 ? split[0] : "";
                nameYearAndBudget[1] = split.Length > 1 ? split[1].Split(')')[0] : "";

                if(nameYearAndBudget[0].Length > 0){
                    nameYearAndBudget[0] = nameYearAndBudget[0].Remove(nameYearAndBudget[0].Length-1);
                }
                
            }else if(line.StartsWith("BT:")){
                nameYearAndBudget[2] = line.Replace("BT: ", "");
            }else if(line.StartsWith("-") && nameYearAndBudget[0] != null && nameYearAndBudget[2] != null){
                sw.WriteLine(string.Format("{0}¤{1}¤{2}", nameYearAndBudget));
                nameYearAndBudget = new string[3];
            }
        }
        sr.Close();
        sw.Close();
    }catch (Exception e){
        Console.WriteLine(e.ToString());
    }
}

        public string Between(string str, string firstString, string lastString){
            if(str.Length <= 0) return "XXXX";
            int Pos1 = str.IndexOf(firstString) + firstString.Length;
            int Pos2 = str.IndexOf(lastString);
            return str.Substring(Pos1, Pos2 - Pos1);
        }

    }
}
