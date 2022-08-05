using Microsoft.EntityFrameworkCore.Migrations;

namespace ENTITIES.Migrations
{
    public partial class StoredProcedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
				@"CREATE PROCEDURE [dbo].[sp_NotificadosDevuelveDatosConsultaNotificadosPaginado]
						--Para el paginado
						@start int,
						@pageSize int

						AS
						BEGIN
							-- SET NOCOUNT ON added to prevent extra result sets from
							-- interfering with SELECT statements.
							SET NOCOUNT ON;


						Select N.IdNotificado,N.FechaNotificacion, vC.ApellidoNombre, A.IdCuenta, T.TyC, isnull(T1.Debe,0) as ImporteNeto, isnull(T1.Total,0) as ImporteTotal,
										  N.Interes, N.FechaAlcance, N.Obs, N.NroNotificacion, N.Entregado

								From Notificados N JOIN Asignaciones A ON A.IdCuenta = N.IdCuenta
											   JOIN vContribuyentes vC ON A.IdContribuyente = vC.IdContribuyente
											   JOIN TyC T ON T.IdTyC = N.IdTyC
											   LEFT JOIN Inmueble I ON I.IdCuenta = N.IdCuenta
											LEFT JOIN (
											Select sum(dbo.funDevuelveDebexIdCtaCte (C.IdCtaCte, getdate())) as Debe, sum(dbo.funDevuelveDebexIdCtaCte		(C.IdCtaCte, getdate()) + ( dbo.funDevuelveDebexIdCtaCte (C.IdCtaCte, getdate()) *					     dbo.funDevuelveAlicuotaxIdCtaCte (C.IdCtaCte, N.FechaNotificacion) / 100 )) as Total , DN.IdNotificado, C.Idcuenta
											from Ctacte C JOIN DetalleNotificaciones DN ON DN.IdCtaCte = C.IdCtaCte
																		  JOIN notificados N ON N.IdNotificado = DN.IdNotificado
															group by DN.IdNotificado, C.IdCuenta
														   ) T1 ON T1.IdNotificado = N.IdNotificado and T1.IdCuenta= N.IdCuenta


									order by VC.Apellido
								OFFSET 2 ROWS FETCH NEXT 10 ROWS ONLY;
		END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("DROP PROCEDURE dbo.sp_NotificadosDevuelveDatosConsultaNotificadosPaginado");

		}
    }
}
