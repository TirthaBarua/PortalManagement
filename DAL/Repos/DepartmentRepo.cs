using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class DepartmentRepo : IDepartmentFeature
    {
        EMSContext db;
        public DepartmentRepo(EMSContext db)
        {
            this.db = db;
        }
        public bool Create(Department dept)
        {
            db.Departments.Add(dept);
            return db.SaveChanges() > 0;
        }

        public List<Department> GetAll()
        {
            return db.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return db.Departments.Find(id);
        }

        public bool Update(Department dept)
        {
            var ex = GetById(dept.Id);
            db.Entry(ex).CurrentValues.SetValues(dept);
            return db.SaveChanges() > 0;

        }

        public bool Delete(int id)
        {
            var ex = GetById(id);
            db.Departments.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Department> GetWithEmployees()
        {
            return db.Departments
                     .Include(d => d.Employees)
                     .ToList();
        }

        public Department FindByName(string name)
        {
            var dept = (from d in db.Departments
                        where d.Name.Contains(name)
                        select d).SingleOrDefault();
            return dept;
        }

        public Department HighestEmployees()
        {
            var dept = (from d in db.Departments.Include(d => d.Employees)
                        orderby d.Employees.Count() descending
                        select d).FirstOrDefault();
            return dept;

        }

    }

}
