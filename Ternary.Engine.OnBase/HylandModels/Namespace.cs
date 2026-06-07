using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Namespace
{
    public long Id { get; set; }

    public string Namespaceprimary { get; set; } = null!;

    public string Namespacesecondary { get; set; } = null!;

    public virtual ICollection<Midtermclaimedtempfile> Midtermclaimedtempfiles { get; set; } = new List<Midtermclaimedtempfile>();

    public virtual ICollection<Midtermunclaimedtempfile> Midtermunclaimedtempfiles { get; set; } = new List<Midtermunclaimedtempfile>();

    public virtual ICollection<Multipartupload> Multipartuploads { get; set; } = new List<Multipartupload>();

    public virtual ICollection<Namedfilegroup> Namedfilegroups { get; set; } = new List<Namedfilegroup>();

    public virtual ICollection<Shorttermtempfile> Shorttermtempfiles { get; set; } = new List<Shorttermtempfile>();
}
