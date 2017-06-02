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


            CheckKarenAndersonStatus();

            //if (Global.KarenAnderson != DateTime.MinValue && !Global.ArrivekarenAnderson)
            //{
            //    TimeSpan diff = (Global.KarenAnderson.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox1.Text = diff.ToString("mm");
            //    else
            //        TextBox1.Text = "-" + diff.ToString("mm");

            //}
            //else if (Global.ArrivekarenAnderson)
            //{
            //    TextBox1.Text = Global.KarenAnderson.ToString("HHmm") + "hrs";
            //    TextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button28.Text = "HERE";
            //    Button28.Enabled = false;
            //}


            CheckLaresaDeboerStatus();
            CheckDanDeweyStatus();

            //if (Global.DanDewey != DateTime.MinValue && !Global.ArrivedanDewey && DeweyArrivalButton.Text !="DONE")
            //{
            //    TimeSpan diff = (Global.DanDewey.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox3.Text = diff.ToString("mm");
            //    else
            //        TextBox3.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivedanDewey)
            //{
            //    TextBox3.Text = Global.DanDewey.ToString("HHmm") + "hrs";
            //    TextBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            //    DeweyArrivalButton.Text = "HERE";
            //    //   DeweyArrivalButton.Enabled = false;
            //}
            //else if (!Global.ArrivedanDewey && DeweyArrivalButton.Text == "HERE")
            //{
            //    DeweyArrivalButton.Text = "DONE";
            //    TextBox3.Text = Global.DanDewey.ToString("HHmm") + "hrs";
            //    TextBox3.BackColor = System.Drawing.Color.Red;
            //}

            CheckJoseDundeeStatus();
            //if (Global.JoseDundee != DateTime.MinValue && !Global.ArrivejoseDundee)
            //{
            //    TimeSpan diff = (Global.JoseDundee.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox4.Text = diff.ToString("mm");
            //    else
            //        TextBox4.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivejoseDundee)
            //{
            //    TextBox4.Text = Global.JoseDundee.ToString("HHmm") + "hrs";
            //    TextBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            //    JoseArrivalButton.Text = "HERE";
            //    JoseArrivalButton.Enabled = false;
            //}

            CheckSarahDundeeStatus();
            //if (Global.SarahDundee != DateTime.MinValue && !Global.ArrivesarahDundee)

            //{
            //    TimeSpan diff = (Global.SarahDundee.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox5.Text = diff.ToString("mm");
            //    else
            //        TextBox5.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivesarahDundee)
            //{
            //    TextBox5.Text = Global.SarahDundee.ToString("HHmm") + "hrs";
            //    TextBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            //    SDundeeARrivalButton.Text = "HERE";
            //    SDundeeARrivalButton.Enabled = false;
            //}

            CheckSaraFishStatus();
            //if (Global.SaraFish != DateTime.MinValue && !Global.ArrivesaraFish)
            //{
            //    TimeSpan diff = (Global.SaraFish.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox6.Text = diff.ToString("mm");
            //    else
            //        TextBox6.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivesaraFish)
            //{
            //    TextBox6.Text = Global.SaraFish.ToString("HHmm") + "hrs";
            //    TextBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button29.Text = "HERE";
            //    Button29.Enabled = false;
            //}
            CheckErinFongStatus();

            //if (Global.ErinFong != DateTime.MinValue && !Global.ArriveerinFong)
            //{
            //    TimeSpan diff = (Global.ErinFong.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox7.Text = diff.ToString("mm");
            //    else
            //        TextBox7.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArriveerinFong)
            //{
            //    TextBox6.Text = Global.SaraFish.ToString("HHmm") + "hrs";
            //    TextBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button30.Text = "HERE";
            //    Button30.Enabled = false;
            //}

            CheckMattHeroldStatus();
            //if (Global.MattHerold != DateTime.MinValue && !Global.ArrivemattHerold)
            //{
            //    TimeSpan diff = (Global.MattHerold.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox8.Text = diff.ToString("mm");
            //    else
            //        TextBox8.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivemattHerold)
            //{
            //    TextBox8.Text = Global.MattHerold.ToString("HHmm") + "hrs";
            //    TextBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button31.Text = "HERE";
            //    Button31.Enabled = false;
            //}
            CheckBruceHubbardStatus();

            //if (Global.BruceHubbard != DateTime.MinValue && !Global.ArrivebruceHubbard)
            //{
            //    TimeSpan diff = (Global.BruceHubbard.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox9.Text = diff.ToString("mm");
            //    else
            //        TextBox9.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivebruceHubbard)
            //{
            //    TextBox9.Text = Global.BruceHubbard.ToString("HHmm") + "hrs";
            //    TextBox9.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button32.Text = "HERE";
            //    Button32.Enabled = false;
            //}

            CheckValerieJohnsonStatus();
            //if (Global.ValerieJohnson != DateTime.MinValue && !Global.ArrivevalerieJohnson)
            //{
            //    TimeSpan diff = (Global.ValerieJohnson.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox10.Text = diff.ToString("mm");
            //    else
            //        TextBox10.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivevalerieJohnson)
            //{
            //    TextBox10.Text = Global.ValerieJohnson.ToString("HHmm") + "hrs";
            //    TextBox10.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button33.Text = "HERE";
            //    Button33.Enabled = false;
            //}

            CheckDaveLarsonStatus();
            //if (Global.DaveLarson != DateTime.MinValue && !Global.ArrivedaveLarson)
            //{
            //    TimeSpan diff = (Global.DaveLarson.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox11.Text = diff.ToString("mm");
            //    else
            //        TextBox11.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivedaveLarson)
            //{
            //    TextBox11.Text = Global.DaveLarson.ToString("HHmm") + "hrs";
            //    TextBox11.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button34.Text = "HERE";
            //    Button34.Enabled = false;
            //}

            CheckAmyOsbornStatus();
            //if (Global.AmyOsborn != DateTime.MinValue && !Global.ArriveamyOsborn)
            //{
            //    TimeSpan diff = (Global.AmyOsborn.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox12.Text = diff.ToString("mm");
            //    else
            //        TextBox12.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArriveamyOsborn)
            //{
            //    TextBox12.Text = Global.AmyOsborn.ToString("HHmm") + "hrs";
            //    TextBox12.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button35.Text = "HERE";
            //    Button35.Enabled = false;
            //}

            CheckGregPetersonStatus();
            //if (Global.GregPeterson != DateTime.MinValue && !Global.ArrivegregPeterson)
            //{
            //    TimeSpan diff = (Global.GregPeterson.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox13.Text = diff.ToString("mm");
            //    else
            //        TextBox13.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivegregPeterson)
            //{
            //    TextBox13.Text = Global.GregPeterson.ToString("HHmm") + "hrs";
            //    TextBox13.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button36.Text = "HERE";
            //    Button36.Enabled = false;
            //}

           CheckYoSchugelStatus();
            //if (Global.YoSchugel != DateTime.MinValue && !Global.ArriveyoSchugel)
            //{
            //    TimeSpan diff = (Global.YoSchugel.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox14.Text = diff.ToString("mm");
            //    else
            //        TextBox14.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArriveyoSchugel)
            //{
            //    TextBox14.Text = Global.YoSchugel.ToString("HHmm") + "hrs";
            //    TextBox14.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button37.Text = "HERE";
            //    Button37.Enabled = false;
            //}

            CheckKevinSipprellStatus();
            //if (Global.KevinSipprell != DateTime.MinValue && !Global.ArrivekevinSipprell)
            //{
            //    TimeSpan diff = (Global.KevinSipprell.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox15.Text = diff.ToString("mm");
            //    else
            //        TextBox15.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivekevinSipprell)
            //{
            //    TextBox15.Text = Global.KevinSipprell.ToString("HHmm") + "hrs";
            //    TextBox15.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button38.Text = "HERE";
            //    Button38.Enabled = false;
            //}

            CheckEmilyAndersonStatus();
            //if (Global.EmilyAnderson != DateTime.MinValue && !Global.ArriveemilyAnderson)
            //{
            //    TimeSpan diff = (Global.EmilyAnderson.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox16.Text = diff.ToString("mm");
            //    else
            //        TextBox16.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArriveemilyAnderson)
            //{
            //    TextBox16.Text = Global.EmilyAnderson.ToString("HHmm") + "hrs";
            //    TextBox16.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button39.Text = "HERE";
            //    Button39.Enabled = false;
            //}

            CheckJerodBarnesStatus();
            //if (Global.JerodBarnes != DateTime.MinValue && !Global.ArrivejerodBarnes)
            //{
            //    TimeSpan diff = (Global.JerodBarnes.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox17.Text = diff.ToString("mm");
            //    else
            //        TextBox17.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivejerodBarnes)
            //{
            //    TextBox17.Text = Global.JerodBarnes.ToString("HHmm") + "hrs";
            //    TextBox17.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button40.Text = "HERE";
            //    Button40.Enabled = false;
            //}

            CheckErinBischoffStatus();
            //if (Global.ErinBischoff != DateTime.MinValue && !Global.ArriveerinBischoff)
            //{
            //    TimeSpan diff = (Global.ErinBischoff.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox18.Text = diff.ToString("mm");
            //    else
            //        TextBox18.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArriveerinBischoff)
            //{
            //    TextBox18.Text = Global.ErinBischoff.ToString("HHmm") + "hrs";
            //    TextBox18.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button40.Text = "HERE";
            //    Button40.Enabled = false;
            //}

            CheckFredDemeuseStatus();
            //if (Global.FredDemeuse != DateTime.MinValue && !Global.ArrivefredDemeuse)
            //{
            //    TimeSpan diff = (Global.FredDemeuse.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox19.Text = diff.ToString("mm");
            //    else
            //        TextBox19.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivefredDemeuse)
            //{
            //    TextBox19.Text = Global.FredDemeuse.ToString("HHmm") + "hrs";
            //    TextBox19.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button42.Text = "HERE";
            //    Button42.Enabled = false;
            //}

            CheckChelseaErnisseStatus();
            //if (Global.ChelseaErnisse != DateTime.MinValue && !Global.ArrivechelseaErnisse)
            //{
            //    TimeSpan diff = (Global.ChelseaErnisse.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox20.Text = diff.ToString("mm");
            //    else
            //        TextBox20.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivechelseaErnisse)
            //{
            //    TextBox20.Text = Global.ChelseaErnisse.ToString("HHmm") + "hrs";
            //    TextBox20.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button43.Text = "HERE";
            //    Button43.Enabled = false;
            //}

            CheckAlliEngelsmaStatus();
            //if (Global.AllisonEngelsma != DateTime.MinValue && !Global.ArriveallisonEngelsma)
            //{
            //    TimeSpan diff = (Global.AllisonEngelsma.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox21.Text = diff.ToString("mm");
            //    else
            //        TextBox21.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArriveallisonEngelsma)
            //{
            //    TextBox21.Text = Global.AllisonEngelsma.ToString("HHmm") + "hrs";
            //    TextBox21.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button44.Text = "HERE";
            //    Button44.Enabled = false;
            //}

            CheckBradyGriffithStatus();
          //  if (Global.BradyGriffith != DateTime.MinValue && !Global.ArrivebradyGriffith)
          //  {
          //      TimeSpan diff = (Global.BradyGriffith.Subtract(DateTime.Now));
          //      if (diff.TotalMinutes >= 0)
          //          TextBox22.Text = diff.ToString("mm");
          //      else
          //          TextBox22.Text = "-" + diff.ToString("mm");
          //  }
          //  else if (Global.ArrivebradyGriffith)
          //  {
          //      TextBox22.Text = Global.BradyGriffith.ToString("HHmm") + "hrs";
          //      TextBox22.BackColor = System.Drawing.Color.WhiteSmoke;
          //      Button45.Text = "HERE";
          //      Button45.Enabled = false;
          //  }

           CheckJasonHicksStatus();
          //  if (Global.JasonHicks != DateTime.MinValue && !Global.ArrivejasonHicks)
          //  {
          //      TimeSpan diff = (Global.JasonHicks.Subtract(DateTime.Now));
          //      if (diff.TotalMinutes >= 0)
          //          TextBox23.Text = diff.ToString("mm");
          //      else
          //          TextBox23.Text = "-" + diff.ToString("mm");
          //  }
          //  else if (Global.ArrivejasonHicks)
          //  {
          //      TextBox23.Text = Global.JasonHicks.ToString("HHmm") + "hrs";
          //      TextBox23.BackColor = System.Drawing.Color.WhiteSmoke;
          //      Button46.Text = "HERE";
          //      Button46.Enabled = false;
          //  }

           CheckLisaLarsonStatus();
            //if (Global.LisaLarson != DateTime.MinValue && !Global.ArrivelisaLarson)
            //{
            //    TimeSpan diff = (Global.LisaLarson.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox24.Text = diff.ToString("mm");
            //    else
            //        TextBox24.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivelisaLarson)
            //{
            //    TextBox24.Text = Global.LisaLarson.ToString("HHmm") + "hrs";
            //    TextBox24.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button47.Text = "HERE";
            //    Button47.Enabled = false;
            //}

            CheckBethRadkeStatus();
            //if (Global.BethRadke != DateTime.MinValue && !Global.ArrivebethRadke)
            //{
            //    TimeSpan diff = (Global.BethRadke.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox25.Text = diff.ToString("mm");
            //    else
            //        TextBox25.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivebethRadke)
            //{
            //    TextBox25.Text = Global.BethRadke.ToString("HHmm") + "hrs";
            //    TextBox25.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button48.Text = "HERE";
            //    Button48.Enabled = false;
            //}

            CheckTamrahTenhaeffStatus();
            //if (Global.TamrahTenhaeff != DateTime.MinValue && !Global.ArrivetamrahTenhaeff)
            //{
            //    TimeSpan diff = (Global.TamrahTenhaeff.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox26.Text = diff.ToString("mm");
            //    else
            //        TextBox26.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArrivetamrahTenhaeff)
            //{
            //    TextBox26.Text = Global.TamrahTenhaeff.ToString("HHmm") + "hrs";
            //    TextBox26.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button49.Text = "HERE";
            //    Button49.Enabled = false;
            //}

            CheckErinnVonReinStatus();
            //if (Global.ErinnVonRein != DateTime.MinValue && !Global.ArriveerinnVonRein)
            //{
            //    TimeSpan diff = (Global.ErinnVonRein.Subtract(DateTime.Now));
            //    if (diff.TotalMinutes >= 0)
            //        TextBox27.Text = diff.ToString("mm");
            //    else
            //        TextBox27.Text = "-" + diff.ToString("mm");
            //}
            //else if (Global.ArriveerinnVonRein)
            //{
            //    TextBox27.Text = Global.ErinnVonRein.ToString("HHmm") + "hrs";
            //    TextBox27.BackColor = System.Drawing.Color.WhiteSmoke;
            //    Button50.Text = "HERE";
            //    Button50.Enabled = false;
            //}

        }




        private void CancelUnexpectedRePost()
        {
            string clientCode = _repostcheckcode.Value;

            //Get Server Code from session (Or Empty if null)
            string serverCode = Session["_repostcheckcode"] as string ?? "";

            if (!IsPostBack || clientCode.Equals(serverCode))
            {
                //Codes are equals - The action was initiated by the user
                //Save new code (Can use simple counter instead Guid)
                string code = Guid.NewGuid().ToString();
                _repostcheckcode.Value = code;
                Session["_repostcheckcode"] = code;
            }
            else
            {
                //Unexpected action - caused by F5 (Refresh) button
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }


        private Boolean IsPageRefresh = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            CancelUnexpectedRePost();





            if (!IsPostBack)
            {
                ViewState["postids"] = System.Guid.NewGuid().ToString();
                Session["postid"] = ViewState["postids"].ToString();
            }
            else
            {
                if (ViewState["postids"].ToString() != Session["postid"].ToString())
                {
                    IsPageRefresh = true;
                }
                Session["postid"] = System.Guid.NewGuid().ToString();
                ViewState["postids"] = Session["postid"].ToString();
            }

            TextBox29.Text = Global.MDrespond.ToString();
            TextBox28.Text = Global.Mdhere.ToString();
            TextBox30.Text = Global.PAhere.ToString();
            TextBox31.Text = Global.PArespond.ToString();
            //  string important1 = Global.ImportantData;
            // //   TextBox1.Text = important1;
            if (!IsPageRefresh) // prevent page refresh from tiggering again
            {

                DisplayETA();


                SetBackColor(Page);
            }

        }

      

        protected void LaresaArrivalButton_Click(object sender, EventArgs e)
        {

            if (!IsPageRefresh) // prevent page refresh from tiggering again
            {

                if (Global.LaresaDeboerStatus !=null)
                    Global.MDrespond--;

                    Global.Mdhere++;
                    Global.LaresaDeboerStatus = "Here";
                    Global.LaresaDeboer = DateTime.Now;
                    LaresaArrivalButton.Enabled = false;
                    Log.Logstring += "Laresa DeBoer Arrived: " + DateTime.Now.ToString() + "\n";
                    TextBox2.BackColor = System.Drawing.Color.Yellow;
                    
                    CheckLaresaDeboerStatus();
                    Response.Redirect("index.aspx");

               // }

                //if (Global.ArrivelaresaDeboer)
                //{
                //    Global.Mdhere--;
                //    LaresaArrivalButton.Text = "DONE";
                //    LaresaArrivalButton.Enabled = false;
                //    Global.LaresaDeboer = DateTime.Now;
                //    TextBox2.Text = Global.LaresaDeboer.ToString("HHmm") + "hrs";
                //    TextBox2.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Laresa DeBoer Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivelaresaDeboer = false;
                //}
                //else
                //{
                //    Log.Logstring += "Laresa DeBoer Arrival: " + DateTime.Now.ToString() + "\n";
                //    //  Global.LaresaDeboer = DateTime.Now.ToString("HHmm") + "hrs";

                //    Global.Mdhere++;
                //    //else
                //    //    Global.Mdhere--;
                //    Global.MDrespond--;
                //    Global.LaresaDeboer = DateTime.Now;
                //    TextBox2.Text = Global.LaresaDeboer.ToString("HHmm") + "hrs";
                //    TextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
                //    LaresaArrivalButton.Text = "HERE";
                //    //  LaresaArrivalButton.Enabled = false;
                //    Global.ArrivelaresaDeboer = true;
                //}
            }

        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                if (Global.KarenAndersonStatus != null)
                    Global.MDrespond--;

                Global.Mdhere++;
                Global.KarenAndersonStatus = "Here";
                Global.KarenAnderson = DateTime.Now;
           //     Button28.Enabled = false;
                Log.Logstring += "Karen Anderson Arrived: " + DateTime.Now.ToString() + "\n";
           //     TextBox1.BackColor = System.Drawing.Color.Yellow;
              //  Global.MDrespond--;
                CheckKarenAndersonStatus();
                Response.Redirect("index.aspx");
             
            }
        }
        protected void DeweyArrivalButton_Click(object sender, EventArgs e)
        {

            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                if (Global.DanDeweyStatus != null)
                    Global.MDrespond--;

                Global.Mdhere++;
                Global.DanDeweyStatus = "Here";
                Global.DanDewey = DateTime.Now;
                DeweyArrivalButton.Enabled = false;
                Log.Logstring += "Dan Dewey Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox3.BackColor = System.Drawing.Color.Yellow;
              //  Global.MDrespond--;
                CheckDanDeweyStatus();
                Response.Redirect("index.aspx");


                //if (Global.ArrivedanDewey)
                //{
                //    Global.Mdhere--;
                //    DeweyArrivalButton.Text = "DONE";
                //    DeweyArrivalButton.Enabled = false;
                //    Global.DanDewey = DateTime.Now;
                //    TextBox3.Text = Global.DanDewey.ToString("HHmm") + "hrs";
                //    TextBox3.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Dan Dewey Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivedanDewey = false;
                //}
                //else
                //{


                //    Global.Mdhere++;
                //    Global.MDrespond--;
                //    Log.Logstring += "Dan Dewey Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.DanDewey = DateTime.Now;
                //    TextBox3.Text = Global.DanDewey.ToString("HHmm") + "hrs";
                //    TextBox3.BackColor = System.Drawing.Color.WhiteSmoke;
                //    DeweyArrivalButton.Text = "HERE";
                //    Global.ArrivedanDewey = true;
                //  //  DeweyArrivalButton.Enabled = false;

                //    //else
                //    //{

                //    //    Global.Mdhere--;
                //    //    Log.Logstring += "Dan Dewey DONE: " + DateTime.Now.ToString() + "\n";
                //    //    DeweyArrivalButton.Enabled = false;
                //    //    Global.DanDewey = DateTime.Now;
                //    //    DeweyArrivalButton.Text = "DONE";     
                //    //    TextBox3.Text = Global.DanDewey.ToString("HHmm") + "hrs";
                //    //    TextBox3.BackColor = System.Drawing.Color.Red;

                //  }
                //}
            }
       }

        protected void JoseArrivalButton_Click(object sender, EventArgs e)
        {

            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                if (Global.JoseDundeeStatus != null)
                    Global.MDrespond--;
                Global.Mdhere++;
                Global.JoseDundeeStatus = "Here";
                Global.JoseDundee = DateTime.Now;
                JoseArrivalButton.Enabled = false;
                Log.Logstring += "Jose Dundee Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox4.BackColor = System.Drawing.Color.Yellow;
             //   Global.MDrespond--;
                CheckJoseDundeeStatus();
                Response.Redirect("index.aspx");
                //if (Global.ArrivejoseDundee)
                //{
                //    Global.Mdhere--;
                //    JoseArrivalButton.Text = "DONE";
                //    JoseArrivalButton.Enabled = false;
                //    Global.JoseDundee = DateTime.Now;
                //    TextBox4.Text = Global.JoseDundee.ToString("HHmm") + "hrs";
                //    TextBox4.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Jose Dundee Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivejoseDundee = false;
                //}
                //else
                //{
                //    Global.Mdhere++;
                //    Global.MDrespond--;
                //    Log.Logstring += "Jose Dundee Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.JoseDundee = DateTime.Now;
                //    TextBox4.Text = Global.JoseDundee.ToString("HHmm") + "hrs";
                //    TextBox4.BackColor = System.Drawing.Color.WhiteSmoke;
                //    JoseArrivalButton.Text = "HERE";
                //    JoseArrivalButton.Enabled = false;
                //    Global.ArrivejoseDundee = true;
                //}
            }
        }
        protected void SDundeeARrivalButton_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivesarahDundee)
                //{
                //    Global.Mdhere--;
                //    SDundeeARrivalButton.Text = "DONE";
                //    SDundeeARrivalButton.Enabled = false;
                //    Global.SarahDundee = DateTime.Now;
                //    TextBox5.Text = Global.SarahDundee.ToString("HHmm") + "hrs";
                //    TextBox5.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Sarah Dundee Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivesarahDundee = false;
                //}
                //else
                //{
                //    Global.Mdhere++;
                //    Global.MDrespond--;
                //    Log.Logstring += "Sarah Dundee Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.SarahDundee = DateTime.Now;
                //    TextBox5.Text = Global.SarahDundee.ToString("HHmm") + "hrs";
                //    TextBox5.BackColor = System.Drawing.Color.WhiteSmoke;
                //    SDundeeARrivalButton.Text = "HERE";
                //    // SDundeeARrivalButton.Enabled = false;
                //    Global.ArrivesarahDundee = true;
                //}
                if (Global.SarahDundeeStatus != null)
                    Global.MDrespond--;

                Global.Mdhere++;
                Global.SarahDundeeStatus = "Here";
                Global.SarahDundee = DateTime.Now;
                SDundeeARrivalButton.Enabled = false;
                Log.Logstring += "Sarah Dundee Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox5.BackColor = System.Drawing.Color.Yellow;
            //    Global.MDrespond--;
                CheckSarahDundeeStatus();
                Response.Redirect("index.aspx");
            }
        }
        protected void Button29_Click(object sender, EventArgs e)
        {

            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivesaraFish)
                //{
                //    Global.Mdhere--;
                //    Button29.Text = "DONE";
                //    Button29.Enabled = false;
                //    Global.SaraFish = DateTime.Now;
                //    TextBox6.Text = Global.SaraFish.ToString("HHmm") + "hrs";
                //    TextBox6.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Sara Fish Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivesaraFish = false;
                //}
                //else
                //{

                //    Global.Mdhere++;
                //    Global.MDrespond--;
                //    Log.Logstring += "Sara Fish Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.SaraFish = DateTime.Now;
                //    TextBox6.Text = Global.SaraFish.ToString("HHmm") + "hrs";
                //    TextBox6.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button29.Text = "HERE";
                //    // Button29.Enabled = false;
                //    Global.ArrivesaraFish = true;
                //}
                if (Global.SaraFishStatus != null)
                    Global.MDrespond--;
                Global.Mdhere++;
                Global.SaraFishStatus = "Here";
                Global.SaraFish = DateTime.Now;
                Button29.Enabled = false;
                Log.Logstring += "Sara Fish Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox6.BackColor = System.Drawing.Color.Yellow;
              //  Global.MDrespond--;
                CheckSaraFishStatus();
                Response.Redirect("index.aspx");
            }
        }
        protected void Button30_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArriveerinFong)
                //{
                //    Global.Mdhere--;
                //    Button30.Text = "DONE";
                //    Button30.Enabled = false;
                //    Global.ErinFong = DateTime.Now;
                //    TextBox7.Text = Global.ErinFong.ToString("HHmm") + "hrs";
                //    TextBox7.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Erin Fong Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArriveerinFong = false;
                //}
                //else
                //{

                //    Global.Mdhere++;
                //    Global.MDrespond--;
                //    Log.Logstring += "Erine Fong Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.ErinFong = DateTime.Now;
                //    TextBox7.Text = Global.SaraFish.ToString("HHmm") + "hrs";
                //    TextBox7.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button30.Text = "HERE";
                //    //Button30.Enabled = false;
                //    Global.ArriveerinFong = true;
                //}
                if (Global.ErinFongStatus != null)
                    Global.MDrespond--;
                Global.Mdhere++;
                Global.ErinFongStatus = "Here";
                Global.ErinFong = DateTime.Now;
                Button30.Enabled = false;
                Log.Logstring += "Erine Fong Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox7.BackColor = System.Drawing.Color.Yellow;
            //    Global.MDrespond--;
                CheckErinFongStatus();
                Response.Redirect("index.aspx");
            }
        }
        protected void Button31_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivemattHerold)
                //{
                //    Global.Mdhere--;
                //    Button31.Text = "DONE";
                //    Button31.Enabled = false;
                //    Global.MattHerold = DateTime.Now;
                //    TextBox8.Text = Global.MattHerold.ToString("HHmm") + "hrs";
                //    TextBox8.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Matt Herold Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivemattHerold = false;
                //}
                //else
                //{

                //    Global.Mdhere++;
                //    Global.MDrespond--;
                //    Log.Logstring += "Matt Herold Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.MattHerold = DateTime.Now;
                //    TextBox8.Text = Global.MattHerold.ToString("HHmm") + "hrs";
                //    TextBox8.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button31.Text = "HERE";
                //    //Button31.Enabled = false;
                //    Global.ArrivemattHerold = true;
                //}
                if (Global.MattHeroldStatus != null)
                    Global.MDrespond--;
                Global.Mdhere++;
                Global.MattHeroldStatus = "Here";
                Global.MattHerold = DateTime.Now;
                Button31.Enabled = false;
                Log.Logstring += "Matt Herold Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox8.BackColor = System.Drawing.Color.Yellow;
             //   Global.MDrespond--;
                CheckMattHeroldStatus();
                Response.Redirect("index.aspx");

            }

        }
        protected void Button32_Click(object sender, EventArgs e)
        {

            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivebruceHubbard)
                //{
                //    Global.Mdhere--;
                //    Button32.Text = "DONE";
                //    Button32.Enabled = false;
                //    Global.BruceHubbard = DateTime.Now;
                //    TextBox9.Text = Global.BruceHubbard.ToString("HHmm") + "hrs";
                //    TextBox9.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Bruce Hubbard Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivebruceHubbard = false;
                //}
                //else
                //{

                //    Global.MDrespond--;
                //    Global.Mdhere++;
                //    Log.Logstring += "Bruce Hubbard Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.BruceHubbard = DateTime.Now;
                //    TextBox9.Text = Global.BruceHubbard.ToString("HHmm") + "hrs";
                //    TextBox9.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button32.Text = "HERE";
                ////    Button32.Enabled = false;
                //    Global.ArrivebruceHubbard = true;
                if (Global.BruceHubbardStatus != null)
                    Global.MDrespond--;
                Global.Mdhere++;
                Global.BruceHubbardStatus = "Here";
                Global.BruceHubbard = DateTime.Now;
                Button32.Enabled = false;
                Log.Logstring += "Bruce Hubbard Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox9.BackColor = System.Drawing.Color.Yellow;
              //  Global.MDrespond--;
                CheckBruceHubbardStatus();
                Response.Redirect("index.aspx");
            
            }
        }
        protected void Button33_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivevalerieJohnson)
                //{
                //    Global.Mdhere--;
                //    Button33.Text = "DONE";
                //    Button33.Enabled = false;
                //    Global.ValerieJohnson = DateTime.Now;
                //    TextBox10.Text = Global.ValerieJohnson.ToString("HHmm") + "hrs";
                //    TextBox10.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Bruce Hubbard Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivevalerieJohnson = false;
                //}
                //else
                //{


                //    Global.Mdhere++;
                //    Global.MDrespond--;
                //    Log.Logstring += "Valerie Johnson Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.ValerieJohnson = DateTime.Now;
                //    TextBox10.Text = Global.ValerieJohnson.ToString("HHmm") + "hrs";
                //    TextBox10.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button33.Text = "HERE";
                //    //   Button33.Enabled = false;
                //    Global.ArrivevalerieJohnson = true;
                //}
                if (Global.ValerieJohnsonStatus != null)
                    Global.MDrespond--;
                Global.Mdhere++;
                Global.ValerieJohnsonStatus = "Here";
                Global.ValerieJohnson = DateTime.Now;
                Button33.Enabled = false;
                Log.Logstring += "Valerie Johnson Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox10.BackColor = System.Drawing.Color.Yellow;
             //   Global.MDrespond--;
                CheckValerieJohnsonStatus();
                Response.Redirect("index.aspx");
            }
        }

        protected void Button34_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivedaveLarson)
                //{
                //    Global.Mdhere--;
                //    Button34.Text = "DONE";
                //    Button34.Enabled = false;
                //    Global.DaveLarson = DateTime.Now;
                //    TextBox11.Text = Global.DaveLarson.ToString("HHmm") + "hrs";
                //    TextBox11.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Dave Larson Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivedaveLarson = false;
                //}
                //else
                //{

                //    Global.Mdhere++;
                //    Global.MDrespond--;
                //    Log.Logstring += "Dave Larson Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.DaveLarson = DateTime.Now;
                //    TextBox11.Text = Global.DaveLarson.ToString("HHmm") + "hrs";
                //    TextBox11.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button34.Text = "HERE";
                //    //   Button34.Enabled = false;
                //    Global.ArrivedaveLarson = true;
                //}DaveLarson  
                if (Global.DaveLarsonStatus != null)
                    Global.MDrespond--;
                Global.Mdhere++;
                Global.DaveLarsonStatus = "Here";
                Global.DaveLarson = DateTime.Now;
                Button34.Enabled = false;
                Log.Logstring += "Dave Larson Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox11.BackColor = System.Drawing.Color.Yellow;
              //  Global.MDrespond--;
                CheckDaveLarsonStatus();
                Response.Redirect("index.aspx");
            }
        }
        protected void Button35_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArriveamyOsborn)
                //{
                //    Global.Mdhere--;
                //    Button35.Text = "DONE";
                //    Button35.Enabled = false;
                //    Global.AmyOsborn = DateTime.Now;
                //    TextBox12.Text = Global.AmyOsborn.ToString("HHmm") + "hrs";
                //    TextBox12.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Amy Osborn Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArriveamyOsborn = false;
                //}
                //else
                //{

                //    Global.Mdhere++;
                //    Global.MDrespond--;
                //    Log.Logstring += "Amy Osborn Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.AmyOsborn = DateTime.Now;
                //    TextBox12.Text = Global.AmyOsborn.ToString("HHmm") + "hrs";
                //    TextBox12.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button35.Text = "HERE";
                //    //Button35.Enabled = false;
                //    GlobaAmyOsbornyOsborn = true;
                //}
                if (Global.AmyOsbornStatus != null)
                    Global.MDrespond--;
                Global.Mdhere++;
                Global.AmyOsbornStatus = "Here";
                Global.AmyOsborn = DateTime.Now;
                Button35.Enabled = false;
                Log.Logstring += "Amy Osborn Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox12.BackColor = System.Drawing.Color.Yellow;
              //  Global.MDrespond--;
                CheckAmyOsbornStatus();
                Response.Redirect("index.aspx");
            }
        }
        protected void Button36_Click(object sender, EventArgs e)
        {

            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //       if (Global.ArrivegregPeterson)
                //       {
                //           Global.Mdhere--;
                //           Button36.Text = "DONE";
                //           Button36.Enabled = false;
                //           Global.GregPeterson = DateTime.Now;
                //           TextBox13.Text = Global.GregPeterson.ToString("HHmm") + "hrs";
                //           TextBox13.BackColor = System.Drawing.Color.Red;
                //           Log.Logstring += "Greg Peterson Done: " + DateTime.Now.ToString() + "\n";
                //           Global.ArrivegregPeterson = false;
                //       }
                //       else
                //       {
                //           Global.Mdhere++;
                //           Global.MDrespond--;
                //           Log.Logstring += "Greg Peterson Arrival: " + DateTime.Now.ToString() + "\n";
                //           Global.GregPeterson = DateTime.Now;
                //           TextBox13.Text = Global.GregPeterson.ToString("HHmm") + "hrs";
                //           TextBox13.BackColor = System.Drawing.Color.WhiteSmoke;
                //           Button36.TexGregPeterson";
                ////           Button36.Enabled = false;
                //           Global.ArrivegregPeterson = true;
                //       }
                if (Global.GregPetersonStatus != null)
                    Global.MDrespond--;
                Global.Mdhere++;
                Global.GregPetersonStatus = "Here";
                Global.GregPeterson = DateTime.Now;
                Button36.Enabled = false;
                Log.Logstring += "Greg Peterson Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox13.BackColor = System.Drawing.Color.Yellow;
             //   Global.MDrespond--;
                CheckGregPetersonStatus();
                Response.Redirect("index.aspx");

            }
        }
        protected void Button37_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArriveyoSchugel)
                //{
                //    Global.Mdhere--;
                //    Button37.Text = "DONE";
                //    Button37.Enabled = false;
                //    Global.YoSchugel = DateTime.Now;
                //    TextBox14.Text = Global.YoSchugel.ToString("HHmm") + "hrs";
                //    TextBox14.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Yo Schugel Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArriveyoSchugel = false;
                //}
                //else
                //{

                //    Global.Mdhere++;
                //    Global.MDrespond--;
                //    Log.Logstring += "Yo Schugel Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.YoSchugel = DateTime.Now;
                //    TextBox14.Text = Global.YoSchugel.ToString("HHmm") + "hrs";
                //    TextBox14.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button37.Text = "HERE";
                //    //   Button37.Enabled = false;
                //    Global.ArriveyoSchugel = true;
                //}
                if (Global.YoSchugelStatus != null)
                    Global.MDrespond--;
                Global.Mdhere++;
                Global.YoSchugelStatus = "Here";
                Global.YoSchugel = DateTime.Now;
                Button37.Enabled = false;
                Log.Logstring += "Yo Schugel Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox14.BackColor = System.Drawing.Color.Yellow;
              //  Global.MDrespond--;
                CheckYoSchugelStatus();
                Response.Redirect("index.aspx");
            }
        }

        protected void Button38_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivekevinSipprell)
                //{
                //    Global.Mdhere--;
                //    Button38.Text = "DONE";
                //    Button38.Enabled = false;
                //    Global.KevinSipprell = DateTime.Now;
                //    TextBox15.Text = Global.KevinSipprell.ToString("HHmm") + "hrs";
                //    TextBox15.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Kevin Sipprell Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivekevinSipprell = false;
                //}
                //else
                //{
                //    Global.Mdhere++;
                //    Global.MDrespond--;
                //    Log.Logstring += "Kevin Sipprell Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.KevinSipprell = DateTime.Now;
                //    TextBox15.Text = Global.KevinSipprell.ToString("HHmm") + "hrs";
                //    TextBox15.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button38.Text = "HERE";
                //    //Button38.Enabled = false;
                //    Global.ArrivekevinSipprell = true;
                //}
                if (Global.KevinSipprellStatus != null)
                    Global.MDrespond--;
                Global.Mdhere++;
                Global.KevinSipprellStatus = "Here";
                Global.KevinSipprell = DateTime.Now;
                Button38.Enabled = false;
                Log.Logstring += "Kevin Sipprell Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox15.BackColor = System.Drawing.Color.Yellow;
             //   Global.MDrespond--;
                CheckKevinSipprellStatus();
                Response.Redirect("index.aspx");
            }
        }

        protected void Button39_Click(object sender, EventArgs e)
        {

            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArriveemilyAnderson)
                //{
                //    Global.PAhere--;
                //    Button39.Text = "DONE";
                //    Button39.Enabled = false;
                //    Global.EmilyAnderson = DateTime.Now;
                //    TextBox16.Text = Global.EmilyAnderson.ToString("HHmm") + "hrs";
                //    TextBox16.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Emily Anderson Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArriveemilyAnderson = false;
                //}
                //else
                //{
                //    Global.PAhere++;
                //    Global.PArespond--;
                //    Log.Logstring += "Emily Anderson Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.EmilyAnderson = DateTime.Now;
                //    TextBox16.Text = Global.EmilyAnderson.ToString("HHmm") + "hrs";
                //    TextBox16.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button39.Text = "HERE";
                //    //    Button39.Enabled = false;
                //    Global.ArriveemilyAnderson = true;
                //}
                if (Global.EmilyAndersonStatus != null)
                    Global.PArespond--;
                Global.PAhere++;
                Global.EmilyAndersonStatus = "Here";
                Global.EmilyAnderson = DateTime.Now;
                Button39.Enabled = false;
                Log.Logstring += "Emily Anderson Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox16.BackColor = System.Drawing.Color.Yellow;
             //   Global.PArespond--;
                CheckEmilyAndersonStatus();
                Response.Redirect("index.aspx");
            }
        }

        protected void Button40_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivejerodBarnes)
                //{
                //    Global.PAhere--;
                //    Button40.Text = "DONE";
                //    Button40.Enabled = false;
                //    Global.JerodBarnes = DateTime.Now;
                //    TextBox17.Text = Global.JerodBarnes.ToString("HHmm") + "hrs";
                //    TextBox17.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Jerod Barnes Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivejerodBarnes = false;
                //}
                //else
                //{

                //    Global.PAhere++;
                //    Global.PArespond--;
                //    Log.Logstring += "Jerod Barnes Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.JerodBarnes = DateTime.Now;
                //    TextBox17.Text = Global.JerodBarnes.ToString("HHmm") + "hrs";
                //    TextBox17.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button40.Text = "HERE";
                //    //   Button40.Enabled = false;
                //    Global.ArrivejerodBarnes = true;
                //}
                if (Global.JerodBarnesStatus != null)
                    Global.PArespond--;
                Global.PAhere++;
                Global.JerodBarnesStatus = "Here";
                Global.JerodBarnes = DateTime.Now;
                Button40.Enabled = false;
                Log.Logstring += "Jerod Barnes Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox17.BackColor = System.Drawing.Color.Yellow;
           //     Global.PArespond--;
                CheckJerodBarnesStatus();
                Response.Redirect("index.aspx");
            }
        }
        protected void Button41_Click(object sender, EventArgs e)
        {

            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArriveerinBischoff)
                //{
                //    Global.PAhere--;
                //    Button41.Text = "DONE";
                //    Button41.Enabled = false;
                //    Global.ErinBischoff = DateTime.Now;
                //    TextBox18.Text = Global.ErinBischoff.ToString("HHmm") + "hrs";
                //    TextBox18.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Erin Bischoff Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArriveerinBischoff = false;
                //}
                //else
                //{
                //    Global.PAhere++;
                //    Global.PArespond--;
                //    Log.Logstring += "Erin Bischoff Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.ErinBischoff = DateTime.Now;
                //    TextBox18.Text = Global.ErinBischoff.ToString("HHmm") + "hrs";
                //    TextBox18.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button41.Text = "HERE";
                //    // Button41.Enabled = false;
                //    Global.ArriveerinBischoff = true;
                //}
                if (Global.ErinBischoffStatus != null)
                    Global.PArespond--;
                Global.PAhere++;
                Global.ErinBischoffStatus = "Here";
                Global.ErinBischoff = DateTime.Now;
                Button41.Enabled = false;
                Log.Logstring += "Erin Bischoff Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox18.BackColor = System.Drawing.Color.Yellow;
            //    Global.PArespond--;
                CheckErinBischoffStatus();
                Response.Redirect("index.aspx");
            }
        }

        protected void Button42_Click(object sender, EventArgs e)
        {

            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivefredDemeuse)
                //{
                //    Global.PAhere--;
                //    Button42.Text = "DONE";
                //    Button42.Enabled = false;
                //    Global.FredDemeuse = DateTime.Now;
                //    TextBox19.Text = Global.FredDemeuse.ToString("HHmm") + "hrs";
                //    TextBox19.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Fred DeMeuse Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivefredDemeuse = false;
                //}
                //else
                //{
                //    Global.PAhere++;
                //    Global.PArespond--;
                //    Log.Logstring += "Fred DeMeuse Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.FredDemeuse = DateTime.Now;
                //    TextBox19.Text = Global.FredDemeuse.ToString("HHmm") + "hrs";
                //    TextBox19.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button42.Text = "HERE";
                //    //  Button42.Enabled = false;
                //    Global.ArrivefredDemeuse = true;
                //}
                if (Global.FredDemeuseStatus != null)
                    Global.PArespond--;
                Global.PAhere++;
                Global.FredDemeuseStatus = "Here";
                Global.FredDemeuse = DateTime.Now;
                Button42.Enabled = false;
                Log.Logstring += "Fred DeMeuse Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox19.BackColor = System.Drawing.Color.Yellow;
              //  Global.PArespond--;
                CheckFredDemeuseStatus();
                Response.Redirect("index.aspx");
            }
        }

        protected void Button43_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivechelseaErnisse)
                //{
                //    Global.PAhere--;
                //    Button43.Text = "DONE";
                //    Button43.Enabled = false;
                //    Global.ChelseaErnisse = DateTime.Now;
                //    TextBox20.Text = Global.ChelseaErnisse.ToString("HHmm") + "hrs";
                //    TextBox20.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Chelsea Eernisse Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivechelseaErnisse = false;
                //}
                //else
                //{

                //    Global.PAhere++;
                //    Global.PArespond--;
                //    Log.Logstring += "Chelsea Eernisse Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.ChelseaErnisse = DateTime.Now;
                //    TextBox20.Text = Global.ChelseaErnisse.ToString("HHmm") + "hrs";
                //    TextBox20.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button43.Text = "HERE";
                //    //   Button43.Enabled = false;
                //    Global.ArrivechelseaErnisse = true;
                //}
                if (Global.ChelseaErnisseStatus != null)
                    Global.PArespond--;
                Global.PAhere++;
                Global.ChelseaErnisseStatus = "Here";
                Global.ChelseaErnisse = DateTime.Now;
                Button43.Enabled = false;
                Log.Logstring += "Chelsea Eernisse Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox20.BackColor = System.Drawing.Color.Yellow;
             //   Global.PArespond--;
                CheckChelseaErnisseStatus();
                Response.Redirect("index.aspx");
            }
        }

        protected void Button44_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArriveallisonEngelsma)
                //{
                //    Global.PAhere--;
                //    Button44.Text = "DONE";
                //    Button44.Enabled = false;
                //    Global.AllisonEngelsma = DateTime.Now;
                //    TextBox21.Text = Global.AllisonEngelsma.ToString("HHmm") + "hrs";
                //    TextBox21.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Alli Engelsma Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArriveallisonEngelsma = false;
                //}
                //else
                //{


                //    Global.PAhere++;
                //    Global.PArespond--;
                //    Log.Logstring += "Alli Engelsma Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.AllisonEngelsma = DateTime.Now;
                //    TextBox21.Text = Global.AllisonEngelsma.ToString("HHmm") + "hrs";
                //    TextBox21.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button44.Text = "HERE";
                //    //   Button44.Enabled = false;
                //    Global.ArriveallisonEngelsma = true;
                //}
                if (Global.AllisonEngelsmaStatus != null)
                    Global.PArespond--;
                Global.PAhere++;
                Global.AllisonEngelsmaStatus = "Here";
                Global.AllisonEngelsma = DateTime.Now;
                Button44.Enabled = false;
                Log.Logstring += "Alli Engelsma Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox21.BackColor = System.Drawing.Color.Yellow;
            //    Global.PArespond--;
                CheckAlliEngelsmaStatus();
                Response.Redirect("index.aspx");
            }
        }

        protected void Button45_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivebradyGriffith)
                //{
                //    Global.PAhere--;
                //    Button45.Text = "DONE";
                //    Button45.Enabled = false;
                //    Global.BradyGriffith = DateTime.Now;
                //    TextBox22.Text = Global.BradyGriffith.ToString("HHmm") + "hrs";
                //    TextBox22.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Brady Griffith Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivebradyGriffith = false;
                //}
                //else
                //{
                //    Global.PAhere++;
                //    Global.PArespond--;
                //    Log.Logstring += "Brady Griffith Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.BradyGriffith = DateTime.Now;
                //    TextBox22.Text = Global.BradyGriffith.ToString("HHmm") + "hrs";
                //    TextBox22.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button45.Text = "HERE";
                //    //Button45.Enabled = false;
                //    Global.ArrivebradyGriffith = true;
                //}
                if (Global.BradyGriffithStatus != null)
                    Global.PArespond--;
                Global.PAhere++;
                Global.BradyGriffithStatus = "Here";
                Global.BradyGriffith = DateTime.Now;
                Button45.Enabled = false;
                Log.Logstring += "Brady Griffith Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox22.BackColor = System.Drawing.Color.Yellow;
              //  Global.PArespond--;
                CheckBradyGriffithStatus();
                Response.Redirect("index.aspx");
            }
        }

        protected void Button46_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivejasonHicks)
                //{
                //    Global.PAhere--;
                //    Button46.Text = "DONE";
                //    Button46.Enabled = false;
                //    Global.JasonHicks = DateTime.Now;
                //    TextBox23.Text = Global.JasonHicks.ToString("HHmm") + "hrs";
                //    TextBox23.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Jason Hicks Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivejasonHicks = false;
                //}
                //else
                //{
                //    Global.PAhere++;
                //    Global.PArespond--;
                //    Log.Logstring += "Jason Hicks Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.JasonHicks = DateTime.Now;
                //    TextBox23.Text = Global.JasonHicks.ToString("HHmm") + "hrs";
                //    TextBox23.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button46.Text = "HERE";
                //    //  Button46.Enabled = false;
                //    Global.ArrivejasonHicks = true;
                //}
                if (Global.JasonHicksStatus != null)
                    Global.PArespond--;
                Global.PAhere++;
                Global.JasonHicksStatus = "Here";
                Global.JasonHicks = DateTime.Now;
                Button46.Enabled = false;
                Log.Logstring += "Jason Hicks Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox23.BackColor = System.Drawing.Color.Yellow;
              //  Global.PArespond--;
                CheckJasonHicksStatus();
                Response.Redirect("index.aspx");
            }
        }
        protected void Button47_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivelisaLarson)
                //{
                //    Global.PAhere--;
                //    Button47.Text = "DONE";
                //    Button47.Enabled = false;
                //    Global.LisaLarson = DateTime.Now;
                //    TextBox24.Text = Global.LisaLarson.ToString("HHmm") + "hrs";
                //    TextBox24.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Lisa Larson Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivelisaLarson = false;
                //}
                //else
                //{
                //    Global.PAhere++;
                //    Global.PArespond--;
                //    Log.Logstring += "Lisa Larson Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.LisaLarson = DateTime.Now;
                //    TextBox24.Text = Global.LisaLarson.ToString("HHmm") + "hrs";
                //    TextBox24.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button47.Text = "HERE";
                //    //    Button47.Enabled = false;
                //    Global.ArrivelisaLarson = true;
                //}
                if (Global.LisaLarsonStatus != null)
                    Global.PArespond--;
                Global.PAhere++;
                Global.LisaLarsonStatus = "Here";
                Global.LisaLarson = DateTime.Now;
                Button47.Enabled = false;
                Log.Logstring += "Lisa Larson Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox24.BackColor = System.Drawing.Color.Yellow;
            //    Global.PArespond--;
                CheckLisaLarsonStatus();
                Response.Redirect("index.aspx");
            }

        }
        protected void Button48_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArrivebethRadke)
                //{
                //    Global.PAhere--;
                //    Button48.Text = "DONE";
                //    Button48.Enabled = false;
                //    Global.BethRadke = DateTime.Now;
                //    TextBox25.Text = Global.BethRadke.ToString("HHmm") + "hrs";
                //    TextBox25.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Beth Radke Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArrivebethRadke = false;
                //}
                //else
                //{

                //    Global.PAhere++;
                //    Global.PArespond--;
                //    Log.Logstring += "Beth Radke Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.BethRadke = DateTime.Now;
                //    TextBox25.Text = Global.BethRadke.ToString("HHmm") + "hrs";
                //    TextBox25.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button48.Text = "HERE";
                //    //   Button48.Enabled = false;
                //    Global.ArrivebethRadke = true;
                //}
                if (Global.BethRadkeStatus != null)
                    Global.PArespond--;
                Global.PAhere++;
                Global.BethRadkeStatus = "Here";
                Global.BethRadke = DateTime.Now;
                Button48.Enabled = false;
                Log.Logstring += "Beth Radke Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox25.BackColor = System.Drawing.Color.Yellow;
             //   Global.PArespond--;
                CheckBethRadkeStatus();
                Response.Redirect("index.aspx");
            }
        }
        protected void Button49_Click(object sender, EventArgs e)
        {
            //if (!IsPageRefresh)// prevent page refresh from tiggering again
            //{
            //    if (Global.ArrivetamrahTenhaeff)
            //    {
            //        Global.PAhere--;
            //        Button49.Text = "DONE";
            //        Button49.Enabled = false;
            //        Global.TamrahTenhaeff = DateTime.Now;
            //        TextBox26.Text = Global.TamrahTenhaeff.ToString("HHmm") + "hrs";
            //        TextBox26.BackColor = System.Drawing.Color.Red;
            //        Log.Logstring += "Tamrah Tenhaeff Done: " + DateTime.Now.ToString() + "\n";
            //        Global.ArrivetamrahTenhaeff = false;
            //    }
            //    else
            //    {

            //        Global.PAhere++;
            //        Global.PArespond--;
            //        Log.Logstring += "Tamrah Tenhaeff Arrival: " + DateTime.Now.ToString() + "\n";
            //        Global.TamrahTenhaeff = DateTime.Now;
            //        TextBox26.Text = Global.TamrahTenhaeff.ToString("HHmm") + "hrs";
            //        TextBox26.BackColor = System.Drawing.Color.WhiteSmoke;
            //        Button49.Text = "HERE";
            //        //  Button49.Enabled = false;
            //        Global.ArrivetamrahTenhaeff = true;
            //    }
            if (Global.TamrahTenhaeffStatus != null)
                Global.PArespond--;
            Global.PAhere++;
            Global.TamrahTenhaeffStatus = "Here";
            Global.TamrahTenhaeff = DateTime.Now;
            Button49.Enabled = false;
            Log.Logstring += "Tamrah Tenhaeff Arrived: " + DateTime.Now.ToString() + "\n";
            TextBox26.BackColor = System.Drawing.Color.Yellow;
         //   Global.PArespond--;
            CheckTamrahTenhaeffStatus();
            Response.Redirect("index.aspx");
        
        }
        protected void Button50_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                //if (Global.ArriveerinnVonRein)
                //{
                //    Global.PAhere--;
                //    Button50.Text = "DONE";
                //    Button50.Enabled = false;
                //    Global.ErinnVonRein = DateTime.Now;
                //    TextBox27.Text = Global.ErinnVonRein.ToString("HHmm") + "hrs";
                //    TextBox27.BackColor = System.Drawing.Color.Red;
                //    Log.Logstring += "Erinn VonRein Done: " + DateTime.Now.ToString() + "\n";
                //    Global.ArriveerinnVonRein = false;
                //}
                //else
                //{

                //    Global.PAhere++;
                //    Global.PArespond--;
                //    Log.Logstring += "Erinn vonRein Arrival: " + DateTime.Now.ToString() + "\n";
                //    Global.ErinnVonRein = DateTime.Now;
                //    TextBox27.Text = Global.ErinnVonRein.ToString("HHmm") + "hrs";
                //    TextBox27.BackColor = System.Drawing.Color.WhiteSmoke;
                //    Button50.Text = "HERE";
                //    //  Button50.Enabled = false;
                //    Global.ArriveerinnVonRein = true;
                //}
                if (Global.ErinnVonReinStatus != null)
                    Global.PArespond--;
                Global.PAhere++;
                Global.ErinnVonReinStatus = "Here";
                Global.ErinnVonRein = DateTime.Now;
                Button50.Enabled = false;
                Log.Logstring += "Erinn VonRein Arrived: " + DateTime.Now.ToString() + "\n";
                TextBox27.BackColor = System.Drawing.Color.Yellow;
             //   Global.PArespond--;
                CheckErinnVonReinStatus();
                Response.Redirect("index.aspx");
            }
        }

        protected void Button51_Click(object sender, EventArgs e)
        {
            Global.Reset();
            CleartextBoxes(Page);
            DisplayETA();
            SetBackColor(Page);
            //    Response.Redirect("index.apsx");

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
        public void CheckKarenAndersonStatus()
        {
            if (Global.KarenAndersonStatus == null)
                return;

            if (Global.KarenAndersonStatus == "Enroute")
            {
                TimeSpan diff = (Global.KarenAnderson.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox1.Text = diff.ToString("mm");
                else
                    TextBox1.Text = "-" + diff.ToString("mm");
            }
            else if (Global.KarenAndersonStatus == "Here")
            {
                TextBox1.Text = Global.KarenAnderson.ToString("HHmm") + ("hrs");
                TextBox1.BackColor = System.Drawing.Color.Yellow;
                Button28.Text = Global.KarenAndersonStatus;
                Button28.Enabled = false;
            }
            else if (Global.KarenAndersonStatus == "Done")
            {
                TextBox1.BackColor = System.Drawing.Color.Red;
                TextBox1.Text = Global.KarenAnderson.ToString("HHmm") + ("hrs");
                Button52.Text = Global.KarenAndersonStatus;
                Button52.Enabled = false;
                Button28.Text = Global.KarenAndersonStatus;
                Button28.Enabled = false;
            }
        }
        protected void Button52_Click(object sender, EventArgs e) // KA done
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {
                
                Global.KarenAndersonStatus = "Done";
                Global.KarenAnderson = DateTime.Now;
                Log.Logstring += "Karen Anderson Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckKarenAndersonStatus();
                Response.Redirect("index.aspx");
            
            }
        }
        public void CheckLaresaDeboerStatus()
        {
            if (Global.LaresaDeboerStatus == null)
                return;

            if (Global.LaresaDeboerStatus == "Enroute")
            {
                TimeSpan diff = (Global.LaresaDeboer.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox2.Text = diff.ToString("mm");
                else
                    TextBox2.Text = "-" + diff.ToString("mm");
            }
            else if (Global.LaresaDeboerStatus == "Here")
            {
                TextBox2.Text = Global.LaresaDeboer.ToString("HHmm") + ("hrs");
                TextBox2.BackColor = System.Drawing.Color.Yellow;
                LaresaArrivalButton.Text = Global.LaresaDeboerStatus;
                LaresaArrivalButton.Enabled = false;
            }
            else if (Global.KarenAndersonStatus == "Done")
            {
                TextBox2.BackColor = System.Drawing.Color.Red;
                TextBox2.Text = Global.LaresaDeboer.ToString("HHmm") + ("hrs");
                Button1.Text = Global.LaresaDeboerStatus;
                Button1.Enabled = false;
                LaresaArrivalButton.Text = Global.LaresaDeboerStatus;
                LaresaArrivalButton.Enabled = false;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.LaresaDeboerStatus = "Done";
                Global.LaresaDeboer = DateTime.Now;
                Log.Logstring += "Laresa DeBoer Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckLaresaDeboerStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckDanDeweyStatus()
        {
            if (Global.DanDeweyStatus == null)
                return;

            if (Global.DanDeweyStatus == "Enroute")
            {
                TimeSpan diff = (Global.DanDewey.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox3.Text = diff.ToString("mm");
                else
                    TextBox3.Text = "-" + diff.ToString("mm");
            }
            else if (Global.DanDeweyStatus == "Here")
            {
                TextBox3.Text = Global.DanDewey.ToString("HHmm") + ("hrs");
                TextBox3.BackColor = System.Drawing.Color.Yellow;
                DeweyArrivalButton.Text = Global.DanDeweyStatus;
                DeweyArrivalButton.Enabled = false;
            }
            else if (Global.DanDeweyStatus == "Done")
            {
                TextBox3.BackColor = System.Drawing.Color.Red;
                TextBox3.Text = Global.DanDewey.ToString("HHmm") + ("hrs");
                Button2.Text = Global.DanDeweyStatus;
                Button2.Enabled = false;
                DeweyArrivalButton.Text = Global.DanDeweyStatus;
                DeweyArrivalButton.Enabled = false;
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.DanDeweyStatus = "Done";
                Global.DanDewey = DateTime.Now;
                Log.Logstring += "Dan Dewey Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckDanDeweyStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckJoseDundeeStatus()
        {
            if (Global.JoseDundeeStatus == null)
                return;

            if (Global.JoseDundeeStatus == "Enroute")
            {
                TimeSpan diff = (Global.JoseDundee.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox4.Text = diff.ToString("mm");
                else
                    TextBox4.Text = "-" + diff.ToString("mm");
            }
            else if (Global.JoseDundeeStatus == "Here")
            {
                TextBox4.Text = Global.JoseDundee.ToString("HHmm") + ("hrs");
                TextBox4.BackColor = System.Drawing.Color.Yellow;
                JoseArrivalButton.Text = Global.JoseDundeeStatus;
                JoseArrivalButton.Enabled = false;
            }
            else if (Global.JoseDundeeStatus == "Done")
            {
                TextBox4.BackColor = System.Drawing.Color.Red;
                TextBox4.Text = Global.JoseDundee.ToString("HHmm") + ("hrs");
                Button3.Text = Global.JoseDundeeStatus;
                Button3.Enabled = false;
                JoseArrivalButton.Text = Global.JoseDundeeStatus;
                JoseArrivalButton.Enabled = false;
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.JoseDundeeStatus = "Done";
                Global.JoseDundee= DateTime.Now;
                Log.Logstring += "Jose Dundee Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckJoseDundeeStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckSarahDundeeStatus()
        {
            if (Global.SarahDundeeStatus == null)
                return;

            if (Global.SarahDundeeStatus == "Enroute")
            {
                TimeSpan diff = (Global.SarahDundee.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox5.Text = diff.ToString("mm");
                else
                    TextBox5.Text = "-" + diff.ToString("mm");
            }
            else if (Global.SarahDundeeStatus == "Here")
            {
                TextBox5.Text = Global.SarahDundee.ToString("HHmm") + ("hrs");
                TextBox5.BackColor = System.Drawing.Color.Yellow;
                SDundeeARrivalButton.Text = Global.SarahDundeeStatus;
                SDundeeARrivalButton.Enabled = false;
            }
            else if (Global.SarahDundeeStatus == "Done")
            {
                TextBox5.BackColor = System.Drawing.Color.Red;
                TextBox5.Text = Global.SarahDundee.ToString("HHmm") + ("hrs");
                Button4.Text = Global.SarahDundeeStatus;
                Button4.Enabled = false;
                SDundeeARrivalButton.Text = Global.SarahDundeeStatus;
                SDundeeARrivalButton.Enabled = false;
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.SarahDundeeStatus = "Done";
                Global.SarahDundee = DateTime.Now;
                Log.Logstring += "Sarah Dundee Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckSarahDundeeStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckSaraFishStatus()
        {
            if (Global.SaraFishStatus == null)
                return;

            if (Global.SaraFishStatus == "Enroute")
            {
                TimeSpan diff = (Global.SaraFish.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox6.Text = diff.ToString("mm");
                else
                    TextBox6.Text = "-" + diff.ToString("mm");
            }
            else if (Global.SaraFishStatus == "Here")
            {
                TextBox6.Text = Global.SaraFish.ToString("HHmm") + ("hrs");
                TextBox6.BackColor = System.Drawing.Color.Yellow;
                Button29.Text = Global.SaraFishStatus;
                Button29.Enabled = false;
            }
            else if (Global.SaraFishStatus == "Done")
            {
                TextBox6.BackColor = System.Drawing.Color.Red;
                TextBox6.Text = Global.SaraFish.ToString("HHmm") + ("hrs");
                Button5.Text = Global.SaraFishStatus;
                Button5.Enabled = false;
                Button29.Text = Global.SaraFishStatus;
                Button29.Enabled = false;
            }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.SaraFishStatus = "Done";
                Global.SaraFish = DateTime.Now;
                Log.Logstring += "Sara Fish Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckSaraFishStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckErinFongStatus()
        {
            if (Global.ErinFongStatus == null)
                return;

            if (Global.ErinFongStatus == "Enroute")
            {
                TimeSpan diff = (Global.ErinFong.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox7.Text = diff.ToString("mm");
                else
                    TextBox7.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ErinFongStatus == "Here")
            {
                TextBox7.Text = Global.ErinFong.ToString("HHmm") + ("hrs");
                TextBox7.BackColor = System.Drawing.Color.Yellow;
                Button30.Text = Global.ErinFongStatus;
                Button30.Enabled = false;
            }
            else if (Global.ErinFongStatus == "Done")
            {
                TextBox7.BackColor = System.Drawing.Color.Red;
                TextBox7.Text = Global.ErinFong.ToString("HHmm") + ("hrs");
                Button6.Text = Global.ErinFongStatus;
                Button6.Enabled = false;
                Button30.Text = Global.ErinFongStatus;
                Button30.Enabled = false;
            }
        }
     
        protected void Button6_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.ErinFongStatus = "Done";
                Global.ErinFong = DateTime.Now;
                Log.Logstring += "Erine Fong Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckErinFongStatus();
                Response.Redirect("index.aspx");

            }
        }
       
        public void CheckMattHeroldStatus()
        {
            if (Global.MattHeroldStatus == null)
                return;

            if (Global.MattHeroldStatus == "Enroute")
            {
                TimeSpan diff = (Global.MattHerold.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox8.Text = diff.ToString("mm");
                else
                    TextBox8.Text = "-" + diff.ToString("mm");
            }
            else if (Global.MattHeroldStatus == "Here")
            {
                TextBox8.Text = Global.MattHerold.ToString("HHmm") + ("hrs");
                TextBox8.BackColor = System.Drawing.Color.Yellow;
                Button31.Text = Global.MattHeroldStatus;
                Button31.Enabled = false;
            }
            else if (Global.MattHeroldStatus == "Done")
            {
                TextBox8.BackColor = System.Drawing.Color.Red;
                TextBox8.Text = Global.MattHerold.ToString("HHmm") + ("hrs");
                Button7.Text = Global.MattHeroldStatus;
                Button7.Enabled = false;
                Button31.Text = Global.MattHeroldStatus;
                Button31.Enabled = false;
            }
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.MattHeroldStatus = "Done";
                Global.MattHerold = DateTime.Now;
                Log.Logstring += "Matt Herold Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckMattHeroldStatus();
                Response.Redirect("index.aspx");

            }
        }
       
        public void CheckBruceHubbardStatus()
        {
            if (Global.BruceHubbardStatus == null)
                return;

            if (Global.BruceHubbardStatus == "Enroute")
            {
                TimeSpan diff = (Global.BruceHubbard.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox9.Text = diff.ToString("mm");
                else
                    TextBox9.Text = "-" + diff.ToString("mm");
            }
            else if (Global.BruceHubbardStatus == "Here")
            {
                TextBox9.Text = Global.BruceHubbard.ToString("HHmm") + ("hrs");
                TextBox9.BackColor = System.Drawing.Color.Yellow;
                Button32.Text = Global.BruceHubbardStatus;
                Button32.Enabled = false;
            }
            else if (Global.BruceHubbardStatus == "Done")
            {
                TextBox9.BackColor = System.Drawing.Color.Red;
                TextBox9.Text = Global.BruceHubbard.ToString("HHmm") + ("hrs");
                Button8.Text = Global.BruceHubbardStatus;
                Button8.Enabled = false;
                Button32.Text = Global.BruceHubbardStatus;
                Button32.Enabled = false;
            }
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.BruceHubbardStatus = "Done";
                Global.BruceHubbard = DateTime.Now;
                Log.Logstring += "Bruce Hubbard Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckBruceHubbardStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckValerieJohnsonStatus()
        {
            if (Global.ValerieJohnsonStatus == null)
                return;

            if (Global.ValerieJohnsonStatus == "Enroute")
            {
                TimeSpan diff = (Global.ValerieJohnson.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox10.Text = diff.ToString("mm");
                else
                    TextBox10.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ValerieJohnsonStatus == "Here")
            {
                TextBox10.Text = Global.ValerieJohnson.ToString("HHmm") + ("hrs");
                TextBox10.BackColor = System.Drawing.Color.Yellow;
                Button33.Text = Global.ValerieJohnsonStatus;
                Button33.Enabled = false;
            }
            else if (Global.ValerieJohnsonStatus == "Done")
            {
                TextBox10.BackColor = System.Drawing.Color.Red;
                TextBox10.Text = Global.ValerieJohnson.ToString("HHmm") + ("hrs");
                Button9.Text = Global.ValerieJohnsonStatus;
                Button9.Enabled = false;
                Button33.Text = Global.ValerieJohnsonStatus;
                Button33.Enabled = false;
            }
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
         if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.ValerieJohnsonStatus = "Done";
                Global.ValerieJohnson = DateTime.Now;
                Log.Logstring += "Valerie Johnson Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckValerieJohnsonStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckDaveLarsonStatus()
        {
            if (Global.DaveLarsonStatus == null)
                return;

            if (Global.DaveLarsonStatus == "Enroute")
            {
                TimeSpan diff = (Global.DaveLarson.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox11.Text = diff.ToString("mm");
                else
                    TextBox11.Text = "-" + diff.ToString("mm");
            }
            else if (Global.DaveLarsonStatus == "Here")
            {
                TextBox11.Text = Global.DaveLarson.ToString("HHmm") + ("hrs");
                TextBox11.BackColor = System.Drawing.Color.Yellow;
                Button34.Text = Global.DaveLarsonStatus;
                Button34.Enabled = false;
            }
            else if (Global.DaveLarsonStatus == "Done")
            {
                TextBox11.BackColor = System.Drawing.Color.Red;
                TextBox11.Text = Global.DaveLarson.ToString("HHmm") + ("hrs");
                Button10.Text = Global.DaveLarsonStatus;
                Button10.Enabled = false;
                Button34.Text = Global.DaveLarsonStatus;
                Button34.Enabled = false;
            }
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
             if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.DaveLarsonStatus = "Done";
                Global.DaveLarson = DateTime.Now;
                Log.Logstring += "Dave Larson Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckDaveLarsonStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckAmyOsbornStatus()
        {
            if (Global.AmyOsbornStatus == null)
                return;

            if (Global.AmyOsbornStatus == "Enroute")
            {
                TimeSpan diff = (Global.AmyOsborn.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox12.Text = diff.ToString("mm");
                else
                    TextBox12.Text = "-" + diff.ToString("mm");
            }
            else if (Global.AmyOsbornStatus == "Here")
            {
                TextBox12.Text = Global.AmyOsborn.ToString("HHmm") + ("hrs");
                TextBox12.BackColor = System.Drawing.Color.Yellow;
                Button35.Text = Global.AmyOsbornStatus;
                Button35.Enabled = false;
            }
            else if (Global.AmyOsbornStatus == "Done")
            {
                TextBox12.BackColor = System.Drawing.Color.Red;
                TextBox12.Text = Global.AmyOsborn.ToString("HHmm") + ("hrs");
                Button11.Text = Global.AmyOsbornStatus;
                Button11.Enabled = false;
                Button35.Text = Global.AmyOsbornStatus;
                Button35.Enabled = false;
            }
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.AmyOsbornStatus = "Done";
                Global.AmyOsborn = DateTime.Now;
                Log.Logstring += "Amy Osborn Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckAmyOsbornStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckGregPetersonStatus()
        { 
            if (Global.GregPetersonStatus == null)
                return;

            if (Global.GregPetersonStatus == "Enroute")
            {
                TimeSpan diff = (Global.GregPeterson.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox13.Text = diff.ToString("mm");
                else
                    TextBox13.Text = "-" + diff.ToString("mm");
            }
            else if (Global.GregPetersonStatus == "Here")
            {
                TextBox13.Text = Global.GregPeterson.ToString("HHmm") + ("hrs");
                TextBox13.BackColor = System.Drawing.Color.Yellow;
                Button36.Text = Global.GregPetersonStatus;
                Button36.Enabled = false;
            }
            else if (Global.GregPetersonStatus == "Done")
            {
                TextBox13.BackColor = System.Drawing.Color.Red;
                TextBox13.Text = Global.GregPeterson.ToString("HHmm") + ("hrs");
                Button12.Text = Global.GregPetersonStatus;
                Button12.Enabled = false;
                Button36.Text = Global.GregPetersonStatus;
                Button36.Enabled = false;
            }
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.GregPetersonStatus = "Done";
                Global.GregPeterson = DateTime.Now;
                Log.Logstring += "Greg Peterson Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckGregPetersonStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckYoSchugelStatus()
        {
            if (Global.YoSchugelStatus == null)
                return;

            if (Global.YoSchugelStatus == "Enroute")
            {
                TimeSpan diff = (Global.YoSchugel.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox14.Text = diff.ToString("mm");
                else
                    TextBox14.Text = "-" + diff.ToString("mm");
            }
            else if (Global.YoSchugelStatus == "Here")
            {
                TextBox14.Text = Global.YoSchugel.ToString("HHmm") + ("hrs");
                TextBox14.BackColor = System.Drawing.Color.Yellow;
                Button37.Text = Global.YoSchugelStatus;
                Button37.Enabled = false;
            }
            else if (Global.YoSchugelStatus == "Done")
            {
                TextBox14.BackColor = System.Drawing.Color.Red;
                TextBox14.Text = Global.YoSchugel.ToString("HHmm") + ("hrs");
                Button13.Text = Global.YoSchugelStatus;
                Button13.Enabled = false;
                Button37.Text = Global.YoSchugelStatus;
                Button37.Enabled = false;
            }
        }
        protected void Button13_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.YoSchugelStatus = "Done";
                Global.YoSchugel = DateTime.Now;
                Log.Logstring += "Yo Schugel Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckYoSchugelStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckKevinSipprellStatus()
        {
            if (Global.KevinSipprellStatus == null)
                return;

            if (Global.KevinSipprellStatus == "Enroute")
            {
                TimeSpan diff = (Global.KevinSipprell.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox15.Text = diff.ToString("mm");
                else
                    TextBox15.Text = "-" + diff.ToString("mm");
            }
            else if (Global.KevinSipprellStatus == "Here")
            {
                TextBox15.Text = Global.KevinSipprell.ToString("HHmm") + ("hrs");
                TextBox15.BackColor = System.Drawing.Color.Yellow;
                Button38.Text = Global.KevinSipprellStatus;
                Button38.Enabled = false;
            }
            else if (Global.KevinSipprellStatus == "Done")
            {
                TextBox15.BackColor = System.Drawing.Color.Red;
                TextBox15.Text = Global.KevinSipprell.ToString("HHmm") + ("hrs");
                Button14.Text = Global.KevinSipprellStatus;
                Button14.Enabled = false;
                Button38.Text = Global.KevinSipprellStatus;
                Button38.Enabled = false;
            }
        }
        protected void Button14_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.KevinSipprellStatus = "Done";
                Global.KevinSipprell = DateTime.Now;
                Log.Logstring += "Kevin Sipprell Done: " + DateTime.Now.ToString() + "\n";
                Global.Mdhere--;
                CheckKevinSipprellStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckEmilyAndersonStatus()
        {
            if (Global.EmilyAndersonStatus == null)
                return;

            if (Global.EmilyAndersonStatus == "Enroute")
            {
                TimeSpan diff = (Global.EmilyAnderson.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox16.Text = diff.ToString("mm");
                else
                    TextBox16.Text = "-" + diff.ToString("mm");
            }
            else if (Global.EmilyAndersonStatus == "Here")
            {
                TextBox16.Text = Global.EmilyAnderson.ToString("HHmm") + ("hrs");
                TextBox16.BackColor = System.Drawing.Color.Yellow;
                Button39.Text = Global.EmilyAndersonStatus;
                Button39.Enabled = false;
            }
            else if (Global.EmilyAndersonStatus == "Done")
            {
                TextBox16.BackColor = System.Drawing.Color.Red;
                TextBox16.Text = Global.EmilyAnderson.ToString("HHmm") + ("hrs");
                Button15.Text = Global.EmilyAndersonStatus;
                Button15.Enabled = false;
                Button39.Text = Global.EmilyAndersonStatus;
                Button39.Enabled = false;
            }
        }
        protected void Button15_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.EmilyAndersonStatus = "Done";
                Global.EmilyAnderson = DateTime.Now;
                Log.Logstring += "Emily Anderson Done: " + DateTime.Now.ToString() + "\n";
                Global.PAhere--;
                CheckEmilyAndersonStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckJerodBarnesStatus()
        {
            if (Global.JerodBarnesStatus == null)
                return;

            if (Global.JerodBarnesStatus == "Enroute")
            {
                TimeSpan diff = (Global.JerodBarnes.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox17.Text = diff.ToString("mm");
                else
                    TextBox17.Text = "-" + diff.ToString("mm");
            }
            else if (Global.JerodBarnesStatus == "Here")
            {
                TextBox17.Text = Global.JerodBarnes.ToString("HHmm") + ("hrs");
                TextBox17.BackColor = System.Drawing.Color.Yellow;
                Button40.Text = Global.JerodBarnesStatus;
                Button40.Enabled = false;
            }
            else if (Global.JerodBarnesStatus == "Done")
            {
                TextBox17.BackColor = System.Drawing.Color.Red;
                TextBox17.Text = Global.JerodBarnes.ToString("HHmm") + ("hrs");
                Button16.Text = Global.JerodBarnesStatus;
                Button16.Enabled = false;
                Button40.Text = Global.JerodBarnesStatus;
                Button40.Enabled = false;
            }
        }
        protected void Button16_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.JerodBarnesStatus = "Done";
                Global.JerodBarnes = DateTime.Now;
                Log.Logstring += "Jerod Barnes Done: " + DateTime.Now.ToString() + "\n";
                Global.PAhere--;
                CheckJerodBarnesStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckErinBischoffStatus()
        {
            if (Global.ErinBischoffStatus == null)
                return;

            if (Global.ErinBischoffStatus == "Enroute")
            {
                TimeSpan diff = (Global.ErinBischoff.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox18.Text = diff.ToString("mm");
                else
                    TextBox18.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ErinBischoffStatus == "Here")
            {
                TextBox18.Text = Global.ErinBischoff.ToString("HHmm") + ("hrs");
                TextBox18.BackColor = System.Drawing.Color.Yellow;
                Button41.Text = Global.ErinBischoffStatus;
                Button41.Enabled = false;
            }
            else if (Global.ErinBischoffStatus == "Done")
            {
                TextBox18.BackColor = System.Drawing.Color.Red;
                TextBox18.Text = Global.ErinBischoff.ToString("HHmm") + ("hrs");
                Button17.Text = Global.ErinBischoffStatus;
                Button17.Enabled = false;
                Button41.Text = Global.ErinBischoffStatus;
                Button41.Enabled = false;
            }
        }
        protected void Button17_Click(object sender, EventArgs e)
        {
        if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.ErinBischoffStatus = "Done";
                Global.ErinBischoff = DateTime.Now;
                Log.Logstring += "Erin Bischoff Done: " + DateTime.Now.ToString() + "\n";
                Global.PAhere--;
                CheckErinBischoffStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckFredDemeuseStatus()
        {
            if (Global.FredDemeuseStatus == null)
                return;

            if (Global.FredDemeuseStatus == "Enroute")
            {
                TimeSpan diff = (Global.FredDemeuse.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox19.Text = diff.ToString("mm");
                else
                    TextBox19.Text = "-" + diff.ToString("mm");
            }
            else if (Global.FredDemeuseStatus == "Here")
            {
                TextBox19.Text = Global.FredDemeuse.ToString("HHmm") + ("hrs");
                TextBox19.BackColor = System.Drawing.Color.Yellow;
                Button42.Text = Global.FredDemeuseStatus;
                Button42.Enabled = false;
            }
            else if (Global.FredDemeuseStatus == "Done")
            {
                TextBox19.BackColor = System.Drawing.Color.Red;
                TextBox19.Text = Global.FredDemeuse.ToString("HHmm") + ("hrs");
                Button18.Text = Global.FredDemeuseStatus;
                Button18.Enabled = false;
                Button42.Text = Global.FredDemeuseStatus;
                Button42.Enabled = false;
            }
        }
        protected void Button18_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.FredDemeuseStatus = "Done";
                Global.FredDemeuse = DateTime.Now;
                Log.Logstring += "Fred DeMeuse Done: " + DateTime.Now.ToString() + "\n";
                Global.PAhere--;
                CheckFredDemeuseStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckChelseaErnisseStatus()
        {
            if (Global.ChelseaErnisseStatus == null)
                return;

            if (Global.ChelseaErnisseStatus == "Enroute")
            {
                TimeSpan diff = (Global.ChelseaErnisse.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox20.Text = diff.ToString("mm");
                else
                    TextBox20.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ChelseaErnisseStatus == "Here")
            {
                TextBox20.Text = Global.ChelseaErnisse.ToString("HHmm") + ("hrs");
                TextBox20.BackColor = System.Drawing.Color.Yellow;
                Button43.Text = Global.ChelseaErnisseStatus;
                Button43.Enabled = false;
            }
            else if (Global.ChelseaErnisseStatus == "Done")
            {
                TextBox20.BackColor = System.Drawing.Color.Red;
                TextBox20.Text = Global.ChelseaErnisse.ToString("HHmm") + ("hrs");
                Button19.Text = Global.ChelseaErnisseStatus;
                Button19.Enabled = false;
                Button43.Text = Global.ChelseaErnisseStatus;
                Button43.Enabled = false;
            }
        }
        protected void Button19_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.ChelseaErnisseStatus = "Done";
                Global.ChelseaErnisse = DateTime.Now;
                Log.Logstring += "Chelsea Eernisse Done: " + DateTime.Now.ToString() + "\n";
                Global.PAhere--;
                CheckChelseaErnisseStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckAlliEngelsmaStatus()
        {
            if (Global.AllisonEngelsmaStatus == null)
                return;

            if (Global.AllisonEngelsmaStatus == "Enroute")
            {
                TimeSpan diff = (Global.AllisonEngelsma.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox21.Text = diff.ToString("mm");
                else
                    TextBox21.Text = "-" + diff.ToString("mm");
            }
            else if (Global.AllisonEngelsmaStatus == "Here")
            {
                TextBox21.Text = Global.AllisonEngelsma.ToString("HHmm") + ("hrs");
                TextBox21.BackColor = System.Drawing.Color.Yellow;
                Button44.Text = Global.AllisonEngelsmaStatus;
                Button44.Enabled = false;
            }
            else if (Global.AllisonEngelsmaStatus == "Done")
            {
                TextBox21.BackColor = System.Drawing.Color.Red;
                TextBox21.Text = Global.AllisonEngelsma.ToString("HHmm") + ("hrs");
                Button20.Text = Global.AllisonEngelsmaStatus;
                Button20.Enabled = false;
                Button44.Text = Global.AllisonEngelsmaStatus;
                Button44.Enabled = false;
            }
        }
        protected void Button20_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.AllisonEngelsmaStatus = "Done";
                Global.AllisonEngelsma = DateTime.Now;
                Log.Logstring += "Alli Engelsma Done: " + DateTime.Now.ToString() + "\n";
                Global.PAhere--;
                CheckAlliEngelsmaStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckBradyGriffithStatus()
        {
            if (Global.BradyGriffithStatus == null)
                return;

            if (Global.BradyGriffithStatus == "Enroute")
            {
                TimeSpan diff = (Global.BradyGriffith.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox22.Text = diff.ToString("mm");
                else
                    TextBox22.Text = "-" + diff.ToString("mm");
            }
            else if (Global.BradyGriffithStatus == "Here")
            {
                TextBox22.Text = Global.BradyGriffith.ToString("HHmm") + ("hrs");
                TextBox22.BackColor = System.Drawing.Color.Yellow;
                Button45.Text = Global.BradyGriffithStatus;
                Button45.Enabled = false;
            }
            else if (Global.BradyGriffithStatus == "Done")
            {
                TextBox22.BackColor = System.Drawing.Color.Red;
                TextBox22.Text = Global.BradyGriffith.ToString("HHmm") + ("hrs");
                Button21.Text = Global.BradyGriffithStatus;
                Button21.Enabled = false;
                Button45.Text = Global.BradyGriffithStatus;
                Button45.Enabled = false;
            }
        }
      
        protected void Button21_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.BradyGriffithStatus = "Done";
                Global.BradyGriffith = DateTime.Now;
                Log.Logstring += "Brady Griffith Done: " + DateTime.Now.ToString() + "\n";
                Global.PAhere--;
                CheckBradyGriffithStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckJasonHicksStatus()
        {
            if (Global.JasonHicksStatus == null)
                return;

            if (Global.JasonHicksStatus == "Enroute")
            {
                TimeSpan diff = (Global.JasonHicks.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox23.Text = diff.ToString("mm");
                else
                    TextBox23.Text = "-" + diff.ToString("mm");
            }
            else if (Global.JasonHicksStatus == "Here")
            {
                TextBox23.Text = Global.JasonHicks.ToString("HHmm") + ("hrs");
                TextBox23.BackColor = System.Drawing.Color.Yellow;
                Button46.Text = Global.JasonHicksStatus;
                Button46.Enabled = false;
            }
            else if (Global.JasonHicksStatus == "Done")
            {
                TextBox23.BackColor = System.Drawing.Color.Red;
                TextBox23.Text = Global.JasonHicks.ToString("HHmm") + ("hrs");
                Button22.Text = Global.JasonHicksStatus;
                Button22.Enabled = false;
                Button46.Text = Global.JasonHicksStatus;
                Button46.Enabled = false;
            }
        }
       
        protected void Button22_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.JasonHicksStatus = "Done";
                Global.JasonHicks = DateTime.Now;
                Log.Logstring += "Jason Hicks Done: " + DateTime.Now.ToString() + "\n";
                Global.PAhere--;
                CheckJasonHicksStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckLisaLarsonStatus()
        {
            if (Global.LisaLarsonStatus == null)
                return;

            if (Global.LisaLarsonStatus == "Enroute")
            {
                TimeSpan diff = (Global.LisaLarson.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox24.Text = diff.ToString("mm");
                else
                    TextBox24.Text = "-" + diff.ToString("mm");
            }
            else if (Global.LisaLarsonStatus == "Here")
            {
                TextBox24.Text = Global.LisaLarson.ToString("HHmm") + ("hrs");
                TextBox24.BackColor = System.Drawing.Color.Yellow;
                Button47.Text = Global.LisaLarsonStatus;
                Button47.Enabled = false;
            }
            else if (Global.LisaLarsonStatus == "Done")
            {
                TextBox24.BackColor = System.Drawing.Color.Red;
                TextBox24.Text = Global.LisaLarson.ToString("HHmm") + ("hrs");
                Button23.Text = Global.LisaLarsonStatus;
                Button23.Enabled = false;
                Button47.Text = Global.LisaLarsonStatus;
                Button47.Enabled = false;
            }
        }
        protected void Button23_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.LisaLarsonStatus = "Done";
                Global.LisaLarson = DateTime.Now;
                Log.Logstring += "Lisa Larson Done: " + DateTime.Now.ToString() + "\n";
                Global.PAhere--;
                CheckLisaLarsonStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckBethRadkeStatus()
        {
            if (Global.BethRadkeStatus == null)
                return;

            if (Global.BethRadkeStatus == "Enroute")
            {
                TimeSpan diff = (Global.BethRadke.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox25.Text = diff.ToString("mm");
                else
                    TextBox25.Text = "-" + diff.ToString("mm");
            }
            else if (Global.BethRadkeStatus == "Here")
            {
                TextBox25.Text = Global.BethRadke.ToString("HHmm") + ("hrs");
                TextBox25.BackColor = System.Drawing.Color.Yellow;
                Button48.Text = Global.BethRadkeStatus;
                Button48.Enabled = false;
            }
            else if (Global.BethRadkeStatus == "Done")
            {
                TextBox25.BackColor = System.Drawing.Color.Red;
                TextBox25.Text = Global.BethRadke.ToString("HHmm") + ("hrs");
                Button24.Text = Global.BethRadkeStatus;
                Button24.Enabled = false;
                Button48.Text = Global.BethRadkeStatus;
                Button48.Enabled = false;
            }
        }
        protected void Button24_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.BethRadkeStatus = "Done";
                Global.BethRadke = DateTime.Now;
                Log.Logstring += "Beth Radke Done: " + DateTime.Now.ToString() + "\n";
                Global.PAhere--;
                CheckBethRadkeStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckTamrahTenhaeffStatus()
        {
            if (Global.TamrahTenhaeffStatus == null)
                return;

            if (Global.TamrahTenhaeffStatus == "Enroute")
            {
                TimeSpan diff = (Global.TamrahTenhaeff.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox26.Text = diff.ToString("mm");
                else
                    TextBox26.Text = "-" + diff.ToString("mm");
            }
            else if (Global.TamrahTenhaeffStatus == "Here")
            {
                TextBox26.Text = Global.TamrahTenhaeff.ToString("HHmm") + ("hrs");
                TextBox26.BackColor = System.Drawing.Color.Yellow;
                Button49.Text = Global.TamrahTenhaeffStatus;
                Button49.Enabled = false;
            }
            else if (Global.TamrahTenhaeffStatus == "Done")
            {
                TextBox26.BackColor = System.Drawing.Color.Red;
                TextBox26.Text = Global.TamrahTenhaeff.ToString("HHmm") + ("hrs");
                Button25.Text = Global.TamrahTenhaeffStatus;
                Button25.Enabled = false;
                Button49.Text = Global.TamrahTenhaeffStatus;
                Button49.Enabled = false;
            }
        }
        protected void Button25_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.TamrahTenhaeffStatus = "Done";
                Global.TamrahTenhaeff = DateTime.Now;
                Log.Logstring += "Tamrah Tenhaeff Done: " + DateTime.Now.ToString() + "\n";
                Global.PAhere--;
                CheckTamrahTenhaeffStatus();
                Response.Redirect("index.aspx");

            }
        }
        public void CheckErinnVonReinStatus()
        {
            if (Global.ErinnVonReinStatus == null)
                return;

            if (Global.ErinnVonReinStatus == "Enroute")
            {
                TimeSpan diff = (Global.ErinnVonRein.Subtract(DateTime.Now));
                if (diff.TotalMinutes >= 0)
                    TextBox27.Text = diff.ToString("mm");
                else
                    TextBox27.Text = "-" + diff.ToString("mm");
            }
            else if (Global.ErinnVonReinStatus == "Here")
            {
                TextBox27.Text = Global.ErinnVonRein.ToString("HHmm") + ("hrs");
                TextBox27.BackColor = System.Drawing.Color.Yellow;
                Button50.Text = Global.ErinnVonReinStatus;
                Button50.Enabled = false;
            }
            else if (Global.ErinnVonReinStatus == "Done")
            {
                TextBox27.BackColor = System.Drawing.Color.Red;
                TextBox27.Text = Global.ErinnVonRein.ToString("HHmm") + ("hrs");
                Button26.Text = Global.ErinnVonReinStatus;
                Button26.Enabled = false;
                Button50.Text = Global.ErinnVonReinStatus;
                Button50.Enabled = false;
            }
        }
        protected void Button26_Click(object sender, EventArgs e)
        {
            if (!IsPageRefresh)// prevent page refresh from tiggering again
            {

                Global.ErinnVonReinStatus = "Done";
                Global.ErinnVonRein = DateTime.Now;
                Log.Logstring += "Erinn VonRein Done: " + DateTime.Now.ToString() + "\n";
                Global.PAhere--;
                CheckErinnVonReinStatus();
                Response.Redirect("index.aspx");

            }
        }
    }
}