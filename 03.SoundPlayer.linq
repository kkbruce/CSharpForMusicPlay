<Query Kind="Program">
  <Namespace>System.Media</Namespace>
</Query>

void Main()
{
	var player = new SoundPlayer();
	player.SoundLocation = "http://billor.chsh.chc.edu.tw/sound/ambul.wav";
	player.LoadAsync();
	//player.Play();
	player.PlaySync();
	
	player.SoundLocation = "http://billor.chsh.chc.edu.tw/sound/bb.wav";
	player.Load();
	player.PlaySync();

	player.SoundLocation = "http://billor.chsh.chc.edu.tw/sound/ambul[1].wav";
	player.LoadAsync();
	player.PlaySync();

	player.SoundLocation = "http://billor.chsh.chc.edu.tw/sound/balarm.wav";
	player.Load();
	player.PlaySync();

	player.SoundLocation = "http://billor.chsh.chc.edu.tw/sound/alarm1.wav";
	player.LoadAsync();
	player.PlaySync();

	player.SoundLocation = "http://billor.chsh.chc.edu.tw/sound/dive.wav";
	player.Load();
	player.PlaySync();
}

// Define other methods and classes here