using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using Castle.DynamicProxy;

namespace ProxySubject02.src
{
    //测试拦截器
    public class TestInterceptor
    {
        public virtual void MethodInterceptor()
        {
            Console.WriteLine("走过滤器");
        }

        public virtual int Add(int a, int b)
        {
            Console.WriteLine($"{a}+{b}={a+b}");
            return a + b;
        }

        public void NoInterceptor()
        {
            Console.WriteLine("不走过滤器");
        }
    }

    class MyInterceptor : StandardInterceptor
    {
        protected override void PerformProceed(IInvocation invocation)
        {
            base.PerformProceed(invocation);
            Console.WriteLine($"拦截的方法返回时调用的拦截器，方法名是：[{invocation.Method.Name}]，返回结果是[{invocation.ReturnValue}]");
        }

        protected override void PostProceed(IInvocation invocation)
        {
            Console.WriteLine($"调用后的拦截器，方法名是：[{invocation.Method.Name}]，返回结果是[{invocation.ReturnValue}]");
        }

        protected override void PreProceed(IInvocation invocation)
        {
            Console.WriteLine($"调用前的拦截器，方法名是：[{invocation.Method.Name}]，返回结果是[{invocation.ReturnValue}]");
        }
    }

    class MyProxyPattern02
    {
        public void Execute()
        {
            ProxyGenerator generator = new ProxyGenerator();//实例化【代理类生成器】  
            MyInterceptor interceptor = new MyInterceptor();//实例化【拦截器】  

            //使用【代理类生成器】创建对象，而不是使用new关键字来实例化  
            TestInterceptor test = generator.CreateClassProxy<TestInterceptor>(interceptor);

            Console.WriteLine($"当前类型:{test.GetType()},父类型:{test.GetType().BaseType}");
            Console.WriteLine();
            
            test.MethodInterceptor();
            Console.WriteLine();

            test.Add(10, 20);
            Console.WriteLine();
            
            test.NoInterceptor();
            Console.WriteLine();
            
            Console.ReadLine();
        }
    }
}
