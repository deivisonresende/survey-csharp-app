using System.ComponentModel.DataAnnotations;

namespace SurveyApp.Models
{
  public class SurveyResponse {
    [Required(ErrorMessage ="O campo Nome deve ser preenchido")]
    public string name { get; set; }
    [Required(ErrorMessage ="O campo email deve ser preenchido")]
    [EmailAddress(ErrorMessage ="O campo email não corresponde a um endereço válido")]
    public string email { get; set; }
    [Required(ErrorMessage ="O campo resposta deve ser preenchido")]
    public bool? accept { get; set; }
  }
}
