using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Domain.Models;
using System.Collections.Generic;

namespace DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCliente
    {
        #region Mappers

        Cliente MapperToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);

        ClienteDTO MapperToDTO(Cliente Cliente);

        #endregion

    }
}
