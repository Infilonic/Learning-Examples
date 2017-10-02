using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm_Inheritance_Composition_Delegation {
	class Sphere : PhysicalObject {
		protected double radius;

		public Sphere(string material, string colour, double weight, double radius) : base(material, colour, weight) {
			this.radius = radius;
		}
	}
}
