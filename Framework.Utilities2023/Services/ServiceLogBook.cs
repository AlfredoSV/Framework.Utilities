
using Framework.Utilities202.Entities;
using Framework.Utilities2023.Repository;

namespace Framework.Utilities2023.Log.Services { 
    public class ServiceLogBook
    {
        private readonly RepositoryLogBook _repositoryLogBook;

        public ServiceLogBook()
        {
            _repositoryLogBook = new RepositoryLogBook();
        }
        
        public void SaveLog(LogBook logBook)
        {
            _repositoryLogBook.Save(logBook);
        }
    }
}
