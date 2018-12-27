using DataLayer.Interfaces;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Repositories;
using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        MyDbContext Context { get; set; }
        private IRepository<Author> _autorRepository;
        private ICourseRepository _coursesRepository;

        public UnitOfWork()
        {
            Context = new MyDbContext();
        }
        public IRepository<Author> AutorRepository
        {
            get
            {
                return _autorRepository ?? (_autorRepository = new Repository<Author>(Context));
            }
        }

        public ICourseRepository CourseRepository
        {
            get
            {
                return _coursesRepository ?? (_coursesRepository = new CourseRepository(Context));
            }
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
