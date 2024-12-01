// DAY ONE 1ST DECEMBER \\
// part one

var lines = File.ReadAllLines(@"../../../PuzzlesInput/Day01_A.txt");
int[] leftList = new int[lines.Length];
int[] rightList = new int[lines.Length];

for (int i = 0; i < lines.Length; i++)
{
    var values = lines[i].Split("   ");
    leftList[i] = int.Parse(values[0]);
    rightList[i] = int.Parse(values[1]);
}

Array.Sort(leftList);
Array.Sort(rightList);

int sum = 0;

for (int i = 0; i < leftList.Length; i++)
{
    sum += Math.Abs(leftList[i] - rightList[i]);
}

Console.WriteLine($"The sum of the left and right distances is: {sum}");


// part two

int similarityScore = 0;

for (int i = 0; i < leftList.Length; i++)
{
    similarityScore += leftList[i] * rightList.Count((val => val == leftList[i]));
}

Console.WriteLine($"The similarity score is: {similarityScore}");