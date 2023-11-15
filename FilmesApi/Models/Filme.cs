using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Required(ErrorMessage = "O titulo do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O titulo só pode ter no maximo 50 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O genero do filme é obrigatório")]
    [MaxLength(20, ErrorMessage = "O genero só pode ter no maximo 20 caracteres")]
    public string Genero {  get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatório")]
    [Range(70, 600, ErrorMessage = "A Duração deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
