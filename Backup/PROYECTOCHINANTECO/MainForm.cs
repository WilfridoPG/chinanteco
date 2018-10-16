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

		string ruta="";
		void Button1Click(object sender, EventArgs e)
		{
			try
			{
			 label7.Text="";
             string palabra="";
             int i=0,j=0;
             bool band=false;
             string [,] colors=new string[3,10]{{"negro","blanco","azul","amarillo","morado","rojo","anaranjado","verde","gris","café"},{"Liáh2","Tiáu2","Aá2 zuú21","Mi2 Nauh23","Zɨn13","Záɨn3","Hi3 Ñi32 Raú3","Réh2","Juah13","Tsáh2"},{"I:/PYTCNTC/PROYECTOCHINANTECO/SONIDO/Negro.wav","I:/PYTCNTC/PROYECTOCHINANTECO/SONIDO/Blanco.wav","I:/PYTCNTC/PROYECTOCHINANTECO/SONIDO/Azul.wav","I:/PYTCNTC/PROYECTOCHINANTECO/SONIDO/Amarillo.wav","I:/PYTCNTC/PROYECTOCHINANTECO/SONIDO/Morado.wav","I:/PYTCNTC/PROYECTOCHINANTECO/SONIDO/Rojo.wav","","I:/PYTCNTC/PROYECTOCHINANTECO/SONIDO/Verde.wav","I:/PYTCNTC/PROYECTOCHINANTECO/SONIDO/Gris.wav","I:/PYTCNTC/PROYECTOCHINANTECO/SONIDO/Cafe.wav"}};
             string [,] cantid=new string[3,21]{{"uno","dos","tres","cuatro","cinco","seis","siete","ocho","nueve","diez","veinte","treinta","cuarenta","cincuenta","sesenta","setenta","ochenta","noventa","cien","mil","un millon"},{"Cáun2","Tun3","Hnɨ32","Quiún3","Jñiá3","Jñeí3","Quiau3","Jñia3","Jñiu3","Quia3","Quiú3","Quiu3 quia3","Tuu3 lo32","Tu3 la3 quia3","Hnɨ32 hnio2 quiú3","Hnɨ32 hnio2 quiú3 quia3","Quiún3 hnio2 quiú3","Quiún3 hnio2 quiú3 quia3","Jña3 laú3","Cáun2 mein21","Quia3 nio2 jña3 laú3 mein21"},{"","","","","","","","","","","","","","","","","","","","",""}};
             string [,] cuerphum=new string[3,15]{{"cabeza","hombro","ojos","oreja","nariz","boca","cuello","espalda","panza","brazo","uña","pie","cabello","rodilla","dedos"},{"Chi1 tsú2","Mah3 cuo2 tsú2","Mɨ1 ñi1 tsú2","Cuáh1 tsú2","Heh2 tsú2","Ho3 tsú2","Laɨ1 tsú2","Nah21 tsú2","Hein1 tsú2","Cuo2 tsú2","Hëh2 tsú2","Ta3 tsú2","Jñiun2 chi1 tsú2","Cuu1 jñin1 tsú2","Zeíh21 cuo2 tsú2"},{"","","","","","","","","","","","","","",""}};
             string [,] frutverd=new string[3,17]{{"naranja","mango","lima","guayabina","guayaba","toronga","papas","calabaza","tomate","mamey","nopal","elote","platano","coco","chile","chayote","cuajinicuil"},{"Ñi1 raú3","Má1","Ñi1 tuu21","Ñi1 juh21","Ñi1 jaunh32","Ñi2 máh3","Shí1 hioh21","Máh3","Jmah2","Lá2 joh21","Lo2","Lá3","Táu2","Zún3","Hën2","Ngɨ3","Cháh1"},{"","","","","","","","","","","","","","","","",""}};
             string [,] parents=new string[3,9]{{"papá","mamá","hijo","nieto","hermano","sobrino","tío","abuelo","abuela"},{"Tia21","Mɨ1","Jón32","Chó1","Raɨnh21","Jón raɨnh21 tsú2","Raɨnh21 mi1 diú12 tsú2","Tia21 yieh3","Mɨ1 hionh13"},{"","","","","","","","",""}};
             string [,] animals=new string[3,24]{{"burro","caballo","mula","conejo","perro","ratón","guajolote","araña","gato","pez","camarón","puerco","venado","lagartija","chivo","mosca","gallina del monte","paloma","abeja","borrego","tejón","pájaro","ciempiés","murciélago"},{"Búh13","Tsa3 cuá1","Lo1","Lo1 cuá3","Tsaɨ2","No2","Tú2","Jah32","Mi1 tei21","Juóh13","Táh2","Mi2 ñí3","Cua1 naɨn2","Cah2","Zeɨn1","Jáh1","Ju32","Jaɨ2","Toh2","Já1 ziáh2","Quiú3","Tan32","Jáh3 Tá3","Ñi13"},{"","","","","","","","","","","","","","","","","","","","","","","",""}};
             string [,] casa=new string[3,32]{{"ventana","puerta","escalera","silla","mesa","chimenea","techo","piso","pared","cama","recamara","comedor","cosina","baño","television","grabadora","taza","platos","cortina","cochera","escoba","pala","recogedor","servilleta","ropero","cubiertos","cobija","jardin","patio","sillon","foco","cacerolas"},{"Ho3 tá2 quie2","Ua3 ñiúnh13","Ta32","jma1 si2","Mesa","Ñi1 hiah32 mi2 ñi1","Si2 hiúnh3","Piso","Na1 hiah32","jen3","Ñi1 cuaún1 tsú2","Ñi1 cúh13  tsú2 hí3","Ho3 sính13","Ñí1 lauh32 tsú2","Televisión","Su1 un1","Taza","Huonh2","Mí32","Ñí1 toh1 tsú2 ca1 rro2","Hiauh","Mi1 mah1","Hi3 zíh32 tsú2 má1 ","Cu1 jmi32 , jmí1 sí2 zi32 tsú2 ho3","Si1 cúoh2","Mí1 ñí1 caúh32 tsú2 ma1 ca3 cúh13 hí3","Ñí1 jáu2","ja1 líh13","Cheíh13","Ma3 sì2 hua1","Mì3 si2","Hú3"},{"","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","",""}};
             string [,] tiempo=new string[3,16]{{"primavera","verano","otoño","invierno","minutos","horas","segundo","día ","mes ","año","semanas","noche","madrugada","temprano","medio día","tarde"},{"Main1 hia32 lí13","Maín1 mí3","Maín1 zuúh32 mu21 mah2","Main1 cuaúh3","Mi2 nuu1 to1","Hoora1","segundo","Main1","Zí2","Mi2","semanas","Ja1 nei2","Hua2","Hu1 nei2","Ta3 ma2","Ca3 hlaú3"},{"","","","","","","","","","","","","","","",""}};
            
             palabra=(textBox1.Text).ToLower();
             
             if(comboBox1.SelectedIndex==0)
             {
             	
              do{
                 if(String.Equals(colors[i,j],palabra)==true)
                 {
                  
                   ruta=colors[i+2,j];
                   label2.Text= (colors[i+1,j]);
                   band=true;                 
                 }
                 else
                 {
                	j++;
                 }
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
                    
                     label2.Text=(cantid[i+1,j]);
                     ruta=cantid[i+2,j];
                     band=true;
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
                    
                     label2.Text= (cuerphum[i+1,j]);
                     ruta=cuerphum[i+2,j];
                     band=true;
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
                  
                   label2.Text=(frutverd[i+1,j]);
                   ruta=frutverd[i+2,j];
                   band=true;
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
                    
                    label2.Text=(parents[i+1,j]);
                    ruta=parents[i+2,j];
                    band=true;
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
                    
                     label2.Text= (animals[i+1,j]);
                     ruta=animals[i+2,j];
                     band=true;
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
                    
                     label2.Text= (casa[i+1,j]);
                     ruta=casa[i+2,j];
                     band=true;
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
                     
                     label2.Text=(tiempo[i+1,j]);
                     ruta=tiempo[i+2,j];
                     band=true;
                   }
                   else
                   {
                    	j++;
                   }
                }while(band==false); 
	    	
			}
	     	
	     	if(band==true)
	     	{   
	     		button2.Visible=true;
				button3.Visible=true;
				
	     	}    	
	     	
		}
				catch
		{
		 label7.Text=("La palabra que busca no se encuentra");
		 
		}
			
				
        }
		
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			 
			
			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{

			
		}
				
		
		void Button2Click(object sender, EventArgs e)
		{
			
              string path =ruta;
              playSound(path);
              
             
		}
		
		private void playSound(string path)
        {
           System.Media.SoundPlayer player = 
           new System.Media.SoundPlayer();
           player.SoundLocation =path;
           player.Load();
           player.Play();
        }
		
		void Button3Click(object sender, EventArgs e)
		{
			System.Media.SoundPlayer player = new System.Media.SoundPlayer();
			player.Stop();
			
		}
	}
}
