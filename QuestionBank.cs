using Command_Practice.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Command_Practice
{
    internal class QuestionBank
    {
        public List<dynamic> categories = new List<dynamic>();
        internal QuestionBank()
        {
            categories.Add(new AzureCommandLine());
            categories.Add(new AzurePowerShell());
            categories.Add(new Docker());
            categories.Add(new Git());
            categories.Add(new Linux());
            categories.Add(new CSharp());
             
            foreach (var category in categories) 
            {
                AssignProblemNumbers(category);
            }
        }

        void AssignProblemNumbers(dynamic category)
        {
            for (int i = 0; i < category.problems.Count; i++)
            {
                category.problems[i].problemNumber = i; 
            }
        }

    }
}
