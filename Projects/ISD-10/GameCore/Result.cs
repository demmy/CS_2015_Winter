using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace GameCore
{
    [DataContract]
    public class Result : IComparable<Result>
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Hp { get; set; }        
        public Result(string name, int hp)
        {
            Name = name;
            Hp = hp;            
        }
        public int CompareTo(Result obj)
        {
            if (this.Hp > obj.Hp)
                return -1;
            if (this.Hp < obj.Hp)
                return 1;
            else
                return 0;
        }
    }
}
