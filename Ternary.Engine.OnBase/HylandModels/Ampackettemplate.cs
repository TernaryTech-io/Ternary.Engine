using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ampackettemplate
{
    public long Amtemplatenum { get; set; }

    public string? Templatename { get; set; }

    public long? Outputtype { get; set; }

    public long? Agenddoctype { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Filetypenum { get; set; }

    public long? Docgennum { get; set; }

    public long? Labelingscheme { get; set; }

    public long? Exclclosedsection { get; set; }

    public long? Exclclosedai { get; set; }

    public long? Flags { get; set; }

    public string? Amfilepath { get; set; }

    public long? Clsditemtypenum { get; set; }

    public long? Packettype { get; set; }
}
