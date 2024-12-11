using System;

namespace CuestionarioLudopatia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tBienvenido al cuestionario sobre ludopatía.");
            Console.WriteLine("Este cuestionario consta de 15 preguntas.");
            Console.WriteLine("Por favor, responde con sinceridad.");
            Console.WriteLine("Para responder escribe el numero de tu respuesta y presiona enter");

            int puntaje = 0;
            int respuesta;

            // Pregunta 1
            Console.WriteLine("\nPregunta 1:");
            Console.WriteLine("¿Con qué frecuencia sientes la necesidad irresistible de jugar?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 2
            Console.WriteLine("\nPregunta 2:");
            Console.WriteLine("¿Cuánto tiempo dedicas, en promedio, a jugar en una sola sesión?");
            Console.WriteLine("1. Menos de 30 minutos");
            Console.WriteLine("2. Entre 30 minutos y 1 hora");
            Console.WriteLine("3. Entre 1 y 2 horas");
            Console.WriteLine("4. Entre 2 y 4 horas");
            Console.WriteLine("5. Más de 4 horas");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 3
            Console.WriteLine("\nPregunta 3:");
            Console.WriteLine("¿Has tenido que mentir a tus seres queridos sobre cuánto juegas o cuánto dinero gastas en juegos de azar?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 4
            Console.WriteLine("\nPregunta 4:");
            Console.WriteLine("¿Has descuidado tus responsabilidades (trabajo, estudios, familia) debido al juego?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 5
            Console.WriteLine("\nPregunta 5:");
            Console.WriteLine("¿Has utilizado dinero destinado a otras cosas (comida, vivienda, etc.) para jugar?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 6
            Console.WriteLine("\nPregunta 6:");
            Console.WriteLine("¿Has intentado reducir o dejar de jugar y no lo has conseguido?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 7
            Console.WriteLine("\nPregunta 7:");
            Console.WriteLine("¿Has sentido culpa o vergüenza después de jugar?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 8
            Console.WriteLine("\nPregunta 8:");
            Console.WriteLine("¿Has tenido problemas financieros debido al juego (deudas, embargos)?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 9
            Console.WriteLine("\nPregunta 9:");
            Console.WriteLine("¿Has cometido actos ilegales (robar, estafar) para obtener dinero para jugar?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 10
            Console.WriteLine("\nPregunta 10:");
            Console.WriteLine("¿Has pensado en el suicidio debido a problemas relacionados con el juego?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 11
            Console.WriteLine("\nPregunta 11:");
            Console.WriteLine("¿Sientes que necesitas jugar para sentirte bien o relajado?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 12
            Console.WriteLine("\nPregunta 12:");
            Console.WriteLine("¿Has puesto en riesgo tu salud física o mental debido al juego?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 13
            Console.WriteLine("\nPregunta 13:");
            Console.WriteLine("¿Has descuidado tu apariencia personal o higiene debido al juego?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 14
            Console.WriteLine("\nPregunta 14:");
            Console.WriteLine("¿Has tenido problemas en tus relaciones personales debido al juego?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;

            // Pregunta 15
            Console.WriteLine("\nPregunta 15:");
            Console.WriteLine("¿Crees que necesitas apostar cantidades cada vez mayores para sentir la misma emoción?");
            Console.WriteLine("1. Nunca");
            Console.WriteLine("2. Rara vez");
            Console.WriteLine("3. A veces");
            Console.WriteLine("4. Frecuentemente");
            Console.WriteLine("5. Siempre");

            respuesta = int.Parse(Console.ReadLine());
            puntaje += respuesta;


            // Evaluación del puntaje
            Console.WriteLine("\nResultados:");
            if (puntaje <= 25)
            {
                Console.WriteLine("Tu puntaje indica un bajo riesgo de ludopatía.");
            }
            else if (puntaje <= 50)
            {
                Console.WriteLine("Tu puntaje sugiere un riesgo moderado de ludopatía. Considera buscar ayuda profesional.");
            }
            else
            {
                Console.WriteLine("Tu puntaje indica un alto riesgo de ludopatía. Es fundamental que busques ayuda especializada lo antes posible.\n");
            }
        }
    }
}