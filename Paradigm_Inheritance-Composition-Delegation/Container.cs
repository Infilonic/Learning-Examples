using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm_Inheritance_Composition_Delegation {
	class Container {
		protected string form;
		protected PhysicalObject[] fill;

		private Container() {
			//Intentionally left blank
		}

		public Container(string form, int capacity) {
			this.form = form;
			this.fill = new PhysicalObject[capacity];
		}

		public PhysicalObject[] Fill(PhysicalObject[] obj) {
			int objIndex = obj.Length;
			for(int i = 0; i < this.fill.Length && !(objIndex < 0); i++) {
				if(this.fill[i] == null) {
					this.fill[i] = obj[--objIndex];
					obj[objIndex] = null;
				}
			}

			PhysicalObject[] objects = new PhysicalObject[objIndex]; ;
			if (objIndex > 0) {
				for (int i = 0; i < obj.Length || objIndex > 0; i++) {
					if (obj[i] != null) {
						objects[--objIndex] = obj[i];
					}
				}
			}
			return objects;
		}

		public PhysicalObject[] Empty() {
			PhysicalObject[] objects = this.fill;
			this.fill = null;
			return objects;
		}

		public PhysicalObject[] GetObject(int amount) {
			amount = (amount > this.fill.Length) ? this.fill.Length : amount;
			PhysicalObject[] objects = new PhysicalObject[amount];
			for(int i = 0; i < fill.Length || amount > 0; i++) {
				if(this.fill[i] != null) {
					objects[amount--] = this.fill[i];
				}
			}
			return objects;
		}

		public int FillLevel() {
			int level = 0;
			for(int i = 0; i < this.fill.Length; i++) {
				if(this.fill[i] != null) {
					level++;
				}
			}
			return level;
		}

		public bool IsMobile() {
			return !(this.FillLevel() > this.fill.Length / 2);
		}
	}
}
