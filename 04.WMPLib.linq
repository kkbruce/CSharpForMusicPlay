<Query Kind="Program">
  <Reference>&lt;ProgramFilesX86&gt;\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\PrivateAssemblies\WMPLib.dll</Reference>
  <Namespace>WMPLib</Namespace>
  <Namespace>System.Windows</Namespace>
</Query>

void Main()
{
	// http://www.cdcc.gov.tw/fdownload/fdlist.asp?PageNo=2&id={43664160-55C2-4680-B892-64F81D13745D}
	PlayFile(@"z:\2013-3-27-9-36-24-56-nf1.mp3");
}

// Define other methods and classes here
WindowsMediaPlayer Player;
private void PlayFile(String url)
{
	Player = new WMPLib.WindowsMediaPlayer();
	Player.PlayStateChange +=
		new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
	Player.MediaError +=
		new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
	Player.URL = url;
	Player.controls.play();
}
private void Player_PlayStateChange(int NewState)
{
	var state = (WMPLib.WMPPlayState)NewState;
	//state.Dump();
	
	if ((WMPPlayState)NewState == WMPPlayState.wmppsStopped)
	{
		Console.WriteLine("Stop");
		Player.close();
	}
}
private void Player_MediaError(object pMediaObject)
{
	Console.WriteLine("Error");
	Player.close();
}