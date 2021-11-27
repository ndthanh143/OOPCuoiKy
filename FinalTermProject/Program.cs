using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    class Program
    {
        static List<NgheSi> dsNgheSi = new List<NgheSi>();
        static List<BaiNhac> dsBaiNhac = new List<BaiNhac>();
        static List<TheLoaiNhac> dsTheLoaiNhac = new List<TheLoaiNhac>();
		static List<BoPhanCongTy> dsBoPhanCTy = new List<BoPhanCongTy>();
		static List<NhanVien> dsNhanVien = new List<NhanVien>();
		static List<HopDongNgheSi> dsHopDongNS = new List<HopDongNgheSi>();
		static List<Booking> dsBooking = new List<Booking>();
		static List<KhachHang> dsKhachHang = new List<KhachHang>();
		static List<DiaDiemBieuDien> dsDiaDiemBieuDien = new List<DiaDiemBieuDien>();
		static List<QLNgheSi> dsQLNgheSi = new List<QLNgheSi>();

		public static void TaoDanhSachNgheSi()
		{
			dsNgheSi.Add(new NgheSi("NS01", "Nguyen Son Tung", "Son Tung MTP", 27, "Thai Binh", "30/12/2015",
				new List<BaiNhac>(), new List<Booking>(), new List<HopDongNgheSi>(), null));
			dsNgheSi.Add(new NgheSi("NS02", "Nguyen Khoa Toc Tien", "Toc Tien", 32, "TP HCM", "3 - 07 - 2020",
				new List<BaiNhac>(), new List<Booking>(), new List<HopDongNgheSi>(), null));
			dsNgheSi.Add(new NgheSi("NS03" , "Mai Hong Ngoc" , "Dong Nhi" , 33, "Ha Noi" , "22 - 08 - 2019",
				new List<BaiNhac>(), new List<Booking>(), new List<HopDongNgheSi>(), null));
			dsNgheSi.Add(new NgheSi("NS04" , "Phan Thi My Tam" , "My Tam" , 40, "Da Nang" , "9 - 04 - 2018",
				new List<BaiNhac>(), new List<Booking>(), new List<HopDongNgheSi>(), null));
			dsNgheSi.Add(new NgheSi("NS05" , "Nguyen Bang Kieu" , "Bang Kieu" , 48, "Ha Noi" , "30 - 03 - 2020",
				new List<BaiNhac>(), new List<Booking>(), new List<HopDongNgheSi>(), null));
		}
		public static void TaoDanhSachBaiNhac()
        {
            dsBaiNhac.Add(new BaiNhac("BH01", "Con mua ngang qua", dsTheLoaiNhac[0], dsNgheSi[0]));
            dsBaiNhac.Add(new BaiNhac("BH02", "Que toi", dsTheLoaiNhac[1], dsNgheSi[1]));
            dsBaiNhac.Add(new BaiNhac("BH03", "Ha Noi mua thu", dsTheLoaiNhac[4], dsNgheSi[3]));
            dsBaiNhac.Add(new BaiNhac("BH04", "Cu chill thoi", dsTheLoaiNhac[3], dsNgheSi[2]));
            dsBaiNhac.Add(new BaiNhac("BH05", "Em ngay xua khac roi", dsTheLoaiNhac[5], dsNgheSi[3]));
            dsBaiNhac.Add(new BaiNhac("BH06", "Trai tim ben le", dsTheLoaiNhac[2], dsNgheSi[4]));
            dsBaiNhac.Add(new BaiNhac("BH07", "Yeu la cuoi", dsTheLoaiNhac[2], dsNgheSi[1]));
            dsBaiNhac.Add(new BaiNhac("BH08", "Di ve nha", dsTheLoaiNhac[0], dsNgheSi[2]));
            dsBaiNhac.Add(new BaiNhac("BH09", "Mot dem say", dsTheLoaiNhac[5], dsNgheSi[0]));
            ////
            dsTheLoaiNhac[0].dsbn_bn.Add(dsBaiNhac[0]);
            dsTheLoaiNhac[0].dsbn_bn.Add(dsBaiNhac[7]);

            dsTheLoaiNhac[1].dsbn_bn.Add(dsBaiNhac[1]);

            dsTheLoaiNhac[2].dsbn_bn.Add(dsBaiNhac[5]);
            dsTheLoaiNhac[2].dsbn_bn.Add(dsBaiNhac[6]);

            dsTheLoaiNhac[3].dsbn_bn.Add(dsBaiNhac[3]);

            dsTheLoaiNhac[4].dsbn_bn.Add(dsBaiNhac[2]);

            dsTheLoaiNhac[5].dsbn_bn.Add(dsBaiNhac[4]);
            dsTheLoaiNhac[5].dsbn_bn.Add(dsBaiNhac[8]);

            //
            dsNgheSi[0].dsbn_bn.Add(dsBaiNhac[0]);
            dsNgheSi[0].dsbn_bn.Add(dsBaiNhac[8]);

            dsNgheSi[1].dsbn_bn.Add(dsBaiNhac[1]);
            dsNgheSi[1].dsbn_bn.Add(dsBaiNhac[6]);


            dsNgheSi[2].dsbn_bn.Add(dsBaiNhac[3]);
            dsNgheSi[2].dsbn_bn.Add(dsBaiNhac[7]);


            dsNgheSi[3].dsbn_bn.Add(dsBaiNhac[2]);
            dsNgheSi[3].dsbn_bn.Add(dsBaiNhac[4]);

            dsNgheSi[4].dsbn_bn.Add(dsBaiNhac[5]);

        }
		public static void TaoDanhSachTheLoaiNhac()
        {
			dsTheLoaiNhac.Add(new TheLoaiNhac("TL01", "Pop", new List<BaiNhac>()));
			dsTheLoaiNhac.Add(new TheLoaiNhac("TL02", "Blues", new List<BaiNhac>()));
			dsTheLoaiNhac.Add(new TheLoaiNhac("TL03", "Countryside", new List<BaiNhac>()));
			dsTheLoaiNhac.Add(new TheLoaiNhac("TL04", "Jazz", new List<BaiNhac>()));
			dsTheLoaiNhac.Add(new TheLoaiNhac("TL05", "Rock", new List<BaiNhac>()));
			dsTheLoaiNhac.Add(new TheLoaiNhac("TL06", "HipHop", new List<BaiNhac>()));
		}

        public static void TaoDanhSachNhanVien()
        {
            dsNhanVien.Add(new NhanVien(1001, "Le Van Do", 24, "12/6A - Chu Van An – Binh Thanh – TP.HCM", "Nam", 10000, dsBoPhanCTy[0], null));
            dsNhanVien.Add(new NhanVien(1002, " Pham Nhat Minh ", 27, "35 – Le Loi – TP.Quy Nhon", "Nam", 20000, dsBoPhanCTy[1],null));
            dsNhanVien.Add(new NhanVien(1003, " Tran Van Truong ", 44, "24/3A – Tran Hung Dao –TP. Nha Trang", "Nam", 12000, dsBoPhanCTy[2], null));
            dsNhanVien.Add(new NhanVien(1004, " Le Quoc Chi ", 43, "35/3A - Chu Van An – Binh Thanh – TP.HCM", "Nam", 18000, dsBoPhanCTy[3], null));
            dsNhanVien.Add(new NhanVien(1005, " Nguyen Minh Anh ", 24, "12 – Le Hong Phong – TP.Quy Nhon", "Nu", 22000, dsBoPhanCTy[4], null));
            dsNhanVien.Add(new NhanVien(1006, " Pham Ngoc Anh ", 23, "2/2A – Tran Phu –TP. Da Nang", "Nu", 12000, dsBoPhanCTy[5], null));
            dsNhanVien.Add(new NhanVien(1007, " Do Hong Nhung ", 32, "3/2B – Nguyen Thi Minh Khai – TP.Quy Nhon", "Nu", 15000, dsBoPhanCTy[6], null));
            dsNhanVien.Add(new NhanVien(1008, " Vu Trung Hieu ", 33, "3/4A – Ngo Quyen – TP. Vung Tau", "Nam", 11000, dsBoPhanCTy[0], null));
            dsNhanVien.Add(new NhanVien(1009, " Tran Van An ", 34, "2/1A – Nguyen Thi Minh Khai – TP.Quy Nhon", "Nam", 17000, dsBoPhanCTy[0], null));
            dsNhanVien.Add(new NhanVien(1010, " Nguyen Thi Lua ", 33, "123 – Vo Van Ngan – TP.Thu Duc", "Nu", 10000, dsBoPhanCTy[0], null));
            dsNhanVien.Add(new NhanVien(1011, " Truong Tan Phuc", 29, "10 – Cu Chi - TP.HCM ", "Nam", 32000, dsBoPhanCTy[0], null));
            dsNhanVien.Add(new NhanVien(1012, " Pham Anh Huy", 33, "10 – Dang Van Bi - TP.Thu Duc", "Nam", 25000, dsBoPhanCTy[4], null));
            dsNhanVien.Add(new NhanVien(1013, " Tran Minh Hoa", 41, "25 – Cu Chi - TP.HCM ", "Nam", 16000, dsBoPhanCTy[5], null));
            /////
            dsBoPhanCTy[0].dsnv_nv.Add(dsNhanVien[0]);
            dsBoPhanCTy[0].dsnv_nv.Add(dsNhanVien[7]);

            dsBoPhanCTy[1].dsnv_nv.Add(dsNhanVien[1]);
            dsBoPhanCTy[1].dsnv_nv.Add(dsNhanVien[8]);

            dsBoPhanCTy[2].dsnv_nv.Add(dsNhanVien[2]);
            dsBoPhanCTy[2].dsnv_nv.Add(dsNhanVien[9]);

            dsBoPhanCTy[3].dsnv_nv.Add(dsNhanVien[3]);
            dsBoPhanCTy[3].dsnv_nv.Add(dsNhanVien[10]);

            dsBoPhanCTy[4].dsnv_nv.Add(dsNhanVien[4]);
            dsBoPhanCTy[4].dsnv_nv.Add(dsNhanVien[11]);

            dsBoPhanCTy[5].dsnv_nv.Add(dsNhanVien[5]);
            dsBoPhanCTy[5].dsnv_nv.Add(dsNhanVien[12]);

            dsBoPhanCTy[6].dsnv_nv.Add(dsNhanVien[6]);
            ///
        }
		public static void TaoDanhSachBoPhanCongTy()
        {
            dsBoPhanCTy.Add(new BoPhanCongTy(201, "Quan ly nghe si", new List<NhanVien>()));
            dsBoPhanCTy.Add(new BoPhanCongTy(202, "Thiet Ke", new List<NhanVien>()));
            dsBoPhanCTy.Add(new BoPhanCongTy(203, "Am Thanh", new List<NhanVien>()));
            dsBoPhanCTy.Add(new BoPhanCongTy(204, "Sang tac", new List<NhanVien>()));
            dsBoPhanCTy.Add(new BoPhanCongTy(205, "Ke hoach", new List<NhanVien>()));
            dsBoPhanCTy.Add(new BoPhanCongTy(206, "Tai Chinh", new List<NhanVien>()));
            dsBoPhanCTy.Add(new BoPhanCongTy(207, "trang phuc", new List<NhanVien>()));
        }
        public static void TaoDanhSachHopDongNgheSi()
        {
            dsHopDongNS.Add(new HopDongNgheSi(3001, "15/11/2020", "15/11/2026", 8, dsNgheSi[0]));
            dsHopDongNS.Add(new HopDongNgheSi(3002,  "25/11/2020", "25/11/2024", 7, dsNgheSi[1]));
            dsHopDongNS.Add(new HopDongNgheSi(3003,  "17/1/2018", "17/1/2028", 12, dsNgheSi[2]));
            dsHopDongNS.Add(new HopDongNgheSi(3004,  "3/4/2019", "3/4/2026", 16, dsNgheSi[3]));
            dsHopDongNS.Add(new HopDongNgheSi(3005,  "25/11/2024", "25/11/2026", 8, dsNgheSi[1]));
            dsHopDongNS.Add(new HopDongNgheSi(3006,  "5/9/2015", "5/9/2029", 19, dsNgheSi[4]));
			//
			dsNgheSi[0].dshd_hdns.Add(dsHopDongNS[0]);

			dsNgheSi[1].dshd_hdns.Add(dsHopDongNS[1]);
			dsNgheSi[1].dshd_hdns.Add(dsHopDongNS[4]);

			dsNgheSi[2].dshd_hdns.Add(dsHopDongNS[2]);

			dsNgheSi[3].dshd_hdns.Add(dsHopDongNS[3]);

			dsNgheSi[4].dshd_hdns.Add(dsHopDongNS[5]);
			//
		}
		public static void TaoDanhSachKhachHang()
		{
			dsKhachHang.Add(new KhachHang("KH01", "Le Van Duy", "vanduy172@gmail.com", "0964721849", new List<Booking>()));
			dsKhachHang.Add(new KhachHang("KH02", "Nguyen Tan Tai", "tainguyen204@gmail.com", "0273916452", new List<Booking>()));
			dsKhachHang.Add(new KhachHang("KH03", "Nguyen Phat Dat", "phatDatNguyen@gmail.com", "017439243", new List<Booking>()));
			dsKhachHang.Add(new KhachHang("KH04", "Truong Van B", "btruongxyz@gmail.com", "0136593462", new List<Booking>()));
			dsKhachHang.Add(new KhachHang("KH05", "Doan Quoc Trung", "trantrung1978@gmail.com", "0427492542", new List<Booking>()));
			dsKhachHang.Add(new KhachHang("KH06", "Nguyen Van A", "anguyenvan503@gmail.com", "0353725931", new List<Booking>()));
			dsKhachHang.Add(new KhachHang("KH07", "Nguyen Duy Thanh", "thanhnguyenduy103@gmail.com", "0363827931", new List<Booking>()));
		}

		public static void TaoDanhSachBooking()
		{

            dsBooking.Add(new Booking("BK01", "70th Anniversary", "2 - 12 - 2021", dsNgheSi[0],
                 dsDiaDiemBieuDien[0], dsKhachHang[0]));
            dsBooking.Add(new Booking("BK02", "Festival 20", "27 - 01 - 2022", dsNgheSi[1],
                 dsDiaDiemBieuDien[1], dsKhachHang[1]));
            dsBooking.Add(new Booking("BK03", "Song 21", "31 - 01 - 2022", dsNgheSi[2],
                 dsDiaDiemBieuDien[2], dsKhachHang[2]));
            dsBooking.Add(new Booking("BK04", "Le Hoi Hoa", "30 - 03 - 2022", dsNgheSi[1],
                 dsDiaDiemBieuDien[3], dsKhachHang[3]));
            dsBooking.Add(new Booking("BK05", "Cho Di Con Mai", "15 - 07 - 2022", dsNgheSi[3],
                 dsDiaDiemBieuDien[4], dsKhachHang[4]));
            dsBooking.Add(new Booking("BK06", "Final Coutdown", "24 - 9 - 2022", dsNgheSi[4],
                 dsDiaDiemBieuDien[5], dsKhachHang[5]));
            dsBooking.Add(new Booking("BK07", "VietNam Festival", "27 - 12 - 2021", dsNgheSi[2],
                 dsDiaDiemBieuDien[6], dsKhachHang[6]));
            dsBooking.Add(new Booking("BK08", "Tro Ve", "10 - 10 - 2022", dsNgheSi[0],
                 dsDiaDiemBieuDien[1], dsKhachHang[1]));
            dsBooking.Add(new Booking("BK09", "Duong xa Honda", "20 - 12 - 2022", dsNgheSi[3],
                 dsDiaDiemBieuDien[2], dsKhachHang[4]));
            //
            dsNgheSi[0].dsbk_bk.Add(dsBooking[0]);
            dsNgheSi[0].dsbk_bk.Add(dsBooking[7]);

            dsNgheSi[1].dsbk_bk.Add(dsBooking[1]);
            dsNgheSi[1].dsbk_bk.Add(dsBooking[3]);

            dsNgheSi[2].dsbk_bk.Add(dsBooking[2]);
            dsNgheSi[2].dsbk_bk.Add(dsBooking[6]);

            dsNgheSi[3].dsbk_bk.Add(dsBooking[4]);
            dsNgheSi[3].dsbk_bk.Add(dsBooking[8]);

            dsNgheSi[4].dsbk_bk.Add(dsBooking[5]);

            //
            dsDiaDiemBieuDien[0].dsbk_bk.Add(dsBooking[0]);

            dsDiaDiemBieuDien[1].dsbk_bk.Add(dsBooking[1]);
            dsDiaDiemBieuDien[1].dsbk_bk.Add(dsBooking[7]);

            dsDiaDiemBieuDien[2].dsbk_bk.Add(dsBooking[2]);
            dsDiaDiemBieuDien[2].dsbk_bk.Add(dsBooking[8]);

            dsDiaDiemBieuDien[3].dsbk_bk.Add(dsBooking[3]);
            dsDiaDiemBieuDien[4].dsbk_bk.Add(dsBooking[4]);
            dsDiaDiemBieuDien[5].dsbk_bk.Add(dsBooking[5]);
            dsDiaDiemBieuDien[6].dsbk_bk.Add(dsBooking[6]);

            //
            dsKhachHang[0].dsbk_bk.Add(dsBooking[0]);

            dsKhachHang[1].dsbk_bk.Add(dsBooking[1]);
            dsKhachHang[1].dsbk_bk.Add(dsBooking[7]);

            dsKhachHang[2].dsbk_bk.Add(dsBooking[2]);
            dsKhachHang[3].dsbk_bk.Add(dsBooking[3]);

            dsKhachHang[4].dsbk_bk.Add(dsBooking[4]);
            dsKhachHang[4].dsbk_bk.Add(dsBooking[8]);

            dsKhachHang[5].dsbk_bk.Add(dsBooking[5]);
            dsKhachHang[6].dsbk_bk.Add(dsBooking[6]);
            //
        }
        public static void TaoDanhSachDiaDiemBieuDiem()
		{
			dsDiaDiemBieuDien.Add(new DiaDiemBieuDien("DiaDiem01", "22 Hai Ba Trung", "Nha Hat Lon Ha Noi", 2000, new List<Booking>()));
			dsDiaDiemBieuDien.Add(new DiaDiemBieuDien("DiaDiem02", "144 Hoang Kiem", "Quang Truong Lon", 1500, new List<Booking>()));
			dsDiaDiemBieuDien.Add(new DiaDiemBieuDien("DiaDiem03", "7 Phuong Be Nghe", "Nha Hat TP HCM", 500, new List<Booking>()));
			dsDiaDiemBieuDien.Add(new DiaDiemBieuDien("DiaDiem04", "Hoang Minh Giam Phuong 9 Phu Nhuan", "Cong Vien Gia Dinh", 1000, new List<Booking>()));
			dsDiaDiemBieuDien.Add(new DiaDiemBieuDien("DiaDiem05", "105 Tran Hung Dao", "Nha Hat Tay Do", 1200, new List<Booking>()));
			dsDiaDiemBieuDien.Add(new DiaDiemBieuDien("DiaDiem06", "142 Le Loi", "Trung Tâm TP Moi BD", 3000, new List<Booking>()));
			dsDiaDiemBieuDien.Add(new DiaDiemBieuDien("DiaDiem07", "82 Nguyen Hue", "Pho Di Bo Nguyen Hue", 10000, new List<Booking>()));
			dsDiaDiemBieuDien.Add(new DiaDiemBieuDien("DiaDiem08", "1 Luu Gia Phuong 15", "Nha Thi Dau Phu Tho", 1000, new List<Booking>()));
		}
		public static void TaoDanhSachQLNgheSi()
        {
			dsQLNgheSi.Add(new QLNgheSi(dsNgheSi[0], dsNhanVien[0]));
			dsQLNgheSi.Add(new QLNgheSi(dsNgheSi[1], dsNhanVien[7]));
			dsQLNgheSi.Add(new QLNgheSi(dsNgheSi[2], dsNhanVien[8]));
			dsQLNgheSi.Add(new QLNgheSi(dsNgheSi[3], dsNhanVien[9]));
			dsQLNgheSi.Add(new QLNgheSi(dsNgheSi[4], dsNhanVien[10]));
            //
            dsNgheSi[0].qlns = new QLNgheSi(dsQLNgheSi[0]);
            dsNgheSi[1].qlns = new QLNgheSi(dsQLNgheSi[1]);
            dsNgheSi[2].qlns = new QLNgheSi(dsQLNgheSi[2]);
            dsNgheSi[3].qlns = new QLNgheSi(dsQLNgheSi[3]);
            dsNgheSi[4].qlns = new QLNgheSi(dsQLNgheSi[4]);
            //
            dsNhanVien[0].qlns = new QLNgheSi(dsQLNgheSi[0]);
            dsNhanVien[7].qlns = new QLNgheSi(dsQLNgheSi[1]);
            dsNhanVien[8].qlns = new QLNgheSi(dsQLNgheSi[2]);
            dsNhanVien[9].qlns = new QLNgheSi(dsQLNgheSi[3]);
            dsNhanVien[10].qlns = new QLNgheSi(dsQLNgheSi[4]);
            //
        }
        /////////
        // liệt kê danh sách nghệ sĩ
        public static void linq1()
        {
            var dsns = dsNgheSi.Select(ns => ns);
            foreach(var ns in dsns)
            {
                Console.WriteLine("{0} - {1}",ns.maNgheSi,ns.tenNgheSi);
                foreach(var bainhac in ns.dsbn_bn)
                {
                    Console.WriteLine("{0} - {1} - {2}",bainhac.maBaiNhac,bainhac.tenBaiNhac,bainhac.TLN.tenTheLoai);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
			Console.OutputEncoding = Encoding.UTF8;
            TaoDanhSachTheLoaiNhac();
            TaoDanhSachNgheSi();
            TaoDanhSachBaiNhac();
            TaoDanhSachDiaDiemBieuDiem();
            TaoDanhSachKhachHang();
            TaoDanhSachHopDongNgheSi();
            TaoDanhSachBoPhanCongTy();
            TaoDanhSachNhanVien();
            TaoDanhSachQLNgheSi();
            TaoDanhSachBooking();

            linq1();
        }
    }
}
