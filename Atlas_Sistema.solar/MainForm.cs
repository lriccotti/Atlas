/*
 * Created by SharpDevelop.
 * User: VaCkensi
 * Date: 23/11/2021
 * Time: 12:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atlas_Sistema.solar
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string[] imagen;
		string[] nombre;
		string[] informacion;
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
		
	
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			imagen= new string[8];
			string dreccion="C:\\Users\\VaCkensi\\Pictures\\atlas\\";
			
			imagen[0] =dreccion+"1.jpg";
			imagen[1] =dreccion+"2.jpg";
			imagen[2] =dreccion+"3.jpg";
			imagen[3] =dreccion+"4.jpg";
			imagen[4] =dreccion+"5.jpg";
			imagen[5] =dreccion+"6.jpg";
			imagen[6] =dreccion+"7.jpg";
			imagen[7] =dreccion+"8.jpg";
			
			pc1.Image = Image.FromFile(imagen[0]);
			pc2.Image = Image.FromFile(imagen[1]);
			pc3.Image = Image.FromFile(imagen[2]);
			pc4.Image = Image.FromFile(imagen[3]);
			pc5.Image = Image.FromFile(imagen[4]);
			pc6.Image = Image.FromFile(imagen[5]);
			pc7.Image = Image.FromFile(imagen[6]);
			pc8.Image = Image.FromFile(imagen[7]);
			
			nombre= new string[8];
			nombre[0]="Mercurio";
			nombre[1]="Venus";
			nombre[2]="Tierra";
			nombre[3]="Marte";
			nombre[4]="Jupiter";
			nombre[5]="Saturno";
			nombre[6]="Urano";
			nombre[7]="Neptuno";
		
			informacion= new string[8];
			informacion[0]="Mercurio es el planeta más pequeño de nuestro sistema solar. Simplemente, es un poco más grande que la Luna de la Tierra. Es el planeta más cercano al Sol, pero no es realmente el más cálido";
			informacion[1]="carece de satélites naturales. Recibe su nombre en honor a Venus, la diosa romana del amor. ";
			informacion[2]="Nuestro hogar, el planeta Tierra, es un planeta terrestre y rocoso. Tiene una superficie sólida y activa, con montañas, valles, cañones, llanuras y mucho más. La Tierra es especial porque es un planeta océano, ya que el agua cubre el 70% de su superficie.";
			informacion[3]="Marte es un planeta desértico y frío. Es la mitad del tamaño de la Tierra, y también recibe el nombre de planeta rojo'. Es rojo por el hierro oxidado que tiene en el suelo. ";
			informacion[4]="Júpiter es el planeta más grande del sistema solar y el quinto en orden de lejanía al Sol.​ Es un gigante gaseoso que forma parte de los denominados planetas exteriores. Recibe su nombre del dios romano Júpiter.";
			informacion[5]="Saturno es el sexto planeta del sistema solar contando desde el Sol, el segundo en tamaño y masa después de Júpiter y el único con un sistema de anillos visible desde la Tierra. ";
			informacion[6]="Urano es el séptimo planeta del sistema solar, el tercero de mayor tamaño, y el cuarto más masivo. Se llama así en honor de la divinidad griega del cielo Urano, el padre de Crono y el abuelo de Zeus.";
			informacion[7]="Neptuno es el octavo planeta en distancia respecto al Sol y el más lejano del sistema solar. Forma parte de los denominados planetas exteriores, y dentro de estos, es uno de los gigantes helados, y es el primero que fue descubierto gracias a predicciones matemáticas.";
			
			
			lb_nombre.Text=nombre[0];
			lb_descripcion.Text= informacion[0];
			pic_central.Image=pc1.Image;
		}
		void Label4Click(object sender, EventArgs e)
		{
		}
		
		
		
		void Pc1Click(object sender, EventArgs e)
		{
			PictureBox aux= (PictureBox)sender;
			pic_central.Image= aux.Image;
			
			
			int i;
			i = Convert.ToInt32(aux.Tag);
			pic_central.Image = Image.FromFile(imagen[i]);
			lb_nombre.Text = nombre[i];
			lb_descripcion.Text = informacion[i];
		}
	}
}
