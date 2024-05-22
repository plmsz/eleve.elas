// Um código onde voce pergunta para o usuário o nome dele, a idade, o cargo
// e no final imprime uma saudação na tela com todas as infos e com data e hora

Console.WriteLine("Qual o seu nome, idade e cargo? Digite e separe apenas por virgulas");

string resposta = Console.ReadLine();
string[] usuario = resposta.Split(",");

string name = usuario[0];
int idade = int.Parse(usuario[1]);
string cargo = usuario[2];

Console.WriteLine($"Olá, {name}! Você tem {idade} anos e ocupa o cargo de {cargo}. Hora atual: {DateTime.Now}");