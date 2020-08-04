﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerFinalNorthWind.crud;

namespace TallerFinalNorthWind.menus
{
    public class MenuEmpleados
    {
        public void mostrarMenuEmpleados()
        {
            string menu = "";
            int opcion = 0;

            menu = "MENÚ DE OPCIONES DEL GESTOR CRUD DE LA TABLA EMPLEADOS \n" +
                         "1.  Insertar Registro \n" +
                         "2.  Modificar Registro \n" +
                         "3.  Consultar Registro \n" +
                         "4.  Volver al menú anterior \n" +


                         "Ingrese una opción: ";

            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("APLICACIÓN C# PARA VISUALIZAR EL FUNCIONAMIENTO DE LAS OPERACIONES CRUD");
            Console.WriteLine("EN UNA TABLA DE MS SQL SERVER");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");

            CrudEmpleados ejecutarOpcionCrudEmpleados = new CrudEmpleados();

            do
            {
                Console.WriteLine(menu);
                opcion = Int32.Parse(System.Console.ReadLine());

              
                ejecutarOpcionCrudEmpleados.ejecutarOpcionEmpleados(opcion);


            } while (opcion != 4);

            Console.WriteLine("El programa ha terminado");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
        }

    }
}
