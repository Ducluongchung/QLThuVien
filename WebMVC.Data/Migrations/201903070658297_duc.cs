namespace WebMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class duc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChuDes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DocGias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Sex = c.String(),
                        Address = c.String(),
                        National = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HopDongs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Luong = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MuonSaches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NhanVienId = c.Int(nullable: false),
                        DocGiaId = c.Int(nullable: false),
                        SachId = c.Int(nullable: false),
                        NgayMuon = c.DateTime(nullable: false),
                        NgayTra = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DocGias", t => t.DocGiaId, cascadeDelete: true)
                .ForeignKey("dbo.NhanViens", t => t.NhanVienId, cascadeDelete: true)
                .ForeignKey("dbo.Saches", t => t.SachId, cascadeDelete: true)
                .Index(t => t.NhanVienId)
                .Index(t => t.DocGiaId)
                .Index(t => t.SachId);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Sex = c.String(),
                        Address = c.String(),
                        National = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        HopDongId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HopDongs", t => t.HopDongId, cascadeDelete: true)
                .Index(t => t.HopDongId);
            
            CreateTable(
                "dbo.Saches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IdTacGia = c.Int(nullable: false),
                        IdNXB = c.Int(nullable: false),
                        IdChuDe = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChuDes", t => t.IdChuDe, cascadeDelete: true)
                .ForeignKey("dbo.NhaXuatBans", t => t.IdNXB, cascadeDelete: true)
                .ForeignKey("dbo.Tacgias", t => t.IdTacGia, cascadeDelete: true)
                .Index(t => t.IdTacGia)
                .Index(t => t.IdNXB)
                .Index(t => t.IdChuDe);
            
            CreateTable(
                "dbo.NhaXuatBans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tacgias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        National = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MuonSaches", "SachId", "dbo.Saches");
            DropForeignKey("dbo.Saches", "IdTacGia", "dbo.Tacgias");
            DropForeignKey("dbo.Saches", "IdNXB", "dbo.NhaXuatBans");
            DropForeignKey("dbo.Saches", "IdChuDe", "dbo.ChuDes");
            DropForeignKey("dbo.MuonSaches", "NhanVienId", "dbo.NhanViens");
            DropForeignKey("dbo.NhanViens", "HopDongId", "dbo.HopDongs");
            DropForeignKey("dbo.MuonSaches", "DocGiaId", "dbo.DocGias");
            DropIndex("dbo.Saches", new[] { "IdChuDe" });
            DropIndex("dbo.Saches", new[] { "IdNXB" });
            DropIndex("dbo.Saches", new[] { "IdTacGia" });
            DropIndex("dbo.NhanViens", new[] { "HopDongId" });
            DropIndex("dbo.MuonSaches", new[] { "SachId" });
            DropIndex("dbo.MuonSaches", new[] { "DocGiaId" });
            DropIndex("dbo.MuonSaches", new[] { "NhanVienId" });
            DropTable("dbo.Tacgias");
            DropTable("dbo.NhaXuatBans");
            DropTable("dbo.Saches");
            DropTable("dbo.NhanViens");
            DropTable("dbo.MuonSaches");
            DropTable("dbo.HopDongs");
            DropTable("dbo.DocGias");
            DropTable("dbo.ChuDes");
        }
    }
}
