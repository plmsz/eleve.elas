/*
 EXERCÍCIO
Você deve desenvolver um sistema de gerenciamento de animais para um zoológico.

O sistema deve suportar diferentes tipos de animais, como anfíbios, mamíferos, aves, peixes e répteis. Cada tipo de animal deve ter características específicas.

Além disso, alguns animais devem ser capazes de voar ou nadar.

Todo mundo que voa deve saber levantar voo e pousar.

Todo mundo que nada deve ter um limite de profundidade, e ser capaz de subir e descer x metros no mar
.
Esperada aplicação de modelagem de classes e objetos, herança e interface
 */

using Zoo;
using Zoo.Animais;
using Zoo.Grupos;

Aves emaJuju = new Ema();
IVoadores gaivotaMariana = new Gaivota();
gaivotaMariana.LevantarVoo();
gaivotaMariana.Pousar();
Anfibios sapo = new Sapo();
sapo.ProfundidadeMáxima = 2; // girino nada
INadadores baleiaJubarte = new Baleia();
baleiaJubarte.ProfundidadeMáxima = 200;
baleiaJubarte.ProfundidadeAtual = -10;
baleiaJubarte.Subir(5);
baleiaJubarte.Descer(196);
IAndadores leaoDaMontanha = new Leao();