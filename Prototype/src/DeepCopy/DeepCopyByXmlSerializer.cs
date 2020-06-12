using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Prototype.src.DeepCopy
{
    class DeepCopyByXmlSerializer : IDeepCopy
    {
        public T DeepCopyDispose<T>(T obj)
        {
            object retObj;

            using (MemoryStream ms = new MemoryStream())
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));

                xml.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);

                retObj = xml.Deserialize(ms);

                ms.Close();
            }

            return (T)retObj;
        }
    }
}
