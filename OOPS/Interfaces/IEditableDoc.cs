﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.OOPS.Interfaces
{
    public interface IEditableDoc:IDocument
    {
         void EditDoc(string filename);
    }
}
