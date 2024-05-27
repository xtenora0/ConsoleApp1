//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//int[] numbers = [12, 44, 43, -69, 66, 32, 3, 0, -8, 6, -8, 80, 53, -63, 36, 5, 0, 75, -75, -120];

////WHERE filtr
//var kladna777 = numbers.Where(numbers => numbers > 0).ToList();

////ORDER BY
//var ordered = numbers.OrderBy(numbers => numbers).ToList();

////TAKE, SKIP
//var first5 = numbers.Take(5).ToList();
//var skip = numbers.Skip(5).ToList();

////MAX, MIN, SUM, AVG  - agregační
//var sum = numbers.Sum(numbers => numbers);
//var max = numbers.Max(numbers => numbers);

////Console.WriteLine($"Sum: {sum}");
////Console.WriteLine($"Max: {max}");

////SELECT - transformace
//var positiveNum = numbers.Select(number => Math.Abs(number)).Where(number => number > 50);
//Console.WriteLine(positiveNum);

////ukoly
//var pocetKladna = numbers.Where(numbers => numbers > 0).Count();
//var pocetZaporna = numbers.Where(numbers => numbers < 0).Count();
//var sumKlad = numbers.Where(numbers => numbers > 0).Sum();
//var maxAbs = numbers.Select(number => Math.Abs(number)).Max();
//var kladSud = numbers.Where(numbers => numbers > 0 && numbers % 2 == 0).ToList();
//var orderedBy = numbers.OrderBy(num => num);
//var skipThreeSum = numbers.Skip(3).Sum();

//Console.WriteLine($"Kladna: {pocetKladna}");
//Console.WriteLine($"Zaporna: {pocetZaporna}");
//Console.WriteLine($"Suma kladnych: {sumKlad}");
//Console.WriteLine($"Max absolutni : {maxAbs}");
//Console.WriteLine($"Kladna suda cisla: {string.Join(", ", kladSud)}");
//Console.WriteLine($"Serazeno od nejmensi po nejvetsi: {string.Join(", ", orderedBy)}");
//Console.WriteLine($"Preskoc 3 a secti: {skipThreeSum}");

////All, Any

//bool vsechna_kladna = numbers.All(num => num > 0);
//bool alespon_jedno_kladne = numbers.Any(num => num > 0);

//pismena dohromady
//var fruits = new[] { "aPPle", "BluebERRY", "chERRy", "RaspBERRy" };
//var dohromady_pismen = fruits.Select(f => f.Length).Sum();
//Console.WriteLine($"Dohromady pismen {dohromady_pismen}");

//var upperFruits = fruits.Select(x => x.ToUpper());
//Console.WriteLine($"Fruits upper: {string.Join(", ", upperFruits)}");
//var lowerFruits = fruits.Select(x => x.ToLower());
//Console.WriteLine($"Fruits lower: {string.Join(", ", lowerFruits)}");

////Upper lower case combo
//var fruit_combo = fruits.Select(x => new
//{
//    Uppercase = x.ToUpper(),
//    Lowercase = x.ToLower(),
//});
//Console.WriteLine($"Fruits upper lower combo: {string.Join(", ", fruit_combo)}");

//var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//// vypište čísla v poli numbers jako slova

//var jako_slova = numbers.Select(x => strings[x]);
//Console.WriteLine($"Jako slova: {string.Join(", ", jako_slova)}");


//foreach (var n in kladna)
//{
//    Console.Write(n);
//}