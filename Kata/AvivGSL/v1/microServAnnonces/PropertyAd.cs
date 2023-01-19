class PropertyAd
{
    public int Id {get; set;}
    public required string Description {get; set;}
    public required PropertyAddress Localization {get; set;}
    public required PropertyType Type {get; set;}
    public bool Published {get; set;}
}
