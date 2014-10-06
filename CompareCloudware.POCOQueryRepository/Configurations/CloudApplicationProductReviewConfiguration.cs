using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class CloudApplicationProductReviewConfiguration : EntityTypeConfiguration<CloudApplicationProductReview>
    {
        public CloudApplicationProductReviewConfiguration()
        {
            ToTable("CloudApplicationProductReviews");
            Property(d => d.CloudApplicationProductReviewDate).IsRequired();
            Property(d => d.CloudApplicationProductReviewPublisherName).HasMaxLength(105);
            Property(d => d.CloudApplicationProductReviewText).HasMaxLength(1000);
            //Property(d => d.CloudApplicationProductReviewStatus).IsRequired();
            this.HasRequired(x => x.CloudApplicationProductReviewStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
