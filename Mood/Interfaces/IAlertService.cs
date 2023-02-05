using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.Interfaces
{
    public interface IAlertService
    {
        Task ShowAlertAsync(string title, string message, string cancel = "Cancel");
        void ShowAlert(string title, string message, string cancel = "Cancel");
        Task<bool> ShowConfirmationAsync(string title, string message, string accept = "OK", string cancel = "Cancel");
        void ShowConfirmation(string title, string message, Action<bool> callback, string accept = "OK", string cancel = "Cancel");
        Task<string> ShowActionSheetAsync(string title, string cancel, string destruction, params string[] buttons);
        void ShowActionSheet(string title, string cancel, string destruction, Action<string> callback, params string[] buttons);
    }
}
