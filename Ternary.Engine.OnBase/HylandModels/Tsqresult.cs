using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tsqresult
{
    public long? Tstestinstancenum { get; set; }

    public long? Tstestnum { get; set; }

    public long? Tsquestionnum { get; set; }

    public long? Questioncorrect { get; set; }

    public long? Answerorder { get; set; }

    public string? Essayanswer { get; set; }

    public long? Essayscored { get; set; }

    public long? Feedbackviewed { get; set; }
}
