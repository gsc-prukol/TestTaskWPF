﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public interface IDataModel : INotifyPropertyChanged
    {
        List<TableModel> publicData { get; }
    }
}
