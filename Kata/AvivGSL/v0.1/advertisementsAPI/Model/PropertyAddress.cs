/*
<summary>
This class is the property address.
</summary>
*/
class PropertyAddress
{
    public int Id {get; internal set;}
    public required string Country {get; internal set;}
    public required int PostalCode {get; internal set;}
    public required string City {get; internal set;}
    public required string Street {get; internal set;}
    public required int Number {get; internal set;}
}