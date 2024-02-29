namespace Restaurant.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public IList<Item> Itens { get; set; }
}