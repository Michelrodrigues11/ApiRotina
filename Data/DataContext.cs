using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiRotina.Models;
using ApiRotina.Models.Enuns;


namespace ApiRotina.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public DbSet<Dieta> TB_DIETAS { get; set; }
        public DbSet<Treino> TB_TREINOS { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dieta>().HasData
                (
                     new Dieta()
            {
                Dia = "Domingo",
                IdDieta = 1,
                Alimentos =
                    " Refeição 1:Ovos mexidos (6 claras e 2 gemas), Aveia (50g) e Banana (1 unidade), Refeição 2: Peito de frango grelhado (150g)Arroz integral (100g)Brócolis cozido (100g), Refeição 3 (pré-treino):Batata doce (150g), Peito de frango grelhado (150g), Salada de folhas verdes (alface, rúcula, espinafre) com azeite de oliva, Refeição 4 (pós-treino):Whey protein (30g) com águaBanana (1 unidade).",
                Refeicoes = 4,
                Nutrientes = "Proteína: 180g, Carboidratos: 177g, Gordura: 20g e Fibras: 21g",
                DietaClass = DietaEnum.Domingo
            },
            new Dieta()
            {
                Dia = "Segunda",
                IdDieta = 2,
                Alimentos = "Refeição 1: 2 ovos cozidos, 1 xícara de leite, 1 fatia de pão integral, 1 banana, Refeição 2: 100 g de frango grelhado, 200 g de arroz integral, 100 g de legumes cozidos, Refeição 3: 150 g de iogurte natural, 100 g de frutas, Refeição 4: 200 g de peixe grelhado, 300 g de batata doce assada, 100 g de legumes cozidos.",
                Refeicoes = 4,
                Nutrientes = "200 g de Proteína, 350 g de Carboidratos, 80 g de Gorduras",
                DietaClass = DietaEnum.Segunda
            },
            new Dieta()
            {
                Dia = "Terça",
                IdDieta = 3,
                Alimentos = "Refeição 1: 1 xícara de mingau de aveia com frutas e castanhas, Refeição 2: 200 g de carne moída magra, 250 g de macarrão integral, 100 g de legumes cozidos, Refeição 3: 100 g de pão integral com pasta de amendoim, Refeição 4: 150 g de frango desfiado, 300 g de batata inglesa cozida, 100 g de legumes cozidos.",
                Refeicoes = 4,
                Nutrientes = "200 g de Proteína, 350 g de Carboidratos, 80 g de Gorduras",
                DietaClass = DietaEnum.Terca
            },
            new Dieta()
            {
                Dia = "Quarta",
                IdDieta = 4,
                Alimentos = " Refeição 1:Ovos mexidos (6 claras e 2 gemas), Aveia (50g) e Banana (1 unidade), Refeição 2: Peito de frango grelhado (150g)Arroz integral (100g)Brócolis cozido (100g), Refeição 3 (pré-treino):Batata doce (150g), Peito de frango grelhado (150g), Salada de folhas verdes (alface, rúcula, espinafre) com azeite de oliva, Refeição 4 (pós-treino):Whey protein (30g) com águaBanana (1 unidade).",
                Refeicoes = 4,
                Nutrientes = "Proteína: 180g, Carboidratos: 177g, Gordura: 20g e Fibras: 21g",
                DietaClass = DietaEnum.Quarta
            },
            new Dieta()
            {
                Dia = "Quinta",
                IdDieta = 5,
                Alimentos = "Refeição 1: 2 ovos cozidos, 1 xícara de leite, 1 fatia de pão integral, 1 banana, Refeição 2: 100 g de frango grelhado, 200 g de arroz integral, 100 g de legumes cozidos, Refeição 3: 150 g de iogurte natural, 100 g de frutas, Refeição 4: 200 g de peixe grelhado, 300 g de batata doce assada, 100 g de legumes cozidos.",
                Refeicoes = 4,
                Nutrientes = "200 g de Proteína, 350 g de Carboidratos, 80 g de Gorduras",
                DietaClass = DietaEnum.Quinta
            },
            new Dieta()
            {
                Dia = "Sexta",
                IdDieta = 6,
                Alimentos = "Refeição 1: 1 xícara de mingau de aveia com frutas e castanhas, Refeição 2: 200 g de carne moída magra, 250 g de macarrão integral, 100 g de legumes cozidos, Refeição 3: 100 g de pão integral com pasta de amendoim, Refeição 4: 150 g de frango desfiado, 300 g de batata inglesa cozida, 100 g de legumes cozidos.",
                Refeicoes = 4,
                Nutrientes = "200 g de Proteína, 350 g de Carboidratos, 80 g de Gorduras",
                DietaClass = DietaEnum.Sexta
            },
            new Dieta()
            {
                Dia = "Sabado",
                IdDieta = 7,
                Alimentos = "Refeição 1:Ovos mexidos (6 claras e 2 gemas), Aveia (50g) e Banana (1 unidade), Refeição 2: Peito de frango grelhado (150g)Arroz integral (100g)Brócolis cozido (100g), Refeição 3 (pré-treino):Batata doce (150g), Peito de frango grelhado (150g), Salada de folhas verdes (alface, rúcula, espinafre) com azeite de oliva, Refeição 4 (pós-treino):Whey protein (30g) com águaBanana (1 unidade).",
                Refeicoes = 4,
                Nutrientes = "Proteína: 180g, Carboidratos: 177g, Gordura: 20g e Fibras: 21g",
                DietaClass = DietaEnum.Sabado
            }
                );

                modelBuilder.Entity<Treino>().HasData
                (
                new Treino() { IdTreino = 1, Exercicios = "Supino reto com halteres: 3 séries de 8-12 repetições, Rosca bíceps com halteres: 3 séries de 8-12 repetições, Agachamento com barra: 3 séries de 8-12 repetições, Leg press: 3 séries de 10-15 repetições, Remada curvada com halteres: 3 séries de 8-12 repetições, Tríceps francês com halteres: 3 séries de 8-12 repetições.", TreinoClass = TreinoEnum.Domingo },
                new Treino() { IdTreino = 2, Exercicios = "Agachamento com barra: 3 séries de 8-12 repetições, Leg press: 3 séries de 10-15 repetições, Leg extension: 3 séries de 10-15 repetições, Legcurl:3 séries de 10-15 repetições.", TreinoClass = TreinoEnum.Segunda },
                new Treino() { IdTreino = 3, Exercicios = "Elevação de panturrilha em pé: 3 séries de 15-20 repetições, Elevação de panturrilha sentado: 3 séries de 15-20 repetições, Elevação de panturrilha unilateral: 3 séries de 15-20 repetições para cada perna.", TreinoClass = TreinoEnum.Terca },
                new Treino() { IdTreino = 4, Exercicios = "Rosca direta com halteres: 3 séries de 8-12 repetições, Rosca martelo com halteres: 3 séries de 8-12 repetições, Rosca concentrada com halteres: 3 séries de 8-12 repetições, Tríceps francês com halteres: 3 séries de 8-12 repetições, Tríceps pushdown: 3 séries de 10-15 repetições.", TreinoClass = TreinoEnum.Quarta },
                new Treino() { IdTreino = 5, Exercicios = "Agachamento com barra: 3 séries de 8-12 repetições, Leg press: 3 séries de 10-15 repetições, Leg extension: 3 séries de 10-15 repetições, Legcurl:3 séries de 10-15 repetições.", TreinoClass = TreinoEnum.Quinta },
                new Treino() { IdTreino = 6, Exercicios = "Supino reto com halteres: 3 séries de 8-12 repetições, Rosca bíceps com halteres: 3 séries de 8-12 repetições, Agachamento com barra: 3 séries de 8-12 repetições, Leg press: 3 séries de 10-15 repetições, Remada curvada com halteres: 3 séries de 8-12 repetições, Tríceps francês com halteres: 3 séries de 8-12 repetições.", TreinoClass = TreinoEnum.Sexta },
                new Treino() { IdTreino = 7, Exercicios = "Elevação de panturrilha em pé: 3 séries de 15-20 repetições, Elevação de panturrilha sentado: 3 séries de 15-20 repetições, Elevação de panturrilha unilateral: 3 séries de 15-20 repetições para cada perna.", TreinoClass = TreinoEnum.Sabado }
                );
        }
    }
}
