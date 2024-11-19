using GenericRepoPractice.DataAccessLayer.Context;
using GenericRepoPractise.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepoPractice.DataAccessLayer.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext context)
        {
            TeacherRepository = new TeacherRepository(context);
            GroupRepository = new GroupRepository(context);
            _appDbContext = context;    
        }

        public ITeacherRepository TeacherRepository { get; }

        public IGroupRepository GroupRepository { get; }

        public int Save()
        {
            return _appDbContext.SaveChanges();
        }
    }
}
