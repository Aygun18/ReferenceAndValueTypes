using System;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;

namespace ReferenceAndValueTypes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Tapşırıq 1: Bunu Adi metod olaraq yazsaz kifayətdir
			//Stringdə olan adları tərs çevirib yeni bir string kimi geriyə qaytaran method yazın. 
			Reverse("Ali Salam");
			//Tapşırıq 2:
			//İstifadəçidən bir ədəd daxil etməsini istəyin və bu ədədin rəqəmlərini dəyişdirərək yeni bir ədəd yaradın.
			Console.WriteLine("Ededi daxil edin: ");
			int num = Convert.ToInt32(Console.ReadLine());
			ReverseNum(num);

			//Tapşırıq 3:
			//İstifadəçidən bir cümlə daxil etməsini istəyin və bu cümlədə olan hərf silsiləsində bənzər hərflərin sayını ekrana çap edin.
			//Hər hərfin sayını ayrı ayrı hesablayın və hər hərf üçün sayğac göstərin.
			//Console.WriteLine("Cumleni daxil edin: ");
			//CountLetters(Console.ReadLine());

			//Tapşırıq 4: 
			//İstifadəçidən bir söz daxil etməsini istəyin və bu sözün palindrom(tərsində də eyni olan) olub - olmadığını yoxlayın.
			//Palindrom söz isə uyğun mesajı ekrana çap edin, əks halda uyğun mesajı çap edin.

			Console.WriteLine("Sozu daxil edin:");
			Palindrom(Console.ReadLine());


        }
		static void Reverse(string text)
		{
			string result = "";
			for (int i = text.Length - 1; i >= 0; i--)
			{
				result += text[i];
			}
            Console.WriteLine(result);
        }
		static void ReverseNum(int num)
		{
			int num1 = 0;

			while (num > 0)
			{

				num1 = num1 * 10;
				num1 = num1 + num % 10;
				num = num / 10;
			}
			Console.WriteLine(num1);
		}
		static void Palindrom(string text)
		{
			for (int i = 0; i < text.Length / 2; i++)
			{
				if (text[i] == text[text.Length - i - 1])
				{

                    Console.WriteLine(text);
					break;
					
                }
				else
				{
					Console.WriteLine("Soz palindrom deyil");
					break;
				}
			}
		}

	}
}