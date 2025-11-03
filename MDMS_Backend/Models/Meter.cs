using System;
using System.Collections.Generic;

namespace MDMS_Backend.Models;

public partial class Meter
{
    public string MeterSerialNo { get; set; } = null!;

    public int ConsumerId { get; set; }

    public string Ipaddress { get; set; } = null!;

    public string? Iccid { get; set; }

    public string? Imsi { get; set; }

    public int ManufacturerId { get; set; }

    public string? Firmware { get; set; }

    public int CategoryId { get; set; }

    public DateOnly InstallDate { get; set; }

    public int StatusId { get; set; }

    public virtual Tariff Category { get; set; } = null!;

    public virtual Consumer Consumer { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
