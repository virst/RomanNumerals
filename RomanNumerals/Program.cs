using static RomanNumerals.RomanNumeralsUtils;

Console.WriteLine(ToRoman(2000));
Console.WriteLine(ToRoman(1666));
Console.WriteLine(ToRoman(400));
Console.WriteLine(ToRoman(9));

Console.WriteLine(FromRoman("MDCLXVI"));
Console.WriteLine(FromRoman("MM"));
Console.WriteLine(FromRoman("I"));
Console.WriteLine(FromRoman("IX"));

Console.WriteLine("Start!");
for (int i = 0; i <= 4000; i++)
{
    if (FromRoman(ToRoman(i)) != i) Console.WriteLine($"!{i}");
}
Console.WriteLine("Done!");