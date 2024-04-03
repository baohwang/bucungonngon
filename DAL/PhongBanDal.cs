using DTO.Models;

namespace DAL
{
    public class PhongBanDal
    {
        QlnvLab6Context dbContext = new QlnvLab6Context();

        public List<Phongban> getAllPhongBansDal()
        {
            return dbContext.Phongbans.ToList();
        }
    }
}
