using EspacoCar.Api.Models;
using Flunt.Validations;

namespace EspacoCar.Api.validators
{
    public class ValidacaoDeCategoria : Contract<Categoria>
    {
        public ValidacaoDeCategoria(Categoria categoria)
        {
            Requires()
                .IsNotNullOrEmpty(categoria.Nome, "Nome", "O nome da categoria deve ser informado")
                .IsLowerThan(categoria.Nome, 50, "Nome", "O nome da categoria deve ter no maximo 50 caracteres");
        }
    }
}