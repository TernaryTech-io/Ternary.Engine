using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmworklistusercolumn
{
    public long Rcmwlusercolsnum { get; set; }

    public long? Rcmworklistnum { get; set; }

    public string? Rcmcolumnid { get; set; }

    public string? Rcmcolumnname { get; set; }

    public long? Entitydatatype { get; set; }

    public string? Displayquery { get; set; }

    public long? Flags { get; set; }
}
