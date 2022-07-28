using FluentMigrator;

namespace SchoolOfNothing.repository.Migrations
{
    [Migration(1)]
    public class InitialMigration : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {
            Create.Schema("demographics");

            Create.Table("student").InSchema("demographics")

            .WithColumn("id").AsGuid().PrimaryKey().Unique().NotNullable()

            .WithColumn("firstname").AsString().NotNullable()

            .WithColumn("lastname").AsString().NotNullable()

            .WithColumn("birthdate").AsDateTime().NotNullable();
        }
    }
}
