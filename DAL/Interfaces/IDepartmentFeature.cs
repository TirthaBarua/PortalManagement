using DAL.EF.Models;
using System.Collections.Generic;

namespace DAL.Repos.Interfaces
{
    public interface IDepartmentFeature
    {
        List<Department> GetWithEmployees();
        Department FindByName(string name);
        Department HighestEmployees();
    }
}
