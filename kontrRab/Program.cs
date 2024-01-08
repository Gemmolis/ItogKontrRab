//string[] startArray = {"Hello", "2", "world", ":-)"}; //[“2”, “:-)”]
//string[] startArray = {"1234", "1567", "-2", "computer science"};//[“-2”]
string[] startArray = {"Russia", "Denmark", "Kazan"}; // []
string[] resultArray = new string[startArray.Length]; 
int resultIndex = 0;

for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= 3)
    {
      resultArray[resultIndex] = startArray[i];
      resultIndex++;
       }
}
//Console.Write("[“Hello”, “2”, “world”, “:-)”] → ");
//Console.Write("[“1234”, “1567”, “-2”, “computer science”] → ");
Console.Write("[“Russia”, “Denmark”, “Kazan”] → ");
Console.Write("[");
for (int i = 0; i < resultIndex; i++)
{
    Console.Write($"“{resultArray[i]}”, ");
}
    Console.Write("]");

