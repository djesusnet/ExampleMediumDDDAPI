using DDDWebAPI.Application.DTO.DTO;
using System.Collections.Generic;

namespace DDDWebAPI.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDTO obj);

        ClienteDTO GetById(int id);

        IEnumerable<ClienteDTO> GetAll();

        void Update(ClienteDTO obj);

        void Remove(ClienteDTO obj);

        void Dispose();

    }
}
