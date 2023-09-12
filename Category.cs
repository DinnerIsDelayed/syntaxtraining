using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Practice
{
    internal class Category
    {
        internal List<Problem> problems = new List<Problem>();

        internal void AddProblem(Problem problem)
        {
            problems.Add(problem);
        }
    }
    
}
