using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszBartkowiakHomework2
{
    // Klasa gracza dziedziczy bo charakterze
    public class Player : Character
    {
        /// <summary>
        /// Konstruktor który odwołuje się do klasy bazowej (to samo wykonuje)
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="demage"></param>
        public Player(int hp, int demage) : base(hp, demage) { }

        /// <summary>
        /// Ustawianie pozycji
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetPosition(int x, int y)
        {
            pictureBoxCharacter.Left = x;
            pictureBoxCharacter.Top = y;
        }

        /// <summary>
        /// Ustawianie pozycji
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetPosition()
        {
            pictureBoxCharacter.Left = 100;
            pictureBoxCharacter.Top = 350;
        }

        /// <summary>
        /// Przesłonięcie metody (dodajemy jedną linijkę)
        /// </summary>
        /// <param name="form"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="tag"></param>
        override public void SetPicture(Form form, int height, int width, string tag)
        {
            // Ustawiamy obrazek 
            pictureBoxCharacter.Image = Properties.Resources.playerRight;
            // Odwołanie do klasy bazowej (wykonuje to samo)
            base.SetPicture(form, height, width, tag);
        }

    }
}
