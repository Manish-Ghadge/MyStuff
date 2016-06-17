using CodeFirstEF.Context;
using CodeFirstEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx =new SchoolContext())
            {
                //Student std = new Student()
                //{
                //    Name = "New Student"
                //};
                //ctx.Students.Add(std);

                //ctx.SaveChanges();

                Console.WriteLine(ctx.Students.FirstOrDefault().Name);
                Console.ReadKey();
            }
        }
    }
}
