Console.WriteLine("Welcome to my calculator");
Console.WriteLine("************************");

Console.Write("Please enter first number: ");
var inputOne = Console.ReadLine();

Console.Write("Please enter second number: ");
var inputTwo = Console.ReadLine();

Tuple<int, int>? inputs;
inputs = ConvertInputs(inputOne, inputTwo);

var sum = Add(inputs.Item1,inputs.Item2);

Console.WriteLine(sum);

int Add(int numOne, int numTwo)
{
	return numOne + numTwo;
}

Tuple<int,int>? ConvertInputs(string first, string second)
{
	if (int.TryParse(first, out int firstNum) && int.TryParse(second, out int secondNum))
	{
		return new Tuple<int,int>(firstNum,secondNum);
	}

    Console.WriteLine("Input not valid, numbers only");
	return null;
}