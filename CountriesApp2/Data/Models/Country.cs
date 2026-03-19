using System;
using System.Collections.Generic;

namespace CountriesApp2.Data.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public virtual ICollection<Town> Towns { get; set; } = new List<Town>();
}
