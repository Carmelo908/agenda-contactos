/*
 * Created by SharpDevelop.
 * User: User
 * Date: 9/6/2025
 * Time: 14:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using agenda_contactos;

namespace agenda_contactos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Button botonAñadir;
		public Button botonEliminar;
		public Button botonModificar;
		public CuadriculaContactos cuadriculaContactos;
		
		public MainForm()
		{
			InitializeComponent();
			crearLayout();
			AutoSize = true;
		}
		
		private void crearLayout()
		{
			FlowLayoutPanel panelPrincipal = new FlowLayoutPanel { 
				AutoSize = true, FlowDirection = FlowDirection.TopDown 
			};
			cuadriculaContactos = new CuadriculaContactos(panelPrincipal);
			FlowLayoutPanel panelBotones = crearPanelBotones(panelPrincipal);
			panelPrincipal.Controls.Add(cuadriculaContactos);
			panelPrincipal.Controls.Add(panelBotones);
			Controls.Add(panelPrincipal);
		}
		
		private Button crearBoton(string texto, Panel padre)
		{
			Button result = new Button { 
				AutoSize = true,
				Text = texto,
				Margin = new Padding(30, 20, 30, 20),
				Padding = new Padding(10, 5, 10, 5)
			};
			padre.Controls.Add(result);
			return result;
		}
		
		private FlowLayoutPanel crearPanelBotones(Panel padre)
		{
			FlowLayoutPanel panelBotones = new FlowLayoutPanel { 
				AutoSize = true,
				Font = new Font("Microsoft Sans Serif", 9.5f)
			};
			botonAñadir = crearBoton("Añadir", panelBotones);
			botonEliminar = crearBoton("Eliminar", panelBotones);
			botonModificar = crearBoton("Modificar", panelBotones);
			return panelBotones;
		}
		
		
	}
}
