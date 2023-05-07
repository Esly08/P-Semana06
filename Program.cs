Console.WriteLine("Ingrese el número");
int numero = int.Parse(Console.ReadLine());

int divisor = 2;
int primo = 0;

do
{
    int prueba = numero % divisor;
    if (prueba == 0)
    {
        //True
        primo++;
        divisor++;
    }
    else
    {
        //False
        divisor++;
    }
}
while (numero != divisor);
    if (primo == 0)
    {
        //True
        primo++;
    }
else
    {
        //False
        divisor++;
    }
