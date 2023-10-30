using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IEurope
    {
        void BuildAncient();
    }
    interface IAsia
    {
        void BuidModern();
    }
    interface IVietNam : IEurope, IAsia
    {
        void BuildMixed();
    }
    class BuildingKeanganam : IVietNam
    {
        public void BuildMixed()
        {
            Console.WriteLine("Kiem tra pha tron");
        }
        public void BuildAncient()
        {
            Console.WriteLine("Kien truc co kinh");
        }
        public void BuidModern()
        {
            Console.WriteLine("Kien truc hien dai");
        }
    }
    public interface IStorable
    {
        void Read();
        void Write(Object data);
    }
    public class Document : IStorable
    {
        public void Read()
        {
            Console.WriteLine("Doc du lieu tu tai lieu");
        }
        public void Write(object data)
        {
            Console.WriteLine("Ghi du lieu " + data + " vao tai lieu");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BuildingKeanganam buildingKeanganam = new BuildingKeanganam();
            buildingKeanganam.BuildAncient();
            Document document = new Document();
            document.Read();
            document.Write(1);
        }
    }
}
