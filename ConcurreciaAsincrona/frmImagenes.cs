//opción 1: descarga imagenes en forma secuencial
//opción 2: descarga imagenes en forma paralela

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ConcurreciaAsincrona
{
    public partial class frmImagenes : Form
    {
        private HttpClient http = new HttpClient();
        private Stopwatch sw = new Stopwatch();
        private Imagenes imagenes = new Imagenes();
        private string DirSecuencial = "";
        private string DirParalelo = "";

        public frmImagenes()
        {
            InitializeComponent();

            var DirActual = AppDomain.CurrentDomain.BaseDirectory;

            this.DirSecuencial = Path.Combine(DirActual, "Secuencial");

            if (!Directory.Exists(DirSecuencial))
            {
                Directory.CreateDirectory(DirSecuencial);
            }

            this.DirParalelo = Path.Combine(DirActual, "Paralelo");

            if (!Directory.Exists(DirParalelo))
            {
                Directory.CreateDirectory(DirParalelo);
            }
        }

        private async void btSecuencial_Click(object sender, EventArgs e)
        {
            BorrarArchivos(DirSecuencial);
            Console.WriteLine("Inicio descarga secuencial\r\n");
            sw.Reset();
            sw.Start();
            foreach (var imagen in imagenes.Lista)
            {
                await DescargarImagen(DirSecuencial, imagen);
            }

            sw.Stop();
            Console.WriteLine($"Fin descarga secuencial. Tiempo transcurrido: {sw.ElapsedMilliseconds} ms\r\n");
            Console.WriteLine($"----------------");

        }

        private async void btParalelo_Click(object sender, EventArgs e)
        {
            BorrarArchivos(DirParalelo);
            Console.WriteLine("Inicio descarga en Paralelo\r\n");
            sw.Reset();
            sw.Start();

            //var descargas = new List<Task>()
            //{
            //    DescargarImagen(DirParalelo, imagenes.Lista[0]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[1]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[2]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[3]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[4]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[5]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[6]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[7]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[8]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[9]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[10]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[11]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[12]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[13]),
            //    DescargarImagen(DirParalelo, imagenes.Lista[14])
            //};

            var descargas = new List<Task>();
            foreach (var imagen in imagenes.Lista)
            {
                descargas.Add(DescargarImagen(DirParalelo, imagen));
            }

            await Task.WhenAll(descargas);

            sw.Stop();
            Console.WriteLine($"Fin descarga en Paralelo. Tiempo transcurrido: {sw.ElapsedMilliseconds} ms\r\n");
            Console.WriteLine($"----------------");
        }

        private async Task DescargarImagen(string directorio, Imagen imagen)
        {
            Console.WriteLine($"Descargando {imagen.Nombre}");
            var bytes = await http.GetByteArrayAsync(imagen.URL);
            var ruta = Path.Combine(directorio, imagen.Nombre);
            await File.WriteAllBytesAsync(ruta, bytes);
        }

        private void BorrarArchivos(string directorio)
        {
            var archivos = Directory.GetFiles(directorio);
            foreach (var archivo in archivos)
            {
                File.Delete(archivo);
            }
        }
    }
}
