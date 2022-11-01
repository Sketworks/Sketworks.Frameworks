using Sketworks.Domain.Entities.Core.Model.Base.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sketworks.Domain.Entities.Core.Model.Base;

/// <summary>
///     Abstract model for the Role model
/// </summary>
[Table("Roles")]
public class SketRoleModel :
    SketPersistedModel
{

    #region

    public string? Description { get; set; }

    public string? Name { get; set; }

    #endregion
}
