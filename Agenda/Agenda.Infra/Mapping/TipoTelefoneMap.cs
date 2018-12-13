using System;
using System.Collections.Generic;
using System.Text;
using Agenda.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Agenda.Infra.Mapping
{
    public class TipoTelefoneMap : ClassMap<TipoTelefone>
    {
        public TipoTelefoneMap()
        {
            Id(x => x.tipoTelefoneId);
            Map(x => x.tipo);
        }
    }
}
