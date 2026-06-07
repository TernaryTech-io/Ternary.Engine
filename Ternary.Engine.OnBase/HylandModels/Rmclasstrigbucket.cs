using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmclasstrigbucket
{
    public long Classtrigbucketid { get; set; }

    public long? Clastriggerid { get; set; }

    public long? Sequenceid { get; set; }

    public string? Testvalue { get; set; }

    public string? Targetaddress { get; set; }

    public long? Testoperator { get; set; }

    public long? Flags { get; set; }
}
