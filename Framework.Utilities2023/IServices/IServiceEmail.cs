using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utilities2023.Email.IServices
{
    public  interface IServiceEmail
    {
        void SendEmail(string email, string emailTo,
            Guid idBodyEmail, Dictionary<string, string> paramsBody);

        string GenerateBody(Guid idTemplate);
    }
}
