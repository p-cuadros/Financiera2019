namespace Financiera2019.Infraestructura.Datos.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_CLIENTES",
                c => new
                    {
                        COD_CLIENTE = c.Int(nullable: false, identity: true),
                        NOM_CLIENTE = c.String(nullable: false, maxLength: 100),
                        FEC_REGISTRO = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.COD_CLIENTE);
            
            CreateTable(
                "dbo.TBL_CUENTAS",
                c => new
                    {
                        ID_CUENTA = c.Int(nullable: false, identity: true),
                        NUM_CUENTA = c.String(nullable: false, maxLength: 10),
                        COD_CLIENTE = c.Int(nullable: false),
                        MON_SALDO = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FEC_APERTURA = c.DateTime(nullable: false),
                        EST_CUENTA = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID_CUENTA)
                .ForeignKey("dbo.TBL_CLIENTES", t => t.COD_CLIENTE, cascadeDelete: true)
                .Index(t => t.COD_CLIENTE);

            CreateTable(
                "dbo.TBL_MOVIMIENTOS",
                c => new
                {
                    NUM_MOVIMIENTO = c.Int(nullable: false, identity: true),
                    FEC_MOVIMIENTO = c.DateTime(nullable: false),
                    COD_TIPO_OPER = c.Byte(nullable: false),
                    MON_MOVIMIENTO = c.Decimal(nullable: false, precision: 18, scale: 2),
                    EST_MOVIMIENTO = c.Byte(nullable: false),
                    ID_CUENTA = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.NUM_MOVIMIENTO)
                .ForeignKey("dbo.TBL_CUENTAS", t => t.ID_CUENTA, cascadeDelete: true)
                .Index(t => t.ID_CUENTA);            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBL_CUENTAS", "COD_CLIENTE", "dbo.TBL_CLIENTES");
            DropForeignKey("dbo.TBL_MOVIMIENTOS", "ID_CUENTA", "dbo.TBL_CUENTAS");
            DropIndex("dbo.TBL_MOVIMIENTOS", new[] { "ID_CUENTA" });
            DropIndex("dbo.TBL_CUENTAS", new[] { "COD_CLIENTE" });
            DropTable("dbo.TBL_MOVIMIENTOS");
            DropTable("dbo.TBL_CUENTAS");
            DropTable("dbo.TBL_CLIENTES");
        }
    }
}
