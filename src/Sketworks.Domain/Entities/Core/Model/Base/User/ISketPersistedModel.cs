namespace Sketworks.Domain.Entities.Core.Model.Base.User;

public interface ISketPersistedModel
{
    #region

    long Id { get; set; }

    SketUserProfile? OwnerId { get; set; }

    #endregion
}