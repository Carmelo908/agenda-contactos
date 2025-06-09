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

namespace agenda_contactos.Clases
{
	/// <summary>
	/// Description of Contacto.
	/// </summary>
	[DataContract]
	public class Contacto
	{
		private string nombre;
		private string email;
		private string telefono;
		private string movil;
		private string domicilio;
		private string notas;
		
		[DataMember]
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
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
		public string Movil {
			get { return movil; }
			set { movil = value; }
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
		
		public Contacto()
		{
		}
	}
}
