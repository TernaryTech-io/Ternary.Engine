using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class S3multipartupload
{
    public long Id { get; set; }

    public long Multipartuploadid { get; set; }

    public string S3uploadid { get; set; } = null!;

    public virtual Multipartupload Multipartupload { get; set; } = null!;
}
