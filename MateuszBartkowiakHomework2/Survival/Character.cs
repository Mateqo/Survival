using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszBartkowiakHomework2
{

    public abstract class Character
    {
        // Deklaracja obrażeń
        public int demage;
        // Deklaracja zdrowia
        public int hp;
        // Tworzenie obrazka
        public PictureBox pictureBoxCharacter = new PictureBox();


        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="demage"></param>
        public Character(int hp, int demage)
        {
            this.hp = hp;
            this.demage = demage;
        }

        /// <summary>
        /// Ustawianie wyglądu obrazka
        /// </summary>
        /// <param name="form"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="tag"></param>
        virtual public void SetPicture(Form form, int height, int width, string tag)
        {
            // Ustawia wyzoskość,szerokość,oddalanie itp..
            pictureBoxCharacter.Height = height;
            pictureBoxCharacter.Width = width;
            pictureBoxCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCharacter.BackColor = Color.Transparent;
            pictureBoxCharacter.Name = tag;
            form.Controls.Add(pictureBoxCharacter);
            pictureBoxCharacter.BringToFront();
        }
    }



}
