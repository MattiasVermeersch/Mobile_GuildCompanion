using Imi.Project.Api.Core.Entities.Base;
using Imi.Project.Api.Core.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IRepository<T> : IBaseRepository<T, Guid>
        where T : BaseEntity
    {    }
}
