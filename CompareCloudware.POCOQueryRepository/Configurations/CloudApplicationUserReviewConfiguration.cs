using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class CloudApplicationUserReviewConfiguration : EntityTypeConfiguration<CloudApplicationUserReview>
    {
        public CloudApplicationUserReviewConfiguration()
        {
            ToTable("CloudApplicationUserReviews");
            //Property(d => d.CloudApplicationReviewDate).IsRequired();
            //Property(d => d.CloudApplicationReviewPublisherName).HasMaxLength(105);
            //Property(d => d.CloudApplicationUserReviewStatus).IsRequired();
            this.HasRequired(x => x.CloudApplicationUserReviewStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
