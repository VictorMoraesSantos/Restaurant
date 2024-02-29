namespace Restaurant.Models;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public bool Available { get; set; }
    public Category Category { get; set; }
}