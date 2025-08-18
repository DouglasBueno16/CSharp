// Exemplos de ArrayListas
/*
for() -> utiliza um contador na própria estrutura
foreach -> necessário um contador externo, mas percorre o array todo
*/

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;

/*// redimensionando o array
Console.WriteLine($"Tamanho do array: {arrayInteiros.Length}");
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
Console.WriteLine($"Tamanho do array: {arrayInteiros.Length}");
*/

Console.WriteLine("=== Array com for ===");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Valor na posição {contador} é {arrayInteiros[contador]}");

}  // for

/* Console.WriteLine("=== Array com foreach ===");
int contadorForEach = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Valor na posição {contadorForEach} é {valor}");
}  //foreach
*/

int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);
Console.WriteLine($"Tamanho do novo array: {arrayInteirosDobrados.Length}");


List<string> listString = new List<string>();
listString.Add("SP");
listString.Add("RJ");
listString.Add("MG");

for (int contador = 0; contador < listString.Count; contador++)
{
    Console.WriteLine($"Valor na posição {contador} é {listString[contador]}");
}