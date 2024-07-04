using System.ComponentModel.DataAnnotations;

namespace Dima.Core.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    [Required(ErrorMessage = "Título Inválido")]
    [MaxLength(80,ErrorMessage = "O título deve ter no máximo 80 caracteres")]
    public string Title { get; set; } = string.Empty;
        
    [Required(ErrorMessage = "Description Inválido")]
    public string Description { get; set; } = string.Empty;
}