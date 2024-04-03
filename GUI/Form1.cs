using BLL;
using DTO.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GUI
{
    public partial class Form1 : Form
    {
        NhanVienBLL nvBLL = new NhanVienBLL();
        PhongBanBLL pbBLL = new PhongBanBLL();


        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Manv", typeof(string));
            dt.Columns.Add("Hoten", typeof(string));
            dt.Columns.Add("Gioitinh", typeof(string));
            dt.Columns.Add("Ngaysinh", typeof(DateOnly));
            dt.Columns.Add("Cmnd", typeof(string));
            dt.Columns.Add("Ngayvaolamviec", typeof(DateOnly));
            dt.Columns.Add("Mapb", typeof(string));
            dt.Columns.Add("Luong", typeof(double));
            dt.Columns.Add("Mavt", typeof(string));
            dt.Columns.Add("Matruongphong", typeof(string));

            var sucvat = nvBLL.getAllNhanVien();
            foreach (var cv in sucvat)
            {
                DataRow dr = dt.NewRow();

                dr["Manv"] = cv.Manv;
                dr["Hoten"] = cv.Hoten;
                dr["Gioitinh"] = cv.Gioitinh;
                dr["Ngaysinh"] = cv.Ngaysinh;
                dr["Cmnd"] = cv.Cmnd;
                dr["Ngayvaolamviec"] = cv.Ngayvaolamviec;
                dr["Mapb"] = cv.Mapb;
                dr["Luong"] = cv.Luong;
                dr["Mavt"] = cv.Mavt;
                dr["Matruongphong"] = cv.Matruongphong;

                dt.Rows.Add(dr);
            }

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("Mapb", typeof(string));
            dt.Columns.Add("Tenpb", typeof(string));
            dt.Columns.Add("Matruongphong", typeof(string));
            dt.Columns.Add("Diadiem", typeof(string));
            dt.Columns.Add("Ngaynhanchuc", typeof(DateOnly));

            var pb = pbBLL.getAllPhongDal();
            foreach (var p in pb)
            {
                DataRow dr = dt.NewRow();

                dr["Mapb"] = p.Mapb;
                dr["Tenpb"] = p.Tenpb;
                dr["Matruongphong"] = p.Matruongphong;
                dr["Diadiem"] = p.Diadiem;
                dr["Ngaynhanchuc"] = p.Ngaynhanchuc;

                dt.Rows.Add(dr);
            }

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
