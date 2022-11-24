using RailFenceCipher;

Console.WriteLine("Type the message you would like to encode with the Rail Fence Cipher method.");
var userEncode = Console.ReadLine();
Console.WriteLine();

Console.Write("How many rails would you like to encode with? ");
var userRailsParsable = int.TryParse(Console.ReadLine(), out int userRails);
Console.WriteLine();

while (!userRailsParsable)
{
    Console.Write("Invalid rails input. Please enter a valid number for rails: ");
    userRailsParsable = int.TryParse(Console.ReadLine(), out userRails);
    Console.WriteLine();
}

var encodedMessage = Methods.Encode(userEncode, userRails);

Console.WriteLine("Your encoded message is: ");
Console.WriteLine();

Console.WriteLine(encodedMessage);
Console.WriteLine();

Console.WriteLine("Enter the encoded message for decoding: ");
var userDecode = Console.ReadLine();
Console.WriteLine();

Console.Write("How many rails? ");
var userDecodeRailsParsable = int.TryParse(Console.ReadLine(), out int userDecodeRails);
Console.WriteLine();

while (!userDecodeRailsParsable)
{
    Console.Write("Invalid input. Please input a valid number for the rails: ");
    userRailsParsable = int.TryParse(Console.ReadLine(), out userDecodeRails);
    Console.WriteLine();
}

var decodedMessage = Methods.Decode(userDecode, userDecodeRails);

Console.WriteLine("Your decoded message is: ");
Console.WriteLine();

Console.WriteLine(decodedMessage);
