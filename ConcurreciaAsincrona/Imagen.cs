using System;
using System.Collections.Generic;
using System.Text;

namespace ConcurreciaAsincrona
{
    public class Imagen
    {
        public string Nombre { get; set; } = null!;
        public string URL { get; set; } = null!;
    }

    public class Imagenes
    {
        public List<Imagen> Lista { get; set; }
        public Imagenes()
        {
            Lista = new List<Imagen>();

            for (int i = 1; i <= 5; i++)
            {
                Lista.Add(new Imagen()
                {
                    Nombre = $"Polignano a Mare {i}.jpg",
                    URL = $"https://www.greenme.it/wp-content/uploads/2020/06/polgnano-mare.jpg"
                });
                Lista.Add(new Imagen()
                {
                    Nombre = $"Matera de noche {i}.jpg",
                    URL = $"https://espartedelviaje.com/wp-content/uploads/2024/09/matera-que-ver-de-noche.jpg"
                });
                Lista.Add(new Imagen()
                {
                    Nombre = $"Valencia {i}.jpg",
                    URL = $"https://i.pinimg.com/originals/e3/5e/47/e35e47622d07c7149d62e4c0d6453e07.jpg"
                });
            }

        }
    }
}
