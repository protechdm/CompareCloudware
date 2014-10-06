using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class CloudApplicationRatingConfiguration : EntityTypeConfiguration<CloudApplicationRating>
    {
        public CloudApplicationRatingConfiguration()
        {
            ToTable("CloudApplicationRatings");
            //Property(d => d.CloudApplicationReviewDate).IsRequired();
            //Property(d => d.CloudApplicationReviewPublisherName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
