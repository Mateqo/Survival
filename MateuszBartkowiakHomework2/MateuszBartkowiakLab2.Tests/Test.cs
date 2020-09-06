using MateuszBartkowiakHomework2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MateuszBartkowiakLab2.Tests
{
    public class Test
    {

        [Fact]
        public void CheckProperlyRespawnPosition()
        {
            // Rozmiar okna WindowForms
            int formHeight = 750;
            int formWidth = 1200;

            Player player = new Player(50, 50);
        
            player.SetPosition();

            // Sprawdzanie czy postać pojawi się na ekranie (czy nie poza)
            // Sukces ponieważ konstruktor bezparametryczny nadaje położenie postaci w prawidłowym zakresie
            Assert.True(player.pictureBoxCharacter.Left>=0 && player.pictureBoxCharacter.Left<=formWidth && player.pictureBoxCharacter.Top >= 0 && player.pictureBoxCharacter.Top <= formHeight);
        }

        [Fact]
        public void CompareEnemy()
        {
           // Tworzenie dwóch przeciwników o takich samych wartoścach hp oraz dmg
            Enemy enemy1 = new Enemy(50, 50);
            Enemy enemy2 = new Enemy(50, 50);

            // Ustawianie pozycji
            enemy1.SetPosition();
            enemy2.SetPosition();

            // Sprawdzenie czy przeciwnicy różnią się od siebie położeniem
            // Sukces ponieważ system losowości położenia działa prawidłowo
            Assert.False(enemy1.pictureBoxCharacter.Left==enemy2.pictureBoxCharacter.Left && enemy1.pictureBoxCharacter.Top == enemy2.pictureBoxCharacter.Top);
        }

        [Fact]
        public void VerificationSpeed()
        {
            Shoot shoot = new Shoot();

            // Definiowanie przedziału prędkości
            int minSpeed = 1;
            int maxSpeed = 100;

            // Sprawdzenie czy prędkość kuli znajduję się w przedziale
            Assert.InRange(shoot.shootSpeed, minSpeed, maxSpeed);
        }

        [Fact]
        public void VerificationShoot()
        {
            Shoot shoot = new Shoot();

            // Sprawdzenie czy nie został odpalony timer przed wystrzałem czyli przed wywołaniem SetShoot
            Assert.False(shoot.timerShoot.Enabled);
        }

    }
}
