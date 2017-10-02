using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm_Encapsulation {
	class Container {
		public bool mobile;
		private double volume;
		private string form;
		private string fill;

		private Container() { //Damit keine undefinierten Behälter entstehen können wird die Sichtbarkeit std. Konstruktor auf private gestellt
			//Intentionally left blank
		}

		public Container(bool mobile, double volume, string form, string fill) {
			this.mobile = mobile;
			this.volume = volume;
			this.form = form;
			this.fill = fill;
		}

		public void Fill(double amount) {
			this.volume = this.volume + amount;
		}

		public void Empty(double amount) {
			this.volume = (this.volume - amount < 0.0) ? 0.0 : this.volume - amount; //Kleine Anpassung um Negatives Volumen zu vermeiden, was rein logisch nicht ginge
		}

		public double FillLevel() {
			return this.volume;
		}

		public string FillElement() {
			return this.fill;
		}
	}
}
