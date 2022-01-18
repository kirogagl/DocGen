using System;
using System.Collections.Generic;

namespace DocGen_2
{
    [Serializable]
    public class Shabls
    {
        int countOfLines = 1;
        List<string> labelBoxes;
        List<string> tegBoxes;

        public Shabls()
        {
        }

        public Shabls(int countOfLines, List<string> labelBoxes, List<string> tegBoxes)
        {
            this.countOfLines = countOfLines;
            this.labelBoxes = labelBoxes;
            this.tegBoxes = tegBoxes;
        }

        public int CountOfLines { get => countOfLines; set => countOfLines = value; }
        public List<string> LabelBoxes { get => labelBoxes; set => labelBoxes = value; }
        public List<string> TegBoxes { get => tegBoxes; set => tegBoxes = value; }
    }
}
