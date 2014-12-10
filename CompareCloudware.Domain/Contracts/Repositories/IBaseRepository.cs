using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.Objects;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Data.Entity.Core;

namespace CompareCloudware.Domain.Contracts.Repositories
{
    public interface IBaseRepository
    {
        bool Insert<T>(T model) where T : class;
        bool Insert<T>(string userId, T model) where T : class;
        bool Update<T>(string userId, T model) where T : class;
        bool Update<T>(string userId, T model, RefreshMode refreshMode) where T : class;
        bool Delete<T>(string userId, T model) where T : class;
    }
}
