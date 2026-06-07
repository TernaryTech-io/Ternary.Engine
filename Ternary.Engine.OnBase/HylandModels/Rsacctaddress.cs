using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rsacctaddress
{
    public long Accountaddrnum { get; set; }

    public long? Addresstype { get; set; }

    public string? Careofname { get; set; }

    public string? Rsaddress1 { get; set; }

    public string? Rsaddress2 { get; set; }

    public string? Rscity { get; set; }

    public string? Rsstate { get; set; }

    public string? Rszipcode { get; set; }

    public string? Rscountry { get; set; }

    public string? Rscontactname { get; set; }

    public long? Contacttype1 { get; set; }

    public string? Contactvalue1 { get; set; }

    public long? Contacttype2 { get; set; }

    public string? Contactvalue2 { get; set; }

    public long? Contacttype3 { get; set; }

    public string? Contactvalue3 { get; set; }

    public long? Contacttype4 { get; set; }

    public string? Contactvalue4 { get; set; }

    public long? Rsaccountnum { get; set; }
}
