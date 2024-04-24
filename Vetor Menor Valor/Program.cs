// 1. Faça um programa que leia 5 números e imprima o menor valor;

//int size = 10, auxiliar = 0;
//int[] vetor_original = new int[size];
//int[] vetor_ordenado = new int[size];

//for (int i = 0; i< size; i++)
//{
//    vetor_original[i] = new Random().Next(0, 100);
//    vetor_ordenado[i] = vetor_original[i];
//}

//Console.WriteLine("Vetor Original");
//for (int i = 0; i < size; i++)
//    Console.Write(vetor_original[i] + " ");

//for (int referencia = 0; referencia<size; referencia++)
//{
//    for (int comparacao = referencia + 1; comparacao<size; comparacao++)
//    {
//        if (vetor_ordenado[referencia] > vetor_ordenado[comparacao])
//        {
//            auxiliar = vetor_ordenado[referencia];
//            vetor_ordenado[referencia] = vetor_ordenado[comparacao];
//            vetor_ordenado[comparacao] = auxiliar;
//        }
//    }
//}

//Console.WriteLine("\nVetor Ordenado");
//for (int i = 0; i < size; i++)
//    Console.Write(vetor_ordenado[i] + " ");

//2. O vetor original deve ter 5 posições; o segundo deve ser ordenado (crescente) e não pode ter número repetido; crie um terceiro vetor, ordene em ordem decrescente, caseado no segundo vetor

int size = 5, auxiliar, auxiliar_vetor_3;
int[] vetor_original = new int[size];
int[] segundo_vetor = new int[size];
int[] terceiro_vetor = new int[size];
int[] verificacao_vetor_repetido = new int[size];
bool vetor_nao_copiado;

for (int i = 0; i < size; i++)
{
    vetor_original[i] = new Random().Next(0, 10);

    do
    {
        for (int referencia = 0; referencia < size; referencia++)
        {
            for (int comparacao = referencia + 1; comparacao < size; comparacao++)
            {
                if (vetor_original[referencia] == vetor_original[comparacao])
                {
                    verificacao_vetor_repetido[i] = vetor_original[i];
                    vetor_original[i] = new Random().Next(0, 10);

                    for (int s = 0; s < size; s++)
                    {
                        if (vetor_original[s] == verificacao_vetor_repetido[s])
                        {
                            vetor_original[s] = new Random().Next(0, 10);
                        }
                    }
                }
            }
        }
        
        vetor_nao_copiado = true;

    } while (vetor_nao_copiado == false);

    segundo_vetor[i] = vetor_original[i];
}

for (int referencia_2 = 0; referencia_2 < size; referencia_2++)
{
    for (int comparacao_2 = referencia_2 + 1; comparacao_2 < size; comparacao_2++)
    {
        if (segundo_vetor[referencia_2] > segundo_vetor[comparacao_2])
        {
            auxiliar = segundo_vetor[referencia_2];
            segundo_vetor[referencia_2] = segundo_vetor[comparacao_2];
            segundo_vetor[comparacao_2] = auxiliar;
        }
    }
}

Console.WriteLine("Segundo vetor ordenado de forma crescente, sem repetição: ");
for (int x = 0; x < size; x++)
{
    Console.Write(segundo_vetor[x] + " ");
}

//Crie um terceiro vetor, ordene-o do maior para o menor, baseado no segundo vetor
Console.WriteLine("\nTerceiro vetor, ordenado de forma decrescente:");
for (int j = 0; j < size; j++)
{
    terceiro_vetor[j] = segundo_vetor[j];
}

for (int referencia_3 = 0; referencia_3 < size; referencia_3++)
{
    for (int comparacao_3 = referencia_3 + 1; comparacao_3 < size; comparacao_3++)
    {
        if (terceiro_vetor[comparacao_3] > terceiro_vetor[referencia_3])
        {
            auxiliar_vetor_3 = terceiro_vetor[referencia_3];
            terceiro_vetor[referencia_3] = terceiro_vetor[comparacao_3];
            terceiro_vetor[comparacao_3] = auxiliar_vetor_3;
        }
    }
}

for (int h = 0; h < size; h++)
{
    Console.Write(terceiro_vetor[h] + " ");
}

Console.WriteLine("\n\nPressione ENTER para encerrar...");
Console.ReadKey();