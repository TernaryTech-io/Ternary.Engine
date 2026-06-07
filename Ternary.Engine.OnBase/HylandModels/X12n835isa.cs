using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835isa
{
    public long Isa835num { get; set; }

    public long? Batchnum { get; set; }

    public string? Isa01authinfoq { get; set; }

    public string? Isa02authinfo { get; set; }

    public string? Isa03secinfoq { get; set; }

    public string? Isa04secinfo { get; set; }

    public string? Isa05sendidq { get; set; }

    public string? Isa06sendid { get; set; }

    public string? Isa07recvidq { get; set; }

    public string? Isa08recvid { get; set; }

    public DateTime? Isa09date { get; set; }

    public string? Isa10time { get; set; }

    public string? Isa11ctrlstdid { get; set; }

    public string? Isa12ctrlversion { get; set; }

    public string? Isa13ctrlnumber { get; set; }

    public string? Isa14ackrequested { get; set; }

    public string? Isa15usageindicator { get; set; }

    public string? Isa16separator { get; set; }
}
