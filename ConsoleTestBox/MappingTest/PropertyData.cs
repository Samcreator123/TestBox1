using System;

namespace ConsoleTestBox.MappingTest
{
    public class PropertyData
    {
        private string _propertyName = string.Empty;
        private Type _propertyType = null;
        private object _value = string.Empty;

        public PropertyData()
        {
        }

        public PropertyData(string propertyName, Type propertyType, object value)
        {
            _propertyName = propertyName;
            _propertyType = propertyType;
            _value = value;
        }

        public string PropertyName { get => _propertyName; set => _propertyName = value; }
        public Type PropertyType { get => _propertyType; set => _propertyType = value; }
        public object Value { get => _value; set => _value = value; }


    }
}