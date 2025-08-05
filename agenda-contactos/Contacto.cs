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
		private List<string> Errores;
		
		public ContactoInvalido(List<string> errores)
			: base("El contacto tiene campos inválidos: " + 
			       "\n- " + string.Join("\n- ", errores))
		{
			Errores = errores;
		}
		
		public override string ToString()
		{
			return base.Message;
		}
	}
	
	[DataContract]
	public class Contacto
	{
		private string nombre = "";
		private string email = "";
		private string telefono = "";
		private string domicilio = "";
		private string notas = "";
		
		public static readonly int cantidadCampos = 5;
		
		private static readonly string errorEmail = "Lo introducido en el campo " + 
			"email no corresponde a un correo electrónico válido";
		
		private static readonly string errorTelefono = "El número de teléfono " +
			"contiene caracteres que no son números";
		
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
		public string Domicilio {
			get { return domicilio; }
			set { domicilio = value; }
		}

		[DataMember]
		public string Notas {
			get { return notas; }
			set { notas = value; }
		}
		
		private bool controlarEmail(string email)
		{
			if (email.Length == 0) {
				return true;
			} else {
				return Regex.IsMatch(email, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
			}
		}
		
		private bool controlarTelefono(string telefono)
		{
			foreach (var caracter in telefono) {
				if (caracter < '0' && caracter > '9') {
					return false;
				}		
			}
			return true;
		}
		
		private List<string> controlarCampos(string nombre, string email, 
		                                    string telefono, string domicilio)
		{
			var errores = new List<string>();
			if (controlarEmail(email)) {
				Email = email;
			} else {
				errores.Add(errorEmail);
			}
			if (controlarTelefono(telefono)) {
				Telefono = telefono;
			} else {
				errores.Add(errorTelefono);
			}
			if (nombre.Length == 0) {
				errores.Add("El campo nombre es obligatorio");
			}
			this.domicilio = domicilio;
			return errores;
		}
		
		public Contacto(string nombre, string email, string telefono, 
		                string domicilio, string notas)
		{
			var errores = controlarCampos(nombre, email, telefono, domicilio);
			Nombre = nombre;
			
			Domicilio = domicilio;
			Notas = notas;
			if (errores.Count != 0) 
			{
				throw new ContactoInvalido(errores);
			}
		}
	}
}
