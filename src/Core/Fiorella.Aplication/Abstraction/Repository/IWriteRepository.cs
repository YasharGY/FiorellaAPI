using Fiorella.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Aplication.Abstraction.Repository;

public interface IWriteRepository<T>:IRepository<T> where T : BaseEntity, new()
{
	Task AddAsync(T entity);
	Task AddRangeAsync(ICollection<T> entities);
	void Remove(T entity);
	void RemoveRange(ICollection<T> entities);
	void Update(T entity);
	Task SaveChangeAsync();
}
