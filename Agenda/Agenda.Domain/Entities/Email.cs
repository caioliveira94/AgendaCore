using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Domain.Entities
{
    public class Email
    {
        public int emailId { get; set; }
        public string email { get; set; }
        public int contatoId { get; set; }
    }
}
