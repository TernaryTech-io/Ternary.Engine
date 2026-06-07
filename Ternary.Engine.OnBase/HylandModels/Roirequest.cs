using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roirequest
{
    public long Roirequestnum { get; set; }

    public long? Roiparentreqnum { get; set; }

    public long? Creatorusernum { get; set; }

    public long? Workusernum { get; set; }

    public long? Requestitemnum { get; set; }

    public long? Paymentitemnum { get; set; }

    public long? Roilocationnum { get; set; }

    public string? Requestorname { get; set; }

    public string? Requestorrelation { get; set; }

    public string? Requestoremail { get; set; }

    public string? Billtoaddress1 { get; set; }

    public string? Billtoaddress2 { get; set; }

    public string? Billtoaddress3 { get; set; }

    public string? Shiptoaddress1 { get; set; }

    public string? Shiptoaddress2 { get; set; }

    public string? Shiptoaddress3 { get; set; }

    public string? Roirequestreason { get; set; }

    public string? Patientname { get; set; }

    public long? Mpinum { get; set; }

    public long? Mrnum { get; set; }

    public long? Chtnum { get; set; }

    public DateTime? Begindate { get; set; }

    public DateTime? Enddate { get; set; }

    public DateTime? Requestdate { get; set; }

    public long? Requestpriority { get; set; }

    public long? Roirequesttypenum { get; set; }

    public long? Costperpage { get; set; }

    public long? Autopagecount { get; set; }

    public long? Manualpagecount { get; set; }

    public decimal? Roicost { get; set; }

    public decimal? Roitax { get; set; }

    public decimal? Costadjustment { get; set; }

    public long? Requestbillstatus { get; set; }

    public long? Requestsendstatus { get; set; }

    public long? Deliverytype { get; set; }

    public decimal? Roitotalamount { get; set; }

    public decimal? Roipaidamount { get; set; }

    public long? Flags { get; set; }

    public string? Rejectreason { get; set; }

    public long? Approvalusernum { get; set; }

    public DateTime? Shippeddate { get; set; }

    public DateTime? Paiddate { get; set; }

    public decimal? Roishippingcost { get; set; }

    public long? Paymenttype { get; set; }

    public string? Paymentdesc { get; set; }

    public long? Roiflatfeenum { get; set; }

    public decimal? Roiflatfee { get; set; }

    public string? Roipatientid { get; set; }

    public string? Referencenumber { get; set; }

    public DateTime? Patientdob { get; set; }

    public long? Facilitynum { get; set; }

    public long? Sorttype { get; set; }

    public DateTime? Roiduedate { get; set; }

    public DateTime? Roisubmitteddate { get; set; }

    public long? Rejectreasonnum { get; set; }

    public string? Roicompanyname { get; set; }

    public string? Phonenumber { get; set; }

    public string? Faxnumber { get; set; }

    public long? Pricingpolicynum { get; set; }

    public long? Packetitemnum { get; set; }

    public DateTime? Origbilldate { get; set; }
}
