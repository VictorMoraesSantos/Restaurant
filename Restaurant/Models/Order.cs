namespace Restaurant.Models;

public class Order
{
    public enum Status
    {
        Pending,
        Preparing,
        Ready
    }

    public int Id { get; set; }
    public int OrderNumber { get; set; }
    public Status OrderStatus { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public User User { get; set; }
}