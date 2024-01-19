using System.Linq.Expressions;

namespace linqJoin
{
    internal class Program
    {
        class teacher
        {
            public string name { get; set; }    

        }

        class student
        {
            public string name { get; set; }
        }
        static void Main(string[] args)
        {
            teacher[] teachers ={
                new teacher(){name="asmaa"},
                new teacher(){name="ahmed"},
                new teacher(){name="hassan"},
                new teacher(){name="mohamed"}

            };
            student[] students =
            {
                new student(){name="mohamed"},
                new student(){name="bassem"},
                 new student(){name="ahmed"},
                new student(){name="alaa"},
                new student(){name="ali"},
            };
            //Query sentax
            //var joinList = from teacher in teachers
            //               join
            //             student in students
            //             on teacher.name equals student.name
            //               select teacher;


                          
            //foreach (var item in joinList)
            //{
            //    Console.WriteLine(item.name);
            //}

                         //Method syntax
            var joinList = teachers.Join(students,
                tname => tname.name,
                sname => sname.name,
                (tname, sname) => tname );

            foreach (var item in joinList)
            {
                Console.WriteLine("name="+item.name);
            }
            Console.ReadKey();

        }
    }
}