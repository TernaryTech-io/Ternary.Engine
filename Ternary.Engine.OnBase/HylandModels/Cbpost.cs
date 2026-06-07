using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cbpost
{
    public long Postid { get; set; }

    public long? Postthreadid { get; set; }

    public long? Parentpostid { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Postdate { get; set; }

    public string? Postsubject { get; set; }

    public string? Posttext { get; set; }

    public long? Usessecurity { get; set; }

    public long? Lft { get; set; }

    public long? Rgt { get; set; }
}
