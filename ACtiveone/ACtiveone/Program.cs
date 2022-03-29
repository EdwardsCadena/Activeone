// See https://aka.ms/new-console-template for more information
int resultado = 0;
int a = 0;
int b = 0;

int[,] array = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 9, 8, 9 }
};
a = array[0, 0] + array[1,1] + array[2,2] ;
b = array[0, 2] + array[1, 1] + array[2,0];
resultado = a - b;
resultado = System.Math.Abs(resultado);

Console.WriteLine(resultado);






