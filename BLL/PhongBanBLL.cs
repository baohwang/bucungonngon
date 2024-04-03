using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhongBanBLL
    {
        PhongBanDal pb = new PhongBanDal();

        public List<Phongban> getAllPhongDal()
        {
            var gg = pb.getAllPhongBansDal();
            return gg;
        }
    }
}
