using Microsoft.EntityFrameworkCore;
using Sketworks.Domain.Entities.Core.Model.Blog;

namespace Sketworks.Domain.Entities.Core.Model.Base.User;

/// <summary>
///     Abstract model for the User model
/// </summary>
[Index(nameof(Email), nameof(FirstName), nameof(LastName))]
public abstract class SketUserProfile : SketPersistedModel, ISketUserModel
{
    public int Attempt { get; set; }
    public DateTime DOB { get; set; }
    public string? Dp { get; set; }
    public string? Email { get; set; }
    public bool EmailVerified { get; set; }
    public string? FirstName { get; set; }
    public string? FullName { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    public double PhoneVerification { get; set; }
    public string? Realm { get; set; }
    public string? Role { get; set; }
    public string? Username { get; set; }
    public string? VerificationToken { get; set; }

    public SocialMediaDto? SocialMedia { get; set; }
    public long SocialMediaId { get; set; }

}