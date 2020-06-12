using Prototype.src.DeepCopy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.src
{
    [Serializable]
    class Student : AbstractPerson
    {
        public string name;
        public string gender;
        public int age;
        private School school;
        
        public Student(string name, string gender, int age, string schoolName, string schoolAddress)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;

            school = new School(schoolName, schoolAddress);
        }

        public void ModifySchool(string schoolName, string schoolAddress)
        {
            school.name = schoolName;
            school.address = schoolAddress;
        }

        public void Show()
        {
            Console.WriteLine("我叫{0}，{1}，{2}岁，是地址在{3}的{4}学校的学生。"
                ,name
                ,gender
                ,age
                ,school.address
                ,school.name);
        }

        public override AbstractPerson DeepCopy()
        {
            IDeepCopy deepCopy = new DeepCopyByBinarySerializer();
            //IDeepCopy deepCopy = new DeepCopyByXmlSerializer();
            return deepCopy.DeepCopyDispose(this);
        }

        public override AbstractPerson ShallowCopy()
        {
            return (Student)this.MemberwiseClone();
        }

    }
}
