using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Raappealstimeper
{
    public long Raappealtimenum { get; set; }

    public DateTime? Effectivestartdate { get; set; }

    public DateTime? Enddate { get; set; }

    public long? Medrecrequestperiod { get; set; }

    public long? Medrecreqdecisionperiod { get; set; }

    public long? Rebuttalletterperiod { get; set; }

    public long? Appealrecoupsuspperiod { get; set; }

    public long? Fiappealperiod { get; set; }

    public long? Fidecisionperiod { get; set; }

    public long? Postfiapprecoupsusper { get; set; }

    public long? Qicappealperiod { get; set; }

    public long? Qicdecisionperiod { get; set; }

    public long? Aljappealperiod { get; set; }

    public long? Aljdecisionperiod { get; set; }

    public long? Acrappealperiod { get; set; }

    public long? Acrdecisionperiod { get; set; }

    public long? Usdcappealperiod { get; set; }
}
