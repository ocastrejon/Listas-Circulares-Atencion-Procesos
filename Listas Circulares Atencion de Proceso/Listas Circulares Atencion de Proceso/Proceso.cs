﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares_Atencion_de_Proceso
{
    class Proceso
    {
        private int _numProceso;
        public int NumProceso { get { return _numProceso; } }

        private int _vidaProceso;
        public int VidaProceso { get { return _vidaProceso; } }

        private int _vidaRestante;
        public int VidaRestante { get { return _vidaRestante; } set { _vidaRestante = value; } }

        private Proceso _siguiente;
        public Proceso Siguiente { get { return _siguiente; } set { _siguiente = value; } }

        private Proceso _anterior;
        public Proceso Anterior { get { return _anterior; } set { _anterior = value; } }

        public Proceso(int numProceso, int vidaProceso)
        {
            this._numProceso = numProceso;
            this._vidaProceso = vidaProceso;
            this._vidaRestante = vidaProceso;
        }

        public override string ToString()
        {
            return "Proceso: " + _numProceso + Environment.NewLine
                 + "Ciclos originales:  " + _vidaProceso + Environment.NewLine
                 + "Ciclos restantes:  " + _vidaRestante + Environment.NewLine
                 + "=================" + Environment.NewLine + Environment.NewLine;
        }
    }
}
