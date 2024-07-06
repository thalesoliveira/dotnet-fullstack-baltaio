using Dima.Api.Common.Api;
using Dima.Core;
using Dima.Core.Handlers;
using Dima.Core.Models;
using Dima.Core.Requests.Transactions;
using Dima.Core.Responses;

namespace Dima.Api.Endpoints.Transactions
{
    public class GetTransactionsByPeriodEndpoint : IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
        => app.MapGet("/", HandleAsync)
            .WithName("Transactions: Get All")
            .WithSummary("Recupera todas as transações")
            .WithDescription("Recuperar todas as transações")
            .WithOrder(5)
            .Produces<PagedResponse<List<Transaction>?>>();

        private static async Task<IResult> HandleAsync(
            ITransactionHandler handler,
            DateTime? startDate = null,
            DateTime? endDate = null,
            int pageNumber = Configuration.DefaultPageNumber,
            int pageSize = Configuration.DefaultPageSize)
        {
            var request = new GetTransactionsByPeriodRequest
            {
                UserId = "teste@balta.io",
                PageNumber = pageNumber,
                PageSize = pageSize,
                StartDate = startDate,
                EndDate = endDate
            };

            var result = await handler.GetByPeriodAsync(request);
            return result.IsSucess
                ? TypedResults.Ok(result)
                : TypedResults.BadRequest(result);
        }

    }
}