using System;
using System.Collections.Generic;

namespace Employee.DataEntity;

public partial class CityDetail
{
    public int CityId { get; set; }

    public string? CityName { get; set; }

    public int? StateId { get; set; }

    public bool? IsActive { get; set; }
}
