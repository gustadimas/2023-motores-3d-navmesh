# Motores 3D: NavMesh

Projeto da faculdade, de set/2023 a out/2023. Subi pro GitHub em novembro de 2026 só pra guardar, sem mexer no código.

Continuação das aulas de motores 3D, agora com NavMesh. Num terreno com floresta low-poly, os NPCs vão até o jogador pelo NavMesh (`NPCNavMesh.cs`). Também tem o `NPCCalculo.cs`, onde fiz a perseguição calculando direção e distância na mão.

O primeiro commit, de 18/09, é só o cenário (terreno e floresta). O segundo, de 02/10, já tem o NavMesh e os scripts.

## Como abrir

Na época só exportei a pasta Assets num `.unitypackage`, então não tem ProjectSettings. Crie um projeto 3D vazio no Unity (nessa época eu usava a 2021.3) e importe `pacote-original/ContinuarNav.unitypackage` em Assets > Import Package > Custom Package.

## Créditos

Floresta do pacote Low-Poly Forest Nature Set Free Sample, da Asset Store. As texturas de grama foram baixadas da internet.

Outros projetos da faculdade: [projetos-da-faculdade](https://github.com/gustadimas/projetos-da-faculdade)
