using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scheduleitem
{
    public long Schedulenum { get; set; }

    public long? Scheduletype { get; set; }

    public long? Initialperiod { get; set; }

    public long? Repeatperiod { get; set; }

    public DateTime? Executeat { get; set; }

    public long? Daysofweek { get; set; }

    public long? Monthsofyear { get; set; }

    public long? Daysofmonth1 { get; set; }

    public long? Daysofmonth2 { get; set; }

    public long? Sundaysofmonth { get; set; }

    public long? Mondaysofmonth { get; set; }

    public long? Tuesdaysofmonth { get; set; }

    public long? Wednesdaysofmonth { get; set; }

    public long? Thursdaysofmonth { get; set; }

    public long? Fridaysofmonth { get; set; }

    public long? Saturdaysofmonth { get; set; }

    public long? Jandays1 { get; set; }

    public long? Jandays2 { get; set; }

    public long? Febdays1 { get; set; }

    public long? Febdays2 { get; set; }

    public long? Mardays1 { get; set; }

    public long? Mardays2 { get; set; }

    public long? Aprdays1 { get; set; }

    public long? Aprdays2 { get; set; }

    public long? Maydays1 { get; set; }

    public long? Maydays2 { get; set; }

    public long? Jundays1 { get; set; }

    public long? Jundays2 { get; set; }

    public long? Juldays1 { get; set; }

    public long? Juldays2 { get; set; }

    public long? Augdays1 { get; set; }

    public long? Augdays2 { get; set; }

    public long? Sepdays1 { get; set; }

    public long? Sepdays2 { get; set; }

    public long? Octdays1 { get; set; }

    public long? Octdays2 { get; set; }

    public long? Novdays1 { get; set; }

    public long? Novdays2 { get; set; }

    public long? Decdays1 { get; set; }

    public long? Decdays2 { get; set; }

    public long? Flags { get; set; }
}
