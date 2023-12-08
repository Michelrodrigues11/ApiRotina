IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [TB_DIETAS] (
    [IdDieta] int NOT NULL IDENTITY,
    [Dia] nvarchar(max) NOT NULL,
    [Alimentos] nvarchar(max) NOT NULL,
    [Refeicoes] int NOT NULL,
    [Nutrientes] nvarchar(max) NOT NULL,
    [DietaClass] int NOT NULL,
    CONSTRAINT [PK_TB_DIETAS] PRIMARY KEY ([IdDieta])
);
GO

CREATE TABLE [TB_TREINOS] (
    [IdTreino] int NOT NULL IDENTITY,
    [Exercicios] nvarchar(max) NOT NULL,
    [TreinoClass] int NOT NULL,
    CONSTRAINT [PK_TB_TREINOS] PRIMARY KEY ([IdTreino])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdDieta', N'Alimentos', N'Dia', N'DietaClass', N'Nutrientes', N'Refeicoes') AND [object_id] = OBJECT_ID(N'[TB_DIETAS]'))
    SET IDENTITY_INSERT [TB_DIETAS] ON;
INSERT INTO [TB_DIETAS] ([IdDieta], [Alimentos], [Dia], [DietaClass], [Nutrientes], [Refeicoes])
VALUES (1, N' Refeição 1:Ovos mexidos (6 claras e 2 gemas), Aveia (50g) e Banana (1 unidade), Refeição 2: Peito de frango grelhado (150g)Arroz integral (100g)Brócolis cozido (100g), Refeição 3 (pré-treino):Batata doce (150g), Peito de frango grelhado (150g), Salada de folhas verdes (alface, rúcula, espinafre) com azeite de oliva, Refeição 4 (pós-treino):Whey protein (30g) com águaBanana (1 unidade).', N'Domingo', 1, N'Proteína: 180g, Carboidratos: 177g, Gordura: 20g e Fibras: 21g', 4),
(2, N'Refeição 1: 2 ovos cozidos, 1 xícara de leite, 1 fatia de pão integral, 1 banana, Refeição 2: 100 g de frango grelhado, 200 g de arroz integral, 100 g de legumes cozidos, Refeição 3: 150 g de iogurte natural, 100 g de frutas, Refeição 4: 200 g de peixe grelhado, 300 g de batata doce assada, 100 g de legumes cozidos.', N'Segunda', 2, N'200 g de Proteína, 350 g de Carboidratos, 80 g de Gorduras', 4),
(3, N'Refeição 1: 1 xícara de mingau de aveia com frutas e castanhas, Refeição 2: 200 g de carne moída magra, 250 g de macarrão integral, 100 g de legumes cozidos, Refeição 3: 100 g de pão integral com pasta de amendoim, Refeição 4: 150 g de frango desfiado, 300 g de batata inglesa cozida, 100 g de legumes cozidos.', N'Terça', 3, N'200 g de Proteína, 350 g de Carboidratos, 80 g de Gorduras', 4),
(4, N' Refeição 1:Ovos mexidos (6 claras e 2 gemas), Aveia (50g) e Banana (1 unidade), Refeição 2: Peito de frango grelhado (150g)Arroz integral (100g)Brócolis cozido (100g), Refeição 3 (pré-treino):Batata doce (150g), Peito de frango grelhado (150g), Salada de folhas verdes (alface, rúcula, espinafre) com azeite de oliva, Refeição 4 (pós-treino):Whey protein (30g) com águaBanana (1 unidade).', N'Quarta', 4, N'Proteína: 180g, Carboidratos: 177g, Gordura: 20g e Fibras: 21g', 4),
(5, N'Refeição 1: 2 ovos cozidos, 1 xícara de leite, 1 fatia de pão integral, 1 banana, Refeição 2: 100 g de frango grelhado, 200 g de arroz integral, 100 g de legumes cozidos, Refeição 3: 150 g de iogurte natural, 100 g de frutas, Refeição 4: 200 g de peixe grelhado, 300 g de batata doce assada, 100 g de legumes cozidos.', N'Quinta', 5, N'200 g de Proteína, 350 g de Carboidratos, 80 g de Gorduras', 4),
(6, N'Refeição 1: 1 xícara de mingau de aveia com frutas e castanhas, Refeição 2: 200 g de carne moída magra, 250 g de macarrão integral, 100 g de legumes cozidos, Refeição 3: 100 g de pão integral com pasta de amendoim, Refeição 4: 150 g de frango desfiado, 300 g de batata inglesa cozida, 100 g de legumes cozidos.', N'Sexta', 6, N'200 g de Proteína, 350 g de Carboidratos, 80 g de Gorduras', 4),
(7, N'Refeição 1:Ovos mexidos (6 claras e 2 gemas), Aveia (50g) e Banana (1 unidade), Refeição 2: Peito de frango grelhado (150g)Arroz integral (100g)Brócolis cozido (100g), Refeição 3 (pré-treino):Batata doce (150g), Peito de frango grelhado (150g), Salada de folhas verdes (alface, rúcula, espinafre) com azeite de oliva, Refeição 4 (pós-treino):Whey protein (30g) com águaBanana (1 unidade).', N'Sabado', 7, N'Proteína: 180g, Carboidratos: 177g, Gordura: 20g e Fibras: 21g', 4);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdDieta', N'Alimentos', N'Dia', N'DietaClass', N'Nutrientes', N'Refeicoes') AND [object_id] = OBJECT_ID(N'[TB_DIETAS]'))
    SET IDENTITY_INSERT [TB_DIETAS] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdTreino', N'Exercicios', N'TreinoClass') AND [object_id] = OBJECT_ID(N'[TB_TREINOS]'))
    SET IDENTITY_INSERT [TB_TREINOS] ON;
INSERT INTO [TB_TREINOS] ([IdTreino], [Exercicios], [TreinoClass])
VALUES (1, N'Supino reto com halteres: 3 séries de 8-12 repetições, Rosca bíceps com halteres: 3 séries de 8-12 repetições, Agachamento com barra: 3 séries de 8-12 repetições, Leg press: 3 séries de 10-15 repetições, Remada curvada com halteres: 3 séries de 8-12 repetições, Tríceps francês com halteres: 3 séries de 8-12 repetições.', 1),
(2, N'Agachamento com barra: 3 séries de 8-12 repetições, Leg press: 3 séries de 10-15 repetições, Leg extension: 3 séries de 10-15 repetições, Legcurl:3 séries de 10-15 repetições.', 2),
(3, N'Elevação de panturrilha em pé: 3 séries de 15-20 repetições, Elevação de panturrilha sentado: 3 séries de 15-20 repetições, Elevação de panturrilha unilateral: 3 séries de 15-20 repetições para cada perna.', 3),
(4, N'Rosca direta com halteres: 3 séries de 8-12 repetições, Rosca martelo com halteres: 3 séries de 8-12 repetições, Rosca concentrada com halteres: 3 séries de 8-12 repetições, Tríceps francês com halteres: 3 séries de 8-12 repetições, Tríceps pushdown: 3 séries de 10-15 repetições.', 4),
(5, N'Agachamento com barra: 3 séries de 8-12 repetições, Leg press: 3 séries de 10-15 repetições, Leg extension: 3 séries de 10-15 repetições, Legcurl:3 séries de 10-15 repetições.', 5),
(6, N'Supino reto com halteres: 3 séries de 8-12 repetições, Rosca bíceps com halteres: 3 séries de 8-12 repetições, Agachamento com barra: 3 séries de 8-12 repetições, Leg press: 3 séries de 10-15 repetições, Remada curvada com halteres: 3 séries de 8-12 repetições, Tríceps francês com halteres: 3 séries de 8-12 repetições.', 6),
(7, N'Elevação de panturrilha em pé: 3 séries de 15-20 repetições, Elevação de panturrilha sentado: 3 séries de 15-20 repetições, Elevação de panturrilha unilateral: 3 séries de 15-20 repetições para cada perna.', 7);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdTreino', N'Exercicios', N'TreinoClass') AND [object_id] = OBJECT_ID(N'[TB_TREINOS]'))
    SET IDENTITY_INSERT [TB_TREINOS] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231207165647_MigracaoDietasTreinos', N'7.0.4');
GO

COMMIT;
GO

