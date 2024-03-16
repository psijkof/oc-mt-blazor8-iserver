using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcBlazorSampleLib;

public interface IUser
{
    /// <summary>
    /// Gets the user name.
    /// </summary>
    string UserName { get; }
}
