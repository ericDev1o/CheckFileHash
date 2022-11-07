namespace StatsTennisAPI;

public class PlayerDetails
{
    [DisallowNull]
    short Rank {get; set;} = 0;
    short Points {get; set;} = 0;
    int Weight {get; set;} = 0;
    short Height {get; set;} = 0;
    short Age {get; set;} = 0;
    List<short> Last {get; set;} = new List<short>();
}