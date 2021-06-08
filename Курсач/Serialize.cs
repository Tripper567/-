using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    [Serializable]
    public class Block
    {
        public ObservableCollection<Carta> g = new ObservableCollection<Carta>();
     
    }

    public class Serialize
    {

        BinaryFormatter binaryFormatter = new BinaryFormatter();

        Block CaptureBlock(Block Temp)
        {
            Temp.g = DB.cards;
          
            return Temp;
        }

        public void Save()
        {
            using (FileStream fileStream = new FileStream("File.baka", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, CaptureBlock(new Block()));
            }
        }

        Block GetDeserializedBlock()
        {
            Block DeserializeBlock;
            using (FileStream fileStream = new FileStream("File.baka", FileMode.OpenOrCreate))
            {
                DeserializeBlock = binaryFormatter.Deserialize(fileStream) as Block;
            }
            return DeserializeBlock;
        }

        void SetDB(Block loadBlock)
        {
            DB.cards = loadBlock.g;
         
        }

        public void Load()
        {
            SetDB(GetDeserializedBlock());
        }

    }
}
