/*
 * Created by SharpDevelop.
 * User: alumno
 * Date: 30/7/2025
 * Time: 08:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using agenda_contactos;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace agenda_contactos
{
	/// <summary>
	/// Description of ExportarPDF.
	/// </summary>
	public static class ExportadorPDF
	{
		static public void exportarAPDF(string outfilepath, 
		                         List<Contacto> contactos)
		{
			Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
			FileStream file = new FileStream(outfilepath, FileMode.OpenOrCreate);
			PdfWriter.GetInstance(doc, file);
			doc.Open();
			doc.Add(crearTablaPDF(contactos));
			doc.Close();
			Process.Start(outfilepath);
		}
		
		static private PdfPTable crearTablaPDF(List<Contacto> contactos)
		{
			PdfPTable tabla = new PdfPTable(5);
			tabla.DefaultCell.Padding = 3;
			float[] anchos = Enumerable.Repeat(60f, 5).ToArray();
			tabla.HeaderRows = 1;
			tabla.SetWidths(anchos);
			tabla.DefaultCell.BorderWidth = 2;
			tabla.AddCell("Nombre");
			tabla.AddCell("Email");
			tabla.AddCell("Teléfono");
			tabla.AddCell("Domicilio");
			tabla.AddCell("Notas");
			tabla.CompleteRow();
			
			for (int i = 0; i < contactos.Count; i++)
			{
				tabla.AddCell(contactos[i].Nombre);
				tabla.AddCell(contactos[i].Email);
				tabla.AddCell(contactos[i].Telefono);
				tabla.AddCell(contactos[i].Domicilio);
				tabla.AddCell(contactos[i].Notas);
				tabla.CompleteRow();
			}
			
			return tabla;
		}
	}
}
