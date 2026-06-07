using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Efmigrationshistory
{
    public string MigrationId { get; set; } = null!;

    public string ProductVersion { get; set; } = null!;
}
