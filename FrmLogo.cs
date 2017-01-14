using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AGaugeApp
{
  
    
    public partial class FrmLogo : Form
    {
        public FrmLogo()
        {
            InitializeComponent();


       
          


        }

        private void TmrLogo_Tick(object sender, EventArgs e)
        {




            if ((prgsLogo.Value + 2) < 100)
            {

                prgsLogo.Value = prgsLogo.Value + 2;
            }
            else
            {
                
                
                prgsLogo.Value = 100;
                TmrLogo.Enabled = false;

                this.Hide();

                FrmMain FrmMain = new FrmMain();
                FrmMain.ShowDialog();




            }






        }

        public int glb_version_number = 0;

        private void check_version()
        {




            string flname = "";
            string readline = "";

            flname = Application.StartupPath + "\\cfg.conf";
            System.IO.StreamReader Filereader = new System.IO.StreamReader(flname);


            //  readline = (Filereader.ReadLine());


            string tmp_version = "";



            while ((readline = Filereader.ReadLine()) != null)
            {



                if (readline.IndexOf("#") != -1)
                {


                    continue;


                }



                if (readline == "")
                {


                    continue;


                }


                tmp_version = readline.ToString();





            }


            glb_version_number = int.Parse(tmp_version.ToString());
            Filereader.Close();



        }





        private void FrmLogo_Load(object sender, EventArgs e)
        {

            check_version();

            if (glb_version_number == 2)//for airport
            {

                ///
                string path = Application.StartupPath +"\\Screen\\Logo.bmp";
                Image myimage = new Bitmap(@path);
                this.BackgroundImage = myimage;
                ///

            }
            
            TmrLogo.Enabled = true;


        }

        private void FrmLogo_Click(object sender, EventArgs e)
        {







            this.Hide();
            TmrLogo.Enabled = false;
            FrmMain FrmMain = new FrmMain();
            FrmMain.ShowDialog();

           




        }
    }
}
