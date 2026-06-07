using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmjournalentry
{
    public long Fcjournalentrynum { get; set; }

    public long? Fcjetemplatenum { get; set; }

    public string? Fcactivityname { get; set; }

    public long? Fcsectionnum { get; set; }

    public long? Fccompanynum { get; set; }

    public long? Fcstagenum { get; set; }

    public long? Fcentrytypeperiod { get; set; }

    public long? Fcclosemonth { get; set; }

    public long? Fccloseyear { get; set; }

    public long? Fcdescriptionid { get; set; }

    public long? Fcnonstandard { get; set; }

    public long? Fcexception { get; set; }

    public long? Fcexceptreasonnotenum { get; set; }

    public long? Fcjournalentrystatus { get; set; }

    public long? Fcreverseentry { get; set; }

    public DateTime? Fcreversaldate { get; set; }

    public long? Fcexplanationnotenum { get; set; }

    public long? Fcmanagernotenum { get; set; }

    public long? Fcaccountingnotenum { get; set; }

    public DateTime? Completeddate { get; set; }

    public DateTime? Preparebydate { get; set; }

    public DateTime? Prepareddate { get; set; }

    public DateTime? Revieweddate { get; set; }

    public long? Preparerusernum { get; set; }

    public long? Reviewerusernum { get; set; }

    public long? Reviewer2usernum { get; set; }

    public long? Fcclosemonthmap { get; set; }

    public long? Fcreversedentry { get; set; }

    public long? Fcexceptionflaggedby { get; set; }

    public long? Flags { get; set; }

    public string? Fcpostingreference { get; set; }

    public long? Fcsecureentry { get; set; }

    public long? Reviewer3usernum { get; set; }

    public long? Reviewer4usernum { get; set; }

    public long? Reviewer5usernum { get; set; }

    public DateTime? Fcspecificduedate { get; set; }

    public long? Fcclassification { get; set; }

    public string? Fcjetype { get; set; }

    public DateTime? Fcpostingdate { get; set; }

    public long? Posterusernum { get; set; }

    public long? Returntoreviewer { get; set; }

    public long? Numaddreviewsreq { get; set; }

    public long? Numaddreviewsdone { get; set; }

    public long? Fccontroltype { get; set; }

    public long? Fcparentnum { get; set; }

    public long? Parententitynum { get; set; }

    public long? Fcentitynum { get; set; }

    public long? Fccloseeventnum { get; set; }

    public long? Preparedbyusernum { get; set; }

    public long? Reviewedbyusernum { get; set; }

    public long? Reviewedby2usernum { get; set; }

    public long? Fcpriority { get; set; }

    public long? Fcrevprocnum { get; set; }

    public long? Fcnumattachments { get; set; }

    public long? Fcreturnnotenum { get; set; }

    public long? Fcpreparernoterf { get; set; }

    public long? Fcreviewernoterf { get; set; }

    public DateTime? Reviewed2date { get; set; }

    public long? Returnforclarnum { get; set; }

    public long? Fcimportance { get; set; }

    public decimal? Fcmateriality { get; set; }

    public string? Fcflexnumeric1 { get; set; }

    public DateTime? Fcflexdate1 { get; set; }

    public string? Fcflextext1 { get; set; }

    public string? Fcflexnumeric2 { get; set; }

    public DateTime? Fcflexdate2 { get; set; }

    public string? Fcflextext2 { get; set; }

    public DateTime? Fcinitprepareddate { get; set; }

    public string? Fcsequencestr { get; set; }

    public long? Fcinitstagenum { get; set; }

    public string? Fcidentifier { get; set; }
}
