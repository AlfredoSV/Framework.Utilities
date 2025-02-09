using Framework.Utilities202.Entities;

namespace Framework.Utilities.IServices
{
    public interface IServiceLogBook
    {
        Task SaveWarningLog(LogBook logBook);

        Task SaveErrorLog(LogBook logBook);
        
        Task SaveErrorLog(Exception exception);
        
        Task SaveInformationLog(LogBook logBook);

        Task SaveCustomLog(Guid id, string classEx, string method, string message, ErrorType errorType);
    }
}
