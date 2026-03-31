using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayersGuideChallenges.challenges
{

    public class VariableShop : Challenge
    {
        public string challengeName => "The Variable Shop";
        public int challengeNumber => 4;

        public void Run()
        {
            // the 14 variable literals in C#
            // numeric literals
            byte byteLiteral = 255;
            short shortLiteral = 32_767;
            int intLiteral = 2_147_483_647;
            long longLiteral = 9_223_372_036_854_775_807;
            sbyte sbyteLiteral = 127;
            ushort ushortLiteral = 65_535;
            uint uintLiteral = 4_294_967_295;
            ulong ulongLiteral = 18_446_744_073_709_551_615;

            // floating-point literals
            float floatLiteral = 3.14159f;
            double doubleLiteral = 2.718281828459045;
            decimal decimalLiteral = 1.618033988749895m;

            // character and string literals
            char charLiteral = 'A';
            string stringLiteral = "Hello, World!";

            // boolean literal
            bool boolLiteral = true;

            // output the literals to the console

            Console.WriteLine($"byte literal: {byteLiteral}");
            Console.WriteLine($"short literal: {shortLiteral}");
            Console.WriteLine($"int literal: {intLiteral}");
            Console.WriteLine($"long literal: {longLiteral}");
            Console.WriteLine($"sbyte literal: {sbyteLiteral}");
            Console.WriteLine($"ushort literal: {ushortLiteral}");
            Console.WriteLine($"uint literal: {uintLiteral}");
            Console.WriteLine($"ulong literal: {ulongLiteral}");
            Console.WriteLine($"float literal: {floatLiteral}");
            Console.WriteLine($"double literal: {doubleLiteral}");
            Console.WriteLine($"decimal literal: {decimalLiteral}");
            Console.WriteLine($"char literal: {charLiteral}");
            Console.WriteLine($"string literal: {stringLiteral}");
            Console.WriteLine($"bool literal: {boolLiteral}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            // Variable Shop Returns section
            // you can adjust the variables by simply assigning new values to them, for example
            // intLiteral = 100;
        }
    }
}
