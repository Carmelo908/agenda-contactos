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
using System.Collections.Generic;
using System.ComponentModel;

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
		
		private List<Contacto> listaContactos;
			
		public FormularioContactos(List<Contacto> listaContactos)
		{
			AutoSize = true;
			botonListo = new Button {
				Text = "Listo",
				Margin = new Padding(140, 10, 140, 10),
				Height = 30
			};
			Controls.Add(crearLayout());
			botonListo.Click += añadirContacto;
			this.listaContactos = listaContactos;
			Show();
		}
		
		public FormularioContactos(List<Contacto> listaContactos, int indice)
			: this(listaContactos)
		{
			rellenarCampos(listaContactos[indice]);
		}
		
		void rellenarCampos(Contacto contacto)
		{
			campoNombre.Text = contacto.Nombre;
			campoEmail.Text = contacto.Email;
			campoTelefono.Text = contacto.Telefono;
			campoDomicilio.Text = contacto.Domicilio;
			campoNotas.Text = contacto.Notas;
		}
		
		FlowLayoutPanel crearCelda(ref TextBox input, string textoLabel)
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
			panelTabla.Controls.Add(crearCelda(ref campoNombre, "Nombre:"), 0, 0);
			panelTabla.Controls.Add(crearCelda(ref campoEmail, "Correo electrónico:"), 1, 0);
			panelTabla.Controls.Add(crearCelda(ref campoTelefono, "Número de teléfono:"), 0, 1);
			panelTabla.Controls.Add(crearCelda(ref campoDomicilio, "Domicilio:"), 1, 1);
			panelTabla.Controls.Add(crearCelda(ref campoNotas, "Notas:"), 0, 2);
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
			Contacto contactoGuardado;
			try {
				contactoGuardado = new Contacto(campoNombre.Text, campoEmail.Text,
			            campoTelefono.Text, campoDomicilio.Text, campoNotas.Text);
				listaContactos.Add(contactoGuardado);
				Close();
			} catch (ContactoInvalido error) {
				MessageBox.Show(error.Message);
			}
		}
	}
}