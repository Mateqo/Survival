using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszBartkowiakHomework2
{
    // Klasa boss dziedziczy po przeciwniku
    public class Boss : Enemy
    {
        /// <summary>
        /// Konstruktor który odwołuje się do klasy bazowej (to samo wykonuje)
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="demage"></param>
        public Boss(int hp, int demage) : base(hp, demage) { }

        /// <summary>
        /// Przeciązenie metody o tej samej nazwie (inne parametry)
        /// </summary>
        /// <param name="form"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="tag"></param>
        /// <param name="labelBossHealth"></param>
        /// <param name="pictureBoxBossHealth"></param>
        public void SetPicture(Form form, int height, int width, string tag, Label labelBossHealth, ProgressBar pictureBoxBossHealth)
        {
            // Zmien obrazek
            pictureBoxCharacter.Image = Properties.Resources.bossLeft;

            // Odwołanie do klasy bazowej (wykonuje to samo)
            base.SetPicture(form, height, width, tag);

            // Ustawienie widoczności progress bara i labela
            labelBossHealth.Visible = true;
            pictureBoxBossHealth.Visible = true;
        }
    }
}
