using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;
using _08_HOTROTIMVIEC.DAO;

namespace _08_HOTROTIMVIEC.BUS
{
    class BUS_SERVICES
    {
        DAO_SERVICES dAO_SERVICES;
        public BUS_SERVICES()
        {
            dAO_SERVICES = new DAO_SERVICES();
        }
        public int? checkDN(string tk, string mk)
        {
            int? check = dAO_SERVICES.checkDN(tk, mk);
            return check;
        }
        //////////////////////////THỨC
        public dynamic getListDVTD_By_MaViec(int maViec)
        {
            return dAO_SERVICES.getListDVTD_By_MaViec(maViec);
        }
        public dynamic getList_DiaDiem_MaViec(int maViec, string kw)
        {
            return dAO_SERVICES.getList_DiaDiem_MaViec(maViec,kw);
        }
        //////////////////HÌNH ẢNH
        ///ĐƠN VỊ
        public DONVI_Image get_DV_images(string maDV)
        {
            return dAO_SERVICES.get_DV_images(maDV);
        }
        public int? CheckDV_Image(string maDV)
        {
            return dAO_SERVICES.CheckDV_Image(maDV);
        }
        ///NGƯỜI LAO ĐỘNG
        public void UpdateImage_Link_NLD(int maNLD, string Link)
        {
            dAO_SERVICES.UpdateImage_Link_NLD(maNLD,Link);
        }
        public NGUOILD_Image get_NGUOILD_images(int maNLD)
        {
            return dAO_SERVICES.get_NGUOILD_images(maNLD);
        }
        public int? CheckNLD_Image(int maNLD)
        {
            return dAO_SERVICES.CheckNLD_Image(maNLD);
        }
        public int? Check_NLD_image_TrungTen(string tenImage)
        {
            return dAO_SERVICES.Check_NLD_image_TrungTen(tenImage);
        }
        public dynamic LocDon_TD_TheoNgay_ByMaNLDandTenViec(int maNLD, string tenViec, int kind, int trangthai)
        {
            return dAO_SERVICES.LocDon_TD_TheoNgay_ByMaNLDandTenViec(maNLD, tenViec, kind, trangthai);
        }
        public void Add_ThongTin_TaiKhoan_NLD(int maNLD, string ten, string cmnd, string gt, DateTime ngaysinh, string diadiem, string sdt, string bangcap, string taikhoan, string mk)
        {
            dAO_SERVICES.Add_ThongTin_TaiKhoan_NLD(maNLD, ten, cmnd, gt, ngaysinh, diadiem, sdt, bangcap, taikhoan, mk);
        }
        //////////////////////////
    }
}
