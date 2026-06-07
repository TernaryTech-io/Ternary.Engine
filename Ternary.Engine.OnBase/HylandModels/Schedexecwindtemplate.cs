using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Schedexecwindtemplate
{
    public long Execwindtemplnum { get; set; }

    public string? Execwindtemplname { get; set; }

    public string? Execwindtempldesc { get; set; }

    public long? Flags { get; set; }

    public long? Createduser { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Updateduser { get; set; }

    public DateTime? Updateddate { get; set; }
}
