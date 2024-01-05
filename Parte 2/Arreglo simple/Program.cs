/* PROGRAMA QUE LE PIDA AL USUARIO 5 NÚMEROS Y LOS ALMACENE EN UN ARREGLO. 
CUANDO EL USUARIO TERMINE DE INGRESARLOS  DEBE MOSTRAR LA SUMATORIA DE ESOS NÚMEROS.
*/


int a=0;
int [] num;
num = new int [4];

for(int i=0;i<num.Length;i++)
{
    Console.WriteLine("Digite un numero: ");
    num[i] = Convert.ToInt32(Console.ReadLine());
    a+= num[i];

}

Console.WriteLine("La sumatoria de los digitos ingresados es: ");
Console.WriteLine(a);

Console.ReadKey();