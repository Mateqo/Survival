using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszBartkowiakHomework2
{

    public abstract class Item
    {
        // Tworzenie obrazka
        public PictureBox pictureBoxItem = new PictureBox();
        // Deklaracja zmiennej losowej
        public Random r = new Random();

        /// <summary>
        /// Ustawia położenie
        /// </summary>
        public void SetPosition()
        {
            pictureBoxItem.Left = r.Next(0, 740);
            pictureBoxItem.Top = r.Next(200, 450);
        }

        /// <summary>
        /// Metoda wirtualna ustawiająca wygląd obrazka
        /// </summary>
        /// <param name="form"></param>
        /// <param name="tag"></param>
        virtual public void SetPicture(Form form, string tag)
        {
            pictureBoxItem.Height = 40;
            pictureBoxItem.Width = 40;
            pictureBoxItem.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxItem.BackColor = Color.Transparent;
            pictureBoxItem.Name = tag;
            form.Controls.Add(pictureBoxItem);
        }
    }

}
