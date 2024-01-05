// PROGRAMA QUE LEA 10 NÚMEROS ENTEROS INGRESADOS POR EL USUARIO Y LOS INSERTE EN UN ARREGLO. A CONTINUACIÓN, EL PROGRAMA DEBE CONTAR Y CLASIFICAR CUÁNTOS NÚMEROS PARES Y CUÁNTOS NÚMEROS IMPARES HAY DENTRO DEL ARREGLO, Y MOSTRAR ESOS RESULTADOS.
int a=0,b=0;

int [] num;
num = new int [10];
for(int i=0;i<num.Length;i++)
{
    Console.WriteLine($"Digite un numero: {i+1} ");
    num[i] = Convert.ToInt32(Console.ReadLine());

    if(num[i]%2==0)
    {
        a++;
    }
    else
    {
        b++;
    }
    
}
Console.WriteLine($"Los numeros pares son: {a}");
Console.WriteLine($"Los numeros pares son: {b}");

Console.ReadKey();