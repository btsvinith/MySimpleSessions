using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.DesignPatterns
{
    public class SampleDI
    {
        ISampleDIDal dal;

        public SampleDI(ISampleDIDal dal)
        {
            this.dal = dal;
        }

        public void Exec()
        {
           string data= dal.GetData();

            Console.WriteLine(data);
        }
    }

    public interface ISampleDIDal
    {
        string GetData();
    }

    public class SampleDIDal : ISampleDIDal
    {
        public string GetData()
        {
            return "Some Data";
        }
    }

    public class SampleNewDIDal : ISampleDIDal
    {
        public string GetData()
        {
            return "Some New Data";
        }
    }

    public class SampleOldDIDal : ISampleDIDal
    {
        public string GetData()
        {
            return "Some Old Data";
        }
    }

}
