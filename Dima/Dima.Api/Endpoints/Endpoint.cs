
using Dima.Api.Common.Api;
using Dima.Api.Endpoints.Categories;

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

        }

        private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder app)
        where TEndpoint : IEndpoint
        {
            TEndpoint.Map(app);
            return app;
        }

    }
}