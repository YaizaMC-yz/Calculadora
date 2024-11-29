using System;
using System.Runtime.InteropServices.Marshalling;

class Calculadora
{
static void Main(string[] args)
{

//mensaje para que el usuario introduzca valores
    Console.WriteLine("Introduce los dos valores de la operación"); 


//declaramos variables    
     int num1=0; 
     int num2=0;


//variable para controlar el bucle principal
bool continuar2=true;

//BUCLE PRINCIPAL PARA QUE SE REPITA TODO EL PROGRAMA SI EL USUARIO ASI LO DESEA, SI ELIJE "S" EL PROGRAMA FINALIZA AL FINAL DEL CODIGO
while (continuar2)
{

// solicitamos al usuario la variable actual del bucle 
    for (int i=1; i<=2; i++)    //inicia el contador con 1, el bucle se ejecutara mientras i sea menor o igual a 2, al final de cada bucle i aumenta en 1 por lo tanto se repite dos veces
    {
      Console.Write($"Número {i}: ");    //pedimos al usuario el numero actual del bucle 
      int numero;                        //almacenamos el valor que el usuario ingrese. Esta variable se reutiliza en cada bucle



//bucle que asegura que el numero ingresado es entero y positivo
      while (true)     //con while se reepite el proceso si es entero y positivo
    {


//intenta convertir el valor a numero entero
        if (!int.TryParse(Console.ReadLine(), out numero)) 
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero");
        }
        else if (numero<=0) //Multiples condiciones a evaluar
        {
            Console.WriteLine("El número debe ser positivo. Por favor, ingrese un número entero positivo");
        }



//si el numero es valido y entero salimos del bucle 
    else
    {
        break; //cortamos el bucle 
    }
    }
    
    //guardamos el valor del primer numero que ingrese el usuario
    if (i==1)
    {
        num1=numero;
    }
    
    //guardamos el valor del segundo numero que ingrese el usuario
    else if (i==2)
    {
        num2=numero;
    }


//le confirmamos al usuario los numeros ingresados que ha puesto
    Console.WriteLine($"Número 1 ingresado: {num1}");
    Console.WriteLine($"Número 2 ingresado: {num2}");
    }


//mensajes para que el usuario elija opcion
    Console.WriteLine("\nElija la operación que desea");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. División");


//guardamos el valor introducido por el usuario     
    string input = Console.ReadLine();


//convertimos el valor ingresado a numeros   
    if (int.TryParse(input, out int opcion))
    {

//iniciamos switch para que se efectue la operacion que haya elegido el usuario   
        switch (opcion)
        {
            case 1:
            int suma=num1+num2;
            Console.WriteLine($"El resultado de la suma es: {suma}");
            break;

            case 2:
            int resta=num1-num2;
            Console.WriteLine($"El resultado de la resta es: {resta}");
            break;

            case 3:
            int multiplicacion=num1*num2;
            Console.WriteLine($"El resultado de la multiplicación es: {multiplicacion}");
            break;

            case 4:
            int division=num1/num2;
            Console.WriteLine($"El resultado de la división es: {division}");
            break;

        }
//menu para que el usuario decida si quiere volver al menú    
    Console.WriteLine("\nQuieres salir del menú? (s/n)");
//variable para guardar la respuesta del usuario. Tolower para convertir todo a minuscula y no depender de lo que escriba el usuario    
    string respuesta= Console.ReadLine().ToLower();
    
    if (respuesta != "s")
    {
       bool continuar=true;

    }
     
    }

}
}
}
