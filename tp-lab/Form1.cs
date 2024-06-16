using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_lab
{
    public partial class Form1 : Form
    {
        int total = 0;

        string[,] sectorSeleccionado;

        string[,] campo = new string[1, 1];
        string[,] plateaAlta = new string[2, 2];
        string[,] plateaBaja = new string[2, 2];

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewData.Columns.Add("col1", "dni");
            dataGridViewData.Columns.Add("col2", "fila");
            dataGridViewData.Columns.Add("col3", "asiento");
            dataGridViewData.Columns.Add("col3", "sector");

            comboBoxCampo.Items.Add("campo");
            comboBoxCampo.Items.Add("platea alta");
            comboBoxCampo.Items.Add("platea baja");
        }

        private void imprimirGrilla(string[,] matriz, string sector, bool limpiar = true)
        {
            if (limpiar)
            {
                dataGridViewData.Rows.Clear();

                for (int row = 0; row < matriz.GetLength(0); row++)
                {
                    for (int col = 0; col < matriz.GetLength(1); col++)
                    {
                        if (matriz[row, col] != null)
                        {
                            dataGridViewData.Rows.Add(matriz[row, col], row, col, sector);
                        }
                    }
                }
            } else
            {
                for (int row = 0; row < matriz.GetLength(0); row++)
                {
                    for (int col = 0; col < matriz.GetLength(1); col++)
                    {
                        if (matriz[row, col] != null)
                        {
                            dataGridViewData.Rows.Add(matriz[row, col], row, col, sector);
                        }
                    }
                }
            }
        
        }

        private bool verificacion(string dni)
        {
            for (int row = 0; row < sectorSeleccionado.GetLength(0); row++)
            {
                for (int col = 0; col < sectorSeleccionado.GetLength(1); col++)
                {
                    if (sectorSeleccionado[row, col] == dni)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = comboBoxCampo.SelectedIndex;
            
            if(seleccion == 0)
            {
                sectorSeleccionado = campo;
                return;
            }

            if (seleccion == 1)
            {
                sectorSeleccionado = plateaAlta;
                return;
            }

            if (seleccion == 2)
            {
                sectorSeleccionado = plateaBaja;
                return;
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            string texto;
            string dni = textBoxDni.Text;

            if(sectorSeleccionado == plateaBaja)
            {
                texto = "platea Baja";
            } else if (sectorSeleccionado == plateaAlta)
            {
                texto = "platea Alta";
            } else
            {
                texto = "campo";
            }

            if (!verificacion(dni))
            {
                for (int row = 0; row < sectorSeleccionado.GetLength(0); row++)
                {
                    for (int col = 0; col < sectorSeleccionado.GetLength(1); col++)
                    {
                        if (sectorSeleccionado[row, col] == null)
                        {
                            sectorSeleccionado[row, col] = dni;
                            imprimirGrilla(sectorSeleccionado, texto);
                            total +=1;
                            labelOcupacionActual.Text = total.ToString();
                            return;
                        }
                    }
                }

            } else
            {
                MessageBox.Show("dni ya ingresado");
                return;
            }

        MessageBox.Show("No hay lugares.");
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Clear();

            Array.Clear(campo, 0, campo.Length);
            Array.Clear(plateaAlta, 0, plateaAlta.Length);
            Array.Clear(plateaBaja, 0, plateaBaja.Length);
            Array.Clear(sectorSeleccionado, 0, sectorSeleccionado.Length);
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Clear();

            imprimirGrilla(campo, "campo", false);
            imprimirGrilla(plateaAlta, "platea alta", false);
            imprimirGrilla(plateaBaja, "platea baja", false);
        }
    }
     
}
