using FluentMigrator;

namespace SchoolOfNothing.repository.Migrations
{
    [Migration(3)]
    public class ThirdMigration : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {

            Create.Table("classroom").InSchema("demographics")

            .WithColumn("id").AsGuid().PrimaryKey().Unique().NotNullable()

            .WithColumn("number").AsString().NotNullable();
        }
    }
}
