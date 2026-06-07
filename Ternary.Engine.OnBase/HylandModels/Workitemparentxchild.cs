using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Workitemparentxchild
{
    public long? Wfchildbatchnum { get; set; }

    public long? Contentnum { get; set; }

    public long? Contentclassnum { get; set; }

    public long? Wfcontenttype { get; set; }

    public long? Usernum { get; set; }

    public long? Lcnum { get; set; }

    public long? Statenum { get; set; }

    public long? Lcnumcomplete { get; set; }

    public long? Statenumcomplete { get; set; }

    public long? Actionnumcomplete { get; set; }

    public long? Completestatus { get; set; }

    public DateTime? Completedatetime { get; set; }

    public long? Flags { get; set; }
}
