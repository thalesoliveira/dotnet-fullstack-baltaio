
using Dima.Api.Common.Api;
using Dima.Api.Endpoints.Categories;
using Dima.Api.Endpoints.Transactions;

namespace Dima.Api.Endpoints
{
    public static class Endpoint
    {

        //Extension Method
        public static void MapEndPoints(this WebApplication app)
        {
            var endpoints = app
            .MapGroup("");

            endpoints.MapGroup("v1/categories")
            .WithTags("Categories")
            .MapEndpoint<CreateCategoryEndpoint>()
            .MapEndpoint<UpdateCategoryEndpoint>()
            .MapEndpoint<DeleteCategoryEndpoint>()
            .MapEndpoint<GetCategoryByIdEndpoint>()
            .MapEndpoint<GetAllCategoriesEndpoint>();

            endpoints.MapGroup("v1/transactions")
            .WithTags("Transactions")
            .MapEndpoint<CreateTransactionEndpoint>()
            .MapEndpoint<UpdateTransactionEndpoint>()
            .MapEndpoint<DeleteTransactionEndpoint>()
            .MapEndpoint<GetTransactionByIdEndpoint>()
            .MapEndpoint<GetTransactionsByPeriodEndpoint>();

        }



        private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder app)
        where TEndpoint : IEndpoint
        {
            TEndpoint.Map(app);
            return app;
        }

    }
}