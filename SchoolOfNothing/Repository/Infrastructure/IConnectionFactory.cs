namespace SchoolOfNothing.repository.Infrastructure
{
    public interface IConnectionFactory
    {
        System.Data.IDbConnection GetConnection();
    }
}
