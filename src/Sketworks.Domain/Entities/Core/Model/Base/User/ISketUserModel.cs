namespace Sketworks.Domain.Entities.Core.Model.Base.User;

public interface ISketUserModel : ISketPersistedModel
{
    #region

    int Attempt { get; set; }
    DateTime DOB { get; set; }
    string? Dp { get; set; }
    string? Email { get; set; }
    bool EmailVerified { get; set; }
    string? FirstName { get; set; }
    string? FullName { get; }
    string? LastName { get; set; }
    string? Phone { get; set; }
    double PhoneVerification { get; set; }
    string? Realm { get; set; }
    string? Role { get; set; }
    string? Username { get; set; }
    string? VerificationToken { get; set; }

    #endregion
}