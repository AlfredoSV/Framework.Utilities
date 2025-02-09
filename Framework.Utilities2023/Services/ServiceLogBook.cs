
using Framework.Utilities202.Entities;
using Framework.Utilities.IServices;
using Framework.Utilities.Repository;

namespace Framework.Utilities.Log.Services { 

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

        public async Task SaveCustomLog(Guid id, string classEx, string method, string message, ErrorType errorType)
        {
            LogBook logBook = LogBook.Create(classEx, method, message);
            logBook.Id = id;    
            logBook.Type = errorType;
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
