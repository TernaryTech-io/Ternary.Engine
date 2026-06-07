using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Migration
{
    public string Migrationname { get; set; } = null!;

    public string? Migrationdescription { get; set; }

    public string? Databaseuser { get; set; }

    public DateTimeOffset? Migrationdate { get; set; }

    public long? Stepcompleted { get; set; }
}
