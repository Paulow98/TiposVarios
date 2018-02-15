using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 1312;
            uint ui = 12013U;
            int i = 100;
            long l = 123L;
            ulong ul = 3UL;
            decimal de = 3.13m;
            Console.WriteLine(d);
            Console.WriteLine(ui);
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(de);

            char a = '\u00BC';
            char b = '\u00A2';
            char c = '\u00B6';
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            float fa = 1.3f;
            float fb = 2.4f;
            float fc = 55512.34f;

            Console.WriteLine(fa);
            Console.WriteLine(fb);
            Console.WriteLine(fc);

            bool ba = true;
            bool bb = false;

            Console.WriteLine(ba);
            Console.WriteLine(bb);
        }
    }
}


//Criar novo projeto no Visual Studio(Console App .NET Framework c/ Git)
//Nome do projeto: TiposVarios
//2 Criar variáveis inteiras de diferentes tipos inicializadas com literais adequados
//3 Imprimir no ecrã o valor das várias variáveis inteiras
//4 Git: add alterações + commit com mensagem apropriada
//5 Criar variáveis char com diferentes valores Unicode
//(https://unicode-table.com/)
//6 Imprimir no ecrã o valor dos diferentes caracteres
//7 Git: add alterações + commit com mensagem apropriada
//8 Criar variáveis reais de diferentes tipos inicializadas com literais adequados
//9 Imprimir no ecrã o valor das várias variáveis reais
//10 Git: add alterações + commit com mensagem apropriada

//11 Criar duas variáveis booleanas, uma inicializada a true, outra a false
//12 Imprimir no ecrã o valor de cada variável booleana
//13 Git: add alterações + commit com mensagem apropriada

//14 Criar novo repositório remoto (GitHub, GitLab ou BitBucket)
//15 Fazer push de todos os commits para o repositório remoto
