using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Composite
{  /// <summary>
   /// Composite
   /// </summary>
    public class Directory1 : FileSystemItem
    {
        private long _size;
        private List<FileSystemItem> _fileSystemItems = new List<FileSystemItem>();
        public Directory1(string name, long size) : base(name)
        {
            _size = size;
        }

        public void Add(FileSystemItem itemToAdd)
        {
            _fileSystemItems.Add(itemToAdd);
        }
        public void Remove(FileSystemItem removeItem)
        {
            _fileSystemItems.Remove(removeItem);
        }

        public override long GetSize()
        {
            var treeSize = _size;
            foreach (var fileSystemItem in _fileSystemItems)
            {
                treeSize += fileSystemItem.GetSize();
            }

            return treeSize;
        }
    }
}
