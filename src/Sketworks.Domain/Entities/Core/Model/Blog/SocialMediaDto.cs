using Sketworks.Domain.Entities.Core.Model.Base.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sketworks.Domain.Entities.Core.Model.Blog;

[Table("SocialMedia")]
public class SocialMediaDto : SketPersistedModel
{
    #region

    public string? Facebook { get; set; }
    public string? Github { get; set; }
    public string? LinkedIn { get; set; }
    public string? Twitter { get; set; }

    #endregion
}
