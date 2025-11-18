using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.App.ViewModels;

public record UserModel(
    int Id,
    string Name,
    string Email,
    string Login,
    DateTime RegisterDate,
    DateTime LoginDate,
    bool IsActive
);