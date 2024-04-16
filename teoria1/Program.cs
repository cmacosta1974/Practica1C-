using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
/**************************************************************
//(programa 1 practica 1)
Console.WriteLine("Presione una letra");
Console.ReadKey(intercept: true);
Console.Write("Hola ");
Console.ReadKey(intercept: true);
Console.Write("Mundo");
Console.ReadKey(intercept: true);
*/


/**************************************************************
//(programa 2 practica 1)
Console.Write(" \"Hola Mundo\" \t (proxima frase)...\n");
Console.Write(" Visita: www.google.com\\espanol \n C:\\Users\\LosAcosta\\CursoDotnet\\teoria1");
*/


/**************************************************************
//(programa 3 practica 1)
Console.WriteLine("Por favor ingrese su nombre");
string nombre = Console.ReadLine();

if (nombre == "")
{
    Console.WriteLine("\"Hola Mundo\"");
}
else
{
    Console.WriteLine("Buenos dias!!! "+(nombre));
}
*/


/**************************************************************
//(programa 4 A practica 1)
Console.WriteLine("Por favor ingrese su nombre");
string nombre = Console.ReadLine();

if (nombre == "")
{
    Console.WriteLine("\"Buen dia Mundo\"");
}
else if  (nombre == "Juan")
{
    Console.WriteLine("¡Hola Amigo!");
}
else if  (nombre == "Maria")
{
   Console.WriteLine("Buen dia señora"); 
}
else if  (nombre == "Alberto")
{
    Console.WriteLine("Hola Alberto");    
}
else
{
    Console.WriteLine("Buenos dias!!! "+(nombre));
}*/


/**************************************************************
//(program 4 B practica 1)
Console.WriteLine("Por favor ingrese su nombre:");
string name = Console.ReadLine();

switch (name)   
{   
    case "Juan": 
    Console.WriteLine("\"Hola Amigo\"");
    break;

    case "Maria":
    Console.WriteLine("\"Buen dia señora\"");
    break;

    case "Alberto":
    Console.WriteLine("\"Hola Alberto\"");
    break;
    
    case "":
    Console.WriteLine("\"Buen dia Mundo\"");
    break;

    default:
    Console.WriteLine("\"Buen dia "+ (name)+"\"");
    break;
}
*/


/**************************************************************
//(programa 5 practica 1)
string st = "";
int longitud = 0;

Console.WriteLine("Ingrese una cadena de caracteres(nada para salir): ");
st = Console.ReadLine();

while (st != "")
{
    longitud = st.Length;
    Console.WriteLine("El largo de la cadena es: "+ longitud);
    Console.WriteLine("Ingrese una cadena de caracteres(nada para salir): ");
    st = Console.ReadLine();
}
*/


/**************************************************************
//(programa 6 practica 1) 
Console.WriteLine("100".Length);// imprime la cantidad de caracteres dentro de las comillas.
*/

/*
//(programa 7 practica 1)
string st;
Console.WriteLine(st=Console.ReadLine());// imprime en pantalla lo ingresado anteriormente
*/


/**************************************************************
//(programa 8 practica 1)
string st = "";
int longitud = 0;
int divisor = 1;
int inicio = 0;
int veces = 0;
int n = 0;
int m = 1;
string aviso = "";

Console.WriteLine("Ingrese dos palabras con la misma longitud");
st = Console.ReadLine();
longitud = st.Length;
divisor = (longitud - 1)/2;
veces = divisor;


while (veces > 0)
{

    if (st[inicio+n] == st[longitud-m])
    {
        aviso = "Son simetricos";
    }
    else
    {
        aviso = "No son simetricos";
    }

    veces--;
    n++;
    m++;
};
Console.WriteLine(aviso);
*/


/**************************************************************
//(programa 9 practica 1 )
int numero = 1;
while (numero <= 1000)
{
  if (((numero % 17) == 0) & ((numero % 29) == 0))
  {
    Console.WriteLine(numero);
  }
    numero++;
} 
*/


/**************************************************************
//(programa 10 practica 1)
Console.WriteLine("10/3 = " + 10 / 3);
Console.WriteLine("10.0/3 = " + 10.0 / 3);
Console.WriteLine("10/3.0 = " + 10 / 3.0);
int a = 10, b = 3;
Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
Console.WriteLine("entonces a/b =" + a / b);
double c = 3;
Console.Write("Si c es una variable double, c=3");
Console.Write("entonces a/c =" + a / c);
//Respuestas:
// Se puede concluir respecto del operador "/" que devuelve el resultado en el conjunto de los numeros.
//en los intiger recorta la parte decimal y devuelve un int.
//El operador "+" suma en numeros y concatena en los string.
*/


