using Framework.Utilities.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Framework.Utilities.Repository
{
    public class RepositoryLogBook
    {
        private readonly string _sqlStr;

        public RepositoryLogBook(ConnectionStrUtilities connectionStrUtilities)
        {
            _sqlStr = connectionStrUtilities.StrConnectionFrameworkUtilities;
        }

        public async Task SaveAsync(LogBook book)
        {
            try
            {
                string insertStr = @"INSERT INTO LogBook VALUES(@id, @class, @method, @type, @message, @createdAt);";

                SqlParameter[] parameters = new SqlParameter[6];
                (parameters[0] = new SqlParameter("@id", SqlDbType.UniqueIdentifier)).Value = book.Id;
                (parameters[1] = new SqlParameter("@class", SqlDbType.NVarChar)).Value = book.Class;
                (parameters[2] = new SqlParameter("@method", SqlDbType.NVarChar)).Value = book.Method;
                (parameters[3] = new SqlParameter("@type", SqlDbType.NVarChar)).Value = book.Type;
                (parameters[4] = new SqlParameter("@message", SqlDbType.NVarChar)).Value = book.Message;
                (parameters[5] = new SqlParameter("@createdAt", SqlDbType.DateTime)).Value = book.CreatedAt;

                using (SqlConnection sqlConnection = new SqlConnection(_sqlStr))
                {
                    await sqlConnection.OpenAsync();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandText = insertStr;
                    cmd.Parameters.AddRange(parameters);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }       
        }
    }
}
