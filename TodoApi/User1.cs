﻿using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class User1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }
}
