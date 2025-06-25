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
		
		static List<Contacto> abrirArchivo()
		{
			string json = File.ReadAllText(rutaArchivo);
			return JsonConvert.DeserializeObject<List<Contacto>>(json);
		}
		
		static void guardarEnArchivo(Contacto contacto)
		{
			var contactos = abrirArchivo();
			contactos.Add(contacto);
			string json = JsonConvert.SerializeObject(rutaArchivo);
		}
	}
}