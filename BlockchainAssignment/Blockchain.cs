using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        List<Block> chain = new List<Block>();

        public Blockchain()
        {
            chain.Add(new Block()); //could be done with builder
        }

        public String getBlockAsString(int index)
        {
            return chain[index].ToString();
        }
    }
}
