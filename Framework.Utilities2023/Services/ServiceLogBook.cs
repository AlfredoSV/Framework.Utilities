
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

        public void SaveErrorLog(LogBook logBook)
        {
            logBook.Type = ErrorType.Error;
            _repositoryLogBook.Save(logBook);
        }

        //public void SaveErrorLog(Exception ex)
        //{
        //    LogBook logBook = LogBook.Create(ex.StackTrace.)
        //    logBook.Type = ErrorType.Error;
        //    _repositoryLogBook.Save(logBook);
        //}

        public void SaveInformationLog(LogBook logBook)
        {
            logBook.Type = ErrorType.Information;
            _repositoryLogBook.Save(logBook);
        }

        public void SaveWarningLog(LogBook logBook)
        {
            logBook.Type = ErrorType.Warning;
            _repositoryLogBook.Save(logBook);
        }
    }
}
