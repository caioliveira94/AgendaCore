using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Domain.Entities
{
    public class Endereco
    {
        public int enderecoId { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
    }
}
