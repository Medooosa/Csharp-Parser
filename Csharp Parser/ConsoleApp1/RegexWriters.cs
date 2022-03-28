using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class RegexWriters : ParserBase
    {
        public RegexWriters(string fileLocation = @"E:\Big movie files\Writers.list", string newFileName = @"..\..\..\testfiles\editedwriters.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"(^(.*)\t)(.*)(\([0-9,?,/,A-Z]{4,11}\))((.*)((\{.*\})|(\[.*\]))|())( \(([A-Z]{1,3})\)|())(\s+(\(.*\))|())";
            this.substitution = "$1¤$3¤$4¤$8¤$12¤$15";
            this.pattern = @"(.*)\t(\""(.*)\""|(.*)) (\([0-9,?,/,A-Z]{4,11}\))( (\([A-Z]{1,2}\))| ({{SUSPENDED}})| ({.*})|)( ({.*})|)( +(\(uncredited\))| +(\(.*\)) | +(\(.*\))|)( +(\[.*\])| *(\(.*\))|)";
            this.substitution = "$1¤$3$4¤$5¤$7¤$9¤$8$11¤$14$15¤$13$18¤$17";
            this.startLine = "ACTOR¤MOVIEORSHOWNAMESTARTYEAR¤ATTRIBUTE¤COMMENT";
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
                        if (m.Groups[1].ToString().Length > 3)
                            temp = m.Groups[1];
                        else if (m.Groups[1].ToString().Length < 3)
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

