﻿using GenericRepoPractice.DataAccessLayer.Context;
using GenericRepoPractise.Domain.Entities;
using GenericRepoPractise.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepoPractice.DataAccessLayer.Implementation
{
    public class GroupRepository : GenericRepository<Group>, IGroupRepository
    {
        public GroupRepository(AppDbContext context) : base(context)
        {
            
        }


    }
}
