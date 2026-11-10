using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    struct genero
    {
        public double hombre;
        public double mujer;
    }
    struct categoria
    {
        public double colectivos;
        public double contactofisico;
        public double individualesRF;
        public double individualesRE;
        public double nopractica;
    }
    static void Main()
    {
        if (!(File.Exists("genero.txt")) && !(File.Exists("categoria.txt")))
        {
            StreamWriter fich = new StreamWriter("genero.txt");
            fich.Close();
            StreamWriter fich2 = new StreamWriter("categoria.txt");
            fich.Close();
        }
        List<genero> genero= new List<genero>();
        List<categoria> categoria = new List<categoria>();
        LlenarDatos(ref genero, ref categoria);
    }
    static void LlenarDatos(ref List<genero> g, ref List<categoria> cat)
    {
        //sacar del 2do parcial
    }
    static double MediaG(List<genero> g)
    {
        double sgh = 0, sgm = 0;
        for (int c=0;c<g.Count;c++)
        {
            sgh = sgh + g[c].hombre;
            sgm = sgm + g[c].mujer;
        }
        double fxh = 1 * sgh;
        double fxm = 2 * sgm;
        double media = (fxh + fxm) / (sgh + sgm);
        return media;
    }
    static double MediaCat(List<categoria> cat)
    {
        double scat1 = 0, scat2 = 0, scat3 = 0, scat4 = 0, scat5 = 0;
        for (int c = 0; c < cat.Count; c++)
        {
            scat1 = scat1 + cat[c].colectivos;
            scat2 = scat2 + cat[c].contactofisico;
            scat3 = scat3 + cat[c].individualesRF;
            scat4 = scat4 + cat[c].individualesRE;
            scat5 = scat5 + cat[c].nopractica;
        }
        double fx1 = 1 * scat1;
        double fx2 = 2 * scat2;
        double fx3 = 3 * scat3;
        double fx4 = 4 * scat4;
        double fx5 = 5 * scat5;
        double media = (fx1+fx2+fx3+fx4+fx5) / (scat1+scat2+scat3+scat4+scat5);
        return media;
    }
    static double Varianza(List<genero> g, List<categoria> cat)
    {

        double varianza = 0;
        return varianza;
    }
}