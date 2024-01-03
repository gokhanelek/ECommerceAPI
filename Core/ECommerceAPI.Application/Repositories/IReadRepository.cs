using ECommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Repositories
{
    // IRepository interface base olarak alabilmek için ona verilen generic T class için IReadRepository generic yapıyoruz.
    // Tracking parametresi eklendi. DbContext yapılan değişiklikleri tracking edilmemesini istediğimiz zaman kullanabilmek için eklendi.Default değeri true
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        // Sorgu üzerinde çalışmak istiyorsak IQueryable kullanıyoruz.
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);

        Task<T> GetByIdAsync(string id, bool tracking = true);
    }
}
