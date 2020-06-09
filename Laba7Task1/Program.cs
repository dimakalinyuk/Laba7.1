using System;
using System.Collections;

namespace Dima_OOP_7
{
    public class Doc : IComparable
    {
        public string name;
        public double number1;
        public string date;
        public int cena;
        public float height;



        public Doc(string name, double weight, string date, int number, float height)
        {
            this.name = name;
            this.number1 = weight;
            this.date = date;
            this.cena = number;
            this.height = height;
        }

        public class SortByCena : IComparer
        {
            int IComparer.Compare(object ob1, object ob2)
            {
                Doc p1 = (Doc)ob1;
                Doc p2 = (Doc)ob2;
                if (Convert.ToDateTime(p1.date) > Convert.ToDateTime(p2.date)) return 1;
                if (Convert.ToDateTime(p1.date) < Convert.ToDateTime(p2.date)) return -1;
                return 0;
            }
        }

        public int CompareTo(object pers)
        {
            Doc p = (Doc)pers;
            if (this.number1 > p.number1) return 1;
            if (this.number1 < p.number1) return -1; return 0;
        }
        public void Info()
        {

            Console.WriteLine("{0, -15}{1, -10}{2, -15}{3, -15}{4, -10}", name, number1, date, cena, height);
        }
    }

    class GTR : IEnumerable
    {
        public string name;
        public double weight;
        public float cena;
        public int number;
        public float height;



        public GTR(string name, double weight, float cena, int number, float height)
        {
            this.name = name;
            this.weight = weight;
            this.cena = cena;
            this.number = number;
            this.height = height;
        }

        protected int size;
        protected Doc[] container;

        public GTR()
        {
            size = 10;
            container = new Doc[size];
            FillContainer();
        }

        public GTR(int size)
        {
            this.size = size;
            container = new Doc[size];
            FillContainer();
        }
        public GTR(Doc[] container)
        {
            this.container = container;
            size = container.Length;
        }
        void FillContainer()
        {


            Doc p1 = new Doc("ДСТУ 244773", 5, "18.11.2020", 20, 22);
            Doc p2 = new Doc("ДСTУ 773743", 7, "17.11.2009", 20, 28);
            Doc p3 = new Doc("ДСТУ 746738", 2, "17.02.2018", 13, 10);
            Doc p4 = new Doc("ДСТУ 748933", 27, "22.07.1999", 100, 8);
            Doc p5 = new Doc("ДСТУ 987667", 1, "21.09.2006", 50, 13);
            Doc p6 = new Doc("ДСТУ 767838", 50, "14.03.2004", 20, 200);
            Doc p7 = new Doc("ДСТУ 748493", 12, "19.03.2020", 10, 40);
            Doc p8 = new Doc("ДСТУ 783993", 10, "08.01.2002", 18, 39);
            Doc p9 = new Doc("ДСТУ 748399", 11, "01.02.2001", 6, 15);
            Doc p10 = new Doc("ДСТУ 748939", 8, "02.03.2016", 23, 11);
            Doc[] pn = new Doc[10];
            pn[0] = p1;
            pn[1] = p2;
            pn[2] = p3;
            pn[3] = p4;
            pn[4] = p5;
            pn[5] = p6;
            pn[6] = p7;
            pn[7] = p8;
            pn[8] = p9;
            pn[9] = p10;



        }
        public IEnumerator GetEnumerator()
        {
            Array.Sort(container);
            return container.GetEnumerator();
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Doc p1 = new Doc("ДСТУ 244773", 5, "18.11.2020", 20, 22);
            Doc p2 = new Doc("ДСTУ 773743", 7, "17.11.2009", 20, 28);
            Doc p3 = new Doc("ДСТУ 746738", 2, "17.02.2018", 13, 10);
            Doc p4 = new Doc("ДСТУ 748933", 27, "22.07.1999", 100, 8);
            Doc p5 = new Doc("ДСТУ 987667", 1, "21.09.2006", 50, 13);
            Doc p6 = new Doc("ДСТУ 767838", 50, "14.03.2004", 20, 200);
            Doc p7 = new Doc("ДСТУ 748493", 12, "19.03.2020", 10, 40);
            Doc p8 = new Doc("ДСТУ 783993", 10, "08.01.2002", 18, 39);
            Doc p9 = new Doc("ДСТУ 748399", 11, "01.02.2001", 6, 15);
            Doc p10 = new Doc("ДСТУ 748939", 8, "02.03.2016", 23, 11);
            Doc[] pn = new Doc[10];
            pn[0] = p1;
            pn[1] = p2;
            pn[2] = p3;
            pn[3] = p4;
            pn[4] = p5;
            pn[5] = p6;
            pn[6] = p7;
            pn[7] = p8;
            pn[8] = p9;
            pn[9] = p10;
            Array.Sort(pn);

            Console.WriteLine("\t\t\tСортування за кількістю сторінок\n{0, -15}{1, -10}{2, -15}{3, -15}{4, -10}", "Назва", "Кількість", "Дата", "Ціна", "Важливість");
            foreach (Doc elem in pn) elem.Info();
            Console.WriteLine("\n\t\t\tСортування за датою");
            Array.Sort(pn, new Doc.SortByCena());
            foreach (Doc elem in pn) elem.Info();

            int size = 10;
            GTR chic = new GTR(size);

            Console.WriteLine("\t\t\tСортування за кількістю сторінок");
            foreach (GTR chics in chic)
            {
                Console.WriteLine("{0, -15}{1, -10}{2, -15}{3, -15}{4, -10}", chic.name, chic.weight, chic.cena, chic.number, chic.height);
            }





        }
    }
}

