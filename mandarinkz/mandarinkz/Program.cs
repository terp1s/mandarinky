using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mandarinkz
{
    interface IPomerancovnik
    {
        List<IPomNode> Strom { get; set; }
        List<int> Auticka { get; set; } // pozadavky
        List<iPlostice> Plostice { get; set; } //jentak, pac na kazdem strome musi byt plostice :)
        List<int> ZkazenePomerance { get; set; }

        void NacistStrom(); //prvni node jde do Parent a druhy je index
        void NacistAuticka();

        void Nakupik(); //zacni od korene stromu, rekurzivne. od pozadavku odecti nejhlubsi node a furt odeitej dokud nedojdes pod 0. pak mej dictionary<List<node>,int>, kde kazdy list budou nody co se smazou a ten int bude kolik jich zbylo. pak vyberes nejlepsi a smazes ty nody a napises zkazene pomernace do ZkazenePomerance :)

    }
    interface IPomNode
    {
        int Index { get; set; }
        int Hloubka { get; set; }  
        int Hodnota { get; set; }
        int SmazHodnota { get; set; } // hodnota celyho nodu kdyz ho smazes

        IPomNode Parent { get; set; }
        List<IPomNode> Children { get; set; }

        void HodnotaSmaz(); // vypocitas SmazHodnotu ... intuitivni ne // projedes vsechny decka a prictes jejich hodnotu. Rekurzivne to mega pujde :)
    } 
    interface iPlostice
    {
        // :)
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