/**************************************************************
//(programa 11 practica 1)

string st = "";
int veces = 1;
int numero = 0;

Console.WriteLine("Por favor ingrese el numero: ");
st = Console.ReadLine();
numero =  int.Parse(st);

while (numero >= veces)
{
    if (numero % veces == 0)
    {
        Console.WriteLine(veces);
    }
    veces++;
}
*/


/**************************************************************
//(programa 12 practica 1)
double numero1;
double numero2;
string st;
double resultado;

Console.WriteLine("Por favor ingrese el primer numero real: ");
st = Console.ReadLine();
numero1 = double.Parse(st);
Console.WriteLine("Por favor ingrese el segundo numero real: ");
st = Console.ReadLine();
numero2 = double.Parse(st);
resultado = numero1 + numero2;
Console.WriteLine("La suma es:"+ resultado);
*/


/**************************************************************
//(programa 13 practica 1)
string numerost;
int numeroint;
int resultado;
int x;
int longitud;

Console.WriteLine("Por favor ingrese el numero: ");
numerost = Console.ReadLine();
numeroint = int.Parse(numerost);
resultado = numeroint * 365;
Console.WriteLine("el resultado es: " + resultado);
numerost = resultado.ToString();
longitud = numerost.Length;
x=1;

while (longitud >=x)
{
    Console.Write(numerost[longitud-x]+" ");
    x++;
}
*/


/**************************************************************
//(programa 14 practico 1)
int year = 0;
string yearst = "";

Console.WriteLine("Ingrese el año: ");
yearst = Console.ReadLine();
year  = int.Parse(yearst);

if (year % 4 == 0)
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0)
        {
            Console.WriteLine("es año bisiesto");
        }
        else
        {
            Console.WriteLine("No es año bisiesto..");
        }
        
    }
    else
    {
        Console.WriteLine("Es año bisiesto");
    }

}
else 
{
    Console.WriteLine("No es año bisiesto");
}
*/


/**************************************************************
//(programa 15 practica 1)
int a = 6;// hacer que la division de mas de 5
int b = 1;// poner en 1 la variable b

if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);

*/

/**************************************************************
//(programa 16 practica 1)

int numero1 = 0;
int numero2 = 0;
string teclado = "";
int resultado = 0;  

Console.WriteLine("Ingrese el primer numero: ");
teclado = Console.ReadLine();
numero1 = int.Parse(teclado);
Console.WriteLine("ingrese el segudo numero: ");
teclado = Console.ReadLine();
numero2 = int.Parse(teclado);
resultado = (numero1 < numero2) ? numero1 : numero2 ;
Console.WriteLine("El numero mas pequeño es:"+ resultado);
*/


/**************************************************************
//(programa 17 practica 1)
for (int i = 0; i <= 4; i++)
{
string st = i < 3 ? i == 2 ? "dos" : i == 1 ? "uno" : "< 1" : i < 4 ? "tres" : "> 3";
Console.WriteLine(st);
}

//salida:
< 1
uno
dos
tres
> 3
*/

/**************************************************************
//(programa 18 practica 1)
int a, b, c; // 1) se puede usar

int a; int b; int c, d;// 2) se puede usar

int a = 1; int b = 2; int c = 3; // 3) a=1 , b=2, c=3

int b; int c; int a = b = c = 1; // 4) a = 1, b=1, c=1

int c; int a, b = c = 1;// 5) a (variable no asignada), b=1 c=1

int c; int a = 2, b = c = 1;// 6) a=2, b=1, c=1


int a = 2, b, c, d = 2 * a;// 7) a=2, b y c no asignadas, d = 4

int a = 2, int b = 3, int c = 4; // 8) faltan poner ";" en lugar de "," para que compile o borrar "int" antes b y c


int a = 2; b = 3; c = 4;// 9) falta poner el tipo de variable "int" antes de b y c


int a; int c = a;// 10) la variable "a" no esta asignada


char c = 'A', string st = "Hola"; // 11) de esperaba un ";" en lugar de la ","


char c = 'A'; string st = "Hola";// 12) c=A , st=Hola


char c = 'A', st = "Hola";// 13) falta cambiar la "," por ";" y agregar string antes de la variable st
*/


/**************************************************************
//(programa 19 practica 1)
int a = 0; // hay que cambiar el nombre de la variable
for (int i = 1; i <= 10;i++)// poner i++ en el for
{
Console.WriteLine(i);// imprimir i
}
*/


/**************************************************************
//(programa 20 practica 1)

int i = 1;
if (--i == 0)// primero realiza la operacion de resta y despues evalua 
{
Console.WriteLine("cero");
}
if (i++ == 0)// primero evalua y luego realiza la operacion de suma
{
Console.WriteLine("cero");
}
Console.WriteLine(i);// la salida por consola es cero, cero, 1
*/