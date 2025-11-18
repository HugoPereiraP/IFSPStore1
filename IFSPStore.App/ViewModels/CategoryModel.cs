using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.App.ViewModels;

public record CategoryModel(
    int Id,
    string Name,
    string Description
);

