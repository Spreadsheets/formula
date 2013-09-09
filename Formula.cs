using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using Sheet;

namespace Jison
{
	public class Formula
	{
		public ParserSymbols Symbols;
		public Dictionary<int, ParserSymbol> Terminals;
		public Dictionary<int, ParserProduction> Productions;
		public Dictionary<int, ParserState> Table;
		public Dictionary<int, ParserAction> DefaultActions;
		public string Version = "0.4.2";
		public bool Debug = false;

		public const int None = 0;
		public const int Shift = 1;
		public const int Reduce = 2;
		public const int Accept = 3;

		public void Trace()
		{

		}

		public Formula()
		{
			//Setup Parser
			
			var symbol0 = new ParserSymbol("accept", 0);
			var symbol1 = new ParserSymbol("end", 1);
			var symbol2 = new ParserSymbol("error", 2);
			var symbol3 = new ParserSymbol("expressions", 3);
			var symbol4 = new ParserSymbol("expression", 4);
			var symbol5 = new ParserSymbol("EOF", 5);
			var symbol6 = new ParserSymbol("variableSequence", 6);
			var symbol7 = new ParserSymbol("TIME_AMPM", 7);
			var symbol8 = new ParserSymbol("TIME_24", 8);
			var symbol9 = new ParserSymbol("number", 9);
			var symbol10 = new ParserSymbol("STRING", 10);
			var symbol11 = new ParserSymbol("&", 11);
			var symbol12 = new ParserSymbol("=", 12);
			var symbol13 = new ParserSymbol("+", 13);
			var symbol14 = new ParserSymbol("(", 14);
			var symbol15 = new ParserSymbol(")", 15);
			var symbol16 = new ParserSymbol("<", 16);
			var symbol17 = new ParserSymbol(">", 17);
			var symbol18 = new ParserSymbol("NOT", 18);
			var symbol19 = new ParserSymbol("-", 19);
			var symbol20 = new ParserSymbol("*", 20);
			var symbol21 = new ParserSymbol("/", 21);
			var symbol22 = new ParserSymbol("^", 22);
			var symbol23 = new ParserSymbol("E", 23);
			var symbol24 = new ParserSymbol("FUNCTION", 24);
			var symbol25 = new ParserSymbol("expseq", 25);
			var symbol26 = new ParserSymbol("cell", 26);
			var symbol27 = new ParserSymbol("FIXEDCELL", 27);
			var symbol28 = new ParserSymbol(":", 28);
			var symbol29 = new ParserSymbol("CELL", 29);
			var symbol30 = new ParserSymbol("SHEET", 30);
			var symbol31 = new ParserSymbol("!", 31);
			var symbol32 = new ParserSymbol(";", 32);
			var symbol33 = new ParserSymbol(",", 33);
			var symbol34 = new ParserSymbol("VARIABLE", 34);
			var symbol35 = new ParserSymbol("DECIMAL", 35);
			var symbol36 = new ParserSymbol("NUMBER", 36);
			var symbol37 = new ParserSymbol("%", 37);
			var symbol38 = new ParserSymbol("#", 38);


			Symbols = new ParserSymbols();
			Symbols.Add(symbol0);
			Symbols.Add(symbol1);
			Symbols.Add(symbol2);
			Symbols.Add(symbol3);
			Symbols.Add(symbol4);
			Symbols.Add(symbol5);
			Symbols.Add(symbol6);
			Symbols.Add(symbol7);
			Symbols.Add(symbol8);
			Symbols.Add(symbol9);
			Symbols.Add(symbol10);
			Symbols.Add(symbol11);
			Symbols.Add(symbol12);
			Symbols.Add(symbol13);
			Symbols.Add(symbol14);
			Symbols.Add(symbol15);
			Symbols.Add(symbol16);
			Symbols.Add(symbol17);
			Symbols.Add(symbol18);
			Symbols.Add(symbol19);
			Symbols.Add(symbol20);
			Symbols.Add(symbol21);
			Symbols.Add(symbol22);
			Symbols.Add(symbol23);
			Symbols.Add(symbol24);
			Symbols.Add(symbol25);
			Symbols.Add(symbol26);
			Symbols.Add(symbol27);
			Symbols.Add(symbol28);
			Symbols.Add(symbol29);
			Symbols.Add(symbol30);
			Symbols.Add(symbol31);
			Symbols.Add(symbol32);
			Symbols.Add(symbol33);
			Symbols.Add(symbol34);
			Symbols.Add(symbol35);
			Symbols.Add(symbol36);
			Symbols.Add(symbol37);
			Symbols.Add(symbol38);

			Terminals = new Dictionary<int, ParserSymbol>
				{
					{5, symbol5},
					{7, symbol7},
					{8, symbol8},
					{10, symbol10},
					{11, symbol11},
					{12, symbol12},
					{13, symbol13},
					{14, symbol14},
					{15, symbol15},
					{16, symbol16},
					{17, symbol17},
					{18, symbol18},
					{19, symbol19},
					{20, symbol20},
					{21, symbol21},
					{22, symbol22},
					{23, symbol23},
					{24, symbol24},
					{27, symbol27},
					{28, symbol28},
					{29, symbol29},
					{30, symbol30},
					{31, symbol31},
					{32, symbol32},
					{33, symbol33},
					{34, symbol34},
					{35, symbol35},
					{36, symbol36},
					{37, symbol37},
					{38, symbol38}
				};

			var table0 = new ParserState(0);
			var table1 = new ParserState(1);
			var table2 = new ParserState(2);
			var table3 = new ParserState(3);
			var table4 = new ParserState(4);
			var table5 = new ParserState(5);
			var table6 = new ParserState(6);
			var table7 = new ParserState(7);
			var table8 = new ParserState(8);
			var table9 = new ParserState(9);
			var table10 = new ParserState(10);
			var table11 = new ParserState(11);
			var table12 = new ParserState(12);
			var table13 = new ParserState(13);
			var table14 = new ParserState(14);
			var table15 = new ParserState(15);
			var table16 = new ParserState(16);
			var table17 = new ParserState(17);
			var table18 = new ParserState(18);
			var table19 = new ParserState(19);
			var table20 = new ParserState(20);
			var table21 = new ParserState(21);
			var table22 = new ParserState(22);
			var table23 = new ParserState(23);
			var table24 = new ParserState(24);
			var table25 = new ParserState(25);
			var table26 = new ParserState(26);
			var table27 = new ParserState(27);
			var table28 = new ParserState(28);
			var table29 = new ParserState(29);
			var table30 = new ParserState(30);
			var table31 = new ParserState(31);
			var table32 = new ParserState(32);
			var table33 = new ParserState(33);
			var table34 = new ParserState(34);
			var table35 = new ParserState(35);
			var table36 = new ParserState(36);
			var table37 = new ParserState(37);
			var table38 = new ParserState(38);
			var table39 = new ParserState(39);
			var table40 = new ParserState(40);
			var table41 = new ParserState(41);
			var table42 = new ParserState(42);
			var table43 = new ParserState(43);
			var table44 = new ParserState(44);
			var table45 = new ParserState(45);
			var table46 = new ParserState(46);
			var table47 = new ParserState(47);
			var table48 = new ParserState(48);
			var table49 = new ParserState(49);
			var table50 = new ParserState(50);
			var table51 = new ParserState(51);
			var table52 = new ParserState(52);
			var table53 = new ParserState(53);
			var table54 = new ParserState(54);
			var table55 = new ParserState(55);
			var table56 = new ParserState(56);
			var table57 = new ParserState(57);
			var table58 = new ParserState(58);
			var table59 = new ParserState(59);
			var table60 = new ParserState(60);
			var table61 = new ParserState(61);
			var table62 = new ParserState(62);
			var table63 = new ParserState(63);
			var table64 = new ParserState(64);
			var table65 = new ParserState(65);
			var table66 = new ParserState(66);
			var table67 = new ParserState(67);
			var table68 = new ParserState(68);
			var table69 = new ParserState(69);
			var table70 = new ParserState(70);
			var table71 = new ParserState(71);
			var table72 = new ParserState(72);
			var table73 = new ParserState(73);
			var table74 = new ParserState(74);
			var table75 = new ParserState(75);
			var table76 = new ParserState(76);
			var table77 = new ParserState(77);
			var table78 = new ParserState(78);
			var table79 = new ParserState(79);
			var table80 = new ParserState(80);

			var tableDefinition0 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{3, new ParserAction(None, ref table1)},
					{4, new ParserAction(None, ref table2)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition1 = new Dictionary<int, ParserAction>
				{
					{1, new ParserAction(Accept)}
				};

			var tableDefinition2 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Shift, ref table21)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Shift, ref table23)},
					{13, new ParserAction(Shift, ref table24)},
					{16, new ParserAction(Shift, ref table25)},
					{17, new ParserAction(Shift, ref table26)},
					{18, new ParserAction(Shift, ref table27)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)}
				};

			var tableDefinition3 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table2)},
					{11, new ParserAction(Reduce, ref table2)},
					{12, new ParserAction(Reduce, ref table2)},
					{13, new ParserAction(Reduce, ref table2)},
					{15, new ParserAction(Reduce, ref table2)},
					{16, new ParserAction(Reduce, ref table2)},
					{17, new ParserAction(Reduce, ref table2)},
					{18, new ParserAction(Reduce, ref table2)},
					{19, new ParserAction(Reduce, ref table2)},
					{20, new ParserAction(Reduce, ref table2)},
					{21, new ParserAction(Reduce, ref table2)},
					{22, new ParserAction(Reduce, ref table2)},
					{32, new ParserAction(Reduce, ref table2)},
					{33, new ParserAction(Reduce, ref table2)},
					{35, new ParserAction(Shift, ref table32)}
				};

			var tableDefinition4 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table3)},
					{11, new ParserAction(Reduce, ref table3)},
					{12, new ParserAction(Reduce, ref table3)},
					{13, new ParserAction(Reduce, ref table3)},
					{15, new ParserAction(Reduce, ref table3)},
					{16, new ParserAction(Reduce, ref table3)},
					{17, new ParserAction(Reduce, ref table3)},
					{18, new ParserAction(Reduce, ref table3)},
					{19, new ParserAction(Reduce, ref table3)},
					{20, new ParserAction(Reduce, ref table3)},
					{21, new ParserAction(Reduce, ref table3)},
					{22, new ParserAction(Reduce, ref table3)},
					{32, new ParserAction(Reduce, ref table3)},
					{33, new ParserAction(Reduce, ref table3)}
				};

			var tableDefinition5 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table4)},
					{11, new ParserAction(Reduce, ref table4)},
					{12, new ParserAction(Reduce, ref table4)},
					{13, new ParserAction(Reduce, ref table4)},
					{15, new ParserAction(Reduce, ref table4)},
					{16, new ParserAction(Reduce, ref table4)},
					{17, new ParserAction(Reduce, ref table4)},
					{18, new ParserAction(Reduce, ref table4)},
					{19, new ParserAction(Reduce, ref table4)},
					{20, new ParserAction(Reduce, ref table4)},
					{21, new ParserAction(Reduce, ref table4)},
					{22, new ParserAction(Reduce, ref table4)},
					{32, new ParserAction(Reduce, ref table4)},
					{33, new ParserAction(Reduce, ref table4)}
				};

			var tableDefinition6 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table5)},
					{11, new ParserAction(Reduce, ref table5)},
					{12, new ParserAction(Reduce, ref table5)},
					{13, new ParserAction(Reduce, ref table5)},
					{15, new ParserAction(Reduce, ref table5)},
					{16, new ParserAction(Reduce, ref table5)},
					{17, new ParserAction(Reduce, ref table5)},
					{18, new ParserAction(Reduce, ref table5)},
					{19, new ParserAction(Reduce, ref table5)},
					{20, new ParserAction(Reduce, ref table5)},
					{21, new ParserAction(Reduce, ref table5)},
					{22, new ParserAction(Reduce, ref table5)},
					{32, new ParserAction(Reduce, ref table5)},
					{33, new ParserAction(Reduce, ref table5)},
					{37, new ParserAction(Shift, ref table33)}
				};

			var tableDefinition7 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table6)},
					{11, new ParserAction(Reduce, ref table6)},
					{12, new ParserAction(Reduce, ref table6)},
					{13, new ParserAction(Reduce, ref table6)},
					{15, new ParserAction(Reduce, ref table6)},
					{16, new ParserAction(Reduce, ref table6)},
					{17, new ParserAction(Reduce, ref table6)},
					{18, new ParserAction(Reduce, ref table6)},
					{19, new ParserAction(Reduce, ref table6)},
					{20, new ParserAction(Reduce, ref table6)},
					{21, new ParserAction(Reduce, ref table6)},
					{22, new ParserAction(Reduce, ref table6)},
					{32, new ParserAction(Reduce, ref table6)},
					{33, new ParserAction(Reduce, ref table6)}
				};

			var tableDefinition8 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table34)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition9 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table35)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition10 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table36)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition11 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table23)},
					{11, new ParserAction(Reduce, ref table23)},
					{12, new ParserAction(Reduce, ref table23)},
					{13, new ParserAction(Reduce, ref table23)},
					{15, new ParserAction(Reduce, ref table23)},
					{16, new ParserAction(Reduce, ref table23)},
					{17, new ParserAction(Reduce, ref table23)},
					{18, new ParserAction(Reduce, ref table23)},
					{19, new ParserAction(Reduce, ref table23)},
					{20, new ParserAction(Reduce, ref table23)},
					{21, new ParserAction(Reduce, ref table23)},
					{22, new ParserAction(Reduce, ref table23)},
					{32, new ParserAction(Reduce, ref table23)},
					{33, new ParserAction(Reduce, ref table23)}
				};

			var tableDefinition12 = new Dictionary<int, ParserAction>
				{
					{14, new ParserAction(Shift, ref table37)}
				};

			var tableDefinition13 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table26)},
					{11, new ParserAction(Reduce, ref table26)},
					{12, new ParserAction(Reduce, ref table26)},
					{13, new ParserAction(Reduce, ref table26)},
					{15, new ParserAction(Reduce, ref table26)},
					{16, new ParserAction(Reduce, ref table26)},
					{17, new ParserAction(Reduce, ref table26)},
					{18, new ParserAction(Reduce, ref table26)},
					{19, new ParserAction(Reduce, ref table26)},
					{20, new ParserAction(Reduce, ref table26)},
					{21, new ParserAction(Reduce, ref table26)},
					{22, new ParserAction(Reduce, ref table26)},
					{32, new ParserAction(Reduce, ref table26)},
					{33, new ParserAction(Reduce, ref table26)}
				};

			var tableDefinition14 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table38)},
					{5, new ParserAction(Reduce, ref table27)},
					{11, new ParserAction(Reduce, ref table27)},
					{12, new ParserAction(Reduce, ref table27)},
					{13, new ParserAction(Reduce, ref table27)},
					{15, new ParserAction(Reduce, ref table27)},
					{16, new ParserAction(Reduce, ref table27)},
					{17, new ParserAction(Reduce, ref table27)},
					{18, new ParserAction(Reduce, ref table27)},
					{19, new ParserAction(Reduce, ref table27)},
					{20, new ParserAction(Reduce, ref table27)},
					{21, new ParserAction(Reduce, ref table27)},
					{22, new ParserAction(Reduce, ref table27)},
					{32, new ParserAction(Reduce, ref table27)},
					{33, new ParserAction(Reduce, ref table27)},
					{34, new ParserAction(Shift, ref table39)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition15 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table38)},
					{11, new ParserAction(Reduce, ref table38)},
					{12, new ParserAction(Reduce, ref table38)},
					{13, new ParserAction(Reduce, ref table38)},
					{15, new ParserAction(Reduce, ref table38)},
					{16, new ParserAction(Reduce, ref table38)},
					{17, new ParserAction(Reduce, ref table38)},
					{18, new ParserAction(Reduce, ref table38)},
					{19, new ParserAction(Reduce, ref table38)},
					{20, new ParserAction(Reduce, ref table38)},
					{21, new ParserAction(Reduce, ref table38)},
					{22, new ParserAction(Reduce, ref table38)},
					{32, new ParserAction(Reduce, ref table38)},
					{33, new ParserAction(Reduce, ref table38)},
					{35, new ParserAction(Reduce, ref table38)},
					{38, new ParserAction(Shift, ref table40)}
				};

			var tableDefinition16 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table40)},
					{11, new ParserAction(Reduce, ref table40)},
					{12, new ParserAction(Reduce, ref table40)},
					{13, new ParserAction(Reduce, ref table40)},
					{15, new ParserAction(Reduce, ref table40)},
					{16, new ParserAction(Reduce, ref table40)},
					{17, new ParserAction(Reduce, ref table40)},
					{18, new ParserAction(Reduce, ref table40)},
					{19, new ParserAction(Reduce, ref table40)},
					{20, new ParserAction(Reduce, ref table40)},
					{21, new ParserAction(Reduce, ref table40)},
					{22, new ParserAction(Reduce, ref table40)},
					{32, new ParserAction(Reduce, ref table40)},
					{33, new ParserAction(Reduce, ref table40)},
					{35, new ParserAction(Shift, ref table41)},
					{37, new ParserAction(Reduce, ref table40)}
				};

			var tableDefinition17 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table29)},
					{11, new ParserAction(Reduce, ref table29)},
					{12, new ParserAction(Reduce, ref table29)},
					{13, new ParserAction(Reduce, ref table29)},
					{15, new ParserAction(Reduce, ref table29)},
					{16, new ParserAction(Reduce, ref table29)},
					{17, new ParserAction(Reduce, ref table29)},
					{18, new ParserAction(Reduce, ref table29)},
					{19, new ParserAction(Reduce, ref table29)},
					{20, new ParserAction(Reduce, ref table29)},
					{21, new ParserAction(Reduce, ref table29)},
					{22, new ParserAction(Reduce, ref table29)},
					{28, new ParserAction(Shift, ref table42)},
					{32, new ParserAction(Reduce, ref table29)},
					{33, new ParserAction(Reduce, ref table29)}
				};

			var tableDefinition18 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table31)},
					{11, new ParserAction(Reduce, ref table31)},
					{12, new ParserAction(Reduce, ref table31)},
					{13, new ParserAction(Reduce, ref table31)},
					{15, new ParserAction(Reduce, ref table31)},
					{16, new ParserAction(Reduce, ref table31)},
					{17, new ParserAction(Reduce, ref table31)},
					{18, new ParserAction(Reduce, ref table31)},
					{19, new ParserAction(Reduce, ref table31)},
					{20, new ParserAction(Reduce, ref table31)},
					{21, new ParserAction(Reduce, ref table31)},
					{22, new ParserAction(Reduce, ref table31)},
					{28, new ParserAction(Shift, ref table43)},
					{32, new ParserAction(Reduce, ref table31)},
					{33, new ParserAction(Reduce, ref table31)}
				};

			var tableDefinition19 = new Dictionary<int, ParserAction>
				{
					{31, new ParserAction(Shift, ref table44)}
				};

			var tableDefinition20 = new Dictionary<int, ParserAction>
				{
					{34, new ParserAction(Shift, ref table45)}
				};

			var tableDefinition21 = new Dictionary<int, ParserAction>
				{
					{1, new ParserAction(Reduce, ref table1)}
				};

			var tableDefinition22 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table46)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition23 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table47)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition24 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table48)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition25 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table51)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{12, new ParserAction(Shift, ref table49)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{17, new ParserAction(Shift, ref table50)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition26 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table53)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{12, new ParserAction(Shift, ref table52)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition27 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table54)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition28 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table55)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition29 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table56)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition30 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table57)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition31 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table58)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition32 = new Dictionary<int, ParserAction>
				{
					{34, new ParserAction(Shift, ref table59)}
				};

			var tableDefinition33 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table42)},
					{11, new ParserAction(Reduce, ref table42)},
					{12, new ParserAction(Reduce, ref table42)},
					{13, new ParserAction(Reduce, ref table42)},
					{15, new ParserAction(Reduce, ref table42)},
					{16, new ParserAction(Reduce, ref table42)},
					{17, new ParserAction(Reduce, ref table42)},
					{18, new ParserAction(Reduce, ref table42)},
					{19, new ParserAction(Reduce, ref table42)},
					{20, new ParserAction(Reduce, ref table42)},
					{21, new ParserAction(Reduce, ref table42)},
					{22, new ParserAction(Reduce, ref table42)},
					{32, new ParserAction(Reduce, ref table42)},
					{33, new ParserAction(Reduce, ref table42)},
					{37, new ParserAction(Reduce, ref table42)}
				};

			var tableDefinition34 = new Dictionary<int, ParserAction>
				{
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Shift, ref table23)},
					{13, new ParserAction(Shift, ref table24)},
					{15, new ParserAction(Shift, ref table60)},
					{16, new ParserAction(Shift, ref table25)},
					{17, new ParserAction(Shift, ref table26)},
					{18, new ParserAction(Shift, ref table27)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)}
				};

			var tableDefinition35 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table21)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table21)},
					{13, new ParserAction(Reduce, ref table21)},
					{15, new ParserAction(Reduce, ref table21)},
					{16, new ParserAction(Reduce, ref table21)},
					{17, new ParserAction(Reduce, ref table21)},
					{18, new ParserAction(Reduce, ref table21)},
					{19, new ParserAction(Reduce, ref table21)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table21)},
					{33, new ParserAction(Reduce, ref table21)}
				};

			var tableDefinition36 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table22)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table22)},
					{13, new ParserAction(Reduce, ref table22)},
					{15, new ParserAction(Reduce, ref table22)},
					{16, new ParserAction(Reduce, ref table22)},
					{17, new ParserAction(Reduce, ref table22)},
					{18, new ParserAction(Reduce, ref table22)},
					{19, new ParserAction(Reduce, ref table22)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table22)},
					{33, new ParserAction(Reduce, ref table22)}
				};

			var tableDefinition37 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table63)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{15, new ParserAction(Shift, ref table61)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{25, new ParserAction(None, ref table62)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition38 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table28)},
					{11, new ParserAction(Reduce, ref table28)},
					{12, new ParserAction(Reduce, ref table28)},
					{13, new ParserAction(Reduce, ref table28)},
					{15, new ParserAction(Reduce, ref table28)},
					{16, new ParserAction(Reduce, ref table28)},
					{17, new ParserAction(Reduce, ref table28)},
					{18, new ParserAction(Reduce, ref table28)},
					{19, new ParserAction(Reduce, ref table28)},
					{20, new ParserAction(Reduce, ref table28)},
					{21, new ParserAction(Reduce, ref table28)},
					{22, new ParserAction(Reduce, ref table28)},
					{32, new ParserAction(Reduce, ref table28)},
					{33, new ParserAction(Reduce, ref table28)}
				};

			var tableDefinition39 = new Dictionary<int, ParserAction>
				{
					{38, new ParserAction(Shift, ref table40)}
				};

			var tableDefinition40 = new Dictionary<int, ParserAction>
				{
					{34, new ParserAction(Shift, ref table64)}
				};

			var tableDefinition41 = new Dictionary<int, ParserAction>
				{
					{36, new ParserAction(Shift, ref table65)}
				};

			var tableDefinition42 = new Dictionary<int, ParserAction>
				{
					{27, new ParserAction(Shift, ref table66)}
				};

			var tableDefinition43 = new Dictionary<int, ParserAction>
				{
					{29, new ParserAction(Shift, ref table67)}
				};

			var tableDefinition44 = new Dictionary<int, ParserAction>
				{
					{29, new ParserAction(Shift, ref table68)}
				};

			var tableDefinition45 = new Dictionary<int, ParserAction>
				{
					{31, new ParserAction(Shift, ref table69)}
				};

			var tableDefinition46 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table7)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Shift, ref table23)},
					{13, new ParserAction(Shift, ref table24)},
					{15, new ParserAction(Reduce, ref table7)},
					{16, new ParserAction(Shift, ref table25)},
					{17, new ParserAction(Shift, ref table26)},
					{18, new ParserAction(Shift, ref table27)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table7)},
					{33, new ParserAction(Reduce, ref table7)}
				};

			var tableDefinition47 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table8)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table8)},
					{13, new ParserAction(Shift, ref table24)},
					{15, new ParserAction(Reduce, ref table8)},
					{16, new ParserAction(Shift, ref table25)},
					{17, new ParserAction(Shift, ref table26)},
					{18, new ParserAction(Shift, ref table27)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table8)},
					{33, new ParserAction(Reduce, ref table8)}
				};

			var tableDefinition48 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table9)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table9)},
					{13, new ParserAction(Reduce, ref table9)},
					{15, new ParserAction(Reduce, ref table9)},
					{16, new ParserAction(Reduce, ref table9)},
					{17, new ParserAction(Reduce, ref table9)},
					{18, new ParserAction(Reduce, ref table9)},
					{19, new ParserAction(Reduce, ref table9)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table9)},
					{33, new ParserAction(Reduce, ref table9)}
				};

			var tableDefinition49 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table70)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition50 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table71)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition51 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table16)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table16)},
					{13, new ParserAction(Shift, ref table24)},
					{15, new ParserAction(Reduce, ref table16)},
					{16, new ParserAction(Reduce, ref table16)},
					{17, new ParserAction(Reduce, ref table16)},
					{18, new ParserAction(Reduce, ref table16)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table16)},
					{33, new ParserAction(Reduce, ref table16)}
				};

			var tableDefinition52 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table72)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition53 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table15)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table15)},
					{13, new ParserAction(Shift, ref table24)},
					{15, new ParserAction(Reduce, ref table15)},
					{16, new ParserAction(Reduce, ref table15)},
					{17, new ParserAction(Reduce, ref table15)},
					{18, new ParserAction(Reduce, ref table15)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table15)},
					{33, new ParserAction(Reduce, ref table15)}
				};

			var tableDefinition54 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table14)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table14)},
					{13, new ParserAction(Shift, ref table24)},
					{15, new ParserAction(Reduce, ref table14)},
					{16, new ParserAction(Shift, ref table25)},
					{17, new ParserAction(Shift, ref table26)},
					{18, new ParserAction(Reduce, ref table14)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table14)},
					{33, new ParserAction(Reduce, ref table14)}
				};

			var tableDefinition55 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table17)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table17)},
					{13, new ParserAction(Reduce, ref table17)},
					{15, new ParserAction(Reduce, ref table17)},
					{16, new ParserAction(Reduce, ref table17)},
					{17, new ParserAction(Reduce, ref table17)},
					{18, new ParserAction(Reduce, ref table17)},
					{19, new ParserAction(Reduce, ref table17)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table17)},
					{33, new ParserAction(Reduce, ref table17)}
				};

			var tableDefinition56 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table18)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table18)},
					{13, new ParserAction(Reduce, ref table18)},
					{15, new ParserAction(Reduce, ref table18)},
					{16, new ParserAction(Reduce, ref table18)},
					{17, new ParserAction(Reduce, ref table18)},
					{18, new ParserAction(Reduce, ref table18)},
					{19, new ParserAction(Reduce, ref table18)},
					{20, new ParserAction(Reduce, ref table18)},
					{21, new ParserAction(Reduce, ref table18)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table18)},
					{33, new ParserAction(Reduce, ref table18)}
				};

			var tableDefinition57 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table19)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table19)},
					{13, new ParserAction(Reduce, ref table19)},
					{15, new ParserAction(Reduce, ref table19)},
					{16, new ParserAction(Reduce, ref table19)},
					{17, new ParserAction(Reduce, ref table19)},
					{18, new ParserAction(Reduce, ref table19)},
					{19, new ParserAction(Reduce, ref table19)},
					{20, new ParserAction(Reduce, ref table19)},
					{21, new ParserAction(Reduce, ref table19)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table19)},
					{33, new ParserAction(Reduce, ref table19)}
				};

			var tableDefinition58 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table20)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table20)},
					{13, new ParserAction(Reduce, ref table20)},
					{15, new ParserAction(Reduce, ref table20)},
					{16, new ParserAction(Reduce, ref table20)},
					{17, new ParserAction(Reduce, ref table20)},
					{18, new ParserAction(Reduce, ref table20)},
					{19, new ParserAction(Reduce, ref table20)},
					{20, new ParserAction(Reduce, ref table20)},
					{21, new ParserAction(Reduce, ref table20)},
					{22, new ParserAction(Reduce, ref table20)},
					{32, new ParserAction(Reduce, ref table20)},
					{33, new ParserAction(Reduce, ref table20)}
				};

			var tableDefinition59 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table39)},
					{11, new ParserAction(Reduce, ref table39)},
					{12, new ParserAction(Reduce, ref table39)},
					{13, new ParserAction(Reduce, ref table39)},
					{15, new ParserAction(Reduce, ref table39)},
					{16, new ParserAction(Reduce, ref table39)},
					{17, new ParserAction(Reduce, ref table39)},
					{18, new ParserAction(Reduce, ref table39)},
					{19, new ParserAction(Reduce, ref table39)},
					{20, new ParserAction(Reduce, ref table39)},
					{21, new ParserAction(Reduce, ref table39)},
					{22, new ParserAction(Reduce, ref table39)},
					{32, new ParserAction(Reduce, ref table39)},
					{33, new ParserAction(Reduce, ref table39)},
					{35, new ParserAction(Reduce, ref table39)}
				};

			var tableDefinition60 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table10)},
					{11, new ParserAction(Reduce, ref table10)},
					{12, new ParserAction(Reduce, ref table10)},
					{13, new ParserAction(Reduce, ref table10)},
					{15, new ParserAction(Reduce, ref table10)},
					{16, new ParserAction(Reduce, ref table10)},
					{17, new ParserAction(Reduce, ref table10)},
					{18, new ParserAction(Reduce, ref table10)},
					{19, new ParserAction(Reduce, ref table10)},
					{20, new ParserAction(Reduce, ref table10)},
					{21, new ParserAction(Reduce, ref table10)},
					{22, new ParserAction(Reduce, ref table10)},
					{32, new ParserAction(Reduce, ref table10)},
					{33, new ParserAction(Reduce, ref table10)}
				};

			var tableDefinition61 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table24)},
					{11, new ParserAction(Reduce, ref table24)},
					{12, new ParserAction(Reduce, ref table24)},
					{13, new ParserAction(Reduce, ref table24)},
					{15, new ParserAction(Reduce, ref table24)},
					{16, new ParserAction(Reduce, ref table24)},
					{17, new ParserAction(Reduce, ref table24)},
					{18, new ParserAction(Reduce, ref table24)},
					{19, new ParserAction(Reduce, ref table24)},
					{20, new ParserAction(Reduce, ref table24)},
					{21, new ParserAction(Reduce, ref table24)},
					{22, new ParserAction(Reduce, ref table24)},
					{32, new ParserAction(Reduce, ref table24)},
					{33, new ParserAction(Reduce, ref table24)}
				};

			var tableDefinition62 = new Dictionary<int, ParserAction>
				{
					{15, new ParserAction(Shift, ref table73)},
					{32, new ParserAction(Shift, ref table74)},
					{33, new ParserAction(Shift, ref table75)}
				};

			var tableDefinition63 = new Dictionary<int, ParserAction>
				{
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Shift, ref table23)},
					{13, new ParserAction(Shift, ref table24)},
					{15, new ParserAction(Reduce, ref table35)},
					{16, new ParserAction(Shift, ref table25)},
					{17, new ParserAction(Shift, ref table26)},
					{18, new ParserAction(Shift, ref table27)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table35)},
					{33, new ParserAction(Reduce, ref table35)}
				};

			var tableDefinition64 = new Dictionary<int, ParserAction>
				{
					{31, new ParserAction(Shift, ref table76)}
				};

			var tableDefinition65 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table41)},
					{11, new ParserAction(Reduce, ref table41)},
					{12, new ParserAction(Reduce, ref table41)},
					{13, new ParserAction(Reduce, ref table41)},
					{15, new ParserAction(Reduce, ref table41)},
					{16, new ParserAction(Reduce, ref table41)},
					{17, new ParserAction(Reduce, ref table41)},
					{18, new ParserAction(Reduce, ref table41)},
					{19, new ParserAction(Reduce, ref table41)},
					{20, new ParserAction(Reduce, ref table41)},
					{21, new ParserAction(Reduce, ref table41)},
					{22, new ParserAction(Reduce, ref table41)},
					{32, new ParserAction(Reduce, ref table41)},
					{33, new ParserAction(Reduce, ref table41)},
					{37, new ParserAction(Reduce, ref table41)}
				};

			var tableDefinition66 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table30)},
					{11, new ParserAction(Reduce, ref table30)},
					{12, new ParserAction(Reduce, ref table30)},
					{13, new ParserAction(Reduce, ref table30)},
					{15, new ParserAction(Reduce, ref table30)},
					{16, new ParserAction(Reduce, ref table30)},
					{17, new ParserAction(Reduce, ref table30)},
					{18, new ParserAction(Reduce, ref table30)},
					{19, new ParserAction(Reduce, ref table30)},
					{20, new ParserAction(Reduce, ref table30)},
					{21, new ParserAction(Reduce, ref table30)},
					{22, new ParserAction(Reduce, ref table30)},
					{32, new ParserAction(Reduce, ref table30)},
					{33, new ParserAction(Reduce, ref table30)}
				};

			var tableDefinition67 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table32)},
					{11, new ParserAction(Reduce, ref table32)},
					{12, new ParserAction(Reduce, ref table32)},
					{13, new ParserAction(Reduce, ref table32)},
					{15, new ParserAction(Reduce, ref table32)},
					{16, new ParserAction(Reduce, ref table32)},
					{17, new ParserAction(Reduce, ref table32)},
					{18, new ParserAction(Reduce, ref table32)},
					{19, new ParserAction(Reduce, ref table32)},
					{20, new ParserAction(Reduce, ref table32)},
					{21, new ParserAction(Reduce, ref table32)},
					{22, new ParserAction(Reduce, ref table32)},
					{32, new ParserAction(Reduce, ref table32)},
					{33, new ParserAction(Reduce, ref table32)}
				};

			var tableDefinition68 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table33)},
					{11, new ParserAction(Reduce, ref table33)},
					{12, new ParserAction(Reduce, ref table33)},
					{13, new ParserAction(Reduce, ref table33)},
					{15, new ParserAction(Reduce, ref table33)},
					{16, new ParserAction(Reduce, ref table33)},
					{17, new ParserAction(Reduce, ref table33)},
					{18, new ParserAction(Reduce, ref table33)},
					{19, new ParserAction(Reduce, ref table33)},
					{20, new ParserAction(Reduce, ref table33)},
					{21, new ParserAction(Reduce, ref table33)},
					{22, new ParserAction(Reduce, ref table33)},
					{28, new ParserAction(Shift, ref table77)},
					{32, new ParserAction(Reduce, ref table33)},
					{33, new ParserAction(Reduce, ref table33)}
				};

			var tableDefinition69 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table43)},
					{11, new ParserAction(Reduce, ref table43)},
					{12, new ParserAction(Reduce, ref table43)},
					{13, new ParserAction(Reduce, ref table43)},
					{15, new ParserAction(Reduce, ref table43)},
					{16, new ParserAction(Reduce, ref table43)},
					{17, new ParserAction(Reduce, ref table43)},
					{18, new ParserAction(Reduce, ref table43)},
					{19, new ParserAction(Reduce, ref table43)},
					{20, new ParserAction(Reduce, ref table43)},
					{21, new ParserAction(Reduce, ref table43)},
					{22, new ParserAction(Reduce, ref table43)},
					{32, new ParserAction(Reduce, ref table43)},
					{33, new ParserAction(Reduce, ref table43)},
					{34, new ParserAction(Reduce, ref table43)},
					{38, new ParserAction(Reduce, ref table43)}
				};

			var tableDefinition70 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table11)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table11)},
					{13, new ParserAction(Shift, ref table24)},
					{15, new ParserAction(Reduce, ref table11)},
					{16, new ParserAction(Reduce, ref table11)},
					{17, new ParserAction(Reduce, ref table11)},
					{18, new ParserAction(Reduce, ref table11)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table11)},
					{33, new ParserAction(Reduce, ref table11)}
				};

			var tableDefinition71 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table13)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table13)},
					{13, new ParserAction(Shift, ref table24)},
					{15, new ParserAction(Reduce, ref table13)},
					{16, new ParserAction(Reduce, ref table13)},
					{17, new ParserAction(Reduce, ref table13)},
					{18, new ParserAction(Reduce, ref table13)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table13)},
					{33, new ParserAction(Reduce, ref table13)}
				};

			var tableDefinition72 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table12)},
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Reduce, ref table12)},
					{13, new ParserAction(Shift, ref table24)},
					{15, new ParserAction(Reduce, ref table12)},
					{16, new ParserAction(Reduce, ref table12)},
					{17, new ParserAction(Reduce, ref table12)},
					{18, new ParserAction(Reduce, ref table12)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table12)},
					{33, new ParserAction(Reduce, ref table12)}
				};

			var tableDefinition73 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table25)},
					{11, new ParserAction(Reduce, ref table25)},
					{12, new ParserAction(Reduce, ref table25)},
					{13, new ParserAction(Reduce, ref table25)},
					{15, new ParserAction(Reduce, ref table25)},
					{16, new ParserAction(Reduce, ref table25)},
					{17, new ParserAction(Reduce, ref table25)},
					{18, new ParserAction(Reduce, ref table25)},
					{19, new ParserAction(Reduce, ref table25)},
					{20, new ParserAction(Reduce, ref table25)},
					{21, new ParserAction(Reduce, ref table25)},
					{22, new ParserAction(Reduce, ref table25)},
					{32, new ParserAction(Reduce, ref table25)},
					{33, new ParserAction(Reduce, ref table25)}
				};

			var tableDefinition74 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table78)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition75 = new Dictionary<int, ParserAction>
				{
					{2, new ParserAction(None, ref table14)},
					{4, new ParserAction(None, ref table79)},
					{6, new ParserAction(None, ref table3)},
					{7, new ParserAction(Shift, ref table4)},
					{8, new ParserAction(Shift, ref table5)},
					{9, new ParserAction(None, ref table6)},
					{10, new ParserAction(Shift, ref table7)},
					{13, new ParserAction(Shift, ref table10)},
					{14, new ParserAction(Shift, ref table8)},
					{19, new ParserAction(Shift, ref table9)},
					{23, new ParserAction(Shift, ref table11)},
					{24, new ParserAction(Shift, ref table12)},
					{26, new ParserAction(None, ref table13)},
					{27, new ParserAction(Shift, ref table17)},
					{29, new ParserAction(Shift, ref table18)},
					{30, new ParserAction(Shift, ref table19)},
					{34, new ParserAction(Shift, ref table15)},
					{36, new ParserAction(Shift, ref table16)},
					{38, new ParserAction(Shift, ref table20)}
				};

			var tableDefinition76 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table44)},
					{11, new ParserAction(Reduce, ref table44)},
					{12, new ParserAction(Reduce, ref table44)},
					{13, new ParserAction(Reduce, ref table44)},
					{15, new ParserAction(Reduce, ref table44)},
					{16, new ParserAction(Reduce, ref table44)},
					{17, new ParserAction(Reduce, ref table44)},
					{18, new ParserAction(Reduce, ref table44)},
					{19, new ParserAction(Reduce, ref table44)},
					{20, new ParserAction(Reduce, ref table44)},
					{21, new ParserAction(Reduce, ref table44)},
					{22, new ParserAction(Reduce, ref table44)},
					{32, new ParserAction(Reduce, ref table44)},
					{33, new ParserAction(Reduce, ref table44)},
					{34, new ParserAction(Reduce, ref table44)},
					{38, new ParserAction(Reduce, ref table44)}
				};

			var tableDefinition77 = new Dictionary<int, ParserAction>
				{
					{29, new ParserAction(Shift, ref table80)}
				};

			var tableDefinition78 = new Dictionary<int, ParserAction>
				{
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Shift, ref table23)},
					{13, new ParserAction(Shift, ref table24)},
					{15, new ParserAction(Reduce, ref table36)},
					{16, new ParserAction(Shift, ref table25)},
					{17, new ParserAction(Shift, ref table26)},
					{18, new ParserAction(Shift, ref table27)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table36)},
					{33, new ParserAction(Reduce, ref table36)}
				};

			var tableDefinition79 = new Dictionary<int, ParserAction>
				{
					{11, new ParserAction(Shift, ref table22)},
					{12, new ParserAction(Shift, ref table23)},
					{13, new ParserAction(Shift, ref table24)},
					{15, new ParserAction(Reduce, ref table37)},
					{16, new ParserAction(Shift, ref table25)},
					{17, new ParserAction(Shift, ref table26)},
					{18, new ParserAction(Shift, ref table27)},
					{19, new ParserAction(Shift, ref table28)},
					{20, new ParserAction(Shift, ref table29)},
					{21, new ParserAction(Shift, ref table30)},
					{22, new ParserAction(Shift, ref table31)},
					{32, new ParserAction(Reduce, ref table37)},
					{33, new ParserAction(Reduce, ref table37)}
				};

			var tableDefinition80 = new Dictionary<int, ParserAction>
				{
					{5, new ParserAction(Reduce, ref table34)},
					{11, new ParserAction(Reduce, ref table34)},
					{12, new ParserAction(Reduce, ref table34)},
					{13, new ParserAction(Reduce, ref table34)},
					{15, new ParserAction(Reduce, ref table34)},
					{16, new ParserAction(Reduce, ref table34)},
					{17, new ParserAction(Reduce, ref table34)},
					{18, new ParserAction(Reduce, ref table34)},
					{19, new ParserAction(Reduce, ref table34)},
					{20, new ParserAction(Reduce, ref table34)},
					{21, new ParserAction(Reduce, ref table34)},
					{22, new ParserAction(Reduce, ref table34)},
					{32, new ParserAction(Reduce, ref table34)},
					{33, new ParserAction(Reduce, ref table34)}
				};

			table0.SetActions(ref tableDefinition0);
			table1.SetActions(ref tableDefinition1);
			table2.SetActions(ref tableDefinition2);
			table3.SetActions(ref tableDefinition3);
			table4.SetActions(ref tableDefinition4);
			table5.SetActions(ref tableDefinition5);
			table6.SetActions(ref tableDefinition6);
			table7.SetActions(ref tableDefinition7);
			table8.SetActions(ref tableDefinition8);
			table9.SetActions(ref tableDefinition9);
			table10.SetActions(ref tableDefinition10);
			table11.SetActions(ref tableDefinition11);
			table12.SetActions(ref tableDefinition12);
			table13.SetActions(ref tableDefinition13);
			table14.SetActions(ref tableDefinition14);
			table15.SetActions(ref tableDefinition15);
			table16.SetActions(ref tableDefinition16);
			table17.SetActions(ref tableDefinition17);
			table18.SetActions(ref tableDefinition18);
			table19.SetActions(ref tableDefinition19);
			table20.SetActions(ref tableDefinition20);
			table21.SetActions(ref tableDefinition21);
			table22.SetActions(ref tableDefinition22);
			table23.SetActions(ref tableDefinition23);
			table24.SetActions(ref tableDefinition24);
			table25.SetActions(ref tableDefinition25);
			table26.SetActions(ref tableDefinition26);
			table27.SetActions(ref tableDefinition27);
			table28.SetActions(ref tableDefinition28);
			table29.SetActions(ref tableDefinition29);
			table30.SetActions(ref tableDefinition30);
			table31.SetActions(ref tableDefinition31);
			table32.SetActions(ref tableDefinition32);
			table33.SetActions(ref tableDefinition33);
			table34.SetActions(ref tableDefinition34);
			table35.SetActions(ref tableDefinition35);
			table36.SetActions(ref tableDefinition36);
			table37.SetActions(ref tableDefinition37);
			table38.SetActions(ref tableDefinition38);
			table39.SetActions(ref tableDefinition39);
			table40.SetActions(ref tableDefinition40);
			table41.SetActions(ref tableDefinition41);
			table42.SetActions(ref tableDefinition42);
			table43.SetActions(ref tableDefinition43);
			table44.SetActions(ref tableDefinition44);
			table45.SetActions(ref tableDefinition45);
			table46.SetActions(ref tableDefinition46);
			table47.SetActions(ref tableDefinition47);
			table48.SetActions(ref tableDefinition48);
			table49.SetActions(ref tableDefinition49);
			table50.SetActions(ref tableDefinition50);
			table51.SetActions(ref tableDefinition51);
			table52.SetActions(ref tableDefinition52);
			table53.SetActions(ref tableDefinition53);
			table54.SetActions(ref tableDefinition54);
			table55.SetActions(ref tableDefinition55);
			table56.SetActions(ref tableDefinition56);
			table57.SetActions(ref tableDefinition57);
			table58.SetActions(ref tableDefinition58);
			table59.SetActions(ref tableDefinition59);
			table60.SetActions(ref tableDefinition60);
			table61.SetActions(ref tableDefinition61);
			table62.SetActions(ref tableDefinition62);
			table63.SetActions(ref tableDefinition63);
			table64.SetActions(ref tableDefinition64);
			table65.SetActions(ref tableDefinition65);
			table66.SetActions(ref tableDefinition66);
			table67.SetActions(ref tableDefinition67);
			table68.SetActions(ref tableDefinition68);
			table69.SetActions(ref tableDefinition69);
			table70.SetActions(ref tableDefinition70);
			table71.SetActions(ref tableDefinition71);
			table72.SetActions(ref tableDefinition72);
			table73.SetActions(ref tableDefinition73);
			table74.SetActions(ref tableDefinition74);
			table75.SetActions(ref tableDefinition75);
			table76.SetActions(ref tableDefinition76);
			table77.SetActions(ref tableDefinition77);
			table78.SetActions(ref tableDefinition78);
			table79.SetActions(ref tableDefinition79);
			table80.SetActions(ref tableDefinition80);

			Table = new Dictionary<int, ParserState>
				{
					{0, table0},
					{1, table1},
					{2, table2},
					{3, table3},
					{4, table4},
					{5, table5},
					{6, table6},
					{7, table7},
					{8, table8},
					{9, table9},
					{10, table10},
					{11, table11},
					{12, table12},
					{13, table13},
					{14, table14},
					{15, table15},
					{16, table16},
					{17, table17},
					{18, table18},
					{19, table19},
					{20, table20},
					{21, table21},
					{22, table22},
					{23, table23},
					{24, table24},
					{25, table25},
					{26, table26},
					{27, table27},
					{28, table28},
					{29, table29},
					{30, table30},
					{31, table31},
					{32, table32},
					{33, table33},
					{34, table34},
					{35, table35},
					{36, table36},
					{37, table37},
					{38, table38},
					{39, table39},
					{40, table40},
					{41, table41},
					{42, table42},
					{43, table43},
					{44, table44},
					{45, table45},
					{46, table46},
					{47, table47},
					{48, table48},
					{49, table49},
					{50, table50},
					{51, table51},
					{52, table52},
					{53, table53},
					{54, table54},
					{55, table55},
					{56, table56},
					{57, table57},
					{58, table58},
					{59, table59},
					{60, table60},
					{61, table61},
					{62, table62},
					{63, table63},
					{64, table64},
					{65, table65},
					{66, table66},
					{67, table67},
					{68, table68},
					{69, table69},
					{70, table70},
					{71, table71},
					{72, table72},
					{73, table73},
					{74, table74},
					{75, table75},
					{76, table76},
					{77, table77},
					{78, table78},
					{79, table79},
					{80, table80}
				};

			DefaultActions = new Dictionary<int, ParserAction>
				{
					{21, new ParserAction(Reduce, ref table1)}
				};

			Productions = new Dictionary<int, ParserProduction>
				{				
					{0, new ParserProduction(symbol0)},
					{1, new ParserProduction(symbol3,2)},
					{2, new ParserProduction(symbol4,1)},
					{3, new ParserProduction(symbol4,1)},
					{4, new ParserProduction(symbol4,1)},
					{5, new ParserProduction(symbol4,1)},
					{6, new ParserProduction(symbol4,1)},
					{7, new ParserProduction(symbol4,3)},
					{8, new ParserProduction(symbol4,3)},
					{9, new ParserProduction(symbol4,3)},
					{10, new ParserProduction(symbol4,3)},
					{11, new ParserProduction(symbol4,4)},
					{12, new ParserProduction(symbol4,4)},
					{13, new ParserProduction(symbol4,4)},
					{14, new ParserProduction(symbol4,3)},
					{15, new ParserProduction(symbol4,3)},
					{16, new ParserProduction(symbol4,3)},
					{17, new ParserProduction(symbol4,3)},
					{18, new ParserProduction(symbol4,3)},
					{19, new ParserProduction(symbol4,3)},
					{20, new ParserProduction(symbol4,3)},
					{21, new ParserProduction(symbol4,2)},
					{22, new ParserProduction(symbol4,2)},
					{23, new ParserProduction(symbol4,1)},
					{24, new ParserProduction(symbol4,3)},
					{25, new ParserProduction(symbol4,4)},
					{26, new ParserProduction(symbol4,1)},
					{27, new ParserProduction(symbol4,1)},
					{28, new ParserProduction(symbol4,2)},
					{29, new ParserProduction(symbol26,1)},
					{30, new ParserProduction(symbol26,3)},
					{31, new ParserProduction(symbol26,1)},
					{32, new ParserProduction(symbol26,3)},
					{33, new ParserProduction(symbol26,3)},
					{34, new ParserProduction(symbol26,5)},
					{35, new ParserProduction(symbol25,1)},
					{36, new ParserProduction(symbol25,3)},
					{37, new ParserProduction(symbol25,3)},
					{38, new ParserProduction(symbol6,1)},
					{39, new ParserProduction(symbol6,3)},
					{40, new ParserProduction(symbol9,1)},
					{41, new ParserProduction(symbol9,3)},
					{42, new ParserProduction(symbol9,2)},
					{43, new ParserProduction(symbol2,3)},
					{44, new ParserProduction(symbol2,4)}
				};



			
			//Setup Lexer
			
			Rules = new Dictionary<int, Regex>
				{
					{0, new Regex(@"^(?:\s+)")},
					{1, new Regex(@"^(?:""(\\[""]|[^""])*"")")},
					{2, new Regex(@"^(?:'(\\[']|[^'])*')")},
					{3, new Regex(@"^(?:[A-Za-z]{1,}[A-Za-z_0-9]+(?=[(]))")},
					{4, new Regex(@"^(?:([0]?[1-9]|1[0-2])[:][0-5][0-9]([:][0-5][0-9])?[ ]?(AM|am|aM|Am|PM|pm|pM|Pm))")},
					{5, new Regex(@"^(?:([0]?[0-9]|1[0-9]|2[0-3])[:][0-5][0-9]([:][0-5][0-9])?)")},
					{6, new Regex(@"^(?:SHEET[0-9]+)")},
					{7, new Regex(@"^(?:\$[A-Za-z]+\$[0-9]+)")},
					{8, new Regex(@"^(?:[A-Za-z]+[0-9]+)")},
					{9, new Regex(@"^(?:[A-Za-z]+(?=[(]))")},
					{10, new Regex(@"^(?:[A-Za-z]{1,}[A-Za-z_0-9]+)")},
					{11, new Regex(@"^(?:[A-Za-z_]+)")},
					{12, new Regex(@"^(?:[0-9]+)")},
					{13, new Regex(@"^(?:\$)")},
					{14, new Regex(@"^(?:&)")},
					{15, new Regex(@"^(?: )")},
					{16, new Regex(@"^(?:[.])")},
					{17, new Regex(@"^(?::)")},
					{18, new Regex(@"^(?:;)")},
					{19, new Regex(@"^(?:,)")},
					{20, new Regex(@"^(?:\*)")},
					{21, new Regex(@"^(?:\/)")},
					{22, new Regex(@"^(?:-)")},
					{23, new Regex(@"^(?:\+)")},
					{24, new Regex(@"^(?:\^)")},
					{25, new Regex(@"^(?:\()")},
					{26, new Regex(@"^(?:\))")},
					{27, new Regex(@"^(?:>)")},
					{28, new Regex(@"^(?:<)")},
					{29, new Regex(@"^(?:NOT\b)")},
					{30, new Regex(@"^(?:PI\b)")},
					{31, new Regex(@"^(?:E\b)")},
					{32, new Regex(@"^(?:"")")},
					{33, new Regex(@"^(?:')")},
					{34, new Regex(@"^(?:!)")},
					{35, new Regex(@"^(?:=)")},
					{36, new Regex(@"^(?:%)")},
					{37, new Regex(@"^(?:[#])")},
					{38, new Regex(@"^(?:$)")}
				};

			Conditions = new Dictionary<string, LexerConditions>
				{
					{"INITIAL", new LexerConditions(new List<int> { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38 }, true)}
				};


		}
		
		public Expression ParserPerformAction(ref Expression thisS, ref Expression yy, ref int yystate, ref JList<Expression> ss)
		{
			var so = ss.Count - 1;
/* this == yyval */


switch (yystate) {
case 1:
        return ss[so-1];
    
break;
case 2:
        
		
        
            thisS = ss[so];
        
    
break;
case 3:
	        
break;
case 4:
        
    
break;
case 5:
	    

		
			ss[so].ToDouble();
			thisS = ss[so];
		
    
break;
case 6:
        

		
			ss[so].ToString();
			thisS = ss[so];
		
    
break;
case 7:
        
        
        
            ss[so-2].Set(ss[so-2].Text + ss[so].Text);
            thisS = ss[so-2];
	    
    
break;
case 8:
	    

		
			ss[so-2].Set(ss[so-2].Text == ss[so].Text);
			thisS = ss[so-2];
		
    
break;
case 9:
	    

		
			if (ss[so-2].IsNumeric()) {
				ss[so-2].ToDouble();
				ss[so-2].Add(ss[so]);
				thisS = ss[so-2];
			} else {
				ss[so-2].ToString();
				ss[so-2].Concat(ss[so]);
				thisS = ss[so-2];
			}
		
    
break;
case 10:
	    	
break;
case 11:
        
        
        
            ss[so-3].Set(ss[so-3].ToDouble() <= ss[so].ToDouble());
            thisS = ss[so-3];
        
    
break;
case 12:
        
        
        
            ss[so-3].Set(ss[so-3].ToDouble() >= ss[so].ToDouble());
            thisS = ss[so-3];
        
    
break;
case 13:
        
            ss[so-3].Set(ss[so-3].Text != ss[so].Text);
            thisS = ss[so-3];
        
    
break;
case 14:
        
            ss[so-2].Set(ss[so-2].Text != ss[so].Text);
            thisS = ss[so-2];
        
    
break;
case 15:
	    
        
        
            ss[so-2].Set(ss[so-2].ToDouble() > ss[so].ToDouble());
            thisS = ss[so-2];
        
    
break;
case 16:
        
        
        
            ss[so-2].Set(ss[so-2].ToDouble() < ss[so].ToDouble());
            thisS = ss[so-2];
        
    
break;
case 17:
        
        
        
            ss[so-2].Set(ss[so-2].ToDouble() - ss[so].ToDouble());
            thisS = ss[so-2];
        
    
break;
case 18:
	    
        
        
            ss[so-2].Set(ss[so-2].ToDouble() * ss[so].ToDouble());
            thisS = ss[so-2];
        
    
break;
case 19:
	    
        
        
            ss[so-2].Set(ss[so-2].ToDouble() / ss[so].ToDouble());
            thisS = ss[so-2];
        
    
break;
case 20:
        
        
        
            ss[so-2].Set(Math.Pow(ss[so-2].ToDouble(), ss[so].ToDouble()));
            thisS = ss[so-2];
        
    
break;
case 21:
		
		
		
			ss[so].Set(-ss[so].ToDouble());
			thisS = ss[so];
		
    
break;
case 22:
	    
        
        
            ss[so].Set(ss[so].ToDouble());
            thisS = ss[so];
        
    
break;
case 23:;
break;
case 24:
	    
        
        
            thisS = Functions.Call(ss[so-2].Text);
        
    
break;
case 25:
	    
        
        
            thisS = Functions.Call(ss[so-3].Text, ss[so-1]);
        
    
break;
case 29:
	    
        
        
            thisS = Spreadsheet.CellValue(Location.ParseFixed(ss[so].Text));
        
    
break;
case 30:
	    
        
        
            thisS = Spreadsheet.CellValue(Location.ParseFixed(ss[so-2].Text), Location.ParseFixed(ss[so].Text));
        
    
break;
case 31:
	    
        
        
            thisS = Spreadsheet.CellValue(Location.Parse(ss[so].Text));
        
    
break;
case 32:
	    
        
        
            thisS = Spreadsheet.CellValue(Location.Parse(ss[so-2].Text), Location.Parse(ss[so].Text));
        
    
break;
case 33:
	    
        
        
            thisS = Spreadsheet.CellValue(Location.ParseRemote(ss[so-2].Text, ss[so].Text));
        
    
break;
case 34:
	    
        
        
            thisS = Spreadsheet.CellValue(Location.ParseRemote(ss[so-4].Text, ss[so-2].Text), Location.ParseRemote(ss[so-4].Text, ss[so].Text));
        
    
break;
case 35:
	    
        
        
            thisS = ss[so];
        
    
break;
case 36:
	    
        
        
            ss[so-2].Push(ss[so]);
            thisS = ss[so-2];
        

    
break;
case 37:
 	    
        
        
            ss[so-2].Push(ss[so]);
            thisS = ss[so-2];
        
    
break;
case 38:
	    
            thisS = ss[so];
        
    
break;
case 39:
        
        
        
            ss[so-2].Push(ss[so]);
            thisS = ss[so-2];
        
    
break;
case 40:
        
            ss[so].ToDouble();
            thisS = ss[so];
        
    
break;
case 41:
        
        
        
            ss[so-2].Text += "." + ss[so].Text;
            ss[so-2].ToDouble();
            thisS = ss[so-2];
        
    
break;
case 42:
        
            ss[so-1].Set(ss[so-1].ToDouble() * 0.01);
            thisS = ss[so-1];
        
        
    
break;
case 43:
        

        
            ss[so-2].Set(ss[so-2].Text + ss[so-1].Text + ss[so].Text);
            thisS = ss[so-2];
        
    
break;
case 44:
        

        
            ss[so-3].Set(ss[so-3].Text + ss[so-2].Text + ss[so-1].Text + ss[so].Text);
            thisS = ss[so-3];
        
    
break;
}

			return null;
		}

		public ParserSymbol ParserLex()
		{
			var token = LexerLex();//end = 1

            if (token != null)
            {
                return token;
            }

			return Symbols["end"];
		}

		public void ParseError(string error, ParserError hash = null)
		{
			throw new InvalidOperationException(error);
		}

		public void LexerError(string error, LexerError hash = null)
		{
			throw new InvalidOperationException(error);
		}

		public Expression Parse(string input)
		{
			if (Table == null) {
				throw new Exception("Empty table");
			}
			var stack = new JList<ParserCachedAction>
			{
				new ParserCachedAction(new ParserAction(0, Table[0]))
			};
			var vstack = new JList<Expression>
			{
				new Expression()
			};
			var yy = new Expression();
			var _yy = new Expression();
			var v = new Expression();
			int recovering = 0;
			ParserSymbol symbol = null;
			ParserAction action = null;
			string errStr = "";
			ParserSymbol preErrorSymbol = null;
			ParserState state = null;

			SetInput(input);

			while (true)
			{
				// retreive state number from top of stack
				state = stack.Last().Action.State;

				// use default actions if available
				if (state != null && DefaultActions.ContainsKey(state.Index))
				{
					action = DefaultActions[state.Index];
				}
				else
				{
					if (symbol == null)
					{
						symbol = ParserLex();
					}
					// read action for current state and first input
					if (state != null && state.Actions.ContainsKey(symbol.Index))
					{
						action = state.Actions[symbol.Index];
					}
					else
					{
						action = null;
					}
				}

				if (action == null)
				{
					if (recovering > 0)
					{
						// Report error
						var expected = new Stack<string>{};
						foreach(var p in Table[state.Index].Actions)
						{
							expected.Push(Terminals[p.Value.Action].Name);
						}

						errStr = "Parse error on line " + (Yy.LineNo + 1).ToString() + ":" + '\n' +
							ShowPosition() + '\n' + 
								"Expecting " + String.Join(", ", expected) +
								", got '" +
								(symbol != null ? Terminals[symbol.Index].ToString() : "NOTHING") + "'";

						ParseError(errStr, new ParserError(Match, state, symbol, Yy.LineNo, yy.Loc, expected));
					}
				}

				/*if (state.IsArray()) {
					this.parseError("Parse Error: multiple actions possible at state: " + state + ", token: " + symbol);
				}*/

				if (state == null || action == null)
				{
					break;
				}

				switch (action.Action)
				{
					case Shift:
						stack.Push(new ParserCachedAction(action, symbol));
						vstack.Push(Yy.Clone());

						symbol = null;
						if (preErrorSymbol == null)
						{ // normal execution/no error
							yy = Yy.Clone();
							if (recovering > 0) recovering--;
						} else { // error just occurred, resume old lookahead f/ before error
							symbol = preErrorSymbol;
							preErrorSymbol = null;
						}
					break;

					case Reduce:
						int len = Productions[action.State.Index].Len;
						// perform semantic action
						_yy = vstack[vstack.Count - len];

						if (Ranges != null)
						{
							Yy.Loc.Range = new ParserRange(
								vstack[vstack.Count - len].Loc.Range.X,
								vstack.Last().Loc.Range.Y
							);
						}

						var value = ParserPerformAction(ref _yy, ref yy, ref action.State.Index, ref vstack);

						if (value != null)
						{
							return value;
						}

						// pop off stack
						while (len > 0)
						{
							stack.Pop();
							vstack.Pop();
							len--;
						}

				        if (_yy == null)
				        {
							vstack.Push(new Expression());
				        }
				        else
				        {
				            vstack.Push(_yy.Clone());
				        }
				        var nextSymbol = Productions[action.State.Index].Symbol;
						// goto new state = table[STATE][NONTERMINAL]
						var nextState = stack.Last().Action.State;
						var nextAction = nextState.Actions[nextSymbol.Index];

						stack.Push(new ParserCachedAction(nextAction, nextSymbol));

					break;
					case Accept:
						return v;
				}
			}

			return v;
		}

		/* Jison generated lexer */
		public ParserSymbol Eof = new ParserSymbol("Eof", 1);
		public Expression Yy = new Expression();
		public string Match = "";
		public string Matched = "";
		public Stack<string> ConditionStack;
		public Dictionary<int, Regex> Rules;
		public Dictionary<string, LexerConditions> Conditions;
		public bool Done = false;
		public bool Less;
		public bool _More;
		public string _Input;
		public int Offset;
		public Dictionary<int, ParserRange>Ranges;
		public bool Flex = false;

		public void SetInput(string input)
		{
			_Input = input;
			_More = Less = Done = false;
			Yy.LineNo = Yy.Leng = 0;
			Matched = Match = "";
			ConditionStack = new Stack<string>();
			ConditionStack.Push("INITIAL");

			if (Ranges != null)
			{
				Yy.Loc = new ParserLocation(new ParserRange(0,0));
			} else {
				Yy.Loc = new ParserLocation();
			}

			Offset = 0;
		}

		public string Input()
		{
			string ch = _Input[0].ToString();
			Yy.Text += ch;
			Yy.Leng++;
			Offset++;
			Match += ch;
			Matched += ch;
			Match lines = Regex.Match(ch, "/(?:\r\n?|\n).*/");
			if (lines.Success) {
				Yy.LineNo++;
				Yy.Loc.LastLine++;
			} else {
				Yy.Loc.LastColumn++;
			}

			if (Ranges != null)
			{
				Yy.Loc.Range.Y++;
			}

			_Input = _Input.Substring(1);
			return ch;
		}

		public void Unput(string ch)
		{
			int len = ch.Length;
			var lines = Regex.Split(ch, "/(?:\r\n?|\n)/");

			_Input = ch + _Input;
			Yy.Text = Yy.Text.Substring(0, len - 1);
			Offset -= len;
			var oldLines = Regex.Split(Match, "/(?:\r\n?|\n)/");
			Match = Match.Substring(0, Match.Length - 1);
			Matched = Matched.Substring(0, Matched.Length - 1);

			if ((lines.Length - 1) > 0) Yy.LineNo -= lines.Length - 1;
			var r = Yy.Loc.Range;

			Yy.Loc = new ParserLocation(
				Yy.Loc.FirstLine,
				Yy.LineNo + 1,
				Yy.Loc.FirstColumn,
				(
					lines.Length > 0 ?
					(
						lines.Length == oldLines.Length ?
							Yy.Loc.FirstColumn :
							0
					) + oldLines[oldLines.Length - lines.Length].Length - lines[0].Length :
					Yy.Loc.FirstColumn - len
				)
			);

			if (Ranges.Count > 0) {
				Yy.Loc.Range = new ParserRange(r.X, r.X + Yy.Leng - len);
			}
		}

		public void More()
		{
			_More = true;
		}

		public string PastInput()
		{
			var past = Matched.Substring(0, Matched.Length - Match.Length);
			return (past.Length > 20 ? "..." + Regex.Replace(past.Substring(-20), "/\n/", "") : "");
		}

		public string UpcomingInput()
		{
			var next = Match;
			if (next.Length < 20)
			{
				next += _Input.Substring(0, (next.Length > 20 ? 20 - next.Length : next.Length));
			}
			return Regex.Replace(next.Substring(0, (next.Length > 20 ? 20 - next.Length : next.Length)) + (next.Length > 20 ? "..." : ""), "/\n/", "");
		}

		public string ShowPosition()
		{
			var pre = PastInput();

			var c = "";
			for (var i = 0; i < pre.Length; i++)
			{
				c += "-";
			}

			return pre + UpcomingInput() + '\n' + c + "^";
		}

		public ParserSymbol Next()
		{
			if (Done == true)
			{
				return Eof;
			}

			if (String.IsNullOrEmpty(_Input))
			{
				Done = true;
			}

			if (_More == false)
			{
				Yy.Text = "";
				Match = "";
			}

			var rules = CurrentRules();
			string match = "";
			bool matched = false;
			int index = 0;
			Regex rule;
			for (int i = 0; i < rules.Count; i++)
			{
				rule = Rules[rules[i]];
				var tempMatch = rule.Match(_Input);
				if (tempMatch.Success == true && (match != null || tempMatch.Length > match.Length)) {
					match = tempMatch.Value;
					matched = true;
					index = i;
					if (!Flex) {
						break;
					}
				}
			}
			if ( matched )
			{
				Match lineCount = Regex.Match(match, "/\n.*/");

				Yy.LineNo += lineCount.Length;
				Yy.Loc.FirstLine = Yy.Loc.LastLine;
				Yy.Loc.LastLine = Yy.LineNo + 1;
				Yy.Loc.FirstColumn = Yy.Loc.LastColumn;
				Yy.Loc.LastColumn = lineCount.Length > 0 ? lineCount.Length - 1 : Yy.Loc.LastColumn + match.Length;

				Yy.Text += match;
				Match += match;
				Matched += match;

				Yy.Leng = Yy.Text.Length;
				if (Ranges != null)
				{
					Yy.Loc.Range = new ParserRange(Offset, Offset += Yy.Leng);
				}
				_More = false;
				_Input = _Input.Substring(match.Length);
                var ruleIndex = rules[index];
                var nextCondition = ConditionStack.Peek();
                dynamic action = LexerPerformAction(ruleIndex, nextCondition);
				ParserSymbol token = Symbols[action];

				if (Done == true && String.IsNullOrEmpty(_Input) == false)
				{
					Done = false;
				}

				if (token.Index > -1) {
					return token;
				} else {
					return null;
				}
			}

			if (String.IsNullOrEmpty(_Input)) {
				return Symbols["EOF"];
			} else
			{
				LexerError("Lexical error on line " + (Yy.LineNo + 1) + ". Unrecognized text.\n" + ShowPosition(), new LexerError("", -1, Yy.LineNo));
				return null;
			}
		}

		public ParserSymbol LexerLex()
		{
			var r = Next();

			while (r == null)
			{
			    r = Next();
			}

		    return r;
		}

		public void Begin(string condition)
		{
			ConditionStack.Push(condition);
		}

		public string PopState()
		{
			return ConditionStack.Pop();
		}

		public List<int> CurrentRules()
		{
			var peek = ConditionStack.Peek();
			return Conditions[peek].Rules;
		}

		public dynamic LexerPerformAction(int avoidingNameCollisions, string Yy_Start)
		{
			

;
switch(avoidingNameCollisions) {
case 0:/* skip whitespace */
break;
case 1:return 10;
break;
case 2:return 10;
break;
case 3:return 24;
break;
case 4:return 7;
break;
case 5:return 8;
break;
case 6:
	

	
		return 30;
	

break;
case 7:
	

	
		return 27;
	

break;
case 8:
	

	
	
		return 29;
	

break;
case 9:return 24;
break;
case 10:return 34;
break;
case 11:return 34;
break;
case 12:return 36;
break;
case 13:/* skip whitespace */
break;
case 14:return 11;
break;
case 15:return ' ';
break;
case 16:return 35;
break;
case 17:return 28;
break;
case 18:return 32;
break;
case 19:return 33;
break;
case 20:return 20;
break;
case 21:return 21;
break;
case 22:return 19;
break;
case 23:return 13;
break;
case 24:return 22;
break;
case 25:return 14;
break;
case 26:return 15;
break;
case 27:return 17;
break;
case 28:return 16;
break;
case 29:return 18;
break;
case 30:return "PI";
break;
case 31:return 23;
break;
case 32:return '"';
break;
case 33:return "'";
break;
case 34:return "!";
break;
case 35:return 12;
break;
case 36:return 37;
break;
case 37:return 38;
break;
case 38:return 5;
break;
}

			return -1;
		}
	}

	public class ParserLocation
	{
		public int FirstLine = 1;
		public int LastLine = 0;
		public int FirstColumn = 1;
		public int LastColumn = 0;
		public ParserRange Range;

		public ParserLocation()
		{
		}

		public ParserLocation(ParserRange range)
		{
			Range = range;
		}

		public ParserLocation(int firstLine, int lastLine, int firstColumn, int lastColumn)
		{
			FirstLine = firstLine;
			LastLine = lastLine;
			FirstColumn = firstColumn;
			LastColumn = lastColumn;
		}

		public ParserLocation(int firstLine, int lastLine, int firstColumn, int lastColumn, ParserRange range)
		{
			FirstLine = firstLine;
			LastLine = lastLine;
			FirstColumn = firstColumn;
			LastColumn = lastColumn;
			Range = range;
		}
	}

	public class LexerConditions
	{
		public List<int> Rules;
		public bool Inclusive;

		public LexerConditions(List<int> rules, bool inclusive)
		{
			Rules = rules;
			Inclusive = inclusive;
		}
	}

	public class ParserProduction
	{
		public int Len = 0;
		public ParserSymbol Symbol;

		public ParserProduction(ParserSymbol symbol)
		{
			Symbol = symbol;
		}

		public ParserProduction(ParserSymbol symbol, int len)
		{
			Symbol = symbol;
			Len = len;
		}
	}

	public class ParserCachedAction
	{
		public ParserAction Action;
		public ParserSymbol Symbol;

		public ParserCachedAction(ParserAction action)
		{
			Action = action;
		}

		public ParserCachedAction(ParserAction action, ParserSymbol symbol)
		{
			Action = action;
			Symbol = symbol;
		}
	}

	public class ParserAction
	{
		public int Action;
		public ParserState State;
		public ParserSymbol Symbol;

		public ParserAction(int action)
		{
			Action = action;
		}

		public ParserAction(int action, ref ParserState state)
		{
			Action = action;
			State = state;
		}

		public ParserAction(int action, ParserState state)
		{
			Action = action;
			State = state;
		}

		public ParserAction(int action, ref ParserSymbol symbol)
		{
			Action = action;
			Symbol = symbol;
		}
	}

	public class ParserSymbol
	{
		public string Name;
		public int Index = -1;
		public IDictionary<int, ParserSymbol> Symbols = new Dictionary<int, ParserSymbol>();
		public IDictionary<string, ParserSymbol> SymbolsByName = new Dictionary<string, ParserSymbol>();

		public ParserSymbol()
		{
		}

		public ParserSymbol(string name, int index)
		{
			Name = name;
			Index = index;
		}

		public void AddAction(ParserSymbol p)
		{
			Symbols.Add(p.Index, p);
			SymbolsByName.Add(p.Name, p);
		}
	}

	public class ParserError
	{
		public String Text;
		public ParserState State;
		public ParserSymbol Symbol;
		public int LineNo;
		public ParserLocation Loc;
		public Stack<string> Expected;

		public ParserError(String text, ParserState state, ParserSymbol symbol, int lineNo, ParserLocation loc, Stack<string> expected)
		{
			Text = text;
			State = state;
			Symbol = symbol;
			LineNo = lineNo;
			Loc = loc;
			Expected = expected;
		}
	}

	public class LexerError
	{
		public String Text;
		public int Token;
		public int LineNo;

		public LexerError(String text, int token, int lineNo)
		{
			Text = text;
			Token = token;
			LineNo = lineNo;
		}
	}

	public class ParserState
	{
		public int Index;
		public Dictionary<int, ParserAction> Actions = new Dictionary<int, ParserAction>();

		public ParserState(int index)
		{
			Index = index;
		}

		public void SetActions(ref Dictionary<int, ParserAction> actions)
		{
			Actions = actions;
		}
	}

	public class ParserRange
	{
		public int X;
		public int Y;

		public ParserRange(int x, int y)
		{
			X = x;
			Y = y;
		}
	}

	public class ParserSymbols
	{
		private Dictionary<string, ParserSymbol> SymbolsString = new Dictionary<string, ParserSymbol>();
		private Dictionary<int, ParserSymbol> SymbolsInt = new Dictionary<int, ParserSymbol>();

		public void Add(ParserSymbol symbol)
		{
			SymbolsInt.Add(symbol.Index, symbol);
			SymbolsString.Add(symbol.Name, symbol);
		}

		public ParserSymbol this[char name]
		{
			get
			{
				return SymbolsString[name.ToString()];
			}
		}

		public ParserSymbol this[string name]
		{
			get
			{
				return SymbolsString[name];
			}
		}

		public ParserSymbol this[int index]
		{
			get
			{
				if (index < 0)
				{
					return new ParserSymbol();
				}
				return SymbolsInt[index];
			}
		}
	}

	public class ParserValue
	{
		public string Text;
		public ParserLocation Loc;
		public int Leng = 0;
		public int LineNo = 0;
		
		public ParserValue()
		{
		}
		
		public ParserValue(ParserValue parserValue)
		{
			Text = parserValue.Text;
			Leng = parserValue.Leng;
			Loc = parserValue.Loc;
			LineNo = parserValue.LineNo;
		}
		
		public ParserValue Clone()
		{
			return new ParserValue(this);
		}
	}

	public class JList<T> : List<T> where T : class
	{
		public void Push(T item)
		{
			Add(item);
		}

		public void Pop()
		{
			RemoveAt(Count - 1);
		}

		new public T this[int index]
		{
			get
			{
				if (index >= Count || index < 0 || Count == 0)
				{
					return null;
				}
				return base[index];
			}
		}
	}
}