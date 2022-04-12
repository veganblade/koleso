using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Data;
using System.Media;

namespace laba34IZ
{
    public partial class Ответы : Form
    {
        public Ответы()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
        }
        public Ответы(int choice)
        {
            InitializeComponent();
            if (choice == 1)
            {
                label1.Text = "Michelin Pilot Sport 4 ";
                pictureBox3.Image = Properties.Resources.Michelin_Pilot_Sport_4;
            }
            if (choice == 2)
            {
                label1.Text = "Michelin Pilot Sport 4 Luxe";
                pictureBox3.Image = Properties.Resources.MichelinPilotSport4БУ;
            }
            if (choice == 3)
            {
                label1.Text = "Michelin Primacy 4 ";
                pictureBox3.Image = Properties.Resources.MichelinPrimacy4;
            }
            if (choice == 4)
            {
                label1.Text = "Michelin Primacy 4 foMatich";
                pictureBox3.Image = Properties.Resources.MichelinPrimacy4БУ;
            }
            if (choice == 5)
            {
                label1.Text = "Michelin Latitude Sport 3 ";
                pictureBox3.Image = Properties.Resources.MichelinLatitudeSport3;
            }
            if (choice == 6)
            {
                label1.Text = "Michelin Latitude Sport 3 Sport";
                pictureBox3.Image = Properties.Resources.MichelinLatitudeSport3БУ;
            }
            if (choice == 7)
            {
                label1.Text = "Michelin X-Ice North 4 ";
                pictureBox3.Image = Properties.Resources.MichelinXIceNorth4;
            }
            if (choice == 8)
            {
                label1.Text = "Michelin X-Ice North 4 s";
                pictureBox3.Image = Properties.Resources.MichelinXIceNorth4БУ;
            }
            if (choice == 9)
            {
                label1.Text = "Michelin X-ICE SNOW ";
                pictureBox3.Image = Properties.Resources.MichelinXICESNOW;
            }
            if (choice == 10)
            {
                label1.Text = "Michelin X-ICE SNOW Kienwood ";
                pictureBox3.Image = Properties.Resources.MichelinXICESNOWБУ;
            }
            if (choice == 11)
            {
                label1.Text = "Michelin Latitude Alpin 2 ";
                pictureBox3.Image = Properties.Resources.MichelinLatitudeAlpin2;
            }
            if (choice == 12)
            {
                label1.Text = "Michelin Latitude Alpin 2";
                pictureBox3.Image = Properties.Resources.MichelinLatitudeAlpin2БУ;
            }
            if (choice == 13)
            {
                label1.Text = "Bridgestone Ecopia EP300 ";
                pictureBox3.Image = Properties.Resources.BridgestoneEcopiaEP300;
            }
            if (choice == 14)
            {
                label1.Text = "Bridgestone Ecopia EP300-1 ";
                pictureBox3.Image = Properties.Resources.BridgestoneEcopiaEP300БУ;
            }
            if (choice == 15)
            {
                label1.Text = "Bridgestone Potenza S001 ";
                pictureBox3.Image = Properties.Resources.BridgestonePotenzaS001;
            }
            if (choice == 16)
            {
                label1.Text = "Bridgestone Potenza S001 c1";
                pictureBox3.Image = Properties.Resources.BridgestonePotenzaS001БУ;
            }
            if (choice == 17)
            {
                label1.Text = "Bridgestone Alenza 001 ";
                pictureBox3.Image = Properties.Resources.BridgestoneAlenza001;
            }
            if (choice == 18)
            {
                label1.Text = "Bridgestone Alenza 002";
                pictureBox3.Image = Properties.Resources.BridgestoneAlenza001БУ;
            }
            if (choice == 19)
            {
                label1.Text = "Bridgestone Blizzak SPIKE-02 ";
                pictureBox3.Image = Properties.Resources.BridgestoneBlizzakSPIKE02;
            }
            if (choice == 20)
            {
                label1.Text = "Bridgestone Blizzak SPIKE-02-01";
                pictureBox3.Image = Properties.Resources.BridgestoneBlizzakSPIKE02БУ;
            }
            if (choice == 21)
            {
                label1.Text = "Bridgestone Blizzak DM-V3 ";
                pictureBox3.Image = Properties.Resources.BridgestoneBlizzakDMV3;
            }
            if (choice == 22)
            {
                label1.Text = "Bridgestone Blizzak DM-V34";
                pictureBox3.Image = Properties.Resources.BridgestoneBlizzakDMV3БУ;
            }
            if (choice == 23)
            {
                label1.Text = "Bridgestone Blizzak RFT ";
                pictureBox3.Image = Properties.Resources.BridgestoneBlizzakRFT;
            }
            if (choice == 24)
            {
                label1.Text = "Bridgestone Blizzak RFT 12 ";
                pictureBox3.Image = Properties.Resources.BridgestoneBlizzakRFTБУ;
            }
            if (choice == 25)
            {
                label1.Text = "Nokian Rotiiva AT ";
                pictureBox3.Image = Properties.Resources.NokianRotiivaAT;
            }
            if (choice == 26)
            {
                label1.Text = "Nokian Rotiiva AT PRO ";
                pictureBox3.Image = Properties.Resources.NokianRotiivaATБУ;
            }
            if (choice == 27)
            {
                label1.Text = "Nokian Hakka Black 2 ";
                pictureBox3.Image = Properties.Resources.NokianHakkaBlack2;
            }
            if (choice == 28)
            {
                label1.Text = "Nokian Hakka Black 2 Stels";
                pictureBox3.Image = Properties.Resources.NokianHakkaBlack2БУ;
            }
            if (choice == 29)
            {
                label1.Text = "Nokian Outpost AT ";
                pictureBox3.Image = Properties.Resources.NokianOutpostAT;
            }
            if (choice == 30)
            {
                label1.Text = "Nokian Outpost ATMS ";
                pictureBox3.Image = Properties.Resources.NokianOutpostATБУ;
            }
            if (choice == 31)
            {
                label1.Text = "Nokian Hakkapeliitta 10p ";
                pictureBox3.Image = Properties.Resources.NokianHakkapeliitta10p;
            }
            if (choice == 32)
            {
                label1.Text = "Nokian Hakkapeliitta 10p pro ";
                pictureBox3.Image = Properties.Resources.NokianHakkapeliitta10pБУ;
            }
            if (choice == 33)
            {
                label1.Text = "Nokian Hakkapeliitta R3";
                pictureBox3.Image = Properties.Resources.NokianHakkapeliittaR3;
            }
            if (choice == 34)
            {
                label1.Text = "Nokian Hakkapeliitta R3-21";
                pictureBox3.Image = Properties.Resources.NokianHakkapeliittaR3БУ;
            }
            if (choice == 35)
            {
                label1.Text = "Nokian WR A4";
                pictureBox3.Image = Properties.Resources.NokianWRA4;
            }
            if (choice == 36)
            {
                label1.Text = "Nokian WR A4 Sport";
                pictureBox3.Image = Properties.Resources.NokianWRA4БУ;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm;
            newForm = new Вопросы();
            newForm.Show();
        }

        private void Ответы_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
