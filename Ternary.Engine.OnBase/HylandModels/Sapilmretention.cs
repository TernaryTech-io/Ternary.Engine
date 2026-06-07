using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapilmretention
{
    public long Archivelinkdocnum { get; set; }

    public string Sapdocid { get; set; } = null!;

    public string Emptybinresource { get; set; } = null!;

    public DateTime? Startofretention { get; set; }

    public DateTime? Ilmexpirationdate { get; set; }

    public DateTime? Ilmdestructiondate { get; set; }

    public long? Legalholdactive { get; set; }

    public DateTime? Datecreated { get; set; }

    public DateTime? Datemodified { get; set; }

    public string? Altable { get; set; }

    public DateTime? Alstoredate { get; set; }

    public string? Alcrepid { get; set; }

    public string? Alobjtype { get; set; }

    public string? Aldoctype { get; set; }

    public string? Aldoclass { get; set; }

    public string? Alobjid { get; set; }

    public string? Almimetype { get; set; }

    public string? Ilmorigin { get; set; }

    public string? Alsid { get; set; }

    public long? Ilmstatus { get; set; }
}
