using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Storagesystem
{
    public long Id { get; set; }

    public long Storagetype { get; set; }

    public virtual ICollection<Midtermclaimedtempfile> Midtermclaimedtempfiles { get; set; } = new List<Midtermclaimedtempfile>();

    public virtual ICollection<Midtermunclaimedtempfile> Midtermunclaimedtempfiles { get; set; } = new List<Midtermunclaimedtempfile>();

    public virtual ICollection<Multipartupload> Multipartuploads { get; set; } = new List<Multipartupload>();

    public virtual ICollection<Namedfile> Namedfiles { get; set; } = new List<Namedfile>();

    public virtual ICollection<Namedtempfilesinprogress> Namedtempfilesinprogresses { get; set; } = new List<Namedtempfilesinprogress>();

    public virtual S3storagesystem? S3storagesystem { get; set; }

    public virtual ICollection<Shorttermtempfile> Shorttermtempfiles { get; set; } = new List<Shorttermtempfile>();

    public virtual Tenantsetting? TenantsettingCachestoragesystem { get; set; }

    public virtual Tenantsetting? TenantsettingMidtermstoragesystem { get; set; }

    public virtual Tenantsetting? TenantsettingStoragesystem { get; set; }

    public virtual Uncstoragesystem? Uncstoragesystem { get; set; }
}
