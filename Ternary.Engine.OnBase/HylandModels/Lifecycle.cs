using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lifecycle
{
    public long Lcnum { get; set; }

    public string? Lifecyclename { get; set; }

    public string? Lifecycledesc { get; set; }

    public long? Initialstatenum { get; set; }

    public string? Helptext { get; set; }

    public long? Bitmapnum { get; set; }

    public long? Iconnum { get; set; }

    public long? Foldertypenum { get; set; }

    public long? Flags { get; set; }

    public string? Encryptedpassword { get; set; }

    public long? Wfcontenttype { get; set; }

    public long? Contentclassnum { get; set; }

    public long? Maxitemsowned { get; set; }

    public long? Encryptiontype { get; set; }

    public long? Obuniqueid { get; set; }

    public long? Configversion { get; set; }
}
