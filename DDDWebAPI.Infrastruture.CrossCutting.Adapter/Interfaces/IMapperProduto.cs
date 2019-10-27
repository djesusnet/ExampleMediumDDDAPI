using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Domain.Models;
using System.Collections.Generic;

namespace DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperProduto
    {
        #region Interfaces Mappers
        Produto MapperToEntity(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> clientes);

        ProdutoDTO MapperToDTO(Produto produto);

        #endregion

    }
}
