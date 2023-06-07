namespace timesloucuratotal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string time1 = "FLAMENGAO";
            string time2 = "SANTOS";
            string time3 = "CORINTHIANS";
            string time4 = "sao palo";

            int pontos1 = 0;
            int pontos2 = 0;
            int pontos3 = 0;
            int pontos4 = 0;

            string status = "";

            // time + G-ganhou, E-empatou ou P-perdeu danado
            // quando um time ganhar ele leva +3 pontos
            // empate = 1 ponto
            // perdeu = 0 pontinhos f 

            for (int x=1; x<=3; x++)
            {
                Console.WriteLine("rodada " + x);
                Console.WriteLine(time1 + " G - ganhou, E - empatou ou P - perdeu o danado: ");
                status = Console.ReadLine().ToUpper();
                if (status == "G")
                {
                    pontos1 += 3;
                }

                else if (status == "E")
                {
                    pontos1 += 1;
                }

                else if (status == "P")
                {
                    pontos1 += 0;
                }
                else Console.WriteLine("Opção inválida");
            }

            for (int x = 1; x <= 3; x++)
            {
                Console.WriteLine("rodada " + x);
                Console.WriteLine(time1 + " G - ganhou, E - empatou ou P - perdeu o danado: ");
                status = Console.ReadLine().ToUpper();
                if (status == "G")
                {
                    pontos2 += 3;
                }

                else if (status == "E")
                {
                    pontos2 += 1;
                }

                else if (status == "P")
                {
                    pontos2 += 0;
                }
                else Console.WriteLine("Opção inválida");
            }

            for (int x = 1; x <= 3; x++)
            {
                Console.WriteLine("rodada " + x);
                Console.WriteLine(time1 + " G - ganhou, E - empatou ou P - perdeu o danado: ");
                status = Console.ReadLine().ToUpper();
                if (status == "G")
                {
                    pontos3 += 3;
                }

                else if (status == "E")
                {
                    pontos3 += 1;
                }

                else if (status == "P")
                {
                    pontos3 += 0;
                }
                else Console.WriteLine("Opção inválida");
            }

            for (int x = 1; x <= 3; x++)
            {
                Console.WriteLine("rodada " + x);
                Console.WriteLine(time1 + " G - ganhou, E - empatou ou P - perdeu o danado: ");
                status = Console.ReadLine().ToUpper();
                if (status == "G")
                {
                    pontos4 += 3;
                }

                else if (status == "E")
                {
                    pontos4 += 1;
                }

                else if (status == "P")
                {
                    pontos4 += 0;
                }
                else Console.WriteLine("Opção inválida");
            }

            Console.WriteLine("TIME\tPONTOS");
            Console.WriteLine(time1 + "\t" + pontos1);
            Console.WriteLine(time2 + "\t" + pontos2);
            Console.WriteLine(time3 + "\t" + pontos3);
            Console.WriteLine(time4 + "\t" + pontos4);
        }


    }
}