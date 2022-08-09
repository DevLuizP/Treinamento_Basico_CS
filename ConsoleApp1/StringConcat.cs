string firstFriend = "Ana";
string secondFriend = "Frederick Franz";

//Uso dos caracteres '${}' para concatenar as strings com variárias
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

//O Método '.Length' retorna um inteiro após calcular a quantidade de caracteres em uma string
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");

/*O Método '.Replace' substitui caracteres em uma string
 * No caso abaixo, o utilizo para retirar os espaços em branco ao declarar (" ", "")
*/
Console.WriteLine($"The name {secondFriend} has {secondFriend.Replace(" ", "").Length} letters.");