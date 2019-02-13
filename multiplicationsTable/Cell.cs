using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationsTable
{
    class Cell
    {
        private ulong _adbsNum = 0;
        private readonly string _title;
        private Cell _prev;
        private Cell _next;

        public ulong AdbsNum { get => _adbsNum; set => _adbsNum = value; }

        public string Title => _title;

        internal Cell Prev { get => _prev; set => _prev = value; }
        internal Cell Next { get => _next; set => _next = value; }

        private 

    }
}
