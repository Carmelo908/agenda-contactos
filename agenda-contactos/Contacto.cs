/*
 * Created by SharpDevelop.
 * User: User
 * Date: 9/6/2025
 * Time: 14:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace agenda_contactos
{
	/// <summary>
	/// Description of Contacto.
	/// </summary>
	
	public class ContactoInvalido : Exception
	{
		private List<string> errores;
	}
	
	[DataContract]
	public class Contacto
	{
		private string nombre = "";
		private string email = "";
		private string telefono = "";
		private string domicilio = "";
		private string notas = "";
		
		[DataMember]
		public string Nombre {
			get { return nombre; }
			set {
				//if (Regex.IsMatch(value, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$")) 
				//{
					nombre = value;
				//}
			}
		}
		
		[DataMember]
		public string Email {
			get { return email; }
			set { email = value; }
		}
		
		[DataMember]
		public string Telefono {
			get { return telefono; }
			set { telefono = value; }
		}


		[DataMember]
		public string Domicilio {
			get { return domicilio; }
			set { domicilio = value; }
		}

		[DataMember]
		public string Notas {
			get { return notas; }
			set { notas = value; }
		}
		
		public Contacto(string nombre, string email, string telefono, 
		                string domicilio, string notas)
		{
			Nombre = nombre;
			Email = email;
			Telefono = telefono;
			Domicilio = domicilio;
			Notas = notas;
		}
	}
}
