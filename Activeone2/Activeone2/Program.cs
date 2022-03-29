// See https://aka.ms/new-console-template for more information

int[] arraynaranjas = new int [3];
int[] arraymanzanas = new int[3];
int arraym = 0;
int arraym1 = 0;
int arraym2 = 0;
int array = 0;
int array1 = 0;
int array2 = 0;

Console.WriteLine("Ingrese valor de inico de la casa de Sam ");
int Sams = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese valor de final de la casa de sam ");
int Samt = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese valor de la ubicacion del manzanero ");
int Mana = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese valor de la ubicacion del naranjo");
int Naraa = int.Parse(Console.ReadLine());
 for(int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese los valor de las naranjas");
    arraynaranjas[i] = int.Parse(Console.ReadLine());

}
for (int m = 0; m < 3; m++)
{
    Console.WriteLine("Ingrese los valor de las manzanas");
    arraymanzanas[m] = int.Parse(Console.ReadLine());

}
for (int p = 0; p < Naraa; p++)
{
    array = Naraa + arraymanzanas[0];
    array1 = Naraa + arraymanzanas[1];
    array2 = Naraa + arraymanzanas[2];

}
for (int o = 0; o < Mana; o++)
{
    arraym = Mana + arraymanzanas[0];
    arraym1 = Mana + arraymanzanas[1];
    arraym2 = Mana + arraymanzanas[2];

}
for (int a = 0; a < 3; a++)
{
  if (arraym <= Sams || arraym1 <= Sams || arraym2 <= Sams)
    {
        if (arraym >= Samt || arraym1 >= Samt || arraym2 >= Samt)
        {
            Console.WriteLine("Numero de naranjas" + a);
        }
    }
    else if (array <= Sams || array1 <= Sams || array2 <= Sams)
    {
        if (array >= Samt || array1 >= Samt || array2 >= Samt)
        {
            Console.WriteLine("Numero de manzanas" + a);
        }
    }
}





