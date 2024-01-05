// PROGRAMA QUE RECIBA 7 NÚMEROS DE PARTE DEL USUARIO. DEBE VERIFICAR SI DENTRO DE ELLOS ESTA EL 23. EN CASO DE QUE ASÍ SEA, MOSTRAR UN SALUDO Y SALIR. EN CASO CONTRARIO MOSTRAR UNA DESPEDIDA Y SALIR.
int a = 0;

int [] num;
num = new int [6];

for(int i=0;i<num.Length;i++)
{
    Console.WriteLine($"Digite un numero: {i} ");
    num[i] = Convert.ToInt32(Console.ReadLine());  
}
for(int i=0;i<num.Length;i++)
{
    if(num[i]==23)
    {
        Console.WriteLine("Saludos bro:)");
        a=1;
        break;
    }
}

if(a==0)
{
    Console.WriteLine("Muchas gracias, te puedes cuidar bro!!:)");
}

Console.ReadKey();