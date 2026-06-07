using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmusernotification
{
    public long Usernotificationnum { get; set; }

    public long? Notificationid { get; set; }

    public long? Objectid { get; set; }

    public long? Usernum { get; set; }

    public long? Opttype { get; set; }

    public long? Usernotiftype { get; set; }

    public string? Sourcedataaddress { get; set; }

    public long? Sourceop { get; set; }

    public string? Sourcevalue { get; set; }

    public string? Prevvalue { get; set; }

    public long? Sourcefilterid { get; set; }

    public long? Prevfilterid { get; set; }

    public long? Flags { get; set; }
}
