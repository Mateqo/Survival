using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszBartkowiakHomework2
{
    // Klasa Ammo dziedzicząca po Item
    public class Ammo : Item
    {
        /// <summary>
        /// Przesłonięcie metody (dodanie jednej linijki)
        /// </summary>
        /// <param name="form"></param>
        /// <param name="tag"></param>
        override public void SetPicture(Form form, string tag)
        {
            // Ustawienie obrazka
            pictureBoxItem.Image = Properties.Resources.ammunition;
            // Odwołanie do klasy bazowej (wykonuje to samo)
            base.SetPicture(form, tag);
        }
    }
}
