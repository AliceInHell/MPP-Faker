using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FakerLibrary
{
    [DataContract]
    public class Foo<T>
    {
        [DataMember]
        private int _int;
        [DataMember]
        private double _double;
        [DataMember]
        private float _float;
        [DataMember]
        private bool _bool;
        [DataMember]
        private string _string;
        [DataMember]
        private long _long;
        [DataMember]
        private object _object;
        [DataMember]
        private DateTime _date;
        [DataMember]
        private List<T> _list;

        public int getInt()
        {
            return _int;
        }

        public double getDouble()
        {
            return _double;
        }

        public float getFloat()
        {
            return _float;
        }

        public bool getBool()
        {
            return _bool;
        }

        public string getString()
        {
            return _string;
        }

        public long getLong()
        {
            return _long;
        }

        public object getObkect()
        {
            return _object;
        }

        public DateTime getDate()
        {
            return _date;
        }        

        public List<T> getList()
        {
            return _list;
        }

        public Foo(int i, double d, float f, bool b, string s, long l, object o, DateTime dt, 
            List<T> list)
        {
            _int = i;
            _double = d;
            _float = f;
            _bool = b;
            _string = s;
            _long = l;
            _object = o;
            _date = dt;
            _list = list;
        }
    }
}
