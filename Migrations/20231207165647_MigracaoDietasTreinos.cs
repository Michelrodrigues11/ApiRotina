using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiRotina.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoDietasTreinos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_DIETAS",
                columns: table => new
                {
                    IdDieta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alimentos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Refeicoes = table.Column<int>(type: "int", nullable: false),
                    Nutrientes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DietaClass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DIETAS", x => x.IdDieta);
                });

            migrationBuilder.CreateTable(
                name: "TB_TREINOS",
                columns: table => new
                {
                    IdTreino = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Exercicios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TreinoClass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TREINOS", x => x.IdTreino);
                });

            migrationBuilder.InsertData(
                table: "TB_DIETAS",
                columns: new[] { "IdDieta", "Alimentos", "Dia", "DietaClass", "Nutrientes", "Refeicoes" },
                values: new object[,]
                {
                    { 1, " Refeição 1:Ovos mexidos (6 claras e 2 gemas), Aveia (50g) e Banana (1 unidade), Refeição 2: Peito de frango grelhado (150g)Arroz integral (100g)Brócolis cozido (100g), Refeição 3 (pré-treino):Batata doce (150g), Peito de frango grelhado (150g), Salada de folhas verdes (alface, rúcula, espinafre) com azeite de oliva, Refeição 4 (pós-treino):Whey protein (30g) com águaBanana (1 unidade).", "Domingo", 1, "Proteína: 180g, Carboidratos: 177g, Gordura: 20g e Fibras: 21g", 4 },
                    { 2, "Refeição 1: 2 ovos cozidos, 1 xícara de leite, 1 fatia de pão integral, 1 banana, Refeição 2: 100 g de frango grelhado, 200 g de arroz integral, 100 g de legumes cozidos, Refeição 3: 150 g de iogurte natural, 100 g de frutas, Refeição 4: 200 g de peixe grelhado, 300 g de batata doce assada, 100 g de legumes cozidos.", "Segunda", 2, "200 g de Proteína, 350 g de Carboidratos, 80 g de Gorduras", 4 },
                    { 3, "Refeição 1: 1 xícara de mingau de aveia com frutas e castanhas, Refeição 2: 200 g de carne moída magra, 250 g de macarrão integral, 100 g de legumes cozidos, Refeição 3: 100 g de pão integral com pasta de amendoim, Refeição 4: 150 g de frango desfiado, 300 g de batata inglesa cozida, 100 g de legumes cozidos.", "Terça", 3, "200 g de Proteína, 350 g de Carboidratos, 80 g de Gorduras", 4 },
                    { 4, " Refeição 1:Ovos mexidos (6 claras e 2 gemas), Aveia (50g) e Banana (1 unidade), Refeição 2: Peito de frango grelhado (150g)Arroz integral (100g)Brócolis cozido (100g), Refeição 3 (pré-treino):Batata doce (150g), Peito de frango grelhado (150g), Salada de folhas verdes (alface, rúcula, espinafre) com azeite de oliva, Refeição 4 (pós-treino):Whey protein (30g) com águaBanana (1 unidade).", "Quarta", 4, "Proteína: 180g, Carboidratos: 177g, Gordura: 20g e Fibras: 21g", 4 },
                    { 5, "Refeição 1: 2 ovos cozidos, 1 xícara de leite, 1 fatia de pão integral, 1 banana, Refeição 2: 100 g de frango grelhado, 200 g de arroz integral, 100 g de legumes cozidos, Refeição 3: 150 g de iogurte natural, 100 g de frutas, Refeição 4: 200 g de peixe grelhado, 300 g de batata doce assada, 100 g de legumes cozidos.", "Quinta", 5, "200 g de Proteína, 350 g de Carboidratos, 80 g de Gorduras", 4 },
                    { 6, "Refeição 1: 1 xícara de mingau de aveia com frutas e castanhas, Refeição 2: 200 g de carne moída magra, 250 g de macarrão integral, 100 g de legumes cozidos, Refeição 3: 100 g de pão integral com pasta de amendoim, Refeição 4: 150 g de frango desfiado, 300 g de batata inglesa cozida, 100 g de legumes cozidos.", "Sexta", 6, "200 g de Proteína, 350 g de Carboidratos, 80 g de Gorduras", 4 },
                    { 7, "Refeição 1:Ovos mexidos (6 claras e 2 gemas), Aveia (50g) e Banana (1 unidade), Refeição 2: Peito de frango grelhado (150g)Arroz integral (100g)Brócolis cozido (100g), Refeição 3 (pré-treino):Batata doce (150g), Peito de frango grelhado (150g), Salada de folhas verdes (alface, rúcula, espinafre) com azeite de oliva, Refeição 4 (pós-treino):Whey protein (30g) com águaBanana (1 unidade).", "Sabado", 7, "Proteína: 180g, Carboidratos: 177g, Gordura: 20g e Fibras: 21g", 4 }
                });

            migrationBuilder.InsertData(
                table: "TB_TREINOS",
                columns: new[] { "IdTreino", "Exercicios", "TreinoClass" },
                values: new object[,]
                {
                    { 1, "Supino reto com halteres: 3 séries de 8-12 repetições, Rosca bíceps com halteres: 3 séries de 8-12 repetições, Agachamento com barra: 3 séries de 8-12 repetições, Leg press: 3 séries de 10-15 repetições, Remada curvada com halteres: 3 séries de 8-12 repetições, Tríceps francês com halteres: 3 séries de 8-12 repetições.", 1 },
                    { 2, "Agachamento com barra: 3 séries de 8-12 repetições, Leg press: 3 séries de 10-15 repetições, Leg extension: 3 séries de 10-15 repetições, Legcurl:3 séries de 10-15 repetições.", 2 },
                    { 3, "Elevação de panturrilha em pé: 3 séries de 15-20 repetições, Elevação de panturrilha sentado: 3 séries de 15-20 repetições, Elevação de panturrilha unilateral: 3 séries de 15-20 repetições para cada perna.", 3 },
                    { 4, "Rosca direta com halteres: 3 séries de 8-12 repetições, Rosca martelo com halteres: 3 séries de 8-12 repetições, Rosca concentrada com halteres: 3 séries de 8-12 repetições, Tríceps francês com halteres: 3 séries de 8-12 repetições, Tríceps pushdown: 3 séries de 10-15 repetições.", 4 },
                    { 5, "Agachamento com barra: 3 séries de 8-12 repetições, Leg press: 3 séries de 10-15 repetições, Leg extension: 3 séries de 10-15 repetições, Legcurl:3 séries de 10-15 repetições.", 5 },
                    { 6, "Supino reto com halteres: 3 séries de 8-12 repetições, Rosca bíceps com halteres: 3 séries de 8-12 repetições, Agachamento com barra: 3 séries de 8-12 repetições, Leg press: 3 séries de 10-15 repetições, Remada curvada com halteres: 3 séries de 8-12 repetições, Tríceps francês com halteres: 3 séries de 8-12 repetições.", 6 },
                    { 7, "Elevação de panturrilha em pé: 3 séries de 15-20 repetições, Elevação de panturrilha sentado: 3 séries de 15-20 repetições, Elevação de panturrilha unilateral: 3 séries de 15-20 repetições para cada perna.", 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_DIETAS");

            migrationBuilder.DropTable(
                name: "TB_TREINOS");
        }
    }
}
