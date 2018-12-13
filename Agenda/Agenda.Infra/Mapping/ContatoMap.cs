using System;
using System.Collections.Generic;
using System.Text;
using Agenda.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Agenda.Infra.Mapping
{
    public class ContatoMap : ClassMap<Contato>
    {
        public ContatoMap()
        {
            Id(x => x.contatoId);
            Map(x => x.nome);
            Map(x => x.empresa);
            HasMany(x => x.emails).KeyColumn("emailId");
            HasMany(x => x.telefones).KeyColumn("telefoneId");
            Map(x => x.endereco);
        }
    }
}
