namespace Restaurant.Models;

public class Table
{
    public enum Status
    {
        Disponivel,
        Indisponivel
    }

    public int Id { get; set; }
    public int TableNumber { get; set; }
    public int Capacity { get; set; }
    public Status TableStatus { get; set; }
}