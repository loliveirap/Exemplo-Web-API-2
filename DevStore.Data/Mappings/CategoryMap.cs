using DevStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace DevStore.Data.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");

            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(60).IsRequired();
            Property(x => x.IdState).HasMaxLength(10).IsRequired();
        }
    }
}
