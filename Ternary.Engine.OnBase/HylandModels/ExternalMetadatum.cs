using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class ExternalMetadatum
{
    public string MetadataId { get; set; } = null!;

    public string ProtocolType { get; set; } = null!;

    public string MetadataXml { get; set; } = null!;

    public string? ProviderId { get; set; }

    public DateTimeOffset LastUpdatedTimeStamp { get; set; }

    public string LastUpdatedBy { get; set; } = null!;
}
