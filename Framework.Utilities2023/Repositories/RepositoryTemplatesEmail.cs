using Framework.Utilities.Entities;
using System.Data.SqlClient;

namespace Framework.Utilities.Repositories
{
    public class RepositoryTemplatesEmail
    {
        private readonly string _sqlStr;

        public RepositoryTemplatesEmail(ConnectionStrUtilities connectionStrUtilities)
        {
            _sqlStr = connectionStrUtilities.StrConnectionFrameworkUtilities;
        }

        public TemplateEmail GetByid(Guid idTemplate)
        {
            TemplateEmail template = default!;
            try
            {
                string insertStr = @"Select id, name, body, CreatedAt from TemplateEmail
                                where Id = @id";

                SqlDataReader sqlDataReader = default!;
                using (SqlConnection sqlConnection = new SqlConnection(_sqlStr))
                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandText = insertStr;
                    cmd.Parameters.AddWithValue("id", idTemplate);

                    sqlDataReader = cmd.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Read();

                        template = TemplateEmail.Create(sqlDataReader.GetGuid(0),
                            sqlDataReader.GetString(1), sqlDataReader.GetString(2),
                            sqlDataReader.GetDateTime(3));

                    }

                }
            }
            catch (Exception)
            {
                throw;
            }

            return template;
        }
    }
}
