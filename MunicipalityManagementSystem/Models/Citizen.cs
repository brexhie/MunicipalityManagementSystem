using System;
using System.Collections.Generic;

namespace MunicipalityManagementSystem.Models;

public partial class Citizen
{
    public int CitizenId { get; set; }

    public string FullName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? DateOfBirth { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
