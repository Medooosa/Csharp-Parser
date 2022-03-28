using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class RegexBiographiescsvfile : ParserBase
    {
        public RegexBiographiescsvfile(string fileLocation = @"E:\Big movie files\testfiles\editedactorbiographies.csv", string newFileName = @"..\..\..\testfiles\editedbiotest.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"(.*)¤((.*[0-9]{4})|(.*))¤(.*)";
            this.substitution = "$1¤$3¤$4$5";
            this.startLine = "ACTORNAME¤MOVIEORSHOWNAME¤STARTYEAR¤EPNAMEORVOICE¤ROLE";
            this.fileMap = @"..\..\..\testfiles\";
        }
        public override void RunParser()
        {
            try
            {
                //StreamReader sr = new StreamReader(this.fileLocation, System.Text.Encoding.GetEncoding(28591));
                StreamReader sr = new StreamReader(this.fileLocation);
                StreamWriter sw = new StreamWriter(this.fileName);

                sw.WriteLine(this.startLine);

                RegexOptions options = RegexOptions.Singleline;
                Regex regexPattern = new Regex(this.pattern, options);

                string result = string.Empty, line;
                while ((line = sr.ReadLine()) != null)
                {
                    Match m = Regex.Match(line, this.pattern, options);
                    if (m.Success)
                    {
                        string substitutionTemp = this.substitution;
                        result = m.Value;
                        if (m.Groups[4].ToString().Length > 1)
                            substitutionTemp = @"$1¤$3¤$4,$5";
                        result = regexPattern.Replace(result, substitutionTemp);
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
