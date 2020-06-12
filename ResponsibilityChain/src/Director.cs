using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChain.src
{
    class Director : Manager
    {
        public Director(string name) : base(name)
        {
        }

        protected override bool IsCanHandle(Request request)
        {
            if (request.Type == QuestionType.Leave && request.Num <= 5)
            {
                return true;
            }
            else if (request.Type == QuestionType.Salary && request.Num <= 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
