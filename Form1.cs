namespace SiembraTerreno
{
    public partial class Form1 : Form
    {
        
        public PictureBox Semilla = new PictureBox();
        public bool [] Fertilizada1 = {false, false, false, false, false, false };
        public bool[] Fertilizada2 = { false, false, false, false, false, false };
        public bool[] Fertilizada3 = { false, false, false, false, false, false };
        public bool[] Fertilizada4 = { false, false, false, false, false, false };
        PictureBox[] Siembra1 = new PictureBox[6];
        PictureBox[] Siembra2 = new PictureBox[6];
        PictureBox[] Siembra3 = new PictureBox[6];
        PictureBox[] Siembra4 = new PictureBox[6];

        Random rnd = new Random();
        int Check = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        


        public void AgregarGrupoI()
        {
            for (int i = 0; i < Siembra1.Length; i++)
            {
                Siembra1[i] = NuevaSemilla();
            }

            Siembra1[0].Location = new System.Drawing.Point(316, 28);
            Siembra1[1].Location = new System.Drawing.Point(416, 28);
            Siembra1[2].Location = new System.Drawing.Point(316, 128);
            Siembra1[3].Location = new System.Drawing.Point(416, 128);
            Siembra1[4].Location = new System.Drawing.Point(316, 228);
            Siembra1[5].Location = new System.Drawing.Point(416, 228);

        }

        public void AgregarGrupoII()
        {
            for (int i = 0; i < Siembra2.Length; i++)
            {
                Siembra2[i] = NuevaSemilla();
            }

            Siembra2[0].Location = new System.Drawing.Point(616, 28);
            Siembra2[1].Location = new System.Drawing.Point(716, 28);
            Siembra2[2].Location = new System.Drawing.Point(616, 128);
            Siembra2[3].Location = new System.Drawing.Point(716, 128);
            Siembra2[4].Location = new System.Drawing.Point(616, 228);
            Siembra2[5].Location = new System.Drawing.Point(716, 228);

        }

        public void AgregarGrupoIII()
        {
            for (int i = 0; i < Siembra3.Length; i++)
            {
                Siembra3[i] = NuevaSemilla();
            }

            Siembra3[0].Location = new System.Drawing.Point(916, 28);
            Siembra3[1].Location = new System.Drawing.Point(1016, 28);
            Siembra3[2].Location = new System.Drawing.Point(916, 128);
            Siembra3[3].Location = new System.Drawing.Point(1016, 128);
            Siembra3[4].Location = new System.Drawing.Point(916, 228);
            Siembra3[5].Location = new System.Drawing.Point(1016, 228);

        }

        public void AgregarGrupoIV()
        {
            for (int i = 0; i < Siembra4.Length; i++)
            {
                Siembra4[i] = NuevaSemilla();
            }

            Siembra4[0].Location = new System.Drawing.Point(1216, 28);
            Siembra4[1].Location = new System.Drawing.Point(1316, 28);
            Siembra4[2].Location = new System.Drawing.Point(1216, 128);
            Siembra4[3].Location = new System.Drawing.Point(1316, 128);
            Siembra4[4].Location = new System.Drawing.Point(1216, 228);
            Siembra4[5].Location = new System.Drawing.Point(1316, 228);

        }

        public PictureBox NuevaSemilla()
        {
            var imgPictureBox = new PictureBox();
            imgPictureBox.Location = new System.Drawing.Point(316, 28);
            imgPictureBox.Size = new System.Drawing.Size(54, 54);
            imgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPictureBox.Image = Image.FromFile(@"C:\Punto.png");
            Controls.Add(imgPictureBox);
            imgPictureBox.Visible = true;

            return imgPictureBox;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + 4;

            if (pictureBox1.Location.X == 316 & pictureBox1.Location.Y == 375)
            {
                AgregarGrupoI();
            }

            if (pictureBox1.Location.X == 616 & pictureBox1.Location.Y == 375)
            {
                AgregarGrupoII();
            }

            if (pictureBox1.Location.X == 916 & pictureBox1.Location.Y == 375)
            {
                AgregarGrupoIII();
            }

            if (pictureBox1.Location.X == 1216 & pictureBox1.Location.Y == 375)
            {
                AgregarGrupoIV();
            }

            if (pictureBox1.Location.X > 1300)
            {
                RegarSiembra();
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        
        public void SiembraJodona()
        {
            for (int i = 0; i < Siembra1.Length; i++)
            {
                Check = rnd.Next(0,2);
                if (Check == 1)
                {
                    Siembra1[i].Image = Image.FromFile(@"C:\PuntoMarron.png");
                    Fertilizada1[i] = true;
                    
                }
            }

            for (int i = 0; i < Siembra2.Length; i++)
            {
                Check = rnd.Next(0, 2);
                if (Check == 1)
                {
                    Siembra2[i].Image = Image.FromFile(@"C:\PuntoMarron.png");
                    Fertilizada2[i] = true;
                   
                }
            }

            for (int i = 0; i < Siembra3.Length; i++)
            {
                Check = rnd.Next(0, 2);
                if (Check == 1)
                {
                    Siembra3[i].Image = Image.FromFile(@"C:\PuntoMarron.png");
                    Fertilizada3[i] = true;
                    
                }

            }

            for (int i = 0; i < Siembra4.Length; i++)
            {
                Check = rnd.Next(0, 2);
                if (Check == 1)
                {
                    Siembra4[i].Image = Image.FromFile(@"C:\PuntoMarron.png");
                    Fertilizada4[i] = true;
                    
                }
            }

        }

        public void RegarSiembra()
        {
            pictureBox1.Image = Image.FromFile(@"C:\CamionAgua.png");
            pictureBox1.Location = new Point(12,375);
            
        }

        public void RegarFertilizante()
        {
            pictureBox1.Image = Image.FromFile(@"C:\CamionFertilizante.png");
            pictureBox1.Location = new Point(12, 375);

        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + 4;

            if (pictureBox1.Location.X >= 1300)
            {
                SiembraJodona();
                timer2.Enabled = false;
                RegarFertilizante();
                timer3.Enabled = true;

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            pictureBox1.Left = pictureBox1.Left + 4;

            if (pictureBox1.Location.X == 316 & pictureBox1.Location.Y == 375)
            {
                for (int i = 0; i < Fertilizada1.Length; i++)
                {
                    if (Fertilizada1[i] == true)
                    {
                        Siembra1[i].Image = Image.FromFile(@"C:\PuntoAzul.png");
                    }
                }
            }

            if (pictureBox1.Location.X == 616 & pictureBox1.Location.Y == 375)
            {
                for (int i = 0; i < Fertilizada2.Length; i++)
                {
                    if (Fertilizada2[i] == true)
                    {
                        Siembra2[i].Image = Image.FromFile(@"C:\PuntoAzul.png");
                    }
                }
            }

            if (pictureBox1.Location.X == 916 & pictureBox1.Location.Y == 375)
            {
                for (int i = 0; i < Fertilizada3.Length; i++)
                {
                    if (Fertilizada3[i] == true)
                    {
                        Siembra3[i].Image = Image.FromFile(@"C:\PuntoAzul.png");
                    }
                }
            }

            if (pictureBox1.Location.X == 1216 & pictureBox1.Location.Y == 375)
            {
                for (int i = 0; i < Fertilizada4.Length; i++)
                {
                    if (Fertilizada4[i] == true)
                    {
                        Siembra4[i].Image = Image.FromFile(@"C:\PuntoAzul.png");
                    }
                }
            }

            if (pictureBox1.Location.X > 1300)
            {
                
                timer3.Enabled = false;
                Descosechar();
            }
            
        }

        public void Descosechar()
        {
            for (int i = 0; i < Fertilizada1.Length; i++)
            {
                if (Fertilizada1[i] == false)
                {
                    Siembra1[i].Image = Image.FromFile(@"C:\PuntoVerde.png");
                }
               
                if (Fertilizada1[i] == true)
                {
                    Check = rnd.Next(0, 2);
                    if (Check == 1)
                    {
                        Siembra1[i].Image = Image.FromFile(@"C:\PuntoMarron.png");
                    }
                    else
                    {
                        Siembra1[i].Image = Image.FromFile(@"C:\PuntoVerde.png");
                    }
                }

                

            }

            for (int i = 0; i < Fertilizada2.Length; i++)
            {
                if (Fertilizada2[i] == false)
                {
                    Siembra2[i].Image = Image.FromFile(@"C:\PuntoVerde.png");
                }

                if (Fertilizada2[i] == true)
                {
                    Check = rnd.Next(0, 2);
                    if (Check == 1)
                    {
                        Siembra2[i].Image = Image.FromFile(@"C:\PuntoMarron.png");
                    }
                    else
                    {
                        Siembra2[i].Image = Image.FromFile(@"C:\PuntoVerde.png");
                    }
                }

            }


            for (int i = 0; i < Fertilizada3.Length; i++)
            {
                if (Fertilizada3[i] == false)
                {
                    Siembra3[i].Image = Image.FromFile(@"C:\PuntoVerde.png");
                }

                if (Fertilizada3[i] == true)
                {
                    Check = rnd.Next(0, 2);
                    if (Check == 1)
                    {
                        Siembra3[i].Image = Image.FromFile(@"C:\PuntoMarron.png");
                    }
                    else
                    {
                        Siembra3[i].Image = Image.FromFile(@"C:\PuntoVerde.png");
                    }
                }
            }

            for (int i = 0; i < Fertilizada4.Length; i++)
            {
                if (Fertilizada4[i] == false)
                {
                    Siembra4[i].Image = Image.FromFile(@"C:\PuntoVerde.png");
                }

                if (Fertilizada4[i] == true)
                {
                    Check = rnd.Next(0, 2);
                    if (Check == 1)
                    {
                        Siembra4[i].Image = Image.FromFile(@"C:\PuntoMarron.png");
                    }
                    else
                    {
                        Siembra4[i].Image = Image.FromFile(@"C:\PuntoVerde.png");
                    }
                }
            }
        }
    }
}