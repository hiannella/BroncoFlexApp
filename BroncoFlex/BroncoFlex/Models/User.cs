using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class User
{
    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public DateTime CreateDate { get; set; }
}
