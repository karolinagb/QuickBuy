using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;

namespace QuickBuy.Repositorio.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Para configurar a chave primária:
            builder.HasKey(usuario => usuario.Id);

            //Para configurar as outras propriedades:

            //OBS: O Builder utiliza o padrão fluent (encadeamento de chamadas)
            //IsRequired = campo de preenchimento obrigatório
            //HasMaxLength = tamanho maximo para a coluna
            builder
                .Property(usuario => usuario.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(usuario => usuario.Password)
                .IsRequired()
                .HasMaxLength(400);

            //HasColummType = define exatamente como a coluna deve ser mapeada no banco de dados (se será varchar ou nvarchar e etc):
            builder
                .Property(usuario => usuario.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            builder
                .Property(usuario => usuario.Surname)
                .IsRequired()
                .HasMaxLength(50);

            //Os pedidos é uma collection e representa um relacionamento entre o usuario e a entidade pedido (que tb é mapeada no dbset).
            //Um usuário pode ter 0 ou n pedidos. Pedido poder ter 1 e somente 1 usuario. Cardinalidade 1 - n
            //HasMany = tem muitos
            builder
                .HasMany(usuario => usuario.Requests)
                .WithOne(requests => requests.User);
        }
    }
}
