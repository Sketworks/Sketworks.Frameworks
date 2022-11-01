using Sketworks.Domain.Entities.Core.Model.Base.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sketworks.Domain.Entities.Core.Model.Blog;

[Table("PostCategory")]
public class PostCategoryDto : SketPersistedModel
{
    #region

    public string? Slug { get; set; }
    public string? Title { get; set; }

    #endregion
}
