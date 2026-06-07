using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Exportformat
{
    public long Formatnum { get; set; }

    public string? Formatname { get; set; }

    public long? Foldernum { get; set; }

    public long? Formatflags { get; set; }

    public string? Destpath { get; set; }

    public string? Exportpath { get; set; }

    public string? Exportdbpath { get; set; }

    public string? Readmepath { get; set; }

    public string? Username { get; set; }

    public string? Userpassword { get; set; }

    public long? Mediakbytes { get; set; }

    public long? Documentkbytes { get; set; }

    public string? Cdvolumename { get; set; }

    public string? Obcdvendorname { get; set; }

    public string? Obcdvendorstreet { get; set; }

    public string? Obcdvendorcityzip { get; set; }

    public long? Labelnum { get; set; }

    public string? Cdpassword { get; set; }

    public long? Isroi { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
