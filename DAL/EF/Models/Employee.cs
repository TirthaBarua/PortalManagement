using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public float Salary { get; set; }

        [ForeignKey("Department")]
        public int Did { get; set; }

        public virtual Department Department { get; set; }
    }
}
