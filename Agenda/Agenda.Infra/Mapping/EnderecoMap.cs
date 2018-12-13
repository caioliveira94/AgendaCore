using System;
using System.Collections.Generic;
using System.Text;
using Agenda.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Agenda.Infra.Mapping
{
    public class EnderecoMap : ClassMap<Endereco>
    {
        public EnderecoMap()
        {
            Id(x => x.enderecoId);
            Map(x => x.endereco);
            Map(x => x.cep);
            Map(x => x.complemento);
            Map(x => x.numero);
        }
    }
}
