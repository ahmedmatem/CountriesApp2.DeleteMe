using System;
using System.Collections.Generic;

namespace CountriesApp2.Data.Models;

public partial class Town
{
    public int TownId { get; set; }

    public string TownName { get; set; } = null!;

    public int? CountryId { get; set; }

    public virtual Country? Country { get; set; }
}
