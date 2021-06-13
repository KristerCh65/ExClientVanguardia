using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClientes.DTOs;
using WebApiClientes.Models;

namespace WebApiClientes.Infraestructura
{
    public interface IClientRepository
    {
        public List<ClientDto> GetDataClient();
        public ClientDto addDataClient(ClientDto dataClient);
        public ClientDto DeleteClient(int idClient);
        public ClientDto UpdateClient(ClientDto clientDto);
        public ClientDto FindClient(int dataClient);
    }
}
