using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Kek
{
    public long Id { get; set; }

    public string Encryptedkey { get; set; } = null!;

    public string Iv { get; set; } = null!;

    public long Algorithm { get; set; }

    public long Kekektype { get; set; }

    public string Kekekid { get; set; } = null!;

    public DateTimeOffset Lastmodification { get; set; }

    public virtual ICollection<Dek> Deks { get; set; } = new List<Dek>();

    public virtual Tenantsetting? Tenantsetting { get; set; }
}
