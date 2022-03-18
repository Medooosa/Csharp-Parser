using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1 {
    public class ParserBase {

        protected string pattern = "";
        protected string substitution = "";
        protected string startLine = "";
        protected string fileLocation = "";
        protected string fileName = "";
        protected string fileMap = "";

        public ParserBase(string fileLocation, string newFileName) {
            this.fileLocation = fileLocation;
            fileName = fileMap + newFileName;
        }

        public virtual void RunParser(){
            try{
                StreamReader sr = new StreamReader(this.fileLocation, System.Text.Encoding.GetEncoding(28591));
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
                        result = m.Value;
                        result = regexPattern.Replace(result, this.substitution);
                        result = Regex.Replace(result, @"\t+", ""); //om files tabs te removen
                        sw.WriteLine(result);
                    }
                }
                sr.Close();
                sw.Close();
            }catch (Exception e){
                Console.WriteLine(e.ToString());
            }
        }

        public string GetPattern { get { return pattern; } }
        public string GetSubsitution { get { return substitution; } }
        public string GetStartLine { get { return startLine; } }
        public string GetFileLocation { get { return fileLocation; } }
        public string GetFileName { get { return fileName; } }
        public void SetFileLocation(string fileLocation) { this.fileLocation = fileLocation; }
        public void SetFileName(string fileName) { this.fileName = fileMap + fileName; }
    }
}
