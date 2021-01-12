using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        public int index;

        public DateTime timestamp;
        public String hash;
        public String previousHash;

        public Block(Block lastBlock)
        {
            timestamp = DateTime.Now;
            index = lastBlock.index++;
            previousHash = lastBlock.hash;
        }
    }
}
