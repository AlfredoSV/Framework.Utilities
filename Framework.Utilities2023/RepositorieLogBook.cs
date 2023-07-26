

using Framework.Sql2023;
using Framework.Utilities2023.Log;

namespace Framework.Utilities2023
{
    public class RepositorieLogBook
    {
        public readonly SqlDB<LogBook> sqlDb;

        public RepositorieLogBook()
        {
            this.sqlDb = new SqlDB<LogBook>("");
        }


    }
}
