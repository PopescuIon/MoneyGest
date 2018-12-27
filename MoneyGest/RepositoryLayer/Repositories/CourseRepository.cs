using DataLayer.Repositories;
using RepositoryLayer.Interfaces;
using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(MyDbContext context)
          : base(context)
        {
        }
        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            var res = new List<Course>();
            res.Add(new Course { Description = "rescription", AuthorId = count });
            return res;//Context.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        {
            return null;
            //return PlutoContext.Courses
            //    .Include(c => c.Author)
            //    .OrderBy(c => c.Name)
            //    .Skip((pageIndex - 1) * pageSize)
            //    .Take(pageSize)
            //    .ToList();
        }
    }
}
