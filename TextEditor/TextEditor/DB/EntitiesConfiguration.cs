using Shared;
using System.Data.Entity.ModelConfiguration;

namespace Core.DBService
{
    public class FilesConfiguration : EntityTypeConfiguration<File>
    {
        public FilesConfiguration()
        {
            ToTable("Files");
        }
    }
}
