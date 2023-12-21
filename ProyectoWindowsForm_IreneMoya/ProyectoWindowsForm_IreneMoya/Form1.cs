namespace ProyectoWindowsForms_Irene
{
    public partial class Form1 : Form
    {
        // Lista que almacena objetos Cliente
        List<Cliente> listaClientes = new List<Cliente>();

        int indice = 0;

        bool esNuevo = false;
        bool esModificar = false;

        // OpenFileDialog para seleccionar imágenes
        OpenFileDialog examinar = new OpenFileDialog();




        public Form1()
        {
            // Creación de clientes de ejemplo 
            //Cliente cli1, cli2, cli3;
            //byte[] imagen1 = File.ReadAllBytes("imagen1.jpg");
            //byte[] imagen2 = File.ReadAllBytes("imagen2.jpg");
            //byte[] imagen3 = File.ReadAllBytes("imagen3.jpg");
            //cli1 = new Cliente("Sonia", "Sánchez", 123456789, 'F', true, true, imagen1, 25.5f);
            //cli2 = new Cliente("Luis", "Rodriguez", 987654321, 'M', true, false, imagen2, 18.7f);
            //cli3 = new Cliente("Maria", "Salas", 654789123, 'F', false, true, imagen3, 19.00f);
            //listaClientes.Add(cli1);
            //listaClientes.Add(cli2);
            //listaClientes.Add(cli3);

            // Configuración inicial del formulario
            InitializeComponent();
            visibleBotones(true);
            habilitarEdicion(false);
            txtPrecio.Enabled = false;
            txtRegistros.Enabled = false;

            // Lectura de datos desde el archivo databank.data
            using (BinaryReader reader = new BinaryReader(File.OpenRead("databank.data")))
            {
                try
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        string nombre;
                        string apellido;
                        int telefono;
                        char genero;
                        bool tipo1;
                        bool tipo2;
                        byte[] imagen;
                        float precio;

                        nombre = reader.ReadString();
                        apellido = reader.ReadString();
                        telefono = reader.ReadInt32();
                        genero = reader.ReadChar();
                        tipo1 = reader.ReadBoolean();
                        tipo2 = reader.ReadBoolean();
                        int numbyte = reader.ReadInt32();
                        imagen = reader.ReadBytes(numbyte);
                        precio = reader.ReadSingle();

                        Cliente cli = new Cliente(nombre, apellido, telefono, genero, tipo1, tipo2, imagen, precio);
                        listaClientes.Add(cli);
                    }
                }
                catch (IOException ex)
                {
                    // Manejar la excepción de entrada/salida (IOException) aquí.
                    Console.WriteLine($"Error de entrada/salida al leer la imagen: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Manejar otras excepciones aquí.
                    Console.WriteLine($"Error al leer la imagen: {ex.Message}");
                }

            }

            mostarActual();
            Load += new EventHandler(LoadForm);
            // Asociar el evento de cierre del formulario al método GuardarDatos mediante FormClosingEvent con el metodo GuardarDatosCerrar
            FormClosing += new FormClosingEventHandler(GuardarDatosCerrar);

        }
        private void LoadForm(object sender, EventArgs e)
        {
            // Colocar la imagen de fondo en el formulario
            this.BackgroundImage = Image.FromFile("fondo2.png");

            // Ajustar el tamaño de la imagen al tamaño del formulario
            this.BackgroundImageLayout = ImageLayout.Stretch;

            logo.BackgroundImage = Image.FromFile("logo.png");
        }

        public void GuardarDatosCerrar(object sender, FormClosingEventArgs e)
        {
            GuardarDatos();
        }

        // Método para guardar datos en el archivo binario
        public void GuardarDatos()
        {
            using (BinaryWriter writer = new BinaryWriter(File.OpenWrite("databank.data")))
            {
                foreach (Cliente cli in listaClientes)
                {
                    // Escribir datos de clientes en el archivo binario
                    writer.Write(cli.nombre);
                    writer.Write(cli.apellido);
                    writer.Write(cli.telefono);
                    writer.Write(cli.genero);
                    writer.Write(cli.tipo1);
                    writer.Write(cli.tipo2);
                    writer.Write(cli.imagen.Length);
                    writer.Write(cli.imagen);
                    writer.Write(cli.precio);
                }
            }
        }

        // Método para mostrar el cliente actual en el formulario
        public void mostarActual()
        {
            Cliente actual = listaClientes[indice];
            txtNombre.Text = actual.nombre;
            txtApellido.Text = actual.apellido;
            txtTelefono.Text = "" + actual.telefono;
            txtGenero.Text = "" + actual.genero;
            cbManicura.Checked = actual.tipo1;
            cbPintar.Checked = actual.tipo2;
            pictureBox1.Image = byteArrayToImage(actual.imagen);
            txtPrecio.Text = string.Format("{0:G}", actual.precio);

            txtRegistros.Text = Convert.ToString(listaClientes.Count);
            //logo.Image = Image.FromFile("logo.png");

        }

        // Evento al hacer clic en el botón "Siguiente"
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            indice++;
            btnSiguiente.Enabled = true;
            btnAnterior.Enabled = true;
            if (indice == listaClientes.Count - 1)
            {
                btnSiguiente.Enabled = false;
                btnAnterior.Enabled = true;
            }

            mostarActual();
        }
        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            indice--;
            btnSiguiente.Enabled = true;
            btnAnterior.Enabled = true;
            if (indice == 0)
            {
                btnSiguiente.Enabled = true;
                btnAnterior.Enabled = false;
            }

            mostarActual();

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            esModificar = true;
            visibleBotones(false);
            habilitarEdicion(true);

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            visibleBotones(false);
            habilitarEdicion(true);

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtGenero.Text = "";
            cbManicura.Checked = false;
            cbPintar.Checked = false;
            txtPrecio.Text = "";
            pictureBox1.Image = Image.FromFile("porDefecto.jpg");

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                if (esNuevo)
                {
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    int telefono = int.Parse(txtTelefono.Text);
                    char genero = Convert.ToChar(txtGenero.Text);
                    bool tipo1 = cbManicura.Checked;
                    bool tipo2 = cbPintar.Checked;
                    byte[] imagen = File.ReadAllBytes(examinar.FileName);
                    ActualizarPrecio();
                    float precio = float.Parse(txtPrecio.Text);


                    if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                     string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtGenero.Text) ||
                     !float.TryParse(txtPrecio.Text, out _))
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios correctamente.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Cliente nuevoCliente = new Cliente(nombre, apellido, telefono, genero, tipo1, tipo2, imagen, precio);
                        listaClientes.Add(nuevoCliente);
                        mostarActual();
                    }

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error de formato: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (esModificar)
                {
                    if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                     string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtGenero.Text) ||
                     !float.TryParse(txtPrecio.Text, out _))
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios correctamente.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        Cliente modificarCliente = listaClientes[indice];

                        string nombre = txtNombre.Text;
                        string apellido = txtApellido.Text;
                        int telefono = int.Parse(txtTelefono.Text);
                        char genero = Convert.ToChar(txtGenero.Text);
                        bool tipo1 = cbManicura.Checked;
                        bool tipo2 = cbPintar.Checked;
                        byte[] imagen = File.ReadAllBytes(examinar.FileName);
                        float precio = float.Parse(txtPrecio.Text);

                        modificarCliente.nombre = nombre;
                        modificarCliente.apellido = apellido;
                        modificarCliente.telefono = telefono;
                        modificarCliente.genero = genero;
                        modificarCliente.tipo1 = tipo1;
                        modificarCliente.tipo2 = tipo2;
                        modificarCliente.imagen = imagen;
                        modificarCliente.precio = precio;

                        mostarActual();
                    }

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error de formato: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            esNuevo = false;
            esModificar = false;
            visibleBotones(true);
            habilitarEdicion(false);

        }

        private void cbManicura_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        private void cbPintar_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        private void ActualizarPrecio()
        {
            float precio = 3.5f;

            if (cbManicura.Checked)
            {
                precio += 7.3f;
            }

            if (cbPintar.Checked)
            {
                precio += 18.8f;
            }

            txtPrecio.Text = precio.ToString("0.00");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            esModificar = false;
            esNuevo = false;
            visibleBotones(true);
            habilitarEdicion(false);
            mostarActual();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listaClientes.RemoveAt(indice);
            if (indice == 0)
            {
                btnSiguiente.Enabled = true;
                btnAnterior.Enabled = false;
            }
            if (indice == listaClientes.Count - 1)
            {
                btnSiguiente.Enabled = false;
                btnAnterior.Enabled = true;
            }
            if (indice == listaClientes.Count)
            {
                indice--;
            }
            mostarActual();
        }
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            examinar.Filter = "JPEG(*.JPG)|*.JPG";
            if (examinar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(examinar.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }
        public void visibleBotones(bool visivilidad)
        {
            btnAceptar.Visible = !visivilidad;
            btnCancelar.Visible = !visivilidad;
            btnAnterior.Visible = visivilidad;
            btnModificar.Visible = visivilidad;
            btnEliminar.Visible = visivilidad;
            btnNuevo.Visible = visivilidad;
            btnSiguiente.Visible = visivilidad;
            btnGuardar.Visible = visivilidad;
            btnAnterior.Enabled = visivilidad;
            btnModificar.Enabled = visivilidad;
            btnEliminar.Enabled = visivilidad;
            btnNuevo.Enabled = visivilidad;
            btnSiguiente.Enabled = visivilidad;
            btnGuardar.Enabled = visivilidad;

        }
        private void habilitarEdicion(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtApellido.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            txtGenero.Enabled = habilitar;
            cbManicura.Enabled = habilitar;
            cbPintar.Enabled = habilitar;
            btnExaminar.Enabled = habilitar;

        }
        //Imagen a bytes
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //Bytes a imagen
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click_1(object sender, EventArgs e)
        {
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }


}





