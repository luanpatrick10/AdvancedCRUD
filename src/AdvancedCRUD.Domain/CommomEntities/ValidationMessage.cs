namespace AdvancedCRUD.Domain.CommomEntities
{
    public class ValidationMessage
    {
        public static string PropertyNull(string propertyName)
        {
            return $"A propriedade {propertyName} não pode ser nula.";
        }

        public static string PropertyBiggerThanMaxValue(string propertyName)
        {
            return $"A propriedade {propertyName} não pode ser maior que seu limite.";
        }

        public static string PropertySmallerThanMinimumValue(string propertyName)
        {
            return $"A propriedade {propertyName} não pode ser menor que seu valor minimo.";
        }
        public static string CpfInvalido = "Cpf inválido.";
        public static string InvalidProperty(string propertyName)
        {
            return $"Propriedade {propertyName} inválida.";
        }

        public static string PropertyNullOrEmpty = "Essa propriedade não pode ser nula ou vazia.";
        public static string ObjectRegistred = "Esse objeto já está cadastrado.";
        public static string ObjectRegistredWithThisName(string nomeDoObjeto) => $"Já existe um {nomeDoObjeto} com esse nome.";

    }
}
