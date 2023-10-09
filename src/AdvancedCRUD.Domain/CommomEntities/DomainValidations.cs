namespace AdvancedCRUD.Domain.CommomEntities
{
    public class DomainValidations
    {
        public static void ValidateIfNotNull(string value, string message)
        {
            if (value == null)
                throw new DomainExceptions(message);
        }
        public static void ValidateIfNotNull(object objeto, string message)
        {
            if (objeto == null)
                throw new DomainExceptions(message);
        }

        public static void ValidateIfNotEmpty(string value, string message)
        {
            if (value == "")
                throw new DomainExceptions(message);
        }

        public static void ValidateIfIsNotNullOrEmpty(string value, string message)
        {
            ValidateIfNotEmpty(value, message);
            ValidateIfNotNull(value, message);
        }

        public static void ValidateIfBiggerThan(decimal value, decimal expectedValue, string message)
        {
            if (value < expectedValue)
                throw new DomainExceptions(message);
        }

        public static void ValidateIfBiggerOrEqualThen(decimal value, decimal expectedValue, string message)
        {
            if (value < expectedValue)
                throw new DomainExceptions(message);
        }

        public static void ValidateIfLessOrEqual(decimal value, decimal valueMaximo, string message)
        {
            if (value >= valueMaximo)
                throw new DomainExceptions(message);
        }

        public static void ValidateIfTrue(bool value, string message)
        {
            if (!value)
                throw new DomainExceptions(message);
        }
    }
}
