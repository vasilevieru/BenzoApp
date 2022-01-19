namespace BenzoApp.Models;

public abstract class BaseEntity
{
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.Now;

    public DateTime DeletedOn { get; protected set; }
}
