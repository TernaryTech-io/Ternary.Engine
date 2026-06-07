using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class BaselineMappingUploadedFile
{
    public string JobId { get; set; } = null!;

    public string UploadedFile { get; set; } = null!;

    public DateTimeOffset FileUploadTimeStamp { get; set; }
}
