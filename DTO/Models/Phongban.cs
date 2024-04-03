using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Phongban
{
    public string Mapb { get; set; } = null!;

    public string? Tenpb { get; set; }

    public string? Matruongphong { get; set; }

    public string? Diadiem { get; set; }

    public DateOnly? Ngaynhanchuc { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
