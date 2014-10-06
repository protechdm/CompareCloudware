using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class ThumbnailDocumentConfiguration : EntityTypeConfiguration<ThumbnailDocument>
    {
        public ThumbnailDocumentConfiguration()
        {
            ToTable("ThumbnailDocuments");
            Property(d => d.ThumbnailDocumentTitle).IsRequired();
            Property(d => d.ThumbnailDocumentTitle).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
