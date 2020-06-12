using Composite.src.Pattern;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component cs1 = new src.Pattern.Composite("北京总公司");

            Component cs2 = new src.Pattern.Composite("上海分公司");
            Component cs3 = new src.Pattern.Composite("广州分公司");

            Component cl1 = new Leaf("财务部A1");
            Component cl2 = new Leaf("人力部B1");
            Component cl3 = new src.Pattern.Composite("办事处C1");
            cs2.Add(cl1);
            cs2.Add(cl2);
            cs2.Add(cl3);

            Component cl11 = new Leaf("财务部A11");
            Component cl12 = new Leaf("人力部B11");
            Component cl13 = new Leaf("办事处C11");
            cl3.Add(cl11);
            cl3.Add(cl12);
            cl3.Add(cl13);

            Component cl4 = new Leaf("财务部A2");
            Component cl5 = new Leaf("财务部B2");
            Component cl6 = new Leaf("财务部C2");
            cs3.Add(cl4);
            cs3.Add(cl5);
            cs3.Add(cl6);

            Component cl7 = new Leaf("总部财务部");
            Component cl8 = new Leaf("总部人力部");

            cs1.Add(cs2);
            cs1.Add(cs3);
            cs1.Add(cl7);
            cs1.Add(cl8);

            cs1.GetChild(1).Add(new src.Pattern.Composite("MarketDepartment01"));
            cs1.GetChild(1).Add(new src.Pattern.Composite("MarketDepartment02"));
            cs1.GetChild(1).GetChild(3).Add(new src.Pattern.Composite("HR01"));
            cs1.GetChild(1).GetChild(3).Add(new src.Pattern.Composite("HR02"));
            cs1.GetChild(1).GetChild(3).Add(new src.Pattern.Composite("HR003"));

            cs1.OperationMethod(1);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            cs3.OperationMethod(1);


            Console.ReadLine();
        }
    }
}
