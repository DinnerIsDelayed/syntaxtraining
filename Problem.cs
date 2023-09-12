using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Practice
{
    
    internal class Problem
    {
        public int problemNumber { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Explanation { get; set; }

        internal Problem(string question,string answer,string explaination)
        {
            Question = question;
            Answer = answer;
            Explanation = explaination;
        }
    }
}
