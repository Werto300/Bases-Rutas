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
        {
            Bases temp = inicio;

            if (temp.nombre == nombre)
            {
                if (temp.siguiente == inicio)
                    inicio = null;
                else
                {
                    while (temp.siguiente != inicio)
                        temp = temp.siguiente;

                    temp.siguiente = inicio.siguiente;
                    inicio = inicio.siguiente;
                }
            }
            else
            {
                while (temp.siguiente != inicio && temp.siguiente.nombre != nombre)
                    temp = temp.siguiente;

                if (temp.siguiente.nombre == nombre)
                    temp.siguiente = temp.siguiente.siguiente;
            }
        }

        public void EliminarInicio()
        {
            Bases temp = inicio;

            if (temp.siguiente == inicio)
                inicio = null;
            else
            {
                while (temp.siguiente != inicio)
                    temp = temp.siguiente;

                temp.siguiente = inicio.siguiente;
                inicio = inicio.siguiente;
            }
        }

        public void EliminarFinal()
        {
            Bases temp = inicio;

            if (temp.siguiente == inicio)
                inicio = null;
            else
            {
                while (temp.siguiente.siguiente != inicio)
                    temp = temp.siguiente;

                temp.siguiente = inicio;
            }
        }

        public string Reporte()
        {
            string cadena = "";
            Bases temp = inicio;

            if (temp != null)
            {
                while (temp.siguiente != inicio)
                {
                    cadena += temp.ToString();
                    temp = temp.siguiente;
                }

                cadena += temp.ToString();
                return cadena;
            }
            else
                return "";
        }

        public void Insertar(string nombre, Bases nueva)
        {
            Bases temp = Buscar(nombre);

            nueva.siguiente = temp.siguiente;
            temp.siguiente = nueva;
        }

        public string Recorrido(string nombre, int tInicio, int tFinal)
        {
            Bases temp = Buscar(nombre), auxiliar = Buscar(nombre);
            string cadena = "";

            while (temp.siguiente != auxiliar)
            {
                cadena += temp.nombre + "        ";
                temp = temp.siguiente;
            }

            cadena += Convert.ToString(temp.nombre);
            temp = temp.siguiente;
            tInicio -= Convert.ToInt32(temp.minutos);

            while (tInicio <= tFinal)
            {
                tInicio += Convert.ToInt32(temp.minutos);
                if (temp == auxiliar)
                    cadena += Environment.NewLine;

                cadena += tInicio.ToString("0000") + " ";
                temp = temp.siguiente;
            }

            return cadena;
        }
    }
}
