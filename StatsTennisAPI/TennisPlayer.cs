namespace StatsTennisAPI;
public class TennisPlayer
{
    [DisallowNull]
    public short Id { get; set; } = 0;
    public string FirstName { get; set; } = "";
    public string LastName {get; set;} = "";
    public string ShortName {get; set;} = "";
    public char Sex {get; set;}
    public PlayerCountry Country {get; set;} = new PlayerCountry();
    //public Image Picture {get; set;}
    public string? Summary { get; set; }
}
