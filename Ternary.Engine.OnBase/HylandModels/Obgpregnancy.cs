using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Obgpregnancy
{
    public long Pregnancynum { get; set; }

    public long? Mpinum { get; set; }

    public DateTime? Firstexamdate { get; set; }

    public DateTime? Lastexamdate { get; set; }

    public DateTime? Pregnancystartdate { get; set; }

    public DateTime? Pregnancyenddate { get; set; }

    public DateTime? Estdeliverydate { get; set; }

    public long? Estgestage { get; set; }

    public long? Flags { get; set; }
}
