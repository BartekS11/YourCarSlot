using MediatR;
using YourCarSlot.Application.Logging;

namespace YourCarSlot.Application.Behaviors;

public sealed class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : class
{
    private readonly IAppLogger<LoggingBehavior<TRequest, TResponse>> _logger;

    public LoggingBehavior(IAppLogger<LoggingBehavior<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"{GetType().Name} is beign processed");

        var response = await next();

        _logger.LogInformation($"{GetType().Name} was processed successfuly");

        return response;
    }
}
