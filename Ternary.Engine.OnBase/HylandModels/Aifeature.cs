using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aifeature
{
    public long Aifeaturenum { get; set; }

    public long? Featuretype { get; set; }

    public string? Featurename { get; set; }

    public long? Featureweight { get; set; }

    public long? Featurelevel { get; set; }

    public long? Featurepyramid { get; set; }

    public long? Featuresection { get; set; }

    public string? Featureword { get; set; }

    public long? Keytypenum { get; set; }

    public string? Discretevalues { get; set; }
}
