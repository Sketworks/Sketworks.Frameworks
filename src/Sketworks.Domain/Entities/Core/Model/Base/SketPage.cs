using Sketworks.Domain.Entities.Core.Model.Base.User;
using Sketworks.Domain.Entities.Core.Model.Blog;

namespace Sketworks.Domain.Entities.Core.Model.Base;

public class SketPage : SketPersistedModel
{
    public string? Content { get; set; }
    public string? CoverPhoto { get; set; }
    public SeoDto? Seo { get; set; }
    public virtual string? Slug { get; set; }
    public virtual string? Title { get; set; }
    public long Views { get; set; }

    public ICollection<PostCategoryDto>? Categories { get; set; }
    public ICollection<CommentDto>? Comments { get; set; }
    public ICollection<TagDto>? Tags { get; set; }


}
