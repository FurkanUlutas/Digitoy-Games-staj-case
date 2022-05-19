using System;
namespace WinFormsApp1
{
    public partial class MasaOzellikleri : Form
    {
        int seciliBahis;
        bool hizli, tekli, rovansli;

        public class masa
        {
            public string masaAdi;
            public int masaBahsi;
            public bool hizliMasa;
            public bool tekliMasa;
            public bool rovansliMasa;
        }
        List<masa> masalar = new List<masa>();

        private void MasaOzellikleri_Load(object sender, EventArgs e)
        {
            masa masa1 = new masa();
            masa1.masaAdi = "Masa 1";
            masa1.masaBahsi = 200;
            masa1.hizliMasa = true;
            masa1.tekliMasa = true;
            masa1.rovansliMasa= true;
            masalar.Add(masa1);

            masa masa2 = new masa();
            masa2.masaAdi = "Masa 2";
            masa2.masaBahsi = 200;
            masa2.hizliMasa = true;
            masa2.tekliMasa = true;
            masa2.rovansliMasa = false;
            masalar.Add(masa2);


            masa masa3 = new masa();
            masa3.masaAdi = "Masa 3";
            masa3.masaBahsi = 200;
            masa3.hizliMasa = true;
            masa3.tekliMasa = false;
            masa3.rovansliMasa = true;
            masalar.Add(masa3);

            masa masa4 = new masa();
            masa4.masaAdi = "Masa 4";
            masa4.masaBahsi = 200;
            masa4.hizliMasa = true;
            masa4.tekliMasa = false;
            masa4.rovansliMasa = false;
            masalar.Add(masa4);

            masa masa5 = new masa();
            masa5.masaAdi = "Masa 5";
            masa5.masaBahsi = 200;
            masa5.hizliMasa = false;
            masa5.tekliMasa = true;
            masa5.rovansliMasa = true;
            masalar.Add(masa5);

            masa masa6 = new masa();
            masa6.masaAdi = "Masa 6";
            masa6.masaBahsi = 200;
            masa6.hizliMasa = false;
            masa6.tekliMasa = true;
            masa6.rovansliMasa = false;
            masalar.Add(masa6);

            masa masa7 = new masa();
            masa7.masaAdi = "Masa 7";
            masa7.masaBahsi = 200;
            masa7.hizliMasa = false;
            masa7.tekliMasa = false;
            masa7.rovansliMasa = true;
            masalar.Add(masa7);

            masa masa8 = new masa();
            masa8.masaAdi = "Masa 8";
            masa8.masaBahsi = 200;
            masa8.hizliMasa = false;
            masa8.tekliMasa = false;
            masa8.rovansliMasa = false;
            masalar.Add(masa8);

            masa masa9 = new masa();
            masa9.masaAdi = "Masa 9";
            masa9.masaBahsi = 1500;
            masa9.hizliMasa = true;
            masa9.tekliMasa = true;
            masa9.rovansliMasa = true;
            masalar.Add(masa9);

            masa masa10 = new masa();
            masa10.masaAdi = "Masa 10";
            masa10.masaBahsi = 1500;
            masa10.hizliMasa = true;
            masa10.tekliMasa = true;
            masa10.rovansliMasa = false;
            masalar.Add(masa10);

            masa masa11 = new masa();
            masa11.masaAdi = "Masa 11";
            masa11.masaBahsi = 1500;
            masa11.hizliMasa = true;
            masa11.tekliMasa = false;
            masa11.rovansliMasa = true;
            masalar.Add(masa11);

            masa masa12 = new masa();
            masa12.masaAdi = "Masa 12";
            masa12.masaBahsi = 1500;
            masa12.hizliMasa = true;
            masa12.tekliMasa = false;
            masa12.rovansliMasa = false;
            masalar.Add(masa12);

            masa masa13 = new masa();
            masa13.masaAdi = "Masa 13";
            masa13.masaBahsi = 1500;
            masa13.hizliMasa = false;
            masa13.tekliMasa = true;
            masa13.rovansliMasa = true;
            masalar.Add(masa13);

            masa masa14 = new masa();
            masa14.masaAdi = "Masa 14";
            masa14.masaBahsi = 1500;
            masa14.hizliMasa = false;
            masa14.tekliMasa = true;
            masa14.rovansliMasa = false;
            masalar.Add(masa14);

            masa masa15 = new masa();
            masa15.masaAdi = "Masa 15";
            masa15.masaBahsi = 1500;
            masa15.hizliMasa = false;
            masa15.tekliMasa = false;
            masa15.rovansliMasa = true;
            masalar.Add(masa15);

            masa masa16 = new masa();
            masa16.masaAdi = "Masa 16";
            masa16.masaBahsi = 1500;
            masa16.hizliMasa = false;
            masa16.tekliMasa = false;
            masa16.rovansliMasa = false;
            masalar.Add(masa16);

            masa masa17 = new masa();
            masa17.masaAdi = "Masa 17";
            masa17.masaBahsi = 2500;
            masa17.hizliMasa = true;
            masa17.tekliMasa = true;
            masa17.rovansliMasa = true;
            masalar.Add(masa17);

            masa masa18 = new masa();
            masa18.masaAdi = "Masa 18";
            masa18.masaBahsi = 2500;
            masa18.hizliMasa = true;
            masa18.tekliMasa = true;
            masa18.rovansliMasa = false;
            masalar.Add(masa18);

            masa masa19 = new masa();
            masa19.masaAdi = "Masa 19";
            masa19.masaBahsi = 2500;
            masa19.hizliMasa = true;
            masa19.tekliMasa = false;
            masa19.rovansliMasa = true;
            masalar.Add(masa19);

            masa masa20 = new masa();
            masa20.masaAdi = "Masa 20";
            masa20.masaBahsi = 2500;
            masa20.hizliMasa = true;
            masa20.tekliMasa = false;
            masa20.rovansliMasa = false;
            masalar.Add(masa20);

            masa masa21 = new masa();
            masa21.masaAdi = "Masa 21";
            masa21.masaBahsi = 2500;
            masa21.hizliMasa = false;
            masa21.tekliMasa = true;
            masa21.rovansliMasa = true;
            masalar.Add(masa21);

            masa masa22 = new masa();
            masa22.masaAdi = "Masa 22";
            masa22.masaBahsi = 2500;
            masa22.hizliMasa = false;
            masa22.tekliMasa = true;
            masa22.rovansliMasa = false;
            masalar.Add(masa22);

            masa masa23 = new masa();
            masa23.masaAdi = "Masa 23";
            masa23.masaBahsi = 2500;
            masa23.hizliMasa = false;
            masa23.tekliMasa = false;
            masa23.rovansliMasa = true;
            masalar.Add(masa23);

            masa masa24 = new masa();
            masa24.masaAdi = "Masa 24";
            masa24.masaBahsi = 2500;
            masa24.hizliMasa = false;
            masa24.tekliMasa = false;
            masa24.rovansliMasa = false;
            masalar.Add(masa24);

            masa masa25 = new masa();
            masa25.masaAdi = "Masa 25";
            masa25.masaBahsi = 4000;
            masa25.hizliMasa = true;
            masa25.tekliMasa = true;
            masa25.rovansliMasa = true;
            masalar.Add(masa25);

            masa masa26 = new masa();
            masa26.masaAdi = "Masa 26";
            masa26.masaBahsi = 4000;
            masa26.hizliMasa = true;
            masa26.tekliMasa = true;
            masa26.rovansliMasa = false;
            masalar.Add(masa26);

            masa masa27 = new masa();
            masa27.masaAdi = "Masa 27";
            masa27.masaBahsi = 4000;
            masa27.hizliMasa = true;
            masa27.tekliMasa = false;
            masa27.rovansliMasa = true;
            masalar.Add(masa27);

            masa masa28 = new masa();
            masa28.masaAdi = "Masa 28";
            masa28.masaBahsi = 4000;
            masa28.hizliMasa = true;
            masa28.tekliMasa = false;
            masa28.rovansliMasa = false;
            masalar.Add(masa28);

            masa masa29 = new masa();
            masa29.masaAdi = "Masa 29";
            masa29.masaBahsi = 4000;
            masa29.hizliMasa = false;
            masa29.tekliMasa = true;
            masa29.rovansliMasa = true;
            masalar.Add(masa29);

            masa masa30 = new masa();
            masa30.masaAdi = "Masa 30";
            masa30.masaBahsi = 4000;
            masa30.hizliMasa = false;
            masa30.tekliMasa = true;
            masa30.rovansliMasa = false;
            masalar.Add(masa30);

            masa masa31 = new masa();
            masa31.masaAdi = "Masa 31";
            masa31.masaBahsi = 4000;
            masa31.hizliMasa = false;
            masa31.tekliMasa = false;
            masa31.rovansliMasa = true;
            masalar.Add(masa31);

            masa masa32 = new masa();
            masa32.masaAdi = "Masa 32";
            masa32.masaBahsi = 4000;
            masa32.hizliMasa = false;
            masa32.tekliMasa = false;
            masa32.rovansliMasa = false;
            masalar.Add(masa32);

            masa masa33 = new masa();
            masa33.masaAdi = "Masa 33";
            masa33.masaBahsi = 5000;
            masa33.hizliMasa = true;
            masa33.tekliMasa = true;
            masa33.rovansliMasa = true;
            masalar.Add(masa33);

            masa masa34 = new masa();
            masa34.masaAdi = "Masa 34";
            masa34.masaBahsi = 5000;
            masa34.hizliMasa = true;
            masa34.tekliMasa = true;
            masa34.rovansliMasa = false;
            masalar.Add(masa34);

            masa masa35 = new masa();
            masa35.masaAdi = "Masa 35";
            masa35.masaBahsi = 5000;
            masa35.hizliMasa = true;
            masa35.tekliMasa = false;
            masa35.rovansliMasa = true;
            masalar.Add(masa35);

            masa masa36 = new masa();
            masa36.masaAdi = "Masa 36";
            masa36.masaBahsi = 5000;
            masa36.hizliMasa = true;
            masa36.tekliMasa = false;
            masa36.rovansliMasa = false;
            masalar.Add(masa36);

            masa masa37 = new masa();
            masa37.masaAdi = "Masa 37";
            masa37.masaBahsi = 5000;
            masa37.hizliMasa = false;
            masa37.tekliMasa = true;
            masa37.rovansliMasa = true;
            masalar.Add(masa37);

            masa masa38 = new masa();
            masa38.masaAdi = "Masa 38";
            masa38.masaBahsi = 5000;
            masa38.hizliMasa = false;
            masa38.tekliMasa = true;
            masa38.rovansliMasa = false;
            masalar.Add(masa38);

            masa masa39 = new masa();
            masa39.masaAdi = "Masa 39";
            masa39.masaBahsi = 5000;
            masa39.hizliMasa = false;
            masa39.tekliMasa = false;
            masa39.rovansliMasa = true;
            masalar.Add(masa39);

            masa masa40 = new masa();
            masa40.masaAdi = "Masa 40";
            masa40.masaBahsi = 5000;
            masa40.hizliMasa = false;
            masa40.tekliMasa = false;
            masa40.rovansliMasa = false;
            masalar.Add(masa40);


        }


