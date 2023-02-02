/*
<summary>
This class is the property address.
</summary>
*/
public class PropertyAddress
{
    public int Id {get; set;}
    public required string Country {get; set;}
    public required int PostalCode {get; set;}
    public required string City {get; set;}
    public required string Street {get; set;}
    public required int Number {get; set;}
}