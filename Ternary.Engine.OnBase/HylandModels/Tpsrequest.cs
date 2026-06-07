using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpsrequest
{
    public long Tpsrequestnum { get; set; }

    public string? Tpsuse { get; set; }

    public long? Tpsscriptnum { get; set; }

    public long? Status { get; set; }

    public long? Processingtpsregnum { get; set; }

    public long? Lockstate { get; set; }

    public string? Lockvalue { get; set; }

    public DateTime? Datecreated { get; set; }

    public long? Createduser { get; set; }

    public DateTime? Datemodified { get; set; }

    public long? Lastmodifieduser { get; set; }

    public long? Donotpurge { get; set; }

    public long? Tpsdeleted { get; set; }
}
