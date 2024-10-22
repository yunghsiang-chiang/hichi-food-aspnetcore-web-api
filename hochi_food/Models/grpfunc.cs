using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class grpfunc
{
    public string GF_ID { get; set; } = null!;

    public string GF_GID { get; set; } = null!;

    public string GF_FID { get; set; } = null!;

    public sbyte GF_LIST { get; set; }

    public sbyte GF_ADD { get; set; }

    public sbyte GF_MOD { get; set; }

    public sbyte GF_DEL { get; set; }
}
