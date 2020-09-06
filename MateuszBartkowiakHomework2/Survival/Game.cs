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
    public partial class Game : Form
    {
        //
        //                      Projekt z klasami:
        //                          
        //              Item            Character         Shoot
        //             |    |          |        |
        //            Hp   Ammo      Player   Enemy
        //                                      |
        //                                     Boss


        #region Zmienne

        // Tworzenie gracza hp:100 demage:5
        public Player player = new Player(100,5);
        // Tworzenie bossa hp:100 demage:5
        Boss boss = new Boss(100,5);

        // Deklaracja zmiennej losowej
        Random r = new Random();
        // Deklaracja zmiennej która sprawdza porażka/zwycięstwo
        public bool gameOver;
        // Prędkość poruszania się gracza
        public int playerSpeed = 10;
        // Prędkość poruszania się przeciwników
        public int enemySpeed = 6;
        
        // Kierunek poruszania się gracza (potrzebny do oddania strzału)
        public string direct = "";
        // Deklaracja zmiennej amunicji w magazynku
        public int ammunition = 5;
        // Deklaracja zmiennej amunicji przy sobie
        public int ammo = 10;
        // Określenie czy dzwięki włączone (domyślnie tak)
        string audio = "on";
        // Deklaracja zmiennej określającej czy boss czy zwykły potwór
        bool isBoss;
        // Deklaracja zmiennej do otwarzania dzwięków
        public System.Media.SoundPlayer myPlayer;
        // Deklaracka poziomu
        public int lvl = 1;
        // Deklaracja wyniku
        public int score = 0;
        // Deklaracja zminnej czy wczytano 
        public bool isSave = false;
        // Deklaracja tablicy przechowującęj dane do zapisu
        string[] save = new string[5];
        // Deklaracja ścieżki
        string path;

        #endregion Zmienne

        #region Funkcje

        /// <summary>
        /// Poruszanie sie przeciwników
        /// </summary>
        /// <param name="x"></param>
        /// <param name="imageLeft"></param>
        /// <param name="imageRight"></param>
        /// <param name="imageUp"></param>
        /// <param name="imageDown"></param>
        private void MovingEnemies(Control x, Image imageLeft, Image imageRight, Image imageUp, Image imageDown)
        {
            // Sprawdza czy gracz nie wyszedł poza określony obszar 
            if (((PictureBox)x).Left > player.pictureBoxCharacter.Left + player.pictureBoxCharacter.Width / 2)
            {
                // Gdy nie wyszedł przesuń w lewo 
                ((PictureBox)x).Left -= enemySpeed;
                // Zmień obrazek na pasujący do kierunku ruchu
                ((PictureBox)x).Image = imageLeft;

            }
            if (((PictureBox)x).Left < player.pictureBoxCharacter.Left + player.pictureBoxCharacter.Width / 2)
            {
                ((PictureBox)x).Left += enemySpeed;
                ((PictureBox)x).Image = imageRight;
            }
            if (((PictureBox)x).Top > player.pictureBoxCharacter.Top + player.pictureBoxCharacter.Height / 2)
            { 
                ((PictureBox)x).Top -= enemySpeed;
                ((PictureBox)x).Image = imageUp;
            }
            if (((PictureBox)x).Top < player.pictureBoxCharacter.Top + player.pictureBoxCharacter.Height / 2)
            {
                ((PictureBox)x).Top += enemySpeed;
                ((PictureBox)x).Image = imageDown;
            }
        }

        /// <summary>
        /// Odpowiada za zderzenia przeciwników z graczem (obrażenia)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="isBoss"></param>
        private void DemageByEnemies(Control x, bool isBoss)
        {
            // Sprawdzenie czy wystąpiło zderzenie
            if (((PictureBox)x).Bounds.IntersectsWith(player.pictureBoxCharacter.Bounds))
            {
                // Jeśli tak i życie gracza jest mniejsze od 0
                if (player.hp <= 0)
                {
                    // Przwerwij grę
                    timerGame.Stop();
                    // Ustaw zmienną na true
                    gameOver = true;

                    // Ukryj te okno
                    this.Visible = false;
                    // Stwórz okno End i wyślij tam naszego forma
                    End e = new End(this);
                    // Otwórz je
                    e.ShowDialog();
                    
                    // Włącz widoczność przycisku start
                    pictureBoxStart.Visible = true;
                }

                // Jeśli poziom zdrowia jest większy od zera i to nie jest boss
                if (player.hp > 0 && !isBoss)
                {
                    // Zmniejsz zdrowie gracza (obrażenia)
                    player.hp -= 1;
                    // Zaktualizuj do progresbara i labela dane
                    progressBarHealth.Value = player.hp;
                    labelHealth.Text = "Health: " + player.hp + "%";
                }

                // Jeśli poziom zdrowia jest większy od obrażeń bossa i jest to boss
                if (player.hp > boss.demage && isBoss)
                {
                    // Zmniejsz zdrowie o obrażenia bossa
                    player.hp -= boss.demage;
                    // Zaktualizuj dane do progressbara i labela
                    progressBarHealth.Value = player.hp;
                    labelHealth.Text = "Health: " + player.hp + "%";
                }

                // Jeśli poziom zdrowia jest mniejszy od obrażen bosa i jest to boss
                if (player.hp <= boss.demage && isBoss)
                {
                    // Wyzeruj zdrowie
                    player.hp = 0;
                    // Zaktualizuj dane
                    progressBarHealth.Value = player.hp;
                    labelHealth.Text = "Health: " + player.hp + "%";
                }

            }
        }

        /// <summary>
        /// Odpowiada za chodzenie w górę
        /// </summary>
        private void GoUp()
        {
            // Jeśli odległość gracza od góry okna jest większa od 180
            if (player.pictureBoxCharacter.Top > 180)
                // Zmniejsz odległość od góry (przesuń w górę)
                player.pictureBoxCharacter.Top -= playerSpeed;
            // Zmień obrazek zgodnie z kierunkiem
            player.pictureBoxCharacter.Image = Properties.Resources.playerUp;
            // Zmien kierunek gracza
            direct = "up";
        }

        /// <summary>
        /// Odpowiada za chodzenie w lewo
        /// </summary>
        private void GoLeft()
        {
            // Jeśli odległość gracza od lewej strony okna jest większa od 0
            if (player.pictureBoxCharacter.Left > 0)
                // Zmniejsz odległość (przesuń w lewo)
                player.pictureBoxCharacter.Left -= playerSpeed;
            // Zmień obrazek kierunku oraz zmienną
            player.pictureBoxCharacter.Image = Properties.Resources.playerLeft;
            direct = "left";
        }

        /// <summary>
        /// Odpowiada za chodzenie w dół
        /// </summary>
        private void GoDown()
        {
            // Jeśli odległość gracza od góry jest mniejsza niż 530
            if (player.pictureBoxCharacter.Top < 530)
                // Przesuń gracza w dół
                player.pictureBoxCharacter.Top += playerSpeed;
            // Zmień kierunek obrazku i zmiennej 
            player.pictureBoxCharacter.Image = Properties.Resources.playerDown;
            direct = "down";
        }

        /// <summary>
        /// Odpowiada za chodzenie w prawo
        /// </summary>
        private void GoRight()
        {
            // Jeśli odległość gracza z lewej strony jest mniejszaa niż 840
            if (player.pictureBoxCharacter.Left < 840)
                // Przesuń gracza w prawo
                player.pictureBoxCharacter.Left += playerSpeed;
            // Zmień kierunek obrazka i zmiennej
            player.pictureBoxCharacter.Image = Properties.Resources.playerRight;
            direct = "right";
        }

        /// <summary>
        /// Odpowiada za strzelanie
        /// </summary>
        private void PressX()
        {
            // Jeśli amunicja jest większa od 0 
            if (ammunition > 0)
            {
                // Jeśli dzwięk mamy włączony
                if (audio == "on")
                {
                    // Stwórz nowy dzwięk
                    myPlayer = new System.Media.SoundPlayer
                    {
                        // Podajemy dzwięk jaki chcemy
                        SoundLocation = "shoot.wav"
                    };
                    // Odtwórz dzwięk
                    myPlayer.Play();
                }

                // Tworzymy nowy obiekt
                Shoot shoot = new Shoot
                {
                    // Przypisujemy kierunek  do pocisku
                    direction = direct,
                    // Ustawiamy miejsce startu pocisku (parametry gracza ale przerobione aby były bliżej broni)
                    idLeft = player.pictureBoxCharacter.Left + (player.pictureBoxCharacter.Width / 3),
                    idTop = player.pictureBoxCharacter.Top + (player.pictureBoxCharacter.Height / 3)
                };

                // Ustawiamy strzał wysyłamy nasza forme
                shoot.SetShoot(this);
                // Zmniejszamy amunicje
                ammunition--;
                // Aktulizujemy dane
                labelAmunnition.Text = ammunition + "/5";

                // Jeśli amunicja wynosi 0
                if (ammunition == 0)
                {
                    // Pojawi się label 
                    labelReload.Visible = true;
                }

                // Jeśli nie posiadamy żadnej amunicji
                if (ammo == 0 && ammunition == 0)
                    // Wyświetli się label
                    labelReload.Text = "Brak amunicji";

                // Jeśli amunicja jest równa 0
                if (ammunition == 0)
                {
                    // Stwórz nowy obiekt amunicji
                    Ammo ammo = new Ammo();
                    // Ustaw pozycje
                    ammo.SetPosition();
                    // Ustaw wygląd obrazka (wyślij forme i nazwe)
                    ammo.SetPicture(this, "ammunition");
                }
        
            }
        }

        /// <summary>
        /// Odpowiada za przeładowanie
        /// </summary>
        private void PressR()
        {
            // Jeśli amunicja w magazynku wynosi 0 
            if (ammunition == 0)
            {
                // Jeśli amunicja zebrana jest większa od 0 
                if (ammo > 0)
                {
                    // Jeśli dzwięki są włączone
                    if (audio == "on")
                    {
                        // Przypisz ten dzwięk
                        myPlayer.SoundLocation = "reload.wav";
                        // Odtwórz
                        myPlayer.Play();
                    }

                    // Ukryj label o przeładowaniu
                    labelReload.Visible = false;
                    // Dodaj do magazynka odejmnij z ogółu
                    ammunition += 5;
                    ammo -= 5;
                    // Włącz obrazek ładowania
                    pictureBoxReload.Visible = true;

                    // Stwórz nowy Timer odpowiadający za przeładowanie
                    Timer timerReload = new Timer
                    {
                        // Ustaw częstotliwość
                        Interval = 500
                    };

                    // Przypisanie timera do zdarzenia
                    timerReload.Tick += new EventHandler(TimerReload_Tick);
                    // Rozpocznij 
                    timerReload.Start();

                }
            }
        }

        /// <summary>
        /// Odpowiada za czyszczenie z ekranu zombie
        /// </summary>
        private void DeleteZombie()
        {
            // Wyłap wszystkie kontrolki
            foreach (Control x in this.Controls)
            {
                // Jeśli któraś to przeciwnik
                if (x is PictureBox && (x.Name == "enemy" || x.Name == "enemyLvl2" || x.Name == "enemyLvl3"))
                {
                    // Usuń z ekranu
                    this.Controls.Remove(x);
                    x.Dispose();
                }
            }
        }


        /// <summary>
        /// Odpowiada za sprawdzenie poziomu gry
        /// </summary>
        private void CheckLvl()
        {
            // Sprawdza czy uzyskano taki wynik
            if (score == 5 || score == 15 || score == 30 || score == 50)
            {

                // Wywoałanie funkcji usuwania zombie
                DeleteZombie();
                // Wyłączenie timeru
                timerGame.Stop();
                // Aktualizacja labela i inkrementacja lvl
                labelCompleted.Text = "You completed level " + lvl;
                lvl++;
                // Pojawienie sie buttonów i labela
                labelCompleted.Visible = true;
                buttonNextLvl.Visible = true;
                buttonSave.Visible = true;
                // Wrzuć na front
                labelCompleted.BringToFront();
                buttonNextLvl.BringToFront();
                buttonSave.BringToFront();
            }
        }

        /// <summary>
        /// Głowna mechanika gry (poruszanie sie przeciwników/zderzenia/zbieranie amunicji i zdrowia...)
        /// </summary>
        private void GameMechanics()
        {
            // Pętla, która wyłapuje wszystkie kontrolki
            foreach (Control x in this.Controls)
            {
                #region Poruszanie się przeciwników i wykrycie zderzenia

                // Sprawdza czy wyłapana kontrolka to przeciwnik
                if (x is PictureBox && (x.Name == "enemy" || x.Name == "enemyLvl2" || x.Name == "enemyLvl3"))

                {   // Ustawianie zmiennej, że potwór nie jest bosem             
                    isBoss = false;
                    // Wywołanie metody odpowiadającej za poruszanię się potworków
                    MovingEnemies(x, Properties.Resources.enemyLeft, Properties.Resources.enemyRight, Properties.Resources.enemyUp, Properties.Resources.enemyDown);
                    // Wywołanie metody odpowiadającej za wykrywanie zderzenia z potworem
                    DemageByEnemies(x, isBoss);
                }
                if (x is PictureBox && x.Name == "boss")
                {
                    // Ustawianie zmiennej, że potwór jest bossem
                    isBoss = true;

                    // Wywołanie metody odpowiadającej za poruszanię się bossa
                    MovingEnemies(x, Properties.Resources.bossLeft, Properties.Resources.bossRight, Properties.Resources.bossUp, Properties.Resources.bossDown);
                    // Wywołanie metody odpowiadającej za wykrywanie zderzenia z potworem
                    DemageByEnemies(x, isBoss);
                }

                #endregion Poruszanie się przeciwników i wykrycie zderzenia

                #region Zbieranie zdrowia i amunicji

                // Sprawdzamy czy wyłapana kontrolka to amunicja
                if (x is PictureBox && x.Name == "ammunition")
                {
                    // Jeśli tak to sprawdzamy czy zderzyła się z graczem
                    if (((PictureBox)x).Bounds.IntersectsWith(player.pictureBoxCharacter.Bounds))
                    {
                        // Jeśli tak to usuń z ekranu
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                        // Powiększ amunicje o 5
                        ammo += 5;
                        // Nadpisz label
                        labelAmmo.Text = ammo.ToString();
                    }
                }

                // Sprawdzamy czy wyłapana kontrolka to życie
                if (x is PictureBox && x.Name == "hp")
                {
                    // Jeśli tak to sprawdzamy czy zderzyło się z graczem
                    if (((PictureBox)x).Bounds.IntersectsWith(player.pictureBoxCharacter.Bounds))
                    {
                        // Jeśli tak to usuń z ekranu 
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                        // Jeśli życie gracza jest mniejsze od 100
                        if (player.hp < 100)
                        {
                            // I jednocześnie większe lub równe 80
                            if (player.hp >= 80)
                            {
                                // Przypisujemy tymczasowej zmiennej życie gracza
                                int tmp = player.hp;
                                // Graczowi powiększamy życie o maksymalną możliwą ilość
                                player.hp += 100 - tmp;
                            }
                            // Jeśli mniejsze od 80
                            else
                            {
                                // Powiększamy o 20
                                player.hp += 20;
                            }

                            // Nadpisujemy progressbara i label
                            progressBarHealth.Value = player.hp;
                            labelHealth.Text = "Health: " + player.hp + "%";

                        }
                    }
                }

                #endregion Zbieranie zdrowia i amunicji

                // Pętla, która wyłapuje kolejne kontrolki (by móc porównywac i działać na dwóch jednocześnie)
                foreach (Control y in this.Controls)
                {

                    #region Wykrywanie trafienia

                    // Jeśli wyłapiemy pocisk i potwora
                    if ((y is PictureBox && y.Name == "shoot") && (x is PictureBox && (x.Name == "enemy" || x.Name == "enemyLvl2" || x.Name == "enemyLvl3")))
                    {
                        // Jeśli wykryje zderzenie potwora i pocisku
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            // Jeśli to potwór początkowy
                            if (x.Name == "enemy")
                            {
                                // Zwiększ score o jeden
                                score++;
                                // Nadpisujemy do labela zaktualizowany score
                                labelScore.Text = "Score: " + score;

                                // Usuwamy kontrolke pocisku
                                this.Controls.Remove(y);
                                y.Dispose();

                                // Usuwamy potwora
                                this.Controls.Remove(x);
                                x.Dispose();

                                // Losujemy licze ze zbioru
                                int tmp = r.Next(0, 6);
                                // Jeśli wylosuje jeden stwórz życie 

                                if (tmp == 1)
                                {
                                    // Utworzenie obiektu hp
                                    Hp hp = new Hp();
                                    // Odwołanie się do metody, która ustawia pozycje
                                    hp.SetPosition();
                                    // Odwołanie sie do metody, która ustawia opcje obrazu (wysyłamy forme i nazwe)
                                    hp.SetPicture(this, "hp");
                                }

                                // Stwórz obiekt enemy
                                Enemy enemy = new Enemy(1, 1);
                                // Odwołanie się do metody, która ustawia pozycje
                                enemy.SetPosition();
                                // Odwołanie sie do metody, która ustawia opcje obrazu (wysyłamy forme wymiary i nazwe)
                                enemy.SetPicture(this, 80, 80, "enemy");

                            }

                            // Jeśli to potwór lvl2 (po połączeniu)
                            if (x.Name == ("enemyLvl2"))
                            {
                                score++;
                                labelScore.Text = "Score: " + score;

                                this.Controls.Remove(y);
                                y.Dispose();

                                int tmp = r.Next(0, 6);

                                if (tmp == 1)
                                {
                                    Hp hp = new Hp();
                                    hp.SetPosition();
                                    hp.SetPicture(this, "hp");
                                }

                                // Zmniejszamy poziom potwora poprzez zmiane nazwy i wymiarów
                                x.Name = "enemy";
                                x.Width = 100;
                                x.Height = 100;

                                Enemy enemy = new Enemy(1, 1);
                                enemy.SetPosition();
                                enemy.SetPicture(this, 80, 80, "enemy");

                            }

                            // Jeśli potwór ma lvl3
                            if (x.Name == "enemyLvl3")
                            {

                                score++;
                                labelScore.Text = "Score: " + score;

                                this.Controls.Remove(y);
                                y.Dispose();

                                int tmp = r.Next(0, 6);
                                if (tmp == 1)
                                {
                                    Hp hp = new Hp();
                                    hp.SetPosition();
                                    hp.SetPicture(this, "hp");
                                }

                                x.Name = "enemy_lvl2";
                                x.Width = 150;
                                x.Height = 150;

                                Enemy enemy = new Enemy(1, 1);
                                enemy.SetPosition();
                                enemy.SetPicture(this, 80, 80, "enemy");

                            }
                        }
                    }

                    // Jeśli wyłapiemy pocisk i bossa
                    if ((y is PictureBox && y.Name == "shoot") && (x is PictureBox && x.Name == "boss"))
                    {
                        // Jeśli wykryje zderzenie pocisku i bossa
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            // Zadaj obrażenia bossowi
                            boss.hp -= player.demage;
                            // Zaktualizuj label i progress bara
                            labelBossHealth.Text = "Health: " + boss.hp;
                            progressBarBossHealth.Value = boss.hp;

                            // Usuń pocisk z ekranu
                            this.Controls.Remove(y);
                            y.Dispose();

                            // Jeśli boss posiada mniejszą ilość hp niż 0
                            if (boss.hp <= 0)
                            {
                                // Usuń bossaa z ekranu
                                this.Controls.Remove(x);
                                x.Dispose();

                                //ustaw zmienna na false (bo wygraliśmy), oraz pokaż okno końcowe
                                gameOver = false;
                                this.Visible = false;
                                End e = new End(this);
                                e.ShowDialog();
                                pictureBoxStart.Visible = true;
                            }

                        }
                    }

                    #endregion Wykrywanie trafienia

                    #region Łączenie się zombie w większe zombie

                    // Jeśli wyłapie dwa potwory
                    if ((y is PictureBox && y.Name == "enemy") && (x is PictureBox && x.Name == "enemy") && (x != y))
                    {
                        // Jeśli wykryje zderzenie pomiędzy nimi
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            // Usuń jednego potwora
                            this.Controls.Remove(x);
                            x.Dispose();
                            // Zwiększ poziom potwora poprzez zmianę nazwy i zwiększenie wymiarów
                            y.Name = "enemyLvl2";
                            y.Height = 110;
                            y.Width = 110;
                        }
                    }

                    if ((y is PictureBox && y.Name == "enemy") && (x is PictureBox && x.Name == "enemy_lvl2"))
                    {
                        if (y.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.Controls.Remove(y);
                            y.Dispose();
                            x.Name = "enemyLvl3";
                            x.Height = 140;
                            x.Width = 140;
                        }
                    }

                    #endregion Łączenie się zombie w większe zombie

                }
            }
        }

        #endregion Funkcje

        /// <summary>
        /// Konstryktor domyślny
        /// </summary>
        public Game()
        {
            InitializeComponent();

            // Ustawienie pozycji gracza           
            player.SetPosition(100,350);
            // Ustawienie wyglądu obrazka wysyłamy forme wymiary i nazwe
            player.SetPicture(this,80,80,"player");

            // Wczytujemy do obrazka gif (przeładowanie)
            pictureBoxReload.Image = Image.FromFile("loading.gif");

            // Ustawiamy styl dzięki któremu po zmianie położenia obiektu nie zostanie biały pozostały fragment
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer, true);

            // Wczytujemy obrazek dzwięku
            pictureBoxSound.Image = Properties.Resources.onPng;

            
        }
        
        /// <summary>
        /// Otworzenie okna informacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_Load(object sender, EventArgs e)
        {
            // Ukryj te okno
            this.Visible = false;
            // Stwórz okno Info i wyślij tam forme
            Info info = new Info(this);
            // Otwórz je
            info.ShowDialog();
        }

        /// <summary>
        /// Stworzenie przeciwników i start całej gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxStart_Click(object sender, EventArgs e)
        {
            // Ukryj przycisk start
            pictureBoxStart.Visible = false;
            timerCheckSave.Stop();


            // Stwórz 3 przeciwników (obiekty) hp:5 demage:1
            // Ustaw im pozycje (wywołanie metody)
            // Ustaw wygląd obrazka (wywołanie metody)
            Enemy enemy = new Enemy(5,1);
            enemy.SetPosition();
            enemy.SetPicture(this, 80, 80, "enemy");


            Enemy enemy2 = new Enemy(5, 1);
            enemy2.SetPosition();
            enemy2.SetPicture(this, 80, 80, "enemy");

            Enemy enemy3 = new Enemy(5, 1);
            enemy3.SetPosition();
            enemy3.SetPicture(this, 80, 80, "enemy");

            // Rozpocznij timer 
            timerGame.Start();
        }

        #region Timery

        /// <summary>
        /// Timer odpowiedzialny za przeładowanie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerReload_Tick(object sender, EventArgs e)
        {
            // Przypisuj aktualną ilość amunicji
            labelAmmo.Text = ammo.ToString();
            labelAmunnition.Text = ammunition + "/5";
            // Wyłącz przeładowanie (gif)
            pictureBoxReload.Visible = false;
        }

        /// <summary>
        /// Timer odpowiedzialny za całą mechanike gry 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerGame_Tick(object sender, EventArgs e)
        {
            // Wywołanie funkcji odpowiedzilną za zderzenia 
            GameMechanics();
            // Wywołanie funkjci sprawdzająca poziom gry
            CheckLvl();
        }

        /// <summary>
        /// Timer odpowiedzialny za sprawdzenie czy wczytano grę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerCheckSave_Tick(object sender, EventArgs e)
        {
            // Jeśli wczytano gre 
            if (isSave == true)
            {
                // Aktualizuj labelei progress bara
                labelScore.Text = "Score: " + score;
                labelLvl.Text = "Lvl: " + lvl;
                labelHealth.Text = "Health: " + player.hp + "%";
                progressBarHealth.Value = player.hp;
                labelAmmo.Text = ammo.ToString();
                labelAmunnition.Text = ammunition + "/5";

                if (lvl != 0)
                {
                    // Sprawdz poziom
                    CheckLvl();
                    if (isSave == true)
                    {
                        // Dekrementacja (żeby wyskoczył prawidłowy pozio a nie już powiększony)
                        lvl--;
                        isSave = false;
                    }

                    labelCompleted.Text = "You completed level " + lvl;
                    lvl++;
                    // Wyłącz timer
                    if (labelCompleted.Visible == true)
                        timerCheckSave.Stop();
                }
            }
        }

        #endregion Timery

        #region Przyciski wyłącz/info/dzwięk

        /// <summary>
        /// Otwórz okno informacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxInfo_Click(object sender, EventArgs e)
        {
            // Ukryj te okno
            this.Visible = false;
            // Stwórz okno Info i wyślij tam forme
            Info info = new Info(this);
            // Otwórz je
            info.ShowDialog();
        }

        /// <summary>
        /// Wyłącz/Włącz dzwięki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxSound_Click(object sender, EventArgs e)
        {
            // Jeśli dzwięk jest wyłączony
            if (audio == "off")
            {
                // Włącz
                audio = "on";
                // Zmień obrazek
                pictureBoxSound.Image = Properties.Resources.onPng;
            }
            // Jeśli jest włączony
            else
            {
                // Wyłacz
                audio = "off";
                // Zmień obrazek
                pictureBoxSound.Image = Properties.Resources.offPng;
            }
        }

        /// <summary>
        /// Wyjście z aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            // Zmienna która przechowuje powiadomienie, możliwe odpowiedzi yes/no
            DialogResult rezultat = MessageBox.Show("Czy na pewno chcesz wyjść do menu.\nPostęp zostanie usunięty.", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Jeśli zaznaczymy yes
            if (rezultat == DialogResult.Yes)
            {
                // nie anulujemy zamykania sie programu              
                this.Close();
            }
            // Jeśli no 
            else
                // Anulujemy zamykanie
                return;
        }

        #endregion Przyciski wyłącz/info/dzwięk

        /// <summary>
        /// Sterowanie 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {   
            // Jeśli klikniemy dany przycisk na klawiaturze wykonaj:
            if (e.KeyCode == Keys.W)
            {
                GoUp();
            }
          
            if (e.KeyCode == Keys.A)
            {
                GoLeft();
            }

            if (e.KeyCode == Keys.S)
            {
                GoDown();
            }

            if (e.KeyCode == Keys.D)
            {
                GoRight();
            }

            if (e.KeyCode == Keys.X)
            {
                PressX();
            }

            if (e.KeyCode == Keys.R)
            {
                PressR();
            }
        }
     
        /// <summary>
        /// Następny poziom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNextLvl_Click(object sender, EventArgs e)
        {
            // Wywołanie funkcji usuwania zombie
            DeleteZombie();
            // Powiększ score
            score++;
            // Aktualizacja labela i ukrycie buttonów
            labelLvl.Text = "Lvl: " + lvl;
            labelCompleted.Visible = false;
            buttonNextLvl.Visible = false;
            buttonSave.Visible = false;

            // Switch zależny od poziomu (w zależności od poziomu tworzy przeciwników)
            switch (lvl)
            {
                case 2:
                    {
                        Enemy enemy = new Enemy(5, 1);
                        enemy.SetPosition();
                        enemy.SetPicture(this, 80, 80, "enemy");

                        Enemy enemy2 = new Enemy(5, 1);
                        enemy2.SetPosition();
                        enemy2.SetPicture(this, 80, 80, "enemy");

                        Enemy enemy3 = new Enemy(5, 1);
                        enemy3.SetPosition();
                        enemy3.SetPicture(this, 80, 80, "enemy");
                    }
                    break;
                case 3:
                    {
                        Enemy enemy = new Enemy(5, 1);
                        enemy.SetPosition();
                        enemy.SetPicture(this, 80, 80, "enemy");

                        Enemy enemy2 = new Enemy(5, 1);
                        enemy2.SetPosition();
                        enemy2.SetPicture(this, 80, 80, "enemy");

                        Enemy enemy3 = new Enemy(5, 1);
                        enemy3.SetPosition();
                        enemy3.SetPicture(this, 80, 80, "enemy");
                    }
                    break;
                case 4:
                    {
                        Enemy enemy = new Enemy(5, 1);
                        enemy.SetPosition();
                        enemy.SetPicture(this, 80, 80, "enemy");

                        Enemy enemy2 = new Enemy(5, 1);
                        enemy2.SetPosition();
                        enemy2.SetPicture(this, 80, 80, "enemy");

                        Enemy enemy3 = new Enemy(5, 1);
                        enemy3.SetPosition();
                        enemy3.SetPicture(this, 80, 80, "enemy");
                    }
                    break;
                case 5:
                    {
                        // Wyczyść zombie używając funkcji
                        DeleteZombie();
                        // Ustaw pozycje bossa
                        boss.SetPosition();
                        // Ustaw wygląd obrazka boss (wysyłamy forme ,wymiary,nazwe,label i progressbar)
                        boss.SetPicture(this, 150, 150, "boss", labelBossHealth, progressBarBossHealth);
                    }
                    break;
                default:
                    break;
            }
            
            // Rozpocznij timer 
            timerGame.Start();
            // Ustawiamy na true by wykrywało klawisze
            this.KeyPreview = true;

        }

        /// <summary>
        /// Zapis stanu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Przypisanie do tablicy głownych parametrów, by móc je zapisać
            save[0] = (lvl - 1).ToString();
            save[1] = score.ToString();
            save[2] = player.hp.ToString();
            save[3] = ammunition.ToString();
            save[4] = ammo.ToString();

            // Tworzenie dialogu i ustawienie filtru tekstowego
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Plik tekstowy (TXT)|*.txt"
            };
            // Jesli wybierzemy
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Przypisz wybraną ścieżkę 
                path = dialog.FileName;

                // Za pomocą stremwriter zapisz do ścieżki zmienne z tablicy
                using (StreamWriter sw = new StreamWriter(path))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        sw.WriteLine(save[i]);
                    }
                }

                // Pokaż powiadomienie o zapisaniu
                MessageBox.Show("Zapisano", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        
        }

    }
}



