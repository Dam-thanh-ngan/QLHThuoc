namespace QLHieuThuoc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KhachHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietNhap",
                c => new
                    {
                        STT = c.Int(nullable: false),
                        MaPhieuNhap = c.String(nullable: false, maxLength: 20),
                        MaThuoc = c.String(nullable: false, maxLength: 20),
                        MaNCC = c.String(nullable: false, maxLength: 20),
                        SoLuong = c.Int(nullable: false),
                        NgayNhap = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.STT);
            
            CreateTable(
                "dbo.ChiTietXuat",
                c => new
                    {
                        STT = c.Int(nullable: false),
                        MaPhieuXuat = c.String(nullable: false, maxLength: 20),
                        MaThuoc = c.String(nullable: false, maxLength: 20),
                        SoLuong = c.Int(nullable: false),
                        NgayNhap = c.DateTime(nullable: false, storeType: "date"),
                        MaKhachHang = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.STT);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 20, unicode: false),
                        TenKhachHang = c.String(nullable: false, maxLength: 20),
                        SoDienThoai = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.NhaCC",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 20, unicode: false),
                        TenNCC = c.String(nullable: false, maxLength: 20),
                        SoDienThoai = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.MaNCC);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 50, unicode: false),
                        HoTen = c.String(nullable: false, maxLength: 50),
                        ChucVu = c.String(nullable: false, maxLength: 50, unicode: false),
                        GioiTinh = c.Boolean(nullable: false),
                        Tuoi = c.Int(nullable: false),
                        DiaChi = c.String(nullable: false, maxLength: 50),
                        SoDienThoai = c.String(nullable: false, maxLength: 50, unicode: false),
                        PhanQuyen = c.String(nullable: false, maxLength: 50),
                        TenDangNhap = c.String(nullable: false, maxLength: 50),
                        MatKhau = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.NhomThuoc",
                c => new
                    {
                        MaNhom = c.String(nullable: false, maxLength: 20, unicode: false),
                        TenNhom = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.MaNhom);
            
            CreateTable(
                "dbo.PhieuNhap",
                c => new
                    {
                        MaPhieuNhap = c.String(nullable: false, maxLength: 20, unicode: false),
                        MaNhanVien = c.String(nullable: false, maxLength: 20, unicode: false),
                        NgayTao = c.DateTime(nullable: false, storeType: "date"),
                        MaNCC = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MaPhieuNhap);
            
            CreateTable(
                "dbo.PhieuXuat",
                c => new
                    {
                        MaPhieuXuat = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaNhanVien = c.String(nullable: false, maxLength: 50, unicode: false),
                        NgayTao = c.DateTime(nullable: false, storeType: "date"),
                        MaKhachHang = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaPhieuXuat);
            
            CreateTable(
                "dbo.Thuoc",
                c => new
                    {
                        MaThuoc = c.String(nullable: false, maxLength: 20, unicode: false),
                        MaNhom = c.String(nullable: false, maxLength: 20, unicode: false),
                        TenThuoc = c.String(nullable: false, maxLength: 20),
                        CongDung = c.String(nullable: false, maxLength: 20),
                        ThanhPhan = c.String(nullable: false, maxLength: 20),
                        DonViTinh = c.String(nullable: false, maxLength: 20),
                        XuatXu = c.String(nullable: false, maxLength: 20),
                        DonGia = c.Decimal(nullable: false, precision: 18, scale: 0),
                        SoLuong = c.Int(nullable: false),
                        MaNCC = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.MaThuoc);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Thuoc");
            DropTable("dbo.PhieuXuat");
            DropTable("dbo.PhieuNhap");
            DropTable("dbo.NhomThuoc");
            DropTable("dbo.NhanVien");
            DropTable("dbo.NhaCC");
            DropTable("dbo.KhachHang");
            DropTable("dbo.ChiTietXuat");
            DropTable("dbo.ChiTietNhap");
        }
    }
}
