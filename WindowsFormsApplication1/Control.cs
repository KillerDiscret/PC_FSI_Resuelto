using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Control
    {
        //Control obj
        public static List<Cuartel>Cuarteles { get; set; }
        public static List<Soldado> ListaSoldados { get; set; }
        public Control()
        {
            if(Cuarteles==null)
            {
                Cuarteles = new List<Cuartel>();

            }
            if(ListaSoldados==null)
            {
                ListaSoldados = new List<Soldado>();
            }
        }
        public bool CuartelExiste(string codigo)
        {
            return Cuarteles.Exists(delegate(Cuartel x) { return x.CODIGO == codigo; });
        }
        public void AgregarCuartel(Cuartel obj)
        {
            Cuarteles.Add(obj);
        }
        public void AgregarSoldado(string codigocuartel,Soldado obj)
        {
            foreach(Cuartel aux in Cuarteles)
            {
                if(aux.CODIGO==codigocuartel)
                {
                    aux.Soldados.Add(obj);
                }
            }
            ListaSoldados.Add(obj);
        }
        public bool SoldadoExiste(string DNIsoldado)
        {
            return ListaSoldados.Exists(delegate(Soldado x) { return x.DNI == DNIsoldado; });
        }
        public List<Cuartel> ListarCuartelesMayorEdad()
        {
            int edadaux = 0;
            foreach(Soldado x in ListaSoldados)
            {
                if(x.EDAD>edadaux)
                {
                    edadaux = x.EDAD;
                }
            }
            List<Cuartel> ListaAux = new List<Cuartel>();
            foreach(Cuartel x in Cuarteles)
            {
                foreach(Soldado y in x.Soldados)
                {
                    if(y.EDAD==edadaux)
                    {
                        ListaAux.Add(x);
                    }
                }
            }

            return ListaAux;
        }
        public List<Cuartel> ListarCuartelesMayorSoldados(string especialidad)
        {
            int auxcantidad = 0;
            int auxcantidad2 = 0;

            foreach (Cuartel x in Cuarteles)
            {
                foreach(Soldado y in x.Soldados)
                {
                    if(y.ESPECIALIDAD==especialidad)
                    {
                        auxcantidad=auxcantidad +1;
                        
                    }
                }
                if(auxcantidad>auxcantidad2)
                {
                    auxcantidad2 = auxcantidad;
                    auxcantidad = 0;
                }
            }
            //ahora auxcantidad2 tiene la mayor cantidad de soldadados de esa especialidad
            List<Cuartel> listaAux = new List<Cuartel>();
            foreach (Cuartel x in Cuarteles)
            {
                foreach (Soldado y in x.Soldados)
                {
                    if (y.ESPECIALIDAD == especialidad)
                    {
                        auxcantidad = auxcantidad + 1;

                    }
                }
                if (auxcantidad==auxcantidad2)
                {
                    listaAux.Add(x);
                    auxcantidad = 0;
                }
            }
            return listaAux;
        }
        public List<string> MostrarEspecialidadMenor()
        {
            int infanteria = 0;
            int artilleria = 0;
            int comunicacion = 0;
            int aux=0;
            List<string> listaEspecialidad = new List<string>();
            foreach(Cuartel x in Cuarteles)
            {
                foreach(Soldado y in x.Soldados)
                {
                    if(y.ESPECIALIDAD=="Infantería")
                    {
                        infanteria = infanteria + 1;
                    }
                    if(y.ESPECIALIDAD=="Artillería")
                    {
                        artilleria = artilleria + 1;
                    }
                    if(y.ESPECIALIDAD=="Comunicación")
                    {
                        comunicacion = comunicacion + 1;
                    }
                }
            }
            if(infanteria<=artilleria&&infanteria<=comunicacion)
            {
                aux = infanteria;
            }
            if (artilleria <= infanteria && artilleria <= comunicacion)
            {
                aux = artilleria;
            }
            if (comunicacion <= artilleria && comunicacion <= infanteria)
            {
                aux = comunicacion;
            }
            
            if( aux == infanteria)
            {
                listaEspecialidad.Add("Infantería");
            }
            if (aux == artilleria)
            {
                listaEspecialidad.Add("Artillería");
            }
            if (aux == comunicacion)
            {
                listaEspecialidad.Add("Comunicación");
            }
            return listaEspecialidad;
        }

        public List<Soldado> MostrarEdadPromedio()
        {
            int infanteria = 0;
            int continfanteria = 0;
            int artilleria = 0;
            int contartilleria = 0;
            int comunicacion = 0;
            int contcomunicacion = 0;

            foreach (Cuartel x in Cuarteles)
            {
                foreach (Soldado y in x.Soldados)
                {
                    if (y.ESPECIALIDAD == "Infantería")
                    {
                        infanteria = infanteria + y.EDAD;
                        continfanteria = continfanteria + 1;
                    }
                    if (y.ESPECIALIDAD == "Artillería")
                    {
                        artilleria = artilleria + y.EDAD;
                        contartilleria = contartilleria + 1;
                    }
                    if (y.ESPECIALIDAD == "Comunicación")
                    {
                        comunicacion = comunicacion + y.EDAD;
                        contcomunicacion = contcomunicacion + 1;
                    }
                }
            }
            List<Soldado> listaAux = new List<Soldado>();
            Soldado obj1 = new Soldado();
            Soldado obj2 = new Soldado();
            Soldado obj3 = new Soldado();
            obj1.ESPECIALIDAD = "Infantería";
            if(continfanteria!=0)
            {
                obj1.EDAD = (infanteria / continfanteria);
            }
            else
            {
                obj1.EDAD = (0);
            }
            
            listaAux.Add(obj1);
            obj2.ESPECIALIDAD = "Artillería";
            if (contartilleria != 0)
            {
                obj2.EDAD = (artilleria / contartilleria);
            }
            else
            {
                obj2.EDAD = (0);
            }
            
            listaAux.Add(obj2);
            obj3.ESPECIALIDAD = "Comunicación";
            if (contcomunicacion != 0)
            {
                obj3.EDAD = (comunicacion / contcomunicacion);
            }
            else
            {
                obj3.EDAD = (0);
            }
         
            listaAux.Add(obj3);

            return listaAux;
        }




    }
}
