using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszBartkowiakHomework2
{
    // Klasa przeciwnik dziedziczy po charakterze
    public class Enemy : Character
    {
        // Deklaracja zmiennej losowej
        Random r = new Random();

        /// <summary>
        /// Konstruktor który odwołuje się do klasy bazowej (to samo wykonuje)
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="demage"></param>
        public Enemy(int hp, int demage) : base(hp, demage) { }

        /// <summary>
        /// Ustawienie pozycji
        /// </summary>
        public void SetPosition()
        {
            pictureBoxCharacter.Left = r.Next(0, 740);
            pictureBoxCharacter.Top = r.Next(200, 450);
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
            // Ustawienie obrazka
            pictureBoxCharacter.Image = Properties.Resources.enemyLeft;
            // Odwołanie do klasy bazowej (wykonuje to samo)
            base.SetPicture(form, height, width, tag);
        }

    }
}
