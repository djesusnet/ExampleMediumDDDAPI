using DDDWebAPI.Domain.Core.Interfaces.Repositorys;
using DDDWebAPI.Domain.Models;
using DDDWebAPI.Infrastructure.Data;

namespace DDDWebAPI.Infrastruture.Repository.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext _context;
        public RepositoryCliente(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
