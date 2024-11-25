
using Framework.Utilities202.Entities;
using Framework.Utilities2023.IServices;
using Framework.Utilities2023.Repository;

namespace Framework.Utilities2023.Log.Services { 

    public class ServiceLogBook : IServiceLogBook
    {
        private readonly RepositoryLogBook _repositoryLogBook;

        public ServiceLogBook(RepositoryLogBook repositoryLogBook)
        {
            _repositoryLogBook = repositoryLogBook;
        }

        public async Task SaveErrorLog(LogBook logBook)
        {
            logBook.Type = ErrorType.Error;
            await _repositoryLogBook.Save(logBook);
        }

        public async Task SaveErrorLog(Exception ex)
        {
            LogBook logBook = LogBook.Create(ex.TargetSite.Name, ex.TargetSite.MethodHandle.Value.ToString(), $"{ex.Message}-{ex.StackTrace}"); 
            logBook.Type = ErrorType.Error;
            await _repositoryLogBook.Save(logBook);
        }

        public async Task SaveInformationLog(LogBook logBook)
        {
            logBook.Type = ErrorType.Information;
            await _repositoryLogBook.Save(logBook);
        }

        public async Task SaveWarningLog(LogBook logBook)
        {
            logBook.Type = ErrorType.Warning;
            await _repositoryLogBook.Save(logBook);
        }
    }
}
