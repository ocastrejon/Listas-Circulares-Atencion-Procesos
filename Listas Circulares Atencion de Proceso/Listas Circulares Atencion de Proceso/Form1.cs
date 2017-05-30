using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Circulares_Atencion_de_Proceso
{
    public partial class Form1 : Form
    {

        private ListaProcesos listaProcesos;
        private static Random alea = new Random();
        private static Random aleatorio = new Random();
        private int _probabilidad;
        private int _vidaProceso;
        private int _ciclosOcio;
        private int _numMayorCiclos;
        private int _EnQueCiclo;
        private int _totalProcesosA;
        private string _reporte;

        public Form1()
        {
            InitializeComponent();
            _probabilidad = 0;
            _vidaProceso = 0;
            _ciclosOcio = 0;
            _numMayorCiclos = 0;
            _EnQueCiclo = 0;
            _totalProcesosA = 0;
            _reporte = string.Empty;

            bttonMostrarReportes.Enabled = false;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttonComenzar_Click(object sender, EventArgs e)
        {
            listaProcesos = new ListaProcesos();
            _ciclosOcio = 0;
            _numMayorCiclos = 0;
            _EnQueCiclo = 0;
            _totalProcesosA = 0;
            _reporte = string.Empty;

            bttonMostrarReportes.Enabled = false;
            Comenzar();
            bttonMostrarReportes.Enabled = true;
        }

        private void bttonMostrarReportes_Click(object sender, EventArgs e)
        {
            txtListaProcesosPendientes.Text = listaProcesos.ToString();
            txtCilcosOcio.Text = Convert.ToString(_ciclosOcio);
            txtNumMaximoProcesos.Text = Convert.ToString(_numMayorCiclos + " desde el ciclo " + _EnQueCiclo);
            txtProcesosPendientes.Text = Convert.ToString(listaProcesos.Count);
            txtCiclosPendientes.Text = Convert.ToString(listaProcesos.CiclosPendientes);
            txtProcesosAtendidos.Text = Convert.ToString(_totalProcesosA);

            txtMostrarActividad.Text = _reporte;
        }

        private void Comenzar()
        {
            int num = 1;

            Proceso temp = null;

            for (int i = 1; i <= 200; i++)
            {
                _reporte += "=================" + Environment.NewLine
                          + "Ciclo:  " + i + Environment.NewLine;

                _probabilidad = alea.Next(1, 12);
                _vidaProceso = aleatorio.Next(4, 12);
                if (_probabilidad >= 1 && _probabilidad <= 3)
                {
                    Proceso nuevo = new Proceso(num++, _vidaProceso);
                    listaProcesos.Agregar(nuevo);

                    if (num == 2)
                        temp = listaProcesos.Inicio;

                    _totalProcesosA++;
                }

                if (listaProcesos.Actual() != null)
                {

                    if (listaProcesos.Actual().VidaRestante > 0)
                    {
                        listaProcesos.Actual().VidaRestante -= 1;
                        _reporte += listaProcesos.Actual().ToString();
                        listaProcesos.moverAsiguiente();
                    }
                    else
                    {
                        _reporte += "Proceso: " + listaProcesos.Actual().NumProceso + Environment.NewLine
                                  + "Ciclos originales:  Null" + Environment.NewLine
                                  + "Proceso eliminado" + Environment.NewLine + Environment.NewLine;
                        listaProcesos.Eliminar(listaProcesos.Actual());
                    }
                }
                else
                {
                    _reporte += "Proceso: Sin proceso" + Environment.NewLine
                              + "Ciclos originales:  Null" + Environment.NewLine
                              + "Ciclos restantes:   Null" + Environment.NewLine + Environment.NewLine;
                    _ciclosOcio++;
                }

                if (_numMayorCiclos < listaProcesos.Count)
                {
                    _numMayorCiclos = listaProcesos.Count;
                    _EnQueCiclo = i;
                }
            }
        }
    }
}
