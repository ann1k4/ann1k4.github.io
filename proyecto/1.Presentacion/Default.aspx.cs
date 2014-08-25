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
    public partial class Default : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
           
        }
        
        private void CargarPaises()
        {
            
            WC country = new WC();
      
           
          
           for (int i = 0; i <2; i++)
            {
               // country.ranking = paises[0].ranking;
              
               // ListBox1.Items.Add(paises[i].country);
               // TextBox1.Text = paises[0].country;
               // TextBox2.Text = paises[0].ranking;
                //TextBox3.Text = paises[1].country;
                //TextBox4.Text = paises[1].ranking;
           }
           for (int i = 1; i < 2; i++)
           {

              // ListBox2.Items.Add(paises[i].country);
               // TextBox1.Text = paises[0].country;
               // TextBox2.Text = paises[0].ranking;
               //TextBox3.Text = paises[1].country;
               //TextBox4.Text = paises[1].ranking;
           }
        }

          private void round1a()
        {
            Random random = new Random();
            WCL obj = new WCL();
              WC Country = new WC();
            List<WC> paises = obj.Consultar();
              int ran;
              int ran2;
              ran = Convert.ToInt32( paises[0].ranking);
              ran2 = Convert.ToInt32(paises[1].ranking);
              string name="";
              int re=0;
              int re1 = 0;
              int i=0; 
              
              if (ran < ran2)
              {
                  i = ran2;
              }
              else if (ran > ran2)
              {
                  i = ran;
              }
              
             ///1//
              while (re ==0)
              {  
                    int randomNumber = random.Next(0, i + 1);

                      if (ran == randomNumber)
                      {
                          re = ran;
                          name = paises[0].country.ToString();
                          lblLoser1.Text = paises[1].country;
                          
                      }
                      else if (ran2 == randomNumber)
                      {
                          re = ran2;
                          name = paises[1].country.ToString();
                          lblLoser1.Text = paises[0].country;
                          
                      }
                      lblre.Text = re.ToString();
                      lblname.Text = name;
              }

            ///2///
            ///



              if (Convert.ToInt32(paises[2].ranking) < Convert.ToInt32(paises[3].ranking))
              {
                  i = Convert.ToInt32(paises[3].ranking);
              }
              else if (Convert.ToInt32(paises[2].ranking) > Convert.ToInt32(paises[3].ranking))
              {
                  i = Convert.ToInt32(paises[2].ranking);
              }
             while (re1 == 0)
              {
                  int randomNumber = random.Next(0, i + 1);

                  if (Convert.ToInt32(paises[2].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[2].ranking);
                      name = paises[2].country.ToString();
                      lblLoser2.Text = paises[3].country;
                      
                  }
                  else if (Convert.ToInt32(paises[3].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[3].ranking);
                      name = paises[3].country.ToString();
                      lblLoser2.Text = paises[2].country;
                      
                  }
                  lbl1.Text = re1.ToString();
                  lbl2.Text = name;
                 
              }

             re1 = 0;

              //3//

             if (Convert.ToInt32(paises[4].ranking) < Convert.ToInt32(paises[5].ranking))
             {
                 i = Convert.ToInt32(paises[5].ranking);
             }
             else if (Convert.ToInt32(paises[4].ranking) > Convert.ToInt32(paises[5].ranking))
             {
                 i = Convert.ToInt32(paises[4].ranking);
             }
            
             while (re1 == 0)
             {
                 int randomNumber = random.Next(0, i + 1);

                 if (Convert.ToInt32(paises[4].ranking) == randomNumber)
                 {
                     re1 = Convert.ToInt32(paises[4].ranking);
                     name = paises[4].country.ToString();
                     lblLoser3.Text = paises[5].country;
                 }
                 else if (Convert.ToInt32(paises[5].ranking) == randomNumber)
                 {
                     re1 = Convert.ToInt32(paises[5].ranking);
                     name = paises[5].country.ToString();
                     lblLoser3.Text = paises[4].country;
                 }
                 lbl4.Text = re1.ToString();
                 lbl3.Text = name;

             }

             ///4///

             re1 = 0;

             //

             if (Convert.ToInt32(paises[6].ranking) < Convert.ToInt32(paises[7].ranking))
             {
                 i = Convert.ToInt32(paises[7].ranking);
             }
             else if (Convert.ToInt32(paises[6].ranking) > Convert.ToInt32(paises[7].ranking))
             {
                 i = Convert.ToInt32(paises[6].ranking);
             }
             while (re1 == 0)
             {
                 int randomNumber = random.Next(0, i + 1);

                 if (Convert.ToInt32(paises[6].ranking) == randomNumber)
                 {
                     re1 = Convert.ToInt32(paises[6].ranking);
                     name = paises[6].country.ToString();
                     lblLoser4.Text = paises[7].country;
                 }
                 else if (Convert.ToInt32(paises[7].ranking) == randomNumber)
                 {
                     re1 = Convert.ToInt32(paises[7].ranking);
                     name = paises[7].country.ToString();
                     lblLoser4.Text = paises[6].country;
                 }
                 lbl5.Text = name ;
                 lbl6.Text = re1.ToString();

             }
              /////5///

             re1 = 0;

             //

             if (Convert.ToInt32(paises[8].ranking) < Convert.ToInt32(paises[9].ranking))
             {
                 i = Convert.ToInt32(paises[9].ranking);
             }
             else if (Convert.ToInt32(paises[8].ranking) > Convert.ToInt32(paises[9].ranking))
             {
                 i = Convert.ToInt32(paises[8].ranking);
             }
             while (re1 == 0)
             {
                 int randomNumber = random.Next(0, i + 1);

                 if (Convert.ToInt32(paises[8].ranking) == randomNumber)
                 {
                     re1 = Convert.ToInt32(paises[8].ranking);
                     name = paises[8].country.ToString();
                     lblLoser5.Text = paises[9].country;
                 }
                 else if (Convert.ToInt32(paises[9].ranking) == randomNumber)
                 {
                     re1 = Convert.ToInt32(paises[9].ranking);
                     name = paises[9].country.ToString();
                     lblLoser5.Text = paises[8].country;
                 }
                 lbl7.Text = name;
                 lbl8.Text = re1.ToString();

             }

              //6//

             re1 = 0;

             //

             if (Convert.ToInt32(paises[10].ranking) < Convert.ToInt32(paises[11].ranking))
             {
                 i = Convert.ToInt32(paises[11].ranking);
             }
             else if (Convert.ToInt32(paises[10].ranking) > Convert.ToInt32(paises[11].ranking))
             {
                 i = Convert.ToInt32(paises[10].ranking);
             }
             while (re1 == 0)
             {
                 int randomNumber = random.Next(0, i + 1);

                 if (Convert.ToInt32(paises[10].ranking) == randomNumber)
                 {
                     re1 = Convert.ToInt32(paises[10].ranking);
                     name = paises[10].country.ToString();
                     lblLoser6.Text = paises[11].country;
                 }
                 else if (Convert.ToInt32(paises[11].ranking) == randomNumber)
                 {
                     re1 = Convert.ToInt32(paises[11].ranking);
                     name = paises[11].country.ToString();
                     lblLoser6.Text = paises[10].country;
                 }
                 lbl9.Text = name;
                 lbl10.Text = re1.ToString();

             }

              ///7///
              ///
             re1 = 0;

             //

             if (Convert.ToInt32(paises[12].ranking) < Convert.ToInt32(paises[13].ranking))
             {
                 i = Convert.ToInt32(paises[13].ranking);
             }
             else if (Convert.ToInt32(paises[12].ranking) > Convert.ToInt32(paises[13].ranking))
             {
                 i = Convert.ToInt32(paises[12].ranking);
             }
             while (re1 == 0)
             {
                 int randomNumber = random.Next(0, i + 1);

                 if (Convert.ToInt32(paises[12].ranking) == randomNumber)
                 {
                     re1 = Convert.ToInt32(paises[12].ranking);
                     name = paises[12].country.ToString();
                     lblLoser7.Text = paises[13].country;
                 }
                 else if (Convert.ToInt32(paises[13].ranking) == randomNumber)
                 {
                     re1 = Convert.ToInt32(paises[13].ranking);
                     name = paises[13].country.ToString();
                     lblLoser7.Text = paises[12].country;
                 }
                 lbl11.Text = name;
                 lbl12.Text = re1.ToString();

             }

              //8//
             re1 = 0;

             //

             if (Convert.ToInt32(paises[14].ranking) < Convert.ToInt32(paises[15].ranking))
             {
                 i = Convert.ToInt32(paises[15].ranking);
             }
             else if (Convert.ToInt32(paises[14].ranking) > Convert.ToInt32(paises[15].ranking))
             {
                 i = Convert.ToInt32(paises[14].ranking);
             }
             while (re1 == 0)
             {
                 int randomNumber = random.Next(0, i + 1);

                 if (Convert.ToInt32(paises[14].ranking) == randomNumber)
                 {
                     re1 = Convert.ToInt32(paises[14].ranking);
                     name = paises[14].country.ToString();
                     lblLoser8.Text = paises[15].country;
                 }
                 else if (Convert.ToInt32(paises[15].ranking) == randomNumber)
                 {
                     re1 = Convert.ToInt32(paises[15].ranking);
                     name = paises[15].country.ToString();
                     lblLoser8.Text = paises[14].country;
                 }
                 lbl13.Text = name;
                 lbl14.Text = re1.ToString();

             }
          }

         
        /// <summary>
        /// round1b
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

          private void round1b()
          {
              Random random = new Random();
              WCL obj = new WCL();
              WC Country = new WC();
              List<WC> paises = obj.Consultar();
              int ran;
              int ran2;
              ran = Convert.ToInt32(paises[16].ranking);
              ran2 = Convert.ToInt32(paises[17].ranking);
              string name = "";
              int re = 0;
              int re1 = 0;
              int i = 0;
              if (ran < ran2)
              {
                  i = ran2;
              }
              else if (ran > ran2)
              {
                  i = ran;
              }

              ///1//
              while (re == 0)
              {
                  int randomNumber = random.Next(0, i + 1);

                  if (ran == randomNumber)
                  {
                      re = ran;
                      name = paises[16].country.ToString();
                      lblLoser9.Text = paises[17].country;
                  }
                  else if (ran2 == randomNumber)
                  {
                      re = ran2;
                      name = paises[17].country.ToString();
                      lblLoser9.Text = paises[16].country;
                  }
                  lbl16.Text = re.ToString();
                  lbl15.Text = name;
              }

              ///2///
              if (Convert.ToInt32(paises[18].ranking) < Convert.ToInt32(paises[19].ranking))
              {
                  i = Convert.ToInt32(paises[19].ranking);
              }
              else if (Convert.ToInt32(paises[18].ranking) > Convert.ToInt32(paises[19].ranking))
              {
                  i = Convert.ToInt32(paises[18].ranking);
              }
              while (re1 == 0)
              {
                  int randomNumber = random.Next(0, i + 1);

                  if (Convert.ToInt32(paises[18].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[18].ranking);
                      name = paises[18].country.ToString();
                      lblLoser10.Text = paises[19].country;
                  }
                  else if (Convert.ToInt32(paises[19].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[19].ranking);
                      name = paises[19].country.ToString();
                      lblLoser10.Text = paises[18].country;
                  }
                  lbl18.Text = re1.ToString();
                  lbl17.Text = name;

              }

              re1 = 0;

              //3//

              if (Convert.ToInt32(paises[20].ranking) < Convert.ToInt32(paises[21].ranking))
              {
                  i = Convert.ToInt32(paises[21].ranking);
              }
              else if (Convert.ToInt32(paises[20].ranking) > Convert.ToInt32(paises[21].ranking))
              {
                  i = Convert.ToInt32(paises[20].ranking);
              }

              while (re1 == 0)
              {
                  int randomNumber = random.Next(0, i + 1);

                  if (Convert.ToInt32(paises[20].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[20].ranking);
                      name = paises[20].country.ToString();
                      lblLoser11.Text = paises[21].country;
                  }
                  else if (Convert.ToInt32(paises[21].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[21].ranking);
                      name = paises[21].country.ToString();
                      lblLoser11.Text = paises[20].country;
                  }
                  lbl20.Text = re1.ToString();
                  lbl19.Text = name;

              }

              ///4///

              re1 = 0;

              //

              if (Convert.ToInt32(paises[22].ranking) < Convert.ToInt32(paises[23].ranking))
              {
                  i = Convert.ToInt32(paises[23].ranking);
              }
              else if (Convert.ToInt32(paises[22].ranking) > Convert.ToInt32(paises[23].ranking))
              {
                  i = Convert.ToInt32(paises[22].ranking);
              }
              while (re1 == 0)
              {
                  int randomNumber = random.Next(0, i + 1);

                  if (Convert.ToInt32(paises[22].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[22].ranking);
                      name = paises[22].country.ToString();
                      lblLoser12.Text = paises[23].country;
                  }
                  else if (Convert.ToInt32(paises[23].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[23].ranking);
                      name = paises[23].country.ToString();
                      lblLoser12.Text = paises[22].country;
                  }
                  lbl21.Text = name;
                  lbl22.Text = re1.ToString();

              }
              /////5///

              re1 = 0;

              //

              if (Convert.ToInt32(paises[24].ranking) < Convert.ToInt32(paises[25].ranking))
              {
                  i = Convert.ToInt32(paises[25].ranking);
              }
              else if (Convert.ToInt32(paises[24].ranking) > Convert.ToInt32(paises[25].ranking))
              {
                  i = Convert.ToInt32(paises[24].ranking);
              }
              while (re1 == 0)
              {
                  int randomNumber = random.Next(0, i + 1);

                  if (Convert.ToInt32(paises[24].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[24].ranking);
                      name = paises[24].country.ToString();
                      lblLoser13.Text = paises[25].country;
                  }
                  else if (Convert.ToInt32(paises[25].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[25].ranking);
                      name = paises[25].country.ToString();
                      lblLoser13.Text = paises[24].country;
                  }
                  lbl23.Text = name;
                  lbl24.Text = re1.ToString();

              }

              //6//

              re1 = 0;

              //

              if (Convert.ToInt32(paises[26].ranking) < Convert.ToInt32(paises[27].ranking))
              {
                  i = Convert.ToInt32(paises[27].ranking);
              }
              else if (Convert.ToInt32(paises[26].ranking) > Convert.ToInt32(paises[27].ranking))
              {
                  i = Convert.ToInt32(paises[26].ranking);
              }
              while (re1 == 0)
              {
                  int randomNumber = random.Next(0, i + 1);

                  if (Convert.ToInt32(paises[26].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[26].ranking);
                      name = paises[26].country.ToString();
                      lblLoser14.Text = paises[27].country;

                  }
                  else if (Convert.ToInt32(paises[27].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[27].ranking);
                      name = paises[27].country.ToString();
                      lblLoser14.Text = paises[26].country;
                  }
                  lbl25.Text = name;
                  lbl26.Text = re1.ToString();

              }

              ///7///
              ///
              re1 = 0;

              //

              if (Convert.ToInt32(paises[28].ranking) < Convert.ToInt32(paises[29].ranking))
              {
                  i = Convert.ToInt32(paises[29].ranking);
              }
              else if (Convert.ToInt32(paises[28].ranking) > Convert.ToInt32(paises[29].ranking))
              {
                  i = Convert.ToInt32(paises[28].ranking);
              }
              while (re1 == 0)
              {
                  int randomNumber = random.Next(0, i + 1);

                  if (Convert.ToInt32(paises[28].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[28].ranking);
                      name = paises[28].country.ToString();
                      lblLoser15.Text = paises[29].country;
                  }
                  else if (Convert.ToInt32(paises[29].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[29].ranking);
                      name = paises[29].country.ToString();
                      lblLoser15.Text = paises[28].country;
                  }
                  lbl27.Text = name;
                  lbl28.Text = re1.ToString();

              }

              //8//
              re1 = 0;

              //

              if (Convert.ToInt32(paises[30].ranking) < Convert.ToInt32(paises[31].ranking))
              {
                  i = Convert.ToInt32(paises[31].ranking);
              }
              else if (Convert.ToInt32(paises[30].ranking) > Convert.ToInt32(paises[31].ranking))
              {
                  i = Convert.ToInt32(paises[30].ranking);
              }
              while (re1 == 0)
              {
                  int randomNumber = random.Next(0, i + 1);

                  if (Convert.ToInt32(paises[31].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[31].ranking);
                      name = paises[31].country.ToString();
                      lblLoser16.Text = paises[30].country;
                  }
                  else if (Convert.ToInt32(paises[30].ranking) == randomNumber)
                  {
                      re1 = Convert.ToInt32(paises[30].ranking);
                      name = paises[30].country.ToString();
                      lblLoser16.Text = paises[31].country;
                  }
                  lbl29.Text = name;
                  lbl30.Text = re1.ToString();

              }
          }

          protected void Button1_Click1(object sender, EventArgs e)
          {
              WC obj = new WC();
              WCL objS = new WCL();
            objS.DeleteData();
            round1a();
            round1b();

          }

          protected void AddDataRound1(string country,int matches,int win, int lost, int ranking,int newranking)
          {

              WC obj = new WC();
            WCL objS = new WCL();
            obj.country=country;
            obj.matches=matches;
            obj.win= win;
             obj.lost= lost;
          obj.ranking=ranking;
          obj.newranking = newranking;
          objS.AddDataRound1(obj);
          }

          protected void btnNext_Click(object sender, EventArgs e)
          {
              WC obj = new WC();
              WCL objS = new WCL();
              objS.DeleteData();

              try
              {


                  AddDataRound1(lblname.Text, 1, 1, 0, Convert.ToInt32(lblre.Text), 0);
                  AddDataRound1(lblLoser1.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl2.Text, 1, 1, 0, Convert.ToInt32(lbl1.Text), 0);
                  AddDataRound1(lblLoser2.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl3.Text, 1, 1, 0, Convert.ToInt32(lbl4.Text), 0);
                  AddDataRound1(lblLoser3.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl5.Text, 1, 1, 0, Convert.ToInt32(lbl6.Text), 0);
                  AddDataRound1(lblLoser4.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl7.Text, 1, 1, 0, Convert.ToInt32(lbl8.Text), 0);
                  AddDataRound1(lblLoser5.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl9.Text, 1, 1, 0, Convert.ToInt32(lbl10.Text), 0);
                  AddDataRound1(lblLoser6.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl11.Text, 1, 1, 0, Convert.ToInt32(lbl12.Text), 0);
                  AddDataRound1(lblLoser7.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl13.Text, 1, 1, 0, Convert.ToInt32(lbl14.Text), 0);
                  AddDataRound1(lblLoser8.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl15.Text, 1, 1, 0, Convert.ToInt32(lbl16.Text), 0);
                  AddDataRound1(lblLoser9.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl17.Text, 1, 1, 0, Convert.ToInt32(lbl18.Text), 0);
                  AddDataRound1(lblLoser10.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl19.Text, 1, 1, 0, Convert.ToInt32(lbl20.Text), 0);
                  AddDataRound1(lblLoser11.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl21.Text, 1, 1, 0, Convert.ToInt32(lbl22.Text), 0);
                  AddDataRound1(lblLoser12.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl23.Text, 1, 1, 0, Convert.ToInt32(lbl24.Text), 0);
                  AddDataRound1(lblLoser13.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl25.Text, 1, 1, 0, Convert.ToInt32(lbl26.Text), 0);
                  AddDataRound1(lblLoser14.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl27.Text, 1, 1, 0, Convert.ToInt32(lbl28.Text), 0);
                  AddDataRound1(lblLoser15.Text, 1, 0, 0, 0, 0);
                  AddDataRound1(lbl29.Text, 1, 1, 0, Convert.ToInt32(lbl30.Text), 0);
                  AddDataRound1(lblLoser16.Text, 1, 0, 0, 0, 0);
                  Response.Redirect("Round2.aspx");
              }
              catch
              { }

          }

    }
}