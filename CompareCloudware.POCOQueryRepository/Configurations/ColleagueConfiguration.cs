﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class ColleagueConfiguration : EntityTypeConfiguration<Colleague>
    {
        public ColleagueConfiguration()
        {
            ToTable("Colleagues");
            //Property(d => d.ColleagueOfIntroducer).IsRequired();
            //Property(d => d.EMail).HasMaxLength(105);
            //Property(d => d.RowVersion).IsRowVersion();
            //Property(d => d.Forename).IsRequired();
            //Property(d => d.NumberOfEmployees).IsRequired();
            ////Property(d => d.PersonStatus).IsRequired();
            //this.HasRequired(x => x.PersonStatus);
        }
    }
}