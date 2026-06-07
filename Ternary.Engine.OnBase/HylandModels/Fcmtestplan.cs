using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmtestplan
{
    public long Fctestplannum { get; set; }

    public long? Fcjournalentrynum { get; set; }

    public long? Fcgeneratemonthmap { get; set; }

    public long? Fcbackdatecount { get; set; }

    public long? Testerusernum { get; set; }

    public long? Reviewerusernum { get; set; }

    public long? Reviewer2usernum { get; set; }

    public long? Flags { get; set; }

    public long? Fctestplantextid { get; set; }

    public long? Fctestplanstatus { get; set; }

    public long? Fctimestogenerate { get; set; }
}
