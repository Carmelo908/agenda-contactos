using System;
using System.IO;
using Newtonsoft.Json;
using agenda_contactos;
using System.Collections.Generic;

namespace agenda_contactos
{
	/// <summary>
	/// Description of serializador.
	/// </summary>
	public static class SerializadorJSON
	{
		private static readonly string rutaArchivo = "./contactos.json";
		
		static public List<Contacto> abrirArchivo()
		{
			try {
				string json = File.ReadAllText(rutaArchivo);
				return JsonConvert.DeserializeObject<List<Contacto>>(json);
			} catch (FileNotFoundException) {
				return new List<Contacto>();
			} catch (ContactoInvalido) {
				return new List<Contacto>();
			}
		}
			
		
		static public void guardarContactos(ref List<Contacto> Contactos)
		{
			string json = JsonConvert.SerializeObject(Contactos);
			File.WriteAllText(rutaArchivo, json);
		}
	}
}