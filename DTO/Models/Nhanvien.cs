using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Nhanvien
{
    public string Manv { get; set; } = null!;

    public string? Hoten { get; set; }

    public string? Gioitinh { get; set; }

    public DateOnly? Ngaysinh { get; set; }

    public string? Cmnd { get; set; }

    public DateOnly? Ngayvaolamviec { get; set; }

    public string? Mapb { get; set; }

    public double? Luong { get; set; }

    public string? Mavt { get; set; }

    public string? Matruongphong { get; set; }

    public virtual ICollection<Nhanvien> InverseMatruongphongNavigation { get; set; } = new List<Nhanvien>();

    public virtual Phongban? MapbNavigation { get; set; }

    public virtual Nhanvien? MatruongphongNavigation { get; set; }

    public virtual Vaitro? MavtNavigation { get; set; }
}
