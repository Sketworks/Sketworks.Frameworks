using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sketworks.Domain.Entities.Core.Model.Base.User;

/// <summary>
///     Abstract model for the Persisted model
/// </summary>
public abstract class SketPersistedModel : ISketPersistedModel
{
    protected SketPersistedModel()
    {
        CreatedOn = DateTime.Now;
    }

    public DateTime CreatedOn { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime ModifiedOn { get; set; }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public SketUserProfile? OwnerId { get; set; }

}