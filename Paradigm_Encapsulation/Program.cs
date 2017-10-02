using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm_Encapsulation {
	class Program {
		static void Main(string[] args) {
			Container c = new Container(true, 1.0, "kugel", "schokolade");
			if(c.mobile) {
				//Irgendeine Funktionalität wird aufgerufen womit der Container auf eine Bahn gesetzt wird und losrollt :)
				c.mobile = false; //Plötzlich kann unser Container nicht mehr bewegt werden weil entweder zu gross, zu schwer oder die Form zu dämlich ist. Gründe müssen keine angegeben werden.
			}
			
			if(c.mobile) {
				//Nochmals losrollen lassen ;)
				//Jedoch nicht möglich da uns der vorherige Lappen den Wert umgestellt hat und die Prüfung immer false zurückgibt und somit das losrollen nie ausgeführt wird.
				c.mobile = true; //Auch nicht hilfreich weil dieser Code nie ausgeführt wird aufgr. vorangehender Erklärung.
			}

			BetterContainer bc = new BetterContainer(true, 2.0, "kugel", "metall"); //Nun wird ein besserer Container erstellt welches sein Leben lang rollen kann
			if(bc.IsMobile()) { //Ist nun ein Methodenaufruf daher die () am Ende
				//Roll the hell out of it
				bc.mobile = false; //Fehler, da sowas nicht zulässig ist aufgrund der Sichtbarkeit der Eigenschaft
			}

			if(bc.IsMobile()) {
				//Roll again mate
			}

			while(bc.IsMobile()) {
				//Roll as long as you can and hopefully never stop
			}
		}
	}
}
