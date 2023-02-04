using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.Interfaces
{
    public interface IAlertService
    {
        Task ShowAlertAsync(string title, string message, string decline = "Cancel");
        Task<bool> ShowConfirmationAsync(string title, string message, string accept = "OK", string decline = "Cancel");
        void ShowAlert(string title, string message, string decline = "Cancel");
        void ShowConfirmation(string title, string message, Action<bool> callback, string accept = "OK", string decline = "Cancel");
    }
}
