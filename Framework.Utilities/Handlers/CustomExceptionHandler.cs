using Framework.Utilities.IServices;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Framework.Utilities.Email.Handlers;

public class CustomExceptionHandler : IExceptionHandler
{
    private readonly IServiceLogBook serviceLogBook;

    public CustomExceptionHandler(IServiceLogBook serviceLogBook)
    {
        this.serviceLogBook = serviceLogBook;
    }
    public  ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        var error = exception;

        this.serviceLogBook.SaveErrorLog(error);

        return ValueTask.FromResult(true);
    }
}