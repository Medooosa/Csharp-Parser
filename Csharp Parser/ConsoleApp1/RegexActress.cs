using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class RegexActress : ParserBase
    {
        public RegexActress(string fileLocation = @"C:\Users\Gebruiker\Downloads\Actresses.list", string newFileName = @"..\..\..\testfiles\editedactressestest.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"(^(.*)\t)(.*)(\([0-9,?,/,A-Z]{4,11}\))((.*)((\{.*\})|(\[.*\]))|())";
            this.substitution = "$2¤$3¤$4¤$6¤$9";
            this.startLine = "ACTORNAME¤MOVIEORSHOWNAME¤STARTYEAR¤EPNAMEORVOICE¤ROLE";
            this.fileMap = @"..\..\..\testfiles\";
        }

        public override void RunParser()
        {
            try
            {
                StreamReader sr = new StreamReader(this.fileLocation, System.Text.Encoding.GetEncoding(28591));
                StreamWriter sw = new StreamWriter(this.fileName);

                sw.WriteLine(this.startLine);

                RegexOptions options = RegexOptions.Singleline;
                Regex regexPattern = new Regex(this.pattern, options);

                string result = string.Empty, line;
                Match mTemp = Regex.Match("", "");
                Group temp = mTemp.Groups[0];
                while ((line = sr.ReadLine()) != null)
                {
                    Match m = Regex.Match(line, this.pattern, options);
                    if (m.Success)
                    {
                        result = m.Value;
                        if (m.Groups[2].ToString().Length > 3)
                            temp = m.Groups[2];
                        else if (m.Groups[2].ToString().Length < 3)
                            result = temp.ToString() + result;
                        result = regexPattern.Replace(result, this.substitution);
                        result = Regex.Replace(result, @"\t+", ""); //om files tabs te removen
                        sw.WriteLine(result);
                    }
                }
                sr.Close();
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

