using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Code_First
{
    public class StudentModel : DbContext

    {
        //dung ket noi den Db
        public StudentModel(): base("name=con"){}
        // tao DataTable ten la Emplist chua danh sach sv
        public DbSet<Student> Emplist { get; set; }
    }
}
