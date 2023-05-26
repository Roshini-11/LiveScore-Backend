using System;
using System.Collections.Generic;

namespace LiveScore.Models;

public partial class Kabaddi
{
    public int Id { get; set; }

    public string? HomeTeam { get; set; }

    public string? AwayTeam { get; set; }

    public int? HomeScore { get; set; }

    public int? AwayScore { get; set; }

    public string? GameStatus { get; set; }
}
