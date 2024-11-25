using Framework.Utilities202.Entities;

namespace Framework.Utilities2023.IServices
{
    public interface IServiceLogBook
    {
        Task SaveWarningLog(LogBook logBook);

        Task SaveErrorLog(LogBook logBook);
        
        Task SaveErrorLog(Exception exception);
        
        Task SaveInformationLog(LogBook logBook);
    }
}
