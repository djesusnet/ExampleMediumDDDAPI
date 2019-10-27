using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Domain.Models;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace DDDWebAPI.Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperProduto : IMapperProduto
    {

        #region Properties

        List<ProdutoDTO> produtoDTOs = new List<ProdutoDTO>();

        #endregion

        #region methods

        public Produto MapperToEntity(ProdutoDTO produtoDTO)
        {
            Produto produto = new Produto
            {

                Id = produtoDTO.Id,
                Nome = produtoDTO.Nome,
                Valor = produtoDTO.Valor

            };

            return produto;

        }

        public IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> produtos)
        {
            foreach (var item in produtos)
            {

                ProdutoDTO produtoDTO = new ProdutoDTO
                {
                    Id = item.Id
                   ,
                    Nome = item.Nome
                   ,
                    Valor = item.Valor

                };

                produtoDTOs.Add(produtoDTO);
            }


            return produtoDTOs;

        }

        public ProdutoDTO MapperToDTO(Produto produto)
        {
            ProdutoDTO produtoDTO = new ProdutoDTO
            {
                Id = produto.Id
               ,
                Nome = produto.Nome
               ,
                Valor = produto.Valor
            };

            return produtoDTO;

        }

        #endregion
    }
}
