using AutoMapper;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace ConsoleTestBox.MappingTest
{
    public class MappingService
    {
        public static ClassB MappingClassBWithEasiestWay(ClassA a)
        {
            return new ClassB()
            {
                string1 = a.string1,
                string2 = a.string2,
                string3 = a.string3,
                string4 = a.string4,
                string5 = a.string5
            };
        }
        public static T2 SlowerMapping<T1, T2>(T1 source, T2 target) where T2 : class, new()//改成targetType進字典
        {
            //會慢的原因猜測是要反覆從propertyType裡面找值，字典的話可以直接用索引
            foreach (var targetProp in target.GetType().GetProperties())
            {
                var sourceProp = source.GetType().GetProperty(targetProp.Name);

                if (sourceProp == null)
                {
                    continue;
                }

                if (targetProp.PropertyType != sourceProp.PropertyType)
                {
                    continue;
                }
                targetProp.SetValue(target, sourceProp.GetValue(source));
            }
            return target;
        }
        public static T2 ObjectStructMapping<T1, T2>(T1 source, T2 target) where T2 : class, new()//改成targetType進字典
        {
            try
            {
                Type sourceType = source.GetType();
                Type targetType = target.GetType();

                Dictionary<string, PropertyData> sourceDic = new Dictionary<string, PropertyData>();

                //取得source的屬性名稱、類型、值，存進字典
                foreach (PropertyInfo property in sourceType.GetProperties())
                {
                    PropertyData data = new PropertyData();
                    data.PropertyName = property.Name;
                    data.PropertyType = property.PropertyType;
                    data.Value = property.GetValue(source);
                    sourceDic.Add(property.Name, data);
                }

                //將相同名字的屬性對照過type後將值寫進target對應的屬性

                foreach (PropertyInfo property in targetType.GetProperties())
                {
                    //若不存在key則下一個
                    if (!sourceDic.ContainsKey(property.Name))
                    {
                        continue;
                    }

                    PropertyData sourceData = sourceDic[property.Name];

                    //若屬性不相同則下一個
                    if (!property.PropertyType.Equals(sourceData.PropertyType))
                    {
                        continue;
                    }

                    property.SetValue(target, sourceData.Value);
                }
                return target;
            }
            catch
            {
                throw;
            }
        }
        public static T2 EmitMapping<T1, T2>(T1 source, T2 target) where T2 : class, new()
        {
            var sourceType = source.GetType();
            var targetType = target.GetType();

            var method = new DynamicMethod("DeepCopy", null, new[] { typeof(T1), typeof(T2) });
            var il = method.GetILGenerator();

            var targetProps = targetType.GetProperties();
            foreach (var prop in targetProps)
            {

                var sourceProp = sourceType.GetProperty(prop.Name);

                if (sourceProp == null)
                {
                    continue;
                }

                if (prop.PropertyType != sourceProp.PropertyType)
                {
                    continue;
                }
                il.Emit(OpCodes.Ldarg_1);
                il.Emit(OpCodes.Ldarg_0);
                il.Emit(OpCodes.Callvirt, sourceProp.GetGetMethod());
                il.Emit(OpCodes.Callvirt, prop.GetSetMethod());
            }

            il.Emit(OpCodes.Ret);

            var deepCopy = (Action<T1, T2>)method.CreateDelegate(typeof(Action<T1, T2>));

            deepCopy(source, target);

            return target;
        }
        public static T2 AutoMapping<T1, T2>(T1 source, T2 target, MapperConfiguration config, IMapper mapper) where T2 : class, new()
        {

            target = mapper.Map<T2>(source);
            return target;
        }
    }
}
