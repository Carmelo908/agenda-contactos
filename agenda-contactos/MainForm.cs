/*
 * Created by SharpDevelop.
 * User: User
 * Date: 9/6/2025
 * Time: 14:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
		public DataGridView cuadriculaContactos;
		
		public MainForm()
		{
			InitializeComponent();
			crearLayout();
		}
		
		private void crearLayout()
		{
			FlowLayoutPanel panelBotones = new FlowLayoutPanel { AutoSize = true };
			FlowLayoutPanel panelPrincipal = new FlowLayoutPanel { 
				AutoSize = true, FlowDirection = FlowDirection.TopDown 
			};
			botonAñadir = crearBoton("Añadir", panelBotones);
			botonEliminar = crearBoton("Eliminar", panelBotones);
			botonModificar = crearBoton("Modificar", panelBotones);
			panelPrincipal.Controls.Add(panelBotones);
			panelPrincipal.Controls.Add(cuadriculaContactos);
			Controls.Add(panelPrincipal);
		}
		
		private Button crearBoton(string texto, Panel padre)
		{
			Button result = new Button { 
				AutoSize = true,
				Text = texto,		
			};
			padre.Controls.Add(result);
			return result;
		}
	}
}
