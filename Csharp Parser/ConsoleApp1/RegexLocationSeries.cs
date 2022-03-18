using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexLocationSeries
    {
        private string pattern = @"(\"".*\"").(\([0-9,?,/,A-Z]{4,11}\)).(({.*}) ({.*})|({.*})|\t)\t+((.+)\t(\(.*\))|(.+))";
        private string substitution = "$1¤$2¤$4$6¤$5¤$8$10¤$9";
        private string startLine = "TITLE¤STARTYEAR¤TITLESERIES¤NOTE¤LOCATION¤COMMENTS";
        private string fileLocation;
        private string fileName;
        private string fileMap = @"..\..\..\testfiles\";
        public RegexLocationSeries(string fileLocation = @"E:\Big movie files\locations.list", string newFileName = @"..\..\..\testfiles\editedSlocations.csv")
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
