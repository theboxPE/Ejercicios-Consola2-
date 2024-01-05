/* PROGRAMA QUE LEA 5 NÚMEROS POR TECLADO. DEBE COPIAR LOS VALORES EN UN SEGUNDO ARREGLO, 
SIGUIENDO ESTE REQUERIMIENTO:SI EL NUMERO DE TURNO DEL PRIMER ARREGLO ES PAR, 
COPIARLO AL SEGUNDO ARREGLO MULTIPLICADO POR 10, EN CASO CONTRARIO COPIARLO AL SEGUNDO ARREGLO TAL COMO ESTA.
*/


int[]num;
int[]resul;
resul = new int [5];

num = new int [5];
for(int i=0;i<num.Length;i++)
{
    Console.WriteLine($"Digite un numero: {i+1} ");
    num[i] = Convert.ToInt32(Console.ReadLine());

    if(num[i]%2==0)
    {
        resul[i] = num[i] * 10;
    }
    else
    {
        resul[i] = num[i];
    }
}

Console.WriteLine();
Console.WriteLine("El nuevo arreglo es: ");

for(int i=0;i<num.Length;i++)
{
    Console.WriteLine($"Los nuevos valores son: {resul[i]}");
}

Console.ReadKey();