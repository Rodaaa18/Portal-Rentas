using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ENTITIES.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClasificaContribuyente",
                columns: table => new
                {
                    IdClasificaContribuyente = table.Column<int>(nullable: false),
                    Clasificacion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropioRentas = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasificaContribuyente", x => x.IdClasificaContribuyente);
                });

            migrationBuilder.CreateTable(
                name: "ClasifImpresion",
                columns: table => new
                {
                    IdClasifImpresion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Obs = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasifImpresion", x => x.IdClasifImpresion);
                });

            migrationBuilder.CreateTable(
                name: "CoberturasSociales",
                columns: table => new
                {
                    IdCoberturaSocial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoberturaSocial = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Obs = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoberturasSociales", x => x.IdCoberturaSocial)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "EstadosContribuyentes",
                columns: table => new
                {
                    IdEstadoContribuyente = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(maxLength: 50, nullable: true),
                    AfectaCuentas = table.Column<bool>(nullable: false),
                    Obs = table.Column<string>(maxLength: 100, nullable: true),
                    PropioRentas = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosContribuyentes", x => x.IdEstadoContribuyente);
                });

            migrationBuilder.CreateTable(
                name: "FuentesFinanciamiento",
                columns: table => new
                {
                    IdFuenteFinanciamiento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuenteFinanciamiento = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Obs = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuentesFinanciamiento", x => x.IdFuenteFinanciamiento)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "FuncionesOcupacions",
                columns: table => new
                {
                    IdFuncionOcupacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionOcupacion = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Obs = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionesOcupacions", x => x.IdFuncionOcupacion)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "IngresosContribuyente",
                columns: table => new
                {
                    IdIngresoContribuyente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngresoContribuyente = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Obs = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresosContribuyente", x => x.IdIngresoContribuyente)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "NivelesEscolarizacions",
                columns: table => new
                {
                    IdNivelEscolarizacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelEscolarizacion = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Obs = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelesEscolarizacions", x => x.IdNivelEscolarizacion)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Ocupaciones",
                columns: table => new
                {
                    IdOcupacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocupacion = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Obs = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocupaciones", x => x.IdOcupacion)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "TiposContribuyentes",
                columns: table => new
                {
                    IdTipoContribuyente = table.Column<int>(nullable: false),
                    TipoContribuyente = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposContribuyentes", x => x.IdTipoContribuyente);
                });

            migrationBuilder.CreateTable(
                name: "TiposDocumentos",
                columns: table => new
                {
                    IdTipoDocumento = table.Column<int>(nullable: false),
                    TipoDocumento = table.Column<string>(maxLength: 255, nullable: false),
                    Obs = table.Column<string>(maxLength: 50, nullable: true),
                    ValidaCUIT = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aaaaaTiposDocumentos_PK", x => x.IdTipoDocumento)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "TiposOcupacion",
                columns: table => new
                {
                    IdTipoOcupacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoOcupacion = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Obs = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposOcupacion", x => x.IdTipoOcupacion)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "ZonasColectores",
                columns: table => new
                {
                    IdZonaColector = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdColector = table.Column<int>(nullable: false),
                    Zona = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Obs = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZonasColectores", x => x.IdZonaColector);
                });

            migrationBuilder.CreateTable(
                name: "Contribuyentes",
                columns: table => new
                {
                    IdContribuyente = table.Column<int>(nullable: false),
                    Apellido = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Nombre = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    IdTipoDocumento = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    NroDocumento = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Telefono = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "datetime", nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    idEstadoContribuyente = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    obs = table.Column<string>(unicode: false, nullable: true),
                    IdTipoContribuyente = table.Column<int>(nullable: true),
                    IdClasificaContribuyente = table.Column<int>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: true),
                    IdClasifImpresion = table.Column<int>(nullable: true),
                    CBU = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Celular = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IdOcupacion = table.Column<int>(nullable: true),
                    IdFuncionOcupacion = table.Column<int>(nullable: true),
                    IdTipoOcupacion = table.Column<int>(nullable: true),
                    SituacionLaboral = table.Column<int>(nullable: true),
                    AportesJubilatorios = table.Column<int>(nullable: true),
                    IdNivelEscolarizacion = table.Column<int>(nullable: true),
                    ContinuaEducacion = table.Column<bool>(nullable: true),
                    TipoEstablecimiento = table.Column<int>(nullable: true),
                    OtraCapacitacion = table.Column<string>(unicode: false, nullable: true),
                    IdFuenteFinanciamiento = table.Column<int>(nullable: true),
                    IdIngresoContribuyente = table.Column<int>(nullable: true),
                    IdCoberturaSocial = table.Column<int>(nullable: true),
                    Enfermedades = table.Column<string>(unicode: false, nullable: true),
                    Discapacidades = table.Column<string>(unicode: false, nullable: true),
                    Medicamentos = table.Column<string>(unicode: false, nullable: true),
                    Tratamientos = table.Column<string>(unicode: false, nullable: true),
                    IdZonaColector = table.Column<int>(nullable: true),
                    codcontri = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribuyentes", x => x.IdContribuyente);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_ClasifImpresion",
                        column: x => x.IdClasifImpresion,
                        principalTable: "ClasifImpresion",
                        principalColumn: "IdClasifImpresion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_ClasificaContribuyente",
                        column: x => x.IdClasificaContribuyente,
                        principalTable: "ClasificaContribuyente",
                        principalColumn: "IdClasificaContribuyente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_CoberturasSociales",
                        column: x => x.IdCoberturaSocial,
                        principalTable: "CoberturasSociales",
                        principalColumn: "IdCoberturaSocial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_EstadosContribuyentes",
                        column: x => x.idEstadoContribuyente,
                        principalTable: "EstadosContribuyentes",
                        principalColumn: "IdEstadoContribuyente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_FuentesFinanciamiento",
                        column: x => x.IdFuenteFinanciamiento,
                        principalTable: "FuentesFinanciamiento",
                        principalColumn: "IdFuenteFinanciamiento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_FuncionesOcupacion",
                        column: x => x.IdFuncionOcupacion,
                        principalTable: "FuncionesOcupacions",
                        principalColumn: "IdFuncionOcupacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_IngresosContribuyente",
                        column: x => x.IdIngresoContribuyente,
                        principalTable: "IngresosContribuyente",
                        principalColumn: "IdIngresoContribuyente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_NivelesEscolarizacion",
                        column: x => x.IdNivelEscolarizacion,
                        principalTable: "NivelesEscolarizacions",
                        principalColumn: "IdNivelEscolarizacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_Ocupaciones",
                        column: x => x.IdOcupacion,
                        principalTable: "Ocupaciones",
                        principalColumn: "IdOcupacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_TiposContribuyentes",
                        column: x => x.IdTipoContribuyente,
                        principalTable: "TiposContribuyentes",
                        principalColumn: "IdTipoContribuyente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_TiposDocumentos",
                        column: x => x.IdTipoDocumento,
                        principalTable: "TiposDocumentos",
                        principalColumn: "IdTipoDocumento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_TiposOcupacion",
                        column: x => x.IdTipoOcupacion,
                        principalTable: "TiposOcupacion",
                        principalColumn: "IdTipoOcupacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contribuyentes_ZonasColectores",
                        column: x => x.IdZonaColector,
                        principalTable: "ZonasColectores",
                        principalColumn: "IdZonaColector",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "det_ClasificacionUnico",
                table: "ClasificaContribuyente",
                column: "Clasificacion",
                unique: true,
                filter: "[Clasificacion] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClasificaContribuyente_PropioRentas",
                table: "ClasificaContribuyente",
                column: "PropioRentas");

            migrationBuilder.CreateIndex(
                name: "det_DescripcionUnica",
                table: "ClasifImpresion",
                column: "Descripcion",
                unique: true,
                filter: "[Descripcion] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdClasifImpresion",
                table: "Contribuyentes",
                column: "IdClasifImpresion");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdClasificaContribuyente",
                table: "Contribuyentes",
                column: "IdClasificaContribuyente");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdCoberturaSocial",
                table: "Contribuyentes",
                column: "IdCoberturaSocial");

            migrationBuilder.CreateIndex(
                name: "IdContribuyente",
                table: "Contribuyentes",
                column: "IdContribuyente");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdEstadoContribuyente",
                table: "Contribuyentes",
                column: "idEstadoContribuyente");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdFuenteFinanciamiento",
                table: "Contribuyentes",
                column: "IdFuenteFinanciamiento");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdFuncionOcupacion",
                table: "Contribuyentes",
                column: "IdFuncionOcupacion");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdIngresoContribuyente",
                table: "Contribuyentes",
                column: "IdIngresoContribuyente");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdNivelEscolarizacion",
                table: "Contribuyentes",
                column: "IdNivelEscolarizacion");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdOcupacion",
                table: "Contribuyentes",
                column: "IdOcupacion");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdTipoContribuyente",
                table: "Contribuyentes",
                column: "IdTipoContribuyente");

            migrationBuilder.CreateIndex(
                name: "ContribuyentesIdTipoDocumento",
                table: "Contribuyentes",
                column: "IdTipoDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdTipoOcupacion",
                table: "Contribuyentes",
                column: "IdTipoOcupacion");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdZonaColector",
                table: "Contribuyentes",
                column: "IdZonaColector");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdContribuyenteIdEstadoContribuyente",
                table: "Contribuyentes",
                columns: new[] { "IdContribuyente", "idEstadoContribuyente" });

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdContribIdTipoIdClasifica",
                table: "Contribuyentes",
                columns: new[] { "IdContribuyente", "IdTipoContribuyente", "IdClasificaContribuyente" });

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdContribuyenteIdEstadoIdTipoIdClasifica",
                table: "Contribuyentes",
                columns: new[] { "IdContribuyente", "idEstadoContribuyente", "IdTipoContribuyente", "IdClasificaContribuyente" });

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdContribuyenteApellidoNombreIdEstadoContribuyenteIdTipoContribuyenteIdClasificaContribuyente",
                table: "Contribuyentes",
                columns: new[] { "IdContribuyente", "Apellido", "Nombre", "idEstadoContribuyente", "IdTipoContribuyente", "IdClasificaContribuyente" });

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdContribuyenteApellidoNombreIdTipoDocumentoIdEstadoContribuyenteIdTipoContribuyenteIdClasificaContribuyente",
                table: "Contribuyentes",
                columns: new[] { "IdContribuyente", "Apellido", "Nombre", "IdTipoDocumento", "idEstadoContribuyente", "IdTipoContribuyente", "IdClasificaContribuyente" });

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_IdContribuyenteApellidoNombreIdTipoDocumentoNroDocumentoIdEstadoContribuyenteIdClasificaContribuyente",
                table: "Contribuyentes",
                columns: new[] { "IdContribuyente", "Apellido", "Nombre", "IdTipoDocumento", "NroDocumento", "idEstadoContribuyente", "IdClasificaContribuyente" });

            migrationBuilder.CreateIndex(
                name: "det_EstadoContribuyenteUnico",
                table: "EstadosContribuyentes",
                column: "Estado",
                unique: true,
                filter: "[Estado] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "det_TipoContribuyenteUnico",
                table: "TiposContribuyentes",
                column: "TipoContribuyente",
                unique: true,
                filter: "[TipoContribuyente] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IdCalle",
                table: "TiposDocumentos",
                column: "IdTipoDocumento");

            migrationBuilder.CreateIndex(
                name: "TiposDocumentosTipoDocumento",
                table: "TiposDocumentos",
                column: "TipoDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_TiposDocumentos_IdTipoDocumentoTipoDocumento",
                table: "TiposDocumentos",
                columns: new[] { "IdTipoDocumento", "TipoDocumento" });

            migrationBuilder.CreateIndex(
                name: "det_zonaColectorUnico",
                table: "ZonasColectores",
                column: "Zona",
                unique: true,
                filter: "[Zona] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contribuyentes");

            migrationBuilder.DropTable(
                name: "ClasifImpresion");

            migrationBuilder.DropTable(
                name: "ClasificaContribuyente");

            migrationBuilder.DropTable(
                name: "CoberturasSociales");

            migrationBuilder.DropTable(
                name: "EstadosContribuyentes");

            migrationBuilder.DropTable(
                name: "FuentesFinanciamiento");

            migrationBuilder.DropTable(
                name: "FuncionesOcupacions");

            migrationBuilder.DropTable(
                name: "IngresosContribuyente");

            migrationBuilder.DropTable(
                name: "NivelesEscolarizacions");

            migrationBuilder.DropTable(
                name: "Ocupaciones");

            migrationBuilder.DropTable(
                name: "TiposContribuyentes");

            migrationBuilder.DropTable(
                name: "TiposDocumentos");

            migrationBuilder.DropTable(
                name: "TiposOcupacion");

            migrationBuilder.DropTable(
                name: "ZonasColectores");
        }
    }
}
