using Prototype.src;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("张三", "男", 12, "第九小学", "沈中大街");
            Student s2 = (Student)s1.ShallowCopy();//浅拷贝
            Student s3 = (Student)s1.DeepCopy();//深拷贝

            s1.Show();
            s2.Show();
            s3.Show();

            s2.name = "robin";
            s2.gender = "girl";
            s2.age = 15;
            //由于s2是从s1浅拷贝而来，所以s2修改引用类型School时，会同时修改s1的School信息。
            s2.ModifySchool("bb","aa");

            s3.name = "zoro";
            s3.gender = "boy";
            s3.age = 25;
            //由于s3是从s1深拷贝而来，所以s3修改引用类型School时，不影响s1。
            s3.ModifySchool("剑客", "AAAA");

            s1.Show();
            s2.Show();
            s3.Show();

            Console.ReadLine();
        }
    }
}
