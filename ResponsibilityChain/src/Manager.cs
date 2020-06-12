using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChain.src
{
    abstract class Manager
    {
        private string _name;
        protected Manager _manager;

        public Manager(string name)
        {
            _name = name;
        }

        public void SetSuperior(Manager manager)
        {
            _manager = manager;
        }

        public void HandleRequest(Request request)
        {
            if (IsCanHandle(request))
            {
                PassRequestDescription(request);
            }
            else
            {
                //无法处理该请求
                //交给其上级处理
                _manager?.HandleRequest(request);
            }
        }

        protected abstract bool IsCanHandle(Request request);

        protected virtual void PassRequestDescription(Request request)
        {
            Console.WriteLine($"当前请求是【{request.Type}】【{request.Description}】【{request.Num}】" +
                $"，该请求被{this.GetType().Name}=【{_name}】批准");
        }
    }
}
