using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm_Objects_Classes {
	class Container {
		bool mobile;
		double volume;
		string form;
		string fill;

		public Container() {
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
			this.volume = this.volume - amount;
		}

		public double FillLevel() {
			return this.volume;
		}

		public string FillElement() {
			return this.fill;
		}
	}
}
