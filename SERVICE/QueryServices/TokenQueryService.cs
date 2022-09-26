using DATA_ACCESS.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SERVICE.QueryServices
{
    public interface ITokenQueryService
    {
        string getTokenUser(string token);

    }
    public class TokenQueryService : ITokenQueryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _config;

        public TokenQueryService(IUnitOfWork unitOfWork, IConfiguration config)
        {
            _unitOfWork = unitOfWork;
            _config = config;
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

        public string getTokenUser(string token)
        {
            SqlConnection conn = (SqlConnection)_unitOfWork._context.Database.GetDbConnection();
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_GetToken";
            cmd.Parameters.Add("@Token", System.Data.SqlDbType.VarChar).Value = token;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();

            var tokenNuevo = dt.AsEnumerable();

            var exiteToken = tokenNuevo.Select(s=> s.ItemArray);

            var listaNueva = exiteToken.ToList();

            var tokenUnico = listaNueva[0].GetValue(0).ToString();

            return tokenUnico;
        }
    }
}
