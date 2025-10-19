using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPC__CodeForces.Sheet_1
{
    internal class Q_Solve
    {
        public static void Start() 
        {
            string input =Console.ReadLine();
            string[] parts = input.Split(' ');
            double x= double.Parse(parts[0]);
            double y= double.Parse(parts[1]);

            string Quadrnat = (y, x) switch
            {
                (0,0)=>"Origem",
                (>0,>0)=>"Q1",
                (<0,<0)=>"Q3",
                (>0,<0)=>"Q2",  
                (<0,>0)=>"Q4",
                (0,_)=>"Eixo X",
                (_,0)=>"Eixo Y",
                _=> "Origem"

            };
            Console.WriteLine(Quadrnat);

        }
    }
}
