namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //I've set prices to int as data doesn't make use of decimal places
        public int RetailPrice { get; set; } 
        public int SellingPrice { get; set; }
    }
}
