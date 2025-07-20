namespace MyApp.Models
{
    public class ItemClient
    {
        // This Helper Model  will connect to both Itemand Client

        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;
        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;


    }
}
