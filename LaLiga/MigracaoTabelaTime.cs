using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLiga
{
    [Migration(20230904)]
    public class MigracaoTabelaTime : Migration
    {
        public override void Up()
        {
            const int tamanhoDaColuna = 18888;
            Create.Table("Times")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("NomeDoTime").AsString().NotNullable()
                .WithColumn("DataFundacao").AsDate().NotNullable()
                .WithColumn("Imagem_Time").AsString(tamanhoDaColuna).Nullable();
        }

        public override void Down()
        {
            Delete.Table("Times");
        }
    }
}
