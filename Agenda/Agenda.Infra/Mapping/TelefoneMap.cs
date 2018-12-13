using System;
using System.Collections.Generic;
using System.Text;
using Agenda.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Agenda.Infra.Mapping
{
    public class TelefoneMap : ClassMap<Telefone>
    {
        public TelefoneMap()
        {
            Id(x => x.telefoneId);
            Map(x => x.numero);
            References(x => x.tipoTelefone);
        }
    }
}
