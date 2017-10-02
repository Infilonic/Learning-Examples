using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonOO_Sharings {
	class Program {
		//Variable bzw. Referenzen
		static int a;
		static char b;
		static float c;
		static byte d;
		static bool e;
		static double f;
		static short g;
		 
		//Methoden bzw. Funktionen
		static void Main(string[] args) {
			//Methoden / Funktionsaufruf
			Program.A();
			Program.B();
			Program.C();
			Program.D();
			Program.E();
			Program.F();
			Program.G();

			//Wertezuweisung an Variable kombiniert mit Funktionsaufruf
			a = A();
			b = B();
			c = C();
			d = D();
			e = E();
			f = F();
			g = G();

			//Fehler bzw. bad practice
			a = B();
			b = C();
		}

		//Noch  mehr Methoden / Funktionen
		static int A() {
			return 0;
		}

		static char B() {
			return 'A';
		}

		static float C() {
			return 0.0f;
		}

		static byte D() {
			return 1;
		}

		static bool E() {
			return true;
		}

		static double F() {
			return 0.1;
		}

		static short G() {
			return 2;
		}
	}
}
