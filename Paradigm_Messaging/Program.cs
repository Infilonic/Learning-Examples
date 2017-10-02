using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm_Messaging {
	class Program {
		static void Main(string[] args) {
			Container c = new Container(true, 1.0, "zylinder", "wasser"); //Nachricht welche der anderen Klasse beim Aufruf ihrer Container-Methode übergeben wird.
			c.Empty(0.5);
			c.Fill(0.2);
			c.FillElement();
			c.FillLevel();
			string element = c.FillElement(); //Erhalten eine Nachricht zurück. Inhalt wird in Variable gespeichert.
			double menge = c.FillLevel(); //Analog zu Z. 15
		}
	}
}
