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
        private char _char;
        [DataMember]
        private List<T> _list;
        [DataMember]
        private Bar<byte> _bar;

        [DataMember]
        public int fakeInt;

        public int GetInt()
        {
            return _int;
        }

        public double GetDouble()
        {
            return _double;
        }

        public float GetFloat()
        {
            return _float;
        }

        public bool GetBool()
        {
            return _bool;
        }

        public string GetString()
        {
            return _string;
        }

        public long GetLong()
        {
            return _long;
        }

        public object GetObkect()
        {
            return _object;
        }

        public DateTime GetDate()
        {
            return _date;
        }        

        public char GetChar()
        {
            return _char;
        }

        public List<T> GetList()
        {
            return _list;
        }

        public Bar<byte> GetBar()
        {
            return _bar;
        }

        public Foo(int i, double d, float f, bool b, string s, long l, object o, DateTime dt, 
            char ch, List<T> list, Bar<byte> bar)
        {
            _int = i;
            _double = d;
            _float = f;
            _bool = b;
            _string = s;
            _long = l;
            _object = o;
            _date = dt;
            _char = ch;
            _list = list;
            _bar = bar;
        }
    }
}
