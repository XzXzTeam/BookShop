using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using AbstractModel;

namespace BookShopFileRepository
{
    public class SmartCsvSerializer<T>
    {
        private readonly Type _perstistableObjectType;

        public SmartXmlSerializer(Type type)
        {
            _perstistableObjectType = type;
        }
        public void Serialize(StreamWriter sw, T Object)
        {
            var typeBuilder = new TypeBuilder();
            var type = typeof(T);
            foreach (var fieldInfo in type.GetFields())
            {
                if (fieldInfo.GetType().IsEquivalentTo(_perstistableObjectType))
                {
                   
                }
            }
        }


        public Type BuildPseudoType(Type originalType)
        {
            
        }
    }
}
