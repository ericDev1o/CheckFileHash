/*
<summary>
This class is the property advertisement received by the API, 
persisted in the microDB, 
ready to be served in a json file or on a web page.
</summary>
*/
public class PropertyAd
{
    public int Id {get; set;}
    public required string Description {get; set;}
    [ForeignKey("Localization")]
    public int PropertyAddressRefId {get; set;}
    public required PropertyAddress Localization {get; set;}
    [ForeignKey("Type")]
    public PropertyTypesEnum PropertyTypeRefType {get; set;}
    public required PropertyType Type {get; set;}
    public required PropertyStatus Published {get; set;}
}