using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class DepartmentEmployeeDTO : DepartmentDTO
    {
        public List<EmployeeDTO> Employees { get; set; }

        public DepartmentEmployeeDTO()
        {
            Employees = new List<EmployeeDTO>();
        }
    }
}
