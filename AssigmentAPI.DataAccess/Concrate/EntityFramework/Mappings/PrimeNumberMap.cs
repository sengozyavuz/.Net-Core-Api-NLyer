﻿using AssigmentAPI.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace AssigmentAPI.DataAccess.Concrate.EntityFramework.Mappings
{
    public class PrimeNumberMap : EntityTypeConfiguration<PrimeNumber>
    {
        public PrimeNumberMap()
        {
            ToTable(@"UserRoles", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Number).HasColumnName("Number");
        }
    }
}
