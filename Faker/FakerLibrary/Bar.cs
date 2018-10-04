using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FakerLibrary
{
    public class Bar<T>
    {
        [DataMember]
        public int _int;
        [DataMember]
        public double _double;
        [DataMember]
        public float _float;
        [DataMember]
        public bool _bool;
        [DataMember]
        public string _string;
        [DataMember]
        public long _long;
        [DataMember]
        public object _object;
        [DataMember]
        public DateTime _date;
        [DataMember]
        public List<T> _list;
        [DataMember]
        public Bar<char> _bar;
        [DataMember]
        public Foo<string> _foo;
        [DataMember]
        public char _char { get; set;}
    }
}
