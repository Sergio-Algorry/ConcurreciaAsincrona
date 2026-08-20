using System.Diagnostics;

namespace ConcurreciaAsincrona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btComenzar_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;                  //1
            MessageBox.Show($"Inicia demora");
            //proceso lento
            //Thread.Sleep(5000); // sincrona            //2
            //await Task.Delay(5000); // asincrona       //3
            await Demora(5000); // asincrona con metodo  //4
            var nombre = await Nombre();                 //5    -- mostrar que pasa sin await
            MessageBox.Show($"Hola {nombre}");
            pictureBox1.Visible = false;                 //1
        }

        private async Task Demora(int MilSeg)            //4
        {
            await Task.Delay(MilSeg);
        }

        private async Task<string> Nombre()              //5
        {
            await Task.Delay(5000);
            return "Juan";
        }

        private async Task ProcesoA()
        {
            await Task.Delay(1000);
            Console.WriteLine("ProcesoA Finalizado");
        }

        private async Task ProcesoB()
        {
            await Task.Delay(1000);
            Console.WriteLine("ProcesoB Finalizado");
        }

        private async Task ProcesoC()
        {
            await Task.Delay(1000);
            Console.WriteLine("ProcesoC Finalizado");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;                   //1
            var sw = new Stopwatch();
            sw.Start();
            await ProcesoA();
            await ProcesoB();
            await ProcesoC();
            sw.Stop();
            Console.WriteLine($"demora: {sw.ElapsedMilliseconds} ms");
            pictureBox1.Visible = false;                  //1

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;                   //1
            var sw = new Stopwatch();
            sw.Start();

            var tareas = new List<Task>()
            {
                ProcesoA(), ProcesoB(), ProcesoC()
            };
            await Task.WhenAll(tareas);

            sw.Stop();
            Console.WriteLine($"demora: {sw.ElapsedMilliseconds} ms");
            pictureBox1.Visible = false;                  //1
        }
    }
}
