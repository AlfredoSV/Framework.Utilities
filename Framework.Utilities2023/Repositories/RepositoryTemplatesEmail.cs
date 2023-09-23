using Framework.Utilities2023.Entities;
using System;
using System.Data.SqlClient;

namespace Framework.Utilities2023.Repositories
{
    public class RepositoryTemplatesEmail
    {
        private readonly string _sqlStr;

        public RepositoryTemplatesEmail()
        {
            _sqlStr = ConnectionStrUtilities.Instance.StrConnectionFrameworkUtilities;
        }

        public TemplateEmail GetByid(Guid idTemplate)
        {
            string insertStr = @"Select Id, NameTemplate, BodyTemplate, DateCreated from TemplateEmail
                                where Id = @idTemplate";
            TemplateEmail template = null;

            SqlDataReader sqlDataReader = null;
            using (SqlConnection sqlConnection = new SqlConnection(_sqlStr))
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = insertStr;
                cmd.Parameters.AddWithValue("idTemplate", idTemplate);

                sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();

                    template = TemplateEmail.Create(sqlDataReader.GetGuid(0),
                        sqlDataReader.GetString(1), sqlDataReader.GetString(2),
                        sqlDataReader.GetDateTime(3));

                }

            }

            return template;
        }
    }
}
