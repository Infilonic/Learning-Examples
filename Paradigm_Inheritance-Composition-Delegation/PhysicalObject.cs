using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm_Inheritance_Composition_Delegation {
	class PhysicalObject {
		protected string material;
		protected string colour;
		protected double weight;

		private PhysicalObject() {

		}

		public PhysicalObject(string material, string colour, double weight) {
			this.material = material;
			this.colour = colour;
			this.weight = weight;
		}

		public string GetMaterial() {
			return this.material;
		}

		public string GetColour() {
			return this.colour;
		}
	}
}
