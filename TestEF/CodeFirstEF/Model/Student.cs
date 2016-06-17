using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstEF.Model
{
    public class Student
    {
        public Student()
        {

        }

        [Key]
        public int Id { get; set; }        
        public string Name { get; set; }
        public Standard Standard { get; set; }

       // [NotMapped]
        public int RollNo { get; set; }


    }
}
