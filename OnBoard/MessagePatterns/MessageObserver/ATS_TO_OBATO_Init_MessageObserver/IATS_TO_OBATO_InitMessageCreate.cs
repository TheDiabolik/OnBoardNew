﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoard
{
    public interface IATS_TO_OBATO_InitMessageCreate
    {
        void InformWatcher();

        void AddWatcher(IATS_TO_OBATO_InitMessageWatcher watcher);

        void RemoveWatcher(IATS_TO_OBATO_InitMessageWatcher watcher);
    }
}
