using Sketworks.Domain.Entities.Core.Model.Base.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sketworks.Domain.Entities.Core.Model.Blog;

[Table("Seo")]
public class SeoDto : SketPersistedModel
{
    #region

    public string? Description { get; set; } = string.Empty;
    public string? Tags { get; set; } = string.Empty;
    public string? Title { get; set; } = string.Empty;

    public long PostId { get; set; }
    public PostDto? Post { get; set; }

    #endregion
}
