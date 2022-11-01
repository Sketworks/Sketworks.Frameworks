using Sketworks.Domain.Entities.Core.Model.Base.User;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sketworks.Domain.Entities.Core.Model.File;

[Table("Media")]
public class SketFileInfo : SketPersistedModel
{

    #region

    public string? FileExtension { get; set; }

    [Required] public string? FileName { get; set; }

    [Required] public string? FilePath { get; set; }

    public ulong? FileSize { get; set; }

    [Required] public string? MimeContentType { get; set; }

    public List<string?> Tags { get; set; } = new();

    public string? ThumbnailPath { get; set; }

    [Required] public string? DocumentType { get; set; }

    #endregion
}
