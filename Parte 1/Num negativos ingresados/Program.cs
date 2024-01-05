/*Escriba un programa que pregunte cuántos números se van a introducir, 
pida esos números y muestre cuántos números negativos ha introducido.
*/

int a,b,c=0;

Console.WriteLine("Introduce la secuencia a repetir: ");
a = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i<a; i++)
{
  Console.WriteLine("Ingresa un numero: ");
  b = Convert.ToInt32(Console.ReadLine());

  if(b<0)
  {
    c++;
  }
   
}
Console.WriteLine("Los numeros negativos son: "+ c);

Console.ReadKey();