using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Composite
{
    /* Leaf */
    public class File : FileSystemItem
    {
        private long _size;
        public File(string name, long size): base(name)
        {
            _size = size;
        }

        public override long GetSize()
        {
            return _size;
        }
    }
}
