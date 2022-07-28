using FluentMigrator;

namespace SchoolOfNothing.Repository.Migrations
{
    [Migration(2)]
    public class SecondMigration : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {

            Create.Table("teacher").InSchema("demographics")

            .WithColumn("id").AsGuid().PrimaryKey().Unique().NotNullable()

            .WithColumn("firstname").AsString().NotNullable()

            .WithColumn("lastname").AsString().NotNullable();
        }
    }
}
