using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class EmployeeRepo
    {
        EMSContext db;
    public EmployeeRepo(EMSContext db)
    {
        this.db = db;
    }
    public bool Create(Employee e)
        {
            db.Employees.Add(e);
            return db.SaveChanges() > 0;
        }
        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }
        public Employee Get(int id)
        {
            return db.Employees.Find(id);
        }
        public bool Update(Employee e)
        {
            var ex = Get(e.Id);
            db.Entry(ex).CurrentValues.SetValues(e);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Employees.Remove(ex);
            return db.SaveChanges() > 0;
        }

    }
}