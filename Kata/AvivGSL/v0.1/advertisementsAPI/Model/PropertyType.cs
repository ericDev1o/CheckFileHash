/*
This class is the property type. As per kata it is an "appartement", "maison" ou "parking"
i.e. "flat", "house" or "parking"
*/
public class PropertyType
{
    [Key]
    public PropertyTypesEnum Type {get; set;}
}