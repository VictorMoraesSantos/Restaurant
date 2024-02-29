namespace Restaurant.Models;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public Table Table { get; set; }
}