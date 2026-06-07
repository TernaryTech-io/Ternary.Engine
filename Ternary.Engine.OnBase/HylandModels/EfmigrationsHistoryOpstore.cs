using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class EfmigrationsHistoryOpstore
{
    public string MigrationId { get; set; } = null!;

    public string ProductVersion { get; set; } = null!;
}
