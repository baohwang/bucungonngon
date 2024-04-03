using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        QlnvLab6Context dbContext = new QlnvLab6Context();

        public List<Nhanvien> getAllNhanVien()
        {
            return dbContext.Nhanviens.ToList();
        }

    }
}
