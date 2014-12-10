using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class PersonTypeConfiguration : EntityTypeConfiguration<PersonType>
    {
        public PersonTypeConfiguration()
        {
            ToTable("PersonTypes");
            Property(d => d.PersonTypeName).IsRequired();
            Property(d => d.RowVersion).IsRowVersion();
            this.HasRequired(x => x.PersonTypeStatus);
        }
    }
}
