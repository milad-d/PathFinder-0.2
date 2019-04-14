using System;
using System.Collections.Generic;
using System.Text;

namespace PathFinder.Heap
{
    class BinaryHeapException : Exception
    {
        /* Private: */
	    //private static long serialVersionUID = 1L;

        /* Public: */
	    public BinaryHeapException(String message):base(message)
        {
	    }
    }
}
