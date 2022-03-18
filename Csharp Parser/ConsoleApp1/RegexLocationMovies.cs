using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexLocationMovies
    {
        private string pattern = @"^(?![\""])(.*) (\([0-9,?,/,A-Z]{4,11}\)).((\([A-Z]{1,2}\))|(\([A-Z]{1,2}\)) |)(({.*})|)\t+((.+)\t(\(.*\))|(.+))";
        private string substitution = "$1¤$2¤$4$5¤$7¤$9$11¤$10";
        private string startLine = "TITLE¤STARTYEAR¤ATTRIBUTE¤NOTE¤LOCATION¤COMMENTS";
        private string fileLocation;
        private string fileName;
        private string fileMap = @"..\..\..\testfiles\";
        public RegexLocationMovies(string fileLocation = @"E:\Big movie files\locations.list", string newFileName = @"..\..\..\testfiles\editedMlocations.csv")
        {
            this.fileLocation = fileLocation;
            fileName = fileMap + newFileName + ".csv";
        }
        public string GetPattern { get { return pattern; } }
        public string GetSubsitution { get { return substitution; } }
        public string GetStartLine { get { return startLine; } }
        public string GetFileLocation { get { return fileLocation; } }
        public string GetFileName { get { return fileName; } }
        public void SetFileLocation(string fileLocation) { this.fileLocation = fileLocation; }
        public void SetFileName(string fileName) { this.fileName = fileMap + fileName + "csv"; }
    }
}
