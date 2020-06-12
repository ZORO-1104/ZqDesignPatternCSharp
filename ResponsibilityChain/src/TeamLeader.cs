using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChain.src
{
    class TeamLeader : Manager
    {
        public TeamLeader(string name) : base(name)
        {
        }

        protected override bool IsCanHandle(Request request)
        {
            if (request.Type == QuestionType.Leave && request.Num <= 2)
            {
                return true;
            }
            //else if (request.Type == QuestionType.Salary && request.Num <= 2)
            //{
            //    return true;
            //}
            else
            {
                return false;
            }
        }
    }
}
