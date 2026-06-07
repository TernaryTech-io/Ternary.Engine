using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eismbmsgproject
{
    public long Eismsgprojectnum { get; set; }

    public string? Eismsgprojectname { get; set; }

    public string? Eisgwnamespace { get; set; }

    public long? Archiveafternumsecs { get; set; }

    public long? Deleteafternumsecs { get; set; }

    public long? Purgeafternumsecs { get; set; }

    public long? Wverrorappid { get; set; }

    public long? Wverrorclassid { get; set; }

    public long? Onerrorscriptid { get; set; }

    public long? Errortimeoutsecs { get; set; }

    public long? Errorretrycount { get; set; }

    public long? Denyafternumerrors { get; set; }

    public long? Denytimeoutsecs { get; set; }

    public long? Unsentmsgtosecs { get; set; }

    public long? Inprogressmsgtosecs { get; set; }

    public long? Pendcompletemsgtosecs { get; set; }

    public long? Consumerofflinetosecs { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Flags { get; set; }

    public long? Onerrordoctypeid { get; set; }
}
