using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EjemploWindowsForm.Domain;
using EjemploWindowsForm.Infraestructure;

namespace EjemploWindowsForm.Presentacion
{
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
            _repositoryEstudiante = new RepositoryEstudiante("estudiantes.txt");
        }

        private RepositoryEstudiante _repositoryEstudiante;


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = Estudiante.Create();

            estudiante.Id = long.Parse(textBox1.Text);
            estudiante.Nombre = textBox2.Text;
            estudiante.Direccion = textBox3.Text;
            estudiante.Semestre = (int)numericUpDown1.Value;
            estudiante.Programa = comboBox1.SelectedItem.ToString();

            _repositoryEstudiante.Add(estudiante);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = Estudiante.Create();

            estudiante.Id = long.Parse(textBox1.Text);
            estudiante.Nombre = textBox2.Text;
            estudiante.Direccion = textBox3.Text;
            estudiante.Semestre = (int)numericUpDown1.Value;
            estudiante.Programa = comboBox1.SelectedItem.ToString();

            _repositoryEstudiante.Update(estudiante);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            long id = long.Parse(textBox1.Text);
            _repositoryEstudiante.Delete(id);
        }

        

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            _repositoryEstudiante.Commit();
        }
    }
}
