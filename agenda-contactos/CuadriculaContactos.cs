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
using System.Collections;

namespace agenda_contactos
{
	/// <summary>
	/// Description of CuadriculaContactos.
	/// </summary>
	
	public class CuadriculaContactos : DataGridView
	{
		private readonly string[] NombresColumnas = 
		{ "Nombre", "Email", "Teléfono", "Domicilio", "Notas" };

		public CuadriculaContactos(Panel padre)
		{
			CrearColumnas();

        	Name = "Cuadrícula de Contactos";
       		Size = new Size(600, 300);
        	AutoSizeRowsMode =
        	DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        	ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
        	CellBorderStyle = DataGridViewCellBorderStyle.Single;
        	GridColor = Color.Black;
        	RowHeadersVisible = false;
        	
        	padre.Controls.Add(this);
		}
		
		
		
		public void CrearColumnas()
		{
			ColumnCount = 5;
			ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
        	ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
       		ColumnHeadersDefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
			for (int i = 0; i < ColumnCount; i++) 
			{
				Columns[i].Name = NombresColumnas[i];
			}
		}
		
		
	}
}