using DATA;
using DATA_ACCESS.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using DATA.Errors;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace SERVICE.QueryServices
{
    public interface IUsuariosQueryService
    {
        ActionResult<GetResponse> GetUsuariosRentas(string usuario, string clave);
    }
    public class UsuariosQueryService : IUsuariosQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsuariosQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult<GetResponse> GetUsuariosRentas(string usuario, string clave)
        {
            var usuariosQuery = new UsuariosQueryService(_unitOfWork);
            var claveHasheada = MD5Hash(clave);
            
            SqlConnection conn = (SqlConnection)_unitOfWork._context.Database.GetDbConnection();
            SqlCommand cmd = conn.CreateCommand();            
            conn.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_UsuariosRentas";
            cmd.Parameters.Add("@usuario", System.Data.SqlDbType.VarChar).Value = usuario;
            //cmd.Parameters.Add("@clave", System.Data.SqlDbType.VarChar).Value = claveHasheada; no pasarlo y recibirlo por dt y al mappearlo comparar las claves.
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            var listaProduct = (from row in dt.AsEnumerable()
                                select new UsuariosDTO()
                                {
                                    Usuario = row["Usuario"].ToString(),
                                    Clave = row["Clave"].ToString(),
                                }).ToList();
            
            try
            {
                if (listaProduct.Count == 0)
                {
                    throw new EmptyCollectionException("Usuario no encontrado");
                }
                foreach (var claveUsuario in listaProduct)
                {
                    if (claveUsuario.Clave != claveHasheada || claveHasheada is null)
                    {
                        throw new EmptyCollectionException("Contraseña Incorrecta");

                    }
                    if (claveUsuario.Usuario != usuario || usuario is null)
                    {

                        throw new EmptyCollectionException("Usuario Incorrecto");

                    }
                    if (claveUsuario.Clave == claveHasheada && claveUsuario.Usuario == usuario)
                    {
                        return new GetResponse()
                        {
                            StatusCode = (int)HttpStatusCode.OK,
                            Message = "success",
                            Result = listaProduct
                        };
                    }
                    

                }
            }
            catch(EmptyCollectionException ex)
            {
                return new GetResponse()
                {
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Message = ex.ToString(),
                    Result = null
                };
            }

            return new GetResponse()
            {
                StatusCode = (int)HttpStatusCode.MultiStatus,
                Message = "Usuario o contraseña invalidos",
                Result = null
            };



        }
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
