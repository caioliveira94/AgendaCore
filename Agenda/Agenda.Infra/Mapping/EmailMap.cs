using System;
using System.Collections.Generic;
using System.Text;
using Agenda.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Agenda.Infra.Mapping
{
    public class EmailMap : ClassMap<Email>
    {
        public EmailMap()
        {
            Id(x => x.emailId);
            Map(x => x.email);
        }
    }
}
