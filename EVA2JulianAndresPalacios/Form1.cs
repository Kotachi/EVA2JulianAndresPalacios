using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVA2JulianAndresPalacios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conexion ventana1 = new Conexion();
        int celda;
        double promedio;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iPLEONESDataSet.notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.iPLEONESDataSet.notas);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.notasTableAdapter.FillBy(this.iPLEONESDataSet.notas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnBuscarDG_Click(object sender, EventArgs e)
        {
            int celda = buscarCodigo(txtBuscarDG.Text);
            promedio=promNotas(celda);

        }

        private void btnPromMate_Click(object sender, EventArgs e)
        {
            int i = 0, y = 9;
            promNotasGrupo(i, y);
        }

        private void btnPromProg_Click(object sender, EventArgs e)
        {
            int i = 8, y = 17;
            promNotasGrupo(i, y);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnRepitentes_Click(object sender, EventArgs e)
        {
            repitentes();
        }

        private void btnExamen_Click(object sender, EventArgs e)
        {
            danExamen();
        }

        private void btnAprobados_Click(object sender, EventArgs e)
        {
            aprobados();
        }

        //limpia las selecciones activas
        public void limpiar ()
        {
            dataGridView1.ClearSelection();
        }
        
        //Busca por codigo
        public int buscarCodigo(String codigo)
        {
            Boolean codigoEncontrado = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (codigo.Equals(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                {
                    dataGridView1.Rows[0].Cells[0].Selected = false;
                    dataGridView1.Rows[i].Selected = true;
                    // dataGridView1.Rows[i].Cells[0].Selected = true;
                    codigoEncontrado = true;
                    celda = i;
                    break;
                }
            }

            if (codigoEncontrado == false)
                MessageBox.Show("Dato no encontrado");
            return celda;
        }

        //Calcula el promedio de notas por codigo individual
        public double promNotas(int celda)
        {
           
                float sumNotas = 0;
                int totalNotas = 0;

                for (int i = 5; i < 9; i++)
                {
                    totalNotas = Convert.ToInt32(dataGridView1.Rows[celda].Cells[9].Value.ToString());
                    sumNotas += Convert.ToSingle(dataGridView1.Rows[celda].Cells[i].Value.ToString());
                    promedio = sumNotas / totalNotas;
                }
                if (promedio < 4)
                {
                    MessageBox.Show("El promedio del alumno es " + promedio + "\n Reprueba.");
                }
                if (promedio >= 5)
                {
                    MessageBox.Show("El promedio del alumno es " + promedio + "\n Aprueba.");
                }
                else if (promedio >= 4 && promedio <= 4.9)
                {
                    MessageBox.Show("El promedio del alumno es " + promedio + "\n Presenta examen.");
                }
                return promedio;
           
        }
        //Sobrecarga del anterior
        public double promNotas(int celda,int c)
        {

            float sumNotas = 0;
            int totalNotas = 0;

            for (int i = 5; i < 9; i++)
            {
                totalNotas = Convert.ToInt32(dataGridView1.Rows[celda].Cells[9].Value.ToString());
                sumNotas += Convert.ToSingle(dataGridView1.Rows[celda].Cells[i].Value.ToString());
                promedio = sumNotas / totalNotas;
            }
            if (promedio < 4 && c == 1)
            {
                dataGridView1.Rows[celda].Selected = true;
            }
            if (promedio >= 5 && c == 3)
            {
                dataGridView1.Rows[celda].Selected = true;
            }
            else if (promedio >= 4 && promedio <= 4.9 && c == 2)
            {
                dataGridView1.Rows[celda].Selected = true;
            }
            return promedio;

        }

        //Calcula el promedio por nota y curso
        public double promNotasGrupo(int i, int y)
        {
            try
            {
                if (txtBuscarDG != null)
                {
                    int numNota = Convert.ToInt32(txtBuscarDG.Text);
                    float sumNotas = 0;
                    switch (numNota)
                    {
                        case (1):
                            for (; i < y; i++)
                            {
                                sumNotas += Convert.ToSingle(dataGridView1.Rows[i].Cells[5].Value.ToString());
                            }
                            promedio = sumNotas / 8;
                            MessageBox.Show("El promedio del grupo en la nota 1 es: " + promedio);
                            break;
                        case (2):
                            for (; i < y; i++)
                            {
                                sumNotas += Convert.ToSingle(dataGridView1.Rows[i].Cells[6].Value.ToString());
                            }
                            promedio = sumNotas / 8;
                            MessageBox.Show("El promedio del grupo en la nota 2 es: " + promedio);
                            break;
                        case (3):
                            for (; i < y; i++)
                            {
                                sumNotas += Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value.ToString());
                            }
                            promedio = sumNotas / 8;
                            MessageBox.Show("El promedio del grupo en la nota 3 es: " + promedio);
                            break;
                        case (4):
                            for (; i < y; i++)
                            {
                                sumNotas += Convert.ToSingle(dataGridView1.Rows[i].Cells[8].Value.ToString());
                            }
                            promedio = sumNotas / 8;
                            MessageBox.Show("El promedio del grupo en la nota 4 es: " + promedio);
                            break;
                    }
                }else
                {
                    MessageBox.Show(" error");
                }
                
            }catch (ArgumentNullException aNE)
            {
                MessageBox.Show(aNE.Message);
            }
            return promedio;
        }

        public void repitentes ()
        {
            int c = 1;
           
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                promedio = promNotas(i,c);
                  }
            }
            
        public void danExamen()
        {
            int c = 2;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                promedio = promNotas(i,c);
                
            }
        }

        public void aprobados()
        {
            int c = 3;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                promedio = promNotas(i,c);
               
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ventana1.Show();
            this.Hide();
        }
    }

      
    }
