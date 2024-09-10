using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Route.MVCProject.BLL.Interfaces;
using Route.MVCProject.DAL.Data;
using Route.MVCProject.DAL.Models;

namespace Route.MVCProject.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public DepartmentRepository(ApplicationDbContext dbcontext) // Ask CLR for object from ApplicationDbContext Class
        {
            _dbContext = dbcontext;
        }

        public int Add(Department entity)
        {
            _dbContext.Add(entity);
            return _dbContext.SaveChanges();
        }

        public int Delete(Department entity)
        {
            _dbContext.Remove(entity);
            return _dbContext.SaveChanges();
        }

        public Department Get(int id)
        {
            /// Department deptartment = _dbContext.Departments.Local.FirstOrDefault(D => D.Id.Equals(id));
            /// if(deptartment is null)
            ///     deptartment = _dbContext.Departments.FirstOrDefault(D => D.Id.Equals(id))
            /// return deptartment;

            return _dbContext.Find<Department>(id);
        }

        public IEnumerable<Department> GetAll()
            => _dbContext.Departments.AsNoTracking().ToList();

        public int Update(Department entity)
        {
            _dbContext.Update(entity);
            return _dbContext.SaveChanges();
        }
    }
}
