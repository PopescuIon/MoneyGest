using RepositoryLayer.Interfaces;
using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    public interface IUnitOfWork:IDisposable 
    {
        IRepository<Author> AutorRepository { get; }

        ICourseRepository CourseRepository { get; }
       // IAuthorRepository Authors { get; }
        void Commit();
    }
}
