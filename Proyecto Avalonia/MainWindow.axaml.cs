using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ProyectoAvalonia;

public partial class MainWindow : Window
{
    List<Cliente> listaClientes = new List<Cliente>();
     bool esModificar = false;
     bool esNuevo = false;
     
     // Ruta del archivo de datos
     readonly string filePath = "databank.data";
     
    public MainWindow()
    {
        InitializeComponent();
        CargarRegistros();
        visibilidadBotones(true);
        habilitarEdicion(false);
        TxtPrecio.IsEnabled = false;
        BtnAnterior.IsEnabled = false;
        TxtRegistros.IsEnabled = false;
   
    }
    
    private void CargarRegistros()
    {
        if (File.Exists(filePath))
        {
            try
            {
                using (var streamReader = new StreamReader(filePath, Encoding.UTF8))
                {
                    var serializer = new XmlSerializer(typeof(List<Cliente>));
                    listaClientes = (List<Cliente>)serializer.Deserialize(streamReader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar registros: {ex.Message}");
            }
        }
    }
    
    private void GuardarRegistros()
    {
        try
        {
            using (var streamWriter = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                var serializer = new XmlSerializer(typeof(List<Cliente>));
                serializer.Serialize(streamWriter, listaClientes);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al guardar registros: {ex.Message}");
        }
    }
    
    

    private void ExaminarImagen(object? sender, RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filters.Add(new FileDialogFilter() { Name = "Imágenes", Extensions = { "jpg", "jpeg", "png", "gif" } });

        
        var result = openFileDialog.ShowAsync(this);

       
        result.ContinueWith(task =>
        {
            if (task.Result != null && task.Result.Length > 0)
            {
               
                string selectedFilePath = task.Result[0];
            
            }
        });
    }

    private void btnAnterior(object? sender, RoutedEventArgs e)
    {
        BtnAnterior.IsEnabled = true;
        BtnSiguiente.IsEnabled = true;
    }

    private void btnSiguiente(object? sender, RoutedEventArgs e)
    {
        BtnAnterior.IsEnabled = true;
        BtnSiguiente.IsEnabled = true;
    }

    private void btnGuardar(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtApellido.Text) ||
            string.IsNullOrWhiteSpace(TxtTelefono.Text) || string.IsNullOrWhiteSpace(TxtGenero.Text) ||
            !float.TryParse(TxtPrecio.Text, out _))
        {
            
        }
        else
        {
            
            Cliente nuevoCliente = new Cliente();
          

            listaClientes.Add(nuevoCliente);
            GuardarRegistros(); 
        }
    }

    private void btnModificar(object? sender, RoutedEventArgs e)
    {
        visibilidadBotones(false);
        habilitarEdicion(true);
        esModificar = true;
    }

    private void btnEliminar(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void btnNuevo(object? sender, RoutedEventArgs e)
    {
        visibilidadBotones(false);
        habilitarEdicion(true);
        esNuevo = true;

        TxtNombre.Text = "";
        TxtApellido.Text = "";
        TxtTelefono.Text = "";
        TxtGenero.Text = "";
        TxtPrecio.Text = "";
        
    }

    private void btnAceptar(object? sender, RoutedEventArgs e)
    {
        if (esNuevo)
        {
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            int telefono = int.Parse(TxtTelefono.Text);
            char genero = Convert.ToChar(TxtGenero.Text);
            bool manicura = (bool)CbManicura.IsChecked;
            bool pedicura = (bool)CbPedicura.IsChecked;
            ActualizarPrecio();
            float precio = float.Parse(TxtPrecio.Text);

            if (string.IsNullOrWhiteSpace(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                string.IsNullOrWhiteSpace(TxtTelefono.Text) || string.IsNullOrWhiteSpace(TxtGenero.Text) ||
                !float.TryParse(TxtPrecio.Text, out _))
            {
             
             
           }
           else
           {
               Cliente nuevoCliente = new Cliente
               {
                   nombre = TxtNombre.Text,
                   apellido = TxtApellido.Text,
                   telefono = int.Parse(TxtTelefono.Text),
                   genero = Convert.ToChar(TxtGenero.Text),
                   manicura = (bool)CbManicura.IsChecked,
                   pedicura = (bool)CbPedicura.IsChecked
               };

               ActualizarPrecio();
               nuevoCliente.precio = float.Parse(TxtPrecio.Text);

               listaClientes.Add(nuevoCliente);
               GuardarRegistros();
 
 
           }
           

        }

        if (esModificar)
        {
            Cliente clienteSeleccionado = null;
            
            
            clienteSeleccionado.nombre = TxtNombre.Text;
            clienteSeleccionado.apellido = TxtApellido.Text;
            clienteSeleccionado.telefono = int.Parse(TxtTelefono.Text);
            clienteSeleccionado.genero = Convert.ToChar(TxtGenero.Text);
            clienteSeleccionado.manicura = (bool)CbManicura.IsChecked;
            clienteSeleccionado.pedicura = (bool)CbPedicura.IsChecked;

            ActualizarPrecio();
            clienteSeleccionado.precio = float.Parse(TxtPrecio.Text);

            GuardarRegistros(); 
            
            
        }
        visibilidadBotones(true);
        habilitarEdicion(false);
        esModificar = false;
        esNuevo = false;
    }

    private void btnCancelar(object? sender, RoutedEventArgs e)
    {
        visibilidadBotones(true);
        habilitarEdicion(false);
        esModificar = false;
        esNuevo = false;
    }

    private void CbManicura_CheckedChanged(object sender, EventArgs e)
    {
        ActualizarPrecio();
    }

    private void CbPedicura_CheckedChanged(object sender, EventArgs e)
    {
        ActualizarPrecio();
    }
    
    private void visibilidadBotones(bool visible)
    {
        BtnCancelar.IsVisible=!visible;
        BtnAceptar.IsVisible=!visible;
        BtnAnterior.IsVisible = visible;
        BtnEliminar.IsVisible = visible;
        BtnGuardar.IsVisible = visible;
        BtnSiguiente.IsVisible = visible;
        BtnModificar.IsVisible = visible;
        BtnNuevo.IsVisible = visible;
    }

    private void habilitarEdicion(bool editable)
    {
        TxtNombre.IsEnabled = editable;
        TxtApellido.IsEnabled = editable;
        TxtTelefono.IsEnabled = editable;
        TxtGenero.IsEnabled = editable;
        BtnExaminar.IsEnabled = editable;
        CbManicura.IsEnabled = editable;
        CbPedicura.IsEnabled = editable;
    }
    
    private void ActualizarPrecio()
    {
        float precio = 3.5f;

        if ((bool)CbManicura.IsChecked)
        {
            precio += 7.3f;
        }

        if ((bool)CbPedicura.IsChecked)
        {
            precio += 18.8f;
        }

        TxtPrecio.Text = precio.ToString("0.00");
    }

}

internal class Cliente
{
    public string nombre { get; set; }
    public string apellido { get; set; }
    public int telefono { get; set; }
    public char genero { get; set; }
    public bool manicura { get; set; }
    public bool pedicura { get; set; }
    public float  precio { get; set; }
    
}  