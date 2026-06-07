using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amitemhistory
{
    public long Amhistorynum { get; set; }

    public long? Ettransactionnum { get; set; }

    public long? Entitytypenum { get; set; }

    public long? Etitemid { get; set; }

    public DateTime? Eteventdate { get; set; }

    public string? Etstartvalue { get; set; }

    public string? Etendvalue { get; set; }

    public string? Username { get; set; }

    public long? Etstarttextnum { get; set; }

    public long? Etendtextnum { get; set; }

    public string? Ettypename { get; set; }

    public string? Etfieldname { get; set; }

    public long? Etdatatype { get; set; }
}
