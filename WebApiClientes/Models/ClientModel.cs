using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiClientes.Models
{
    public class ClientModel
    {
        [Key]
        public int idClient { get; set; }
        public string name { get; set; }
        public string civilStatus { get; set; }
        public DateTime birthDate { get; set; }
    }
}
