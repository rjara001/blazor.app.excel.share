using MongoDB.Bson.Serialization.Attributes;

namespace BlazorAppExcel.Models;

public abstract class EntityBase
{
    public EntityBase()
    {
        this.Id = string.Empty;
    }

    public string Id { get; set; }
}