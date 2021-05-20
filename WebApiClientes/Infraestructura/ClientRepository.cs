using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClientes.Data;
using WebApiClientes.DTOs;
using WebApiClientes.Models;

namespace WebApiClientes.Infraestructura
{
    public class ClientRepository : IClientRepository
    {
        public readonly ClientContext _context;

        public ClientRepository( ClientContext clientContext)
        {
            _context = clientContext;
        }

        public List<ClientDto> GetDataClient()
        {
            var client = _context.clientModels.ToList();
            List<ClientDto> clientDtos = new List<ClientDto>();

            foreach (ClientModel cliente in client)
            {
                clientDtos.Add(new ClientDto { 
                    idClient = cliente.idClient,
                    name = cliente.name,
                    civilStatus = cliente.civilStatus,
                    birthDate = cliente.birthDate
                });
            }

            return clientDtos;
        }

        public ClientDto FindClient(int id)
        {
            var client = _context.clientModels.FirstOrDefault(c => c.idClient == id);

            if (client == null)
            {
                return new ClientDto {
                    errorMessage = "Not found"
                };
            }

            return new ClientDto
            {
                idClient = client.idClient,
                name = client.name,
                civilStatus = client.civilStatus,
                birthDate = client.birthDate
            };

        }

        public ClientDto addDataClient(ClientDto newClient)
        {
            if( newClient != null)
            {
                ClientModel cliente = new ClientModel
                {
                    name = newClient.name,
                    civilStatus = newClient.civilStatus,
                    birthDate = newClient.birthDate
                };
                _context.clientModels.Add(cliente);
                _context.SaveChanges();
                newClient.idClient = cliente.idClient;

                return newClient;
            }

            return new ClientDto
            {
                errorMessage = "Empty Client"
            };
        }

        public ClientDto UpdateClient(ClientDto clientUp)
        {
            var register = _context.clientModels.FirstOrDefault(c => c.idClient == clientUp.idClient);

            if (register != null)
            {
                return new ClientDto
                {
                    errorMessage = "Empty Client"
                };
            }

            register.idClient = clientUp.idClient;
            register.name = clientUp.name;
            register.civilStatus = clientUp.civilStatus;
            register.birthDate = clientUp.birthDate;

            _context.SaveChanges();
            return clientUp;
        }

        public ClientDto DeleteClient(ClientDto clientUp)
        {
            var register = _context.clientModels.FirstOrDefault(c => c.idClient == clientUp.idClient);

            if (register != null)
            {
                return new ClientDto
                {
                    errorMessage = "Not found Client"
                };
            }

            _context.clientModels.Remove(register);
            _context.SaveChanges();
            return clientUp;
        }


    }
}
