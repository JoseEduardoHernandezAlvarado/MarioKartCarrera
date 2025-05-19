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

namespace MarioKartCarrera
{
    public partial class Form1 : Form
    {
        Thread[] hilos;
        int[] vueltasTotales;
        PictureBox[] Personajes;
        List<Point> recorrido;

        public Form1()
        {
            // Corrección: evita problemas por escalado de DPI
            this.AutoScaleMode = AutoScaleMode.None;

            // Corrección: evita que el usuario cambie el tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            InitializeComponent();

            Personajes = new PictureBox[] { C1, C2, C3, C4, C5 };
            hilos = new Thread[Personajes.Length];
            vueltasTotales = new int[Personajes.Length];
            InicializarRecorrido();
        }

        private void InicializarRecorrido()
        {
            recorrido = new List<Point>();

            

            for (int y = (int)(396 * 0.7); y >= (int)(81 * 0.7); y -= 11) 
                recorrido.Add(new Point((int)(129 * 0.5556), y));
            for (int x = (int)(129 * 0.5556); x <= (int)(580 * 0.5556); x += 8)
                recorrido.Add(new Point(x, (int)(81 * 0.7))); 
            for (int y = (int)(81 * 0.7); y >= (int)(127 * 0.7); y -= 11)
                recorrido.Add(new Point((int)(580 * 0.5556), y));
            for (int x = (int)(580 * 0.5556); x <= (int)(642 * 0.5556); x += 8) 
                recorrido.Add(new Point(x, (int)(127 * 0.7))); 
            for (int y = (int)(127 * 0.7); y <= (int)(196 * 0.7); y += 11)
                recorrido.Add(new Point((int)(642 * 0.5556), y)); 
            for (int x = (int)(642 * 0.5556); x <= (int)(697 * 0.5556); x += 8)
                recorrido.Add(new Point(x, (int)(196 * 0.7))); 
            for (int y = (int)(196 * 0.7); y <= (int)(268 * 0.7); y += 11) 
                recorrido.Add(new Point((int)(697 * 0.5556), y)); 
            for (int x = (int)(697 * 0.5556); x <= (int)(1184 * 0.5556); x += 8) 
                recorrido.Add(new Point(x, (int)(268 * 0.7))); 
            for (int y = (int)(268 * 0.7); y >= (int)(106 * 0.7); y -= 11) 
                recorrido.Add(new Point((int)(1184 * 0.5556), y)); 
            for (int x = (int)(1184 * 0.5556); x <= (int)(1255 * 0.5556); x += 8) 
                recorrido.Add(new Point(x, (int)(106 * 0.7))); 
            for (int y = (int)(106 * 0.7); y >= (int)(67 * 0.7); y -= 11) 
                recorrido.Add(new Point((int)(1255 * 0.5556), y)); 
            for (int x = (int)(1255 * 0.5556); x <= (int)(1628 * 0.5556); x += 8) 
                recorrido.Add(new Point(x, (int)(67 * 0.7)));
            for (int y = (int)(67 * 0.7); y <= (int)(105 * 0.7); y += 11) 
                recorrido.Add(new Point((int)(1628 * 0.5556), y)); 
            for (int x = (int)(1628 * 0.5556); x <= (int)(1721 * 0.5556); x += 8) 
                recorrido.Add(new Point(x, (int)(105 * 0.7))); 
            for (int y = (int)(105 * 0.7); y <= (int)(366 * 0.7); y += 11) 
                recorrido.Add(new Point((int)(1721 * 0.5556), y)); 
            for (int x = (int)(1721 * 0.5556); x >= (int)(1605 * 0.5556); x -= 8) 
                recorrido.Add(new Point(x, (int)(366 * 0.7))); 
            for (int y = (int)(366 * 0.7); y <= (int)(409 * 0.7); y += 11) 
                recorrido.Add(new Point((int)(1605 * 0.5556), y)); 
            for (int x = (int)(1605 * 0.5556); x >= (int)(1343 * 0.5556); x -= 8) 
                recorrido.Add(new Point(x, (int)(409 * 0.7))); 
            for (int y = (int)(409 * 0.7); y <= (int)(442 * 0.7); y += 11) 
                recorrido.Add(new Point((int)(1343 * 0.5556), y)); 
            for (int x = (int)(1343 * 0.5556); x >= (int)(1005 * 0.5556); x -= 8) 
                recorrido.Add(new Point(x, (int)(442 * 0.7)));
            for (int y = (int)(442 * 0.7); y <= (int)(488 * 0.7); y += 11) 
                recorrido.Add(new Point((int)(1005 * 0.5556), y)); 
            for (int x = (int)(1005 * 0.5556); x >= (int)(710 * 0.5556); x -= 8)
                recorrido.Add(new Point(x, (int)(488 * 0.7))); 
            for (int y = (int)(488 * 0.7); y <= (int)(615 * 0.7); y += 11)
                recorrido.Add(new Point((int)(710 * 0.5556), y));
            for (int x = (int)(710 * 0.5556); x <= (int)(1680 * 0.5556); x += 8) 
                recorrido.Add(new Point(x, (int)(615 * 0.7))); 
            for (int y = (int)(615 * 0.7); y <= (int)(676 * 0.7); y += 11) 
                recorrido.Add(new Point((int)(1680 * 0.5556), y));
            for (int x = (int)(1680 * 0.5556); x <= (int)(1729 * 0.5556); x += 8) 
                recorrido.Add(new Point(x, (int)(676 * 0.7))); 
            for (int y = (int)(676 * 0.7); y <= (int)(840 * 0.7); y += 11) 
                recorrido.Add(new Point((int)(1729 * 0.5556), y)); 
            for (int x = (int)(1729 * 0.5556); x >= (int)(1665 * 0.5556); x -= 8) 
                recorrido.Add(new Point(x, (int)(840 * 0.7))); 
            for (int y = (int)(840 * 0.7); y <= (int)(877 * 0.7); y += 11) 
                recorrido.Add(new Point((int)(1665 * 0.5556), y)); 
            for (int x = (int)(1665 * 0.5556); x >= (int)(1124 * 0.5556); x -= 8) 
                recorrido.Add(new Point(x, (int)(877 * 0.7))); 
            for (int y = (int)(877 * 0.7); y >= (int)(800 * 0.7); y -= 11) 
                recorrido.Add(new Point((int)(1124 * 0.5556), y)); 
            for (int x = (int)(1124 * 0.5556); x >= (int)(809 * 0.5556); x -= 8) 
                recorrido.Add(new Point(x, (int)(800 * 0.7))); 
            for (int y = (int)(800 * 0.7); y >= (int)(762 * 0.7); y -= 11) 
                recorrido.Add(new Point((int)(809 * 0.5556), y)); 
            for (int x = (int)(809 * 0.5556); x >= (int)(666 * 0.5556); x -= 8) 
                recorrido.Add(new Point(x, (int)(762 * 0.7))); 
            for (int y = (int)(762 * 0.7); y <= (int)(925 * 0.7); y += 11) 
                recorrido.Add(new Point((int)(666 * 0.5556), y));
            for (int x = (int)(666 * 0.5556); x >= (int)(199 * 0.5556); x -= 8) 
                recorrido.Add(new Point(x, (int)(925 * 0.7))); 
            for (int y = (int)(925 * 0.7); y >= (int)(823 * 0.7); y -= 11) 
                recorrido.Add(new Point((int)(199 * 0.5556), y)); 
            for (int x = (int)(199 * 0.5556); x >= (int)(144 * 0.5556); x -= 8)
                recorrido.Add(new Point(x, (int)(823 * 0.7)));
            for (int y = (int)(823 * 0.7); y >= (int)(396 * 0.7); y -= 11) 
                recorrido.Add(new Point((int)(144 * 0.5556), y)); 
        }

        private void MoverCarro(PictureBox carro, int index, int vueltas)
        {
            Random localRand = new Random(Guid.NewGuid().GetHashCode());
            int velocidadFija = localRand.Next(5,7);
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                // Corrección: colocar todos los personajes al inicio del recorrido
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

        private void btnPausa_Click(object sender, EventArgs e)
        {
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
            try
            {
                for (int i = 0; i < hilos.Length; i++)
                {
                    if (hilos[i] != null && hilos[i].ThreadState == ThreadState.Suspended)
                        hilos[i].Resume(); // ⚠️ Obsoleto
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
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
