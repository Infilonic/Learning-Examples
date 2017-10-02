using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm_Inheritance_Composition_Delegation {
	class Chest {
		private Container container;

		private Chest() {

		}

		public Chest(int capacity) {
			this.container = new Container("Quader", capacity);
		}

		public bool Open() {
			return this.MoveCover(90);
		}

		public bool Close() {
			return this.MoveCover(-90);
		}

		private bool MoveCover(int degree) {
			//Angenommen hier bewegt sich die Abdeckung der Truhe
			return true;
		}

		public PhysicalObject[] Put(PhysicalObject[] obj) {
			return this.container.Fill(obj);
		}

		public PhysicalObject[] Take(int amount) {
			return this.container.GetObject(1);
		}
	}
}
