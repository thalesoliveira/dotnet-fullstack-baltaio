
using Dima.Api.Data;
using Dima.Core.Handlers;
using Dima.Core.Models;
using Dima.Core.Requests.Categories;
using Dima.Core.Responses;

namespace Dima.Api.Handlers
{
    public class CategoryHandler(AppDbContext context) : ICategoryHandler
    {
        public async Task<Response<Category?>> CreateAsync(CreateCategoryRequest request)
        {
            try
            {
                var category = new Category
                {
                    UseID = request.UserId,
                    Title = request.Title,
                    Description = request.Description
                };


                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();

                return new Response<Category?>(category, 201, "Categoria criada com sucesso!");

            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Falha ao cria categoria");
            }

        }

        public Task<Response<Category?>> DeleteAsync(DeleteCategoryResquest request)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Category?>> GetAllAsync(GetAllCategoryRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResponse<List<Category>>> GetByIdAsync(GetCategoryByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}