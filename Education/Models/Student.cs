using System;
using System.Collections.Generic;

namespace Education.Models;

public partial class Student
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;
}
