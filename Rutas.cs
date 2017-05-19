using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases_Rutas
{
    class Rutas
    {
        Bases inicio = null;
        bool encontrado = false;

        public void Agregar(Bases nueva)
        {
            Bases temp = inicio;

            if (inicio == null)
            {
                inicio = nueva;
                nueva.siguiente = inicio;
            }
            else
            {
                Buscar(nueva.nombre);
                if (encontrado != true)
                {
                    while (temp.siguiente != inicio)
                        temp = temp.siguiente;

                    temp.siguiente = nueva;
                    nueva.siguiente = inicio;
                }
            }
        }

        public void AgregarInicio(Bases nueva)
        {
            Bases temp = inicio;

            if (inicio == null)
            {
                inicio = nueva;
                nueva.siguiente = inicio;
            }
            else
            {
                Buscar(nueva.nombre);
                if (encontrado != true)
                {
                    while (temp.siguiente != inicio)
                        temp = temp.siguiente;

                    nueva.siguiente = inicio;
                    inicio = nueva;
                    temp.siguiente = inicio;
                }
            }
        }

        public Bases Buscar(string nombre)
        {
            Bases temp = inicio;
            encontrado = false;

            while (temp.siguiente != inicio && temp.nombre != nombre)
                temp = temp.siguiente;

            if (temp.nombre == nombre)
                encontrado = true;

            if (encontrado == true)
                return temp;
            else
                return null;
        }

        public void Eliminar(string nombre)
