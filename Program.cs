using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateJsonObject;

namespace GeekBrains.Hometask.ReadWriteJsonStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonReader commonReader = new CommonReader();
            ReadJsonStructure1 readJsonStructure1 = new ReadJsonStructure1();
            string FirstRead=commonReader.Read(readJsonStructure1);

            ReadJsonStructure2 readJsonStructure2 = new ReadJsonStructure2();
            IJsonReader1 Json2ToJson1 = new Json2ToJson1Adapter(readJsonStructure2);
            string SecondRead=commonReader.Read(Json2ToJson1);

            ReadJsonStructure3 readJsonStructure3 = new ReadJsonStructure3();
            IJsonReader1 Json3ToJson1 = new Json3ToJson1Adapter(readJsonStructure3);
            string ThirdRead = commonReader.Read(Json3ToJson1);

            Print print = new Print();
            print.PrintString(FirstRead);
            print.PrintString(SecondRead);
            print.PrintString(ThirdRead);

            Console.ReadLine();
        }
    }
}
