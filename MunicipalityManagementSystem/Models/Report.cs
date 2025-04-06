using System;
using System.Collections.Generic;

namespace MunicipalityManagementSystem.Models;

public partial class Report
{
    public int ReportId { get; set; }

    public int? CitizenId { get; set; }

    public string ReportType { get; set; } = null!;

    public string Details { get; set; } = null!;

    public DateTime? SubmissionDate { get; set; }

    public string? Status { get; set; }
}
