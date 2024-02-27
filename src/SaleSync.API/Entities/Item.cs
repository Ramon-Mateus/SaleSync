using SaleSync.API.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaleSync.API.Entities
{
    [Table("Items")] // Quando não se declara o DbSet no DbContexto e não vai precisar fazer alterações dessa tabela no banco de dados, pode ser feito assim para o entity entender que a tabela que essa classe está ligada no banco de dados é a passada por parâmetro
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Brand { get; set; } = String.Empty;
        public Condition Condition { get; set; }
        public decimal BasePrice { get; set; }
        public int AuctionId { get; set; }
    }
}
