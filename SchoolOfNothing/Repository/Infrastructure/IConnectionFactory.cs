namespace SchoolOfNothing.Repository.Infrastructure
{
    public interface IConnectionFactory
    {
        System.Data.IDbConnection GetConnection();
    }
}
