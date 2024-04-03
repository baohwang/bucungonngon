using DAL;
using DTO.Models;


namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL sucvat = new NhanVienDAL();

        public List<Nhanvien> getAllNhanVien()
        {
            var nhanvien = sucvat.getAllNhanVien();
            return nhanvien;
        }
    }
}
