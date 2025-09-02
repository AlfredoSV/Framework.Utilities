namespace Framework.Utilities.Email.IServices
{
    public  interface IServiceEmail
    {
        Task SendEmailAsync(string email, string emailTo,
            int idBodyEmail, Dictionary<string, string> paramsBody);
    }
}
