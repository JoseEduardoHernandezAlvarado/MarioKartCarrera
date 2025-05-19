using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MarioKartCarrera
{
    public partial class Form1 : Form
    {
        Thread[] hilos;
        int[] vueltasTotales;
        PictureBox[] Personajes;
        List<Point> recorrido;
        private volatile bool ganadorAnunciado = false;
        SoundPlayer Reproductor;
        public Form1()
        {
            // Corrección: evita problemas por escalado de DPI
            this.AutoScaleMode = AutoScaleMode.None;

            // Corrección: evita que el usuario cambie el tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            InitializeComponent();

            Personajes = new PictureBox[] { Mario, Luigi, Yoshi, Toad, ShyGuy };
            hilos = new Thread[Personajes.Length];
            vueltasTotales = new int[Personajes.Length];
            InicializarRecorrido();
        }

        private void InicializarRecorrido()
        {
            recorrido = new List<Point>();

            for (int y = 216; y >= 45; y -= 5)
                recorrido.Add(new Point(52, y));
            for (int x = 52; x <= 205; x += 5)
                recorrido.Add(new Point(x, 45));
            for (int y = 45; y <= 47; y += 5)
                recorrido.Add(new Point(205, y));
            for (int x = 205; x <= 221; x += 5)
                recorrido.Add(new Point(x, 47));
            for (int y = 47; y <= 73; y += 5)
                recorrido.Add(new Point(221, y));
            for (int x = 221; x <= 248; x += 5)
                recorrido.Add(new Point(x, 73));
            for (int y = 73; y <= 103; y += 5)
                recorrido.Add(new Point(248, y));
            for (int x = 248; x <= 271; x += 5)
                recorrido.Add(new Point(x, 103));
            for (int y = 103; y <= 139; y += 5)
                recorrido.Add(new Point(271, y));
            for (int x = 271; x <= 282; x += 5)
                recorrido.Add(new Point(x, 139));
            for (int y = 139; y <= 150; y += 5)
                recorrido.Add(new Point(282, y));
            for (int x = 282; x <= 443; x += 5)
                recorrido.Add(new Point(x, 150));
            for (int y = 150; y >= 130; y -= 5)
                recorrido.Add(new Point(443, y));
            for (int x = 443; x <= 467; x += 5)
                recorrido.Add(new Point(x, 130));
            for (int y = 130; y >= 66; y -= 5)
                recorrido.Add(new Point(467, y));
            for (int x = 467; x <= 496; x += 5)
                recorrido.Add(new Point(x, 66));
            for (int y = 66; y >= 44; y -= 5)
                recorrido.Add(new Point(496, y));
            for (int x = 496; x <= 643; x += 5)
                recorrido.Add(new Point(x, 44));
            for (int y = 44; y <= 67; y += 5)
                recorrido.Add(new Point(643, y));
            for (int x = 643; x <= 667; x += 5)
                recorrido.Add(new Point(x, 67));
            for (int y = 67; y <= 200; y += 5)
                recorrido.Add(new Point(667, y));
            for (int x = 667; x >= 644; x -= 5)
                recorrido.Add(new Point(x, 200));
            for (int y = 200; y <= 218; y += 5)
                recorrido.Add(new Point(644, y));
            for (int x = 644; x >= 544; x -= 5)
                recorrido.Add(new Point(x, 218));
            for (int y = 218; y <= 233; y += 5)
                recorrido.Add(new Point(544, y));
            for (int x = 544; x >= 469; x -= 5)
                recorrido.Add(new Point(x, 233));
            for (int y = 233; y <= 251; y += 5)
                recorrido.Add(new Point(469, y));
            for (int x = 469; x >= 362; x -= 5)
                recorrido.Add(new Point(x, 251));
            for (int y = 251; y <= 270; y += 5)
                recorrido.Add(new Point(362, y));
            for (int x = 362; x >= 274; x -= 5)
                recorrido.Add(new Point(x, 270));
            for (int y = 270; y <= 328; y += 5)
                recorrido.Add(new Point(274, y));
            for (int x = 274; x <= 654; x += 5)
                recorrido.Add(new Point(x, 328));
            for (int y = 328; y <= 364; y += 5)
                recorrido.Add(new Point(654, y));
            for (int x = 654; x <= 665; x += 5)
                recorrido.Add(new Point(x, 364));
            for (int y = 364; y <= 462; y += 5)
                recorrido.Add(new Point(665, y));
            for (int x = 665; x >= 602; x -= 5)
                recorrido.Add(new Point(x, 462));
            for (int y = 462; y <= 479; y += 5)
                recorrido.Add(new Point(602, y));
            for (int x = 602; x >= 445; x -= 5)
                recorrido.Add(new Point(x, 479));
            for (int y = 479; y >= 430; y -= 5)
                recorrido.Add(new Point(445, y));
            for (int x = 445; x >= 324; x -= 5)
                recorrido.Add(new Point(x, 430));
            for (int y = 430; y >= 444; y -= 5)
                recorrido.Add(new Point(324, y));
            for (int x = 324; x >= 294; x -= 5)
                recorrido.Add(new Point(x, 444));
            for (int y = 444; y >= 459; y -= 5)
                recorrido.Add(new Point(294, y));
            for (int x = 294; x >= 267; x -= 5)
                recorrido.Add(new Point(x, 459));
            for (int y = 459; y <= 484; y += 5)
                recorrido.Add(new Point(267, y));
            for (int x = 267; x >= 82; x -= 5)
                recorrido.Add(new Point(x, 484));
            for (int y = 484; y >= 406; y -= 5)
                recorrido.Add(new Point(82, y));
            for (int x = 82; x >= 52; x -= 5)
                recorrido.Add(new Point(x, 406));
            for (int y = 406; y >= 216; y -= 5)
                recorrido.Add(new Point(52, y));
        }
        public void Ganador(PictureBox ganador)
        {
            MessageBox.Show("¡El ganador es: " + ganador.Name + "!", "Ganador");
            Reproductor.Stop();
        }
       

        private void MoverCarro(PictureBox carro, int index, int vueltas)
        {
            Random localRand = new Random(Guid.NewGuid().GetHashCode());
            int velocidadFija = localRand.Next(20, 30);
            int vueltasActuales = 0;

            while (vueltasActuales < vueltas)
            {
                foreach (Point p in recorrido)
                {
                    carro.Invoke(new Action(() => carro.Location = p));
                    Thread.Sleep(velocidadFija);
                }
                vueltasActuales++;
            }
            // Solo el primer carro en terminar anunciará el ganador
            if (!ganadorAnunciado)
            {
                ganadorAnunciado = true;
                Ganador(carro);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                Reproductor = new SoundPlayer(Properties.Resources. MusicaF);
                Reproductor.PlayLooping();
                for (int i = 0; i < Personajes.Length; i++)
                {
                    Personajes[i].Location = recorrido[0];
                }

                for (int i = 0; i < Personajes.Length; i++)
                {
                    int index = i;
                    hilos[index] = new Thread(() => MoverCarro(Personajes[index], index, 1));
                    hilos[index].Start();
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            Reproductor.Stop();
            try
            {
                for (int i = 0; i < hilos.Length; i++)
                {
                    if (hilos[i] != null && hilos[i].IsAlive)
                        hilos[i].Suspend(); // ⚠️ Obsoleto
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            Reproductor = new SoundPlayer(Properties.Resources.MusicaF);
            Reproductor.PlayLooping();
            try
            {
                for (int i = 0; i < hilos.Length; i++)
                {
                    if (hilos[i] != null && hilos[i].IsAlive)
                    {
                        hilos[i].Abort(); // ⚠️ Obsoleto
                        Personajes[i].Invoke(new Action(() => Personajes[i].Location = recorrido[0]));
                    }
                }
                //nicio de nuevo ciclo de carrea
                for (int i = 0; i < Personajes.Length; i++)
                {
                    Personajes[i].Location = recorrido[0];
                }

                for (int i = 0; i < Personajes.Length; i++)
                {
                    int index = i;
                    hilos[index] = new Thread(() => MoverCarro(Personajes[index], index, 3));
                    hilos[index].Start();
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Reproductor.Stop();
            try
            {
                for (int i = 0; i < hilos.Length; i++)
                {
                    if (hilos[i] != null && hilos[i].IsAlive)
                    {
                        hilos[i].Abort(); // ⚠️ Obsoleto
                        Personajes[i].Invoke(new Action(() => Personajes[i].Location = recorrido[0]));
                    }
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }
    }
}
