using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmitemlistentry
{
    public long Entryid { get; set; }

    public long? Appid { get; set; }

    public long? Classid { get; set; }

    public DateTime? Entrydate { get; set; }

    public long? Itemid { get; set; }

    public string? Itemname { get; set; }

    public long? Rmitemtype { get; set; }

    public long? Rmlisttype { get; set; }

    public long? Sequenceid { get; set; }

    public long? Usernum { get; set; }
}
