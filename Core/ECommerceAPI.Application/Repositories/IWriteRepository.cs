﻿using ECommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Repositories
{
    // IWriteRepository interface base olarak alabilmek için ona verilen generic T class için IReadRepository generic yapıyoruz.
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T datas);
        Task<bool> AddRangeAsync(List<T> datas);
        bool Remove(T datas);
        bool RemoveRange(List<T> datas);
        Task<bool> RemoveAsync(string id);
        bool Update(T datas);

        Task<int> SaveAsync();
    }
}
