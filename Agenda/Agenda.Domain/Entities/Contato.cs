using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Domain.Entities
{
    public class Contato
    {
        public int contatoId { get; set; }
        public string nome { get; set; }
        public List<Telefone> telefones { get; set; }
        public List<Email> emails { get; set; }
        public string empresa { get; set; }
        public Endereco endereco { get; set; }
    }
}
