/*
 * Created by SharpDevelop.
 * User: User
 * Date: 23/6/2025
 * Time: 14:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace agenda_contactos
{
	/// <summary>
	/// Description of FormularioContactos.
	/// </summary>
	public class FormularioContactos : Form
	{
		public Button botonListo;
		public TextBox campoNombre;
		public TextBox campoEmail;
		public TextBox campoTelefono;
		public TextBox campoDomicilio;
		public TextBox campoNotas;
			
		public FormularioContactos()
		{
			AutoSize = true;
			botonListo = new Button {
				Text = "Listo",
				Margin = new Padding(140, 10, 140, 10),
				//Dock = DockStyle.Fill,
				Height = 30
			};
			Controls.Add(crearLayout());
			botonListo.Click += añadirContacto;
			Show();
		}
		
		FlowLayoutPanel crearCelda(TextBox input, string textoLabel)
		{
			var celda = new FlowLayoutPanel { 
				FlowDirection = FlowDirection.TopDown,
				AutoSize = true,
				Margin = new Padding(20)
			};
			var label = new Label { Text = textoLabel, AutoSize = true };
			celda.Controls.Add(label);
			input = new TextBox { Width = 140 };
			celda.Controls.Add(input);
			return celda;
		}
		
		TableLayoutPanel crearTabla()
		{
			var panelTabla = new TableLayoutPanel { 
				ColumnCount = 2,
				RowCount = 3,
				AutoSize = true
			};
			panelTabla.Controls.Add(crearCelda(campoNombre, "Nombre:"), 0, 0);
			panelTabla.Controls.Add(crearCelda(campoEmail, "Correo electrónico:"), 1, 0);
			panelTabla.Controls.Add(crearCelda(campoTelefono, "Número de teléfono:"), 0, 1);
			panelTabla.Controls.Add(crearCelda(campoDomicilio, "Domicilio:"), 1, 1);
			panelTabla.Controls.Add(crearCelda(campoNotas, "Notas:"), 0, 2);
			return panelTabla;
		}
		
		FlowLayoutPanel crearLayout()
		{
			var panelPrincipal = new FlowLayoutPanel { 
				AutoSize = true,
				FlowDirection = FlowDirection.TopDown
			};
			panelPrincipal.Controls.Add(crearTabla());
			panelPrincipal.Controls.Add(botonListo);
			return panelPrincipal;
		}
		
		private void añadirContacto(object sender, EventArgs e)
		{
			Close();
		}
	}
}
