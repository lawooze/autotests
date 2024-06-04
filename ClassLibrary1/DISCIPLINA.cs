using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.DISCIPLINA; //была добавлена
using static ClassLibrary1.Dolznost; //была добавлена

namespace ClassLibrary1
{

    /// <summary>
    /// класс дисциплина
    /// вариант 3
    /// сделал Гачин Иван
    /// </summary>
    public class DISCIPLINA
    {
        private string name;
        private string sokrasch;

        public DISCIPLINA(string name, string sokrasch)
        {
            this.name = name;
            this.sokrasch = sokrasch;
        }
        public string Name()
        {
            return name;
        }
        public string Sokrasch()
        {
            return sokrasch;
        }
    }

}
