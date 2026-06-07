using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eismbmsgtype
{
    public long Eismsgtypenum { get; set; }

    public long? Eismsgprojectnum { get; set; }

    public long? Eisgwoperationnum { get; set; }

    public string? Messagetypecode { get; set; }

    public long? Formattype { get; set; }

    public string? Xsltname { get; set; }

    public long? Xsltblobnum { get; set; }

    public string? Xsdname { get; set; }

    public long? Xsdblobnum { get; set; }

    public string? Replyxsdname { get; set; }

    public long? Replyxsdblobnum { get; set; }

    public long? Onpublishscriptid { get; set; }

    public long? Onresponsescriptid { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Flags { get; set; }

    public string? Replyxsltname { get; set; }

    public long? Replyxsltblobnum { get; set; }

    public string? Rawreplyxsdname { get; set; }

    public long? Rawreplyxsdblobnum { get; set; }

    public long? Onpblshpostxfrmscriptid { get; set; }

    public long? Onrspnspostxfrmscriptid { get; set; }

    public long? Rspnsesmsgitemtypenum { get; set; }
}
