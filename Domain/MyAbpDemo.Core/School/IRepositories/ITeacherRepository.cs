﻿using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Repositories;

namespace MyAbpDemo.Core
{
    public interface ITeacherRepository : IRepository<Teacher,long>
    {

    }
}
