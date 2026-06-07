using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eacuserrequest
{
    public long Eacuserrequestnum { get; set; }

    public string? Eacuserrequestid { get; set; }

    public string? Username { get; set; }

    public string? Eacpassword { get; set; }

    public string? Eacfirstname { get; set; }

    public string? Eaclastname { get; set; }

    public string? Emailaddress { get; set; }

    public string? Phonenumber { get; set; }

    public string? Cellnumber { get; set; }

    public long? Usernum { get; set; }

    public long? Adminusernum { get; set; }

    public long? Externalclientnum { get; set; }

    public long? Pswdencrypttype { get; set; }

    public long? Obuniqueid { get; set; }

    public string? Resettoken { get; set; }

    public DateTime? Tokencreationtimestamp { get; set; }

    public long? Hastokenbeenused { get; set; }

    public long? Questiontouse { get; set; }

    public string? Initvectordata { get; set; }
}
