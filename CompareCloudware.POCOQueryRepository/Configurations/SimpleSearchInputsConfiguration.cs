﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class SimpleSearchInputsConfiguration : EntityTypeConfiguration<SimpleSearchInputs>
    {
        public SimpleSearchInputsConfiguration()
        {
            ToTable("SimpleSearchInputs");
        }
    }
}
