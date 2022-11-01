using Sketworks.Domain.Entities.Core.Model.Base.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sketworks.Domain.Entities.Core.Model.Blog;

[Table("Comments")]
public class CommentDto : SketPersistedModel
{

    #region

    public PostDto? Post { get; set; }

    public string? Content { get; set; }
    public ICollection<SketUserProfile>? DisLikes { get; set; }
    public ICollection<SketUserProfile>? Likes { get; set; }
    public ICollection<CommentDto>? Qoutes { get; set; }
    public ICollection<CommentDto>? Replies { get; set; }
    public SketUserProfile? UserId { get; set; }
    public long PostId { get; set; }

    #endregion
}
