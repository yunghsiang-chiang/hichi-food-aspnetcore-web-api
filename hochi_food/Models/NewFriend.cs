using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class NewFriend
{
    public int NewFriendId { get; set; }

    public string FullName { get; set; } = null!;

    public string FullNameNorm { get; set; } = null!;

    public string MobilePhone { get; set; } = null!;

    public string? Email { get; set; }

    public string? LineUserId { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? City { get; set; }

    public string? District { get; set; }

    public string? Address { get; set; }

    public string Stage { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public int CreatedByHID { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedByHID { get; set; }

    public int? IsMergedIntoId { get; set; }
}
