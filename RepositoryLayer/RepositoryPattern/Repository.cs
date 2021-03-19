using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.RepositoryPattern
{
    public class Repository<T> : IRepository<T> where T: BaseEntity
    {
    }
}
