using System;
using System.Collections.Generic;

namespace Employee.DataEntity;

public partial class StateDetail
{
    public int StateId { get; set; }

    public string? StateName { get; set; }

    public bool? IsActive { get; set; }
}
