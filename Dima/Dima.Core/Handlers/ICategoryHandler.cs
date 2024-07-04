using Dima.Core.Models;
using Dima.Core.Requests.Categories;
using Dima.Core.Responses;

namespace Dima.Core.Handlers;

public interface ICategoryHandler
{
    Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
    Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
    Task<Response<Category?>> DeleteAsync(DeleteCategoryResquest request);
    Task<Response<Category?>> GetAllAsync(GetAllCategoryRequest request);
    Task<PagedResponse<List<Category>>> GetByIdAsync(GetCategoryByIdRequest request);
}