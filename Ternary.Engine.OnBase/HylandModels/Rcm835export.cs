using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcm835export
{
    public long Rcm835exportnum { get; set; }

    public string? Rcm835exportname { get; set; }

    public long? Rcmqueuenum { get; set; }

    public long? Destqueuenum { get; set; }

    public long? Rcmhostsystemnum { get; set; }

    public string? Schemalocation { get; set; }

    public string? Outputlocation { get; set; }

    public string? Archivelocation { get; set; }

    public long? Flags { get; set; }

    public long? Isadate { get; set; }

    public long? Gsdate { get; set; }

    public long? Bprdate { get; set; }

    public string? Senderid { get; set; }

    public string? Expreceiverid { get; set; }

    public string? Payerplanid { get; set; }

    public string? Payeeplanid { get; set; }

    public string? Clientname { get; set; }

    public string? Clientaddress { get; set; }

    public string? Clientcity { get; set; }

    public string? Clientstate { get; set; }

    public string? Clientzip { get; set; }

    public string? Filenameformat { get; set; }

    public string? Fiscalyearend { get; set; }

    public string? Refzzseparator { get; set; }

    public long? Rcmsefconfignum { get; set; }

    public long? Maxbatchcount { get; set; }

    public string? Segterminator { get; set; }

    public string? Elseparator { get; set; }

    public string? Subelseparator { get; set; }

    public string? Postproclocation { get; set; }

    public long? Postprocreturn { get; set; }

    public string? Postprocparams { get; set; }

    public long? Archivedoctypenum { get; set; }
}
