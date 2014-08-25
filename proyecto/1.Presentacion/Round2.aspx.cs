using _2.Logica;
using _4.Modulo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1.Presentacion
{
    public partial class Round2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WCL obj = new WCL();
            WC Country = new WC();
            List<WC> countries  = obj.DataRound2();

            lbl1.Text =  countries[0].country.ToString();
            lbl2.Text = countries[1].country.ToString();
            lbl3.Text = countries[2].country.ToString();
            lbl4.Text = countries[3].country.ToString();
            lbl5.Text = countries[4].country.ToString();
            lbl6.Text = countries[5].country.ToString();
            lbl7.Text = countries[6].country.ToString();
            lbl8.Text = countries[7].country.ToString();


            lbl9.Text = countries[8].country.ToString();
            lbl10.Text = countries[9].country.ToString();
            lbl11.Text = countries[10].country.ToString();
            lbl12.Text = countries[11].country.ToString();
            lbl13.Text = countries[12].country.ToString();
            lbl14.Text = countries[13].country.ToString();
            lbl15.Text = countries[14].country.ToString();
            lbl16.Text = countries[15].country.ToString();
        }

        private void round2a()
        {
            Random random = new Random();
            WCL obj = new WCL();
            WC Country = new WC();
            List<WC> countries = obj.DataRound2();
            string name = "";
            int re = 0;
            int i = 0;
        

            /// match 1
            /// 

            if (Convert.ToInt32(countries[0].ranking) < Convert.ToInt32(countries[1].ranking))
            {
                i = Convert.ToInt32(countries[1].ranking);
            }
            else if (Convert.ToInt32(countries[0].ranking) > Convert.ToInt32(countries[1].ranking))
            {
                i = Convert.ToInt32(countries[0].ranking);
            }
            while (re == 0)
            {
                int randomNumber = random.Next(0, i + 1);

                if (Convert.ToInt32(countries[0].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[0].ranking);
                    name = countries[0].country.ToString();
                    lbll1.Text = countries[1].country;
                }
                else if (Convert.ToInt32(countries[1].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[1].ranking);
                    name = countries[1].country.ToString();
                    lbll1.Text = countries[0].country;
                }
                lblw1.Text = name;
             

            }
            re = 0;
            ///match2
            ///
            if (Convert.ToInt32(countries[2].ranking) < Convert.ToInt32(countries[3].ranking))
            {
                i = Convert.ToInt32(countries[3].ranking);
            }
            else if (Convert.ToInt32(countries[2].ranking) > Convert.ToInt32(countries[3].ranking))
            {
                i = Convert.ToInt32(countries[2].ranking);
            }
            while (re == 0)
            {
                int randomNumber = random.Next(0, i + 1);

                if (Convert.ToInt32(countries[2].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[2].ranking);
                    name = countries[2].country.ToString();
                    lbll2.Text = countries[3].country;
                }
                else if (Convert.ToInt32(countries[3].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[3].ranking);
                    name = countries[3].country.ToString();
                    lbll2.Text = countries[2].country;
                }
                lblw2.Text = name;


            }

            ///match3
            ///
            re = 0;
            if (Convert.ToInt32(countries[4].ranking) < Convert.ToInt32(countries[5].ranking))
            {
                i = Convert.ToInt32(countries[5].ranking);
            }
            else if (Convert.ToInt32(countries[4].ranking) > Convert.ToInt32(countries[5].ranking))
            {
                i = Convert.ToInt32(countries[4].ranking);
            }
            while (re == 0)
            {
                int randomNumber = random.Next(0, i + 1);

                if (Convert.ToInt32(countries[4].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[4].ranking);
                    name = countries[4].country.ToString();
                    lbll3.Text = countries[5].country;
                }
                else if (Convert.ToInt32(countries[5].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[5].ranking);
                    name = countries[5].country.ToString();
                    lbll3.Text = countries[4].country;
                }
                lblw3.Text = name;


            }

            re = 0;
            ///match4
            ///
            if (Convert.ToInt32(countries[6].ranking) < Convert.ToInt32(countries[7].ranking))
            {
                i = Convert.ToInt32(countries[7].ranking);
            }
            else if (Convert.ToInt32(countries[6].ranking) > Convert.ToInt32(countries[7].ranking))
            {
                i = Convert.ToInt32(countries[6].ranking);
            }
            while (re == 0)
            {
                int randomNumber = random.Next(0, i + 1);

                if (Convert.ToInt32(countries[6].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[6].ranking);
                    name = countries[6].country.ToString();
                    lbll4.Text = countries[7].country;
                }
                else if (Convert.ToInt32(countries[7].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[7].ranking);
                    name = countries[7].country.ToString();
                    lbll4.Text = countries[6].country;
                }
                lblw4.Text = name;


            }


            /////////

            re = 0;
            if (Convert.ToInt32(countries[8].ranking) < Convert.ToInt32(countries[9].ranking))
            {
                i = Convert.ToInt32(countries[9].ranking);
            }
            else if (Convert.ToInt32(countries[8].ranking) > Convert.ToInt32(countries[9].ranking))
            {
                i = Convert.ToInt32(countries[8].ranking);
            }
            while (re == 0)
            {
                int randomNumber = random.Next(0, i + 1);

                if (Convert.ToInt32(countries[8].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[8].ranking);
                    name = countries[8].country.ToString();
                    lbll5.Text = countries[9].country;
                }
                else if (Convert.ToInt32(countries[9].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[9].ranking);
                    name = countries[9].country.ToString();
                    lbll5.Text = countries[8].country;
                }
                lblw5.Text = name;


            }
            re = 0;
            ///match2
            ///
            if (Convert.ToInt32(countries[10].ranking) < Convert.ToInt32(countries[11].ranking))
            {
                i = Convert.ToInt32(countries[11].ranking);
            }
            else if (Convert.ToInt32(countries[10].ranking) > Convert.ToInt32(countries[11].ranking))
            {
                i = Convert.ToInt32(countries[10].ranking);
            }
            while (re == 0)
            {
                int randomNumber = random.Next(0, i + 1);

                if (Convert.ToInt32(countries[11].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[11].ranking);
                    name = countries[11].country.ToString();
                    lbll6.Text = countries[10].country;
                }
                else if (Convert.ToInt32(countries[10].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[10].ranking);
                    name = countries[10].country.ToString();
                    lbll6.Text = countries[11].country;
                }
                lblw6.Text = name;


            }

            ///match3
            ///
            re = 0;
            if (Convert.ToInt32(countries[12].ranking) < Convert.ToInt32(countries[13].ranking))
            {
                i = Convert.ToInt32(countries[13].ranking);
            }
            else if (Convert.ToInt32(countries[12].ranking) > Convert.ToInt32(countries[13].ranking))
            {
                i = Convert.ToInt32(countries[12].ranking);
            }
            while (re == 0)
            {
                int randomNumber = random.Next(0, i + 1);

                if (Convert.ToInt32(countries[12].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[12].ranking);
                    name = countries[12].country.ToString();
                    lbll7.Text = countries[13].country;
                }
                else if (Convert.ToInt32(countries[13].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[13].ranking);
                    name = countries[13].country.ToString();
                    lbll7.Text = countries[12].country;
                }
                lblw7.Text = name;


            }

            re = 0;
            ///match4
            ///
            if (Convert.ToInt32(countries[14].ranking) < Convert.ToInt32(countries[15].ranking))
            {
                i = Convert.ToInt32(countries[15].ranking);
            }
            else if (Convert.ToInt32(countries[14].ranking) > Convert.ToInt32(countries[15].ranking))
            {
                i = Convert.ToInt32(countries[14].ranking);
            }
            while (re == 0)
            {
                int randomNumber = random.Next(0, i + 1);

                if (Convert.ToInt32(countries[14].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[14].ranking);
                    name = countries[14].country.ToString();
                    lbll8.Text = countries[15].country;
                }
                else if (Convert.ToInt32(countries[15].ranking) == randomNumber)
                {
                    re = Convert.ToInt32(countries[15].ranking);
                    name = countries[15].country.ToString();
                    lbll8.Text = countries[14].country;
                }
                lblw8.Text = name;


            }
        }







     
        protected void Button1_Click(object sender, EventArgs e)
        {
            round2a();
            //round2b();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
           
        }

        protected void AddDataRound2( string country ,int matches, int win, int lost, int ranking, int newranking)
        {

            WC obj = new WC();
            WCL objS = new WCL();
        
            obj.matches = matches;
            obj.win = win;
            obj.lost = lost;
            obj.ranking = ranking;
            obj.newranking = newranking;
            obj.country = country;
            objS.AddDataRound2(obj);
        }
    }
}