using DataLayer.Repositories;
using ServicesLayer.Interfaces;
using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataLayer.Services
{
    public class CourseDataServices : ICourseDataServices
    {
        public void Add(Course entity)
        {
            using (var uow =new UnitOfWork())
            {
                uow.CourseRepository.Add(entity);
                uow.Commit();
            }
        }

        public void AddRange(IEnumerable<Course> entities)
        {
           
        }

        public IEnumerable<Course> Find(Expression<Func<Course, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Course Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> Get(Expression<Func<Course, bool>> filter = null, Func<IQueryable<Course>, IOrderedQueryable<Course>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            using (var uow = new UnitOfWork())
            {
               var rez= uow.CourseRepository.GetTopSellingCourses(count);
                uow.Commit();
                return rez;
            }
        }

        public void Remove(Course entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Course> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
