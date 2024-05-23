namespace AuthApi.Exceptions
{
    namespace AuthApi.Exceptions
    {
        public class RepositoryExceptions : Exception
        {
            public RepositoryExceptions(string message) : base(message)
            {
            }
        }

        public class EntityNotFoundException : RepositoryExceptions
        {
            public EntityNotFoundException(string message) : base(message)
            {
            }
        }
    }
}
