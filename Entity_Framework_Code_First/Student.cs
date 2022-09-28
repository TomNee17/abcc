using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Code_First
{
    public class Student
    {
        public int studentID { get; set; }
        [StringLength(196)]
        public string name { get; set; }
        [EmailAddress]  
        public string email { get; set; }
        [Phone]
        public string phoneNumber { get; set; }
        [StringLength(255)]
        public string image { get; set; }




    }
}
