using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClientes.Data;
using WebApiClientes.DTOs;
using WebApiClientes.Infraestructura;

namespace WebApiClientes.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepo;

        public ClientController(IClientRepository clientRepository )
        {
            _clientRepo = clientRepository;
        }

        [HttpGet]
        public List<ClientDto> GetDataClient()
        {
            List<ClientDto> clientDtos = _clientRepo.GetDataClient().ToList();
            return clientDtos;
        }

        [HttpGet("{id}")]
        public ClientDto FindClient(int id)
        {
            ClientDto clientDto = _clientRepo.FindClient(id);
            return clientDto;
        }

        [HttpPost]
        public ClientDto addDataClient(ClientDto newClient)
        {
            ClientDto clientDto = _clientRepo.addDataClient(newClient);
            return clientDto;
        }

        [HttpPut("{id}")]
        public ClientDto UpdateClient(ClientDto clientUp)
        {
            ClientDto clientDto = _clientRepo.UpdateClient(clientUp);
            return clientDto;
        }

        [HttpDelete("{id}")]
        public ClientDto DeleteClient(ClientDto clientUp)
        {
            ClientDto clientDto = _clientRepo.DeleteClient(clientUp);
            return clientDto;
        }
    }


}
