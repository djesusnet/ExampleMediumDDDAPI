using DDDWebAPI.Domain.Core.Interfaces.Repositorys;
using DDDWebAPI.Domain.Models;
using DDDWebAPI.Infrastructure.Data;

namespace DDDWebAPI.Infrastruture.Repository.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {

        private readonly SqlContext _context;
        public RepositoryProduto(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

    }
}
