using System;
using System.Collections.Generic;

namespace LiveScore.Models;

public partial class League
{
    public int TeamRank { get; set; }

    public string? TeamName { get; set; }

    public int? Played { get; set; }

    public int? Won { get; set; }

    public int? Lost { get; set; }

    public int? Tied { get; set; }

    public int? Points { get; set; }
}
