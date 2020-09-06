using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszBartkowiakHomework2
{
    public partial class End : Form
    {
        // Deklaracja zmiennej by móc odwoływać się do okna Game  
        Game game;

        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public End()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kontruktor wywołany przez okna Game
        /// </summary>
        /// <param name="game"></param>
        public End(Game game)
        {
            InitializeComponent();
            // Przypisujemy game by móc się odwoływać 
            this.game = game;
            // Sprawdź czy gracz przegrał
            if (game.gameOver == true)
                // Przypisujemy obrazek klęski lub zwycięstwa
                pictureBoxEnd.Image = Properties.Resources.gameOver;
            else
                pictureBoxEnd.Image = Properties.Resources.win;

        }

        /// <summary>
        /// Restart aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxReturn_Click(object sender, EventArgs e)
        {
            // Restartowanie aplikacji
            Application.Restart();            
        }
    }
}
