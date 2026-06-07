using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roirequestloc
{
    public long Roilocationnum { get; set; }

    public string? Roilocationname { get; set; }

    public string? Requestorname { get; set; }

    public string? Requestorrelation { get; set; }

    public string? Requestoremail { get; set; }

    public string? Billtoaddress1 { get; set; }

    public string? Billtoaddress2 { get; set; }

    public string? Billtoaddress3 { get; set; }

    public string? Shiptoaddress1 { get; set; }

    public string? Shiptoaddress2 { get; set; }

    public string? Shiptoaddress3 { get; set; }

    public long? Flags { get; set; }

    public string? Roicompanyname { get; set; }

    public string? Phonenumber { get; set; }

    public string? Faxnum { get; set; }

    public long? Status { get; set; }
}
