using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Exam_Jeopardy.Objects;

namespace Exam_Jeopardy.FileManager
{
    class FileManager
    {
        public static Board LoadBoard(string fileLocation)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Board));
            using (TextReader reader = new StringReader(File.ReadAllText(fileLocation)))
            {
                return (Board)serializer.Deserialize(reader);
            }
        }

        public static void SaveBoard(string fileLocation, Board board)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Board));
            using (StringWriter writer = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(writer))
                {
                    serializer.Serialize(xmlWriter, board);
                    File.WriteAllText(fileLocation, writer.ToString());
                }
            }
        }
    }
}
