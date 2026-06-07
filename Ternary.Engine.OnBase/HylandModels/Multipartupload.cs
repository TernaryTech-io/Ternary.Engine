using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Multipartupload
{
    public long Id { get; set; }

    public string Multipartuploadid { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public DateTimeOffset Expiration { get; set; }

    public long Partsize { get; set; }

    public int Totalparts { get; set; }

    public long Totalsize { get; set; }

    public long Storagesystemid { get; set; }

    public long Namespaceid { get; set; }

    public int Storageclass { get; set; }

    public virtual ICollection<Multipartuploadpart> Multipartuploadparts { get; set; } = new List<Multipartuploadpart>();

    public virtual ICollection<Namedtempfilesinprogress> Namedtempfilesinprogresses { get; set; } = new List<Namedtempfilesinprogress>();

    public virtual Namespace Namespace { get; set; } = null!;

    public virtual S3multipartupload? S3multipartupload { get; set; }

    public virtual Storagesystem Storagesystem { get; set; } = null!;
}
