using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace GenericRepository.Models
{
    public class TechnologicalDataModelMapping : EntityTypeConfiguration<TechnologicalDataModel>
    {
        public TechnologicalDataModelMapping()
        {
            ToTable("TechnologicalData");
            Property(m => m.ID).IsRequired();
            Property(m => m.Company);
            Property(m => m.Date);
            Property(m => m.OpenPrice);
            Property(m => m.ClosePrice);
            Property(m => m.HighestPrice);
            Property(m => m.LowestPrice);
            Property(m => m.ReturnOnInvestment);
            Property(m => m.Volume);
            Property(m => m.Yield);
        }
    }
}