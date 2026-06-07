using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eismbsetting
{
    public long? Archivechecksecs { get; set; }

    public long? Brokerchecksecs { get; set; }

    public long? Maxdequeuemsgsize { get; set; }

    public long? Maxdequeuenummsgs { get; set; }

    public long? Deletefaultsafterndays { get; set; }

    public DateTime? Lastarchivets { get; set; }

    public long? Flags { get; set; }

    public long? Deleteprocchecksecs { get; set; }

    public DateTime? Lastwfmsgcheckts { get; set; }
}
