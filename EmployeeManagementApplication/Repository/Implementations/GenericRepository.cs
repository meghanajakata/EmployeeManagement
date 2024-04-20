using EmployeeManagementApplication.Data;
using EmployeeManagementApplication.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApplication.Repository.Implementations
{
    public class GenericRepository <T> : IGenericRepository<T> where T : class
    {
        private readonly EmployeeManagementApplicationContext _context;
        private DbSet<T> table;
        public GenericRepository(EmployeeManagementApplicationContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public async Task<T> GetById(int id)
        {
            return await table.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public async Task Add(T entity)
        {
            await table.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            table.Remove(entity);
        }

        public void Update(T entity)
        {
            table.Update(entity);
        }
    }
}

