using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace laba34IZ
{
    public partial class Вопросы : Form
    {
        static int guitar;
        static int i;
        int[] arrayGuitar = new int[4];
        string result;

        public Вопросы()
        {
            InitializeComponent();
            label1.Text = "Каким видом активности вы занимаетесь?";
        }

        private void button1_Click(object sender, EventArgs e) //1 вариант
        {
            if (label1.Text == "Ваша машина легковая или полноприводная?")
            {
                i = 3;
                arrayGuitar[i] = 1;
                outputGuitar();
            }
            if (label1.Text == "Какие диски вы ставите на свою машину?")
            {
                i = 2;
                arrayGuitar[i] = 1;
                label1.Text = "Ваша машина легковая или полноприводная?";
                button1.Text = "легковая";
                button2.Text = "полноприводная";
                button3.Visible = false;
            }
            if (label1.Text == "Какой сезон?")
            {
                i = 1;
                arrayGuitar[i] = 1;
                label1.Text = "Какие диски вы ставите на свою машину?";
                button1.Text = "кованные";
                button2.Text = "штампы";
                button3.Visible = true;
                button3.Text = "литые";
            }
            if (label1.Text == "Каким видом активности вы занимаетесь?")
            {
                i = 0;
                arrayGuitar[i] = 1;
                label1.Text = "Какой сезон?";
                button1.Text = "Лето";
                button2.Text = "Зима";
                button3.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e) //2 вариант
        {
            if (label1.Text == "Ваша машина легковая или полноприводная?")
            {
                i = 3;
                arrayGuitar[i] = 2;
                outputGuitar();
            }
            if (label1.Text == "Какие диски вы ставите на свою машину?")
            {
                i = 2;
                arrayGuitar[i] = 3;
                label1.Text = "Ваша машина легковая или полноприводная?";
                button1.Text = "легковая";
                button2.Text = "полноприводная";
                button3.Visible = false;
            }
            if (label1.Text == "Какой сезон?")
            {
                i = 1;
                arrayGuitar[i] = 2;
                label1.Text = "Какие диски вы ставите на свою машину?";
                button1.Text = "кованные";
                button2.Text = "штампы";
                button3.Visible = true;
                button3.Text = "литые";
            }
            if (label1.Text == "Каким видом активности вы занимаетесь?")
            {
                i = 0;
                arrayGuitar[i] = 3;
                label1.Text = "Какой сезон?";
                button1.Text = "Лето";
                button2.Text = "Зима";
                button3.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e) //3 вариант
        {

            if (label1.Text == "Какие диски вы ставите на свою машину?")
            {
                i = 2;
                arrayGuitar[i] = 3;
                label1.Text = "Ваша машина легковая или полноприводная?";
                button1.Text = "легковая";
                button2.Text = "полноприводная";
                button3.Visible = false;
            }
            if (label1.Text == "Каким видом активности вы занимаетесь?")
            {
                i = 0;
                arrayGuitar[i] = 2;
                label1.Text = "Какой сезон?";
                button1.Text = "Лето";
                button2.Text = "Зима";
                button3.Visible = false;
            }
        }
        public void outputGuitar()
        {
            string result = string.Join("", arrayGuitar);
            if (result == "1111")
            {
                guitar = 1; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "1112")
            {
                guitar = 2; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "1121")
            {
                guitar = 3; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "1122")
            {
                guitar = 4; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "1131")
            {
                guitar = 5; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "1132")
            {
                guitar = 6; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "1211")
            {
                guitar = 7; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "1212")
            {
                guitar = 8; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "1221")
            {
                guitar = 9; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "1222")
            {
                guitar = 10; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "1231")
            {
                guitar = 11; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "1232")
            {
                guitar = 12; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "2111")
            {
                guitar = 13; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "2112")
            {
                guitar = 14; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "2121")
            {
                guitar = 15; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "2122")
            {
                guitar = 16; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "2131")
            {
                guitar = 17; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "2132")
            {
                guitar = 18; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "2211")
            {
                guitar = 19; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "2212")
            {
                guitar = 20; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "2221")
            {
                guitar = 21; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "2222")
            {
                guitar = 22; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "2231")
            {
                guitar = 23; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "2232")
            {
                guitar = 24; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "3111")
            {
                guitar = 25; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "3112")
            {
                guitar = 26; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "3121")
            {
                guitar = 27; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "3122")
            {
                guitar = 28; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "3131")
            {
                guitar = 29; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "3132")
            {
                guitar = 30; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "3211")
            {
                guitar = 31; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "3212")
            {
                guitar = 32; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "3221")
            {
                guitar = 33; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "3222")
            {
                guitar = 34; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "3231")
            {
                guitar = 35; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
            if (result == "3232")
            {
                guitar = 36; //
                this.Close();
                Form newForm;
                newForm = new Ответы(guitar);
                newForm.Show();
            }
        }
    }
}
