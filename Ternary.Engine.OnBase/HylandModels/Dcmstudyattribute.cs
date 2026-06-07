using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcmstudyattribute
{
    public long Dcmstudynum { get; set; }

    public string? Dcmstudyinstanceuid { get; set; }

    public string? Dcmstudydate { get; set; }

    public string? Dcmstudytime { get; set; }

    public DateTime? Dcmstudydatetime { get; set; }

    public string? Accessionnumber { get; set; }

    public string? Dcmstudyid { get; set; }
}
