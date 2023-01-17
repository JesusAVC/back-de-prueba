using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class prueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    idcategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.idcategoria);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    idcliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipocliente = table.Column<string>(name: "tipo_cliente", type: "nvarchar(40)", maxLength: 40, nullable: false),
                    nombres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    tipodocumento = table.Column<string>(name: "tipo_documento", type: "nvarchar(40)", maxLength: 40, nullable: false),
                    numdocumento = table.Column<string>(name: "num_documento", type: "nvarchar(40)", maxLength: 40, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    celular = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.idcliente);
                });

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    idmarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marca", x => x.idmarca);
                });

            migrationBuilder.CreateTable(
                name: "proveedor",
                columns: table => new
                {
                    idproveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ruc = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    representante = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    celular = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedor", x => x.idproveedor);
                });

            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    idproducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    precioventa = table.Column<string>(name: "precio_venta", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    stock = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    idcategoria = table.Column<int>(name: "id_categoria", type: "int", nullable: false),
                    idmarca = table.Column<int>(name: "id_marca", type: "int", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto", x => x.idproducto);
                    table.ForeignKey(
                        name: "FK_producto_categoria_id_categoria",
                        column: x => x.idcategoria,
                        principalTable: "categoria",
                        principalColumn: "idcategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_producto_marca_id_marca",
                        column: x => x.idmarca,
                        principalTable: "marca",
                        principalColumn: "idmarca",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ingreso",
                columns: table => new
                {
                    idingreso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipocomprobante = table.Column<string>(name: "tipo_comprobante", type: "nvarchar(40)", maxLength: 40, nullable: false),
                    seriecomprobante = table.Column<string>(name: "serie_comprobante", type: "nvarchar(40)", maxLength: 40, nullable: false),
                    numcomprobante = table.Column<string>(name: "num_comprobante", type: "nvarchar(40)", maxLength: 40, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    impuesto = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: false),
                    estado = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    idproveedor = table.Column<int>(name: "id_proveedor", type: "int", maxLength: 4, nullable: false),
                    idusuario = table.Column<int>(name: "id_usuario", type: "int", maxLength: 4, nullable: false),
                    idproveedor0 = table.Column<int>(name: "idproveedor", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingreso", x => x.idingreso);
                    table.ForeignKey(
                        name: "FK_ingreso_proveedor_idproveedor",
                        column: x => x.idproveedor0,
                        principalTable: "proveedor",
                        principalColumn: "idproveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalleingreso",
                columns: table => new
                {
                    idingreso = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    precio = table.Column<double>(type: "float", maxLength: 9, nullable: false),
                    estado = table.Column<bool>(type: "bit", maxLength: 4, nullable: false),
                    idingreso0 = table.Column<int>(name: "id_ingreso", type: "int", maxLength: 4, nullable: false),
                    idproducto = table.Column<int>(name: "id_producto", type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleingreso", x => x.idingreso);
                    table.ForeignKey(
                        name: "FK_detalleingreso_ingreso_idingreso",
                        column: x => x.idingreso,
                        principalTable: "ingreso",
                        principalColumn: "idingreso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleingreso_producto_id_producto",
                        column: x => x.idproducto,
                        principalTable: "producto",
                        principalColumn: "idproducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detalleingreso_id_producto",
                table: "detalleingreso",
                column: "id_producto");

            migrationBuilder.CreateIndex(
                name: "IX_ingreso_idproveedor",
                table: "ingreso",
                column: "idproveedor");

            migrationBuilder.CreateIndex(
                name: "IX_producto_id_categoria",
                table: "producto",
                column: "id_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_producto_id_marca",
                table: "producto",
                column: "id_marca");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "detalleingreso");

            migrationBuilder.DropTable(
                name: "ingreso");

            migrationBuilder.DropTable(
                name: "producto");

            migrationBuilder.DropTable(
                name: "proveedor");

            migrationBuilder.DropTable(
                name: "categoria");

            migrationBuilder.DropTable(
                name: "marca");
        }
    }
}
