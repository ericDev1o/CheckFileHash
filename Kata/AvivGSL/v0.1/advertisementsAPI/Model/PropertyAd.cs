/*
<summary>
This class is the property advertisement received by the API, 
persisted in the microDB, 
ready to be served in a json file or on a web page.
</summary>
*/
class PropertyAd
{
    public int Id {get; internal set;}
    public required string Description {get; internal set;}
    [ForeignKey("Localization")]
    public int PropertyAddressRefId {get; internal set;}
    public required PropertyAddress Localization {get; internal set;}
    [ForeignKey("Type")]
    public int PropertyTypeRefId {get; internal set;}
    public required PropertyType Type {get; internal set;}
    public required string Published {get; internal set;}
}