using System;
using System.Net.Http;
using TwitchLib.Client;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;

namespace SocialsPoster;

public partial class MainPage : ContentPage
{
	private readonly HttpClient _client;    

    public MainPage()
	{
		InitializeComponent();

        _client = new HttpClient(); // Replace this with local call (create only when needed and dispose after complete

        TwitchBot bot = new TwitchBot();
    }

	async void GetInfo()
	{
		HttpResponseMessage responseMsg = await _client.GetAsync("http://www.google.com/");
		labelToShow.Text = await responseMsg.Content.ReadAsStringAsync();
    }

    private void GetInfoButtonClicked(object sender, EventArgs e)
    {
		GetInfo();
    }
}
