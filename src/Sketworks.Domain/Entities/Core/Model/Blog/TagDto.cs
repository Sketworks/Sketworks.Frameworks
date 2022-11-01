using Sketworks.Domain.Entities.Core.Model.Base.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sketworks.Domain.Entities.Core.Model.Blog;

[Table("Tag")]
public class TagDto : SketPersistedModel
{
    public string? Name { get; set; }
}
