using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCastilloSP4
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Declaración de Matriz
        float[,] vecDatos = new float[5, 5];

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
            foreach (string mozo in mozos)
            {
                int index = dgvDatos.Rows.Add();
                dgvDatos.Rows[index].HeaderCell.Value = mozo;
            }

            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.RowHeadersWidth = 100;

            dgvDatos.CurrentCell = dgvDatos.Rows[0].Cells[1];

            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                for (int j = 0; j < dgvDatos.Columns.Count; j++)
                {
                    dgvDatos.Rows[i].Cells[j].Value = "0";
                }
            }
        }

        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            bool datosValidos = true;
            //recorrer la grilla
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                for (int j = 0; j < dgvDatos.Columns.Count; j++)
                {
                    object valor = dgvDatos.Rows[i].Cells[j].Value;
                    //validar que no este vacio
                    if (valor == null || string.IsNullOrWhiteSpace(valor.ToString()))
                    {
                        datosValidos = false;
                        break;
                    }
                    //validar que sean numeros
                    if (!float.TryParse(valor.ToString(), out _))
                    {
                        datosValidos = false;
                        break;
                    }
                }
                if (!datosValidos)
                    break;
            }

            //muestro el resultado
            if (!datosValidos)
            {
                MessageBox.Show("Error: todas las celdas deben contener valores numéricos (puede ser 0).",
                                "Datos inválidos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                btnMozo.Enabled = false;
                btnTotal.Enabled = false;
            }
            else
            {
                MessageBox.Show("Datos validados correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                btnMozo.Enabled = true;
                btnTotal.Enabled = true;
            }
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
            float[,] ventas = new float[5, 4];
            //cargo los valores de la grilla en una matriz
            // C# - opción simple: saltar filas "nuevas"
            int rowCount = dgvDatos.Rows.Count - (dgvDatos.AllowUserToAddRows ? 1 : 0);
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < dgvDatos.Columns.Count; j++)
                {
                    if (dgvDatos.Rows[i].IsNewRow) continue;
                    ventas[i, j] = float.Parse(dgvDatos.Rows[i].Cells[j].Value.ToString());
                }
            }
            //calculo el total para cada mozo
            float[] totalPorMozo = new float[5];
            for (int i = 0; i < 5; i++)
            {
                float total = 0;
                for (int j = 0; j < 4; j++)
                    total += ventas[i, j];
                totalPorMozo[i] = total;
            }
            //busco el numero maximo
            float maxTotal = totalPorMozo.Max();
            //busco los mozos con ese numero para ver si hay empate
            var mozosEmpatados = new List<string>();
            for (int i = 0; i < mozos.Length; i++)
            {
                if (totalPorMozo[i] == maxTotal)
                    mozosEmpatados.Add(mozos[i]);
            }
            //muestro resultado
            txtImporteMozo.Text = maxTotal.ToString("0.00");
            if (mozosEmpatados.Count == 1)
            {
                txtNombreMozo.Text = mozosEmpatados[0];
            }
            else
            {
                txtNombreMozo.Text = string.Join(", ", mozosEmpatados);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int rowCount = dgvDatos.Rows.Count - (dgvDatos.AllowUserToAddRows ? 1 : 0);
            int colCount = dgvDatos.Columns.Count;

            float[,] ventas = new float[rowCount, colCount];

            // Cargo los valores de la grilla a la matriz (parse seguro)
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    var cell = dgvDatos.Rows[i].Cells[j].Value;
                    if (!float.TryParse(cell?.ToString() ?? "0", out float v))
                        v = 0f;
                    ventas[i, j] = v;
                }
            }

            // Calculo totales por categoría (columnas)
            float[] totalesCategoria = new float[colCount];
            float totalGeneral = 0f;
            for (int j = 0; j < colCount; j++)
            {
                float suma = 0f;
                for (int i = 0; i < rowCount; i++)
                    suma += ventas[i, j];
                totalesCategoria[j] = suma;
                totalGeneral += suma;
            }

            // Mostrar resultado (usar los totales calculados)
            lstTotales.Items.Clear();
            lstTotales.Items.Add($"Comida: {totalesCategoria[0]:0.00}");
            lstTotales.Items.Add($"Bebidas sin alcohol: {totalesCategoria[1]:0.00}");
            lstTotales.Items.Add($"Bebidas con alcohol: {totalesCategoria[2]:0.00}");
            lstTotales.Items.Add($"Postres: {totalesCategoria[3]:0.00}");
            lstTotales.Items.Add($"TOTAL GENERAL: {totalGeneral:0.00}");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstTotales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


