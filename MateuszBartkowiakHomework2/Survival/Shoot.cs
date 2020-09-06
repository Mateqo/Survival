using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszBartkowiakHomework2
{

    public class Shoot
    {
        // Tworzenie obrazka
        public PictureBox pictureBoxShoot = new PictureBox();
        // Tworzenie Timeru
        public Timer timerShoot = new Timer();
        // Deklaracja wielkości pocisku
        public int sizeShoot = 4;
        // Kierunek pocisku
        public string direction = "";
        // Predkość pocisku
        public int shootSpeed = 30;
        // Miejsce wylotu pocisku
        public int idTop;
        public int idLeft;

        /// <summary>
        /// Metoda ustawiająca wizualizacje pocisku
        /// </summary>
        /// <param name="form"></param>
        public void SetShoot(Form form)
        {
            pictureBoxShoot.BackColor = Color.White;
            pictureBoxShoot.Size = new Size(sizeShoot, sizeShoot);
            pictureBoxShoot.Name = "shoot";
            // Ustawi wylotu pocisku
            pictureBoxShoot.Top = idTop;
            pictureBoxShoot.Left = idLeft;
            // Dodanie do ekranu
            form.Controls.Add(pictureBoxShoot);
            // Częstotliwość timera 
            timerShoot.Interval = shootSpeed;
            // Dodanie do zdarzeń
            timerShoot.Tick += new EventHandler(TimerShoot_Tick);
            // Rozpoczęcie timera
            timerShoot.Start();
        }

        /// <summary>
        /// Timer od pocisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerShoot_Tick(object sender, EventArgs e)
        {
            // W zależności od kierunku
            switch (direction)
            {
                // Jeśli lewy
                case "left":
                    // Przsuwaj w lewo
                    pictureBoxShoot.Left -= shootSpeed;
                    break;
                case "right":
                    pictureBoxShoot.Left += shootSpeed;
                    break;
                case "up":
                    pictureBoxShoot.Top -= shootSpeed;
                    break;
                case "down":
                    pictureBoxShoot.Top += shootSpeed;
                    break;
            }
            // Jeśli położenie pocisku będzie mniejsze od zera po lewej stronie
            if (pictureBoxShoot.Left < 0)
            {
                // Zatrzymaj stoper 
                timerShoot.Stop();
                // Zdejmij timer i pocisk z ekranu
                timerShoot.Dispose();
                pictureBoxShoot.Dispose();
            }
          
        }


    }

}
