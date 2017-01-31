using Hobby.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Hobby.Data.EntitiesConfiguration
{
    public class EntityConfigurationBase<T> : EntityTypeConfiguration<T> where T : class, IEntity
    {
        public EntityConfigurationBase(string tableName)
        {
            SetBasicConfiguration(tableName);
        }

        private void SetBasicConfiguration(string tableName)
        {
            ToTable(tableName);

            HasKey(e => e.Id);

            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.CreateDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(e => e.RowVersion)
                .IsFixedLength()
                .IsConcurrencyToken()
                .HasColumnType("timestamp")
                .HasMaxLength(8)
                .IsRowVersion();
        }
    }
}
