using Mood.Interfaces;

namespace Mood.Services
{
    /// <summary>
    /// Represents an alert service, with simple alerts, action sheets, and confirmation dialogs.
    /// </summary>
    public class AlertService : IAlertService
    {
        /* Async interface methods are to be used in the case that these methods are used in 
         * asynchronous caller methods. Synchronous interface methods are to be used in
         * synchronous caller methods
         */

        public Task<bool> ShowConfirmationAsync(string title, string message, string accept = "OK", string cancel = "Cancel")
        {
            return Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }

        public void ShowConfirmation(string title, string message, Action<bool> callback, string accept = "OK", string cancel = "Cancel")
        {
            Application.Current.MainPage.Dispatcher.Dispatch(async () =>
            {
                bool answer = await ShowConfirmationAsync(title, message, accept, cancel);
                callback(answer);
            });
        }

        public void ShowAlert(string title, string message, string cancel = "Cancel")
        {
            Application.Current.MainPage.Dispatcher.Dispatch(async () =>
                await ShowAlertAsync(title, message, cancel)
                );
        }

        public Task ShowAlertAsync(string title, string message, string cancel = "Cancel")
        {
            return Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        public void ShowActionSheet(string title, string cancel, string destruction, Action<string> callback, params string[] buttons)
        {
            Application.Current.MainPage.Dispatcher.Dispatch(async () =>
            {
                string answer = await ShowActionSheetAsync(title, cancel, destruction, buttons);
                callback(answer);
            });
        }

        public Task<string> ShowActionSheetAsync(string title, string cancel, string destruction, params string[] buttons)
        {
            return Application.Current.MainPage.DisplayActionSheet(title, cancel, destruction, buttons);
        }
    }
}
