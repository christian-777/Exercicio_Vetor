using System.Diagnostics.SymbolStore;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[5];
        int[] b = new int[5];
        int[] c = new int[10];
        int esc=0;
        int state1 = 0;
        bool state2 = false;


        while (esc!=8)
        {
            Menu();
        }

        


        void Menu()
        {
            Console.WriteLine("1- inserir valores em A");
            Console.WriteLine("2- inserir valores em B");
            Console.WriteLine("3- Unir em C ");
            Console.WriteLine("4- Imprimir A");
            Console.WriteLine("5- Imprimir B");
            Console.WriteLine("6- Imprimir C");
            Console.WriteLine("7- Ordenar C");
            Console.WriteLine("8- Sair ");

            while (int.TryParse(Console.ReadLine(), out esc) == false)
            {
                Console.WriteLine("Nao eh um numero");
                Console.WriteLine("digite um numero: ");
            }

            switch (esc)
            {
                case 1:
                    LerVet(a, 'A');
                    break;

                case 2:
                    LerVet(b, 'B');
                    break;

                case 3:
                    if (state1 < 2)
                    {
                        Console.WriteLine("A ou B nao foi alterado");
                    }
                    else
                    {
                        UnirEmC(c, a, b);
                    }
                    
                    break;

                case 4:
                    
                        ImprimeVet(a, 'A');
                   
                    break;

                case 5:

                    ImprimeVet(b, 'B');


                    break;

                case 6:
                    if (state2)
                    {
                        ImprimeVet(c, 'C');
                    }
                    else
                    {
                        Console.WriteLine("C ainda nao existe");
                    }
                    
                    break;
                case 7:
                    if (state2)
                    {
                        ordenaC(c);
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



        void LerVet(int[] v, char letra)
        {
            for(int i=0; i<v.Length; i++)
            {
                Console.WriteLine("informe o valor da posicao "+(i+1)+" do vetor "+letra+": ");
                v[i] = int.Parse(Console.ReadLine());
            }
            state1++;
            Console.Clear();
        }



        void UnirEmC(int[]c, int[] vet, int[] vet2)
        {
           
            for(int i = 0; i < c.Length; i++)
            {
                if (i <= vet.Length - 1)
                {
                    c[i] = vet[i];
                }
                else
                {
                    c[i] = vet2[i-5];
                }
            }

            state2 = true;
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


        void ordenaC(int[] c)
        {
            int aux;
            
            for(int i=0; i < c.Length-1; i++)
            {
                for(int j = i+1; j < c.Length; j++)
                {
                    if (c[i] > c[j])
                    {
                        aux= c[i];
                        c[i]= c[j];
                        c[j]= aux;
                    }
                }
            }
        }
    }
}