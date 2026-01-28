using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.EF.Models
{
    public class Department
    {       
        public int Id { get; set; }

        [StringLength(50)]
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }    

        public int TotalEmployee { get; set; }

        public virtual List<Employee> Employees { get; set; }
        public Department()
        {
                        Employees = new List<Employee>();

        }


    }
}
