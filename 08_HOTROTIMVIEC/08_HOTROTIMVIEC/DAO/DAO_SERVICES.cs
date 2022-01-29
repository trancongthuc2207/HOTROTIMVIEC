using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;

namespace _08_HOTROTIMVIEC.DAO
{
    class DAO_SERVICES
    {
        HTTVDataContext conn;
        public DAO_SERVICES()
        {
            conn = new HTTVDataContext();
        }
        public int? checkDN(string tk, string mk)
        {
            int? check = 0;
            conn.SV_CheckDN(tk, mk, ref check);
            return check;
        }

        public dynamic getListDVTD_By_MaViec(int maViec)
        {
            var ds = conn.SV_ListDVTD_By_MaViec(maViec).Select(s => new {
                s.MaDV,
                s.TenDV,
                s.QuyMo,
                s.DiaChi,
                s.TGBatDau,
                s.TGKetThuc
            }).ToList();
            return ds;
        }
        public dynamic getList_DiaDiem_MaViec(int maViec, string kw)
        {
            try
            {
                var ds = conn.SV_Timkiem_DiaDiem_MaViec(maViec, kw).Select(s => new {
                    s.MaDV,
                    s.TenDV,
                    s.QuyMo,
                    s.DiaChi,
                    s.TGBatDau,
                    s.TGKetThuc
                }).ToList();
                return ds;
            }
            catch
            {
                return getListDVTD_By_MaViec(maViec);
            }
        }
        ///////////////HÌNH ẢNH
        ///ĐƠN VỊ
        public DONVI_Image get_DV_images(string maDV)
        {
            var img = (from s in conn.DONVI_Images where s.MaDV == maDV select s).First();
            return img;
        }
        public int? CheckDV_Image(string maDV)
        {
            int? check = 0;
            conn.SV_Check_DV_image(maDV, ref check);
            return check;
        }
        ///NGƯỜI LAO ĐỘNG
        public void UpdateImage_Link_NLD(int maNLD, string Link)
        {
            conn.SV_UpdateImage_Link_NLD(maNLD, Link);
        }
        public NGUOILD_Image get_NGUOILD_images(int maNLD)
        {
            var img = (from s in conn.NGUOILD_Images where s.MaNLD == maNLD select s).First();
            return img;
        }
        public int? CheckNLD_Image(int maNLD)
        {
            int? check = 0;
            conn.SV_Check_NLD_image(maNLD, ref check);
            return check;
        }
        public int? Check_NLD_image_TrungTen(string tenImage) 
        {
            int? check = 0;
            conn.SV_Check_NLD_image_TrungTen(tenImage,ref check);
            return check;
        }
        public dynamic LocDon_TD_TheoNgay_ByMaNLDandTenViec(int maNLD, string tenViec,int kind, int trangthai)
        {
                var ds = conn.SV_LocDon_TD_TheoNgay_ByMaNLDandTenViec(maNLD, tenViec, kind, trangthai).Select(s => new {
                    s.MaDV,
                    s.TenDV,
                    s.TenViec,
                    s.MucLuong,
                    s.NgayDK,
                    s.TrangThai
                }).ToList();
                return ds;
        }
        public void Add_ThongTin_TaiKhoan_NLD(int maNLD, string ten,string cmnd,string gt, DateTime ngaysinh, string diadiem,string sdt, string bangcap, string taikhoan,string mk)
        {
            conn.SV_Add_ThongTin_TaiKhoan_NLD(maNLD,ten,cmnd,gt,ngaysinh,diadiem,sdt,bangcap,taikhoan,mk);
        }
        /////////////////////
    }
}
