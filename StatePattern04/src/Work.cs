using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern04.src
{
    class Work
    {
        private IWorkState state;
        private bool taskFinished;
        //private int 

        public int CurrentHour
        {
            get;set;
        }

        public IWorkState State
        {
            get => state;
            set => state = value;
        }

        public bool TaskFinished
        {
            get => taskFinished;
            set => taskFinished = value;
        }

        public Work()
        {
            state = new ForenoonState();
            taskFinished = false;
            CurrentHour = 9;
        }

        public void WriteProgram()
        {
            state.WriteProgram(this);
        }
    }
}
