using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcodbcinput
{
    public long Dcodbcinputnum { get; set; }

    public string? Dcodbcinputname { get; set; }

    public long? Dctemplatenum { get; set; }

    public string? Dcsqltext { get; set; }

    public string? Odbcdatasource { get; set; }

    public string? Odbcusername { get; set; }

    public string? Odbcpassword { get; set; }

    public long? Encryptiontype { get; set; }

    public string? Initvectordata { get; set; }
}
