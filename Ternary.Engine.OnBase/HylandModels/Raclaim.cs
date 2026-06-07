using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Raclaim
{
    public long Racclaimnum { get; set; }

    public string? Externracid { get; set; }

    public long? Raptbillingrecnum { get; set; }

    public long? Claimmgntusernum { get; set; }

    public long? Raauditareanum { get; set; }

    public long? Currentclaimlevel { get; set; }

    public long? Currentclaimstatus { get; set; }

    public DateTime? Medrecrequestdate { get; set; }

    public DateTime? Medreccomplydate { get; set; }

    public DateTime? Medreccomplieddate { get; set; }

    public long? Medreccomplystatus { get; set; }

    public DateTime? Determinationenddate { get; set; }

    public long? Determinationstatus { get; set; }

    public DateTime? Determinationdate { get; set; }

    public DateTime? Filastdatetoappeal { get; set; }

    public DateTime? Fidecisionenddate { get; set; }

    public long? Fidecisionstatus { get; set; }

    public DateTime? Fidecisiondate { get; set; }

    public DateTime? Qiclastdatetoappeal { get; set; }

    public DateTime? Qicdecisionenddate { get; set; }

    public long? Qicdecisionstatus { get; set; }

    public DateTime? Qicdecisiondate { get; set; }

    public DateTime? Aljlastdatetoappeal { get; set; }

    public DateTime? Aljdecisionenddate { get; set; }

    public long? Aljdecisionstatus { get; set; }

    public DateTime? Aljdecisiondate { get; set; }

    public DateTime? Acrlastdatetoappeal { get; set; }

    public DateTime? Acrdecisionenddate { get; set; }

    public long? Acrdecisionstatus { get; set; }

    public DateTime? Acrdecisiondate { get; set; }

    public DateTime? Usdclastdatetoappeal { get; set; }

    public long? Usdcdecisionstatus { get; set; }

    public DateTime? Usdcdecisiondate { get; set; }

    public DateTime? Fidatetoappealrecoup { get; set; }

    public DateTime? Fiappealrecoupdatefiled { get; set; }

    public long? Firecoupdecisionstatus { get; set; }

    public DateTime? Firecoupdecisiondate { get; set; }

    public DateTime? Qicdatetoappealrecoup { get; set; }

    public DateTime? Qicappealrecoupdatefile { get; set; }

    public long? Qicrecoupdecisionstatus { get; set; }

    public DateTime? Qicrecoupdecisiondate { get; set; }

    public DateTime? Dateamountlost { get; set; }

    public decimal? Medreccompliancecost { get; set; }

    public long? Whoholdsmoney { get; set; }

    public decimal? Amountdenied { get; set; }

    public decimal? Medicareclaimamount { get; set; }

    public decimal? Amountreturned { get; set; }

    public decimal? Addamntawarded { get; set; }

    public decimal? Addamntreceived { get; set; }

    public long? Flags { get; set; }

    public DateTime? Fidateappealed { get; set; }

    public DateTime? Qicdateappealed { get; set; }

    public DateTime? Aljdateappealed { get; set; }

    public DateTime? Acrdateappealed { get; set; }

    public DateTime? Usdcdateappealed { get; set; }

    public long? Actionable { get; set; }

    public DateTime? Lastdatetorespond { get; set; }

    public DateTime? Dateresponded { get; set; }

    public DateTime? Decisiondate { get; set; }

    public DateTime? Decisionenddate { get; set; }

    public DateTime? Dateinitiated { get; set; }

    public long? Raclaimtype { get; set; }

    public long? Medrecpagecnt { get; set; }

    public long? Seqnum { get; set; }

    public string? Outpatientid { get; set; }

    public long? Raaudittypenum { get; set; }

    public long? Raauditornum { get; set; }
}
