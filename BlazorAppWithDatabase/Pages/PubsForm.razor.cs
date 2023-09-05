using BlazorAppWithDatabase.Data.Models;
using BlazorAppWithDatabase.Data.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace BlazorAppWithDatabase.Pages
{
    public partial class PubsForm :ComponentBase
    {

        [Parameter] 
        public string? PubId { get; set; }

        public Pub? Pub { get; set; }

        [Inject]
        protected IPubService? PubService { get; set; }

        [Inject]
        protected NavigationManager? NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            if (PubId == "Add")
            {
                Pub = new Pub();
            }
            else
            {
                var task = PubService!.GetPubAsync(int.Parse(PubId));
                task.Wait();
                Pub = task.Result;
            }
        }

        public void Submit(EditContext editContext)
        {
            var isValid = editContext.Validate();
            if (isValid)
            {
                var pub = (Pub)editContext.Model;
                PubService!.UpdatePub(pub);
                NavigationManager?.NavigateTo("/PubView");
            }
        }

    }
}
