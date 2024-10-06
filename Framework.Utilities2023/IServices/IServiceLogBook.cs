using Framework.Utilities202.Entities;

namespace Framework.Utilities2023.IServices
{
    public interface IServiceLogBook
    {
        void SaveWarningLog(LogBook logBook);
        void SaveErrorLog(LogBook logBook);
        void SaveInformationLog(LogBook logBook);
    }
}
