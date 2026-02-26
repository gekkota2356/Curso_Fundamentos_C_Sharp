📘 FUNDAMENTOS DE C#

Material base de sintaxis y estructuras esenciales en C#.
Este documento reúne ejemplos prácticos utilizados para comprender el funcionamiento del lenguaje.

------------------------------------------------------------------------------------------

 CREANDO UN PROYECTO O SOLUCIÓN

Estructura básica para organizar un proyecto en C# dentro del entorno .NET.
-
mkdir HolaMundo
cd HolaMundo
dotnet new sln -n HolaMundo
dotnet new console -n HolaMundoApp
dotnet sln HolaMundo.sln add HolaMundoApp/HolaMundoApp.csproj
dotnet run --project HolaMundoApp
ls
cd "archivo a entrar"

Estos comandos permiten crear la solución, asociar proyectos y ejecutarlos correctamente.

------------------------------------------------------------------------------------------

 EXPLICACIÓN DE TIPOS

C# es un lenguaje fuertemente tipado. Cada variable debe declarar su tipo.

int edad = 20;
long distancia = 15000000000;
short año = 2025;
byte nivel = 255;

float temperatura = 36.5f;
double pi = 3.14159265359;
decimal precio = 199.99m;

bool encendido = true;
bool esMayor = 10 > 5; // Resultado: true

char letra = 'A';
char simbolo = '#';
char numero = '9';

Los tipos determinan el rango, precisión y comportamiento de los datos en memoria.

 Tipos dinámicos
-
Permiten mayor flexibilidad en la declaración de variables.

var numero = 10;    // Compilador lo interpreta como int SOLO int
var texto = "Hola"; // Compilador lo interpreta como string

dynamic dato = 10;
Console.WriteLine(dato); // int

dato = "Texto ahora";    // string
Console.WriteLine(dato);

var se resuelve en compilación.
dynamic se resuelve en ejecución.


 Colecciones
-
Las colecciones permiten almacenar múltiples valores del mismo tipo.

using System.Collections.Generic;
List<int> numeros = new List<int>();

List<T> es una estructura dinámica ampliamente utilizada.

------------------------------------------------------------------------------------------

 EXPLICACIÓN DE OPERADORES

Los operadores permiten realizar operaciones matemáticas, comparaciones y evaluaciones lógicas.

Aritméticos
Operador	Uso	Ejemplo (a = 10, b = 3)	Resultado
+	Suma	a + b	13
-	Resta	a - b	7
*	Multiplic.	a * b	30
/	División	a / b	3 (entera)
%	Módulo	a % b	1 (resto)
Relacionales

Permiten comparar valores y retornan un booleano.

Operador	Significado	Ejemplo (x = 5, y = 8)	Resultado
==	Igual a	x == y	false
!=	Diferente de	x != y	true
>	Mayor que	x > y	false
<	Menor que	x < y	true
>=	Mayor o igual que	x >= y	false
<=	Menor o igual que	x <= y	true
Lógicos

Evalúan condiciones booleanas.

Operador	Uso	Ejemplo (p = true, q = false)	Resultado
&&	AND (y lógico)	p && q	false
||	OR (o lógico)	p || q	true
!	NOT (negación)	!p	false
Lógica Proposicional

Base teórica de los operadores lógicos en programación.
-
Símbolo	Nombre	Lectura
¬p	Negación	No p
p ∧ q	Conjunción	p y q
p ∨ q	Disyunción	p o q

------------------------------------------------------------------------------------------

 MÉTODOS PARA CÁLCULO MATEMÁTICO

La clase Math proporciona funciones matemáticas listas para usar.

double potencia = Math.Pow(2, 3);   // 2^3 = 8
double raiz = Math.Sqrt(25);       // √25 = 5

double x = 3.75;
double redondeo = Math.Round(x);
double techo = Math.Ceiling(x);
double piso = Math.Floor(x);

int negativo = -15;
int absoluto = Math.Abs(negativo);
int signo = Math.Sign(negativo);

int a = 10, b = 20;
int mayor = Math.Max(a, b);
int menor = Math.Min(a, b);

double pi = Math.PI;
double e = Math.E;

double angulo = Math.PI / 2;
double seno = Math.Sin(angulo);
double coseno = Math.Cos(angulo);
double tangente = Math.Tan(angulo);

Incluye funciones de potencia, raíz, redondeo, trigonometría y constantes matemáticas.

------------------------------------------------------------------------------------------
FUNCIONES

Las funciones permiten encapsular lógica reutilizable.

double potencia = Math.Pow(2, 3);
double raiz = Math.Sqrt(25);
double redondeo = Math.Round(3.75);

Facilitan la modularidad y organización del código.

------------------------------------------------------------------------------------------

ESTRUCTURAS DE CONTROL

Controlan el flujo de ejecución del programa.

Condicional
-
int nota = 85;

if (nota >= 90)
{
    Console.WriteLine("Excelente");
}
else if (nota >= 75)
{
    Console.WriteLine("Bueno");
}
else if (nota >= 60)
{
    Console.WriteLine("Suficiente");
}
else
{
    Console.WriteLine("Insuficiente");
}

Condicional Anidado
-
int edad = 20;
bool tieneLicencia = true;

if (edad >= 18)
{
    if (tieneLicencia)
    {
        Console.WriteLine("Puede conducir.");
    }
    else
    {
        Console.WriteLine("Debe obtener una licencia.");
    }
}
else
{
    Console.WriteLine("No puede conducir, es menor de edad.");
}

Operador Ternario
-
Versión compacta de una estructura condicional.

condición ? valorSiTrue : valorSiFalse;

string mensaje = (edad >= 18) 
    ? (tieneLicencia ? "Puede conducir." : "Debe obtener una licencia.") 
    : "No puede conducir, es menor de edad.";

Console.WriteLine(mensaje);

------------------------------------------------------------------------------------------

MANEJO DE EXCEPCIONES

Permite controlar errores en tiempo de ejecución.

try
{
    // Bloque de código que podría generar una excepción
}
catch (TipoDeExcepcion e)
{
    // Código que maneja la excepción
}
finally
{
    // Código que se ejecuta siempre, ocurra o no la excepción
}

Evita que la aplicación finalice de manera inesperada ante fallos.
