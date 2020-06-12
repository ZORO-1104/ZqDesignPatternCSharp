using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChain.src
{
    class Boss : Manager
    {
        public Boss(string name) : base(name)
        {
        }

        protected override bool IsCanHandle(Request request)
        {
            if (request.Type == QuestionType.Leave && request.Num <= 10)
            {
                return true;
            }
            else if (request.Type == QuestionType.Salary && request.Num <= 2000)
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
