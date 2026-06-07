using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mrappointment
{
    public long Mrappointmentnum { get; set; }

    public string? Mrappointmentid { get; set; }

    public string? Hl7root { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public long? Statuscodenum { get; set; }

    public long? Flags { get; set; }

    public DateTime? Intervaldate { get; set; }

    public DateTime? Servicedurationdate { get; set; }

    public long? Appointmenttype { get; set; }

    public string? Parentapptid { get; set; }

    public long? Apptsetid { get; set; }
}
