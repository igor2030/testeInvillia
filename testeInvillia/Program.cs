// See https://aka.ms/new-console-template for more information
float comprM, Consumo, totalPercurso, distReabastecimento, nlitros;
int numeroVoltas, numeroReabastecimento;

Console.WriteLine("comprimento da pista em metros : ");
comprM = float.Parse(Console.ReadLine());
Console.WriteLine("numero de voltas da corrida: ");
numeroVoltas = int.Parse(Console.ReadLine());
Console.WriteLine("Numero de Reabastecimento: ");
numeroReabastecimento = int.Parse(Console.ReadLine());
Console.WriteLine("consumo de combustivel(km/L)");
Consumo = float.Parse(Console.ReadLine());

totalPercurso = comprM / 1000 * numeroVoltas;
distReabastecimento = totalPercurso / (numeroReabastecimento + 1);
nlitros = distReabastecimento / Consumo;

Console.WriteLine("numero minimo de litros : " + Math.Round(nlitros, 1));
