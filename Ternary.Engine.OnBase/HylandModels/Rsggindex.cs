using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rsggindex
{
    public long Grantorgranteenum { get; set; }

    public long? Ggtype { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Middlename { get; set; }

    public string? Fullgrantname { get; set; }

    public string? Rsaddress1 { get; set; }

    public string? Rsaddress2 { get; set; }

    public string? Rscity { get; set; }

    public string? Rsstate { get; set; }

    public string? Rszipcode { get; set; }

    public string? Rscountry { get; set; }

    public string? Unparsedname { get; set; }

    public string? Nameprefix { get; set; }

    public string? Rsnamesuffix { get; set; }

    public long? Nonpersonentity { get; set; }

    public long? Instrumentnum { get; set; }

    public long? Seqnum { get; set; }
}
