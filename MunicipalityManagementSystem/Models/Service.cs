using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MunicipalityManagementSystem.Models;

public partial class Service
{
    [Key]
    public int RequestId { get; set; }

    public int? CitizenId { get; set; }

    public string ServiceType { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Citizen? Citizen { get; set; }
}
