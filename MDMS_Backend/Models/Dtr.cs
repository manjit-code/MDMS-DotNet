using System;
using System.Collections.Generic;

namespace MDMS_Backend.Models;

public partial class Dtr
{
    public int Dtrid { get; set; }

    public string Dtrname { get; set; } = null!;

    public int FeederId { get; set; }

    public virtual ICollection<Consumer> Consumers { get; set; } = new List<Consumer>();

    public virtual Feeder Feeder { get; set; } = null!;
}
