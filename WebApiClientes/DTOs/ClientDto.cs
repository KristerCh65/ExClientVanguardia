using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiClientes.DTOs
{
    public class ClientDto
    {
        public int idClient { get; set; }
        public string name { get; set; }
        public string civilStatus { get; set; }
        public DateTime birthDate { get; set; }
        public bool activo { get; set; }
        public string errorMessage { get; set; }
    }
}
