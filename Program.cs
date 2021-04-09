using System;

namespace Aula_de_PC1_Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            double g = 9.80665;
            double velocidade , anguloG , anguloRad , alcance , altura;
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("------------------------");
            Console.WriteLine("Vamos lançar um foguete!");
            Console.WriteLine("------------------------");
            Console.ResetColor();
            Console.WriteLine("Da última vez fizemos a contagem regressiva, mas hoje faremos cálculo de lançamento!\n");

            Console.WriteLine("Escreva a velocidade que deseja em m/s :");
            velocidade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Agora escreva o ângulo em graus:");
            anguloG = Convert.ToDouble(Console.ReadLine());

            //Conversão de ângulos para radianos//
            anguloRad = anguloG * (Math.PI/180);
            //Aplicação de Torrivelli para alcance e altura//
            alcance = Math.Pow(velocidade, 2) * Math.Sin(2 * anguloRad) / g;
            altura = Math.Pow((velocidade * Math.Sin(anguloRad)), 2) / (2 * g);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"O alcance de seu foguete é:{alcance:N2} metros\nSua altura máxima equivale a {altura:N2} metros.");
            Console.ResetColor();
            Console.WriteLine("\n Tecle enter para fechar o programa:");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
