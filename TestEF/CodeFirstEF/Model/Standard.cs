using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEF.Model
{
    public class Standard
    {
        public Standard() { }

        [Key]
       
        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public string PostalCode { get; set; }

        [NotMapped]
        public string ContactNo { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
