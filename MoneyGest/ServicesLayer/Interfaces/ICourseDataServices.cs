using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.Interfaces
{
    public interface ICourseDataServices : IRepositoryDataServices<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
        IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
