/*Escriba un programa que solicite un numero al usuario. Si el numero es mayor que 10 y es impar, 
mostrar la secuencia de ascendente del 100 al 500,de 10 en 10. Si es mayor que 10 y es par mostrar un saludo 5 veces. 
Si es menor o igual que 10 mostrar su nombre y matricula 15 veces.
*/


int a, b;

Console.WriteLine("digite un numero");
a = Convert.ToInt32(Console.ReadLine());

if(a>10){

  if(a%2!=0){
    Console.WriteLine("secuencia de 10 en 10 ");
    for(b = 100 ;b <= 500;b+=10)
    {
      Console.WriteLine(b);
    }  
  }
  else
  {
    for(int i=0;i<5;i++)
    {
      Console.WriteLine("saludos");
    } 
  }
}
else
{
  for(int i= 0;i<15;i++)
  {
    Console.WriteLine("Gabriel Perez (2022-0332)");
  }
}

Console.ReadKey();
