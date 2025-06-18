using System;
using System.IO;
using Newtonsoft.Json;
using agenda_contactos;

namespace agenda_contactos
{
	/// <summary>
	/// Description of serializador.
	/// </summary>
	public static class SerializadorJSON
	{
		static Contacto abrirArchivo(string rutaArchivo)
		{
			string json = File.ReadAllText(rutaArchivo);
			return JsonConvert.DeserializeObject<Contacto>(json);
		}
		
	}
}