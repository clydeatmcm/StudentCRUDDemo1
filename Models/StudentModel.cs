using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRUDDemo1.Models
{
    internal class StudentModel
    {
        public int Student_pk { get; set; }
        public string Student_id { get; set; }
        public DateTime Student_bday { get; set; }
        public float Student_gpa { get; set; }
    }
}
