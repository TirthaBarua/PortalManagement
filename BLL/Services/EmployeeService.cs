using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace BLL.Services
{
    public class EmployeeService
    {
        EmployeeRepo repo;
        public EmployeeService(EmployeeRepo repo)
        {
            this.repo = repo;
        }
        public List<EmployeeDTO> GetAll()
        {
            var data = repo.GetAll();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<EmployeeDTO>>(data);
            return ret;
        }

        public EmployeeDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<EmployeeDTO>(id);
        }

        public bool Create(EmployeeDTO e)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Employee>(e);
            return repo.Create(data);
        }
        public bool Update(EmployeeDTO e)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Employee>(e);
            return repo.Update(data);
        }
        public bool Delete(int id)
        {
            return repo.Delete(id);

        }




    }
}
