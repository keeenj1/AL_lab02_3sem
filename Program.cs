using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class ClassRoom
    {
        private Pupil[] Pupils;
        public ClassRoom(params Pupil[] Pupils)
        {
            if(Pupils.Length < 4)
            {
                this.Pupils = new Pupil[4];
                for(int i = 0; i < Pupils.Length; i++)
                {
                    this.Pupils[i] = Pupils[i];
                }
                for (int i = Pupils.Length; i < 4; i++)
                {
                    this.Pupils[i] = new Pupil();
                }
            }
            else
            {
                this.Pupils = Pupils;
            }
        }
        public void ShowPupil()
        {
            foreach (var pupil in Pupils)
            {
                Console.WriteLine("Pupil activity:");
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax(); 
            }
        }
    }
    public class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("People is studying");
        }
        public virtual void Read()
        {
            Console.WriteLine("People is reading");
        }
        public virtual void Write()
        {
            Console.WriteLine("People is writing");
        }
        public virtual void Relax()
        {
            Console.WriteLine("People is relaxing");
        }
    }
    public class ExcelentPupil : Pupil 
    {
        public override void Study() 
        {
            Console.WriteLine("People is studying very well");
        }
        public override void Read()
        {
            Console.WriteLine("People is reading very well");
        }
        public override void Write()
        {
            Console.WriteLine("People is writing very well");
        }
        public override void Relax()
        {
            Console.WriteLine("People isn't realxing");
        }
    }
    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("People is studying good");
        }
        public override void Read()
        {
            Console.WriteLine("People is reading good");
        }
        public override void Write()
        {
            Console.WriteLine("People is writing good");
        }
        public override void Relax()
        {
            Console.WriteLine("People has some relaxing ");
        }
    }
    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("People is studying bad");
        }
        public override void Read()
        {
            Console.WriteLine("People is reading bad");
        }
        public override void Write()
        {
            Console.WriteLine("People is writing bad");
        }
        public override void Relax()
        {
            Console.WriteLine("People relaxing everytime");
        }
    }
    class Program
    {
        static void Main()
        {
            Pupil excelentPupil = new ExcelentPupil();
            Pupil goodPupil = new GoodPupil();
            Pupil badPupil1 = new BadPupil();
            Pupil badPupil2 = new BadPupil();
            Pupil[] pupils = { excelentPupil, goodPupil };

            ClassRoom class1 = new ClassRoom(pupils);
            class1.ShowPupil();
            Console.ReadLine();
        }
    }
}