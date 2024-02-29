namespace Restaurant.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public Table Table { get; set; }
    public IList<Order> Orders { get; set; }
    public IList<Role> Roles { get; set; }
}