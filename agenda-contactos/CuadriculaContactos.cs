/*
 * Created by SharpDevelop.
 * User: User
 * Date: 18/6/2025
 * Time: 10:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace agenda_contactos
{
	/// <summary>
	/// Description of CuadriculaContactos.
	/// </summary>
	
	public class CuadriculaContactos : DataGridView
	{	

		public CuadriculaContactos(Panel padre, ref List<Contacto> contactos)
		{
			crearColumnas(); 
			Name = "Cuadrícula de Contactos";
       		Size = new Size(500, 300);
        	AutoSizeRowsMode =
        	DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        	ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
        	CellBorderStyle = DataGridViewCellBorderStyle.Single;
        	GridColor = Color.Black;
        	RowHeadersVisible = false;
        	
        	DataSource = contactos;
        	padre.Controls.Add(this);
		}
		
		public void crearColumnas()
		{
			ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
        	ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
       		ColumnHeadersDefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
		}
	}
}