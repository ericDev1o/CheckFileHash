/*
This class is the property advertisement status.
Initially a boolean bit default 0 it is a string either "en attente de validation" ou "publiée" 
i.e. "pending" or "published" as per kata.
*/
public class PropertyStatus
{
    [Key]
    public PropertyStatusesEnum Status {get; set;}
}