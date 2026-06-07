using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Useraccount
{
    public long Usernum { get; set; }

    public string? Username { get; set; }

    public long? Defaultdate { get; set; }

    public long? Disablelogin { get; set; }

    public long? Institution { get; set; }

    public long? Mainframeupdate { get; set; }

    public string? Networkid { get; set; }

    public long? Obrefresh { get; set; }

    public string? Usercode { get; set; }

    public string? Userpassword { get; set; }

    public long? Userpref1 { get; set; }

    public long? Userpref2 { get; set; }

    public long? Autodisplaywin { get; set; }

    public long? Helpwindowtype { get; set; }

    public long? Helpwindowloc { get; set; }

    public long? Badlogincount { get; set; }

    public string? Encryptedpassword { get; set; }

    public DateTime? Lastlogon { get; set; }

    public DateTime? Lastpwchange { get; set; }

    public long? Defprintformatnum { get; set; }

    public string? Realname { get; set; }

    public long? Licenseflag { get; set; }

    public string? Longusercode { get; set; }

    public string? Longpassword { get; set; }

    public long? Primaryusergroup { get; set; }

    public long? Userpref3 { get; set; }

    public long? Defprocessdate { get; set; }

    public long? Qapercent { get; set; }

    public string? Emailaddress { get; set; }

    public string? Phonenumber { get; set; }

    public string? Cellnumber { get; set; }

    public DateTime? Lockouttime { get; set; }

    public long? Lockoutreason { get; set; }

    public long? Usertype { get; set; }

    public string? Pinhash { get; set; }

    public DateTime? Pinlastchanged { get; set; }

    public DateTime? Pinlastentered { get; set; }

    public long? Badpincount { get; set; }

    public long? Flags { get; set; }

    public long? Pswdencrypttype { get; set; }

    public long? Obuniqueid { get; set; }

    public string? Securityid { get; set; }

    public long? Licenseflag2 { get; set; }

    public DateTime? Expiredate { get; set; }

    public long? Userpref4 { get; set; }

    public long? Lcid { get; set; }

    public string? Initvectordata { get; set; }

    public long? Pincryptotype { get; set; }

    public string? Pininitvectordata { get; set; }

    public long? Ianatznum { get; set; }
}
