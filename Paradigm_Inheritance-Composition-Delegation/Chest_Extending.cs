using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm_Inheritance_Composition_Delegation {
	class ExtendedChest : Container {
		public ExtendedChest(int capacity) : base("Quader", capacity) {
			
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
	}
}
