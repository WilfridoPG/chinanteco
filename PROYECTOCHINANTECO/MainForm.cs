/*
 * Creado por SharpDevelop.
 * Usuario: Wil
 * Fecha: 10/09/2013
 * Hora: 20:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOCHINANTECO
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

       
       
        char[] delimit = new char[] { ' ' };
        string ruta = "SONIDO/";     
        
        void button1_Click(object sender, EventArgs e)
		{ try
			{
			 label7.Text="";
             string palabra="";
             
             string palabra1="";
             string verifica = " ";
             label2.Text = "";
             label12.Text = "";
             label6.Text = "";
             label10.Text = "";
             label11.Text = "";
             label9.Text = "";
            

            ruta = "SONIDO/";
             int i = 0, j = 0;
             bool band=false;
             string[,] colors = new string[3, 10] { { "negro", "blanco", "azul", "amarillo", "morado", "rojo", "anaranjado", "verde", "gris", "café" }, { "Liáh2", "Tiáu2", "Aá2 zuú21", "Mi2 Nauh23", "Zɨn13", "Záɨn3", "Hi3 Ñi32 Raú3", "Réh2", "Juah13", "Tsáh2" }, { "Negro.wav", "Blanco.wav", "Azul.wav","Amarillo.wav", "Morado.wav", "Rojo.wav", "", "Verde.wav", "Gris.wav", "Cafe.wav" } };
             string [,] cantid=new string[3,21]{{"uno","dos","tres","cuatro","cinco","seis","siete","ocho","nueve","diez","veinte","treinta","cuarenta","cincuenta","sesenta","setenta","ochenta","noventa","cien","mil","un millon"},{"Cáun2","Tun3","Hnɨ32","Quiún3","Jñiá3","Jñeí3","Quiau3","Jñia3","Jñiu3","Quia3","Quiú3","Quiu3 quia3","Tuu3 lo32","Tu3 la3 quia3","Hnɨ32 hnio2 quiú3","Hnɨ32 hnio2 quiú3 quia3","Quiún3 hnio2 quiú3","Quiún3 hnio2 quiú3 quia3","Jña3 laú3","Cáun2 mein21","Quia3 nio2 jña3 laú3 mein21"},{"","","","","","","","","","","","","","","","","","","","",""}};
             string [,] cuerphum=new string[3,15]{{"cabeza","hombro","ojos","oreja","nariz","boca","cuello","espalda","panza","brazo","uña","pie","cabello","rodilla","dedos"},{"Chi1 tsú2","Mah3 cuo2 tsú2","Mɨ1 ñi1 tsú2","Cuáh1 tsú2","Heh2 tsú2","Ho3 tsú2","Laɨ1 tsú2","Nah21 tsú2","Hein1 tsú2","Cuo2 tsú2","Hëh2 tsú2","Ta3 tsú2","Jñiun2 chi1 tsú2","Cuu1 jñin1 tsú2","Zeíh21 cuo2 tsú2"},{"","","","","","","","","","","","","","",""}};
             string[,] frutverd = new string[3, 64] { { "naranja", "mango", "lima", "guayabina", "guayaba", "toronga", "papas", "calabaza", "tomate", "mamey", "nopal", "elote", "platano", "coco", "chile", "chayote", "cuajinicuil", "aguacate", "frijoles", "piña", "frutas", "café", "acuacatillo", "aguacate dulce", "ciruela", "obos", "manzana", "sandia", "cacao", "anona", "chirimolla", "durazno", "zarzamora", "pitahaya", "papaya", "nuez", "nache", "zapote", "uva", "limon", "madarina", "granada", "maracuyá", "chico zapote", "huaje", "ejote", "col", "repollo", "lechuga", "elote", "tepejilote", "yuca", "jícama", "camote", "rabano", "zanahoria", "yerba buena", "epazote", "yerba santa", "peregil", "cilantro", "cebolla", "cebollín", "ajo" }, { "Ñi1 ráu3", "Má1", "Ñi2 tuu21", "Ñí2 juh21", "Ñí2 jaunh32", "Ñí2 máh3", "Shí1 hioh21", "Máh3", "Jmah2", "Lá2 joh21", "Lo2", "Lá3", "Táu2", "Zún3", "Hën2", "Ngɨ3", "Cháh1", "táun1", "jñéi2", "mɨ3 juh21", "máɨ3", "cá fe21", "cú2 hnie2", "cú2 jính", "Huɨh2 chéi3", "Huɨh2 mí1 niau21", "má2 san1 ná1", "máh3 jmáɨ2", "mí2 cháh1", "mí1 hiú2", "mí1 hiú2 ton2", "mɨ3 ján1", "mɨ3 juɨh2 ", "mɨ3 lo2", "mɨ3 máh3", "mɨ3 mue21", "mɨ3 quiú2", "mɨ3 toh2", "mɨ3 uóun2 jɨeh13", "ñí2 jmu3", "ñí2 ráu3 pih21", "páh3", "páh3 jính2", "tá2 nó13", "jñú2 cuánh2", "jñú2 náh2", "já1 jáu2", "já1 jáu2 pëh1", "jonh2 cú3 mu21", "lá3", "lí1", "sí1 hmá3", "sí1 máh3", "sí1 ráu3", "sie1 chéi3", "sie1 tiéi2", "zié2", "há2 mú1", "má2jon2", "má2 hna3 jien3", "má2 hñí1 miíh21", "sí1 cú1 jonh2", "sí1 cú1 míh1", "sí1 cú1 hën2" }, { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","" } };
             string [,] parents=new string[3,9]{{"papá","mamá","hijo","nieto","hermano","sobrino","tío","abuelo","abuela"},{"Tia21","Mɨ1","Jón32","Chó1","Raɨnh21","Jón raɨnh21 tsú2","Raɨnh21 mi1 diú12 tsú2","Tia21 yieh3","Mɨ1 hionh13",},{"","","","","","","","",""}};
             string[,] animals = new string[3, 56] { { "burro", "caballo", "mula", "conejo", "perro", "ratón", "guajolote", "araña", "gato", "pez", "camarón", "puerco", "venado", "lagartija", "chivo", "mosca", "gallina del monte", "paloma", "abeja", "borrego", "tejón", "pájaro", "ciempiés", "murciélago", "gallo", "pollitos", "pajaros", "pajaro carpintero", "colibrí", "tucan", "perico", "pato", "gatitos", "jirafa", "zopilote", "aguila real", "aguila", "tusa", "mapache", "tigre", "leon", "tortuga", "foca", "grillo", "mariposa", "mono", "jabalí", "vaca", "avispa", "caracol", "raton", "ardilla", "pavoreal", "alacrán", "cebra","zorro" }, { "lo1 Búh1", "Tsa3 cuá1", "Lo1", "Lo1 cuá3", "Tsaɨ2", "No2", "Tú2", "Jah32", "Mí1 tiei21", "Juóh13", "Táh2", "Mi2 ñí3", "Cua1 naɨn2", "Cah2", "Zeɨn1", "Jáh1", "Ju32", "Jáɨ2", "Toh2", "Já1 ziáh2", "Quiú3", "Tan32", "Jáh3 Tá3", "Ñi13", "cá1 tsó3", "cá1 míh1 pih21", "tan32", "má2 hnéh3 jmú3", "chi3 quiuh21", "juénh1 jmú3", "tsúh13", "páh3", "tiei21 pih21", "Chauh32", "tú2 jue32", "mɨ2 juɨ13", "máɨ2", "hmáh13", "jáh3 má2 páh3", "hiah32 huénh3", "hiah32 dáɨn3", "jú2 mu3", "tsɨ2 jmáɨ2", "hlah21 niéi2", "chi3 zɨ3", "cuá1 húh2", "mí2 ñí3 náɨ2", "cuá1 juɨ2", "mu21 mɨh32", "chí1 cuo1", "no2", "tsa3 cuo1", "tan32 jmú3", "hñú3", "Lo1 náɨ2","cuo2"}, { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "","",""} };
             string[,] casa = new string[3, 33] { { "ventana", "puerta", "escalera", "silla", "mesa", "chimenea", "techo", "piso", "pared", "cama", "recamara", "comedor", "cosina", "baño", "television", "grabadora", "taza", "platos", "cortina", "cochera", "escoba", "pala", "recogedor", "servilleta", "ropero", "cubiertos", "cobija", "jardin", "patio", "sillon", "foco", "cacerolas","casa" }, { "Ho3 tá2 quie2", "Ua3 ñiúnh13", "Ta32", "Hmá2 sɨ1", "Mesa", "Ñi1 hiah32 mi2 ñi1", "Si2 hiúnh3", "Piso", "Na1 hiah32", "jen3", "Ñi1 cuaún1 tsú2", "Ñi1 cúh13  tsú2 hí3", "Ho3 sính13", "Ñí1 lauh32 tsú2", "Televisión", "Su1 un1", "Taza", "Huonh2", "Mí32", "Ñí1 toh1 tsú2 ca1 rro2", "Hiauh", "Mi1 mah1", "Hi3 zíh32 tsú2 má1 ", "Cu1 jmi32 , jmí1 sí2 zi32 tsú2 ho3", "Si1 cúoh2", "Mí1 ñí1 caúh32 tsú2 ma1 ca3 cúh13 hí3", "Ñí1 jáu2", "ja1 líh13", "Cheíh13", "Ma3 sì2 hua1", "Mì3 si2", "Hú3","hñú3" }, { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "","" } };
             string [,] tiempo=new string[3,16]{{"primavera","verano","otoño","invierno","minutos","horas","segundo","día ","mes ","año","semanas","noche","madrugada","temprano","medio día","tarde"},{"Main1 hia32 lí13","Maín1 mí3","Maín1 zuúh32 mu21 mah2","Main1 cuaúh3","Mi2 nuu1 to1","Hoora1","segundo","Main1","Zí2","Mi2","semanas","Ja1 nei2","Hua2","Hu1 nei2","Ta3 ma2","Ca3 hlaú3"},{"","","","","","","","","","","","","","","",""}};
             palabra=(textBox1.Text).ToLower();
             if(comboBox1.SelectedIndex==0)
             {
                 i = 0;
                 j = 0;
                 band = false;
            
             do{
                 if(String.Equals(colors[i,j],palabra)==true)
                 {
                     palabra1=colors[i+1,j];
                     separa(palabra1);
                     verifica = colors[i + 2, j];
                     if (verifica != "")
                         ruta = ruta + colors[i + 2, j];
                    
                       
                     band=true;                 
                 }
                 else
                	j++;
                 
               }while(band==false);
             	
		      }
             	
		      else if(comboBox1.SelectedIndex==1)
              {
		    	i=0;
		    	j=0;
		    	band=false;
		    	do{
                   if(String.Equals(cantid[i,j],palabra)==true)
                   {

                       palabra1 = cantid[i + 1, j];
                       separa(palabra1);
                       verifica = cantid[i + 2, j];
                       if (verifica != "")
                       ruta =ruta+cantid[i + 2, j];
                       band = true;  
                    }
                    else
                    {
                     	j++;
                    }
                 }while(band==false);  
		
		       }
		       else if(comboBox1.SelectedIndex==2)
               {
		    	i=0;
		    	j=0;
		     	band=false;
		    	do{
                   if(String.Equals(cuerphum[i,j],palabra)==true)
                   {

                       palabra1 = cuerphum[i + 1, j];
                       separa(palabra1);
                       verifica = cuerphum[i + 2, j];
                       if (verifica != "")
                       ruta =ruta+ cuerphum[i + 2, j];
                       band = true;  
                   }
                   else
                    {
                     	j++;
                    }
                  }while(band==false);  
	         	}
	        	else if(comboBox1.SelectedIndex==3)
                {
	     		i=0;
	    		j=0;
	    		band=false;
	    		do{
                  if(String.Equals(frutverd[i,j],palabra)==true)
                  {

                      palabra1 = frutverd[i + 1, j];
                      separa(palabra1);
                      verifica = frutverd[i + 2, j];
                      if (verifica != "")
                      ruta = ruta+frutverd[i + 2, j];
                      band = true;  
                  }
                  else
                   {
                    	j++;
                   }
                 }while(band==false);  
		   	}
	    	else if(comboBox1.SelectedIndex==4)
            {
	    		i=0;
	    		j=0;
	    		band=false;
	    		do{
                  if(String.Equals(parents[i,j],palabra)==true)
                  {

                      palabra1 = parents[i + 1, j];
                      separa(palabra1);
                      verifica = parents[i + 2, j];
                      if (verifica != "")
                      ruta =ruta+ parents[i + 2, j];
                      band = true;  
                  }
                  else
                  {
                 	j++;
                  }
               }while(band==false);  
			}
	     	else if(comboBox1.SelectedIndex==5)
             {
	    		i=0;
	     		j=0;
	    		band=false;
	     		do{
                  if(String.Equals(animals[i,j],palabra)==true)
                   {

                       palabra1 = animals[i + 1, j];
                       separa(palabra1);
                       verifica = animals[i + 2, j];
                       if (verifica != "")
                       ruta = ruta+ animals[i + 2, j];
                       band = true;  
                   }
                   else
                   {
                    	j++;
                   }
                }while(band==false);  
			}
	     	else if(comboBox1.SelectedIndex==6)
             {
	    		i=0;
	     		j=0;
	    		band=false;
	     		do{
                  if(String.Equals(casa[i,j],palabra)==true)
                   {

                       palabra1 = casa[i + 1, j];
                       separa(palabra1);
                       verifica = casa[i + 2, j];
                       if (verifica != "")
                       ruta = ruta+casa[i + 2, j];
                       band = true;  
                   }
                   else
                   {
                    	j++;
                   }
                }while(band==false);  
			}
	     	else if(comboBox1.SelectedIndex==7)
             {
	    		i=0;
	     		j=0;
	    		band=false;
	     		do{
                  if(String.Equals(tiempo[i,j],palabra)==true)
                   {

                       palabra1 = tiempo[i + 1, j];
                       separa(palabra1);
                       verifica = tiempo[i + 2, j];
                       if (verifica != "")
                       ruta = ruta+tiempo[i + 2, j];
                       band = true;  
                   }
                   else
                   {
                    	j++;
                   }
                }while(band==false); 
	    	
			}
             if (verifica != "")
             {
                 button2.Visible = true;
                 button3.Visible = true;

             }
             else
             {
                 button2.Visible = false;
                 button3.Visible = false;
             }
             
            
            
				
	     	
		}
				catch
		{
		 label7.Text=("Lo sentimos la palabra no se encuentra");

         button2.Visible = false;
         button3.Visible = false;
		}


        }
		
		void Label2Click(object sender, EventArgs e)
		{
			 
			
			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{

			
		}
				
		
		void Button2Click(object sender, EventArgs e)
		{
			
              
              playSound(ruta);
              
             
		}
		
		private void playSound(string ruta)
        {
           System.Media.SoundPlayer player =  new System.Media.SoundPlayer();
           player.SoundLocation =ruta;
           player.Play();
        }
		
		void Button3Click(object sender, EventArgs e)
		{
			System.Media.SoundPlayer player = new System.Media.SoundPlayer();
			player.Stop();
			
		}

        private void MainForm_Load(object sender, EventArgs e)
        {
            
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        void separa(string palabra1)
        {
            char[] enteros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] array = new char[20];
            char[] nume = new char[20];
            char[] palab = new char[20];
            int n = 0, m = 0, b = 0;
            int cont = 0, x = 0, y = 0;

            foreach (string substr in palabra1.Split(delimit))
            {
                m = 0;
                n = 0;
              
                array = substr.ToCharArray();
                for (x = 0; x < array.Length; x++)
                {
                   
                    b = 0;
                    for (y = 0; y < enteros.Length; y++)
                    {
                        if (array[x] == enteros[y])
                        {
                            nume[m] = array[x];
                            m++;
                            b = 1;
                        }
                    }
                    if (b == 0)
                    {
                        palab[n] = array[x];
                        n++;
                    }
                }
                cont = cont + 1;

                if (cont == 1)
                {
                    for (n = 0; n < palab.Length; n++)
                        label12.Text += Convert.ToString(palab[n]);

                    for (m = 0; m < nume.Length; m++)
                        label2.Text += Convert.ToString(nume[m]);
                }

                else
                    if (cont == 2)
                    {
                        for (n = 0; n < palab.Length; n++)
                            label6.Text += Convert.ToString(palab[n]);

                        for (m = 0; m < nume.Length; m++)
                            label9.Text += Convert.ToString(nume[m]);
                    }
                    else
                        if (cont == 3)
                        {
                            for (n = 0; n < palab.Length; n++)
                                label10.Text += Convert.ToString(palab[n]);

                            for (m = 0; m < nume.Length; m++)
                                label11.Text += Convert.ToString(nume[m]);
                        }







            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 ayud = new Form1();
            ayud.Visible= true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string messege = "¿esta seguro de salir?";
            const string caption = "aviso";
            var result = MessageBox.Show(messege, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;

            }
        }

    

     

       
	}
}
