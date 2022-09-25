using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MrktProduto.Domain.Models;

namespace MrktProduto.Repository.Mapping
{
    public class ItemMapping : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.QtdPedida).IsRequired();

            builder.HasMany(x => x.Produtos).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}