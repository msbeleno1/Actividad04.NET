using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;  // Libreria para crear archivos xml
using System.IO;                 // Libreria para ller y escribir datos en un archivo
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Actividad04.NET
{
    public partial class frmActividad04 : Form
    {
        List<alumno> listaAlumno = new List<alumno>(); // Para enlistar los alumnos
        Validaciones misValidaciones = new Validaciones(); // Objeto creado para las validaciones
        private static string textName = "txtCodigo"; // Para saber en cual textbox de los datos de usuario, me encuentro parado
        private static string directorio = "C:/Users/User/source/repos/Actividad04.NET/Actividad04.NET/ArchivosXML/listAlumnos.xml";
        private static string codigoTemporal = ""; // Para guardar el codigo temporalmente y podamos editar el codigo de un alumno

        public frmActividad04()
        {
            InitializeComponent();
        }

        //**************************MIS METODOS*****************************************

        private void guardarXml(string directory)
        {
            //------------------- Crear archivo XML---------------------------------------
            XmlSerializer codificador = new XmlSerializer(typeof(List<alumno>));
            TextWriter escribirXml = new StreamWriter(directory);  // Para que cree el archivo XML
            codificador.Serialize(escribirXml, listaAlumno);  // Para escribir datos en el XML
            escribirXml.Close();  // Terminamos de crear el archivo
        }

        private void cargarXml(string directory)
        {
            if (File.Exists(directory) == true)
            {
                //--------------------Cargar datos del xml-----------------------
                listaAlumno.Clear(); // Para que borre los datos de la lista
                XmlSerializer codificador = new XmlSerializer(typeof(List<alumno>));
                FileStream leerXml = File.OpenRead(directory); // Para que abra el archivo XML

                //--------------------generar lista de datos---------------------
                listaAlumno = (List<alumno>)codificador.Deserialize(leerXml); // Para guardar los datos del XML en la lista
                leerXml.Close();
            }
            //--------------------mostrar lista en el dataGridview------------
            dtgvTablaDtos.DataSource = null;
            dtgvTablaDtos.DataSource = listaAlumno;
            dtgvTablaDtos.AutoResizeColumns();
        }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtCorreo.Text = "";
            txtNombre.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtCodigo.Focus();
            textName = "txtCodigo";
        }

        private void limpiar(string mensaje)
        {
            switch (textName)
            {
                case "txtCodigo":
                    txtNombre.Clear();
                    txtCorreo.Clear();
                    txtNota1.Clear();
                    txtNota2.Clear();
                    txtNota3.Clear();
                    txtNota4.Clear();
                    if (mensaje != "")
                        errorValidacion.SetError(txtCodigo, mensaje);
                    break;

                case "txtNombre":
                    txtCodigo.Clear();
                    txtCorreo.Clear();
                    txtNota1.Clear();
                    txtNota2.Clear();
                    txtNota3.Clear();
                    txtNota4.Clear();
                    if (mensaje != "")
                        errorValidacion.SetError(txtNombre, mensaje);
                    break;

                case "txtCorreo":
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtNota1.Clear();
                    txtNota2.Clear();
                    txtNota3.Clear();
                    txtNota4.Clear();
                    if (mensaje != "")
                        errorValidacion.SetError(txtCorreo, mensaje);
                    break;
            }
        }

        private string existente()
        {
           string mensaje = "";
            foreach (alumno myAlumno in listaAlumno)
            {
                if (txtCodigo.Text == (myAlumno.codigo).ToString())
                    mensaje = "codigo";
                else if ((txtNombre.Text).ToLower() == (myAlumno.nombre).ToLower())
                    mensaje = "nombre";
                else if (txtCorreo.Text == myAlumno.correo)
                    mensaje = "correo";
            }
            return mensaje;
        }

        private alumno existente(TextBox box)
        {
            alumno alumnoEncontrado = null;

            foreach (alumno myAlumno in listaAlumno)
            {
                if (box == txtCodigo)
                {
                    if (txtCodigo.Text == (myAlumno.codigo).ToString())
                    {
                        alumnoEncontrado = myAlumno;
                        return alumnoEncontrado;
                    }
                }
                else if(box == txtNombre)
                {
                    if ((txtNombre.Text).ToLower() == (myAlumno.nombre).ToLower())
                    {
                        alumnoEncontrado = myAlumno;
                        return alumnoEncontrado;
                    }
                }
                else
                {
                    if ((txtCorreo.Text).ToLower() == (myAlumno.correo).ToLower())
                    {
                        alumnoEncontrado = myAlumno;
                        return alumnoEncontrado;
                    }
                }
            }
            return alumnoEncontrado;
        }

        private void guardarAlumno()
        {
            string temp = existente();
            if (temp == "")
            {
                errorValidacion.Clear();
                alumno myAlumno = new alumno();
                myAlumno.codigo = Convert.ToInt32(txtCodigo.Text);
                myAlumno.nombre = txtNombre.Text;
                myAlumno.correo = txtCorreo.Text;
                myAlumno.nota1 = Convert.ToDouble(txtNota1.Text);
                myAlumno.nota2 = Convert.ToDouble(txtNota2.Text);
                myAlumno.nota3 = Convert.ToDouble(txtNota3.Text);
                myAlumno.nota4 = Convert.ToDouble(txtNota4.Text);
                myAlumno.notaFinal = (myAlumno.nota1 + myAlumno.nota2 + myAlumno.nota3 + myAlumno.nota4) / 4;
                if (myAlumno.notaFinal >= 3.5)
                    myAlumno.notaConcepto = "Aprobado";
                else
                    myAlumno.notaConcepto = "Reprobado";

                listaAlumno.Add(myAlumno);
                limpiar();

                //--------------------mostrar lista en el dataGridview------------
                dtgvTablaDtos.DataSource = null;
                dtgvTablaDtos.DataSource = listaAlumno;
                dtgvTablaDtos.AutoResizeColumns();
            }
            else
            {
                switch (temp)
                {
                    case "codigo":
                        errorValidacion.Clear();
                        errorValidacion.SetError(txtCodigo, "El codigo ya existe");
                        break;

                    case "nombre":
                        errorValidacion.Clear();
                        errorValidacion.SetError(txtNombre, "El nombre ya existe");
                        break;

                    case "correo":
                        errorValidacion.Clear();
                        errorValidacion.SetError(txtCorreo, "El correo ya existe");
                        break;
                }
            }
        }

        private void guardarAlumno(int indice)
        {
            errorValidacion.Clear();
            listaAlumno[indice].codigo = Convert.ToInt32(txtCodigo.Text);
            listaAlumno[indice].nombre = txtNombre.Text;
            listaAlumno[indice].correo = txtCorreo.Text;
            listaAlumno[indice].nota1 = Convert.ToDouble(txtNota1.Text);
            listaAlumno[indice].nota2 = Convert.ToDouble(txtNota2.Text);
            listaAlumno[indice].nota3 = Convert.ToDouble(txtNota3.Text);
            listaAlumno[indice].nota4 = Convert.ToDouble(txtNota4.Text);
            listaAlumno[indice].notaFinal = (listaAlumno[indice].nota1 + listaAlumno[indice].nota2 + listaAlumno[indice].nota3 + listaAlumno[indice].nota4) / 4;
            if (listaAlumno[indice].notaFinal >= 3.5)
                listaAlumno[indice].notaConcepto = "Aprobado";
            else
                listaAlumno[indice].notaConcepto = "Reprobado";

            limpiar();

            //--------------------mostrar lista en el dataGridview------------
            dtgvTablaDtos.DataSource = null;
            dtgvTablaDtos.DataSource = listaAlumno;
            dtgvTablaDtos.AutoResizeColumns();
        }

        private void obtenerAlumno(alumno elAlumno)
        {
            txtCodigo.Text = (elAlumno.codigo).ToString();
            txtNombre.Text = elAlumno.nombre;
            txtCorreo.Text = elAlumno.correo;
            txtNota1.Text = (elAlumno.nota1).ToString();
            txtNota2.Text = (elAlumno.nota2).ToString();
            txtNota3.Text = (elAlumno.nota3).ToString();
            txtNota4.Text = (elAlumno.nota4).ToString();
            codigoTemporal = txtCodigo.Text;
        }


        //********************************************************************************
        //*************************EVENTOS DE LOS CONTROLES*******************************

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            bool check;

            // Variable que nos dirá que tipo de boron presiono el usuario en la venta FolderBrowserDialog
            DialogResult result = folderBrowserDialog1.ShowDialog();

            do
            {
                // Validamos que la ruta de archivo obtenida no esté vacia
                if (result == DialogResult.OK && string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath) == false)
                {
                    // Guardamos la ruta en nuestra variable
                    directorio = folderBrowserDialog1.SelectedPath;

                    //El FBD guarda las rutas con el separador \ asi que lo reemplazamos para nuestro codificador XML
                    // Recordemos que se usa el \\ debido a que \ es un caracter de escape
                    // Además el FDB solo guarda la ruta y no el nombre del archivo
                    directorio = directorio.Replace("\\", "/") + "/listAlumnos.xml";
                    guardarXml(directorio);
                    check = true;
                }
                else if (result == DialogResult.Cancel)
                    check = true;
                else
                    check = false;
            } while (check == false); // Que vuelva a mostrar la ventana hasta que seleccione OK o Cancelar
        }

        private void btnAddUsser_Click(object sender, EventArgs e)
        {
            if(misValidaciones.ValidarTipo(txtNombre, errorValidacion, "let") == false)
                if(misValidaciones.ValidarTipo(txtCorreo, errorValidacion, "cor") == false)
                    if(misValidaciones.ValidarTipo(txtNota1, errorValidacion, "num") == false)
                        if (misValidaciones.ValidarTipo(txtNota2, errorValidacion, "num") == false)
                            if (misValidaciones.ValidarTipo(txtNota3, errorValidacion, "num") == false)
                                if (misValidaciones.ValidarTipo(txtNota4, errorValidacion, "num") == false)
                                    if(Convert.ToDouble(txtNota1.Text) >= 0 && Convert.ToDouble(txtNota1.Text) <= 5)
                                        if (Convert.ToDouble(txtNota2.Text) >= 0 && Convert.ToDouble(txtNota2.Text) <= 5)
                                            if (Convert.ToDouble(txtNota3.Text) >= 0 && Convert.ToDouble(txtNota3.Text) <= 5)
                                                if (Convert.ToDouble(txtNota4.Text) >= 0 && Convert.ToDouble(txtNota4.Text) <= 5)
                                                {
                                                    guardarAlumno();
                                                    btnSearchUsser.Enabled = true;
                                                }
                                                else
                                                    errorValidacion.SetError(txtNota4, "La nota debe estar entre 0 y 5");
                                            else
                                                errorValidacion.SetError(txtNota3, "La nota debe estar entre 0 y 5"); 
                                        else
                                            errorValidacion.SetError(txtNota2, "La nota debe estar entre 0 y 5"); 
                                    else
                                        errorValidacion.SetError(txtNota1, "La nota debe estar entre 0 y 5");
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            bool check;
            // ------------------------------Configuracion del OpenFileDialogo------------------
            // Ruta inicial a donde nos mostrara el OFD cuando se abra
            openFileDialog1.InitialDirectory = "C://Users//User//source//repos//Actividad04.NET//Actividad04.NET//ArchivosXML//";
            
            // Se agrega el filtro para que cuando abra solo muestre ese tipo de archivos
            openFileDialog1.Filter = "txt files (*.xml)|*.xml";

            // Variable que nos mostrara que tipo de boton seleccionaron
            DialogResult result = openFileDialog1.ShowDialog();

            do
            {
                check = true;

                // Preguntamos si presiono OK y la ruta del archivo no está vacia
                if (result == DialogResult.OK && string.IsNullOrEmpty(openFileDialog1.FileName) == false)
                {
                    // Guardamos la ruta en nuestra variable
                    directorio = openFileDialog1.FileName;

                    //El OFD guarda las rutas con el separador // asi que lo reemplazamos para nuestro codificador XML
                    directorio = directorio.Replace("//", "/");
                    cargarXml(directorio);
                }
                else if (result == DialogResult.Cancel)
                    check = true;
                else
                    check = false;

            } while (check == false);  // Que vuelva a mostrar la ventana hasta que seleccione OK o Cancelar
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            guardarXml(directorio);
            Application.Exit();
        }

        private void btnDeleteUsser_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listaAlumno.Count; i++)
            {
                if(txtCodigo.Text == (listaAlumno[i].codigo).ToString())
                {
                    List<alumno> listaTemporal = new List<alumno>();
                    for (int j = 0; j < listaAlumno.Count; j++)
                    {
                        if(j != i)
                        {
                            listaTemporal.Add(listaAlumno[j]);
                        }
                        else if(j == listaAlumno.Count - 1)
                        {
                            listaAlumno.Clear();
                            for(int z = 0; z < listaTemporal.Count; z++)
                            {
                                listaAlumno.Add(listaTemporal[z]);
                            }
                        }
                    }
                    limpiar();
                }
            }

            // Que me desactive los botones
            btnDeleteUsser.Enabled = false;
            btnEditUsser.Enabled = false;

            //--------------------mostrar lista en el dataGridview------------
            dtgvTablaDtos.DataSource = null;
            dtgvTablaDtos.DataSource = listaAlumno;
            dtgvTablaDtos.AutoResizeColumns();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarXml(directorio);

            // Si la lista esta vacia entonces que me desactive los botones
            if (listaAlumno == null)
            {
                btnDeleteUsser.Enabled = false;
                btnEditUsser.Enabled = false;
                btnSearchUsser.Enabled = false;
            }
            else
            {
                btnDeleteUsser.Enabled = false;
                btnEditUsser.Enabled = false;
                btnSearchUsser.Enabled = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            guardarXml(directorio);
        }

        private void btnSearchUsser_Click(object sender, EventArgs e)
        {
            limpiar("");
            errorValidacion.Clear();
            alumno myAlumno = null;
            switch(textName)
            {
                case "txtCodigo":
                    myAlumno = existente(txtCodigo);
                    if (myAlumno is null)
                        limpiar("El estudiante a buscar no existe");
                    else
                        obtenerAlumno(myAlumno);
                    break;

                case "txtNombre":
                    myAlumno = existente(txtNombre);
                    if(misValidaciones.ValidarTipo(txtNombre, errorValidacion, "let") == false)
                        if (myAlumno is null)
                            limpiar("El estudiante a buscar no existe");
                        else
                            obtenerAlumno(myAlumno);
                    break;

                case "txtCorreo":
                    myAlumno = existente(txtCorreo);
                    if(misValidaciones.ValidarTipo(txtCorreo, errorValidacion, "cor") == false)
                        if (myAlumno is null)
                            limpiar("El estudiante a buscar no existe");
                        else
                            obtenerAlumno(myAlumno);
                    break;
            }
            
            if(listaAlumno == null)
            {
                btnEditUsser.Enabled = false;
                btnDeleteUsser.Enabled = false;
            }
            else
            {
                btnEditUsser.Enabled = true;
                btnDeleteUsser.Enabled = true;
            }
        }

        private void txtCodigo_Click(object sender, EventArgs e)
        {
            textName = txtCodigo.Name;
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            textName = txtNombre.Name;
        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {
            textName = txtCorreo.Name;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true || char.IsControl(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnEditUsser_Click(object sender, EventArgs e)
        {                                    
            if (misValidaciones.ValidarTipo(txtNombre, errorValidacion, "let") == false)
                if (misValidaciones.ValidarTipo(txtCorreo, errorValidacion, "cor") == false)
                    if (misValidaciones.ValidarTipo(txtNota1, errorValidacion, "num") == false)
                        if (misValidaciones.ValidarTipo(txtNota2, errorValidacion, "num") == false)
                            if (misValidaciones.ValidarTipo(txtNota3, errorValidacion, "num") == false)
                                if (misValidaciones.ValidarTipo(txtNota4, errorValidacion, "num") == false)
                                    if(Convert.ToDouble(txtNota1.Text) >= 0 && Convert.ToDouble(txtNota1.Text) <= 5)
                                        if (Convert.ToDouble(txtNota2.Text) >= 0 && Convert.ToDouble(txtNota2.Text) <= 5)
                                            if (Convert.ToDouble(txtNota3.Text) >= 0 && Convert.ToDouble(txtNota3.Text) <= 5)
                                                if (Convert.ToDouble(txtNota4.Text) >= 0 && Convert.ToDouble(txtNota4.Text) <= 5)
                                                    for (int i = 0; i < listaAlumno.Count; i++)
                                                    {
                                                        if (codigoTemporal == (listaAlumno[i].codigo).ToString())
                                                        {
                                                            guardarAlumno(i);
                                                            limpiar();
                                                            btnDeleteUsser.Enabled = false;
                                                            btnEditUsser.Enabled = false;
                                                        }
                                                    }
                                                else
                                                    errorValidacion.SetError(txtNota4, "La nota debe estar entre 0 y 5");
                                            else
                                                errorValidacion.SetError(txtNota3, "La nota debe estar entre 0 y 5");
                                        else
                                            errorValidacion.SetError(txtNota2, "La nota debe estar entre 0 y 5");
                                    else
                                        errorValidacion.SetError(txtNota1, "La nota debe estar entre 0 y 5");
        }
    }
}
