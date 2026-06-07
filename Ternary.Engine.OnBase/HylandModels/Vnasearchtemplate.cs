using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vnasearchtemplate
{
    public long Vnasearchtmplnum { get; set; }

    public long? Searchtype { get; set; }

    public long? Searchvnapatient { get; set; }

    public long? Searchsourcetype { get; set; }

    public long? Flags { get; set; }

    public long? Maxresultcount { get; set; }
}
