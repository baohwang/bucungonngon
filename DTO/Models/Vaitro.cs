using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Vaitro
{
    public string Mavt { get; set; } = null!;

    public string? Tenvaitro { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
