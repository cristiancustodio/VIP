using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Model
{
    public class AudiometerModel
    {
        [Required(ErrorMessage = "Descrição obrigatória")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Data de Calibração obrigatória")]
        public DateTime? DataCalibracao { get; set; }

        [Required(ErrorMessage = "Data de Aferição obrigatória")]
        public DateTime? DataAfericao { get; set; }
    }
}
