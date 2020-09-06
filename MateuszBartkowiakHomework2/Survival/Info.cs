using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszBartkowiakHomework2
{
    public partial class Info : Form
    {

        #region Zmienne

        // Deklaracja zmiennej by móc odwoływać się do okna Game 
        Game game;
        // Deklaracja ścieżki jaką wybierzemy w oknu dialogowym 
        string path = "";
        // Deklaracja tablicy przechowująca elementy do wczytania
        public string[] load = new string[5];

        #endregion Zmienne

        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public Info()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor wywołany przez okno Game
        /// </summary>
        /// <param name="game"></param>
        public Info(Game game)
        {
            InitializeComponent();
            // Przypisujemy game by móc sie odwoływać
            this.game = game;
        }

        /// <summary>
        /// Otwarcie okna Game/Ukrycie okna Info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelPlay_Click(object sender, EventArgs e)
        {
            // Ukryj okno Info
            this.Visible = false;
            // Pokaż okno Game
            game.Visible = true;
        }

        /// <summary>
        /// Wybierz plik tekstowy z okna dialogowego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelLoad_Click(object sender, EventArgs e)
        {
            // Utwórz nowy dialog i zmień filtr na rozszerzenie txt
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Plik tekstowy(TXT)|*.txt"
            };
            // Jeśli wybierzemy plik przypisz ścieżkę i ustaw  że gra została wczytana
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;
                game.isSave = true;
            }
            else
                return;

            // Za pomocą streamreader odczytuj linie pliku tekstowego i przypisuj do tablicy
            using (StreamReader sr = new StreamReader(path))
            {
                // Deklaracja zmiennej tymczasowej by móc poruszać się po tablicy
                int i = 0;
                // Wypisz wszystkie linie
                while (sr.Peek() >= 0)
                {                  
                    load[i] = sr.ReadLine();                    
                    i++;
                }

                // Przypisz wczytane zmienne zmiennym oficjalnym z okna Game
                game.lvl = Int32.Parse(load[0]);
                game.score = Int32.Parse(load[1]);
                game.player.hp= Int32.Parse(load[2]);
                game.ammunition= Int32.Parse(load[3]);
                game.ammo = Int32.Parse(load[4]);

                // Ukryj okno Info
                this.Visible = false;
                // Pokaz okno Game
                game.Visible = true;
            }
        }
    }
}
