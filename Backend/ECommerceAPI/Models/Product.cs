public class Product
{
    public int Id {get; set;}
    public string Name {get; set;}
    public string Description{get; set;}
    public decimal Price {get;set;}
    public string Image {get;set;}=string.Empty;
    public string Category {get;set;}=string.Empty;
    public int Stock {get;set;}
    public double Rating {get;set;}
}