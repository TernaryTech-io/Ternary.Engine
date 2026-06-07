using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Olisorder
{
    public long Olisordernum { get; set; }

    public long? Olispatientnum { get; set; }

    public long? Olissessionnum { get; set; }

    public string? Olisparentordernum { get; set; }

    public DateTime? Olisorderdate { get; set; }

    public string? Orderfacilityname { get; set; }

    public string? Obsrequestnumber { get; set; }

    public string? Fillerordernumber { get; set; }

    public string? Universalsvceid { get; set; }

    public string? Universalsvctext { get; set; }

    public DateTime? Observationdate { get; set; }

    public DateTime? Observationenddate { get; set; }

    public string? Collectionvolume { get; set; }

    public string? Specimensource { get; set; }

    public string? Orderpractlastname { get; set; }

    public DateTime? Resultsreportdate { get; set; }

    public string? Testrequeststatus { get; set; }

    public string? Quantitytiming { get; set; }

    public string? Pointofcaretestid { get; set; }

    public string? Samplecontainers { get; set; }

    public string? Collectorscomment { get; set; }

    public string? Testreqplacername { get; set; }

    public string? Specimencollector { get; set; }

    public string? Reportlabname { get; set; }

    public string? Performlabname { get; set; }

    public string? Destlabname { get; set; }
}
