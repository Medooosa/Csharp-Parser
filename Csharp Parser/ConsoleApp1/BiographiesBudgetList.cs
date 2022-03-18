using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class BiographiesBudgetList{
        string temp = string.Empty;
        string BiographiesActorFileName = @"business.list";
        string editedActorBiographies = @"business.csv";
        public BiographiesBudgetList(string fileLocation){
            BiographiesActorFileName = fileLocation;
        }

        public void RunParser(string fileLocation){
            string line;
            StreamReader sr = new StreamReader(BiographiesActorFileName, System.Text.Encoding.GetEncoding(28591));
            StreamWriter sw = new StreamWriter(editedActorBiographies);
            sw.WriteLine(string.Format("{0}¤{1}", "Name", "Budget"));
            string[] nameAndBudget = new string[2];
            while ((line = sr.ReadLine()) != null){
                int temp = line.Length;
                if (line.StartsWith("MV:")){
                    nameAndBudget[0] = line.Replace("MV: ", "");
                }else if(line.StartsWith("BT:")){
                    nameAndBudget[1] = line.Replace("BT: ", "");
                }else if(line.StartsWith("-") && nameAndBudget[0] != null && nameAndBudget[1] != null){
                    sw.WriteLine(string.Format("{0}¤{1}", nameAndBudget));
                    nameAndBudget = new string[2];
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}
