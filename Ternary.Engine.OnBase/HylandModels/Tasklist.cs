using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tasklist
{
    public long Tasklistnum { get; set; }

    public string? Tasklistname { get; set; }

    public long? Flags { get; set; }

    public long? Scope { get; set; }

    public long? Iconnum { get; set; }

    public long? Bitmapnum { get; set; }

    public string? Helptext { get; set; }

    public long? Wfcontenttype { get; set; }

    public long? Filterrulenum { get; set; }

    public long? Configversion { get; set; }

    public string? Taskdisplayname { get; set; }

    public long? Subscope { get; set; }

    public long? Flags2 { get; set; }

    public long? Onfoundtasklistnum { get; set; }

    public long? Onnotfoundtasklistnum { get; set; }
}
