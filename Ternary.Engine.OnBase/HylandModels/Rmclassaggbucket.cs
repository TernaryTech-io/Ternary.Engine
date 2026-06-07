using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmclassaggbucket
{
    public long Classaggbucketid { get; set; }

    public long? Classaggregateid { get; set; }

    public long? Sequenceid { get; set; }

    public string? Testvalue { get; set; }

    public string? Targetaddress { get; set; }

    public long? Testoperator { get; set; }
}
