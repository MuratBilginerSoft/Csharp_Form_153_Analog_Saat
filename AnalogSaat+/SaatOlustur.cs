using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnalogSaat_
{
    class SaatOlustur
    {
        private int birakilacakBosluk = 20;

        public int boslukBirak
        {
            get
            {
                return birakilacakBosluk;
            }
            set
            {
                birakilacakBosluk = value;
            }
        }
        
        public void Saat(int saat, Form nesne)
        {
            Graphics grafik =  nesne.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 6);

            float r = nesne.ClientSize.Width / 2;
            if (nesne.ClientSize.Width > nesne.ClientSize.Height)
            {
                float formunRYuksekligi = nesne.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }
            float xOrta = nesne.ClientSize.Width / 2;
            float yOrta = nesne.ClientSize.Height / 2;
            float aci = -saat * 30 + 90;

            r -= (float)(r * 0.40);//kenarlardan birakilacak bosluk

            float noktaX = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));
            float noktaY = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

            grafik.DrawLine(kalem, xOrta, yOrta, noktaX, noktaY);
        }

        public void Saat(int saat, Panel nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 6);

            float r = nesne.ClientSize.Width / 2;
            if (nesne.ClientSize.Width > nesne.ClientSize.Height)
            {
                float formunRYuksekligi = nesne.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }
            float xOrta = nesne.ClientSize.Width / 2;
            float yOrta = nesne.ClientSize.Height / 2;
            float aci = -saat * 30 + 90;

            r -= (float)(r * 0.40);//kenarlardan birakilacak bosluk

            float noktaX = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));
            float noktaY = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

            grafik.DrawLine(kalem, xOrta, yOrta, noktaX, noktaY);
        }

        public void Saat(int saat, GroupBox nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            Pen kalem = new Pen(Color.Black, 6);

            float r = nesne.ClientSize.Width / 2;
            if (nesne.ClientSize.Width > nesne.ClientSize.Height)
            {
                float formunRYuksekligi = nesne.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }
            float xOrta = nesne.ClientSize.Width / 2;
            float yOrta = nesne.ClientSize.Height / 2;
            float aci = -saat * 30 + 90;

            r -= (float)(r * 0.40);//kenarlardan birakilacak bosluk

            float noktaX = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));
            float noktaY = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

            grafik.DrawLine(kalem, xOrta, yOrta, noktaX, noktaY);
        }

        public void Dakika(int dakika, Form nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            Pen kalem = new Pen(Color.Blue, 5);

            float r = nesne.ClientSize.Width / 2;
            if (nesne.ClientSize.Width > nesne.ClientSize.Height)
            {
                float formunRYuksekligi = nesne.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }
            float xOrta = nesne.ClientSize.Width / 2;
            float yOrta = nesne.ClientSize.Height / 2;
            float aci = -dakika * 6 + 90;

            r -= (float)(r * 0.25);//kenarlardan birakilacak bosluk

            float noktaX = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));
            float noktaY = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

            grafik.DrawLine(kalem, xOrta, yOrta, noktaX, noktaY);
        }

        public void Dakika(int dakika, Panel nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            Pen kalem = new Pen(Color.Blue, 5);

            float r = nesne.ClientSize.Width / 2;
            if (nesne.ClientSize.Width > nesne.ClientSize.Height)
            {
                float formunRYuksekligi = nesne.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }
            float xOrta = nesne.ClientSize.Width / 2;
            float yOrta = nesne.ClientSize.Height / 2;
            float aci = -dakika * 6 + 90;

            r -= (float)(r * 0.25);//kenarlardan birakilacak bosluk

            float noktaX = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));
            float noktaY = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

            grafik.DrawLine(kalem, xOrta, yOrta, noktaX, noktaY);
        }

        public void Dakika(int dakika, GroupBox nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            Pen kalem = new Pen(Color.Blue, 5);

            float r = nesne.ClientSize.Width / 2;
            if (nesne.ClientSize.Width > nesne.ClientSize.Height)
            {
                float formunRYuksekligi = nesne.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }
            float xOrta = nesne.ClientSize.Width / 2;
            float yOrta = nesne.ClientSize.Height / 2;
            float aci = -dakika * 6 + 90;

            r -= (float)(r * 0.25);//kenarlardan birakilacak bosluk

            float noktaX = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));
            float noktaY = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

            grafik.DrawLine(kalem, xOrta, yOrta, noktaX, noktaY);
        }

        public void Saniye(int saniye, Form nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            Pen kalem = new Pen(Color.Red, 4);

            float r = nesne.ClientSize.Width / 2;
            float yOrta = nesne.ClientSize.Height / 2;

            if (nesne.ClientSize.Width > nesne.ClientSize.Height)
            {
                float formunRYuksekligi = nesne.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }

            float xOrta = nesne.ClientSize.Width / 2;
            float aci = -saniye * 6 + 90;

            r -= (float)(r * 0.10);//kenarlardan birakilacak bosluk

            float noktaX = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));
            float noktaY = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

            grafik.DrawLine(kalem, xOrta, yOrta, noktaX, noktaY);
        }

        public void Saniye(int saniye, Panel nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            Pen kalem = new Pen(Color.Red, 4);

            float r = nesne.ClientSize.Width / 2;
            float yOrta = nesne.ClientSize.Height / 2;

            if (nesne.ClientSize.Width > nesne.ClientSize.Height)
            {
                float formunRYuksekligi = nesne.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }

            float xOrta = nesne.ClientSize.Width / 2;
            float aci = -saniye * 6 + 90;

            r -= (float)(r * 0.10);//kenarlardan birakilacak bosluk

            float noktaX = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));
            float noktaY = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

            grafik.DrawLine(kalem, xOrta, yOrta, noktaX, noktaY);
        }

        public void Saniye(int saniye, GroupBox nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            Pen kalem = new Pen(Color.Red, 4);

            float r = nesne.ClientSize.Width / 2;
            float yOrta = nesne.ClientSize.Height / 2;

            if (nesne.ClientSize.Width > nesne.ClientSize.Height)
            {
                float formunRYuksekligi = nesne.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }

            float xOrta = nesne.ClientSize.Width / 2;
            float aci = -saniye * 6 + 90;

            r -= (float)(r * 0.10);//kenarlardan birakilacak bosluk

            float noktaX = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));
            float noktaY = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

            grafik.DrawLine(kalem, xOrta, yOrta, noktaX, noktaY);
        }

        public void Cerceve(Form nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            int kalemDefaultBoy = 4;
            Pen kalem = new Pen(Color.Black, kalemDefaultBoy);

            float r = nesne.ClientSize.Width / 2;
            float alinacakDeger = 0;
            float alinacakDegerX = 0;
            float alinacakDegerY = 0;

            if (nesne.ClientSize.Height < nesne.ClientSize.Width)
            {
                alinacakDeger = nesne.ClientSize.Height;
                alinacakDegerY = 0;
                alinacakDegerX = (nesne.ClientSize.Width - nesne.ClientSize.Height) / 2;
            }
            else
            {
                alinacakDeger = nesne.ClientSize.Width;
                alinacakDegerX = 0;
                alinacakDegerY = (nesne.ClientSize.Height - nesne.ClientSize.Width) / 2;
            }

            grafik.DrawEllipse(kalem, alinacakDegerX, alinacakDegerY, alinacakDeger, alinacakDeger);

            float kx1, kx2, ky1, ky2;
            float xOrta = nesne.ClientSize.Width / 2, yOrta = nesne.ClientSize.Height / 2;

            if (nesne.ClientSize.Width > nesne.ClientSize.Height)
            {
                float formunRYuksekligi = nesne.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }

            r -= birakilacakBosluk;

            for (int aci = 0; aci <= 360; aci += 6)
            {
                kx1 = (float)(xOrta + (r + 10) * Math.Cos(aci * Math.PI / 180));//10 çizgi uzunluğunu temsil ediyor.
                kx2 = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));

                ky1 = (float)(yOrta - (r + 10) * Math.Sin(aci * Math.PI / 180));//10 çizginin eğimini temsil ediyor.
                ky2 = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

                if (aci % 90 == 0)//çeyrek, yarım veya tam'a eşit ise
                {
                    kalem.Width = kalemDefaultBoy + 4;
                    grafik.DrawLine(kalem, kx1, ky1, kx2, ky2);
                }
                else if (aci % 30 == 0)//her saat başı
                {
                    kalem.Width = kalemDefaultBoy;
                    grafik.DrawLine(kalem, kx1, ky1, kx2, ky2);
                }
                else//her dakika
                {
                    kalem.Width = kalemDefaultBoy - 2;
                    grafik.DrawLine(kalem, kx1, ky1, kx2, ky2);
                }
            }
        }

        public void Cerceve(Panel nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            int kalemDefaultBoy = 4;
            Pen kalem = new Pen(Color.Black, kalemDefaultBoy);

            float r = nesne.ClientSize.Width / 2;
            float alinacakDeger = 0;
            float alinacakDegerX = 0;
            float alinacakDegerY = 0;

            if (nesne.ClientSize.Height < nesne.ClientSize.Width)
            {
                alinacakDeger = nesne.ClientSize.Height;
                alinacakDegerY = 0;
                alinacakDegerX = (nesne.ClientSize.Width - nesne.ClientSize.Height) / 2;
            }
            else
            {
                alinacakDeger = nesne.ClientSize.Width;
                alinacakDegerX = 0;
                alinacakDegerY = (nesne.ClientSize.Height - nesne.ClientSize.Width) / 2;
            }

            grafik.DrawEllipse(kalem, alinacakDegerX, alinacakDegerY, alinacakDeger, alinacakDeger);

            float kx1, kx2, ky1, ky2;
            float xOrta = nesne.ClientSize.Width / 2, yOrta = nesne.ClientSize.Height / 2;

            if (nesne.ClientSize.Width > nesne.ClientSize.Height)
            {
                float formunRYuksekligi = nesne.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }

            r -= birakilacakBosluk;

            for (int aci = 0; aci <= 360; aci += 6)
            {
                kx1 = (float)(xOrta + (r + 10) * Math.Cos(aci * Math.PI / 180));//10 çizgi uzunluğunu temsil ediyor.
                kx2 = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));

                ky1 = (float)(yOrta - (r + 10) * Math.Sin(aci * Math.PI / 180));//10 çizginin eğimini temsil ediyor.
                ky2 = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

                if (aci % 90 == 0)//çeyrek, yarım veya tam'a eşit ise
                {
                    kalem.Width = kalemDefaultBoy + 4;
                    grafik.DrawLine(kalem, kx1, ky1, kx2, ky2);
                }
                else if (aci % 30 == 0)//her saat başı
                {
                    kalem.Width = kalemDefaultBoy;
                    grafik.DrawLine(kalem, kx1, ky1, kx2, ky2);
                }
                else//her dakika
                {
                    kalem.Width = kalemDefaultBoy - 2;
                    grafik.DrawLine(kalem, kx1, ky1, kx2, ky2);
                }
            }
        }

        public void Cerceve(GroupBox nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            int kalemDefaultBoy = 4;
            Pen kalem = new Pen(Color.Black, kalemDefaultBoy);

            float r = nesne.ClientSize.Width / 2;
            float alinacakDeger = 0;
            float alinacakDegerX = 0;
            float alinacakDegerY = 0;

            if (nesne.ClientSize.Height < nesne.ClientSize.Width)
            {
                alinacakDeger = nesne.ClientSize.Height;
                alinacakDegerY = 0;
                alinacakDegerX = (nesne.ClientSize.Width - nesne.ClientSize.Height) / 2;
            }
            else
            {
                alinacakDeger = nesne.ClientSize.Width;
                alinacakDegerX = 0;
                alinacakDegerY = (nesne.ClientSize.Height - nesne.ClientSize.Width) / 2;
            }

            grafik.DrawEllipse(kalem, alinacakDegerX, alinacakDegerY, alinacakDeger, alinacakDeger);

            float kx1, kx2, ky1, ky2;
            float xOrta = nesne.ClientSize.Width / 2, yOrta = nesne.ClientSize.Height / 2;

            if (nesne.ClientSize.Width > nesne.ClientSize.Height)
            {
                float formunRYuksekligi = nesne.ClientSize.Height / 2;
                r = formunRYuksekligi;
            }

            r -= birakilacakBosluk;

            for (int aci = 0; aci <= 360; aci += 6)
            {
                kx1 = (float)(xOrta + (r + 10) * Math.Cos(aci * Math.PI / 180));//10 çizgi uzunluğunu temsil ediyor.
                kx2 = (float)(xOrta + r * Math.Cos(aci * Math.PI / 180));

                ky1 = (float)(yOrta - (r + 10) * Math.Sin(aci * Math.PI / 180));//10 çizginin eğimini temsil ediyor.
                ky2 = (float)(yOrta - r * Math.Sin(aci * Math.PI / 180));

                if (aci % 90 == 0)//çeyrek, yarım veya tam'a eşit ise
                {
                    kalem.Width = kalemDefaultBoy + 4;
                    grafik.DrawLine(kalem, kx1, ky1, kx2, ky2);
                }
                else if (aci % 30 == 0)//her saat başı
                {
                    kalem.Width = kalemDefaultBoy;
                    grafik.DrawLine(kalem, kx1, ky1, kx2, ky2);
                }
                else//her dakika
                {
                    kalem.Width = kalemDefaultBoy - 2;
                    grafik.DrawLine(kalem, kx1, ky1, kx2, ky2);
                }
            }
        }

        public void Sus(Form nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            SolidBrush firca = new SolidBrush(Color.FromArgb(229, 213, 121));

            float r = nesne.ClientSize.Width / 2;
            float alinacakDeger = 0;
            float alinacakDegerX = 0;
            float alinacakDegerY = 0;

            if (nesne.ClientSize.Height < nesne.ClientSize.Width)
            {
                alinacakDeger = 10;
                alinacakDegerY = (nesne.ClientSize.Height / 2) - 5;
                alinacakDegerX = (nesne.ClientSize.Width / 2) - 5;
            }
            else
            {
                alinacakDeger = 10;
                alinacakDegerX = (nesne.ClientSize.Width / 2) - 5;
                alinacakDegerY = (nesne.ClientSize.Height / 2);
            }

            grafik.FillEllipse(firca, alinacakDegerX, alinacakDegerY, alinacakDeger, alinacakDeger);
        }

        public void Sus(Panel nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            SolidBrush firca = new SolidBrush(Color.FromArgb(229, 213, 121));

            float r = nesne.ClientSize.Width / 2;
            float alinacakDeger = 0;
            float alinacakDegerX = 0;
            float alinacakDegerY = 0;

            if (nesne.ClientSize.Height < nesne.ClientSize.Width)
            {
                alinacakDeger = 10;
                alinacakDegerY = (nesne.ClientSize.Height / 2) - 5;
                alinacakDegerX = (nesne.ClientSize.Width / 2) - 5;
            }
            else
            {
                alinacakDeger = 10;
                alinacakDegerX = (nesne.ClientSize.Width / 2) - 5;
                alinacakDegerY = (nesne.ClientSize.Height / 2);
            }

            grafik.FillEllipse(firca, alinacakDegerX, alinacakDegerY, alinacakDeger, alinacakDeger);
        }

        public void Sus(GroupBox nesne)
        {
            Graphics grafik = nesne.CreateGraphics();
            SolidBrush firca = new SolidBrush(Color.FromArgb(229, 213, 121));

            float r = nesne.ClientSize.Width / 2;
            float alinacakDeger = 0;
            float alinacakDegerX = 0;
            float alinacakDegerY = 0;

            if (nesne.ClientSize.Height < nesne.ClientSize.Width)
            {
                alinacakDeger = 10;
                alinacakDegerY = (nesne.ClientSize.Height / 2) - 5;
                alinacakDegerX = (nesne.ClientSize.Width / 2) - 5;
            }
            else
            {
                alinacakDeger = 10;
                alinacakDegerX = (nesne.ClientSize.Width / 2) - 5;
                alinacakDegerY = (nesne.ClientSize.Height / 2);
            }

            grafik.FillEllipse(firca, alinacakDegerX, alinacakDegerY, alinacakDeger, alinacakDeger);
        }

    }
}
