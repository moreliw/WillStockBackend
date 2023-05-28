namespace WillStockBackend.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int IdCategoria { get; set; }
    }
}
