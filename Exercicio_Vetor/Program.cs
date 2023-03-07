using System.Diagnostics.SymbolStore;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[5];
        int[] b = new int[5];
        int[] c = new int[10];
        int prox=0;
        int esc=0;
        bool state1 = false;
        bool state2 = false;
        bool state3 = false;


        while (esc!=8)
        {
            Menu();
        }

        


        void Menu()
        {
            Console.WriteLine("1- inserir valores em A");
            Console.WriteLine("2- inserir valores em B");
            Console.WriteLine("3- Unir A a C ");
            Console.WriteLine("4- Unir B a C ");
            Console.WriteLine("5- Imprimir A");
            Console.WriteLine("6- Imprimir B");
            Console.WriteLine("7- Imprimir C");
            Console.WriteLine("8- Sair ");

            while (int.TryParse(Console.ReadLine(), out esc) == false)
            {
                Console.WriteLine("Nao eh um numero");
                Console.WriteLine("digite um numero: ");
            }

            switch (esc)
            {
                case 1:
                    LerVet(a);
                    break;

                case 2:
                    LerVet(b);
                    break;

                case 3:
                    if(state1)
                    {
                        UnirEmC(a);
                    }
                    else
                    {
                        Console.WriteLine("A nao foi alterado");
                    }
                    
                    break;

                case 4:
                    if (state2)
                    {
                        UnirEmC(b);
                    }
                    else
                    {
                        Console.WriteLine("B nao foi alterado");
                    }
                    break;

                case 5:
                    if (state1)
                    {
                        ImprimeVet(a, 'A');
                    }
                    else
                    {
                        Console.WriteLine("A nao foi alterado");
                    }
                    break;

                case 6:
                    if (state1)
                    {
                        ImprimeVet(b, 'B');
                    }
                    else
                    {
                        Console.WriteLine("A nao foi alterado");
                    }
                    
                    break;

                case 7:
                    if (state3)
                    {
                        ImprimeVet(c, 'C');
                    }
                    else
                    {
                        Console.WriteLine("A nao foi alterado");
                    }
                    
                    break;

                case 8:
                    Console.WriteLine("Saindo");
                    break;
                default:
                    Console.WriteLine("Digite um valor valido");
                    break;
            }
        }



        void LerVet(int[] v)
        {
            for(int i=0; i<v.Length; i++)
            {
                Console.WriteLine("informe o valor da posicao "+(i+1)+" do vetor A: ");
                v[i] = int.Parse(Console.ReadLine());
            }
            state1 = true;
            Console.Clear();
        }



        void UnirEmC(int[] vet)
        {
            for(int i = 0; i < vet.Length; i++)
            {
                c[prox] = vet[i];
                prox++;
            }
            state3 = true;
            Console.Clear();
        }

        void ImprimeVet(int[] vet, char letra)
        {

            Console.WriteLine("Vetor "+letra+": ");
            for (int i=0; i < vet.Length; i++)
            {
                Console.Write(vet[i]+" ");
            }
            Console.WriteLine();

        }
    }
}