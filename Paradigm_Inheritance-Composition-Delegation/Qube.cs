using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm_Inheritance_Composition_Delegation {
	class Qube : PhysicalObject {
		protected double length;

		public Qube(string material, string colour, double weight, double length) : base(material, colour, weight) {
			this.length = length;
		}

		public double GetLength() {
			return this.length;
		}
	}
}
