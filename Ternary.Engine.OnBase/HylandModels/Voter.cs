using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Voter
{
    public long Voternum { get; set; }

    public string? Voterssn { get; set; }

    public DateTime? Voterdob { get; set; }

    public string? Voterphoneprimary { get; set; }

    public string? Voterregnum { get; set; }

    public string? Firstname { get; set; }

    public string? Middlename { get; set; }

    public string? Lastname { get; set; }

    public string? Priorlastname { get; set; }

    public string? Namesuffix { get; set; }

    public string? Sosid { get; set; }

    public string? Bmvid { get; set; }

    public string? Districtcode { get; set; }

    public string? Wardcode { get; set; }

    public string? Precinctcode { get; set; }

    public DateTime? Lastchangedate { get; set; }

    public long? Voterflags { get; set; }

    public long? Voterstatus { get; set; }

    public long? Challengedvoter { get; set; }

    public long? Idrequired { get; set; }

    public long? Tooyoungtovote { get; set; }

    public long? Military { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Dateregistered { get; set; }

    public DateTime? Lastactivitydate { get; set; }

    public DateTime? Confirmnoticedate { get; set; }

    public string? Confirmationcode { get; set; }

    public string? Cityofbirth { get; set; }

    public string? Stateofbirth { get; set; }

    public string? Countryofbirth { get; set; }

    public long? Primaryaddrnum { get; set; }

    public long? Secondaddrnum { get; set; }

    public long? Absenteeaddrnum { get; set; }

    public long? Partynum { get; set; }

    public long? Nursinghomenum { get; set; }

    public long? Polllocationnum { get; set; }
}