        public MasaOzellikleri()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int bahisMax = trackBar1.Value; 
            secilenDeger.Text = bahisMax.ToString()+"$";
            seciliBahis = bahisMax;
        }

        private void hizEvet_Click(object sender, EventArgs e)
        {
            
            hizEvet.BackColor = Color.Green;
            hizEvet.ForeColor = Color.White;
            hizHayir.BackColor = Color.Red;
            hizHayir.ForeColor = Color.White;
            hizli = true;
        }

        private void hizHayir_Click(object sender, EventArgs e)
        {
            hizHayir.BackColor = Color.Green;
            hizHayir.ForeColor = Color.White;
            hizEvet.BackColor = Color.Red;  
            hizEvet.ForeColor = Color.White;
            hizli=false;   
        }

        private void tekEvet_Click(object sender, EventArgs e)
        {
            tekEvet.BackColor = Color.Green;    
            tekEvet.ForeColor = Color.White;    
            tekHayir.BackColor = Color.Red;  
            tekHayir.ForeColor = Color.White;
            tekli = true;
         }

        private void tekHayir_Click(object sender, EventArgs e)
        {
            tekHayir.BackColor = Color.Green;
            tekHayir.ForeColor = Color.White;
            tekEvet.BackColor = Color.Red;
            tekEvet.ForeColor = Color.White;
            tekli = false;
        }

        private void rovansEvet_Click(object sender, EventArgs e)
        {
            rovansEvet.BackColor = Color.Green;
            rovansEvet.ForeColor = Color.White;
            rovansHayir.BackColor = Color.Red;
            rovansHayir.ForeColor = Color.White;
            rovansli = true;
        }

        

        private void rovansHayir_Click(object sender, EventArgs e)
        {
            rovansHayir.BackColor = Color.Green;
            rovansHayir.ForeColor = Color.White;
            rovansEvet.BackColor = Color.Red;
            rovansEvet.ForeColor = Color.White;
            rovansli=false;
        }

        private void filtrele_Click(object sender, EventArgs e)
        {
            sonuc.Text = "";
            foreach (var item in masalar)
            {
                if (item.masaBahsi<=seciliBahis && item.hizliMasa==hizli && item.tekliMasa==tekli && item.rovansliMasa==rovansli)
                {
                    sonuc.Visible = true;
                    sonuc.Text += item.masaAdi + " ";
                }
            }
            sonuc.Text += "masalari uygundur.Iyi eglenceler..";
        }

        
    }
}