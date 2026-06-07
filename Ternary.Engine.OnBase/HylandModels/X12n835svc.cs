using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class X12n835svc
{
    public long Svc835num { get; set; }

    public long? Batchnum { get; set; }

    public long? St835num { get; set; }

    public long? Clp835num { get; set; }

    public string? Loopid { get; set; }

    public long? Segposition { get; set; }

    public long? Setposition { get; set; }

    public string? Svc011procq { get; set; }

    public string? Svc012proccode { get; set; }

    public string? Svc013procmod { get; set; }

    public string? Svc014procmod { get; set; }

    public string? Svc015procmod { get; set; }

    public string? Svc016procmod { get; set; }

    public string? Svc017description { get; set; }

    public decimal? Svc02chargeamt { get; set; }

    public decimal? Svc03paidamt { get; set; }

    public string? Svc04revenuecode { get; set; }

    public string? Svc05unitsofservice { get; set; }

    public string? Svc061procq { get; set; }

    public string? Svc062proccode { get; set; }

    public string? Svc063procmod { get; set; }

    public string? Svc064procmod { get; set; }

    public string? Svc065procmod { get; set; }

    public string? Svc066procmod { get; set; }

    public string? Svc067description { get; set; }

    public string? Svc07unitsofservice { get; set; }

    public long? Svc018serviceid { get; set; }

    public string? Svc068serviceid { get; set; }

    public string? Svc018serviceidr { get; set; }
}
