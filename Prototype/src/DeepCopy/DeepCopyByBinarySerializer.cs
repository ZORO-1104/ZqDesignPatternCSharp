using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Prototype.src.DeepCopy
{
    class DeepCopyByBinarySerializer : IDeepCopy
    {
        public T DeepCopyDispose<T>(T obj)
        {
            object retObj;

            using (MemoryStream ms = new MemoryStream())
            {

                BinaryFormatter bf = new BinaryFormatter();

                // 序列化成流
                bf.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);

                // 反序列化成对象
                retObj = bf.Deserialize(ms);

                ms.Close();
            }

            return (T)retObj;
        }
    }
}
