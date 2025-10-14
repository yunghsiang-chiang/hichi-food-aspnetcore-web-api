using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HDSchedule
{
    public int HUserId { get; set; }

    public int HWeekdayMornings { get; set; }

    public int HWeekdayAfternoons { get; set; }

    public int HWeekdayEvenings { get; set; }

    public int HHolidayMornings { get; set; }

    public int HHolidayAfternoons { get; set; }

    public int HHolidayEvenings { get; set; }

    public DateTime HModifytime { get; set; }
}
