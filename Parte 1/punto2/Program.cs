/* Escriba un programa que solicite dos numeros. 
Debe mostrar la secuencia descendente desde el numero mas grande hasta el numero menor
*/

int num1;
int num2;

Console.WriteLine("Introduzca un numero:");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduzca otro numero:");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2){
    
    Console.WriteLine("La secuencia descendete del primer numero es: ");
for (int i=num1;i!=num2-1;i--){
    Console.WriteLine(i);
    }
}
else{
    Console.WriteLine("La secuencia descendete del segundo numero es: ");
    for (int i=num2;i!=num1-1;i--){
    Console.WriteLine(i);
    }
}

Console.ReadKey();