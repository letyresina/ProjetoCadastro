using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace ProjetoCadastro.Models
{
    public class Produto
    {
        [Range(0, 1000, ErrorMessage = "Números acima de 0, menores que 1000.")]
        public int CodProd { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string Nome { get; set; }

        [StringLength(60, MinimumLength = 10, ErrorMessage = "Insira de 10 a 60 caracteres.")]
        public string DescrProd { get; set; }

        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage="Valor Inválido")]
        public string PesoProd { get; set; }

        [StringLength(50, MinimumLength = 10, ErrorMessage = "Insira de 10 a 50 caracteres.")]
        public string CategProd { get; set; }

        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Valor Inválido")]
        public string VlrUnit { get; set; }

    }
}