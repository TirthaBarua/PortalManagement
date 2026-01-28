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
    public class DepartmentService
    {
        DepartmentRepo repo;
        public DepartmentService(DepartmentRepo repo)
        {
            this.repo = repo;
        }
        public List<DepartmentDTO> GetAll()
        {
            var data = repo.GetAll();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<DepartmentDTO>>(data);
            return ret;
        }

        public DepartmentDTO Get(int id)
        {
            return MapperConfig.GetMapper().Map<DepartmentDTO>(id);
        }

        public bool Create(DepartmentDTO d)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Department>(d);
            return repo.Create(data);
        }
        public bool Update(DepartmentDTO d)
        {
            var mapper = MapperConfig.GetMapper();
            var data = mapper.Map<Department>(d);
            return repo.Update(data);
        }
        public bool Delete(int id)
        {
            return repo.Delete(id);

        }

        public List<DepartmentDTO> GetWithEmployees()
        {
            var data = repo.GetWithEmployees();
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<List<DepartmentDTO>>(data);
            return ret;
        }
        public DepartmentDTO FindByName(string name)
        {
            var data = repo.FindByName(name);
            var mapper = MapperConfig.GetMapper();
            var ret = mapper.Map<DepartmentDTO>(data);
            return ret;
        }
    }


    }

