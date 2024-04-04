namespace Hotel_5;

public partial class Room
{
    public int Id { get; set; }

    public string Room1 { get; set; } = null!;

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? MiddleName { get; set; }

    public string Status { get; set; } = null!;

    public string? EnterDate { get; set; }

    public string? DepartureDate { get; set; }

    public string? BirthDay { get; set; }

    public int? DaysAtTheHotel { get; set; }

    public int? Animal { get; set; }

    public byte[]? Photo { get; set; }
}
