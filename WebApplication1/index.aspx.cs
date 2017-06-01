using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Reflection;

namespace WebApplication1
{
   

    public partial class index : System.Web.UI.Page
    {



        private void SetBackColor(Control Parentcontrol)
        {

            if (Parentcontrol.HasControls())
            {
                foreach (Control c in Parentcontrol.Controls)
                {
                    SetBackColor(c);
                    TextBox tb = c as TextBox;
                    if (tb != null)
                        //  if (tb.Text != "" && tb.BackColor != System.Drawing.Color.WhiteSmoke)
                        if (tb.Text == "" || tb.Text.Contains("hrs"))
                            tb.BackColor = tb.BackColor;
                        else
                            tb.BackColor = System.Drawing.Color.Lime;
                }

            }
        }

        //public static string GetPropValue(String name, Object obj)
        //{
        //    Type type = obj.GetType();
        //    System.Reflection.PropertyInfo info = type.GetProperty(name);
        //    if (info == null) { return null; }
        //    obj = info.GetValue(obj, null);
        //    return obj.ToString();
        //}
      

        private void DisplayETA()
        {




            if (Global.KarenAnderson != DateTime.MinValue && !Global.ArrivekarenAnderson)
            {
                TimeSpan diff = (Global.KarenAnderson.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox1.Text = diff.ToString("mm");
                else
                    TextBox1.Text = "-" + diff.ToString("mm");

            }
            else if (Global.ArrivekarenAnderson)
            {
                TextBox1.Text = Global.KarenAnderson.ToString("HHmm") + "hrs";
                TextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
                Button28.Text = "HERE";
                Button28.Enabled = false;
            }


            if (Global.LaresaDeboer != DateTime.MinValue && !Global.ArrivelaresaDeboer)
            {
                TimeSpan diff = (Global.LaresaDeboer.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox2.Text = diff.ToString("mm");
                else
                    TextBox2.Text = "-" + diff.ToString("mm");
               
            }
            else if (Global.ArrivelaresaDeboer)
            {
                TextBox2.Text = Global.LaresaDeboer.ToString("HHmm") + "hrs";
                TextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
                LaresaArrivalButton.Text = "HERE";
                LaresaArrivalButton.Enabled = false;
            }
           

            if (Global.DanDewey != DateTime.MinValue && !Global.ArrivedanDewey)
            {
                TimeSpan diff = (Global.DanDewey.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox3.Text = diff.ToString("mm");
                else
                    TextBox3.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivedanDewey)
            {
                TextBox3.Text = Global.DanDewey.ToString("HHmm") + "hrs";
                TextBox3.BackColor = System.Drawing.Color.WhiteSmoke;
                DeweyArrivalButton.Text = "HERE";
             //   DeweyArrivalButton.Enabled = false;
            }
            //else if (!Global.ArrivedanDewey && DeweyArrivalButton.Text == "HERE")
            //{
            //    DeweyArrivalButton.Text = "DONE";
            //    TextBox3.Text = Global.DanDewey.ToString("HHmm") + "hrs";
            //    TextBox3.BackColor = System.Drawing.Color.Red;
            //}


            if (Global.JoseDundee != DateTime.MinValue && !Global.ArrivejoseDundee)
            {
                TimeSpan diff = (Global.JoseDundee.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox4.Text = diff.ToString("mm");
                else
                    TextBox4.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivejoseDundee)
            {
                TextBox4.Text = Global.JoseDundee.ToString("HHmm") + "hrs";
                TextBox4.BackColor = System.Drawing.Color.WhiteSmoke;
                JoseArrivalButton.Text = "HERE";
                JoseArrivalButton.Enabled = false;
            }


            if (Global.SarahDundee != DateTime.MinValue && !Global.ArrivesarahDundee)

            {
                TimeSpan diff = (Global.SarahDundee.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox5.Text = diff.ToString("mm");
                else
                    TextBox5.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivesarahDundee)
            {
                TextBox5.Text = Global.SarahDundee.ToString("HHmm") + "hrs";
                TextBox5.BackColor = System.Drawing.Color.WhiteSmoke;
                SDundeeARrivalButton.Text = "HERE";
                SDundeeARrivalButton.Enabled = false;
            }


            if (Global.SaraFish != DateTime.MinValue && !Global.ArrivesaraFish)
            {
                TimeSpan diff = (Global.SaraFish.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox6.Text = diff.ToString("mm");
                else
                    TextBox6.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivesaraFish)
            {
                TextBox6.Text = Global.SaraFish.ToString("HHmm") + "hrs";
                TextBox6.BackColor = System.Drawing.Color.WhiteSmoke;
                Button29.Text = "HERE";
                Button29.Enabled = false;
            }


            if (Global.ErinFong != DateTime.MinValue && !Global.ArriveerinFong)
            {
                TimeSpan diff = (Global.ErinFong.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox7.Text = diff.ToString("mm");
                else
                    TextBox7.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArriveerinFong)
            {
                TextBox6.Text = Global.SaraFish.ToString("HHmm") + "hrs";
                TextBox6.BackColor = System.Drawing.Color.WhiteSmoke;
                Button30.Text = "HERE";
                Button30.Enabled = false;
            }


            if (Global.MattHerold != DateTime.MinValue && !Global.ArrivemattHerold)
            {
                TimeSpan diff = (Global.MattHerold.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox8.Text = diff.ToString("mm");
                else
                    TextBox8.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivemattHerold)
            {
                TextBox8.Text = Global.MattHerold.ToString("HHmm") + "hrs";
                TextBox8.BackColor = System.Drawing.Color.WhiteSmoke;
                Button31.Text = "HERE";
                Button31.Enabled = false;
            }


            if (Global.BruceHubbard != DateTime.MinValue && !Global.ArrivebruceHubbard)
            {
                TimeSpan diff = (Global.BruceHubbard.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox9.Text = diff.ToString("mm");
                else
                    TextBox9.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivebruceHubbard)
            {
                TextBox9.Text = Global.BruceHubbard.ToString("HHmm") + "hrs";
                TextBox9.BackColor = System.Drawing.Color.WhiteSmoke;
                Button32.Text = "HERE";
                Button32.Enabled = false;
            }


            if (Global.ValerieJohnson != DateTime.MinValue && !Global.ArrivevalerieJohnson)
            {
                TimeSpan diff = (Global.ValerieJohnson.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox10.Text = diff.ToString("mm");
                else
                    TextBox10.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivevalerieJohnson)
            {
                TextBox10.Text = Global.ValerieJohnson.ToString("HHmm") + "hrs";
                TextBox10.BackColor = System.Drawing.Color.WhiteSmoke;
                Button33.Text = "HERE";
                Button33.Enabled = false;
            }


            if (Global.DaveLarson != DateTime.MinValue && !Global.ArrivedaveLarson)
            {
                TimeSpan diff = (Global.DaveLarson.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox11.Text = diff.ToString("mm");
                else
                    TextBox11.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivedaveLarson)
            {
                TextBox11.Text = Global.DaveLarson.ToString("HHmm") + "hrs";
                TextBox11.BackColor = System.Drawing.Color.WhiteSmoke;
                Button34.Text = "HERE";
                Button34.Enabled = false;
            }


            if (Global.AmyOsborn != DateTime.MinValue && !Global.ArriveamyOsborn)
            {
                TimeSpan diff = (Global.AmyOsborn.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox12.Text = diff.ToString("mm");
                else
                    TextBox12.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArriveamyOsborn)
            {
                TextBox12.Text = Global.AmyOsborn.ToString("HHmm") + "hrs";
                TextBox12.BackColor = System.Drawing.Color.WhiteSmoke;
                Button35.Text = "HERE";
                Button35.Enabled = false;
            }


            if (Global.GregPeterson != DateTime.MinValue && !Global.ArrivegregPeterson)
            {
                TimeSpan diff = (Global.GregPeterson.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox13.Text = diff.ToString("mm");
                else
                    TextBox13.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivegregPeterson)
            {
                TextBox13.Text = Global.GregPeterson.ToString("HHmm") + "hrs";
                TextBox13.BackColor = System.Drawing.Color.WhiteSmoke;
                Button36.Text = "HERE";
                Button36.Enabled = false;
            }


            if (Global.YoSchugel != DateTime.MinValue && !Global.ArriveyoSchugel)
            {
                TimeSpan diff = (Global.YoSchugel.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox14.Text = diff.ToString("mm");
                else
                    TextBox14.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArriveyoSchugel)
            {
                TextBox14.Text = Global.YoSchugel.ToString("HHmm") + "hrs";
                TextBox14.BackColor = System.Drawing.Color.WhiteSmoke;
                Button37.Text = "HERE";
                Button37.Enabled = false;
            }


            if (Global.KevinSipprell != DateTime.MinValue && !Global.ArrivekevinSipprell)
            {
                TimeSpan diff = (Global.KevinSipprell.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox15.Text = diff.ToString("mm");
                else
                    TextBox15.Text = "-" + diff.ToString("mm");
            }
         else if (Global.ArrivekevinSipprell)
            {
                TextBox15.Text = Global.KevinSipprell.ToString("HHmm") + "hrs";
                TextBox15.BackColor = System.Drawing.Color.WhiteSmoke;
                Button38.Text = "HERE";
                Button38.Enabled = false;
            }


            if (Global.EmilyAnderson != DateTime.MinValue && !Global.ArriveemilyAnderson)
            {
                TimeSpan diff = (Global.EmilyAnderson.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox16.Text = diff.ToString("mm");
                else
                    TextBox16.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArriveemilyAnderson)
            {
                TextBox16.Text = Global.EmilyAnderson.ToString("HHmm") + "hrs";
                TextBox16.BackColor = System.Drawing.Color.WhiteSmoke;
                Button39.Text = "HERE";
                Button39.Enabled = false;
            }


            if (Global.JerodBarnes != DateTime.MinValue && !Global.ArrivejerodBarnes)
            {
                TimeSpan diff = (Global.JerodBarnes.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox17.Text = diff.ToString("mm");
                else
                    TextBox17.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivejerodBarnes)
            {
                TextBox17.Text = Global.JerodBarnes.ToString("HHmm") + "hrs";
                TextBox17.BackColor = System.Drawing.Color.WhiteSmoke;
                Button40.Text = "HERE";
                Button40.Enabled = false;
            }


            if (Global.ErinBischoff != DateTime.MinValue && !Global.ArriveerinBischoff)
            {
                TimeSpan diff = (Global.ErinBischoff.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox18.Text = diff.ToString("mm");
                else
                    TextBox18.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArriveerinBischoff)
            {
                TextBox18.Text = Global.ErinBischoff.ToString("HHmm") + "hrs";
                TextBox18.BackColor = System.Drawing.Color.WhiteSmoke;
                Button40.Text = "HERE";
                Button40.Enabled = false;
            }


            if (Global.FredDemeuse != DateTime.MinValue && !Global.ArrivefredDemeuse)
            {
                TimeSpan diff = (Global.FredDemeuse.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox19.Text = diff.ToString("mm");
                else
                    TextBox19.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivefredDemeuse)
            {
                TextBox19.Text = Global.FredDemeuse.ToString("HHmm") + "hrs";
                TextBox19.BackColor = System.Drawing.Color.WhiteSmoke;
                Button42.Text = "HERE";
                Button42.Enabled = false;
            }


            if (Global.ChelseaErnisse != DateTime.MinValue && !Global.ArrivechelseaErnisse)
            {
                TimeSpan diff = (Global.ChelseaErnisse.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox20.Text = diff.ToString("mm");
                else
                    TextBox20.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivechelseaErnisse)
            {
                TextBox20.Text = Global.ChelseaErnisse.ToString("HHmm") + "hrs";
                TextBox20.BackColor = System.Drawing.Color.WhiteSmoke;
                Button43.Text = "HERE";
                Button43.Enabled = false;
            }


            if (Global.AllisonEngelsma != DateTime.MinValue && !Global.ArriveallisonEngelsma)
            {
                TimeSpan diff = (Global.AllisonEngelsma.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox21.Text = diff.ToString("mm");
                else
                    TextBox21.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArriveallisonEngelsma)
            {
                TextBox21.Text = Global.AllisonEngelsma.ToString("HHmm") + "hrs";
                TextBox21.BackColor = System.Drawing.Color.WhiteSmoke;
                Button44.Text = "HERE";
                Button44.Enabled = false;
            }


            if (Global.BradyGriffith != DateTime.MinValue && !Global.ArrivebradyGriffith)
            {
                TimeSpan diff = (Global.BradyGriffith.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox22.Text = diff.ToString("mm");
                else
                    TextBox22.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivebradyGriffith)
            {
                TextBox22.Text = Global.BradyGriffith.ToString("HHmm") + "hrs";
                TextBox22.BackColor = System.Drawing.Color.WhiteSmoke;
                Button45.Text = "HERE";
                Button45.Enabled = false;
            }


            if (Global.JasonHicks != DateTime.MinValue && !Global.ArrivejasonHicks)
            {
                TimeSpan diff = (Global.JasonHicks.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox23.Text = diff.ToString("mm");
                else
                    TextBox23.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivejasonHicks)
            {
                TextBox23.Text = Global.JasonHicks.ToString("HHmm") + "hrs";
                TextBox23.BackColor = System.Drawing.Color.WhiteSmoke;
                Button46.Text = "HERE";
                Button46.Enabled = false;
            }


            if (Global.LisaLarson != DateTime.MinValue && !Global.ArrivelisaLarson)
            {
                TimeSpan diff = (Global.LisaLarson.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox24.Text = diff.ToString("mm");
                else
                    TextBox24.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivelisaLarson)
            {
                TextBox24.Text = Global.LisaLarson.ToString("HHmm") + "hrs";
                TextBox24.BackColor = System.Drawing.Color.WhiteSmoke;
                Button47.Text = "HERE";
                Button47.Enabled = false;
            }


            if (Global.BethRadke != DateTime.MinValue && !Global.ArrivebethRadke)
            {
                TimeSpan diff = (Global.BethRadke.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox25.Text = diff.ToString("mm");
                else
                    TextBox25.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivebethRadke)
            {
                TextBox25.Text = Global.BethRadke.ToString("HHmm") + "hrs";
                TextBox25.BackColor = System.Drawing.Color.WhiteSmoke;
                Button48.Text = "HERE";
                Button48.Enabled = false;
            }


            if (Global.TamrahTenhaeff != DateTime.MinValue && !Global.ArrivetamrahTenhaeff)
            {
                TimeSpan diff = (Global.TamrahTenhaeff.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox26.Text = diff.ToString("mm");
                else
                    TextBox26.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArrivetamrahTenhaeff)
            {
                TextBox26.Text = Global.TamrahTenhaeff.ToString("HHmm") + "hrs";
                TextBox26.BackColor = System.Drawing.Color.WhiteSmoke;
                Button49.Text = "HERE";
                Button49.Enabled = false;
            }


            if (Global.ErinnVonRein != DateTime.MinValue && !Global.ArriveerinnVonRein)
            {
                TimeSpan diff = (Global.ErinnVonRein.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox27.Text = diff.ToString("mm");
                else
                    TextBox27.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ArriveerinnVonRein)
            {
                TextBox27.Text = Global.ErinnVonRein.ToString("HHmm") + "hrs";
                TextBox27.BackColor = System.Drawing.Color.WhiteSmoke;
                Button50.Text = "HERE";
                Button50.Enabled = false;
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox29.Text = Global.MDrespond.ToString();
            TextBox28.Text = Global.Mdhere.ToString();
            TextBox30.Text = Global.PAhere.ToString();
            TextBox31.Text = Global.PArespond.ToString();
            //  string important1 = Global.ImportantData;
            // //   TextBox1.Text = important1;
            DisplayETA();
          //  TextBox1.Text = Global.KarenAnderson.Subtract(DateTime.Now).ToString("mm");
           // TextBox2.Text = Global.LaresaDeboer.Subtract(DateTime.Now).ToString("mm");
            //TextBox3.Text = Global.DanDewey;
            //TextBox4.Text = Global.JoseDundee;
            //TextBox5.Text = Global.SarahDundee;
            //TextBox6.Text = Global.SaraFish;
            //TextBox7.Text = Global.ErinFong;
            //TextBox8.Text = Global.MattHerold;
            //TextBox9.Text = Global.BruceHubbard;
            //TextBox10.Text = Global.ValerieJohnson;
            //TextBox11.Text = Global.DaveLarson;
            //TextBox12.Text = Global.AmyOsborn;
            //TextBox13.Text = Global.GregPeterson;
            //TextBox14.Text = Global.YoSchugel;
            //TextBox15.Text = Global.KevinSipprell;
            //TextBox16.Text = Global.EmilyAnderson;
            //TextBox17.Text = Global.JerodBarnes;
            //TextBox18.Text = Global.ErinBischoff;
            //TextBox19.Text = Global.FredDemeuse;
            //TextBox20.Text = Global.ChelseaErnisse;
            //TextBox21.Text = Global.AllisonEngelsma;
            //TextBox22.Text = Global.BradyGriffith;
            //TextBox23.Text = Global.JasonHicks;
            //TextBox24.Text = Global.LisaLarson;
            //TextBox25.Text = Global.BethRadke;
            //TextBox26.Text = Global.TamrahTenhaeff;
            //TextBox27.Text = Global.ErinnVonRein;


            SetBackColor(Page);


        }

      

        protected void LaresaArrivalButton_Click(object sender, EventArgs e)
        {
            Log.Logstring += "Laresa DeBoer Arrival: " + DateTime.Now.ToString() + "\n";
            //  Global.LaresaDeboer = DateTime.Now.ToString("HHmm") + "hrs";
            if (!Global.ArrivelaresaDeboer)
                Global.Mdhere++;
            //else
            //    Global.Mdhere--;
            Global.LaresaDeboer = DateTime.Now;
            TextBox2.Text = Global.LaresaDeboer.ToString("HHmm") + "hrs";
            TextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            LaresaArrivalButton.Text = "HERE";
            LaresaArrivalButton.Enabled = false;
            Global.ArrivelaresaDeboer = true;
        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            if (!Global.ArrivekarenAnderson)
            Global.Mdhere++;
            //else
            //    Global.Mdhere--;
            Log.Logstring += "Karen Anderson Arrival: " + DateTime.Now.ToString() + "\n";
            Global.KarenAnderson = DateTime.Now;
            TextBox1.Text = Global.KarenAnderson.ToString("HHmm") + "hrs";
            TextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            Button28.Text = "HERE";
            Button28.Enabled = false;
            Global.ArrivekarenAnderson = true;
        }

        protected void DeweyArrivalButton_Click(object sender, EventArgs e)
        {
            if (!Global.ArrivedanDewey)
            {
                Global.Mdhere++;
                Log.Logstring += "Dan Dewey Arrival: " + DateTime.Now.ToString() + "\n";
                Global.DanDewey = DateTime.Now;
                TextBox3.Text = Global.DanDewey.ToString("HHmm") + "hrs";
                TextBox3.BackColor = System.Drawing.Color.WhiteSmoke;
                DeweyArrivalButton.Text = "HERE"; 
                Global.ArrivedanDewey = true;
                DeweyArrivalButton.Enabled = false;
            }
            //else
            //{
              
            //    Global.Mdhere--;
            //    Log.Logstring += "Dan Dewey DONE: " + DateTime.Now.ToString() + "\n";
            //    DeweyArrivalButton.Enabled = false;
            //    Global.DanDewey = DateTime.Now;
            //    DeweyArrivalButton.Text = "DONE";     
            //    TextBox3.Text = Global.DanDewey.ToString("HHmm") + "hrs";
            //    TextBox3.BackColor = System.Drawing.Color.Red;
               
            //}
            
        }

        protected void JoseArrivalButton_Click(object sender, EventArgs e)
        {
            Global.Mdhere++;
            Log.Logstring += "Jose Dundee Arrival: " + DateTime.Now.ToString() + "\n";
            Global.JoseDundee = DateTime.Now;
            TextBox4.Text = Global.JoseDundee.ToString("HHmm") + "hrs";
            TextBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            JoseArrivalButton.Text = "HERE";
            JoseArrivalButton.Enabled = false;
            Global.ArrivejoseDundee = true;
        }

        protected void SDundeeARrivalButton_Click(object sender, EventArgs e)
        {
            Global.Mdhere++;
            Log.Logstring += "Sarah Dundee Arrival: " + DateTime.Now.ToString() + "\n";
            Global.SarahDundee = DateTime.Now;
            TextBox5.Text = Global.SarahDundee.ToString("HHmm") + "hrs";
            TextBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            SDundeeARrivalButton.Text = "HERE";
            SDundeeARrivalButton.Enabled = false;
            Global.ArrivesarahDundee = true;
        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            Global.Mdhere++;
            Log.Logstring += "Sara Fish Arrival: " + DateTime.Now.ToString() + "\n";
            Global.SaraFish = DateTime.Now;
            TextBox6.Text = Global.SaraFish.ToString("HHmm") + "hrs";
            TextBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            Button29.Text = "HERE";
            Button29.Enabled = false;
            Global.ArrivesaraFish = true;
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            Global.Mdhere++;
            Log.Logstring += "Erine Fong Arrival: " + DateTime.Now.ToString() + "\n";
            Global.ErinFong = DateTime.Now;
            TextBox7.Text = Global.SaraFish.ToString("HHmm") + "hrs";
            TextBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            Button30.Text = "HERE";
            Button30.Enabled = false;
            Global.ArriveerinFong = true;
        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            Global.Mdhere++;
            Log.Logstring += "Matt Herold Arrival: " + DateTime.Now.ToString() + "\n";
            Global.MattHerold = DateTime.Now;
            TextBox8.Text = Global.MattHerold.ToString("HHmm") + "hrs";
            TextBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            Button31.Text = "HERE";
            Button31.Enabled = false;
            Global.ArrivemattHerold = true;
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            Global.Mdhere++;
            Log.Logstring += "Bruce Hubbard Arrival: " + DateTime.Now.ToString() + "\n";
            Global.BruceHubbard = DateTime.Now;
            TextBox9.Text = Global.BruceHubbard.ToString("HHmm") + "hrs";
            TextBox9.BackColor = System.Drawing.Color.WhiteSmoke;
            Button32.Text = "HERE";
            Button32.Enabled = false;
            Global.ArrivebruceHubbard = true;
        }

        protected void Button33_Click(object sender, EventArgs e)
        {
            Global.Mdhere++;
            Log.Logstring += "Valerie Johnson Arrival: " + DateTime.Now.ToString() + "\n";
            Global.ValerieJohnson = DateTime.Now;
            TextBox10.Text = Global.ValerieJohnson.ToString("HHmm") + "hrs";
            TextBox10.BackColor = System.Drawing.Color.WhiteSmoke;
            Button33.Text = "HERE";
            Button33.Enabled = false;
            Global.ArrivevalerieJohnson = true;
        }

        protected void Button34_Click(object sender, EventArgs e)
        {
            Global.Mdhere++;
            Log.Logstring += "Dave Larson Arrival: " + DateTime.Now.ToString() + "\n";
             Global.DaveLarson = DateTime.Now;
            TextBox11.Text = Global.DaveLarson.ToString("HHmm") + "hrs";
            TextBox11.BackColor = System.Drawing.Color.WhiteSmoke;
            Button34.Text = "HERE";
            Button34.Enabled = false;
            Global.ArrivedaveLarson = true;
        }

        protected void Button35_Click(object sender, EventArgs e)
        {
            Global.Mdhere++;
            Log.Logstring += "Amy Osborn Arrival: " + DateTime.Now.ToString() + "\n";
            Global.AmyOsborn = DateTime.Now;
            TextBox12.Text = Global.AmyOsborn.ToString("HHmm") + "hrs";
            TextBox12.BackColor = System.Drawing.Color.WhiteSmoke;
            Button35.Text = "HERE";
            Button35.Enabled = false;
            Global.ArriveamyOsborn = true;
        }

        protected void Button36_Click(object sender, EventArgs e)
        {
            Global.Mdhere++;
            Log.Logstring += "Greg Peterson Arrival: " + DateTime.Now.ToString() + "\n";
            Global.GregPeterson = DateTime.Now;
            TextBox13.Text = Global.GregPeterson.ToString("HHmm") + "hrs";
            TextBox13.BackColor = System.Drawing.Color.WhiteSmoke;
            Button36.Text = "HERE";
            Button36.Enabled = false;
            Global.ArrivegregPeterson = true;
        }

        protected void Button37_Click(object sender, EventArgs e)
        {
            Global.Mdhere++;
            Log.Logstring += "Yo Schugel Arrival: " + DateTime.Now.ToString() + "\n";
            Global.YoSchugel = DateTime.Now;
            TextBox14.Text = Global.YoSchugel.ToString("HHmm") + "hrs";
            TextBox14.BackColor = System.Drawing.Color.WhiteSmoke;
            Button37.Text = "HERE";
            Button37.Enabled = false;
            Global.ArriveyoSchugel = true;
        }

        protected void Button38_Click(object sender, EventArgs e)
        {
            Global.Mdhere++;
            Log.Logstring += "Kevin Sipprell Arrival: " + DateTime.Now.ToString() + "\n";
            Global.KevinSipprell = DateTime.Now;
            TextBox15.Text = Global.KevinSipprell.ToString("HHmm") + "hrs";
            TextBox15.BackColor = System.Drawing.Color.WhiteSmoke;
            Button38.Text = "HERE";
            Button38.Enabled = false;
            Global.ArrivekevinSipprell = true;
        }

        protected void Button39_Click(object sender, EventArgs e)
        {
            Global.PAhere++;
            Log.Logstring += "Emily Anderson Arrival: " + DateTime.Now.ToString() + "\n";
            Global.EmilyAnderson = DateTime.Now;
            TextBox16.Text = Global.EmilyAnderson.ToString("HHmm") + "hrs";
            TextBox16.BackColor = System.Drawing.Color.WhiteSmoke;
            Button39.Text = "HERE";
            Button39.Enabled = false;
            Global.ArriveemilyAnderson = true;
        }

        protected void Button40_Click(object sender, EventArgs e)
        {
            Global.PAhere++;
            Log.Logstring += "Jerod Barnes Arrival: " + DateTime.Now.ToString() + "\n";
            Global.JerodBarnes = DateTime.Now;
            TextBox17.Text = Global.JerodBarnes.ToString("HHmm") + "hrs";
            TextBox17.BackColor = System.Drawing.Color.WhiteSmoke;
            Button40.Text = "HERE";
            Button40.Enabled = false;
            Global.ArrivejerodBarnes = true;

        }

        protected void Button41_Click(object sender, EventArgs e)
        {
            Global.PAhere++;
            Log.Logstring += "Erin Bischoff Arrival: " + DateTime.Now.ToString() + "\n";
            Global.ErinBischoff = DateTime.Now;
            TextBox18.Text = Global.ErinBischoff.ToString("HHmm") + "hrs";
            TextBox18.BackColor = System.Drawing.Color.WhiteSmoke;
            Button41.Text = "HERE";
            Button41.Enabled = false;
            Global.ArriveerinBischoff = true;
        }

        protected void Button42_Click(object sender, EventArgs e)
        {
            Global.PAhere++;

            Log.Logstring += "Fred DeMeuse Arrival: " + DateTime.Now.ToString() + "\n";
            Global.FredDemeuse = DateTime.Now;
            TextBox19.Text = Global.FredDemeuse.ToString("HHmm") + "hrs";
            TextBox19.BackColor = System.Drawing.Color.WhiteSmoke;
            Button42.Text = "HERE";
            Button42.Enabled = false;
            Global.ArrivefredDemeuse = true;
        }

        protected void Button43_Click(object sender, EventArgs e)
        {
            Global.PAhere++;
            Log.Logstring += "Chelsea Eernisse Arrival: " + DateTime.Now.ToString() + "\n";
            Global.ChelseaErnisse = DateTime.Now;
            TextBox20.Text = Global.ChelseaErnisse.ToString("HHmm") + "hrs";
            TextBox20.BackColor = System.Drawing.Color.WhiteSmoke;
            Button43.Text = "HERE";
            Button43.Enabled = false;
            Global.ArrivechelseaErnisse = true;
        }

        protected void Button44_Click(object sender, EventArgs e)
        {
            Global.PAhere++;
            Log.Logstring += "Alli Engelsma Arrival: " + DateTime.Now.ToString() + "\n";
            Global.AllisonEngelsma = DateTime.Now;
            TextBox21.Text = Global.AllisonEngelsma.ToString("HHmm") + "hrs";
            TextBox21.BackColor = System.Drawing.Color.WhiteSmoke;
            Button44.Text = "HERE";
            Button44.Enabled = false;
            Global.ArriveallisonEngelsma = true;
        }

        protected void Button45_Click(object sender, EventArgs e)
        {
            Global.PAhere++;
            Log.Logstring += "Brady Griffith Arrival: " + DateTime.Now.ToString() + "\n";
            Global.BradyGriffith = DateTime.Now;
            TextBox22.Text = Global.BradyGriffith.ToString("HHmm") + "hrs";
            TextBox22.BackColor = System.Drawing.Color.WhiteSmoke;
            Button45.Text = "HERE";
            Button45.Enabled = false;
            Global.ArrivebradyGriffith = true;
        }

        protected void Button46_Click(object sender, EventArgs e)
        {
            Global.PAhere++;
            Log.Logstring += "Jason Hicks Arrival: " + DateTime.Now.ToString() + "\n";
            Global.JasonHicks = DateTime.Now;
            TextBox23.Text = Global.JasonHicks.ToString("HHmm") + "hrs";
            TextBox23.BackColor = System.Drawing.Color.WhiteSmoke;
            Button46.Text = "HERE";
            Button46.Enabled = false;
            Global.ArrivejasonHicks = true;
        }

        protected void Button47_Click(object sender, EventArgs e)
        {
            Global.PAhere++;
            Log.Logstring += "Lisa Larson Arrival: " + DateTime.Now.ToString() + "\n";
            Global.LisaLarson = DateTime.Now;
            TextBox24.Text = Global.LisaLarson.ToString("HHmm") + "hrs";
            TextBox24.BackColor = System.Drawing.Color.WhiteSmoke;
            Button47.Text = "HERE";
            Button47.Enabled = false;
            Global.ArrivelisaLarson = true;

        }


        protected void Button48_Click(object sender, EventArgs e)
        {
            Log.Logstring += "Beth Radke Arrival: " + DateTime.Now.ToString() + "\n";
            Global.BethRadke = DateTime.Now;
            TextBox25.Text = Global.BethRadke.ToString("HHmm") + "hrs";
            TextBox25.BackColor = System.Drawing.Color.WhiteSmoke;
            Button48.Text = "HERE";
            Button48.Enabled = false;
            Global.ArrivebethRadke = true;
        }

        protected void Button49_Click(object sender, EventArgs e)
        {
            Log.Logstring += "Tamrah Tenhaeff Arrival: " + DateTime.Now.ToString() + "\n";
            Global.TamrahTenhaeff = DateTime.Now;
            TextBox26.Text = Global.TamrahTenhaeff.ToString("HHmm") + "hrs";
            TextBox26.BackColor = System.Drawing.Color.WhiteSmoke;
            Button49.Text = "HERE";
            Button49.Enabled = false;
            Global.ArrivetamrahTenhaeff = true;

        }

        protected void Button50_Click(object sender, EventArgs e)
        {
            Log.Logstring += "Erinn vonRein Arrival: " + DateTime.Now.ToString() + "\n";
            Global.ErinnVonRein = DateTime.Now;
            TextBox27.Text = Global.ErinnVonRein.ToString("HHmm") + "hrs";
            TextBox27.BackColor = System.Drawing.Color.WhiteSmoke;
            Button50.Text = "HERE";
            Button50.Enabled = false;
            Global.ArriveerinnVonRein = true;
        }

        protected void Button51_Click(object sender, EventArgs e)
        {
            CleartextBoxes(Page);
        }
        public void CleartextBoxes(Control parent)
        {
            if (parent.HasControls())
            {
                foreach (Control x in parent.Controls)
                {
                    if ((x.GetType() == typeof(TextBox)))
                    {
                        ((TextBox)(x)).Text = "";
                        ((TextBox)(x)).BackColor = default(System.Drawing.Color);
                    }

                  
                    if (x.GetType() == typeof(Button))
                    {
                        if (((Button)(x)).Enabled == false)
                        {
                            ((Button)(x)).Enabled = true;
                            ((Button)(x)).Text = "Arrived";
                        }
                    }

                    CleartextBoxes(x);
                }
            }
        }

        //private void SetBackColor(Control Parentcontrol)
        //{

        //    if (Parentcontrol.HasControls())
        //    {
        //        foreach (Control c in Parentcontrol.Controls)
        //        {
        //            SetBackColor(c);
        //            TextBox tb = c as TextBox;
        //            if (tb != null)
        //                //  if (tb.Text != "" && tb.BackColor != System.Drawing.Color.WhiteSmoke)
        //                if (tb.Text == "" || tb.Text.Contains("hrs"))
        //                    tb.BackColor = tb.BackColor;
        //                else
        //                    tb.BackColor = System.Drawing.Color.Lime;
        //        }

        //    }
        //}







    }
}