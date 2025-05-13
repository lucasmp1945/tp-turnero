using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IE1
{
    internal class Cola
    {
        public Paciente inicio;
        public Paciente fin;

        public void Insertar(string dni, string nombre, string apellido)
        {
            Paciente nuevo = new Paciente(dni, nombre, apellido);

            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.siguiente = nuevo;
                fin = nuevo;
            }
        }
        public void Listar(ListBox lstEspera)
        {
            lstEspera.Items.Clear();

            bool hayPacientes = false;
            Paciente aux = inicio;

            while (aux != null)
            {
                if (aux.estado != "Eliminado")
                {
                    lstEspera.Items.Add($"{aux.dni} - {aux.nombre} {aux.apellido}");
                    hayPacientes = true;
                }
                aux = aux.siguiente;
            }

            if (!hayPacientes)
            {
                lstEspera.Items.Add("No hay pacientes");
            }
        }


        public List<string> devolverRegistros(bool incluirEliminados = false)
        {
            List<string> lista = new List<string>();
            Paciente aux = inicio;

            while (aux != null)
            {
                if (incluirEliminados || aux.estado != "Eliminado")
                {
                    string registro = aux.dni + "," + aux.nombre + "," + aux.apellido + "," + aux.estado;
                    lista.Add(registro);
                }
                aux = aux.siguiente;
            }

            return lista;
        }


        public void Eliminar()
        {
            Paciente aux = inicio;
            inicio = inicio.siguiente;
            aux = null;
        }

        public void InsertarExistente(Paciente p)
        {
            if (inicio == null)
            {
                inicio = p;
                fin = p;
            }
            else
            {
                fin.siguiente = p;
                fin = p;
            }
        }

    }
}
