using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{

    /*Integrantes del grupo:
 * Nombre: Luna Santiago
    DNI: 43362162
 *Nombre: Lopez Alvaro Mauricio
    DNI: 43771195
 *Nombre: Ivan Kameyha
    DNI: 44377298
*Nombre: Nicolas Martinez Castro
    DNI: 44373389

    COMISION 6
 */

    class Program
    {
        static void Main(string[] args)
        {
            const int FILAS = 2;
            const int COLUMNAS = 10;

            const int VALOR_VIAJE = 42;
            
            int[,] matriz = new int[FILAS, COLUMNAS];

            int opcion = 0;

            int tarjeta = 0;

            int monto = 0;
            int tarjetaOrigen = 0;
            int tarjetaDestino = 0;

            int montoATransferir = 0;

            int tarjetaFrecuente = 0;
            int saldoTotal = 0;
            
            GenerarMatriz(matriz);

            do
            {
                Console.Clear();
                opcion = Menu();
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Registrar Viaje");
                            Console.WriteLine();
                            Console.Write("Numero de Tarjeta: ");
                            tarjeta = Int32.Parse(Console.ReadLine());
                            Console.WriteLine();

                            // Verificar si la tarjeta existe
                            if ((tarjeta >= 0) && (tarjeta < COLUMNAS))
                            {
                                if (matriz[0, tarjeta] >= VALOR_VIAJE)
                                {
                                    Console.WriteLine("VIAJE APROBADO");

                                    // Actualizar saldo
                                    matriz[0, tarjeta] = matriz[0, tarjeta] - VALOR_VIAJE;

                                    // Actualizar cantidad de viajes
                                    // matriz[1, tarjeta]++
                                    matriz[1, tarjeta] = matriz[1, tarjeta] + 1;

                                    Console.WriteLine();
                                    Console.WriteLine($"Su Nuevo Saldo es: ${matriz[0, tarjeta]}");
                                }
                                else
                                {
                                    Console.WriteLine("SALDO INSUFICIENTE.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("ERROR: Numero de Tarjeta inexistente...");
                            }

                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Ingresar Dinero");
                            Console.WriteLine();
                            Console.Write("Numero de Tarjeta: ");
                            tarjeta = Int32.Parse(Console.ReadLine());
                            Console.WriteLine();

                            // Verificar si la tarjeta existe
                            if ((tarjeta >= 0) && (tarjeta < COLUMNAS))
                            {
                                Console.WriteLine($"Saldo actual: ${matriz[0, tarjeta]}");
                                Console.WriteLine();
                                Console.Write("Monto a ingresar: $");
                                monto = Int32.Parse(Console.ReadLine());

                                if (monto > VALOR_VIAJE)
                                {
                                    // Actualizar saldo
                                    matriz[0, tarjeta] = matriz[0, tarjeta] + monto;
                                    Console.WriteLine();
                                    Console.WriteLine($"CARGA EXITOSA");
                                    Console.WriteLine($"Su Nuevo Saldo es: ${matriz[0, tarjeta]}");
                                }
                                else
                                {
                                    Console.WriteLine($"ERROR. Debe ingresar un monto minimo de $ {VALOR_VIAJE}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("ERROR: Numero de Tarjeta inexistente...");
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Transferir Saldo");
                            Console.WriteLine();

                            Console.Write("Tarjeta de Origen: ");
                            tarjetaOrigen = Int32.Parse(Console.ReadLine());

                            // Verificar si la tarjeta existe
                            if ((tarjetaOrigen >= 0) && (tarjetaOrigen < COLUMNAS))
                            {
                                Console.Write("Tarjeta de Destino: ");
                                tarjetaDestino = Int32.Parse(Console.ReadLine());

                                // Verificar si la tarjeta existe
                                if ((tarjetaDestino >= 0) && (tarjetaDestino < COLUMNAS))
                                {

                                    Console.Write("Monto a Transferir: ");
                                    montoATransferir = Int32.Parse(Console.ReadLine());

                                    if ((montoATransferir >= VALOR_VIAJE) && (montoATransferir <= matriz[0, tarjetaOrigen]) && (matriz[0, tarjetaOrigen] >= VALOR_VIAJE))
                                    {
                                        // Actualizar los saldos
                                        Console.WriteLine("TRANSFERENCIA EXITOSA");
                                        // En la tarjeta de Origen
                                        matriz[0, tarjetaOrigen] = matriz[0, tarjetaOrigen] - montoATransferir;

                                        // En la tarjeta de Destino
                                        matriz[0, tarjetaDestino] = matriz[0, tarjetaDestino] + montoATransferir;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("ERROR. No se puede realizar la transferencia...");
                                        Console.WriteLine("El saldo de la tarjeta origen es insuficiente para realizar la operación.");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("ERROR: Tarjeta de Destino inexistente...");
                                }
                            }
                            else
                            {
                                Console.WriteLine("ERROR: Tarjeta de Origen inexistente...");
                            }


                            break;
                        }

                    case 4:
                        {
                            // Creamos un nuevo vector para sacar el maximo de viajes
                            int[] vector = new int[10];
                            int contador = 0;

                            // Utilizamos este for para recorrer la por la matriz de los viajes
                            for (int i = 0; i < 10; i++)
                            {
                                vector[i] = matriz[1, contador];
                                contador = contador + 1;
                            }

                            // Guardamos el maximo de viajes en tarjetaFrecuente
                            tarjetaFrecuente = vector.Max();
                            contador = -1;

                            // Hallamos la tarjeta
                            do
                            {
                                contador = contador + 1;

                            } while (tarjetaFrecuente != matriz[1, contador]);

                            Console.WriteLine("Tarjeta Frecuente: " + contador);
                            Console.WriteLine("Viajes realizados: " + vector.Max());
                            
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Saldo Total resguardado por la empresa: $" + saldoTotal);
                            saldoTotal = matriz[0, 0] + matriz[0, 1] + matriz[0, 2] + matriz[0, 3] + matriz[0, 4] + matriz[0, 5] + matriz[0, 6] + matriz[0, 7] + matriz[0, 8] + matriz[0, 9];
                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("Estado del Sistema");
                            Console.WriteLine("──────────────────");
                            Console.WriteLine();
                            GenerarMatriz(matriz);
                            break;
                        }

                    case 0:
                        {
                            Console.WriteLine("Fin del programa...");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Opcion incorrecta...");
                            break;
                        }

                } // switch

                Console.ReadKey();

            } while (opcion != 0);

        }
        
        static public void GenerarMatriz(int[,] mat)
        {
            Random generador = new Random();

            Console.WriteLine("       │               NUMERO DE TARJETA");
            Console.WriteLine("  ███  ├──────────────────────────────────────────────────");
            Console.WriteLine("       │   0    1    2    3    4    5    6    7    8    9");

            for (int filas = 0; filas < mat.GetLength(0); filas++)
            {
                Console.WriteLine("───────┼──────────────────────────────────────────────────");
                if (filas == 0)
                {
                    Console.Write("SALDOS │ ");
                }
                else
                {
                    Console.Write("VIAJES │ ");
                }

                for (int columnas = 0; columnas < mat.GetLength(1); columnas++)
                {
                    if (filas == 0)
                    {
                        mat[filas, columnas] = generador.Next(50) * 7;
                        Console.Write($"{mat[filas, columnas].ToString("$000")} ");
                    }
                    else
                    {
                        Console.Write($"{mat[filas, columnas].ToString(" 000")} ");
                    }
                   
                }

                Console.WriteLine();
                
            }

        }

        static public int Menu()
        {
            int opcion = 0;

            Console.WriteLine("ACTIVIDAD DE PASAJEROS");
            Console.WriteLine("──────────────────────");
            Console.WriteLine("1- Registrar Viaje");
            Console.WriteLine("2- Ingresar Dinero");
            Console.WriteLine("3- Transferir Saldo");
            Console.WriteLine("4- Pasajero mas frecuente");
            Console.WriteLine("5- Saldo Total");
            Console.WriteLine("6- Mostrar Estado");
            Console.WriteLine("0- Salir");
            Console.WriteLine();
            Console.Write("Opcion: ");
            opcion = Int32.Parse(Console.ReadLine());

            return opcion;
        }

    }
}
