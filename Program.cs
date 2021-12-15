using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Join_Method_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher[] teachers =
            {
                new Teacher() {Name= "Jack"},
                new Teacher() {Name= "ProMan"},
                new Teacher() {Name= "A12-02"},
                new Teacher() {Name= "John"},
                new Teacher() {Name= "Jasmine"},
                new Teacher() {Name= "Azore"}
            };

            Student[] students =
            {
                new Student() {Name = "Xman"},
                new Student() {Name = "John"},
                new Student() {Name = "Tx-023"},
                new Student() {Name = "ProMan"},
                new Student() {Name = "Azore"},
                new Student() {Name = "Marry"}
            };

            // In Query Syntax

            //var Result = from teacher in teachers
            //             join student in students
            //             on teacher.Name equals student.Name
            //             select teacher;

            // In Method or Fluent Syntax 

            var Result = teachers.Join(students, 
                TeaName => TeaName.Name, 
                StuName => StuName.Name,
                (TeaName,StuName)
                => TeaName);

            foreach (var element in Result)
                Console.WriteLine("Name is  {0}", element.Name);
        }
    }
}
