using Mood.Interfaces;

namespace Mood.Services
{
    public class AlertService : IAlertService
    {
        public Task<bool> ShowConfirmationAsync(string title, string message, string accept = "OK", string decline = "Cancel")
        {
            return Application.Current.MainPage.DisplayAlert(title, message, accept, decline);
        }

        public void ShowConfirmation(string title, string message, Action<bool> callback, string accept = "OK", string decline = "Cancel")
        {
            Application.Current.MainPage.Dispatcher.Dispatch(async () =>
            {
                bool answer = await ShowConfirmationAsync(title, message, accept, decline);
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
    }
}
