
/*
 * 1. Describa en sus propias palabras el concepto de colecciones (collections) y cuales tipos existen.
        RESULTADO: Forma de trabajar mas facil los objetos y valores, el collections sera una clase
                   ademas solo contiene elementos de un tio de datos, los tipos que existen son:
                    non-generic collections
                    generic collections 
//---------------------------------------------------------------------------------------------------------------------------------------------------------
   2.Defina a que se refiere el concepto de código no seguro y que se necesita para implementarlo.
         RESULTADO: La implementacion de punteros, lo que le permite al proframa  ejecuarse fuera dle recolector de basura, asi mismo nos ayuda
                     a acceder a segmentos de memoria. 
                    Para poder implementar el uso de codigo no seguro utilizamos como modificador unsafe el cual nos ayudara en el contructor, 
                    metodo, y propiedad, con el fin de definir un conjunto de codigo.
 ---------------------------------------------------------------------------------------------------------------------------------------------------------                   
   3.Mencione al menos tres clases que se utilizan en lo y proporcione brevemente la idea central de las mismas.
        RESULTADO: 
                       MemoryStream: Los bytes se escriben y se leen desde y hacia la memoria.
                       PipeStream: Los bytes se escriben y se leen desde los direntes y hacia los diferentes procesos.
                       BufferedStream: Los bytes se escriben y se leen hasta y  hacia otros Streams con el fin de mejorar el rendimiento de salida y entrada de operaciones 
---------------------------------------------------------------------------------------------------------------------------------------------------------
   4. Explique la diferencia entre los siguientes códigos en csharp
        a. Console. Writeline ("resultado: (*ptr) ").
            RESULTADO: No especifica el tipo de dato a imprimir, por ende dara cualquier tipo de dato que se le haya guardado
        b. Console.WriteLine("resultado: ((int)ptr)")
            RESULTADO:  Se intacia a int con el fin de recordarle los valores que se estaran manejando dentro de la variable e imprimir el tipo de dato que se guardo.  
---------------------------------------------------------------------------------------------------------------------------------------------------------
   5.Mencione al menos tres caracteristicas de las excepciones (Exceptions).
        RESULTADO: 
                    1.-Contiene la informacion necesaria sobre el error producido. 
                    2.-Cualquier clase de exceptions se originan directamente o indirectamente de la Clase Exception. 
                    3.-Sus clases principales son SystemException:clase base que genera todos los errores del CLR 
                    ApplicationException: Clase base el cual estan todas las excepciones que tengan relacion con tu aplicacion. 
---------------------------------------------------------------------------------------------------------------------------------------------------------                                  
   6.En Java, mencione y describa los tres tipos de excepciones.
        RESULTADO:
                    1.-Checked exceptions: Son las excepciones que una aplicacion en java debe de ser frente, es decir.- si una aplicación lee datos de un archivo, debería poder controlar el archivo 
                    2.-Runtime exception: Al compilar el codigo, si el programador ha cometido un error en el codigo, al compilador lo pasa por bueno no obstante al momento de ejecutar 
                        lanzara ya sea una matriz que no existe o un valor nulo
                    3.- Unchecked exceptions.- Error externo que se genera en la aplicacion 
---------------------------------------------------------------------------------------------------------------------------------------------------------
   7. Explique brevemente a que se refiere con directivas para preprocesador y que se necesita para usarlas.
        RESULTADO: Asignación de instrucciones que se le dan al compilador con el fin de analizar la informacion, antes de compilar. 
                   Se debera de inciar con # gato y omitir el punto y coma ;
                   Asi mismo deberan de ser las unicas instrucciones en linea
                   Alguna de ellas son: #define   #elif   #warning  #error entre otras
 ---------------------------------------------------------------------------------------------------------------------------------------------------------
                   8. Explique las diferencias entre ArrayList, Sorted List Hash Table.
        RESULTADO: 
                 1.-ArrayList.- Matriz que va en crecimiento y no se necesita especificar el tamaño del arreglo
                 2.-Sorted List Hash Table.- Se utiliza para almacenar pares, siendo uno  para la llave y el otro sera el valor. Con el fin de utilizar la llave dada, 
                    para recuperar los valores. 
---------------------------------------------------------------------------------------------------------------------------------------------------------                    
   9. Describa las para que sirven StreamReader y StreamWriter
        RESULTADO: 
                StreamReader.-

                StreamWriter.- 
---------------------------------------------------------------------------------------------------------------------------------------------------------
   10. Explique el funcionamiento del algoritmo Quicksort
        RESULTADO: 
                    Dicho algoritmo inicializara siendo el pivote que nos ayudara a particionar la lista de elementos generada en dos partes. 
                    Teniendo como regla si los pivotes son mayores estaran en la derecha, y si son menores iran a la izquierda. 
 ---------------------------------------------------------------------------------------------------------------------------------------------------------                   
   11. En Java, explique cuál es la diferencia entre System.out, System.in y System.err
        RESULTADO: 
                 System.out.- Salida estandar que nos dara el codigo al ser compilado. 
                 System.in.- Es la entrada de datos que provengan desde el teclado. 
                 System.err.- Salida que nos informara un error en el codigo. 
--------------------------------------------------------------------------------------------------------------------------------------------------------- 
   12. Explique cuáles son las ventajas de utilizar "generic collections"
        RESULTADO: 
        generic collections. -
                    *.-Reutilizacion de codigo
                    *.-Se pueden acceder los valores mediante un foreach
                    *.-Rendimiento
                    *.-Seguridad de tipos
                    *.-




 */
using System;

namespace PREGUNTAS_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
