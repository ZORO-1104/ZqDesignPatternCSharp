using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChain.src
{
    class Request
    {
        public QuestionType Type { get; set; }
        public string Description { get; set; }
        public int Num { get; set; }
    }

    enum QuestionType
    {
        Leave,//请假
        Salary,//调薪
    }
}
