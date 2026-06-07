using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ldapsetting
{
    public string? Hostname { get; set; }

    public long? Hostport { get; set; }

    public long? Connectflags { get; set; }

    public long? Authflags { get; set; }

    public string? Connectuser { get; set; }

    public string? Connectpassword { get; set; }

    public string? Userclassname { get; set; }

    public string? Usernameattr { get; set; }

    public string? Groupclassname { get; set; }

    public string? Groupnameattr { get; set; }

    public long? Associationflag { get; set; }

    public string? Associationattr { get; set; }

    public string? Basedistname { get; set; }

    public long Ldapsettingsnum { get; set; }

    public long? Flags { get; set; }

    public long? Seqnum { get; set; }

    public string? Realnameattr { get; set; }

    public string? Emailattr { get; set; }

    public string? Ldapsettingsname { get; set; }

    public string? Groupsearchroot { get; set; }

    public string? Assocvalueattr { get; set; }

    public long? Encryptiontype { get; set; }

    public string? Initvectordata { get; set; }
}
