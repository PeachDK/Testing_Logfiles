using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testing_Logfiles
{
    class SensorData
    {
        public string Tid { get; set; }
        public string ID { get; set; }
        public string Alarm { get; set; }
        public string Navn { get; set; }
        public string Afdeling { get; set; }
        public string Bolig { get; set; }   
        public string Afmeldt { get; set; }
        public string Personale { get; set; }
     

        public SensorData(string tid, string id, string alarm, string navn, string afdeling, string bolig, string afmeldt, string personale)
        {
            this.Tid = tid;
            this.ID = id;
            this.Alarm = alarm;
            this.Navn = navn;
            this.Afdeling = afdeling;
            this.Bolig = bolig;            
            this.Afmeldt = afmeldt;
            this.Personale = personale;       
        }



        public override string ToString()
        {
            return ID.ToString() + "  " + Tid.ToString()+ "  " + Navn.ToString() + "  " + Alarm.ToString()+ "  "+ Afdeling.ToString() ;
        }







    }
}
