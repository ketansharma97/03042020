using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DbGitPerson.Models
{[Table("Person")]
    public class Person
    {[Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Lname { get; set; }

    }
}
