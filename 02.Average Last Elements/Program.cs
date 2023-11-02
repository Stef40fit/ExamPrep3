int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());
double currentSum = 0;
for(int i = 0; i < n; i++)
{
    int currentNum = numbers[numbers.Length - 1 - i];
     currentSum +=currentNum;

}
double average = currentSum / n;
Console.WriteLine($"{average:f2}");