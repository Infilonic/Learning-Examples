using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm_Messaging {
	class Container {
		bool mobile;
		double volume;
		string form;
		string fill;

		public Container() {
			//Intentionally left blank
		}

		public Container(bool mobile, double volume, string form, string fill) { //Erwartet 4 Unterschiedliche Informationen vom Aufrufer bevor ausgeführt wird
			this.mobile = mobile; //Speichert die übergebene Information in Instanzeigener Variable.
			this.volume = volume; //Analog Z.19
			this.form = form; //Analog Z.19
			this.fill = fill; //Analog Z.19
		}

		public void Fill(double amount) { //Analog Z. 18
			this.volume = this.volume + amount; //Addiert zuerst den erhaltenen Wert zum Wert des momentanem Volumen, danach erhält die Instanzeigene Variable den errechneten Wert
		}

		public void Empty(double amount) { //Analog Z. 18
			this.volume = this.volume - amount; //Analog Z. 26
		}

		public double FillLevel() {
			return this.volume; //Gibt eine Nachricht an den Aufrufer zurück
		}

		public string FillElement() {
			return this.fill; //Analog Z. 34
		}
	}
}
