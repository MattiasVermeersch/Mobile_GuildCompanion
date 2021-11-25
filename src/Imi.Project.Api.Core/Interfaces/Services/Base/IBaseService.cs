using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.Base
{
    public interface IBaseService<T, TKey> 
    {
        Task<IEnumerable<T>> ListAllAsync();
        Task<T> GetByIdAsync(TKey id);
    }
}
