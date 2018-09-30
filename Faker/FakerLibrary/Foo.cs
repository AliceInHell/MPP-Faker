using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakerLibrary
{
    public class Foo<T>
    {
        private int _int;
        private double _double;
        private float _float;
        private bool _bool;
        private string _string;
        private long _long;
        private object _object;
        private DateTime _date;
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
