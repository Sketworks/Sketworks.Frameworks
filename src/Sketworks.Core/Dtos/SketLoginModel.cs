using System.ComponentModel.DataAnnotations;

namespace Sketworks.Domain.Entities.Core.Model.Base;

public class SketLoginModel
{
    public string? Email { get; set; }

    [Required] public string? Password { get; set; }
    public string? Phone { get; set; }
    public string? Username { get; set; }

}