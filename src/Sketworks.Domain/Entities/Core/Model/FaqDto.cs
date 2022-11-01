using Sketworks.Domain.Entities.Core.Model.Base.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sketworks.Domain.Entities.Core.Model;

[Table("Faq")]
public class FaqDto : SketPersistedModel
{
    #region

    public string? Answer { get; set; }
    public string? Question { get; set; }

    #endregion
}
