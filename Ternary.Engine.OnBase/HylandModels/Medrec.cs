using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Medrec
{
    public long Mrnum { get; set; }

    public string? Medrecnumber { get; set; }

    public long? Facilitynum { get; set; }

    public string? Mpinumber { get; set; }

    public string? Ptfirstname { get; set; }

    public string? Ptlastname { get; set; }

    public DateTime? Ptdob { get; set; }

    public string? Ptssn { get; set; }

    public long? Ptsex { get; set; }

    public string? Hl7source { get; set; }

    public long? Mpinum { get; set; }

    public string? Ptmiddlename { get; set; }

    public string? Birthplace { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? City { get; set; }

    public string? Stateabbr { get; set; }

    public string? Zipcode { get; set; }

    public string? Mrcontactname { get; set; }

    public string? Homephone { get; set; }

    public string? Workphone { get; set; }

    public string? Hl7root { get; set; }

    public string? Cellphone { get; set; }
}
